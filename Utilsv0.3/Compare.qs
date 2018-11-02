namespace Utils.Compare {
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;
    open Utils.Math;

    operation XIfEqual(a: Qubit[], b: Qubit[], target: Qubit): Unit {
        body (...) {
            let lenA = Length(a);
            let lenB = Length(b);

            if (lenA <= lenB) {
                for (i in 0..lenA - 1) {
                    CNOT(a[i], b[i]);
                }

                ApplyToEachCA(X, b);
                Controlled X(b, target);
                ApplyToEachCA(X, b);

                for (i in lenA - 1..-1..0) {
                    CNOT(a[i], b[i]);
                }
            } else {
                for (i in 0..lenB - 1) {
                    CNOT(b[i], a[i]);
                }

                ApplyToEachCA(X, a);
                Controlled X(a, target);
                ApplyToEachCA(X, a);

                for (i in lenB - 1..-1..0) {
                    CNOT(b[i], a[i]);
                }
            }

        }

        adjoint invert;
        controlled distribute;
        controlled adjoint distribute;
    }

    operation XIfQubitEqualToInt(a: Qubit[], b: Int, target: Qubit): Unit {
        body (...) {
            using (bQubit = Qubit[Length(a) + 1]) {
                QFTAdderInt(bQubit, b);
                XIfEqual(a, bQubit, target);
                Adjoint QFTAdderInt(bQubit, b);
            }
        }

        adjoint invert;
        controlled distribute;
        controlled adjoint distribute;
    }

    operation XIfLessThan(a: Qubit[], b: Qubit[], target: Qubit): Unit {
        body (...) {
            using(borrows = Qubit[Length(a) + 1]) {
                BitSubtractor(a, b, borrows);

                let indicator = Head(borrows);
                CNOT(indicator, target);

                Adjoint BitSubtractor(a, b, borrows);
            }
        }

        adjoint invert;
        controlled distribute;
        controlled adjoint distribute;
    }

}
