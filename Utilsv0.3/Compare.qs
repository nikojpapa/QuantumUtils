namespace Utils.Compare {
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;
    open Utils.General;
    open Utils.Math;
    open Utils.Testing;

    operation XIfAllZero(a: Qubit[], target: Qubit): Unit {
        body (...) {
            ApplyToEachCA(X, a);
            Controlled X(a, target);
            ApplyToEachCA(X, a);
        }

        adjoint invert;
        controlled distribute;
        controlled adjoint distribute;
    }

    operation XIfEqual(a: Qubit[], b: Qubit[], target: Qubit): Unit {
        body (...) {
            let lenA = Length(a);
            let lenB = Length(b);

            if (lenA <= lenB) {
                for (i in 0..lenA - 1) {
                    CNOT(a[i], b[i]);
                }

                XIfAllZero(b, target);

                for (i in lenA - 1..-1..0) {
                    CNOT(a[i], b[i]);
                }
            } else {
                for (i in 0..lenB - 1) {
                    CNOT(b[i], a[i]);
                }

                XIfAllZero(a, target);

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
            using (bQubit = Qubit[Length(a)]) {
                QFTAdderInt(bQubit, b);
                XIfEqual(a, bQubit, target);
                Adjoint QFTAdderInt(bQubit, b);
            }
        }

        adjoint invert;
        controlled distribute;
        controlled adjoint distribute;
    }
    operation _TestXIfQubitEqualToIntImpl(a: Qubit[], length: Int): Unit {
        let aVal = QubitsToInt(a);
        let maxA = 2 ^ Length(a) - 1;

        for (b in 0..maxA) {
            using(qubits = Qubit[1]) {
                XIfQubitEqualToInt(a, b, qubits[0]);

                let calcAns = BoolFromResult(M(qubits[0]));
                let trueAns = aVal == b;
                AssertBoolEqual(calcAns, trueAns, $"{aVal} ?= {b}; calcAns: {calcAns}, trueAns: {trueAns}");
                Message($"{aVal} ?= {b} passed");
                ResetAll(qubits);
            }
        }
    }
    operation _TestXIfQubitEqualToInt(length: Int): Unit {
        RunOnAllBinariesOfLength(length, _TestXIfQubitEqualToIntImpl(_, length));
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
    
    operation XIfLessThanOrEqual(a: Qubit[], b: Qubit[], target: Qubit): Unit {
        body (...) {
            using(qubits = Qubit[Length(a) + 2]) {
                let borrows = Most(qubits);
                let zeroTest = Tail(qubits);
                BitSubtractor(a, b, borrows);

                XIfAllZero(a, zeroTest);

                let indicator = Head(borrows);
                QubitOr(indicator, zeroTest, target);

                XIfAllZero(a, zeroTest);

                (Adjoint BitSubtractor)(a, b, borrows);
            }
        }

        adjoint auto;
        controlled auto;
        controlled adjoint auto;
    }
}
