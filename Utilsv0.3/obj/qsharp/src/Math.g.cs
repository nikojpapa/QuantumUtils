#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"Utils.Math\",\"Name\":\"CeilLogBase2\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs\",\"Position\":{\"Item1\":5,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":22}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"Double\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":23},\"Item2\":{\"Line\":1,\"Column\":24}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Double\"},\"ReturnType\":{\"Case\":\"Int\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Utils.Math\",\"Name\":\"CeilLogBase2\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs\",\"Position\":{\"Item1\":5,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":22}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"Utils.Math\",\"Name\":\"ClassicalSum\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs\",\"Position\":{\"Item1\":9,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":22}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"arr\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":24},\"Item2\":{\"Line\":1,\"Column\":27}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"ReturnType\":{\"Case\":\"Int\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Utils.Math\",\"Name\":\"ClassicalSum\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs\",\"Position\":{\"Item1\":9,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":22}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Utils.Math\",\"Name\":\"QFTAdder\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs\",\"Position\":{\"Item1\":18,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":19}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"start\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":20},\"Item2\":{\"Line\":1,\"Column\":25}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"amount\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":36},\"Item2\":{\"Line\":1,\"Column\":42}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"},{\"Case\":\"Controlled\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Utils.Math\",\"Name\":\"QFTAdder\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs\",\"Position\":{\"Item1\":19,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Utils.Math\",\"Name\":\"QFTAdder\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs\",\"Position\":{\"Item1\":32,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"Parent\":{\"Namespace\":\"Utils.Math\",\"Name\":\"QFTAdder\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs\",\"Position\":{\"Item1\":33,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":11}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"Parent\":{\"Namespace\":\"Utils.Math\",\"Name\":\"QFTAdder\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs\",\"Position\":{\"Item1\":34,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Utils.Math\",\"Name\":\"QFTAdderInt\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs\",\"Position\":{\"Item1\":37,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"start\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":23},\"Item2\":{\"Line\":1,\"Column\":28}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"amount\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":39},\"Item2\":{\"Line\":1,\"Column\":45}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"},{\"Case\":\"Controlled\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Utils.Math\",\"Name\":\"QFTAdderInt\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs\",\"Position\":{\"Item1\":38,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Utils.Math\",\"Name\":\"QFTAdderInt\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs\",\"Position\":{\"Item1\":46,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"Parent\":{\"Namespace\":\"Utils.Math\",\"Name\":\"QFTAdderInt\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs\",\"Position\":{\"Item1\":47,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":11}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"Parent\":{\"Namespace\":\"Utils.Math\",\"Name\":\"QFTAdderInt\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs\",\"Position\":{\"Item1\":48,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Utils.Math\",\"Name\":\"QFTSubtractor\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs\",\"Position\":{\"Item1\":51,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"start\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":25},\"Item2\":{\"Line\":1,\"Column\":30}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"amount\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":41},\"Item2\":{\"Line\":1,\"Column\":47}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"},{\"Case\":\"Controlled\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Utils.Math\",\"Name\":\"QFTSubtractor\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs\",\"Position\":{\"Item1\":52,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Utils.Math\",\"Name\":\"QFTSubtractor\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs\",\"Position\":{\"Item1\":60,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"Parent\":{\"Namespace\":\"Utils.Math\",\"Name\":\"QFTSubtractor\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs\",\"Position\":{\"Item1\":61,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":11}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"Parent\":{\"Namespace\":\"Utils.Math\",\"Name\":\"QFTSubtractor\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs\",\"Position\":{\"Item1\":62,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Utils.Math\",\"Name\":\"_SubtractBit\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs\",\"Position\":{\"Item1\":65,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":23}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"t1\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":24},\"Item2\":{\"Line\":1,\"Column\":26}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"t2\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":35},\"Item2\":{\"Line\":1,\"Column\":37}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"borrowIn\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":46},\"Item2\":{\"Line\":1,\"Column\":54}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"borrowOut\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":63},\"Item2\":{\"Line\":1,\"Column\":72}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Qubit\"},{\"Case\":\"Qubit\"},{\"Case\":\"Qubit\"},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"},{\"Case\":\"Controlled\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Utils.Math\",\"Name\":\"_SubtractBit\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs\",\"Position\":{\"Item1\":66,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Utils.Math\",\"Name\":\"_SubtractBit\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs\",\"Position\":{\"Item1\":78,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"Parent\":{\"Namespace\":\"Utils.Math\",\"Name\":\"_SubtractBit\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs\",\"Position\":{\"Item1\":79,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":11}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"Parent\":{\"Namespace\":\"Utils.Math\",\"Name\":\"_SubtractBit\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs\",\"Position\":{\"Item1\":80,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Utils.Math\",\"Name\":\"BitSubtractor\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs\",\"Position\":{\"Item1\":83,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"start\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":25},\"Item2\":{\"Line\":1,\"Column\":30}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"amount\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":41},\"Item2\":{\"Line\":1,\"Column\":47}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"borrows\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":58},\"Item2\":{\"Line\":1,\"Column\":65}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"},{\"Case\":\"Controlled\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Utils.Math\",\"Name\":\"BitSubtractor\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs\",\"Position\":{\"Item1\":84,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Utils.Math\",\"Name\":\"BitSubtractor\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs\",\"Position\":{\"Item1\":101,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"Parent\":{\"Namespace\":\"Utils.Math\",\"Name\":\"BitSubtractor\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs\",\"Position\":{\"Item1\":102,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":11}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"Parent\":{\"Namespace\":\"Utils.Math\",\"Name\":\"BitSubtractor\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs\",\"Position\":{\"Item1\":103,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
#line hidden
namespace Utils.Math
{
    public class CeilLogBase2 : Function<Double, Int64>, ICallable
    {
        public CeilLogBase2(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "CeilLogBase2";
        String ICallable.FullName => "Utils.Math.CeilLogBase2";
        protected ICallable<Double, Int64> MicrosoftQuantumExtensionsMathCeiling
        {
            get;
            set;
        }

        protected ICallable<Double, Double> MicrosoftQuantumExtensionsMathLog
        {
            get;
            set;
        }

        public override Func<Double, Int64> Body => (__in) =>
        {
            var x = __in;
#line 7 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs"
            return MicrosoftQuantumExtensionsMathCeiling.Apply((MicrosoftQuantumExtensionsMathLog.Apply(x) / MicrosoftQuantumExtensionsMathLog.Apply(2D)));
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumExtensionsMathCeiling = this.Factory.Get<ICallable<Double, Int64>>(typeof(Microsoft.Quantum.Extensions.Math.Ceiling));
            this.MicrosoftQuantumExtensionsMathLog = this.Factory.Get<ICallable<Double, Double>>(typeof(Microsoft.Quantum.Extensions.Math.Log));
        }

        public override IApplyData __dataIn(Double data) => new QTuple<Double>(data);
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, Double x)
        {
            return __m__.Run<CeilLogBase2, Double, Int64>(x);
        }
    }

