#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Intrinsic;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"Utils.Math\",\"Name\":\"CeilLogBase2\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs\",\"Position\":{\"Item1\":6,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":22}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"Double\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":23},\"Item2\":{\"Line\":1,\"Column\":24}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Double\"},\"ReturnType\":{\"Case\":\"Int\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Utils.Math\",\"Name\":\"CeilLogBase2\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs\",\"Position\":{\"Item1\":6,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":22}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"Utils.Math\",\"Name\":\"ClassicalSum\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs\",\"Position\":{\"Item1\":10,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":22}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"arr\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":24},\"Item2\":{\"Line\":1,\"Column\":27}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"ReturnType\":{\"Case\":\"Int\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Utils.Math\",\"Name\":\"ClassicalSum\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs\",\"Position\":{\"Item1\":10,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":22}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Utils.Math\",\"Name\":\"QFTAdder\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs\",\"Position\":{\"Item1\":19,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":19}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"start\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":20},\"Item2\":{\"Line\":1,\"Column\":25}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"amount\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":36},\"Item2\":{\"Line\":1,\"Column\":42}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Utils.Math\",\"Name\":\"QFTAdder\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs\",\"Position\":{\"Item1\":20,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Utils.Math\",\"Name\":\"QFTAdder\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs\",\"Position\":{\"Item1\":33,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Utils.Math\",\"Name\":\"QFTAdder\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs\",\"Position\":{\"Item1\":34,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":11}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Utils.Math\",\"Name\":\"QFTAdder\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs\",\"Position\":{\"Item1\":35,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Utils.Math\",\"Name\":\"QFTAdderInt\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs\",\"Position\":{\"Item1\":38,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"start\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":23},\"Item2\":{\"Line\":1,\"Column\":28}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"amount\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":39},\"Item2\":{\"Line\":1,\"Column\":45}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Utils.Math\",\"Name\":\"QFTAdderInt\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs\",\"Position\":{\"Item1\":39,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Utils.Math\",\"Name\":\"QFTAdderInt\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs\",\"Position\":{\"Item1\":47,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Utils.Math\",\"Name\":\"QFTAdderInt\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs\",\"Position\":{\"Item1\":48,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":11}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Utils.Math\",\"Name\":\"QFTAdderInt\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs\",\"Position\":{\"Item1\":49,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Utils.Math\",\"Name\":\"QFTSubtractor\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs\",\"Position\":{\"Item1\":52,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"start\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":25},\"Item2\":{\"Line\":1,\"Column\":30}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"amount\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":41},\"Item2\":{\"Line\":1,\"Column\":47}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Utils.Math\",\"Name\":\"QFTSubtractor\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs\",\"Position\":{\"Item1\":53,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Utils.Math\",\"Name\":\"QFTSubtractor\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs\",\"Position\":{\"Item1\":61,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Utils.Math\",\"Name\":\"QFTSubtractor\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs\",\"Position\":{\"Item1\":62,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":11}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Utils.Math\",\"Name\":\"QFTSubtractor\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs\",\"Position\":{\"Item1\":63,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Utils.Math\",\"Name\":\"_SubtractBit\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs\",\"Position\":{\"Item1\":66,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":23}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"t1\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":24},\"Item2\":{\"Line\":1,\"Column\":26}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"t2\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":35},\"Item2\":{\"Line\":1,\"Column\":37}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"borrowIn\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":46},\"Item2\":{\"Line\":1,\"Column\":54}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"borrowOut\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":63},\"Item2\":{\"Line\":1,\"Column\":72}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Qubit\"},{\"Case\":\"Qubit\"},{\"Case\":\"Qubit\"},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Utils.Math\",\"Name\":\"_SubtractBit\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs\",\"Position\":{\"Item1\":67,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Utils.Math\",\"Name\":\"_SubtractBit\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs\",\"Position\":{\"Item1\":79,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Utils.Math\",\"Name\":\"_SubtractBit\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs\",\"Position\":{\"Item1\":80,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":11}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Utils.Math\",\"Name\":\"_SubtractBit\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs\",\"Position\":{\"Item1\":81,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Utils.Math\",\"Name\":\"BitSubtractor\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs\",\"Position\":{\"Item1\":84,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"start\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":25},\"Item2\":{\"Line\":1,\"Column\":30}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"amount\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":41},\"Item2\":{\"Line\":1,\"Column\":47}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"borrows\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":58},\"Item2\":{\"Line\":1,\"Column\":65}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Utils.Math\",\"Name\":\"BitSubtractor\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs\",\"Position\":{\"Item1\":85,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Utils.Math\",\"Name\":\"BitSubtractor\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs\",\"Position\":{\"Item1\":102,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Utils.Math\",\"Name\":\"BitSubtractor\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs\",\"Position\":{\"Item1\":103,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":11}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Utils.Math\",\"Name\":\"BitSubtractor\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs\",\"Position\":{\"Item1\":104,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
#line hidden
namespace Utils.Math
{
    public partial class CeilLogBase2 : Function<Double, Int64>, ICallable
    {
        public CeilLogBase2(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "CeilLogBase2";
        String ICallable.FullName => "Utils.Math.CeilLogBase2";
        protected ICallable<Double, Int64> MicrosoftQuantumMathCeiling
        {
            get;
            set;
        }

        protected ICallable<Double, Double> MicrosoftQuantumMathLog
        {
            get;
            set;
        }

        public override Func<Double, Int64> Body => (__in__) =>
        {
            var x = __in__;
#line 8 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs"
            return MicrosoftQuantumMathCeiling.Apply((MicrosoftQuantumMathLog.Apply(x) / MicrosoftQuantumMathLog.Apply(2D)));
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumMathCeiling = this.Factory.Get<ICallable<Double, Int64>>(typeof(Microsoft.Quantum.Math.Ceiling));
            this.MicrosoftQuantumMathLog = this.Factory.Get<ICallable<Double, Double>>(typeof(Microsoft.Quantum.Math.Log));
        }

        public override IApplyData __dataIn(Double data) => new QTuple<Double>(data);
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, Double x)
        {
            return __m__.Run<CeilLogBase2, Double, Int64>(x);
        }
    }

