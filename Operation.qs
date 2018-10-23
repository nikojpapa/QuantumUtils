namespace Utils
{
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Primitive;

    operation Toffoli(a: Qubit, b: Qubit, c: Qubit): () {
        body {
            (Controlled X)([a; b], c);
        }

        adjoint auto;
        controlled auto;
        controlled adjoint auto;
    }

    operation QubitOr(q1: Qubit, q2: Qubit, target: Qubit): () {
        body {
            CNOT(q1, target);
            CNOT(q2, target);
            Toffoli(q1, q2, target);
        } 
    }

    function GenerateBinaries(allBinaries: Int[][], depth: Int): Int[][] {
        let numBinaries = Length(allBinaries);
        let lastBinary = allBinaries[numBinaries - 1];
        let binaryLength = Length(lastBinary);
        let newBinaryPosition = numBinaries;

        if (depth > binaryLength - 1) {
            return allBinaries;
        }

        mutable newBinary = new Int[binaryLength];
        for (i in 0..binaryLength - 1) {
            set newBinary[i] = lastBinary[i];
        }

        let binariesFromZero = GenerateBinaries(allBinaries, depth + 1);

        set newBinary[depth] = 1;
        mutable newAllBinaries2 = new Int[][Length(binariesFromZero) + 1];
        for (i in 0..Length(binariesFromZero) - 1) {
            set newAllBinaries2[i] = binariesFromZero[i];
        }
        set newAllBinaries2[Length(binariesFromZero)] = newBinary;

        let binariesFromOne = GenerateBinaries(newAllBinaries2, depth + 1);

        return binariesFromOne;
    }

    function GenerateAllBinariesOfLength(length: Int): Int[][] {
        mutable initialBinaries = new Int[][1];
        set initialBinaries[0] = new Int[length];
        return GenerateBinaries(initialBinaries, 0);
    }

    function NumIsOne(num: Int): Bool {
        return num == 1;
    }

    operation InitQubit(index: Int, binaryRep: Int[], target: Qubit): () {
        body {
            ApplyIf(X, NumIsOne(binaryRep[index]), target);        
        }
    }

    operation SetQubits(register: Qubit[], binary: Int[]): () {
        body {
            ApplyToEachIndex(InitQubit(_, binary, _), register);
        }
    }

    operation BinaryValue(index: Int, qubit: Qubit): Int {
        body {
            return (2 ^ index) * ResultAsInt([M(qubit)]);
        }
    }

    operation QubitsToInt(qubits: Qubit[]): Int {
        body {
            mutable sum = 0;
            let lastIndex = Length(qubits) - 1;
            for (j in 0..lastIndex) {
                set sum = sum + BinaryValue(j, qubits[lastIndex - j]);
            }
            return sum;
        }
    }
}
