#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Utils.Compare\",\"Name\":\"XIfEqual\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs\",\"Position\":{\"Item1\":7,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":19}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"a\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":20},\"Item2\":{\"Line\":1,\"Column\":21}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"b\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":32},\"Item2\":{\"Line\":1,\"Column\":33}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"target\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":44},\"Item2\":{\"Line\":1,\"Column\":50}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"},{\"Case\":\"Controlled\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Utils.Compare\",\"Name\":\"XIfEqual\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs\",\"Position\":{\"Item1\":8,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Utils.Compare\",\"Name\":\"XIfEqual\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs\",\"Position\":{\"Item1\":40,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"Parent\":{\"Namespace\":\"Utils.Compare\",\"Name\":\"XIfEqual\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs\",\"Position\":{\"Item1\":41,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":11}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"Parent\":{\"Namespace\":\"Utils.Compare\",\"Name\":\"XIfEqual\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs\",\"Position\":{\"Item1\":42,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Utils.Compare\",\"Name\":\"XIfQubitEqualToInt\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs\",\"Position\":{\"Item1\":45,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":29}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"a\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":30},\"Item2\":{\"Line\":1,\"Column\":31}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"b\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":42},\"Item2\":{\"Line\":1,\"Column\":43}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"target\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":50},\"Item2\":{\"Line\":1,\"Column\":56}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Int\"},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"},{\"Case\":\"Controlled\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Utils.Compare\",\"Name\":\"XIfQubitEqualToInt\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs\",\"Position\":{\"Item1\":46,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Utils.Compare\",\"Name\":\"XIfQubitEqualToInt\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs\",\"Position\":{\"Item1\":54,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"Parent\":{\"Namespace\":\"Utils.Compare\",\"Name\":\"XIfQubitEqualToInt\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs\",\"Position\":{\"Item1\":55,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":11}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"Parent\":{\"Namespace\":\"Utils.Compare\",\"Name\":\"XIfQubitEqualToInt\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs\",\"Position\":{\"Item1\":56,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Utils.Compare\",\"Name\":\"_TestXIfQubitEqualToIntImpl\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs\",\"Position\":{\"Item1\":58,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":38}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"a\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":39},\"Item2\":{\"Line\":1,\"Column\":40}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"length\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":51},\"Item2\":{\"Line\":1,\"Column\":57}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Utils.Compare\",\"Name\":\"_TestXIfQubitEqualToIntImpl\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs\",\"Position\":{\"Item1\":58,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":38}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Utils.Compare\",\"Name\":\"_TestXIfQubitEqualToInt\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs\",\"Position\":{\"Item1\":74,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":34}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"length\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":35},\"Item2\":{\"Line\":1,\"Column\":41}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Int\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Utils.Compare\",\"Name\":\"_TestXIfQubitEqualToInt\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs\",\"Position\":{\"Item1\":74,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":34}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Utils.Compare\",\"Name\":\"XIfLessThan\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs\",\"Position\":{\"Item1\":78,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"a\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":23},\"Item2\":{\"Line\":1,\"Column\":24}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"b\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":35},\"Item2\":{\"Line\":1,\"Column\":36}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"target\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":47},\"Item2\":{\"Line\":1,\"Column\":53}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"},{\"Case\":\"Controlled\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Utils.Compare\",\"Name\":\"XIfLessThan\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs\",\"Position\":{\"Item1\":79,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Utils.Compare\",\"Name\":\"XIfLessThan\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs\",\"Position\":{\"Item1\":90,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"Parent\":{\"Namespace\":\"Utils.Compare\",\"Name\":\"XIfLessThan\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs\",\"Position\":{\"Item1\":91,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":11}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"Parent\":{\"Namespace\":\"Utils.Compare\",\"Name\":\"XIfLessThan\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs\",\"Position\":{\"Item1\":92,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
#line hidden
namespace Utils.Compare
{
    public class XIfEqual : Unitary<(QArray<Qubit>,QArray<Qubit>,Qubit)>, ICallable
    {
        public XIfEqual(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,QArray<Qubit>,Qubit)>, IApplyData
        {
            public In((QArray<Qubit>,QArray<Qubit>,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "XIfEqual";
        String ICallable.FullName => "Utils.Compare.XIfEqual";
        protected IUnitary MicrosoftQuantumCanonApplyToEachCA
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

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,QArray<Qubit>,Qubit), QVoid> Body => (__in) =>
        {
            var (a,b,target) = __in;
#line 10 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
            var lenA = a.Length;
#line 11 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
            var lenB = b.Length;
#line 13 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
            if ((lenA <= lenB))
            {
#line 14 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
                foreach (var i in new Range(0L, (lenA - 1L)))
#line hidden
                {
#line 15 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
                    MicrosoftQuantumPrimitiveCNOT.Apply((a[i], b[i]));
                }

#line 18 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
                MicrosoftQuantumCanonApplyToEachCA.Apply((MicrosoftQuantumPrimitiveX, b?.Copy()));
#line 19 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
                MicrosoftQuantumPrimitiveX.Controlled.Apply((b?.Copy(), target));
#line 20 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
                MicrosoftQuantumCanonApplyToEachCA.Apply((MicrosoftQuantumPrimitiveX, b?.Copy()));
#line 22 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
                foreach (var i in new Range((lenA - 1L), -(1L), 0L))
#line hidden
                {
#line 23 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
                    MicrosoftQuantumPrimitiveCNOT.Apply((a[i], b[i]));
                }
            }
            else
            {
#line 26 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
                foreach (var i in new Range(0L, (lenB - 1L)))
#line hidden
                {
#line 27 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
                    MicrosoftQuantumPrimitiveCNOT.Apply((b[i], a[i]));
                }

#line 30 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
                MicrosoftQuantumCanonApplyToEachCA.Apply((MicrosoftQuantumPrimitiveX, a?.Copy()));
#line 31 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
                MicrosoftQuantumPrimitiveX.Controlled.Apply((a?.Copy(), target));
#line 32 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
                MicrosoftQuantumCanonApplyToEachCA.Apply((MicrosoftQuantumPrimitiveX, a?.Copy()));
#line 34 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
                foreach (var i in new Range((lenB - 1L), -(1L), 0L))
#line hidden
                {
#line 35 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
                    MicrosoftQuantumPrimitiveCNOT.Apply((b[i], a[i]));
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,QArray<Qubit>,Qubit), QVoid> AdjointBody => (__in) =>
        {
            var (a,b,target) = __in;
#line hidden
            var lenA = a.Length;
#line hidden
            var lenB = b.Length;
#line hidden
            if ((lenA <= lenB))
            {
#line hidden
                foreach (var i in RangeReverse.Apply(new Range((lenA - 1L), -(1L), 0L)))
#line hidden
                {
#line hidden
                    MicrosoftQuantumPrimitiveCNOT.Adjoint.Apply((a[i], b[i]));
                }

#line hidden
                MicrosoftQuantumCanonApplyToEachCA.Adjoint.Apply((MicrosoftQuantumPrimitiveX, b?.Copy()));
#line hidden
                MicrosoftQuantumPrimitiveX.Controlled.Adjoint.Apply((b?.Copy(), target));
#line hidden
                MicrosoftQuantumCanonApplyToEachCA.Adjoint.Apply((MicrosoftQuantumPrimitiveX, b?.Copy()));
#line hidden
                foreach (var i in RangeReverse.Apply(new Range(0L, (lenA - 1L))))
#line hidden
                {
#line hidden
                    MicrosoftQuantumPrimitiveCNOT.Adjoint.Apply((a[i], b[i]));
                }
            }
            else
            {
#line hidden
                foreach (var i in RangeReverse.Apply(new Range((lenB - 1L), -(1L), 0L)))
#line hidden
                {
#line hidden
                    MicrosoftQuantumPrimitiveCNOT.Adjoint.Apply((b[i], a[i]));
                }

#line hidden
                MicrosoftQuantumCanonApplyToEachCA.Adjoint.Apply((MicrosoftQuantumPrimitiveX, a?.Copy()));
#line hidden
                MicrosoftQuantumPrimitiveX.Controlled.Adjoint.Apply((a?.Copy(), target));
#line hidden
                MicrosoftQuantumCanonApplyToEachCA.Adjoint.Apply((MicrosoftQuantumPrimitiveX, a?.Copy()));
#line hidden
                foreach (var i in RangeReverse.Apply(new Range(0L, (lenB - 1L))))
#line hidden
                {
#line hidden
                    MicrosoftQuantumPrimitiveCNOT.Adjoint.Apply((b[i], a[i]));
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Qubit>,QArray<Qubit>,Qubit)), QVoid> ControlledBody => (__in) =>
        {
            var (__controlQubits__,(a,b,target)) = __in;
#line hidden
            var lenA = a.Length;
#line hidden
            var lenB = b.Length;
#line hidden
            if ((lenA <= lenB))
            {
#line hidden
                foreach (var i in new Range(0L, (lenA - 1L)))
#line hidden
                {
#line hidden
                    MicrosoftQuantumPrimitiveCNOT.Controlled.Apply((__controlQubits__?.Copy(), (a[i], b[i])));
                }

#line hidden
                MicrosoftQuantumCanonApplyToEachCA.Controlled.Apply((__controlQubits__?.Copy(), (MicrosoftQuantumPrimitiveX, b?.Copy())));
#line hidden
                MicrosoftQuantumPrimitiveX.Controlled.Controlled.Apply((__controlQubits__?.Copy(), (b?.Copy(), target)));
#line hidden
                MicrosoftQuantumCanonApplyToEachCA.Controlled.Apply((__controlQubits__?.Copy(), (MicrosoftQuantumPrimitiveX, b?.Copy())));
#line hidden
                foreach (var i in new Range((lenA - 1L), -(1L), 0L))
#line hidden
                {
#line hidden
                    MicrosoftQuantumPrimitiveCNOT.Controlled.Apply((__controlQubits__?.Copy(), (a[i], b[i])));
                }
            }
            else
            {
#line hidden
                foreach (var i in new Range(0L, (lenB - 1L)))
#line hidden
                {
#line hidden
                    MicrosoftQuantumPrimitiveCNOT.Controlled.Apply((__controlQubits__?.Copy(), (b[i], a[i])));
                }

#line hidden
                MicrosoftQuantumCanonApplyToEachCA.Controlled.Apply((__controlQubits__?.Copy(), (MicrosoftQuantumPrimitiveX, a?.Copy())));
#line hidden
                MicrosoftQuantumPrimitiveX.Controlled.Controlled.Apply((__controlQubits__?.Copy(), (a?.Copy(), target)));
#line hidden
                MicrosoftQuantumCanonApplyToEachCA.Controlled.Apply((__controlQubits__?.Copy(), (MicrosoftQuantumPrimitiveX, a?.Copy())));
#line hidden
                foreach (var i in new Range((lenB - 1L), -(1L), 0L))
#line hidden
                {
#line hidden
                    MicrosoftQuantumPrimitiveCNOT.Controlled.Apply((__controlQubits__?.Copy(), (b[i], a[i])));
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Qubit>,QArray<Qubit>,Qubit)), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (__controlQubits__,(a,b,target)) = __in;
#line hidden
            var lenA = a.Length;
#line hidden
            var lenB = b.Length;
#line hidden
            if ((lenA <= lenB))
            {
#line hidden
                foreach (var i in RangeReverse.Apply(new Range((lenA - 1L), -(1L), 0L)))
#line hidden
                {
#line hidden
                    MicrosoftQuantumPrimitiveCNOT.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (a[i], b[i])));
                }

#line hidden
                MicrosoftQuantumCanonApplyToEachCA.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (MicrosoftQuantumPrimitiveX, b?.Copy())));
#line hidden
                MicrosoftQuantumPrimitiveX.Controlled.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (b?.Copy(), target)));
#line hidden
                MicrosoftQuantumCanonApplyToEachCA.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (MicrosoftQuantumPrimitiveX, b?.Copy())));
#line hidden
                foreach (var i in RangeReverse.Apply(new Range(0L, (lenA - 1L))))
#line hidden
                {
#line hidden
                    MicrosoftQuantumPrimitiveCNOT.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (a[i], b[i])));
                }
            }
            else
            {
#line hidden
                foreach (var i in RangeReverse.Apply(new Range((lenB - 1L), -(1L), 0L)))
#line hidden
                {
#line hidden
                    MicrosoftQuantumPrimitiveCNOT.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (b[i], a[i])));
                }