    public partial class ClassicalSum : Function<IQArray<Int64>, Int64>, ICallable
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

        public override Func<IQArray<Int64>, Int64> Body => (__in__) =>
        {
            var arr = __in__;
#line 12 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs"
            var sum = 0L;
#line 13 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs"
            foreach (var i in new Range(0L, (arr.Length - 1L)))
#line hidden
            {
#line 14 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs"
                sum = (sum + arr[i]);
            }

#line 17 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs"
            return sum;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
        }

        public override IApplyData __dataIn(IQArray<Int64> data) => data;
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, IQArray<Int64> arr)
        {
            return __m__.Run<ClassicalSum, IQArray<Int64>, Int64>(arr);
        }
    }

    public partial class QFTAdder : Unitary<(IQArray<Qubit>,IQArray<Qubit>)>, ICallable
    {
        public QFTAdder(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,IQArray<Qubit>)>, IApplyData
        {
            public In((IQArray<Qubit>,IQArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "QFTAdder";
        String ICallable.FullName => "Utils.Math.QFTAdder";
        protected ICallable<IQArray<Qubit>, Microsoft.Quantum.Arithmetic.BigEndian> MicrosoftQuantumArithmeticBigEndian
        {
            get;
            set;
        }

        protected IUnitary MicrosoftQuantumCanonApplyToEachIndexCA
        {
            get;
            set;
        }

        protected IUnitary<Microsoft.Quantum.Arithmetic.BigEndian> MicrosoftQuantumCanonQFT
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

        protected IUnitary<(Int64,Int64,Qubit)> MicrosoftQuantumIntrinsicR1Frac
        {
            get;
            set;
        }

        public override Func<(IQArray<Qubit>,IQArray<Qubit>), QVoid> Body => (__in__) =>
        {
            var (start,amount) = __in__;
#line 22 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs"
            var bigEndian = new Microsoft.Quantum.Arithmetic.BigEndian(start);
#line 24 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs"
            MicrosoftQuantumCanonQFT.Apply(bigEndian);
#line 26 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs"
            foreach (var i in new Range((amount.Length - 1L), -(1L), 0L))
#line hidden
            {
#line 27 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs"
                var add = 2L.Pow(((amount.Length - 1L) - i));
#line 28 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs"
                MicrosoftQuantumCanonApplyToEachIndexCA.Apply((MicrosoftQuantumIntrinsicR1Frac.Controlled.Partial(new Func<(Int64,Qubit), (IQArray<Qubit>,(Int64,Int64,Qubit))>((__arg1__) => (new QArray<Qubit>(amount[i]), (add, __arg1__.Item1, __arg1__.Item2)))), start));
            }

#line 31 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs"
            MicrosoftQuantumCanonQFT.Adjoint.Apply(bigEndian);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,IQArray<Qubit>), QVoid> AdjointBody => (__in__) =>
        {
            var (start,amount) = __in__;
#line hidden
            var __qsVar0__bigEndian__ = new Microsoft.Quantum.Arithmetic.BigEndian(start);
#line hidden
            MicrosoftQuantumCanonQFT.Adjoint.Adjoint.Apply(__qsVar0__bigEndian__);
#line hidden
            foreach (var __qsVar1__i__ in RangeReverse.Apply(new Range((amount.Length - 1L), -(1L), 0L)))
#line hidden
            {
#line hidden
                var __qsVar2__add__ = 2L.Pow(((amount.Length - 1L) - __qsVar1__i__));
#line hidden
                MicrosoftQuantumCanonApplyToEachIndexCA.Adjoint.Apply((MicrosoftQuantumIntrinsicR1Frac.Controlled.Partial(new Func<(Int64,Qubit), (IQArray<Qubit>,(Int64,Int64,Qubit))>((__arg1__) => (new QArray<Qubit>(amount[__qsVar1__i__]), (__qsVar2__add__, __arg1__.Item1, __arg1__.Item2)))), start));
            }

#line hidden
            MicrosoftQuantumCanonQFT.Adjoint.Apply(__qsVar0__bigEndian__);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,(IQArray<Qubit>,IQArray<Qubit>)), QVoid> ControlledBody => (__in__) =>
        {
            var (__controlQubits__,(start,amount)) = __in__;
#line hidden
            var bigEndian = new Microsoft.Quantum.Arithmetic.BigEndian(start);
#line hidden
            MicrosoftQuantumCanonQFT.Controlled.Apply((__controlQubits__, bigEndian));
#line hidden
            foreach (var i in new Range((amount.Length - 1L), -(1L), 0L))
#line hidden
            {
#line hidden
                var add = 2L.Pow(((amount.Length - 1L) - i));
#line hidden
                MicrosoftQuantumCanonApplyToEachIndexCA.Controlled.Apply((__controlQubits__, (MicrosoftQuantumIntrinsicR1Frac.Controlled.Partial(new Func<(Int64,Qubit), (IQArray<Qubit>,(Int64,Int64,Qubit))>((__arg1__) => (new QArray<Qubit>(amount[i]), (add, __arg1__.Item1, __arg1__.Item2)))), start)));
            }

#line hidden
            MicrosoftQuantumCanonQFT.Adjoint.Controlled.Apply((__controlQubits__, bigEndian));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,(IQArray<Qubit>,IQArray<Qubit>)), QVoid> ControlledAdjointBody => (__in__) =>
        {
            var (__controlQubits__,(start,amount)) = __in__;
#line hidden
            var __qsVar0__bigEndian__ = new Microsoft.Quantum.Arithmetic.BigEndian(start);
#line hidden
            MicrosoftQuantumCanonQFT.Adjoint.Adjoint.Controlled.Apply((__controlQubits__, __qsVar0__bigEndian__));
#line hidden
            foreach (var __qsVar1__i__ in RangeReverse.Apply(new Range((amount.Length - 1L), -(1L), 0L)))
#line hidden
            {
#line hidden
                var __qsVar2__add__ = 2L.Pow(((amount.Length - 1L) - __qsVar1__i__));
#line hidden
                MicrosoftQuantumCanonApplyToEachIndexCA.Adjoint.Controlled.Apply((__controlQubits__, (MicrosoftQuantumIntrinsicR1Frac.Controlled.Partial(new Func<(Int64,Qubit), (IQArray<Qubit>,(Int64,Int64,Qubit))>((__arg1__) => (new QArray<Qubit>(amount[__qsVar1__i__]), (__qsVar2__add__, __arg1__.Item1, __arg1__.Item2)))), start)));
            }

#line hidden
            MicrosoftQuantumCanonQFT.Adjoint.Controlled.Apply((__controlQubits__, __qsVar0__bigEndian__));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumArithmeticBigEndian = this.Factory.Get<ICallable<IQArray<Qubit>, Microsoft.Quantum.Arithmetic.BigEndian>>(typeof(Microsoft.Quantum.Arithmetic.BigEndian));
            this.MicrosoftQuantumCanonApplyToEachIndexCA = this.Factory.Get<IUnitary>(typeof(Microsoft.Quantum.Canon.ApplyToEachIndexCA<>));
            this.MicrosoftQuantumCanonQFT = this.Factory.Get<IUnitary<Microsoft.Quantum.Arithmetic.BigEndian>>(typeof(Microsoft.Quantum.Canon.QFT));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.RangeReverse = this.Factory.Get<ICallable<Range, Range>>(typeof(Microsoft.Quantum.Core.RangeReverse));
            this.MicrosoftQuantumIntrinsicR1Frac = this.Factory.Get<IUnitary<(Int64,Int64,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.R1Frac));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,IQArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> start, IQArray<Qubit> amount)
        {
            return __m__.Run<QFTAdder, (IQArray<Qubit>,IQArray<Qubit>), QVoid>((start, amount));
        }
    }

    public partial class QFTAdderInt : Unitary<(IQArray<Qubit>,Int64)>, ICallable
    {
        public QFTAdderInt(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,Int64)>, IApplyData
        {
            public In((IQArray<Qubit>,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item1)?.Qubits;
        }

        String ICallable.Name => "QFTAdderInt";
        String ICallable.FullName => "Utils.Math.QFTAdderInt";
        protected ICallable<IQArray<Qubit>, Microsoft.Quantum.Arithmetic.BigEndian> MicrosoftQuantumArithmeticBigEndian
        {
            get;
            set;
        }

        protected IUnitary MicrosoftQuantumCanonApplyToEachIndexCA
        {
            get;
            set;
        }

        protected IUnitary<Microsoft.Quantum.Arithmetic.BigEndian> MicrosoftQuantumCanonQFT
        {
            get;
            set;
        }

        protected IUnitary<(Int64,Int64,Qubit)> MicrosoftQuantumIntrinsicR1Frac
        {
            get;
            set;
        }

        public override Func<(IQArray<Qubit>,Int64), QVoid> Body => (__in__) =>
        {
            var (start,amount) = __in__;
#line 41 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs"
            var bigEndian = new Microsoft.Quantum.Arithmetic.BigEndian(start);
#line 43 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs"
            MicrosoftQuantumCanonQFT.Apply(bigEndian);
#line 44 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs"
            MicrosoftQuantumCanonApplyToEachIndexCA.Apply((MicrosoftQuantumIntrinsicR1Frac.Partial(new Func<(Int64,Qubit), (Int64,Int64,Qubit)>((__arg1__) => (amount, __arg1__.Item1, __arg1__.Item2))), start));
#line 45 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs"
            MicrosoftQuantumCanonQFT.Adjoint.Apply(bigEndian);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,Int64), QVoid> AdjointBody => (__in__) =>
        {
            var (start,amount) = __in__;
#line hidden
            var __qsVar0__bigEndian__ = new Microsoft.Quantum.Arithmetic.BigEndian(start);
#line hidden
            MicrosoftQuantumCanonQFT.Adjoint.Adjoint.Apply(__qsVar0__bigEndian__);
#line hidden
            MicrosoftQuantumCanonApplyToEachIndexCA.Adjoint.Apply((MicrosoftQuantumIntrinsicR1Frac.Partial(new Func<(Int64,Qubit), (Int64,Int64,Qubit)>((__arg1__) => (amount, __arg1__.Item1, __arg1__.Item2))), start));
#line hidden
            MicrosoftQuantumCanonQFT.Adjoint.Apply(__qsVar0__bigEndian__);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,(IQArray<Qubit>,Int64)), QVoid> ControlledBody => (__in__) =>
        {
            var (__controlQubits__,(start,amount)) = __in__;
#line hidden
            var bigEndian = new Microsoft.Quantum.Arithmetic.BigEndian(start);
#line hidden
            MicrosoftQuantumCanonQFT.Controlled.Apply((__controlQubits__, bigEndian));
#line hidden
            MicrosoftQuantumCanonApplyToEachIndexCA.Controlled.Apply((__controlQubits__, (MicrosoftQuantumIntrinsicR1Frac.Partial(new Func<(Int64,Qubit), (Int64,Int64,Qubit)>((__arg1__) => (amount, __arg1__.Item1, __arg1__.Item2))), start)));
#line hidden
            MicrosoftQuantumCanonQFT.Adjoint.Controlled.Apply((__controlQubits__, bigEndian));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,(IQArray<Qubit>,Int64)), QVoid> ControlledAdjointBody => (__in__) =>
        {
            var (__controlQubits__,(start,amount)) = __in__;
#line hidden
            var __qsVar0__bigEndian__ = new Microsoft.Quantum.Arithmetic.BigEndian(start);
#line hidden
            MicrosoftQuantumCanonQFT.Adjoint.Adjoint.Controlled.Apply((__controlQubits__, __qsVar0__bigEndian__));
#line hidden
            MicrosoftQuantumCanonApplyToEachIndexCA.Adjoint.Controlled.Apply((__controlQubits__, (MicrosoftQuantumIntrinsicR1Frac.Partial(new Func<(Int64,Qubit), (Int64,Int64,Qubit)>((__arg1__) => (amount, __arg1__.Item1, __arg1__.Item2))), start)));
#line hidden
            MicrosoftQuantumCanonQFT.Adjoint.Controlled.Apply((__controlQubits__, __qsVar0__bigEndian__));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumArithmeticBigEndian = this.Factory.Get<ICallable<IQArray<Qubit>, Microsoft.Quantum.Arithmetic.BigEndian>>(typeof(Microsoft.Quantum.Arithmetic.BigEndian));
            this.MicrosoftQuantumCanonApplyToEachIndexCA = this.Factory.Get<IUnitary>(typeof(Microsoft.Quantum.Canon.ApplyToEachIndexCA<>));
            this.MicrosoftQuantumCanonQFT = this.Factory.Get<IUnitary<Microsoft.Quantum.Arithmetic.BigEndian>>(typeof(Microsoft.Quantum.Canon.QFT));
            this.MicrosoftQuantumIntrinsicR1Frac = this.Factory.Get<IUnitary<(Int64,Int64,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.R1Frac));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,Int64) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> start, Int64 amount)
        {
            return __m__.Run<QFTAdderInt, (IQArray<Qubit>,Int64), QVoid>((start, amount));
        }
    }

    public partial class QFTSubtractor : Unitary<(IQArray<Qubit>,Int64)>, ICallable
    {
        public QFTSubtractor(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,Int64)>, IApplyData
        {
            public In((IQArray<Qubit>,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item1)?.Qubits;
        }

        String ICallable.Name => "QFTSubtractor";
        String ICallable.FullName => "Utils.Math.QFTSubtractor";
        protected ICallable<IQArray<Qubit>, Microsoft.Quantum.Arithmetic.BigEndian> MicrosoftQuantumArithmeticBigEndian
        {
            get;
            set;
        }

        protected IUnitary MicrosoftQuantumCanonApplyToEachIndexCA
        {
            get;
            set;
        }

        protected IUnitary<Microsoft.Quantum.Arithmetic.BigEndian> MicrosoftQuantumCanonQFT
        {
            get;
            set;
        }

        protected IUnitary<(Int64,Int64,Qubit)> MicrosoftQuantumIntrinsicR1Frac
        {
            get;
            set;
        }

        public override Func<(IQArray<Qubit>,Int64), QVoid> Body => (__in__) =>
        {
            var (start,amount) = __in__;
#line 55 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs"
            var bigEndian = new Microsoft.Quantum.Arithmetic.BigEndian(start);
#line 57 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs"
            MicrosoftQuantumCanonQFT.Apply(bigEndian);
#line 58 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs"
            MicrosoftQuantumCanonApplyToEachIndexCA.Apply((MicrosoftQuantumIntrinsicR1Frac.Partial(new Func<(Int64,Qubit), (Int64,Int64,Qubit)>((__arg1__) => (-(amount), __arg1__.Item1, __arg1__.Item2))), start));
#line 59 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs"
            MicrosoftQuantumCanonQFT.Adjoint.Apply(bigEndian);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,Int64), QVoid> AdjointBody => (__in__) =>
        {
            var (start,amount) = __in__;
#line hidden
            var __qsVar0__bigEndian__ = new Microsoft.Quantum.Arithmetic.BigEndian(start);
#line hidden
            MicrosoftQuantumCanonQFT.Adjoint.Adjoint.Apply(__qsVar0__bigEndian__);
#line hidden
            MicrosoftQuantumCanonApplyToEachIndexCA.Adjoint.Apply((MicrosoftQuantumIntrinsicR1Frac.Partial(new Func<(Int64,Qubit), (Int64,Int64,Qubit)>((__arg1__) => (-(amount), __arg1__.Item1, __arg1__.Item2))), start));
#line hidden
            MicrosoftQuantumCanonQFT.Adjoint.Apply(__qsVar0__bigEndian__);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,(IQArray<Qubit>,Int64)), QVoid> ControlledBody => (__in__) =>
        {
            var (__controlQubits__,(start,amount)) = __in__;
#line hidden
            var bigEndian = new Microsoft.Quantum.Arithmetic.BigEndian(start);
#line hidden
            MicrosoftQuantumCanonQFT.Controlled.Apply((__controlQubits__, bigEndian));
#line hidden
            MicrosoftQuantumCanonApplyToEachIndexCA.Controlled.Apply((__controlQubits__, (MicrosoftQuantumIntrinsicR1Frac.Partial(new Func<(Int64,Qubit), (Int64,Int64,Qubit)>((__arg1__) => (-(amount), __arg1__.Item1, __arg1__.Item2))), start)));
#line hidden
            MicrosoftQuantumCanonQFT.Adjoint.Controlled.Apply((__controlQubits__, bigEndian));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,(IQArray<Qubit>,Int64)), QVoid> ControlledAdjointBody => (__in__) =>
        {
            var (__controlQubits__,(start,amount)) = __in__;
#line hidden
            var __qsVar0__bigEndian__ = new Microsoft.Quantum.Arithmetic.BigEndian(start);
#line hidden
            MicrosoftQuantumCanonQFT.Adjoint.Adjoint.Controlled.Apply((__controlQubits__, __qsVar0__bigEndian__));
#line hidden
            MicrosoftQuantumCanonApplyToEachIndexCA.Adjoint.Controlled.Apply((__controlQubits__, (MicrosoftQuantumIntrinsicR1Frac.Partial(new Func<(Int64,Qubit), (Int64,Int64,Qubit)>((__arg1__) => (-(amount), __arg1__.Item1, __arg1__.Item2))), start)));
#line hidden
            MicrosoftQuantumCanonQFT.Adjoint.Controlled.Apply((__controlQubits__, __qsVar0__bigEndian__));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumArithmeticBigEndian = this.Factory.Get<ICallable<IQArray<Qubit>, Microsoft.Quantum.Arithmetic.BigEndian>>(typeof(Microsoft.Quantum.Arithmetic.BigEndian));
            this.MicrosoftQuantumCanonApplyToEachIndexCA = this.Factory.Get<IUnitary>(typeof(Microsoft.Quantum.Canon.ApplyToEachIndexCA<>));
            this.MicrosoftQuantumCanonQFT = this.Factory.Get<IUnitary<Microsoft.Quantum.Arithmetic.BigEndian>>(typeof(Microsoft.Quantum.Canon.QFT));
            this.MicrosoftQuantumIntrinsicR1Frac = this.Factory.Get<IUnitary<(Int64,Int64,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.R1Frac));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,Int64) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> start, Int64 amount)
        {
            return __m__.Run<QFTSubtractor, (IQArray<Qubit>,Int64), QVoid>((start, amount));
        }
    }

    public partial class _SubtractBit : Unitary<(Qubit,Qubit,Qubit,Qubit)>, ICallable
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

        protected IUnitary<(IQArray<Pauli>,IQArray<Qubit>,Result,String)> MicrosoftQuantumIntrinsicAssert
        {
            get;
            set;
        }

        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumIntrinsicCNOT
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicX
        {
            get;
            set;
        }

        public override Func<(Qubit,Qubit,Qubit,Qubit), QVoid> Body => (__in__) =>
        {
            var (t1,t2,borrowIn,borrowOut) = __in__;
#line 69 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs"
            MicrosoftQuantumIntrinsicAssert.Apply((new QArray<Pauli>(Pauli.PauliZ), new QArray<Qubit>(borrowOut), Result.Zero, "Borrow out is not in |0> state"));
#line 71 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs"
            MicrosoftQuantumIntrinsicX.Apply(t1);
#line 72 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs"
            MicrosoftQuantumIntrinsicX.Controlled.Apply((new QArray<Qubit>(t1, t2), borrowOut));
#line 73 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs"
            MicrosoftQuantumIntrinsicX.Controlled.Apply((new QArray<Qubit>(t1, borrowIn), borrowOut));
#line 74 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs"
            MicrosoftQuantumIntrinsicX.Controlled.Apply((new QArray<Qubit>(t2, borrowIn), borrowOut));
#line 75 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs"
            MicrosoftQuantumIntrinsicX.Apply(t1);
#line 77 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs"
            MicrosoftQuantumCanonApplyToEachCA.Apply((MicrosoftQuantumIntrinsicCNOT.Partial(new Func<Qubit, (Qubit,Qubit)>((__arg1__) => (__arg1__, t1))), new QArray<Qubit>(t2, borrowIn)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(Qubit,Qubit,Qubit,Qubit), QVoid> AdjointBody => (__in__) =>
        {
            var (t1,t2,borrowIn,borrowOut) = __in__;
#line hidden
            MicrosoftQuantumCanonApplyToEachCA.Adjoint.Apply((MicrosoftQuantumIntrinsicCNOT.Partial(new Func<Qubit, (Qubit,Qubit)>((__arg1__) => (__arg1__, t1))), new QArray<Qubit>(t2, borrowIn)));
#line hidden
            MicrosoftQuantumIntrinsicX.Adjoint.Apply(t1);
#line hidden
            MicrosoftQuantumIntrinsicX.Controlled.Adjoint.Apply((new QArray<Qubit>(t2, borrowIn), borrowOut));
#line hidden
            MicrosoftQuantumIntrinsicX.Controlled.Adjoint.Apply((new QArray<Qubit>(t1, borrowIn), borrowOut));
#line hidden
            MicrosoftQuantumIntrinsicX.Controlled.Adjoint.Apply((new QArray<Qubit>(t1, t2), borrowOut));
#line hidden
            MicrosoftQuantumIntrinsicX.Adjoint.Apply(t1);
#line hidden
            MicrosoftQuantumIntrinsicAssert.Adjoint.Apply((new QArray<Pauli>(Pauli.PauliZ), new QArray<Qubit>(borrowOut), Result.Zero, "Borrow out is not in |0> state"));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,(Qubit,Qubit,Qubit,Qubit)), QVoid> ControlledBody => (__in__) =>
        {
            var (__controlQubits__,(t1,t2,borrowIn,borrowOut)) = __in__;
#line hidden
            MicrosoftQuantumIntrinsicAssert.Controlled.Apply((__controlQubits__, (new QArray<Pauli>(Pauli.PauliZ), new QArray<Qubit>(borrowOut), Result.Zero, "Borrow out is not in |0> state")));
#line hidden
            MicrosoftQuantumIntrinsicX.Controlled.Apply((__controlQubits__, t1));
#line hidden
            MicrosoftQuantumIntrinsicX.Controlled.Controlled.Apply((__controlQubits__, (new QArray<Qubit>(t1, t2), borrowOut)));
#line hidden
            MicrosoftQuantumIntrinsicX.Controlled.Controlled.Apply((__controlQubits__, (new QArray<Qubit>(t1, borrowIn), borrowOut)));
#line hidden
            MicrosoftQuantumIntrinsicX.Controlled.Controlled.Apply((__controlQubits__, (new QArray<Qubit>(t2, borrowIn), borrowOut)));
#line hidden
            MicrosoftQuantumIntrinsicX.Controlled.Apply((__controlQubits__, t1));
#line hidden
            MicrosoftQuantumCanonApplyToEachCA.Controlled.Apply((__controlQubits__, (MicrosoftQuantumIntrinsicCNOT.Partial(new Func<Qubit, (Qubit,Qubit)>((__arg1__) => (__arg1__, t1))), new QArray<Qubit>(t2, borrowIn))));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,(Qubit,Qubit,Qubit,Qubit)), QVoid> ControlledAdjointBody => (__in__) =>
        {
            var (__controlQubits__,(t1,t2,borrowIn,borrowOut)) = __in__;
#line hidden
            MicrosoftQuantumCanonApplyToEachCA.Adjoint.Controlled.Apply((__controlQubits__, (MicrosoftQuantumIntrinsicCNOT.Partial(new Func<Qubit, (Qubit,Qubit)>((__arg1__) => (__arg1__, t1))), new QArray<Qubit>(t2, borrowIn))));
#line hidden
            MicrosoftQuantumIntrinsicX.Adjoint.Controlled.Apply((__controlQubits__, t1));
#line hidden
            MicrosoftQuantumIntrinsicX.Controlled.Adjoint.Controlled.Apply((__controlQubits__, (new QArray<Qubit>(t2, borrowIn), borrowOut)));
#line hidden
            MicrosoftQuantumIntrinsicX.Controlled.Adjoint.Controlled.Apply((__controlQubits__, (new QArray<Qubit>(t1, borrowIn), borrowOut)));
#line hidden
            MicrosoftQuantumIntrinsicX.Controlled.Adjoint.Controlled.Apply((__controlQubits__, (new QArray<Qubit>(t1, t2), borrowOut)));
#line hidden
            MicrosoftQuantumIntrinsicX.Adjoint.Controlled.Apply((__controlQubits__, t1));
#line hidden
            MicrosoftQuantumIntrinsicAssert.Adjoint.Controlled.Apply((__controlQubits__, (new QArray<Pauli>(Pauli.PauliZ), new QArray<Qubit>(borrowOut), Result.Zero, "Borrow out is not in |0> state")));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonApplyToEachCA = this.Factory.Get<IUnitary>(typeof(Microsoft.Quantum.Canon.ApplyToEachCA<>));
            this.MicrosoftQuantumIntrinsicAssert = this.Factory.Get<IUnitary<(IQArray<Pauli>,IQArray<Qubit>,Result,String)>>(typeof(Microsoft.Quantum.Intrinsic.Assert));
            this.MicrosoftQuantumIntrinsicCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.CNOT));
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
        }

        public override IApplyData __dataIn((Qubit,Qubit,Qubit,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit t1, Qubit t2, Qubit borrowIn, Qubit borrowOut)
        {
            return __m__.Run<_SubtractBit, (Qubit,Qubit,Qubit,Qubit), QVoid>((t1, t2, borrowIn, borrowOut));
        }
    }

    public partial class BitSubtractor : Unitary<(IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>)>, ICallable
    {
        public BitSubtractor(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>)>, IApplyData
        {
            public In((IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>) data) : base(data)
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

        public override Func<(IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>), QVoid> Body => (__in__) =>
        {
            var (start,amount,borrows) = __in__;
#line 87 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs"
            MicrosoftQuantumCanonAssertBoolEqual.Apply(((start.Length >= amount.Length), true, "unequal operand lengths"));
#line 88 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs"
            MicrosoftQuantumCanonAssertIntEqual.Apply(((start.Length + 1L), borrows.Length, "not right amount of borrows"));
#line hidden
            {
#line 90 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs"
                var padding = Allocate.Apply(1L);
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 91 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs"
                    foreach (var j in new Range((start.Length - 1L), -(1L), 0L))
#line hidden
                    {
#line 92 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs"
                        var sop = _SubtractBit.Partial(new Func<Qubit, (Qubit,Qubit,Qubit,Qubit)>((__arg3__) => (start[j], __arg3__, borrows[(j + 1L)], borrows[j])));
#line 93 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs"
                        if ((j >= (start.Length - amount.Length)))
                        {
#line 94 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs"
                            sop.Apply(amount[((j - start.Length) + amount.Length)]);
                        }
                        else
                        {
#line 96 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Math.qs"
                            sop.Apply(padding[0L]);
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
                    Release.Apply(padding);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>), QVoid> AdjointBody => (__in__) =>
        {
            var (start,amount,borrows) = __in__;
#line hidden
            MicrosoftQuantumCanonAssertBoolEqual.Apply(((start.Length >= amount.Length), true, "unequal operand lengths"));
#line hidden
            MicrosoftQuantumCanonAssertIntEqual.Apply(((start.Length + 1L), borrows.Length, "not right amount of borrows"));
#line hidden
            {
#line hidden
                var __qsVar0__padding__ = Allocate.Apply(1L);
#line hidden
                Exception __arg1__ = null;
                try
                {
#line hidden
                    foreach (var __qsVar1__j__ in RangeReverse.Apply(new Range((start.Length - 1L), -(1L), 0L)))
#line hidden
                    {
#line hidden
                        var __qsVar2__sop__ = _SubtractBit.Partial(new Func<Qubit, (Qubit,Qubit,Qubit,Qubit)>((__arg3__) => (start[__qsVar1__j__], __arg3__, borrows[(__qsVar1__j__ + 1L)], borrows[__qsVar1__j__])));
#line hidden
                        if ((__qsVar1__j__ >= (start.Length - amount.Length)))
                        {
#line hidden
                            __qsVar2__sop__.Adjoint.Apply(amount[((__qsVar1__j__ - start.Length) + amount.Length)]);
                        }
                        else
                        {
#line hidden
                            __qsVar2__sop__.Adjoint.Apply(__qsVar0__padding__[0L]);
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
                    Release.Apply(__qsVar0__padding__);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,(IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>)), QVoid> ControlledBody => (__in__) =>
        {
            var (__controlQubits__,(start,amount,borrows)) = __in__;
#line hidden
            MicrosoftQuantumCanonAssertBoolEqual.Apply(((start.Length >= amount.Length), true, "unequal operand lengths"));
#line hidden
            MicrosoftQuantumCanonAssertIntEqual.Apply(((start.Length + 1L), borrows.Length, "not right amount of borrows"));
#line hidden
            {
#line hidden
                var padding = Allocate.Apply(1L);
#line hidden
                Exception __arg1__ = null;
                try
                {
#line hidden
                    foreach (var j in new Range((start.Length - 1L), -(1L), 0L))
#line hidden
                    {
#line hidden
                        var sop = _SubtractBit.Partial(new Func<Qubit, (Qubit,Qubit,Qubit,Qubit)>((__arg3__) => (start[j], __arg3__, borrows[(j + 1L)], borrows[j])));
#line hidden
                        if ((j >= (start.Length - amount.Length)))
                        {
#line hidden
                            sop.Controlled.Apply((__controlQubits__, amount[((j - start.Length) + amount.Length)]));
                        }
                        else
                        {
#line hidden
                            sop.Controlled.Apply((__controlQubits__, padding[0L]));
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
                    Release.Apply(padding);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,(IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>)), QVoid> ControlledAdjointBody => (__in__) =>
        {
            var (__controlQubits__,(start,amount,borrows)) = __in__;
#line hidden
            MicrosoftQuantumCanonAssertBoolEqual.Apply(((start.Length >= amount.Length), true, "unequal operand lengths"));
#line hidden
            MicrosoftQuantumCanonAssertIntEqual.Apply(((start.Length + 1L), borrows.Length, "not right amount of borrows"));
#line hidden
            {
#line hidden
                var __qsVar0__padding__ = Allocate.Apply(1L);
#line hidden
                Exception __arg1__ = null;
                try
                {
#line hidden
                    foreach (var __qsVar1__j__ in RangeReverse.Apply(new Range((start.Length - 1L), -(1L), 0L)))
#line hidden
                    {
#line hidden
                        var __qsVar2__sop__ = _SubtractBit.Partial(new Func<Qubit, (Qubit,Qubit,Qubit,Qubit)>((__arg3__) => (start[__qsVar1__j__], __arg3__, borrows[(__qsVar1__j__ + 1L)], borrows[__qsVar1__j__])));
#line hidden
                        if ((__qsVar1__j__ >= (start.Length - amount.Length)))
                        {
#line hidden
                            __qsVar2__sop__.Adjoint.Controlled.Apply((__controlQubits__, amount[((__qsVar1__j__ - start.Length) + amount.Length)]));
                        }
                        else
                        {
#line hidden
                            __qsVar2__sop__.Adjoint.Controlled.Apply((__controlQubits__, __qsVar0__padding__[0L]));
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
                    Release.Apply(__qsVar0__padding__);
                }
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
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this._SubtractBit = this.Factory.Get<IUnitary<(Qubit,Qubit,Qubit,Qubit)>>(typeof(_SubtractBit));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> start, IQArray<Qubit> amount, IQArray<Qubit> borrows)
        {
            return __m__.Run<BitSubtractor, (IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>), QVoid>((start, amount, borrows));
        }
    }
}