    public class ClassicalSum : Function<QArray<Int64>, Int64>, ICallable
    {
        public ClassicalSum(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "ClassicalSum";
        String ICallable.FullName => "Utils.Math.ClassicalSum";
        protected ICallable Length
        {
            get;
            set;
        }

        public override Func<QArray<Int64>, Int64> Body => (__in) =>
        {
            var arr = __in;
#line 11 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs"
            var sum = 0L;
#line 12 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs"
            foreach (var i in new Range(0L, (arr.Length - 1L)))
#line hidden
            {
#line 13 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs"
                sum = (sum + arr[i]);
            }

#line 16 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs"
            return sum;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
        }

        public override IApplyData __dataIn(QArray<Int64> data) => data;
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, QArray<Int64> arr)
        {
            return __m__.Run<ClassicalSum, QArray<Int64>, Int64>(arr);
        }
    }

    public class QFTAdder : Unitary<(QArray<Qubit>,QArray<Qubit>)>, ICallable
    {
        public QFTAdder(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,QArray<Qubit>)>, IApplyData
        {
            public In((QArray<Qubit>,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "QFTAdder";
        String ICallable.FullName => "Utils.Math.QFTAdder";
        protected IUnitary MicrosoftQuantumCanonApplyToEachIndexCA
        {
            get;
            set;
        }

        protected IUnitary<Microsoft.Quantum.Canon.BigEndian> MicrosoftQuantumCanonQFT
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

        protected IUnitary<(Int64,Int64,Qubit)> MicrosoftQuantumPrimitiveR1Frac
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,QArray<Qubit>), QVoid> Body => (__in) =>
        {
            var (start,amount) = __in;
#line 21 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs"
            var bigEndian = new Microsoft.Quantum.Canon.BigEndian(start?.Copy());
#line 23 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs"
            MicrosoftQuantumCanonQFT.Apply(bigEndian);
#line 25 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs"
            foreach (var i in new Range((amount.Length - 1L), -(1L), 0L))
#line hidden
            {
#line 26 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs"
                var add = 2L.Pow(((amount.Length - 1L) - i));
#line 27 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs"
                MicrosoftQuantumCanonApplyToEachIndexCA.Apply((MicrosoftQuantumPrimitiveR1Frac.Controlled.Partial(new Func<(Int64,Qubit), (QArray<Qubit>,(Int64,Int64,Qubit))>((_arg1) => (new QArray<Qubit>()
                {amount[i]}, (add, _arg1.Item1, _arg1.Item2)))), start?.Copy()));
            }

#line 30 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs"
            MicrosoftQuantumCanonQFT.Adjoint.Apply(bigEndian);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,QArray<Qubit>), QVoid> AdjointBody => (__in) =>
        {
            var (start,amount) = __in;
#line hidden
            var bigEndian = new Microsoft.Quantum.Canon.BigEndian(start?.Copy());
#line hidden
            MicrosoftQuantumCanonQFT.Adjoint.Adjoint.Apply(bigEndian);
#line hidden
            foreach (var i in RangeReverse.Apply(new Range((amount.Length - 1L), -(1L), 0L)))
#line hidden
            {
#line hidden
                var add = 2L.Pow(((amount.Length - 1L) - i));
#line hidden
                MicrosoftQuantumCanonApplyToEachIndexCA.Adjoint.Apply((MicrosoftQuantumPrimitiveR1Frac.Controlled.Partial(new Func<(Int64,Qubit), (QArray<Qubit>,(Int64,Int64,Qubit))>((_arg1) => (new QArray<Qubit>()
                {amount[i]}, (add, _arg1.Item1, _arg1.Item2)))), start?.Copy()));
            }

#line hidden
            MicrosoftQuantumCanonQFT.Adjoint.Apply(bigEndian);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Qubit>,QArray<Qubit>)), QVoid> ControlledBody => (__in) =>
        {
            var (__controlQubits__,(start,amount)) = __in;
#line hidden
            var bigEndian = new Microsoft.Quantum.Canon.BigEndian(start?.Copy());
#line hidden
            MicrosoftQuantumCanonQFT.Controlled.Apply((__controlQubits__?.Copy(), bigEndian));
#line hidden
            foreach (var i in new Range((amount.Length - 1L), -(1L), 0L))
#line hidden
            {
#line hidden
                var add = 2L.Pow(((amount.Length - 1L) - i));
#line hidden
                MicrosoftQuantumCanonApplyToEachIndexCA.Controlled.Apply((__controlQubits__?.Copy(), (MicrosoftQuantumPrimitiveR1Frac.Controlled.Partial(new Func<(Int64,Qubit), (QArray<Qubit>,(Int64,Int64,Qubit))>((_arg1) => (new QArray<Qubit>()
                {amount[i]}, (add, _arg1.Item1, _arg1.Item2)))), start?.Copy())));
            }

#line hidden
            MicrosoftQuantumCanonQFT.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), bigEndian));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Qubit>,QArray<Qubit>)), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (__controlQubits__,(start,amount)) = __in;
