#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Utils.General\",\"Name\":\"CopyQubits\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/General.qs\",\"Position\":{\"Item1\":8,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":21}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"from\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":23},\"Item2\":{\"Line\":1,\"Column\":27}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"to\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":39},\"Item2\":{\"Line\":1,\"Column\":41}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"},{\"Case\":\"Controlled\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Utils.General\",\"Name\":\"CopyQubits\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/General.qs\",\"Position\":{\"Item1\":10,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Utils.General\",\"Name\":\"CopyQubits\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/General.qs\",\"Position\":{\"Item1\":27,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"Parent\":{\"Namespace\":\"Utils.General\",\"Name\":\"CopyQubits\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/General.qs\",\"Position\":{\"Item1\":28,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":11}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"Parent\":{\"Namespace\":\"Utils.General\",\"Name\":\"CopyQubits\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/General.qs\",\"Position\":{\"Item1\":29,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Utils.General\",\"Name\":\"QubitOr\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/General.qs\",\"Position\":{\"Item1\":33,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":18}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"q1\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":20},\"Item2\":{\"Line\":1,\"Column\":22}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"q2\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":32},\"Item2\":{\"Line\":1,\"Column\":34}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"target\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":44},\"Item2\":{\"Line\":1,\"Column\":50}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Qubit\"},{\"Case\":\"Qubit\"},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"},{\"Case\":\"Controlled\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Utils.General\",\"Name\":\"QubitOr\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/General.qs\",\"Position\":{\"Item1\":35,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Utils.General\",\"Name\":\"QubitOr\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/General.qs\",\"Position\":{\"Item1\":41,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"Parent\":{\"Namespace\":\"Utils.General\",\"Name\":\"QubitOr\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/General.qs\",\"Position\":{\"Item1\":42,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":11}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"Parent\":{\"Namespace\":\"Utils.General\",\"Name\":\"QubitOr\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/General.qs\",\"Position\":{\"Item1\":43,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Utils.General\",\"Name\":\"_InitQubit\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/General.qs\",\"Position\":{\"Item1\":47,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":21}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"index\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":23},\"Item2\":{\"Line\":1,\"Column\":28}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"binaryRep\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":36},\"Item2\":{\"Line\":1,\"Column\":45}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"target\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":55},\"Item2\":{\"Line\":1,\"Column\":61}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"},{\"Case\":\"Controlled\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Utils.General\",\"Name\":\"_InitQubit\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/General.qs\",\"Position\":{\"Item1\":49,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Utils.General\",\"Name\":\"_InitQubit\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/General.qs\",\"Position\":{\"Item1\":53,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"Parent\":{\"Namespace\":\"Utils.General\",\"Name\":\"_InitQubit\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/General.qs\",\"Position\":{\"Item1\":54,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":11}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"Parent\":{\"Namespace\":\"Utils.General\",\"Name\":\"_InitQubit\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/General.qs\",\"Position\":{\"Item1\":55,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Utils.General\",\"Name\":\"BinaryValue\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/General.qs\",\"Position\":{\"Item1\":59,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"index\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":24},\"Item2\":{\"Line\":1,\"Column\":29}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qubit\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":37},\"Item2\":{\"Line\":1,\"Column\":42}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"Int\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Utils.General\",\"Name\":\"BinaryValue\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/General.qs\",\"Position\":{\"Item1\":59,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Utils.General\",\"Name\":\"QubitsToInt\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/General.qs\",\"Position\":{\"Item1\":66,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qubits\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":24},\"Item2\":{\"Line\":1,\"Column\":30}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"Int\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Utils.General\",\"Name\":\"QubitsToInt\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/General.qs\",\"Position\":{\"Item1\":66,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"Utils.General\",\"Name\":\"IntToBinary\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/General.qs\",\"Position\":{\"Item1\":79,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":21}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"base10\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":23},\"Item2\":{\"Line\":1,\"Column\":29}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Int\"},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Utils.General\",\"Name\":\"IntToBinary\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/General.qs\",\"Position\":{\"Item1\":79,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":21}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Utils.General\",\"Name\":\"PrintRegister\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/General.qs\",\"Position\":{\"Item1\":96,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"reg\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":26},\"Item2\":{\"Line\":1,\"Column\":29}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Utils.General\",\"Name\":\"PrintRegister\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/General.qs\",\"Position\":{\"Item1\":96,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"Documentation\":[]}")]
#line hidden
namespace Utils.General
{
    public class CopyQubits : Unitary<(QArray<Qubit>,QArray<Qubit>)>, ICallable
    {
        public CopyQubits(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,QArray<Qubit>)>, IApplyData
        {
            public In((QArray<Qubit>,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "CopyQubits";
        String ICallable.FullName => "Utils.General.CopyQubits";
        protected ICallable<(Boolean,Boolean,String), QVoid> MicrosoftQuantumCanonAssertBoolEqual
        {
            get;
            set;
        }

        protected IUnitary<QArray<Qubit>> MicrosoftQuantumCanonSwapReverseRegister
        {
            get;
            set;
        }

        protected ICallable Length
        {
            get;
            set;
        }

        protected ICallable<Range, Range> RangeReverse
        {
            get;
            set;
        }

        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumPrimitiveCNOT
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,QArray<Qubit>), QVoid> Body => (__in) =>
        {
            var (from,to) = __in;
#line 12 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/General.qs"
            var fromLength = from.Length;
#line 13 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/General.qs"
            var toLength = to.Length;
#line 14 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/General.qs"
            MicrosoftQuantumCanonAssertBoolEqual.Apply(((fromLength <= toLength), true, String.Format("TO register (length {0}) must be able to contain FROM register (length {1})", toLength, fromLength)));
#line 17 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/General.qs"
            MicrosoftQuantumCanonSwapReverseRegister.Apply(from?.Copy());
#line 18 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/General.qs"
            MicrosoftQuantumCanonSwapReverseRegister.Apply(to?.Copy());
#line 20 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/General.qs"
            foreach (var i in new Range(0L, (fromLength - 1L)))
#line hidden
            {
#line 21 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/General.qs"
                MicrosoftQuantumPrimitiveCNOT.Apply((from[i], to[i]));
            }

#line 24 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/General.qs"
            MicrosoftQuantumCanonSwapReverseRegister.Apply(to?.Copy());
#line 25 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/General.qs"
            MicrosoftQuantumCanonSwapReverseRegister.Apply(from?.Copy());
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,QArray<Qubit>), QVoid> AdjointBody => (__in) =>
        {
            var (from,to) = __in;
#line hidden
            var fromLength = from.Length;
#line hidden
            var toLength = to.Length;
#line hidden
            MicrosoftQuantumCanonAssertBoolEqual.Apply(((fromLength <= toLength), true, String.Format("TO register (length {0}) must be able to contain FROM register (length {1})", toLength, fromLength)));
#line hidden
            MicrosoftQuantumCanonSwapReverseRegister.Adjoint.Apply(from?.Copy());
#line hidden
            MicrosoftQuantumCanonSwapReverseRegister.Adjoint.Apply(to?.Copy());
#line hidden
            foreach (var i in RangeReverse.Apply(new Range(0L, (fromLength - 1L))))
#line hidden
            {
#line hidden
                MicrosoftQuantumPrimitiveCNOT.Adjoint.Apply((from[i], to[i]));
            }

#line hidden
            MicrosoftQuantumCanonSwapReverseRegister.Adjoint.Apply(to?.Copy());
#line hidden
            MicrosoftQuantumCanonSwapReverseRegister.Adjoint.Apply(from?.Copy());
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Qubit>,QArray<Qubit>)), QVoid> ControlledBody => (__in) =>
        {
            var (__controlQubits__,(from,to)) = __in;
#line hidden
            var fromLength = from.Length;
#line hidden
            var toLength = to.Length;
#line hidden
            MicrosoftQuantumCanonAssertBoolEqual.Apply(((fromLength <= toLength), true, String.Format("TO register (length {0}) must be able to contain FROM register (length {1})", toLength, fromLength)));
#line hidden
            MicrosoftQuantumCanonSwapReverseRegister.Controlled.Apply((__controlQubits__?.Copy(), from?.Copy()));
#line hidden
            MicrosoftQuantumCanonSwapReverseRegister.Controlled.Apply((__controlQubits__?.Copy(), to?.Copy()));
#line hidden
            foreach (var i in new Range(0L, (fromLength - 1L)))
#line hidden
            {
#line hidden
                MicrosoftQuantumPrimitiveCNOT.Controlled.Apply((__controlQubits__?.Copy(), (from[i], to[i])));
            }

#line hidden
            MicrosoftQuantumCanonSwapReverseRegister.Controlled.Apply((__controlQubits__?.Copy(), to?.Copy()));
#line hidden
            MicrosoftQuantumCanonSwapReverseRegister.Controlled.Apply((__controlQubits__?.Copy(), from?.Copy()));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Qubit>,QArray<Qubit>)), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (__controlQubits__,(from,to)) = __in;
#line hidden
            var fromLength = from.Length;
#line hidden
            var toLength = to.Length;
#line hidden
            MicrosoftQuantumCanonAssertBoolEqual.Apply(((fromLength <= toLength), true, String.Format("TO register (length {0}) must be able to contain FROM register (length {1})", toLength, fromLength)));
#line hidden
            MicrosoftQuantumCanonSwapReverseRegister.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), from?.Copy()));
