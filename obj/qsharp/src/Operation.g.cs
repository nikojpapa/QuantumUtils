#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Utils", "Toffoli (a : Qubit, b : Qubit, c : Qubit) : ()", new string[] { "Controlled", "Adjoint" }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs", 200L, 7L, 57L)]
[assembly: OperationDeclaration("Utils", "QubitOr (q1 : Qubit, q2 : Qubit, target : Qubit) : ()", new string[] { "Controlled", "Adjoint" }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs", 427L, 17L, 64L)]
[assembly: OperationDeclaration("Utils", "_InitQubit (index : Int, binaryRep : Int[], target : Qubit) : ()", new string[] { "Controlled", "Adjoint" }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs", 2003L, 64L, 75L)]
[assembly: OperationDeclaration("Utils", "SetQubits (register : Qubit[], binaryStr : Int[]) : ()", new string[] { "Controlled", "Adjoint" }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs", 2292L, 74L, 66L)]
[assembly: OperationDeclaration("Utils", "BinaryValue (index : Int, qubit : Qubit) : Int", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs", 2545L, 84L, 58L)]
[assembly: OperationDeclaration("Utils", "QubitsToInt (qubits : Qubit[]) : Int", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs", 2691L, 90L, 49L)]
[assembly: OperationDeclaration("Utils", "RunOnAllBinariesOfLength (length : Int, op : (Qubit[] => ())) : ()", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs", 3433L, 114L, 78L)]
[assembly: OperationDeclaration("Utils", "RunOnAllTwoBinariesOfLength (length : Int, op : ((Qubit[], Qubit[]) => ())) : ()", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs", 3973L, 132L, 92L)]
[assembly: OperationDeclaration("Utils", "PrintRegister (reg : Qubit[]) : ()", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs", 4781L, 156L, 47L)]
[assembly: FunctionDeclaration("Utils", "GenerateBinaries (allBinaries : Int[][], depth : Int) : Int[][]", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs", 664L, 29L, 14L)]
[assembly: FunctionDeclaration("Utils", "GenerateAllBinariesOfLength (length : Int) : Int[][]", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs", 1713L, 58L, 14L)]
[assembly: FunctionDeclaration("Utils", "IntToBinary (base10 : Int) : Int[]", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs", 3031L, 101L, 14L)]
#line hidden
namespace Utils
{
    public class Toffoli : Unitary<(Qubit,Qubit,Qubit)>, ICallable
    {
        public Toffoli(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Qubit,Qubit,Qubit)>, IApplyData
        {
            public In((Qubit,Qubit,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits
            {
                get
                {
                    yield return Data.Item1;
                    yield return Data.Item2;
                    yield return Data.Item3;
                }
            }
        }

        String ICallable.Name => "Toffoli";
        String ICallable.FullName => "Utils.Toffoli";
        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<(Qubit,Qubit,Qubit), QVoid> Body => (__in) =>
        {
            var (a,b,c) = __in;
#line 9 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs"
            MicrosoftQuantumPrimitiveX.Controlled.Apply((new QArray<Qubit>(a, b), c));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(Qubit,Qubit,Qubit), QVoid> AdjointBody => (__in) =>
        {
            var (a,b,c) = __in;
            MicrosoftQuantumPrimitiveX.Controlled.Adjoint.Apply((new QArray<Qubit>(a, b), c));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(Qubit,Qubit,Qubit)), QVoid> ControlledBody => (__in) =>
        {
            var (controlQubits,(a,b,c)) = __in;
            MicrosoftQuantumPrimitiveX.Controlled.Controlled.Apply((controlQubits, (new QArray<Qubit>(a, b), c)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(Qubit,Qubit,Qubit)), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (controlQubits,(a,b,c)) = __in;
            MicrosoftQuantumPrimitiveX.Controlled.Adjoint.Controlled.Apply((controlQubits, (new QArray<Qubit>(a, b), c)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn((Qubit,Qubit,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit a, Qubit b, Qubit c)
        {
            return __m__.Run<Toffoli, (Qubit,Qubit,Qubit), QVoid>((a, b, c));
        }
    }

    public class QubitOr : Unitary<(Qubit,Qubit,Qubit)>, ICallable
    {
        public QubitOr(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Qubit,Qubit,Qubit)>, IApplyData
        {
            public In((Qubit,Qubit,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits
            {
                get
                {
                    yield return Data.Item1;
                    yield return Data.Item2;
                    yield return Data.Item3;
                }
            }
        }

        String ICallable.Name => "QubitOr";
        String ICallable.FullName => "Utils.QubitOr";
        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumPrimitiveCNOT
        {
            get;
            set;
        }

        protected IUnitary<(Qubit,Qubit,Qubit)> Toffoli
        {
            get;
            set;
        }

        public override Func<(Qubit,Qubit,Qubit), QVoid> Body => (__in) =>
        {
            var (q1,q2,target) = __in;
#line 19 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs"
            MicrosoftQuantumPrimitiveCNOT.Apply((q1, target));
#line 20 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs"
            MicrosoftQuantumPrimitiveCNOT.Apply((q2, target));
#line 21 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs"
            Toffoli.Apply((q1, q2, target));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(Qubit,Qubit,Qubit), QVoid> AdjointBody => (__in) =>
        {
            var (q1,q2,target) = __in;
            Toffoli.Adjoint.Apply((q1, q2, target));
            MicrosoftQuantumPrimitiveCNOT.Adjoint.Apply((q2, target));
            MicrosoftQuantumPrimitiveCNOT.Adjoint.Apply((q1, target));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(Qubit,Qubit,Qubit)), QVoid> ControlledBody => (__in) =>
        {
            var (controlQubits,(q1,q2,target)) = __in;
            MicrosoftQuantumPrimitiveCNOT.Controlled.Apply((controlQubits, (q1, target)));
            MicrosoftQuantumPrimitiveCNOT.Controlled.Apply((controlQubits, (q2, target)));
            Toffoli.Controlled.Apply((controlQubits, (q1, q2, target)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(Qubit,Qubit,Qubit)), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (controlQubits,(q1,q2,target)) = __in;
            Toffoli.Adjoint.Controlled.Apply((controlQubits, (q1, q2, target)));
            MicrosoftQuantumPrimitiveCNOT.Adjoint.Controlled.Apply((controlQubits, (q2, target)));
            MicrosoftQuantumPrimitiveCNOT.Adjoint.Controlled.Apply((controlQubits, (q1, target)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumPrimitiveCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.CNOT));
            this.Toffoli = this.Factory.Get<IUnitary<(Qubit,Qubit,Qubit)>>(typeof(Utils.Toffoli));
        }

        public override IApplyData __dataIn((Qubit,Qubit,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit q1, Qubit q2, Qubit target)
        {
            return __m__.Run<QubitOr, (Qubit,Qubit,Qubit), QVoid>((q1, q2, target));
        }
    }

    public class GenerateBinaries : Operation<(QArray<QArray<Int64>>,Int64), QArray<QArray<Int64>>>, ICallable
    {
        public GenerateBinaries(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<QArray<Int64>>,Int64)>, IApplyData
        {
            public In((QArray<QArray<Int64>>,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "GenerateBinaries";
        String ICallable.FullName => "Utils.GenerateBinaries";
        public override Func<(QArray<QArray<Int64>>,Int64), QArray<QArray<Int64>>> Body => (__in) =>
        {
            var (allBinaries,depth) = __in;
#line 30 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs"
            var numBinaries = allBinaries.Count;
#line 31 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs"
            var lastBinary = allBinaries[(numBinaries - 1L)];
#line 32 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs"
            var binaryLength = lastBinary.Count;
#line 33 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs"
            var newBinaryPosition = numBinaries;
#line 35 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs"
            if ((depth > (binaryLength - 1L)))
            {
#line 36 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs"
                return allBinaries;
            }

#line 39 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs"
            var newBinary = new QArray<Int64>(binaryLength);
#line 40 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs"
            foreach (var base10 in new Range(0L, (binaryLength - 1L)))
            {
#line 41 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs"
                newBinary[base10] = lastBinary[base10];
            }

#line 44 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs"
            var binariesFromZero = ((ICallable)this).Apply<QArray<QArray<Int64>>>((allBinaries, (depth + 1L)));
#line 46 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs"
            newBinary[depth] = 1L;
#line 47 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs"
            var newAllBinaries2 = new QArray<QArray<Int64>>((binariesFromZero.Count + 1L));
#line 48 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs"
            foreach (var base10 in new Range(0L, (binariesFromZero.Count - 1L)))
            {
#line 49 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs"
                newAllBinaries2[base10] = binariesFromZero[base10];
            }

#line 51 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs"
            newAllBinaries2[binariesFromZero.Count] = newBinary;
#line 53 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs"
            var binariesFromOne = ((ICallable)this).Apply<QArray<QArray<Int64>>>((newAllBinaries2, (depth + 1L)));
#line 55 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs"
            return binariesFromOne;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((QArray<QArray<Int64>>,Int64) data) => new In(data);
        public override IApplyData __dataOut(QArray<QArray<Int64>> data) => data;
        public static System.Threading.Tasks.Task<QArray<QArray<Int64>>> Run(IOperationFactory __m__, QArray<QArray<Int64>> allBinaries, Int64 depth)
        {
            return __m__.Run<GenerateBinaries, (QArray<QArray<Int64>>,Int64), QArray<QArray<Int64>>>((allBinaries, depth));
        }
    }

    public class GenerateAllBinariesOfLength : Operation<Int64, QArray<QArray<Int64>>>, ICallable
    {
        public GenerateAllBinariesOfLength(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "GenerateAllBinariesOfLength";
        String ICallable.FullName => "Utils.GenerateAllBinariesOfLength";
        protected ICallable<(QArray<QArray<Int64>>,Int64), QArray<QArray<Int64>>> GenerateBinaries
        {
            get;
            set;
        }

        public override Func<Int64, QArray<QArray<Int64>>> Body => (__in) =>
        {
            var length = __in;
#line 59 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs"
            var initialBinaries = new QArray<QArray<Int64>>(1L);
#line 60 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs"
            initialBinaries[0L] = new QArray<Int64>(length);
#line 61 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs"
            return GenerateBinaries.Apply((initialBinaries, 0L));
        }

        ;
        public override void Init()
        {
            this.GenerateBinaries = this.Factory.Get<ICallable<(QArray<QArray<Int64>>,Int64), QArray<QArray<Int64>>>>(typeof(Utils.GenerateBinaries));
        }

        public override IApplyData __dataIn(Int64 data) => new QTuple<Int64>(data);
        public override IApplyData __dataOut(QArray<QArray<Int64>> data) => data;
        public static System.Threading.Tasks.Task<QArray<QArray<Int64>>> Run(IOperationFactory __m__, Int64 length)
        {
            return __m__.Run<GenerateAllBinariesOfLength, Int64, QArray<QArray<Int64>>>(length);
        }
    }

    public class _InitQubit : Unitary<(Int64,QArray<Int64>,Qubit)>, ICallable
    {
        public _InitQubit(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,QArray<Int64>,Qubit)>, IApplyData
        {
            public In((Int64,QArray<Int64>,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits
            {
                get
                {
                    yield return Data.Item3;
                }
            }
        }

        String ICallable.Name => "_InitQubit";
        String ICallable.FullName => "Utils._InitQubit";
        protected IUnitary MicrosoftQuantumCanonApplyIfCA
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<(Int64,QArray<Int64>,Qubit), QVoid> Body => (__in) =>
        {
            var (index,binaryRep,target) = __in;
#line 66 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs"
            MicrosoftQuantumCanonApplyIfCA.Apply((((IUnitary)MicrosoftQuantumPrimitiveX), ((index <= (binaryRep.Count - 1L)) && (binaryRep[index] == 1L)), target));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(Int64,QArray<Int64>,Qubit), QVoid> AdjointBody => (__in) =>
        {
            var (index,binaryRep,target) = __in;
            MicrosoftQuantumCanonApplyIfCA.Adjoint.Apply((((IUnitary)MicrosoftQuantumPrimitiveX), ((index <= (binaryRep.Count - 1L)) && (binaryRep[index] == 1L)), target));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(Int64,QArray<Int64>,Qubit)), QVoid> ControlledBody => (__in) =>
        {
            var (controlQubits,(index,binaryRep,target)) = __in;
            MicrosoftQuantumCanonApplyIfCA.Controlled.Apply((controlQubits, (((IUnitary)MicrosoftQuantumPrimitiveX), ((index <= (binaryRep.Count - 1L)) && (binaryRep[index] == 1L)), target)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(Int64,QArray<Int64>,Qubit)), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (controlQubits,(index,binaryRep,target)) = __in;
            MicrosoftQuantumCanonApplyIfCA.Adjoint.Controlled.Apply((controlQubits, (((IUnitary)MicrosoftQuantumPrimitiveX), ((index <= (binaryRep.Count - 1L)) && (binaryRep[index] == 1L)), target)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonApplyIfCA = this.Factory.Get<IUnitary>(typeof(Microsoft.Quantum.Canon.ApplyIfCA<>));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn((Int64,QArray<Int64>,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Int64 index, QArray<Int64> binaryRep, Qubit target)
        {
            return __m__.Run<_InitQubit, (Int64,QArray<Int64>,Qubit), QVoid>((index, binaryRep, target));
        }
    }

    public class SetQubits : Unitary<(QArray<Qubit>,QArray<Int64>)>, ICallable
    {
        public SetQubits(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,QArray<Int64>)>, IApplyData
        {
            public In((QArray<Qubit>,QArray<Int64>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item1)?.Qubits;
        }

        String ICallable.Name => "SetQubits";
        String ICallable.FullName => "Utils.SetQubits";
        protected IUnitary MicrosoftQuantumCanonApplyToEachIndexCA
        {
            get;
            set;
        }

        protected IUnitary<(Int64,QArray<Int64>,Qubit)> _InitQubit
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,QArray<Int64>), QVoid> Body => (__in) =>
        {
            var (register,binaryStr) = __in;
#line 76 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs"
            MicrosoftQuantumCanonApplyToEachIndexCA.Apply((((IUnitary)_InitQubit.Partial(new Func<(Int64,Qubit), (Int64,QArray<Int64>,Qubit)>((_arg1) => (_arg1.Item1, binaryStr, _arg1.Item2)))), register));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,QArray<Int64>), QVoid> AdjointBody => (__in) =>
        {
            var (register,binaryStr) = __in;
            MicrosoftQuantumCanonApplyToEachIndexCA.Adjoint.Apply((((IUnitary)_InitQubit.Partial(new Func<(Int64,Qubit), (Int64,QArray<Int64>,Qubit)>((_arg1) => (_arg1.Item1, binaryStr, _arg1.Item2)))), register));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Qubit>,QArray<Int64>)), QVoid> ControlledBody => (__in) =>
        {
            var (controlQubits,(register,binaryStr)) = __in;
            MicrosoftQuantumCanonApplyToEachIndexCA.Controlled.Apply((controlQubits, (((IUnitary)_InitQubit.Partial(new Func<(Int64,Qubit), (Int64,QArray<Int64>,Qubit)>((_arg1) => (_arg1.Item1, binaryStr, _arg1.Item2)))), register)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Qubit>,QArray<Int64>)), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (controlQubits,(register,binaryStr)) = __in;
            MicrosoftQuantumCanonApplyToEachIndexCA.Adjoint.Controlled.Apply((controlQubits, (((IUnitary)_InitQubit.Partial(new Func<(Int64,Qubit), (Int64,QArray<Int64>,Qubit)>((_arg1) => (_arg1.Item1, binaryStr, _arg1.Item2)))), register)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonApplyToEachIndexCA = this.Factory.Get<IUnitary>(typeof(Microsoft.Quantum.Canon.ApplyToEachIndexCA<>));
            this._InitQubit = this.Factory.Get<IUnitary<(Int64,QArray<Int64>,Qubit)>>(typeof(Utils._InitQubit));
        }

        public override IApplyData __dataIn((QArray<Qubit>,QArray<Int64>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> register, QArray<Int64> binaryStr)
        {
            return __m__.Run<SetQubits, (QArray<Qubit>,QArray<Int64>), QVoid>((register, binaryStr));
        }
    }

    public class BinaryValue : Operation<(Int64,Qubit), Int64>, ICallable
    {
        public BinaryValue(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Qubit)>, IApplyData
        {
            public In((Int64,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits
            {
                get
                {
                    yield return Data.Item2;
                }
            }
        }

        String ICallable.Name => "BinaryValue";
        String ICallable.FullName => "Utils.BinaryValue";
        protected ICallable<Qubit, Result> M
        {
            get;
            set;
        }

        protected ICallable<QArray<Result>, Int64> MicrosoftQuantumCanonResultAsInt
        {
            get;
            set;
        }

        public override Func<(Int64,Qubit), Int64> Body => (__in) =>
        {
            var (index,qubit) = __in;
#line 86 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs"
            return (2L.Pow(index) * MicrosoftQuantumCanonResultAsInt.Apply(new QArray<Result>()
            {M.Apply(qubit)}));
        }

        ;
        public override void Init()
        {
            this.M = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
            this.MicrosoftQuantumCanonResultAsInt = this.Factory.Get<ICallable<QArray<Result>, Int64>>(typeof(Microsoft.Quantum.Canon.ResultAsInt));
        }

        public override IApplyData __dataIn((Int64,Qubit) data) => new In(data);
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, Int64 index, Qubit qubit)
        {
            return __m__.Run<BinaryValue, (Int64,Qubit), Int64>((index, qubit));
        }
    }

    public class QubitsToInt : Operation<QArray<Qubit>, Int64>, ICallable
    {
        public QubitsToInt(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "QubitsToInt";
        String ICallable.FullName => "Utils.QubitsToInt";
        protected ICallable<(Int64,Qubit), Int64> BinaryValue
        {
            get;
            set;
        }

        public override Func<QArray<Qubit>, Int64> Body => (__in) =>
        {
            var qubits = __in;
#line 92 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs"
            var sum = 0L;
#line 93 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs"
            var lastIndex = (qubits.Count - 1L);
#line 94 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs"
            foreach (var j in new Range(0L, lastIndex))
            {
#line 95 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs"
                sum = (sum + BinaryValue.Apply((j, qubits[(lastIndex - j)])));
            }

#line 97 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs"
            return sum;
        }

        ;
        public override void Init()
        {
            this.BinaryValue = this.Factory.Get<ICallable<(Int64,Qubit), Int64>>(typeof(Utils.BinaryValue));
        }

        public override IApplyData __dataIn(QArray<Qubit> data) => data;
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, QArray<Qubit> qubits)
        {
            return __m__.Run<QubitsToInt, QArray<Qubit>, Int64>(qubits);
        }
    }

    public class IntToBinary : Operation<Int64, QArray<Int64>>, ICallable
    {
        public IntToBinary(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "IntToBinary";
        String ICallable.FullName => "Utils.IntToBinary";
        public override Func<Int64, QArray<Int64>> Body => (__in) =>
        {
            var base10 = __in;
#line 102 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs"
            var base10Mut = base10;
#line 103 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs"
            var binary = new QArray<Int64>(0L);
#line 104 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs"
            while (true)
            {
#line 105 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs"
                binary = (new QArray<Int64>()
                {(base10Mut % 2L)} + binary);
#line 106 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs"
                base10Mut = (base10Mut / 2L);
                if ((base10Mut <= 0L))
                {
                    break;
                }
                else
                {
                }
            }

#line 111 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs"
            return binary;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn(Int64 data) => new QTuple<Int64>(data);
        public override IApplyData __dataOut(QArray<Int64> data) => data;
        public static System.Threading.Tasks.Task<QArray<Int64>> Run(IOperationFactory __m__, Int64 base10)
        {
            return __m__.Run<IntToBinary, Int64, QArray<Int64>>(base10);
        }
    }

    public class RunOnAllBinariesOfLength : Operation<(Int64,ICallable), QVoid>, ICallable
    {
        public RunOnAllBinariesOfLength(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,ICallable)>, IApplyData
        {
            public In((Int64,ICallable) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item2)?.Qubits;
        }

        String ICallable.Name => "RunOnAllBinariesOfLength";
        String ICallable.FullName => "Utils.RunOnAllBinariesOfLength";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected ICallable<Int64, QArray<QArray<Int64>>> GenerateAllBinariesOfLength
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected ICallable<QArray<Qubit>, QVoid> ResetAll
        {
            get;
            set;
        }

        protected IUnitary<(QArray<Qubit>,QArray<Int64>)> SetQubits
        {
            get;
            set;
        }

        public override Func<(Int64,ICallable), QVoid> Body => (__in) =>
        {
            var (length,op) = __in;
#line 116 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs"
            var binaries = GenerateAllBinariesOfLength.Apply(length);
#line 118 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs"
            var qubits = Allocate.Apply(length);
#line 119 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs"
            foreach (var base10 in new Range(0L, (binaries.Count - 1L)))
            {
#line 120 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs"
                var binaryStr = binaries[base10];
#line 122 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs"
                SetQubits.Apply((qubits, binaryStr));
#line 124 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs"
                op.Apply(qubits);
#line 126 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs"
                ResetAll.Apply(qubits);
            }

#line hidden
            Release.Apply(qubits);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.GenerateAllBinariesOfLength = this.Factory.Get<ICallable<Int64, QArray<QArray<Int64>>>>(typeof(Utils.GenerateAllBinariesOfLength));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
            this.SetQubits = this.Factory.Get<IUnitary<(QArray<Qubit>,QArray<Int64>)>>(typeof(Utils.SetQubits));
        }

        public override IApplyData __dataIn((Int64,ICallable) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Int64 length, ICallable op)
        {
            return __m__.Run<RunOnAllBinariesOfLength, (Int64,ICallable), QVoid>((length, op));
        }
    }

    public class RunOnAllTwoBinariesOfLength : Operation<(Int64,ICallable), QVoid>, ICallable
    {
        public RunOnAllTwoBinariesOfLength(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,ICallable)>, IApplyData
        {
            public In((Int64,ICallable) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item2)?.Qubits;
        }

        String ICallable.Name => "RunOnAllTwoBinariesOfLength";
        String ICallable.FullName => "Utils.RunOnAllTwoBinariesOfLength";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected ICallable<Int64, QArray<QArray<Int64>>> GenerateAllBinariesOfLength
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected ICallable<QArray<Qubit>, QVoid> ResetAll
        {
            get;
            set;
        }

        protected IUnitary<(QArray<Qubit>,QArray<Int64>)> SetQubits
        {
            get;
            set;
        }

        public override Func<(Int64,ICallable), QVoid> Body => (__in) =>
        {
            var (length,op) = __in;
#line 134 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs"
            var binaries = GenerateAllBinariesOfLength.Apply(length);
#line 136 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs"
            var qubits = Allocate.Apply((length * 2L));
#line 137 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs"
            foreach (var base10 in new Range(0L, (binaries.Count - 1L)))
            {
#line 138 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs"
                foreach (var j in new Range(0L, (binaries.Count - 1L)))
                {
#line 139 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs"
                    var binaryA = binaries[base10];
#line 140 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs"
                    var binaryB = binaries[j];
#line 141 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs"
                    var a = qubits?.Slice(new Range(0L, (length - 1L)));
#line 142 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs"
                    var b = qubits?.Slice(new Range(length, ((length * 2L) - 1L)));
#line 144 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs"
                    SetQubits.Apply((a, binaryA));
#line 145 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs"
                    SetQubits.Apply((b, binaryB));
#line 147 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs"
                    op.Apply((a, b));
#line 149 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs"
                    ResetAll.Apply(qubits);
                }
            }

#line hidden
            Release.Apply(qubits);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.GenerateAllBinariesOfLength = this.Factory.Get<ICallable<Int64, QArray<QArray<Int64>>>>(typeof(Utils.GenerateAllBinariesOfLength));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
            this.SetQubits = this.Factory.Get<IUnitary<(QArray<Qubit>,QArray<Int64>)>>(typeof(Utils.SetQubits));
        }

        public override IApplyData __dataIn((Int64,ICallable) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Int64 length, ICallable op)
        {
            return __m__.Run<RunOnAllTwoBinariesOfLength, (Int64,ICallable), QVoid>((length, op));
        }
    }

    public class PrintRegister : Operation<QArray<Qubit>, QVoid>, ICallable
    {
        public PrintRegister(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "PrintRegister";
        String ICallable.FullName => "Utils.PrintRegister";
        protected ICallable<Qubit, Result> M
        {
            get;
            set;
        }

        protected ICallable<QArray<Result>, Int64> MicrosoftQuantumCanonResultAsInt
        {
            get;
            set;
        }

        protected ICallable<Int64, String> MicrosoftQuantumExtensionsConvertToStringI
        {
            get;
            set;
        }

        public override Func<QArray<Qubit>, QVoid> Body => (__in) =>
        {
            var reg = __in;
#line 158 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs"
            var str = "";
#line 159 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs"
            foreach (var base10 in new Range(0L, (reg.Count - 1L)))
            {
#line 160 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs"
                str = (str + MicrosoftQuantumExtensionsConvertToStringI.Apply(MicrosoftQuantumCanonResultAsInt.Apply(new QArray<Result>()
                {M.Apply(reg[base10])})));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.M = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
            this.MicrosoftQuantumCanonResultAsInt = this.Factory.Get<ICallable<QArray<Result>, Int64>>(typeof(Microsoft.Quantum.Canon.ResultAsInt));
            this.MicrosoftQuantumExtensionsConvertToStringI = this.Factory.Get<ICallable<Int64, String>>(typeof(Microsoft.Quantum.Extensions.Convert.ToStringI));
        }

        public override IApplyData __dataIn(QArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> reg)
        {
            return __m__.Run<PrintRegister, QArray<Qubit>, QVoid>(reg);
        }
    }
}