#line hidden
            var bigEndian = new Microsoft.Quantum.Canon.BigEndian(start?.Copy());
#line hidden
            MicrosoftQuantumCanonQFT.Adjoint.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), bigEndian));
#line hidden
            foreach (var i in RangeReverse.Apply(new Range((amount.Length - 1L), -(1L), 0L)))
#line hidden
            {
#line hidden
                var add = 2L.Pow(((amount.Length - 1L) - i));
#line hidden
                MicrosoftQuantumCanonApplyToEachIndexCA.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (MicrosoftQuantumPrimitiveR1Frac.Controlled.Partial(new Func<(Int64,Qubit), (QArray<Qubit>,(Int64,Int64,Qubit))>((_arg1) => (new QArray<Qubit>()
                {amount[i]}, (add, _arg1.Item1, _arg1.Item2)))), start?.Copy())));
            }

#line hidden
            MicrosoftQuantumCanonQFT.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), bigEndian));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonApplyToEachIndexCA = this.Factory.Get<IUnitary>(typeof(Microsoft.Quantum.Canon.ApplyToEachIndexCA<>));
            this.MicrosoftQuantumCanonQFT = this.Factory.Get<IUnitary<Microsoft.Quantum.Canon.BigEndian>>(typeof(Microsoft.Quantum.Canon.QFT));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.RangeReverse = this.Factory.Get<ICallable<Range, Range>>(typeof(Microsoft.Quantum.Core.RangeReverse));
            this.MicrosoftQuantumPrimitiveR1Frac = this.Factory.Get<IUnitary<(Int64,Int64,Qubit)>>(typeof(Microsoft.Quantum.Primitive.R1Frac));
        }

        public override IApplyData __dataIn((QArray<Qubit>,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> start, QArray<Qubit> amount)
        {
            return __m__.Run<QFTAdder, (QArray<Qubit>,QArray<Qubit>), QVoid>((start, amount));
        }
    }

    public class QFTAdderInt : Unitary<(QArray<Qubit>,Int64)>, ICallable
    {
        public QFTAdderInt(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,Int64)>, IApplyData
        {
            public In((QArray<Qubit>,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item1)?.Qubits;
        }

        String ICallable.Name => "QFTAdderInt";
        String ICallable.FullName => "Utils.Math.QFTAdderInt";
        protected IUnitary MicrosoftQuantumCanonApplyToEachIndexCA
        {
            get;
            set;
        }

        protected IUnitary<Microsoft.Quantum.Canon.BigEndian> MicrosoftQuantumCanonQFT
        {
            get;
            set;
        }

        protected IUnitary<(Int64,Int64,Qubit)> MicrosoftQuantumPrimitiveR1Frac
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,Int64), QVoid> Body => (__in) =>
        {
            var (start,amount) = __in;
#line 40 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs"
            var bigEndian = new Microsoft.Quantum.Canon.BigEndian(start?.Copy());
#line 42 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs"
            MicrosoftQuantumCanonQFT.Apply(bigEndian);
#line 43 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs"
            MicrosoftQuantumCanonApplyToEachIndexCA.Apply((MicrosoftQuantumPrimitiveR1Frac.Partial(new Func<(Int64,Qubit), (Int64,Int64,Qubit)>((_arg1) => (amount, _arg1.Item1, _arg1.Item2))), start?.Copy()));
#line 44 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs"
            MicrosoftQuantumCanonQFT.Adjoint.Apply(bigEndian);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,Int64), QVoid> AdjointBody => (__in) =>
        {
            var (start,amount) = __in;
#line hidden
            var bigEndian = new Microsoft.Quantum.Canon.BigEndian(start?.Copy());
#line hidden
            MicrosoftQuantumCanonQFT.Adjoint.Adjoint.Apply(bigEndian);
#line hidden
            MicrosoftQuantumCanonApplyToEachIndexCA.Adjoint.Apply((MicrosoftQuantumPrimitiveR1Frac.Partial(new Func<(Int64,Qubit), (Int64,Int64,Qubit)>((_arg1) => (amount, _arg1.Item1, _arg1.Item2))), start?.Copy()));
#line hidden
            MicrosoftQuantumCanonQFT.Adjoint.Apply(bigEndian);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Qubit>,Int64)), QVoid> ControlledBody => (__in) =>
        {
            var (__controlQubits__,(start,amount)) = __in;
#line hidden
            var bigEndian = new Microsoft.Quantum.Canon.BigEndian(start?.Copy());
#line hidden
            MicrosoftQuantumCanonQFT.Controlled.Apply((__controlQubits__?.Copy(), bigEndian));
#line hidden
            MicrosoftQuantumCanonApplyToEachIndexCA.Controlled.Apply((__controlQubits__?.Copy(), (MicrosoftQuantumPrimitiveR1Frac.Partial(new Func<(Int64,Qubit), (Int64,Int64,Qubit)>((_arg1) => (amount, _arg1.Item1, _arg1.Item2))), start?.Copy())));
#line hidden
            MicrosoftQuantumCanonQFT.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), bigEndian));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Qubit>,Int64)), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (__controlQubits__,(start,amount)) = __in;