#line hidden
            MicrosoftQuantumCanonSwapReverseRegister.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), to?.Copy()));
#line hidden
            foreach (var i in RangeReverse.Apply(new Range(0L, (fromLength - 1L))))
#line hidden
            {
#line hidden
                MicrosoftQuantumPrimitiveCNOT.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (from[i], to[i])));
            }

#line hidden
            MicrosoftQuantumCanonSwapReverseRegister.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), to?.Copy()));
#line hidden
            MicrosoftQuantumCanonSwapReverseRegister.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), from?.Copy()));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonAssertBoolEqual = this.Factory.Get<ICallable<(Boolean,Boolean,String), QVoid>>(typeof(Microsoft.Quantum.Canon.AssertBoolEqual));
            this.MicrosoftQuantumCanonSwapReverseRegister = this.Factory.Get<IUnitary<QArray<Qubit>>>(typeof(Microsoft.Quantum.Canon.SwapReverseRegister));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.RangeReverse = this.Factory.Get<ICallable<Range, Range>>(typeof(Microsoft.Quantum.Core.RangeReverse));
            this.MicrosoftQuantumPrimitiveCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.CNOT));
        }

        public override IApplyData __dataIn((QArray<Qubit>,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> from, QArray<Qubit> to)
        {
            return __m__.Run<CopyQubits, (QArray<Qubit>,QArray<Qubit>), QVoid>((from, to));
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
        String ICallable.FullName => "Utils.General.QubitOr";
        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumPrimitiveCNOT
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<(Qubit,Qubit,Qubit), QVoid> Body => (__in) =>
        {
            var (q1,q2,target) = __in;
#line 37 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/General.qs"
            MicrosoftQuantumPrimitiveCNOT.Apply((q1, target));
#line 38 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/General.qs"
            MicrosoftQuantumPrimitiveCNOT.Apply((q2, target));
#line 39 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/General.qs"
            MicrosoftQuantumPrimitiveX.Controlled.Apply((new QArray<Qubit>(q1, q2), target));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(Qubit,Qubit,Qubit), QVoid> AdjointBody => (__in) =>
        {
            var (q1,q2,target) = __in;
#line hidden
            MicrosoftQuantumPrimitiveX.Controlled.Adjoint.Apply((new QArray<Qubit>(q1, q2), target));
#line hidden
            MicrosoftQuantumPrimitiveCNOT.Adjoint.Apply((q2, target));
#line hidden
            MicrosoftQuantumPrimitiveCNOT.Adjoint.Apply((q1, target));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(Qubit,Qubit,Qubit)), QVoid> ControlledBody => (__in) =>
        {
            var (__controlQubits__,(q1,q2,target)) = __in;
#line hidden
            MicrosoftQuantumPrimitiveCNOT.Controlled.Apply((__controlQubits__?.Copy(), (q1, target)));
#line hidden
            MicrosoftQuantumPrimitiveCNOT.Controlled.Apply((__controlQubits__?.Copy(), (q2, target)));
#line hidden
            MicrosoftQuantumPrimitiveX.Controlled.Controlled.Apply((__controlQubits__?.Copy(), (new QArray<Qubit>(q1, q2), target)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(Qubit,Qubit,Qubit)), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (__controlQubits__,(q1,q2,target)) = __in;
#line hidden
            MicrosoftQuantumPrimitiveX.Controlled.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (new QArray<Qubit>(q1, q2), target)));
#line hidden
            MicrosoftQuantumPrimitiveCNOT.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (q2, target)));
#line hidden
            MicrosoftQuantumPrimitiveCNOT.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (q1, target)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumPrimitiveCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.CNOT));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn((Qubit,Qubit,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit q1, Qubit q2, Qubit target)
        {
            return __m__.Run<QubitOr, (Qubit,Qubit,Qubit), QVoid>((q1, q2, target));
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
        String ICallable.FullName => "Utils.General._InitQubit";
        protected IUnitary MicrosoftQuantumCanonApplyIfCA
        {
            get;
            set;
        }

        protected ICallable Length
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
#line 51 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/General.qs"
            MicrosoftQuantumCanonApplyIfCA.Apply((MicrosoftQuantumPrimitiveX, ((index <= (binaryRep.Length - 1L)) && (binaryRep[index] == 1L)), target));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(Int64,QArray<Int64>,Qubit), QVoid> AdjointBody => (__in) =>
        {
            var (index,binaryRep,target) = __in;
#line hidden
            MicrosoftQuantumCanonApplyIfCA.Adjoint.Apply((MicrosoftQuantumPrimitiveX, ((index <= (binaryRep.Length - 1L)) && (binaryRep[index] == 1L)), target));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(Int64,QArray<Int64>,Qubit)), QVoid> ControlledBody => (__in) =>
        {
            var (__controlQubits__,(index,binaryRep,target)) = __in;
#line hidden
            MicrosoftQuantumCanonApplyIfCA.Controlled.Apply((__controlQubits__?.Copy(), (MicrosoftQuantumPrimitiveX, ((index <= (binaryRep.Length - 1L)) && (binaryRep[index] == 1L)), target)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(Int64,QArray<Int64>,Qubit)), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (__controlQubits__,(index,binaryRep,target)) = __in;
#line hidden
            MicrosoftQuantumCanonApplyIfCA.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (MicrosoftQuantumPrimitiveX, ((index <= (binaryRep.Length - 1L)) && (binaryRep[index] == 1L)), target)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonApplyIfCA = this.Factory.Get<IUnitary>(typeof(Microsoft.Quantum.Canon.ApplyIfCA<>));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn((Int64,QArray<Int64>,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Int64 index, QArray<Int64> binaryRep, Qubit target)
        {
            return __m__.Run<_InitQubit, (Int64,QArray<Int64>,Qubit), QVoid>((index, binaryRep, target));
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
        String ICallable.FullName => "Utils.General.BinaryValue";
        protected ICallable<QArray<Result>, Int64> MicrosoftQuantumCanonResultAsInt
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> M
        {
            get;
            set;
        }

        public override Func<(Int64,Qubit), Int64> Body => (__in) =>
        {
            var (index,qubit) = __in;
#line 62 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/General.qs"
            return (2L.Pow(index) * MicrosoftQuantumCanonResultAsInt.Apply(new QArray<Result>()
            {M.Apply(qubit)}));
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonResultAsInt = this.Factory.Get<ICallable<QArray<Result>, Int64>>(typeof(Microsoft.Quantum.Canon.ResultAsInt));
            this.M = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
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
        String ICallable.FullName => "Utils.General.QubitsToInt";
        protected ICallable Length
        {
            get;
            set;
        }

        protected ICallable<(Int64,Qubit), Int64> BinaryValue
        {
            get;
            set;
        }

        public override Func<QArray<Qubit>, Int64> Body => (__in) =>
        {
            var qubits = __in;
#line 69 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/General.qs"
            var sum = 0L;
#line 70 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/General.qs"
            var lastIndex = (qubits.Length - 1L);
#line 72 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/General.qs"
            foreach (var j in new Range(0L, lastIndex))
#line hidden
            {
#line 73 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/General.qs"
                sum = (sum + BinaryValue.Apply((j, qubits[(lastIndex - j)])));
            }

#line 76 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/General.qs"
            return sum;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.BinaryValue = this.Factory.Get<ICallable<(Int64,Qubit), Int64>>(typeof(BinaryValue));
        }

        public override IApplyData __dataIn(QArray<Qubit> data) => data;
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, QArray<Qubit> qubits)
        {
            return __m__.Run<QubitsToInt, QArray<Qubit>, Int64>(qubits);
        }
    }

    public class IntToBinary : Function<Int64, QArray<Int64>>, ICallable
    {
        public IntToBinary(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "IntToBinary";
        String ICallable.FullName => "Utils.General.IntToBinary";
        public override Func<Int64, QArray<Int64>> Body => (__in) =>
        {
            var base10 = __in;
#line 82 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/General.qs"
            var base10Mut = base10;
#line 83 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/General.qs"
            var binary = new QArray<Int64>(0L);
#line 85 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/General.qs"
            while (true)
            {
#line 86 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/General.qs"
                binary = (new QArray<Int64>()
                {(base10Mut % 2L)} + binary);
#line 87 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/General.qs"
                base10Mut = (base10Mut / 2L);
                if ((base10Mut <= 0L))
                {
                    break;
                }
                else
                {
                }
            }

#line 93 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/General.qs"
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

    public class PrintRegister : Operation<QArray<Qubit>, QVoid>, ICallable
    {
        public PrintRegister(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "PrintRegister";
        String ICallable.FullName => "Utils.General.PrintRegister";
        protected ICallable<QArray<Result>, Int64> MicrosoftQuantumCanonResultAsInt
        {
            get;
            set;
        }

        protected ICallable Length
        {
            get;
            set;
        }

        protected ICallable<Int64, String> MicrosoftQuantumExtensionsConvertToStringI
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> M
        {
            get;
            set;
        }

        protected ICallable<String, QVoid> Message
        {
            get;
            set;
        }

        public override Func<QArray<Qubit>, QVoid> Body => (__in) =>
        {
            var reg = __in;
#line 99 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/General.qs"
            var str = "";
#line 101 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/General.qs"
            foreach (var i in new Range(0L, (reg.Length - 1L)))
#line hidden
            {
#line 102 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/General.qs"
                str = (str + MicrosoftQuantumExtensionsConvertToStringI.Apply(MicrosoftQuantumCanonResultAsInt.Apply(new QArray<Result>()
                {M.Apply(reg[i])})));
            }

#line 105 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/General.qs"
            Message.Apply(str);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonResultAsInt = this.Factory.Get<ICallable<QArray<Result>, Int64>>(typeof(Microsoft.Quantum.Canon.ResultAsInt));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.MicrosoftQuantumExtensionsConvertToStringI = this.Factory.Get<ICallable<Int64, String>>(typeof(Microsoft.Quantum.Extensions.Convert.ToStringI));
            this.M = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
            this.Message = this.Factory.Get<ICallable<String, QVoid>>(typeof(Microsoft.Quantum.Primitive.Message));
        }

        public override IApplyData __dataIn(QArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> reg)
        {
            return __m__.Run<PrintRegister, QArray<Qubit>, QVoid>(reg);
        }
    }
}