#line hidden
                MicrosoftQuantumCanonApplyToEachCA.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (MicrosoftQuantumPrimitiveX, a?.Copy())));
#line hidden
                MicrosoftQuantumPrimitiveX.Controlled.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (a?.Copy(), target)));
#line hidden
                MicrosoftQuantumCanonApplyToEachCA.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (MicrosoftQuantumPrimitiveX, a?.Copy())));
#line hidden
                foreach (var i in RangeReverse.Apply(new Range(0L, (lenB - 1L))))
#line hidden
                {
#line hidden
                    MicrosoftQuantumPrimitiveCNOT.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (b[i], a[i])));
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonApplyToEachCA = this.Factory.Get<IUnitary>(typeof(Microsoft.Quantum.Canon.ApplyToEachCA<>));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.RangeReverse = this.Factory.Get<ICallable<Range, Range>>(typeof(Microsoft.Quantum.Core.RangeReverse));
            this.MicrosoftQuantumPrimitiveCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.CNOT));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn((QArray<Qubit>,QArray<Qubit>,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> a, QArray<Qubit> b, Qubit target)
        {
            return __m__.Run<XIfEqual, (QArray<Qubit>,QArray<Qubit>,Qubit), QVoid>((a, b, target));
        }
    }

    public class XIfQubitEqualToInt : Unitary<(QArray<Qubit>,Int64,Qubit)>, ICallable
    {
        public XIfQubitEqualToInt(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,Int64,Qubit)>, IApplyData
        {
            public In((QArray<Qubit>,Int64,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "XIfQubitEqualToInt";
        String ICallable.FullName => "Utils.Compare.XIfQubitEqualToInt";
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

        protected IUnitary<(QArray<Qubit>,QArray<Qubit>,Qubit)> XIfEqual
        {
            get;
            set;
        }

        protected IUnitary<(QArray<Qubit>,Int64)> UtilsMathQFTAdderInt
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,Int64,Qubit), QVoid> Body => (__in) =>
        {
            var (a,b,target) = __in;
#line hidden
            {
#line 48 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
                var bQubit = Allocate.Apply(a.Length);
#line 49 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
                UtilsMathQFTAdderInt.Apply((bQubit?.Copy(), b));
#line 50 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
                XIfEqual.Apply((a?.Copy(), bQubit?.Copy(), target));
#line 51 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
                UtilsMathQFTAdderInt.Adjoint.Apply((bQubit?.Copy(), b));
#line hidden
                Release.Apply(bQubit);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,Int64,Qubit), QVoid> AdjointBody => (__in) =>
        {
            var (a,b,target) = __in;
#line hidden
            {
#line hidden
                var bQubit = Allocate.Apply(a.Length);
#line hidden
                UtilsMathQFTAdderInt.Adjoint.Adjoint.Apply((bQubit?.Copy(), b));
#line hidden
                XIfEqual.Adjoint.Apply((a?.Copy(), bQubit?.Copy(), target));
#line hidden
                UtilsMathQFTAdderInt.Adjoint.Apply((bQubit?.Copy(), b));
#line hidden
                Release.Apply(bQubit);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Qubit>,Int64,Qubit)), QVoid> ControlledBody => (__in) =>
        {
            var (__controlQubits__,(a,b,target)) = __in;
#line hidden
            {
#line hidden
                var bQubit = Allocate.Apply(a.Length);
#line hidden
                UtilsMathQFTAdderInt.Controlled.Apply((__controlQubits__?.Copy(), (bQubit?.Copy(), b)));
#line hidden
                XIfEqual.Controlled.Apply((__controlQubits__?.Copy(), (a?.Copy(), bQubit?.Copy(), target)));
#line hidden
                UtilsMathQFTAdderInt.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (bQubit?.Copy(), b)));
#line hidden
                Release.Apply(bQubit);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Qubit>,Int64,Qubit)), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (__controlQubits__,(a,b,target)) = __in;
#line hidden
            {
#line hidden
                var bQubit = Allocate.Apply(a.Length);
#line hidden
                UtilsMathQFTAdderInt.Adjoint.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (bQubit?.Copy(), b)));
#line hidden
                XIfEqual.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (a?.Copy(), bQubit?.Copy(), target)));