#line hidden
            var bigEndian = new Microsoft.Quantum.Canon.BigEndian(start?.Copy());
#line hidden
            MicrosoftQuantumCanonQFT.Adjoint.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), bigEndian));
#line hidden
            MicrosoftQuantumCanonApplyToEachIndexCA.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (MicrosoftQuantumPrimitiveR1Frac.Partial(new Func<(Int64,Qubit), (Int64,Int64,Qubit)>((_arg1) => (amount, _arg1.Item1, _arg1.Item2))), start?.Copy())));
#line hidden
            MicrosoftQuantumCanonQFT.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), bigEndian));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonApplyToEachIndexCA = this.Factory.Get<IUnitary>(typeof(Microsoft.Quantum.Canon.ApplyToEachIndexCA<>));
            this.MicrosoftQuantumCanonQFT = this.Factory.Get<IUnitary<Microsoft.Quantum.Canon.BigEndian>>(typeof(Microsoft.Quantum.Canon.QFT));
            this.MicrosoftQuantumPrimitiveR1Frac = this.Factory.Get<IUnitary<(Int64,Int64,Qubit)>>(typeof(Microsoft.Quantum.Primitive.R1Frac));
        }

        public override IApplyData __dataIn((QArray<Qubit>,Int64) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> start, Int64 amount)
        {
            return __m__.Run<QFTAdderInt, (QArray<Qubit>,Int64), QVoid>((start, amount));
        }
    }

    public class QFTSubtractor : Unitary<(QArray<Qubit>,Int64)>, ICallable
    {
        public QFTSubtractor(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,Int64)>, IApplyData
        {
            public In((QArray<Qubit>,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item1)?.Qubits;
        }

        String ICallable.Name => "QFTSubtractor";
        String ICallable.FullName => "Utils.Math.QFTSubtractor";
        protected IUnitary MicrosoftQuantumCanonApplyToEachIndexCA
        {
            get;
            set;
        }

        protected IUnitary<Microsoft.Quantum.Canon.BigEndian> MicrosoftQuantumCanonQFT
        {
            get;
            set;
        }

        protected IUnitary<(Int64,Int64,Qubit)> MicrosoftQuantumPrimitiveR1Frac
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,Int64), QVoid> Body => (__in) =>
        {
            var (start,amount) = __in;
#line 54 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs"
            var bigEndian = new Microsoft.Quantum.Canon.BigEndian(start?.Copy());
#line 56 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs"
            MicrosoftQuantumCanonQFT.Apply(bigEndian);
#line 57 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs"
            MicrosoftQuantumCanonApplyToEachIndexCA.Apply((MicrosoftQuantumPrimitiveR1Frac.Partial(new Func<(Int64,Qubit), (Int64,Int64,Qubit)>((_arg1) => (-(amount), _arg1.Item1, _arg1.Item2))), start?.Copy()));
#line 58 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs"
            MicrosoftQuantumCanonQFT.Adjoint.Apply(bigEndian);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,Int64), QVoid> AdjointBody => (__in) =>
        {
            var (start,amount) = __in;
#line hidden
            var bigEndian = new Microsoft.Quantum.Canon.BigEndian(start?.Copy());
#line hidden
            MicrosoftQuantumCanonQFT.Adjoint.Adjoint.Apply(bigEndian);
#line hidden
            MicrosoftQuantumCanonApplyToEachIndexCA.Adjoint.Apply((MicrosoftQuantumPrimitiveR1Frac.Partial(new Func<(Int64,Qubit), (Int64,Int64,Qubit)>((_arg1) => (-(amount), _arg1.Item1, _arg1.Item2))), start?.Copy()));
#line hidden
            MicrosoftQuantumCanonQFT.Adjoint.Apply(bigEndian);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Qubit>,Int64)), QVoid> ControlledBody => (__in) =>
        {
            var (__controlQubits__,(start,amount)) = __in;
#line hidden
            var bigEndian = new Microsoft.Quantum.Canon.BigEndian(start?.Copy());
#line hidden
            MicrosoftQuantumCanonQFT.Controlled.Apply((__controlQubits__?.Copy(), bigEndian));
#line hidden
            MicrosoftQuantumCanonApplyToEachIndexCA.Controlled.Apply((__controlQubits__?.Copy(), (MicrosoftQuantumPrimitiveR1Frac.Partial(new Func<(Int64,Qubit), (Int64,Int64,Qubit)>((_arg1) => (-(amount), _arg1.Item1, _arg1.Item2))), start?.Copy())));
#line hidden
            MicrosoftQuantumCanonQFT.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), bigEndian));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Qubit>,Int64)), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (__controlQubits__,(start,amount)) = __in;
