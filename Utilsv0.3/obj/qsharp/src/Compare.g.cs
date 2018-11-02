#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Utils.Compare\",\"Name\":\"XIfEqual\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs\",\"Position\":{\"Item1\":5,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":19}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"a\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":20},\"Item2\":{\"Line\":1,\"Column\":21}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"b\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":32},\"Item2\":{\"Line\":1,\"Column\":33}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"target\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":44},\"Item2\":{\"Line\":1,\"Column\":50}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"},{\"Case\":\"Controlled\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Utils.Compare\",\"Name\":\"XIfEqual\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs\",\"Position\":{\"Item1\":6,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Utils.Compare\",\"Name\":\"XIfEqual\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs\",\"Position\":{\"Item1\":38,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"Parent\":{\"Namespace\":\"Utils.Compare\",\"Name\":\"XIfEqual\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs\",\"Position\":{\"Item1\":39,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":11}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"Parent\":{\"Namespace\":\"Utils.Compare\",\"Name\":\"XIfEqual\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs\",\"Position\":{\"Item1\":40,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Utils.Compare\",\"Name\":\"XIfQubitEqualToInt\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs\",\"Position\":{\"Item1\":43,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":29}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"a\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":30},\"Item2\":{\"Line\":1,\"Column\":31}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"b\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":42},\"Item2\":{\"Line\":1,\"Column\":43}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"target\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":50},\"Item2\":{\"Line\":1,\"Column\":56}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Int\"},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"},{\"Case\":\"Controlled\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Utils.Compare\",\"Name\":\"XIfQubitEqualToInt\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs\",\"Position\":{\"Item1\":44,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Utils.Compare\",\"Name\":\"XIfQubitEqualToInt\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs\",\"Position\":{\"Item1\":52,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"Parent\":{\"Namespace\":\"Utils.Compare\",\"Name\":\"XIfQubitEqualToInt\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs\",\"Position\":{\"Item1\":53,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":11}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"Parent\":{\"Namespace\":\"Utils.Compare\",\"Name\":\"XIfQubitEqualToInt\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs\",\"Position\":{\"Item1\":54,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Utils.Compare\",\"Name\":\"XIfLessThan\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs\",\"Position\":{\"Item1\":57,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"a\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":23},\"Item2\":{\"Line\":1,\"Column\":24}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"b\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":35},\"Item2\":{\"Line\":1,\"Column\":36}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"target\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":47},\"Item2\":{\"Line\":1,\"Column\":53}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"},{\"Case\":\"Controlled\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Utils.Compare\",\"Name\":\"XIfLessThan\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs\",\"Position\":{\"Item1\":58,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Utils.Compare\",\"Name\":\"XIfLessThan\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs\",\"Position\":{\"Item1\":69,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"Parent\":{\"Namespace\":\"Utils.Compare\",\"Name\":\"XIfLessThan\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs\",\"Position\":{\"Item1\":70,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":11}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"Parent\":{\"Namespace\":\"Utils.Compare\",\"Name\":\"XIfLessThan\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs\",\"Position\":{\"Item1\":71,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
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
#line 8 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
            var lenA = a.Length;
#line 9 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
            var lenB = b.Length;
#line 11 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
            if ((lenA <= lenB))
            {
#line 12 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
                foreach (var i in new Range(0L, (lenA - 1L)))
#line hidden
                {
#line 13 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
                    MicrosoftQuantumPrimitiveCNOT.Apply((a[i], b[i]));
                }

#line 16 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
                MicrosoftQuantumCanonApplyToEachCA.Apply((MicrosoftQuantumPrimitiveX, b?.Copy()));
#line 17 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
                MicrosoftQuantumPrimitiveX.Controlled.Apply((b?.Copy(), target));
#line 18 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
                MicrosoftQuantumCanonApplyToEachCA.Apply((MicrosoftQuantumPrimitiveX, b?.Copy()));
#line 20 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
                foreach (var i in new Range((lenA - 1L), -(1L), 0L))
#line hidden
                {
#line 21 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
                    MicrosoftQuantumPrimitiveCNOT.Apply((a[i], b[i]));
                }
            }
            else
            {
#line 24 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
                foreach (var i in new Range(0L, (lenB - 1L)))
#line hidden
                {
#line 25 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
                    MicrosoftQuantumPrimitiveCNOT.Apply((b[i], a[i]));
                }

#line 28 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
                MicrosoftQuantumCanonApplyToEachCA.Apply((MicrosoftQuantumPrimitiveX, a?.Copy()));
#line 29 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
                MicrosoftQuantumPrimitiveX.Controlled.Apply((a?.Copy(), target));
#line 30 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
                MicrosoftQuantumCanonApplyToEachCA.Apply((MicrosoftQuantumPrimitiveX, a?.Copy()));
#line 32 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
                foreach (var i in new Range((lenB - 1L), -(1L), 0L))
#line hidden
                {
#line 33 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
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
#line 46 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
                var bQubit = Allocate.Apply((a.Length + 1L));
#line 47 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
                UtilsMathQFTAdderInt.Apply((bQubit?.Copy(), b));
#line 48 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
                XIfEqual.Apply((a?.Copy(), bQubit?.Copy(), target));
#line 49 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
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
                var bQubit = Allocate.Apply((a.Length + 1L));
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
                var bQubit = Allocate.Apply((a.Length + 1L));
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
                var bQubit = Allocate.Apply((a.Length + 1L));
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
#line 60 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
                var borrows = Allocate.Apply((a.Length + 1L));
#line 61 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
                UtilsMathBitSubtractor.Apply((a?.Copy(), b?.Copy(), borrows?.Copy()));
#line 63 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
                var indicator = MicrosoftQuantumCanonHead.Apply<Qubit>(borrows);
#line 64 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
                MicrosoftQuantumPrimitiveCNOT.Apply((indicator, target));
#line 66 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
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