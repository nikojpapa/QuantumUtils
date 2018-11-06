namespace Utils.General {
    
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Extensions.Convert;
    open Microsoft.Quantum.Extensions.Testing;
    open Microsoft.Quantum.Primitive;


    function ConcatArrays<'T> (arrays: 'T[][]): 'T[] {
        mutable retArr = new 'T[0];
        for (i in 0..Length(arrays) - 1) {
            set retArr = retArr + arrays[i];
        }

        return retArr;
    } 
    
    operation CopyQubits (from : Qubit[], to : Qubit[]) : Unit {
        
        body (...) {
            let fromLength = Length(from);
            let toLength = Length(to);
            AssertBoolEqual(fromLength <= toLength, true, $"TO register (length {toLength}) must be able to contain FROM register (length {fromLength})");
            
            // AssertAllZero(to);
            SwapReverseRegister(from);
            SwapReverseRegister(to);
            
            for (i in 0 .. fromLength - 1) {
                CNOT(from[i], to[i]);
            }
            
            SwapReverseRegister(to);
            SwapReverseRegister(from);
        }
        
        adjoint invert;
        controlled distribute;
        controlled adjoint distribute;
    }
    
    
    operation QubitOr (q1 : Qubit, q2 : Qubit, target : Qubit) : Unit {
        
        body (...) {
            CNOT(q1, target);
            CNOT(q2, target);
            Controlled X([q1, q2], target);
        }
        
        adjoint invert;
        controlled distribute;
        controlled adjoint distribute;
    }
    
    
    operation _InitQubit (index : Int, binaryRep : Int[], target : Qubit) : Unit {
        
        body (...) {
            ApplyIfCA(X, index <= Length(binaryRep) - 1 && binaryRep[index] == 1, target);
        }
        
        adjoint invert;
        controlled distribute;
        controlled adjoint distribute;
    }
    
    
    operation BinaryValue (index : Int, qubit : Qubit) : Int {
        
        return 2 ^ index * ResultAsInt([M(qubit)]);
    }
    
    
    // Like MeasureIntegerBE, but does not set register to 0
    operation QubitsToInt (qubits : Qubit[]) : Int {
        
        mutable sum = 0;
        let lastIndex = Length(qubits) - 1;
        
        for (j in 0 .. lastIndex) {
            set sum = sum + BinaryValue(j, qubits[lastIndex - j]);
        }
        
        return sum;
    }
    
    
    function IntToBinary (base10 : Int) : Int[] {
        
        mutable base10Mut = base10;
        mutable binary = new Int[0];
        
        repeat {
            set binary = [base10Mut % 2] + binary;
            set base10Mut = base10Mut / 2;
        }
        until (base10Mut <= 0)
        fixup {
        }
        
        return binary;
    }
    
    
    operation RegisterToString (reg : Qubit[]) : String {
        
        mutable str = "";
        
        for (i in 0 .. Length(reg) - 1) {
            set str = str + ToStringI(ResultAsInt([M(reg[i])]));
        }

        return str;
    }
    
    operation IntArrrayToString (arr : Int[]) : String {
        
        mutable str = "[";
        
        for (i in 0 .. Length(arr) - 1) {
            set str = str + ToStringI(arr[i]) + ", ";
        }
        set str = str + "]";

        return str;
    }
    
}


