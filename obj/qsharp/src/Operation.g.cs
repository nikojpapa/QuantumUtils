#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Utils", "Toffoli (a : Qubit, b : Qubit, c : Qubit) : ()", new string[] { "Controlled", "Adjoint" }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs", 200L, 7L, 57L)]
[assembly: OperationDeclaration("Utils", "QubitOr (q1 : Qubit, q2 : Qubit, target : Qubit) : ()", new string[] { "Controlled", "Adjoint" }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs", 427L, 17L, 64L)]
[assembly: OperationDeclaration("Utils", "InitQubit (index : Int, binaryRep : Int[], target : Qubit) : ()", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs", 2048L, 68L, 74L)]
[assembly: OperationDeclaration("Utils", "SetQubits (register : Qubit[], binary : Int[]) : ()", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs", 2218L, 74L, 63L)]
[assembly: OperationDeclaration("Utils", "BinaryValue (index : Int, qubit : Qubit) : Int", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs", 2380L, 80L, 58L)]
[assembly: OperationDeclaration("Utils", "QubitsToInt (qubits : Qubit[]) : Int", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs", 2526L, 86L, 49L)]
[assembly: OperationDeclaration("Utils", "RunOnAllTwoBinariesOfLength (length : Int, op : ((Qubit[], Qubit[]) => ())) : ()", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs", 2886L, 97L, 92L)]
[assembly: OperationDeclaration("Utils", "PrintRegister (reg : Qubit[]) : ()", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs", 3684L, 121L, 47L)]
[assembly: FunctionDeclaration("Utils", "GenerateBinaries (allBinaries : Int[][], depth : Int) : Int[][]", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs", 664L, 29L, 14L)]
[assembly: FunctionDeclaration("Utils", "GenerateAllBinariesOfLength (length : Int) : Int[][]", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs", 1683L, 58L, 14L)]
[assembly: FunctionDeclaration("Utils", "NumIsOne (num : Int) : Bool", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs", 1912L, 64L, 14L)]
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
            foreach (var i in new Range(0L, (binaryLength - 1L)))
            {
#line 41 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs"
                newBinary[i] = lastBinary[i];
            }

#line 44 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs"
            var binariesFromZero = ((ICallable)this).Apply<QArray<QArray<Int64>>>((allBinaries, (depth + 1L)));
#line 46 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs"
            newBinary[depth] = 1L;
#line 47 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs"
            var newAllBinaries2 = new QArray<QArray<Int64>>((binariesFromZero.Count + 1L));
#line 48 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs"
            foreach (var i in new Range(0L, (binariesFromZero.Count - 1L)))
            {
#line 49 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs"
                newAllBinaries2[i] = binariesFromZero[i];
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

    public class NumIsOne : Operation<Int64, Boolean>, ICallable
    {
        public NumIsOne(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "NumIsOne";
        String ICallable.FullName => "Utils.NumIsOne";
        public override Func<Int64, Boolean> Body => (__in) =>
        {
            var num = __in;
#line 65 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs"
            return (num == 1L);
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn(Int64 data) => new QTuple<Int64>(data);
        public override IApplyData __dataOut(Boolean data) => new QTuple<Boolean>(data);
        public static System.Threading.Tasks.Task<Boolean> Run(IOperationFactory __m__, Int64 num)
        {
            return __m__.Run<NumIsOne, Int64, Boolean>(num);
        }
    }

    public class InitQubit : Operation<(Int64,QArray<Int64>,Qubit), QVoid>, ICallable
    {
        public InitQubit(IOperationFactory m) : base(m)
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

        String ICallable.Name => "InitQubit";
        String ICallable.FullName => "Utils.InitQubit";
        protected ICallable MicrosoftQuantumCanonApplyIf
        {
            get;
            set;
        }

        protected ICallable<Int64, Boolean> NumIsOne
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
#line 70 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs"
            MicrosoftQuantumCanonApplyIf.Apply((((ICallable)MicrosoftQuantumPrimitiveX), NumIsOne.Apply(binaryRep[index]), target));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonApplyIf = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.ApplyIf<>));
            this.NumIsOne = this.Factory.Get<ICallable<Int64, Boolean>>(typeof(Utils.NumIsOne));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn((Int64,QArray<Int64>,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Int64 index, QArray<Int64> binaryRep, Qubit target)
        {
            return __m__.Run<InitQubit, (Int64,QArray<Int64>,Qubit), QVoid>((index, binaryRep, target));
        }
    }

    public class SetQubits : Operation<(QArray<Qubit>,QArray<Int64>), QVoid>, ICallable
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
        protected ICallable MicrosoftQuantumCanonApplyToEachIndex
        {
            get;
            set;
        }

        protected ICallable<(Int64,QArray<Int64>,Qubit), QVoid> InitQubit
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,QArray<Int64>), QVoid> Body => (__in) =>
        {
            var (register,binary) = __in;
#line 76 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs"
            MicrosoftQuantumCanonApplyToEachIndex.Apply((((ICallable)InitQubit.Partial(new Func<(Int64,Qubit), (Int64,QArray<Int64>,Qubit)>((_arg1) => (_arg1.Item1, binary, _arg1.Item2)))), register));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonApplyToEachIndex = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.ApplyToEachIndex<>));
            this.InitQubit = this.Factory.Get<ICallable<(Int64,QArray<Int64>,Qubit), QVoid>>(typeof(Utils.InitQubit));
        }

        public override IApplyData __dataIn((QArray<Qubit>,QArray<Int64>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> register, QArray<Int64> binary)
        {
            return __m__.Run<SetQubits, (QArray<Qubit>,QArray<Int64>), QVoid>((register, binary));
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
#line 82 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs"
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
#line 88 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs"
            var sum = 0L;
#line 89 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs"
            var lastIndex = (qubits.Count - 1L);
#line 90 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs"
            foreach (var j in new Range(0L, lastIndex))
            {
#line 91 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs"
                sum = (sum + BinaryValue.Apply((j, qubits[(lastIndex - j)])));
            }

#line 93 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs"
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

        protected ICallable<(QArray<Qubit>,QArray<Int64>), QVoid> SetQubits
        {
            get;
            set;
        }

        public override Func<(Int64,ICallable), QVoid> Body => (__in) =>
        {
            var (length,op) = __in;
#line 99 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs"
            var binaries = GenerateAllBinariesOfLength.Apply(length);
#line 101 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs"
            var qubits = Allocate.Apply((length * 2L));
#line 102 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs"
            foreach (var i in new Range(0L, (binaries.Count - 1L)))
            {
#line 103 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs"
                foreach (var j in new Range(0L, (binaries.Count - 1L)))
                {
#line 104 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs"
                    var binaryA = binaries[i];
#line 105 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs"
                    var binaryB = binaries[j];
#line 106 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs"
                    var a = qubits?.Slice(new Range(0L, (length - 1L)));
#line 107 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs"
                    var b = qubits?.Slice(new Range(length, ((length * 2L) - 1L)));
#line 109 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs"
                    SetQubits.Apply((a, binaryA));
#line 110 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs"
                    SetQubits.Apply((b, binaryB));
#line 112 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs"
                    op.Apply((a, b));
#line 114 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs"
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
            this.SetQubits = this.Factory.Get<ICallable<(QArray<Qubit>,QArray<Int64>), QVoid>>(typeof(Utils.SetQubits));
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
#line 123 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs"
            var str = "";
#line 124 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs"
            foreach (var i in new Range(0L, (reg.Count - 1L)))
            {
#line 125 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Operation.qs"
                str = (str + MicrosoftQuantumExtensionsConvertToStringI.Apply(MicrosoftQuantumCanonResultAsInt.Apply(new QArray<Result>()
                {M.Apply(reg[i])})));
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