#line hidden
                UtilsMathQFTAdderInt.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (bQubit?.Copy(), b)));
#line hidden
                Release.Apply(bQubit);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.XIfEqual = this.Factory.Get<IUnitary<(QArray<Qubit>,QArray<Qubit>,Qubit)>>(typeof(XIfEqual));
            this.UtilsMathQFTAdderInt = this.Factory.Get<IUnitary<(QArray<Qubit>,Int64)>>(typeof(Utils.Math.QFTAdderInt));
        }

        public override IApplyData __dataIn((QArray<Qubit>,Int64,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> a, Int64 b, Qubit target)
        {
            return __m__.Run<XIfQubitEqualToInt, (QArray<Qubit>,Int64,Qubit), QVoid>((a, b, target));
        }
    }

    public class _TestXIfQubitEqualToIntImpl : Operation<(QArray<Qubit>,Int64), QVoid>, ICallable
    {
        public _TestXIfQubitEqualToIntImpl(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,Int64)>, IApplyData
        {
            public In((QArray<Qubit>,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item1)?.Qubits;
        }

        String ICallable.Name => "_TestXIfQubitEqualToIntImpl";
        String ICallable.FullName => "Utils.Compare._TestXIfQubitEqualToIntImpl";
        protected ICallable<(Boolean,Boolean,String), QVoid> MicrosoftQuantumCanonAssertBoolEqual
        {
            get;
            set;
        }

        protected ICallable<Result, Boolean> MicrosoftQuantumCanonBoolFromResult
        {
            get;
            set;
        }

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

        protected IUnitary<(QArray<Qubit>,Int64,Qubit)> XIfQubitEqualToInt
        {
            get;
            set;
        }

        protected ICallable<QArray<Qubit>, Int64> UtilsGeneralQubitsToInt
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,Int64), QVoid> Body => (__in) =>
        {
            var (a,length) = __in;
#line 60 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
            var aVal = UtilsGeneralQubitsToInt.Apply(a?.Copy());
#line 61 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
            var maxA = (2L.Pow(a.Length) - 1L);
#line 63 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
            foreach (var b in new Range(0L, maxA))
#line hidden
            {
#line hidden
                {
#line 64 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
                    var qubits = Allocate.Apply(1L);
#line 65 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
                    XIfQubitEqualToInt.Apply((a?.Copy(), b, qubits[0L]));
#line 67 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
                    var calcAns = MicrosoftQuantumCanonBoolFromResult.Apply(M.Apply(qubits[0L]));
#line 68 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
                    var trueAns = (aVal == b);
#line 69 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
                    MicrosoftQuantumCanonAssertBoolEqual.Apply((calcAns, trueAns, String.Format("{0} ?= {1}; calcAns: {2}, trueAns: {3}", aVal, b, calcAns, trueAns)));
#line 70 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
                    Message.Apply(String.Format("{0} ?= {1} passed", aVal, b));
#line 71 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
                    ResetAll.Apply(qubits?.Copy());
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
            this.MicrosoftQuantumCanonAssertBoolEqual = this.Factory.Get<ICallable<(Boolean,Boolean,String), QVoid>>(typeof(Microsoft.Quantum.Canon.AssertBoolEqual));
            this.MicrosoftQuantumCanonBoolFromResult = this.Factory.Get<ICallable<Result, Boolean>>(typeof(Microsoft.Quantum.Canon.BoolFromResult));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.M = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
            this.Message = this.Factory.Get<ICallable<String, QVoid>>(typeof(Microsoft.Quantum.Primitive.Message));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
            this.XIfQubitEqualToInt = this.Factory.Get<IUnitary<(QArray<Qubit>,Int64,Qubit)>>(typeof(XIfQubitEqualToInt));
            this.UtilsGeneralQubitsToInt = this.Factory.Get<ICallable<QArray<Qubit>, Int64>>(typeof(Utils.General.QubitsToInt));
        }

        public override IApplyData __dataIn((QArray<Qubit>,Int64) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> a, Int64 length)
        {
            return __m__.Run<_TestXIfQubitEqualToIntImpl, (QArray<Qubit>,Int64), QVoid>((a, length));
        }
    }

    public class _TestXIfQubitEqualToInt : Operation<Int64, QVoid>, ICallable
    {
        public _TestXIfQubitEqualToInt(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "_TestXIfQubitEqualToInt";
        String ICallable.FullName => "Utils.Compare._TestXIfQubitEqualToInt";
        protected ICallable<(QArray<Qubit>,Int64), QVoid> _TestXIfQubitEqualToIntImpl
        {
            get;
            set;
        }

        protected ICallable<(Int64,ICallable), QVoid> UtilsTestingRunOnAllBinariesOfLength
        {
            get;
            set;
        }

        public override Func<Int64, QVoid> Body => (__in) =>
        {
            var length = __in;
#line 76 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
            UtilsTestingRunOnAllBinariesOfLength.Apply((length, _TestXIfQubitEqualToIntImpl.Partial(new Func<QArray<Qubit>, (QArray<Qubit>,Int64)>((_arg1) => (_arg1, length)))));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this._TestXIfQubitEqualToIntImpl = this.Factory.Get<ICallable<(QArray<Qubit>,Int64), QVoid>>(typeof(_TestXIfQubitEqualToIntImpl));
            this.UtilsTestingRunOnAllBinariesOfLength = this.Factory.Get<ICallable<(Int64,ICallable), QVoid>>(typeof(Utils.Testing.RunOnAllBinariesOfLength));
        }

        public override IApplyData __dataIn(Int64 data) => new QTuple<Int64>(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Int64 length)
        {
            return __m__.Run<_TestXIfQubitEqualToInt, Int64, QVoid>(length);
        }
    }

    public class XIfLessThan : Unitary<(QArray<Qubit>,QArray<Qubit>,Qubit)>, ICallable
    {
        public XIfLessThan(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,QArray<Qubit>,Qubit)>, IApplyData
        {
            public In((QArray<Qubit>,QArray<Qubit>,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "XIfLessThan";
        String ICallable.FullName => "Utils.Compare.XIfLessThan";
        protected ICallable MicrosoftQuantumCanonHead
        {
            get;
            set;
        }

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

        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumPrimitiveCNOT
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected IUnitary<(QArray<Qubit>,QArray<Qubit>,QArray<Qubit>)> UtilsMathBitSubtractor
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,QArray<Qubit>,Qubit), QVoid> Body => (__in) =>
        {
            var (a,b,target) = __in;
#line hidden
            {
#line 81 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
                var borrows = Allocate.Apply((a.Length + 1L));
#line 82 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
                UtilsMathBitSubtractor.Apply((a?.Copy(), b?.Copy(), borrows?.Copy()));
#line 84 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
                var indicator = MicrosoftQuantumCanonHead.Apply<Qubit>(borrows);
#line 85 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
                MicrosoftQuantumPrimitiveCNOT.Apply((indicator, target));
#line 87 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
                UtilsMathBitSubtractor.Adjoint.Apply((a?.Copy(), b?.Copy(), borrows?.Copy()));
#line hidden
                Release.Apply(borrows);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,QArray<Qubit>,Qubit), QVoid> AdjointBody => (__in) =>
        {
            var (a,b,target) = __in;
#line hidden
            {
#line hidden
                var borrows = Allocate.Apply((a.Length + 1L));
#line hidden
                var indicator = MicrosoftQuantumCanonHead.Apply<Qubit>(borrows);
#line hidden
                UtilsMathBitSubtractor.Adjoint.Adjoint.Apply((a?.Copy(), b?.Copy(), borrows?.Copy()));
#line hidden
                MicrosoftQuantumPrimitiveCNOT.Adjoint.Apply((indicator, target));
#line hidden
                UtilsMathBitSubtractor.Adjoint.Apply((a?.Copy(), b?.Copy(), borrows?.Copy()));
#line hidden
                Release.Apply(borrows);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Qubit>,QArray<Qubit>,Qubit)), QVoid> ControlledBody => (__in) =>
        {
            var (__controlQubits__,(a,b,target)) = __in;
#line hidden
            {
#line hidden
                var borrows = Allocate.Apply((a.Length + 1L));
#line hidden
                UtilsMathBitSubtractor.Controlled.Apply((__controlQubits__?.Copy(), (a?.Copy(), b?.Copy(), borrows?.Copy())));
#line hidden
                var indicator = MicrosoftQuantumCanonHead.Apply<Qubit>(borrows);
#line hidden
                MicrosoftQuantumPrimitiveCNOT.Controlled.Apply((__controlQubits__?.Copy(), (indicator, target)));
#line hidden
                UtilsMathBitSubtractor.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (a?.Copy(), b?.Copy(), borrows?.Copy())));
#line hidden
                Release.Apply(borrows);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Qubit>,QArray<Qubit>,Qubit)), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (__controlQubits__,(a,b,target)) = __in;
#line hidden
            {
#line hidden
                var borrows = Allocate.Apply((a.Length + 1L));
#line hidden
                var indicator = MicrosoftQuantumCanonHead.Apply<Qubit>(borrows);
#line hidden
                UtilsMathBitSubtractor.Adjoint.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (a?.Copy(), b?.Copy(), borrows?.Copy())));
#line hidden
                MicrosoftQuantumPrimitiveCNOT.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (indicator, target)));
#line hidden
                UtilsMathBitSubtractor.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (a?.Copy(), b?.Copy(), borrows?.Copy())));
#line hidden
                Release.Apply(borrows);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonHead = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.Head<>));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.MicrosoftQuantumPrimitiveCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.CNOT));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.UtilsMathBitSubtractor = this.Factory.Get<IUnitary<(QArray<Qubit>,QArray<Qubit>,QArray<Qubit>)>>(typeof(Utils.Math.BitSubtractor));
        }

        public override IApplyData __dataIn((QArray<Qubit>,QArray<Qubit>,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> a, QArray<Qubit> b, Qubit target)
        {
            return __m__.Run<XIfLessThan, (QArray<Qubit>,QArray<Qubit>,Qubit), QVoid>((a, b, target));
        }
    }
}