#line hidden
            var bigEndian = new Microsoft.Quantum.Canon.BigEndian(start?.Copy());
#line hidden
            MicrosoftQuantumCanonQFT.Adjoint.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), bigEndian));
#line hidden
            MicrosoftQuantumCanonApplyToEachIndexCA.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (MicrosoftQuantumPrimitiveR1Frac.Partial(new Func<(Int64,Qubit), (Int64,Int64,Qubit)>((_arg1) => (-(amount), _arg1.Item1, _arg1.Item2))), start?.Copy())));
#line hidden
            MicrosoftQuantumCanonQFT.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), bigEndian));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonApplyToEachIndexCA = this.Factory.Get<IUnitary>(typeof(Microsoft.Quantum.Canon.ApplyToEachIndexCA<>));
            this.MicrosoftQuantumCanonQFT = this.Factory.Get<IUnitary<Microsoft.Quantum.Canon.BigEndian>>(typeof(Microsoft.Quantum.Canon.QFT));
            this.MicrosoftQuantumPrimitiveR1Frac = this.Factory.Get<IUnitary<(Int64,Int64,Qubit)>>(typeof(Microsoft.Quantum.Primitive.R1Frac));
        }

        public override IApplyData __dataIn((QArray<Qubit>,Int64) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> start, Int64 amount)
        {
            return __m__.Run<QFTSubtractor, (QArray<Qubit>,Int64), QVoid>((start, amount));
        }
    }

    public class _SubtractBit : Unitary<(Qubit,Qubit,Qubit,Qubit)>, ICallable
    {
        public _SubtractBit(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Qubit,Qubit,Qubit,Qubit)>, IApplyData
        {
            public In((Qubit,Qubit,Qubit,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits
            {
                get
                {
                    yield return Data.Item1;
                    yield return Data.Item2;
                    yield return Data.Item3;
                    yield return Data.Item4;
                }
            }
        }

        String ICallable.Name => "_SubtractBit";
        String ICallable.FullName => "Utils.Math._SubtractBit";
        protected IUnitary MicrosoftQuantumCanonApplyToEachCA
        {
            get;
            set;
        }

        protected IUnitary<(QArray<Pauli>,QArray<Qubit>,Result,String)> Assert
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

        public override Func<(Qubit,Qubit,Qubit,Qubit), QVoid> Body => (__in) =>
        {
            var (t1,t2,borrowIn,borrowOut) = __in;
#line 68 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs"
            Assert.Apply((new QArray<Pauli>()
            {Pauli.PauliZ}, new QArray<Qubit>()
            {borrowOut}, Result.Zero, "Borrow out is not in |0> state"));
#line 70 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs"
            MicrosoftQuantumPrimitiveX.Apply(t1);
#line 71 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs"
            MicrosoftQuantumPrimitiveX.Controlled.Apply((new QArray<Qubit>(t1, t2), borrowOut));
#line 72 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs"
            MicrosoftQuantumPrimitiveX.Controlled.Apply((new QArray<Qubit>(t1, borrowIn), borrowOut));
#line 73 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs"
            MicrosoftQuantumPrimitiveX.Controlled.Apply((new QArray<Qubit>(t2, borrowIn), borrowOut));
#line 74 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs"
            MicrosoftQuantumPrimitiveX.Apply(t1);
#line 76 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs"
            MicrosoftQuantumCanonApplyToEachCA.Apply((MicrosoftQuantumPrimitiveCNOT.Partial(new Func<Qubit, (Qubit,Qubit)>((_arg1) => (_arg1, t1))), new QArray<Qubit>(t2, borrowIn)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(Qubit,Qubit,Qubit,Qubit), QVoid> AdjointBody => (__in) =>
        {
            var (t1,t2,borrowIn,borrowOut) = __in;
#line hidden
            MicrosoftQuantumCanonApplyToEachCA.Adjoint.Apply((MicrosoftQuantumPrimitiveCNOT.Partial(new Func<Qubit, (Qubit,Qubit)>((_arg1) => (_arg1, t1))), new QArray<Qubit>(t2, borrowIn)));
#line hidden
            MicrosoftQuantumPrimitiveX.Adjoint.Apply(t1);
#line hidden
            MicrosoftQuantumPrimitiveX.Controlled.Adjoint.Apply((new QArray<Qubit>(t2, borrowIn), borrowOut));
#line hidden
            MicrosoftQuantumPrimitiveX.Controlled.Adjoint.Apply((new QArray<Qubit>(t1, borrowIn), borrowOut));
#line hidden
            MicrosoftQuantumPrimitiveX.Controlled.Adjoint.Apply((new QArray<Qubit>(t1, t2), borrowOut));
#line hidden
            MicrosoftQuantumPrimitiveX.Adjoint.Apply(t1);
#line hidden
            Assert.Adjoint.Apply((new QArray<Pauli>()
            {Pauli.PauliZ}, new QArray<Qubit>()
            {borrowOut}, Result.Zero, "Borrow out is not in |0> state"));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(Qubit,Qubit,Qubit,Qubit)), QVoid> ControlledBody => (__in) =>
        {
            var (__controlQubits__,(t1,t2,borrowIn,borrowOut)) = __in;
#line hidden
            Assert.Controlled.Apply((__controlQubits__?.Copy(), (new QArray<Pauli>()
            {Pauli.PauliZ}, new QArray<Qubit>()
            {borrowOut}, Result.Zero, "Borrow out is not in |0> state")));
#line hidden
            MicrosoftQuantumPrimitiveX.Controlled.Apply((__controlQubits__?.Copy(), t1));
#line hidden
            MicrosoftQuantumPrimitiveX.Controlled.Controlled.Apply((__controlQubits__?.Copy(), (new QArray<Qubit>(t1, t2), borrowOut)));
#line hidden
            MicrosoftQuantumPrimitiveX.Controlled.Controlled.Apply((__controlQubits__?.Copy(), (new QArray<Qubit>(t1, borrowIn), borrowOut)));
#line hidden
            MicrosoftQuantumPrimitiveX.Controlled.Controlled.Apply((__controlQubits__?.Copy(), (new QArray<Qubit>(t2, borrowIn), borrowOut)));
#line hidden
            MicrosoftQuantumPrimitiveX.Controlled.Apply((__controlQubits__?.Copy(), t1));
#line hidden
            MicrosoftQuantumCanonApplyToEachCA.Controlled.Apply((__controlQubits__?.Copy(), (MicrosoftQuantumPrimitiveCNOT.Partial(new Func<Qubit, (Qubit,Qubit)>((_arg1) => (_arg1, t1))), new QArray<Qubit>(t2, borrowIn))));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(Qubit,Qubit,Qubit,Qubit)), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (__controlQubits__,(t1,t2,borrowIn,borrowOut)) = __in;
#line hidden
            MicrosoftQuantumCanonApplyToEachCA.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (MicrosoftQuantumPrimitiveCNOT.Partial(new Func<Qubit, (Qubit,Qubit)>((_arg1) => (_arg1, t1))), new QArray<Qubit>(t2, borrowIn))));
#line hidden
            MicrosoftQuantumPrimitiveX.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), t1));
#line hidden
            MicrosoftQuantumPrimitiveX.Controlled.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (new QArray<Qubit>(t2, borrowIn), borrowOut)));
