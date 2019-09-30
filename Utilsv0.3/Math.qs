namespace Utils.Math {
    open Microsoft.Quantum.Extensions.Math;
    open Microsoft.Quantum.Arithmetic;
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Intrinsic;

    function CeilLogBase2(x: Double): Int {
        return Ceiling( Log(x) / Log(2.0) );
    }
    
    function ClassicalSum (arr: Int[]): Int {
        mutable sum = 0;
        for (i in 0..Length(arr) - 1) {
            set sum = sum + arr[i];
        }

        return sum;
    }

    operation QFTAdder(start: Qubit[], amount: Qubit[]): Unit {
        body (...) {
            let bigEndian = BigEndian(start);

            QFT(bigEndian);

            for (i in Length(amount) - 1..-1..0) {
                let add = 2 ^ (Length(amount) - 1 - i);
                ApplyToEachIndexCA((Controlled R1Frac)([amount[i]], (add, _, _)), start);
            }

            (Adjoint QFT)(bigEndian);
        }

        adjoint invert;
        controlled distribute;
        controlled adjoint distribute;
    }

    operation QFTAdderInt(start: Qubit[], amount: Int): Unit {
        body (...) {
            let bigEndian = BigEndian(start);

            QFT(bigEndian);
            ApplyToEachIndexCA(R1Frac(amount, _, _), start);
            (Adjoint QFT)(bigEndian);
        }

        adjoint invert;
        controlled distribute;
        controlled adjoint distribute;
    }

    operation QFTSubtractor(start: Qubit[], amount: Int): Unit {
        body (...) {
            mutable bigEndian = BigEndian(start);

            QFT(bigEndian);
            ApplyToEachIndexCA(R1Frac(-amount, _, _), start);
            (Adjoint QFT)(bigEndian);
        }

        adjoint invert;
        controlled distribute;
        controlled adjoint distribute;
    }

    operation _SubtractBit(t1: Qubit, t2: Qubit, borrowIn: Qubit, borrowOut: Qubit): Unit {
        body (...) {
            Assert([PauliZ], [borrowOut], Zero, "Borrow out is not in |0> state");

            X(t1);
            Controlled X([t1, t2], borrowOut);
            Controlled X([t1, borrowIn], borrowOut);
            Controlled X([t2, borrowIn], borrowOut);
            X(t1);

            ApplyToEachCA(CNOT(_, t1), [t2, borrowIn]);
        }

        adjoint invert;
        controlled distribute;
        controlled adjoint distribute;
    }

    operation BitSubtractor(start: Qubit[], amount: Qubit[], borrows: Qubit[]): Unit {
        body (...) {
            AssertBoolEqual(Length(start) >= Length(amount), true, $"unequal operand lengths");
            AssertIntEqual(Length(start) + 1, Length(borrows), $"not right amount of borrows");

            using(padding = Qubit[1]) {
                for (j in Length(start) - 1..-1..0) {
                    let sop = _SubtractBit(start[j], _, borrows[j+1], borrows[j]);
                    if (j >= Length(start) - Length(amount)) {
                        sop(amount[j - Length(start) + Length(amount)]);
                    } else {
                        sop(padding[0]);
                    }
                }
            }

        }

        adjoint invert;
        controlled distribute;
        controlled adjoint distribute;
    }
}
