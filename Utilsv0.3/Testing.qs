namespace Utils.Testing {
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;
    open Utils.General;
    
    
    operation SetQubits (register : Qubit[], binaryStr : Int[]) : Unit {
        
        body (...) {
            ApplyToEachIndexCA(_InitQubit(_, binaryStr, _), register);
        }
        
        adjoint invert;
        controlled distribute;
        controlled adjoint distribute;
    }

    function _GenerateBinaries (allBinaries : Int[][], depth : Int) : Int[][] {
        
        let numBinaries = Length(allBinaries);
        let lastBinary = allBinaries[numBinaries - 1];
        let binaryLength = Length(lastBinary);
        let newBinaryPosition = numBinaries;
        
        if (depth > binaryLength - 1) {
            return allBinaries;
        }
        
        mutable newBinary = new Int[binaryLength];
        
        for (base10 in 0 .. binaryLength - 1) {
            set newBinary[base10] = lastBinary[base10];
        }
        
        let binariesFromZero = _GenerateBinaries(allBinaries, depth + 1);
        set newBinary[depth] = 1;
        mutable newAllBinaries2 = new Int[][Length(binariesFromZero) + 1];
        
        for (base10 in 0 .. Length(binariesFromZero) - 1) {
            set newAllBinaries2[base10] = binariesFromZero[base10];
        }
        
        set newAllBinaries2[Length(binariesFromZero)] = newBinary;
        let binariesFromOne = _GenerateBinaries(newAllBinaries2, depth + 1);
        return binariesFromOne;
    }
    
    
    function GenerateAllBinariesOfLength (length : Int) : Int[][] {
        
        mutable initialBinaries = new Int[][1];
        set initialBinaries[0] = new Int[length];
        return _GenerateBinaries(initialBinaries, 0);
    }
    
    
    operation RunOnAllBinariesOfLength (length : Int, op : (Qubit[] => Unit)) : Unit {
        
        let binaries = GenerateAllBinariesOfLength(length);
        
        using (qubits = Qubit[length]) {
            
            for (base10 in 0 .. Length(binaries) - 1) {
                let binaryStr = binaries[base10];
                SetQubits(qubits, binaryStr);
                op(qubits);
                ResetAll(qubits);
            }
        }
    }
    
    
    operation RunOnAllTwoBinariesOfLength (length : Int, op : ((Qubit[], Qubit[]) => Unit)) : Unit {
        
        let binaries = GenerateAllBinariesOfLength(length);
        
        using (qubits = Qubit[length * 2]) {
            
            for (base10 in 0 .. Length(binaries) - 1) {
                
                for (j in 0 .. Length(binaries) - 1) {
                    let binaryA = binaries[base10];
                    let binaryB = binaries[j];
                    let a = qubits[0 .. length - 1];
                    let b = qubits[length .. length * 2 - 1];
                    SetQubits(a, binaryA);
                    SetQubits(b, binaryB);
                    op(a, b);
                    ResetAll(qubits);
                }
            }
        }
    }

}