#line hidden
            MicrosoftQuantumPrimitiveX.Controlled.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (new QArray<Qubit>(t1, borrowIn), borrowOut)));
#line hidden
            MicrosoftQuantumPrimitiveX.Controlled.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (new QArray<Qubit>(t1, t2), borrowOut)));
#line hidden
            MicrosoftQuantumPrimitiveX.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), t1));
#line hidden
            Assert.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (new QArray<Pauli>()
            {Pauli.PauliZ}, new QArray<Qubit>()
            {borrowOut}, Result.Zero, "Borrow out is not in |0> state")));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonApplyToEachCA = this.Factory.Get<IUnitary>(typeof(Microsoft.Quantum.Canon.ApplyToEachCA<>));
            this.Assert = this.Factory.Get<IUnitary<(QArray<Pauli>,QArray<Qubit>,Result,String)>>(typeof(Microsoft.Quantum.Primitive.Assert));
            this.MicrosoftQuantumPrimitiveCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.CNOT));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn((Qubit,Qubit,Qubit,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit t1, Qubit t2, Qubit borrowIn, Qubit borrowOut)
        {
            return __m__.Run<_SubtractBit, (Qubit,Qubit,Qubit,Qubit), QVoid>((t1, t2, borrowIn, borrowOut));
        }
    }

    public class BitSubtractor : Unitary<(QArray<Qubit>,QArray<Qubit>,QArray<Qubit>)>, ICallable
    {
        public BitSubtractor(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,QArray<Qubit>,QArray<Qubit>)>, IApplyData
        {
            public In((QArray<Qubit>,QArray<Qubit>,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "BitSubtractor";
        String ICallable.FullName => "Utils.Math.BitSubtractor";
        protected ICallable<(Boolean,Boolean,String), QVoid> MicrosoftQuantumCanonAssertBoolEqual
        {
            get;
            set;
        }

        protected ICallable<(Int64,Int64,String), QVoid> MicrosoftQuantumCanonAssertIntEqual
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

        protected IUnitary<(Qubit,Qubit,Qubit,Qubit)> _SubtractBit
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,QArray<Qubit>,QArray<Qubit>), QVoid> Body => (__in) =>
        {
            var (start,amount,borrows) = __in;
#line 86 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs"
            MicrosoftQuantumCanonAssertBoolEqual.Apply(((start.Length >= amount.Length), true, "unequal operand lengths"));
#line 87 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs"
            MicrosoftQuantumCanonAssertIntEqual.Apply(((start.Length + 1L), borrows.Length, "not right amount of borrows"));
#line hidden
            {
#line 89 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs"
                var padding = Allocate.Apply(1L);
#line 90 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs"
                foreach (var j in new Range((start.Length - 1L), -(1L), 0L))
#line hidden
                {
#line 91 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs"
                    var sop = _SubtractBit.Partial(new Func<Qubit, (Qubit,Qubit,Qubit,Qubit)>((_arg1) => (start[j], _arg1, borrows[(j + 1L)], borrows[j])));
#line 92 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs"
                    if ((j >= (start.Length - amount.Length)))
                    {
#line 93 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs"
                        sop.Apply(amount[((j - start.Length) + amount.Length)]);
                    }
                    else
                    {
#line 95 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs"
                        sop.Apply(padding[0L]);
                    }
                }

#line hidden
                Release.Apply(padding);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,QArray<Qubit>,QArray<Qubit>), QVoid> AdjointBody => (__in) =>
        {
            var (start,amount,borrows) = __in;
#line hidden
            MicrosoftQuantumCanonAssertBoolEqual.Apply(((start.Length >= amount.Length), true, "unequal operand lengths"));
#line hidden
            MicrosoftQuantumCanonAssertIntEqual.Apply(((start.Length + 1L), borrows.Length, "not right amount of borrows"));
#line hidden
            {
#line hidden
                var padding = Allocate.Apply(1L);
#line hidden
                foreach (var j in RangeReverse.Apply(new Range((start.Length - 1L), -(1L), 0L)))
#line hidden
                {
#line hidden
                    var sop = _SubtractBit.Partial(new Func<Qubit, (Qubit,Qubit,Qubit,Qubit)>((_arg1) => (start[j], _arg1, borrows[(j + 1L)], borrows[j])));
#line hidden
                    if ((j >= (start.Length - amount.Length)))
                    {
#line hidden
                        sop.Adjoint.Apply(amount[((j - start.Length) + amount.Length)]);
                    }
                    else
                    {
#line hidden
                        sop.Adjoint.Apply(padding[0L]);
                    }
                }

#line hidden
                Release.Apply(padding);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Qubit>,QArray<Qubit>,QArray<Qubit>)), QVoid> ControlledBody => (__in) =>
        {
            var (__controlQubits__,(start,amount,borrows)) = __in;
#line hidden
            MicrosoftQuantumCanonAssertBoolEqual.Apply(((start.Length >= amount.Length), true, "unequal operand lengths"));
#line hidden
            MicrosoftQuantumCanonAssertIntEqual.Apply(((start.Length + 1L), borrows.Length, "not right amount of borrows"));
#line hidden
            {
#line hidden
                var padding = Allocate.Apply(1L);
#line hidden
                foreach (var j in new Range((start.Length - 1L), -(1L), 0L))
#line hidden
                {
#line hidden
                    var sop = _SubtractBit.Partial(new Func<Qubit, (Qubit,Qubit,Qubit,Qubit)>((_arg1) => (start[j], _arg1, borrows[(j + 1L)], borrows[j])));
#line hidden
                    if ((j >= (start.Length - amount.Length)))
                    {
#line hidden
                        sop.Controlled.Apply((__controlQubits__?.Copy(), amount[((j - start.Length) + amount.Length)]));
                    }
                    else
                    {
#line hidden
                        sop.Controlled.Apply((__controlQubits__?.Copy(), padding[0L]));
                    }
                }

#line hidden
                Release.Apply(padding);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Qubit>,QArray<Qubit>,QArray<Qubit>)), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (__controlQubits__,(start,amount,borrows)) = __in;
#line hidden
            MicrosoftQuantumCanonAssertBoolEqual.Apply(((start.Length >= amount.Length), true, "unequal operand lengths"));
#line hidden
            MicrosoftQuantumCanonAssertIntEqual.Apply(((start.Length + 1L), borrows.Length, "not right amount of borrows"));
#line hidden
            {
#line hidden
                var padding = Allocate.Apply(1L);
#line hidden
                foreach (var j in RangeReverse.Apply(new Range((start.Length - 1L), -(1L), 0L)))
#line hidden
                {
#line hidden
                    var sop = _SubtractBit.Partial(new Func<Qubit, (Qubit,Qubit,Qubit,Qubit)>((_arg1) => (start[j], _arg1, borrows[(j + 1L)], borrows[j])));
#line hidden
                    if ((j >= (start.Length - amount.Length)))
                    {
#line hidden
                        sop.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), amount[((j - start.Length) + amount.Length)]));
                    }
                    else
                    {
#line hidden
                        sop.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), padding[0L]));
                    }
                }

#line hidden
                Release.Apply(padding);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonAssertBoolEqual = this.Factory.Get<ICallable<(Boolean,Boolean,String), QVoid>>(typeof(Microsoft.Quantum.Canon.AssertBoolEqual));
            this.MicrosoftQuantumCanonAssertIntEqual = this.Factory.Get<ICallable<(Int64,Int64,String), QVoid>>(typeof(Microsoft.Quantum.Canon.AssertIntEqual));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.RangeReverse = this.Factory.Get<ICallable<Range, Range>>(typeof(Microsoft.Quantum.Core.RangeReverse));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this._SubtractBit = this.Factory.Get<IUnitary<(Qubit,Qubit,Qubit,Qubit)>>(typeof(_SubtractBit));
        }

        public override IApplyData __dataIn((QArray<Qubit>,QArray<Qubit>,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> start, QArray<Qubit> amount, QArray<Qubit> borrows)
        {
            return __m__.Run<BitSubtractor, (QArray<Qubit>,QArray<Qubit>,QArray<Qubit>), QVoid>((start, amount, borrows));
        }
    }
}