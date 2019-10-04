#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Intrinsic;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Utils.Testing\",\"Name\":\"SetQubits\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Testing.qs\",\"Position\":{\"Item1\":7,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":20}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"register\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":22},\"Item2\":{\"Line\":1,\"Column\":30}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"binaryStr\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":42},\"Item2\":{\"Line\":1,\"Column\":51}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Utils.Testing\",\"Name\":\"SetQubits\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Testing.qs\",\"Position\":{\"Item1\":9,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Utils.Testing\",\"Name\":\"SetQubits\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Testing.qs\",\"Position\":{\"Item1\":13,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Utils.Testing\",\"Name\":\"SetQubits\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Testing.qs\",\"Position\":{\"Item1\":14,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":11}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Utils.Testing\",\"Name\":\"SetQubits\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Testing.qs\",\"Position\":{\"Item1\":15,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"Utils.Testing\",\"Name\":\"_GenerateBinaries\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Testing.qs\",\"Position\":{\"Item1\":18,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":27}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"allBinaries\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":29},\"Item2\":{\"Line\":1,\"Column\":40}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"depth\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":52},\"Item2\":{\"Line\":1,\"Column\":57}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]}]},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]}]},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Utils.Testing\",\"Name\":\"_GenerateBinaries\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Testing.qs\",\"Position\":{\"Item1\":18,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":27}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"Utils.Testing\",\"Name\":\"GenerateAllBinariesOfLength\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Testing.qs\",\"Position\":{\"Item1\":49,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":37}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"length\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":39},\"Item2\":{\"Line\":1,\"Column\":45}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Int\"},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]}]},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Utils.Testing\",\"Name\":\"GenerateAllBinariesOfLength\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Testing.qs\",\"Position\":{\"Item1\":49,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":37}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Utils.Testing\",\"Name\":\"RunOnAllBinariesOfLength\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Testing.qs\",\"Position\":{\"Item1\":57,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":35}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"length\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":37},\"Item2\":{\"Line\":1,\"Column\":43}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"op\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":51},\"Item2\":{\"Line\":1,\"Column\":53}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Utils.Testing\",\"Name\":\"RunOnAllBinariesOfLength\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Testing.qs\",\"Position\":{\"Item1\":57,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":35}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Utils.Testing\",\"Name\":\"RunOnAllTwoBinariesOfLength\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Testing.qs\",\"Position\":{\"Item1\":82,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":38}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"length\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":40},\"Item2\":{\"Line\":1,\"Column\":46}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"op\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":54},\"Item2\":{\"Line\":1,\"Column\":56}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Utils.Testing\",\"Name\":\"RunOnAllTwoBinariesOfLength\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Testing.qs\",\"Position\":{\"Item1\":82,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":38}},\"Documentation\":[]}")]
#line hidden
namespace Utils.Testing
{
    public partial class SetQubits : Unitary<(IQArray<Qubit>,IQArray<Int64>)>, ICallable
    {
        public SetQubits(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,IQArray<Int64>)>, IApplyData
        {
            public In((IQArray<Qubit>,IQArray<Int64>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item1)?.Qubits;
        }

        String ICallable.Name => "SetQubits";
        String ICallable.FullName => "Utils.Testing.SetQubits";
        protected IUnitary MicrosoftQuantumCanonApplyToEachIndexCA
        {
            get;
            set;
        }

        protected IUnitary<(Int64,IQArray<Int64>,Qubit)> UtilsGeneral_InitQubit
        {
            get;
            set;
        }

        public override Func<(IQArray<Qubit>,IQArray<Int64>), QVoid> Body => (__in__) =>
        {
            var (register,binaryStr) = __in__;
#line 11 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Testing.qs"
            MicrosoftQuantumCanonApplyToEachIndexCA.Apply((UtilsGeneral_InitQubit.Partial(new Func<(Int64,Qubit), (Int64,IQArray<Int64>,Qubit)>((__arg1__) => (__arg1__.Item1, binaryStr, __arg1__.Item2))), register));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,IQArray<Int64>), QVoid> AdjointBody => (__in__) =>
        {
            var (register,binaryStr) = __in__;
#line hidden
            MicrosoftQuantumCanonApplyToEachIndexCA.Adjoint.Apply((UtilsGeneral_InitQubit.Partial(new Func<(Int64,Qubit), (Int64,IQArray<Int64>,Qubit)>((__arg1__) => (__arg1__.Item1, binaryStr, __arg1__.Item2))), register));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,(IQArray<Qubit>,IQArray<Int64>)), QVoid> ControlledBody => (__in__) =>
        {
            var (__controlQubits__,(register,binaryStr)) = __in__;
#line hidden
            MicrosoftQuantumCanonApplyToEachIndexCA.Controlled.Apply((__controlQubits__, (UtilsGeneral_InitQubit.Partial(new Func<(Int64,Qubit), (Int64,IQArray<Int64>,Qubit)>((__arg1__) => (__arg1__.Item1, binaryStr, __arg1__.Item2))), register)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,(IQArray<Qubit>,IQArray<Int64>)), QVoid> ControlledAdjointBody => (__in__) =>
        {
            var (__controlQubits__,(register,binaryStr)) = __in__;
#line hidden
            MicrosoftQuantumCanonApplyToEachIndexCA.Adjoint.Controlled.Apply((__controlQubits__, (UtilsGeneral_InitQubit.Partial(new Func<(Int64,Qubit), (Int64,IQArray<Int64>,Qubit)>((__arg1__) => (__arg1__.Item1, binaryStr, __arg1__.Item2))), register)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonApplyToEachIndexCA = this.Factory.Get<IUnitary>(typeof(Microsoft.Quantum.Canon.ApplyToEachIndexCA<>));
            this.UtilsGeneral_InitQubit = this.Factory.Get<IUnitary<(Int64,IQArray<Int64>,Qubit)>>(typeof(Utils.General._InitQubit));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,IQArray<Int64>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> register, IQArray<Int64> binaryStr)
        {
            return __m__.Run<SetQubits, (IQArray<Qubit>,IQArray<Int64>), QVoid>((register, binaryStr));
        }
    }

    public partial class _GenerateBinaries : Function<(IQArray<IQArray<Int64>>,Int64), IQArray<IQArray<Int64>>>, ICallable
    {
        public _GenerateBinaries(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<IQArray<Int64>>,Int64)>, IApplyData
        {
            public In((IQArray<IQArray<Int64>>,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "_GenerateBinaries";
        String ICallable.FullName => "Utils.Testing._GenerateBinaries";
        protected ICallable Length
        {
            get;
            set;
        }

        protected ICallable<(IQArray<IQArray<Int64>>,Int64), IQArray<IQArray<Int64>>> self
        {
            get;
            set;
        }

        public override Func<(IQArray<IQArray<Int64>>,Int64), IQArray<IQArray<Int64>>> Body => (__in__) =>
        {
            var (allBinaries,depth) = __in__;
#line 21 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Testing.qs"
            var numBinaries = allBinaries.Length;
#line 22 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Testing.qs"
            var lastBinary = (IQArray<Int64>)allBinaries[(numBinaries - 1L)];
#line 23 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Testing.qs"
            var binaryLength = lastBinary.Length;
#line 24 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Testing.qs"
            var newBinaryPosition = numBinaries;
#line 26 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Testing.qs"
            if ((depth > (binaryLength - 1L)))
            {
#line 27 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Testing.qs"
                return allBinaries;
            }

#line 30 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Testing.qs"
            var newBinary = QArray<Int64>.Create(binaryLength);
#line 32 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Testing.qs"
            foreach (var base10 in new Range(0L, (binaryLength - 1L)))
#line hidden
            {
#line 33 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Testing.qs"
                newBinary.Modify(base10, lastBinary[base10]);
            }

#line 36 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Testing.qs"
            var binariesFromZero = (IQArray<IQArray<Int64>>)self.Apply<IQArray<IQArray<Int64>>>((allBinaries, (depth + 1L)));
#line 37 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Testing.qs"
            newBinary.Modify(depth, 1L);
#line 38 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Testing.qs"
            var newAllBinaries2 = QArray<IQArray<Int64>>.Create((binariesFromZero.Length + 1L));
#line 40 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Testing.qs"
            foreach (var base10 in new Range(0L, (binariesFromZero.Length - 1L)))
#line hidden
            {
#line 41 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Testing.qs"
                newAllBinaries2.Modify(base10, binariesFromZero[base10]);
            }

#line 44 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Testing.qs"
            newAllBinaries2.Modify(binariesFromZero.Length, newBinary?.Copy());
#line 45 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Testing.qs"
            var binariesFromOne = (IQArray<IQArray<Int64>>)self.Apply<IQArray<IQArray<Int64>>>((newAllBinaries2?.Copy(), (depth + 1L)));
#line 46 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Testing.qs"
            return binariesFromOne;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.self = this;
        }

        public override IApplyData __dataIn((IQArray<IQArray<Int64>>,Int64) data) => new In(data);
        public override IApplyData __dataOut(IQArray<IQArray<Int64>> data) => data;
        public static System.Threading.Tasks.Task<IQArray<IQArray<Int64>>> Run(IOperationFactory __m__, IQArray<IQArray<Int64>> allBinaries, Int64 depth)
        {
            return __m__.Run<_GenerateBinaries, (IQArray<IQArray<Int64>>,Int64), IQArray<IQArray<Int64>>>((allBinaries, depth));
        }
    }

    public partial class GenerateAllBinariesOfLength : Function<Int64, IQArray<IQArray<Int64>>>, ICallable
    {
        public GenerateAllBinariesOfLength(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "GenerateAllBinariesOfLength";
        String ICallable.FullName => "Utils.Testing.GenerateAllBinariesOfLength";
        protected ICallable<(IQArray<IQArray<Int64>>,Int64), IQArray<IQArray<Int64>>> _GenerateBinaries
        {
            get;
            set;
        }

        public override Func<Int64, IQArray<IQArray<Int64>>> Body => (__in__) =>
        {
            var length = __in__;
#line 52 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Testing.qs"
            var initialBinaries = QArray<IQArray<Int64>>.Create(1L);
#line 53 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Testing.qs"
            initialBinaries.Modify(0L, QArray<Int64>.Create(length));
#line 54 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Testing.qs"
            return _GenerateBinaries.Apply((initialBinaries?.Copy(), 0L));
        }

        ;
        public override void Init()
        {
            this._GenerateBinaries = this.Factory.Get<ICallable<(IQArray<IQArray<Int64>>,Int64), IQArray<IQArray<Int64>>>>(typeof(_GenerateBinaries));
        }

        public override IApplyData __dataIn(Int64 data) => new QTuple<Int64>(data);
        public override IApplyData __dataOut(IQArray<IQArray<Int64>> data) => data;
        public static System.Threading.Tasks.Task<IQArray<IQArray<Int64>>> Run(IOperationFactory __m__, Int64 length)
        {
            return __m__.Run<GenerateAllBinariesOfLength, Int64, IQArray<IQArray<Int64>>>(length);
        }
    }

    public partial class RunOnAllBinariesOfLength : Operation<(Int64,ICallable), QVoid>, ICallable
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
        String ICallable.FullName => "Utils.Testing.RunOnAllBinariesOfLength";
        protected IUnitary<(Int64,Microsoft.Quantum.Arithmetic.LittleEndian)> MicrosoftQuantumArithmeticIncrementByInteger
        {
            get;
            set;
        }

        protected ICallable<IQArray<Qubit>, Microsoft.Quantum.Arithmetic.LittleEndian> MicrosoftQuantumArithmeticLittleEndian
        {
            get;
            set;
        }

        protected IUnitary<IQArray<Qubit>> MicrosoftQuantumCanonSwapReverseRegister
        {
            get;
            set;
        }

        protected Allocate Allocate
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected ICallable<IQArray<Qubit>, QVoid> MicrosoftQuantumIntrinsicResetAll
        {
            get;
            set;
        }

        public override Func<(Int64,ICallable), QVoid> Body => (__in__) =>
        {
            var (length,op) = __in__;
#line hidden
            {
#line 60 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Testing.qs"
                var qubits = Allocate.Apply(length);
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 61 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Testing.qs"
                    foreach (var base10 in new Range(0L, (2L.Pow(length) - 1L)))
#line hidden
                    {
#line 62 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Testing.qs"
                        MicrosoftQuantumArithmeticIncrementByInteger.Apply((base10, new Microsoft.Quantum.Arithmetic.LittleEndian(qubits)));
#line 63 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Testing.qs"
                        MicrosoftQuantumCanonSwapReverseRegister.Apply(qubits);
#line 64 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Testing.qs"
                        op.Apply(qubits);
#line 65 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Testing.qs"
                        MicrosoftQuantumIntrinsicResetAll.Apply(qubits);
                    }
                }
#line hidden
                catch (Exception __arg2__)
                {
                    __arg1__ = __arg2__;
                    throw __arg1__;
                }
#line hidden
                finally
                {
                    if (__arg1__ != null)
                    {
                        throw __arg1__;
                    }

#line hidden
                    Release.Apply(qubits);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumArithmeticIncrementByInteger = this.Factory.Get<IUnitary<(Int64,Microsoft.Quantum.Arithmetic.LittleEndian)>>(typeof(Microsoft.Quantum.Arithmetic.IncrementByInteger));
            this.MicrosoftQuantumArithmeticLittleEndian = this.Factory.Get<ICallable<IQArray<Qubit>, Microsoft.Quantum.Arithmetic.LittleEndian>>(typeof(Microsoft.Quantum.Arithmetic.LittleEndian));
            this.MicrosoftQuantumCanonSwapReverseRegister = this.Factory.Get<IUnitary<IQArray<Qubit>>>(typeof(Microsoft.Quantum.Canon.SwapReverseRegister));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.MicrosoftQuantumIntrinsicResetAll = this.Factory.Get<ICallable<IQArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Intrinsic.ResetAll));
        }

        public override IApplyData __dataIn((Int64,ICallable) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Int64 length, ICallable op)
        {
            return __m__.Run<RunOnAllBinariesOfLength, (Int64,ICallable), QVoid>((length, op));
        }
    }

    public partial class RunOnAllTwoBinariesOfLength : Operation<(Int64,ICallable), QVoid>, ICallable
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
        String ICallable.FullName => "Utils.Testing.RunOnAllTwoBinariesOfLength";
        protected ICallable Length
        {
            get;
            set;
        }

        protected Allocate Allocate
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected ICallable<IQArray<Qubit>, QVoid> MicrosoftQuantumIntrinsicResetAll
        {
            get;
            set;
        }

        protected ICallable<Int64, IQArray<IQArray<Int64>>> GenerateAllBinariesOfLength
        {
            get;
            set;
        }

        protected IUnitary<(IQArray<Qubit>,IQArray<Int64>)> SetQubits
        {
            get;
            set;
        }

        public override Func<(Int64,ICallable), QVoid> Body => (__in__) =>
        {
            var (length,op) = __in__;
#line 85 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Testing.qs"
            var binaries = (IQArray<IQArray<Int64>>)GenerateAllBinariesOfLength.Apply(length);
#line hidden
            {
#line 87 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Testing.qs"
                var qubits = Allocate.Apply((length * 2L));
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 89 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Testing.qs"
                    foreach (var base10 in new Range(0L, (binaries.Length - 1L)))
#line hidden
                    {
#line 91 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Testing.qs"
                        foreach (var j in new Range(0L, (binaries.Length - 1L)))
#line hidden
                        {
#line 92 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Testing.qs"
                            var binaryA = (IQArray<Int64>)binaries[base10];
#line 93 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Testing.qs"
                            var binaryB = (IQArray<Int64>)binaries[j];
#line 94 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Testing.qs"
                            var a = (IQArray<Qubit>)qubits?.Slice(new Range(0L, (length - 1L)));
#line 95 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Testing.qs"
                            var b = (IQArray<Qubit>)qubits?.Slice(new Range(length, ((length * 2L) - 1L)));
#line 96 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Testing.qs"
                            SetQubits.Apply((a, binaryA));
#line 97 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Testing.qs"
                            SetQubits.Apply((b, binaryB));
#line 98 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Testing.qs"
                            op.Apply((a, b));
#line 99 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Testing.qs"
                            MicrosoftQuantumIntrinsicResetAll.Apply(qubits);
                        }
                    }
                }
#line hidden
                catch (Exception __arg2__)
                {
                    __arg1__ = __arg2__;
                    throw __arg1__;
                }
#line hidden
                finally
                {
                    if (__arg1__ != null)
                    {
                        throw __arg1__;
                    }

#line hidden
                    Release.Apply(qubits);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.MicrosoftQuantumIntrinsicResetAll = this.Factory.Get<ICallable<IQArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Intrinsic.ResetAll));
            this.GenerateAllBinariesOfLength = this.Factory.Get<ICallable<Int64, IQArray<IQArray<Int64>>>>(typeof(GenerateAllBinariesOfLength));
            this.SetQubits = this.Factory.Get<IUnitary<(IQArray<Qubit>,IQArray<Int64>)>>(typeof(SetQubits));
        }

        public override IApplyData __dataIn((Int64,ICallable) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Int64 length, ICallable op)
        {
            return __m__.Run<RunOnAllTwoBinariesOfLength, (Int64,ICallable), QVoid>((length, op));
        }
    }
}