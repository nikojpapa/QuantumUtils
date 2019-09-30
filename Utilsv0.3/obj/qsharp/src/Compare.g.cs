#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Intrinsic;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Utils.Compare\",\"Name\":\"XIfAllZero\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs\",\"Position\":{\"Item1\":8,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":21}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"a\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":22},\"Item2\":{\"Line\":1,\"Column\":23}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"target\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":34},\"Item2\":{\"Line\":1,\"Column\":40}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Utils.Compare\",\"Name\":\"XIfAllZero\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs\",\"Position\":{\"Item1\":9,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Utils.Compare\",\"Name\":\"XIfAllZero\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs\",\"Position\":{\"Item1\":15,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Utils.Compare\",\"Name\":\"XIfAllZero\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs\",\"Position\":{\"Item1\":16,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":11}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Utils.Compare\",\"Name\":\"XIfAllZero\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs\",\"Position\":{\"Item1\":17,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Utils.Compare\",\"Name\":\"XIfEqual\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs\",\"Position\":{\"Item1\":20,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":19}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"a\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":20},\"Item2\":{\"Line\":1,\"Column\":21}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"b\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":32},\"Item2\":{\"Line\":1,\"Column\":33}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"target\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":44},\"Item2\":{\"Line\":1,\"Column\":50}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Utils.Compare\",\"Name\":\"XIfEqual\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs\",\"Position\":{\"Item1\":21,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Utils.Compare\",\"Name\":\"XIfEqual\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs\",\"Position\":{\"Item1\":49,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Utils.Compare\",\"Name\":\"XIfEqual\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs\",\"Position\":{\"Item1\":50,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":11}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Utils.Compare\",\"Name\":\"XIfEqual\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs\",\"Position\":{\"Item1\":51,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Utils.Compare\",\"Name\":\"XIfQubitEqualToInt\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs\",\"Position\":{\"Item1\":54,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":29}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"a\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":30},\"Item2\":{\"Line\":1,\"Column\":31}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"b\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":42},\"Item2\":{\"Line\":1,\"Column\":43}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"target\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":50},\"Item2\":{\"Line\":1,\"Column\":56}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Int\"},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Utils.Compare\",\"Name\":\"XIfQubitEqualToInt\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs\",\"Position\":{\"Item1\":55,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Utils.Compare\",\"Name\":\"XIfQubitEqualToInt\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs\",\"Position\":{\"Item1\":63,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Utils.Compare\",\"Name\":\"XIfQubitEqualToInt\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs\",\"Position\":{\"Item1\":64,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":11}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Utils.Compare\",\"Name\":\"XIfQubitEqualToInt\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs\",\"Position\":{\"Item1\":65,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Utils.Compare\",\"Name\":\"_TestXIfQubitEqualToIntImpl\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs\",\"Position\":{\"Item1\":67,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":38}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"a\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":39},\"Item2\":{\"Line\":1,\"Column\":40}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"length\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":51},\"Item2\":{\"Line\":1,\"Column\":57}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Utils.Compare\",\"Name\":\"_TestXIfQubitEqualToIntImpl\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs\",\"Position\":{\"Item1\":67,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":38}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Utils.Compare\",\"Name\":\"_TestXIfQubitEqualToInt\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs\",\"Position\":{\"Item1\":83,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":34}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"length\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":35},\"Item2\":{\"Line\":1,\"Column\":41}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Int\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Utils.Compare\",\"Name\":\"_TestXIfQubitEqualToInt\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs\",\"Position\":{\"Item1\":83,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":34}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Utils.Compare\",\"Name\":\"XIfLessThan\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs\",\"Position\":{\"Item1\":87,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"a\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":23},\"Item2\":{\"Line\":1,\"Column\":24}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"b\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":35},\"Item2\":{\"Line\":1,\"Column\":36}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"target\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":47},\"Item2\":{\"Line\":1,\"Column\":53}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Utils.Compare\",\"Name\":\"XIfLessThan\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs\",\"Position\":{\"Item1\":88,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Utils.Compare\",\"Name\":\"XIfLessThan\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs\",\"Position\":{\"Item1\":99,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Utils.Compare\",\"Name\":\"XIfLessThan\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs\",\"Position\":{\"Item1\":100,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":11}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Utils.Compare\",\"Name\":\"XIfLessThan\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs\",\"Position\":{\"Item1\":101,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Utils.Compare\",\"Name\":\"XIfLessThanOrEqual\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs\",\"Position\":{\"Item1\":104,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":29}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"a\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":30},\"Item2\":{\"Line\":1,\"Column\":31}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"b\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":42},\"Item2\":{\"Line\":1,\"Column\":43}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"target\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":54},\"Item2\":{\"Line\":1,\"Column\":60}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Utils.Compare\",\"Name\":\"XIfLessThanOrEqual\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs\",\"Position\":{\"Item1\":105,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Utils.Compare\",\"Name\":\"XIfLessThanOrEqual\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs\",\"Position\":{\"Item1\":122,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Utils.Compare\",\"Name\":\"XIfLessThanOrEqual\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs\",\"Position\":{\"Item1\":123,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":11}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Utils.Compare\",\"Name\":\"XIfLessThanOrEqual\"},\"Attributes\":[],\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs\",\"Position\":{\"Item1\":124,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
#line hidden
namespace Utils.Compare
{
    public partial class XIfAllZero : Unitary<(IQArray<Qubit>,Qubit)>, ICallable
    {
        public XIfAllZero(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,Qubit)>, IApplyData
        {
            public In((IQArray<Qubit>,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "XIfAllZero";
        String ICallable.FullName => "Utils.Compare.XIfAllZero";
        protected IUnitary MicrosoftQuantumCanonApplyToEachCA
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicX
        {
            get;
            set;
        }

        public override Func<(IQArray<Qubit>,Qubit), QVoid> Body => (__in__) =>
        {
            var (a,target) = __in__;
#line 11 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
            MicrosoftQuantumCanonApplyToEachCA.Apply((MicrosoftQuantumIntrinsicX, a));
#line 12 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
            MicrosoftQuantumIntrinsicX.Controlled.Apply((a, target));
#line 13 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
            MicrosoftQuantumCanonApplyToEachCA.Apply((MicrosoftQuantumIntrinsicX, a));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,Qubit), QVoid> AdjointBody => (__in__) =>
        {
            var (a,target) = __in__;
#line hidden
            MicrosoftQuantumCanonApplyToEachCA.Adjoint.Apply((MicrosoftQuantumIntrinsicX, a));
#line hidden
            MicrosoftQuantumIntrinsicX.Controlled.Adjoint.Apply((a, target));
#line hidden
            MicrosoftQuantumCanonApplyToEachCA.Adjoint.Apply((MicrosoftQuantumIntrinsicX, a));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,(IQArray<Qubit>,Qubit)), QVoid> ControlledBody => (__in__) =>
        {
            var (__controlQubits__,(a,target)) = __in__;
#line hidden
            MicrosoftQuantumCanonApplyToEachCA.Controlled.Apply((__controlQubits__, (MicrosoftQuantumIntrinsicX, a)));
#line hidden
            MicrosoftQuantumIntrinsicX.Controlled.Controlled.Apply((__controlQubits__, (a, target)));
#line hidden
            MicrosoftQuantumCanonApplyToEachCA.Controlled.Apply((__controlQubits__, (MicrosoftQuantumIntrinsicX, a)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,(IQArray<Qubit>,Qubit)), QVoid> ControlledAdjointBody => (__in__) =>
        {
            var (__controlQubits__,(a,target)) = __in__;
#line hidden
            MicrosoftQuantumCanonApplyToEachCA.Adjoint.Controlled.Apply((__controlQubits__, (MicrosoftQuantumIntrinsicX, a)));
#line hidden
            MicrosoftQuantumIntrinsicX.Controlled.Adjoint.Controlled.Apply((__controlQubits__, (a, target)));
#line hidden
            MicrosoftQuantumCanonApplyToEachCA.Adjoint.Controlled.Apply((__controlQubits__, (MicrosoftQuantumIntrinsicX, a)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonApplyToEachCA = this.Factory.Get<IUnitary>(typeof(Microsoft.Quantum.Canon.ApplyToEachCA<>));
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> a, Qubit target)
        {
            return __m__.Run<XIfAllZero, (IQArray<Qubit>,Qubit), QVoid>((a, target));
        }
    }

    public partial class XIfEqual : Unitary<(IQArray<Qubit>,IQArray<Qubit>,Qubit)>, ICallable
    {
        public XIfEqual(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,IQArray<Qubit>,Qubit)>, IApplyData
        {
            public In((IQArray<Qubit>,IQArray<Qubit>,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "XIfEqual";
        String ICallable.FullName => "Utils.Compare.XIfEqual";
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

        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumIntrinsicCNOT
        {
            get;
            set;
        }

        protected IUnitary<(IQArray<Qubit>,Qubit)> XIfAllZero
        {
            get;
            set;
        }

        public override Func<(IQArray<Qubit>,IQArray<Qubit>,Qubit), QVoid> Body => (__in__) =>
        {
            var (a,b,target) = __in__;
#line 23 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
            var lenA = a.Length;
#line 24 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
            var lenB = b.Length;
#line 26 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
            if ((lenA <= lenB))
            {
#line 27 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
                foreach (var i in new Range(0L, (lenA - 1L)))
#line hidden
                {
#line 28 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
                    MicrosoftQuantumIntrinsicCNOT.Apply((a[i], b[i]));
                }

#line 31 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
                XIfAllZero.Apply((b, target));
#line 33 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
                foreach (var i in new Range((lenA - 1L), -(1L), 0L))
#line hidden
                {
#line 34 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
                    MicrosoftQuantumIntrinsicCNOT.Apply((a[i], b[i]));
                }
            }
            else
            {
#line 37 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
                foreach (var i in new Range(0L, (lenB - 1L)))
#line hidden
                {
#line 38 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
                    MicrosoftQuantumIntrinsicCNOT.Apply((b[i], a[i]));
                }

#line 41 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
                XIfAllZero.Apply((a, target));
#line 43 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
                foreach (var i in new Range((lenB - 1L), -(1L), 0L))
#line hidden
                {
#line 44 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
                    MicrosoftQuantumIntrinsicCNOT.Apply((b[i], a[i]));
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,IQArray<Qubit>,Qubit), QVoid> AdjointBody => (__in__) =>
        {
            var (a,b,target) = __in__;
#line hidden
            var __qsVar0__lenA__ = a.Length;
#line hidden
            var __qsVar1__lenB__ = b.Length;
#line hidden
            if ((__qsVar0__lenA__ <= __qsVar1__lenB__))
            {
#line hidden
                foreach (var __qsVar5__i__ in RangeReverse.Apply(new Range((__qsVar0__lenA__ - 1L), -(1L), 0L)))
#line hidden
                {
#line hidden
                    MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[__qsVar5__i__], b[__qsVar5__i__]));
                }

#line hidden
                XIfAllZero.Adjoint.Apply((b, target));
#line hidden
                foreach (var __qsVar4__i__ in RangeReverse.Apply(new Range(0L, (__qsVar0__lenA__ - 1L))))
#line hidden
                {
#line hidden
                    MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[__qsVar4__i__], b[__qsVar4__i__]));
                }
            }
            else
            {
#line hidden
                foreach (var __qsVar3__i__ in RangeReverse.Apply(new Range((__qsVar1__lenB__ - 1L), -(1L), 0L)))
#line hidden
                {
#line hidden
                    MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((b[__qsVar3__i__], a[__qsVar3__i__]));
                }

#line hidden
                XIfAllZero.Adjoint.Apply((a, target));
#line hidden
                foreach (var __qsVar2__i__ in RangeReverse.Apply(new Range(0L, (__qsVar1__lenB__ - 1L))))
#line hidden
                {
#line hidden
                    MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((b[__qsVar2__i__], a[__qsVar2__i__]));
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,(IQArray<Qubit>,IQArray<Qubit>,Qubit)), QVoid> ControlledBody => (__in__) =>
        {
            var (__controlQubits__,(a,b,target)) = __in__;
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
                    MicrosoftQuantumIntrinsicCNOT.Controlled.Apply((__controlQubits__, (a[i], b[i])));
                }

#line hidden
                XIfAllZero.Controlled.Apply((__controlQubits__, (b, target)));
#line hidden
                foreach (var i in new Range((lenA - 1L), -(1L), 0L))
#line hidden
                {
#line hidden
                    MicrosoftQuantumIntrinsicCNOT.Controlled.Apply((__controlQubits__, (a[i], b[i])));
                }
            }
            else
            {
#line hidden
                foreach (var i in new Range(0L, (lenB - 1L)))
#line hidden
                {
#line hidden
                    MicrosoftQuantumIntrinsicCNOT.Controlled.Apply((__controlQubits__, (b[i], a[i])));
                }

#line hidden
                XIfAllZero.Controlled.Apply((__controlQubits__, (a, target)));
#line hidden
                foreach (var i in new Range((lenB - 1L), -(1L), 0L))
#line hidden
                {
#line hidden
                    MicrosoftQuantumIntrinsicCNOT.Controlled.Apply((__controlQubits__, (b[i], a[i])));
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,(IQArray<Qubit>,IQArray<Qubit>,Qubit)), QVoid> ControlledAdjointBody => (__in__) =>
        {
            var (__controlQubits__,(a,b,target)) = __in__;
#line hidden
            var __qsVar0__lenA__ = a.Length;
#line hidden
            var __qsVar1__lenB__ = b.Length;
#line hidden
            if ((__qsVar0__lenA__ <= __qsVar1__lenB__))
            {
#line hidden
                foreach (var __qsVar5__i__ in RangeReverse.Apply(new Range((__qsVar0__lenA__ - 1L), -(1L), 0L)))
#line hidden
                {
#line hidden
                    MicrosoftQuantumIntrinsicCNOT.Adjoint.Controlled.Apply((__controlQubits__, (a[__qsVar5__i__], b[__qsVar5__i__])));
                }

#line hidden
                XIfAllZero.Adjoint.Controlled.Apply((__controlQubits__, (b, target)));
#line hidden
                foreach (var __qsVar4__i__ in RangeReverse.Apply(new Range(0L, (__qsVar0__lenA__ - 1L))))
#line hidden
                {
#line hidden
                    MicrosoftQuantumIntrinsicCNOT.Adjoint.Controlled.Apply((__controlQubits__, (a[__qsVar4__i__], b[__qsVar4__i__])));
                }
            }
            else
            {
#line hidden
                foreach (var __qsVar3__i__ in RangeReverse.Apply(new Range((__qsVar1__lenB__ - 1L), -(1L), 0L)))
#line hidden
                {
#line hidden
                    MicrosoftQuantumIntrinsicCNOT.Adjoint.Controlled.Apply((__controlQubits__, (b[__qsVar3__i__], a[__qsVar3__i__])));
                }

#line hidden
                XIfAllZero.Adjoint.Controlled.Apply((__controlQubits__, (a, target)));
#line hidden
                foreach (var __qsVar2__i__ in RangeReverse.Apply(new Range(0L, (__qsVar1__lenB__ - 1L))))
#line hidden
                {
#line hidden
                    MicrosoftQuantumIntrinsicCNOT.Adjoint.Controlled.Apply((__controlQubits__, (b[__qsVar2__i__], a[__qsVar2__i__])));
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.RangeReverse = this.Factory.Get<ICallable<Range, Range>>(typeof(Microsoft.Quantum.Core.RangeReverse));
            this.MicrosoftQuantumIntrinsicCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.CNOT));
            this.XIfAllZero = this.Factory.Get<IUnitary<(IQArray<Qubit>,Qubit)>>(typeof(XIfAllZero));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,IQArray<Qubit>,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> a, IQArray<Qubit> b, Qubit target)
        {
            return __m__.Run<XIfEqual, (IQArray<Qubit>,IQArray<Qubit>,Qubit), QVoid>((a, b, target));
        }
    }

    public partial class XIfQubitEqualToInt : Unitary<(IQArray<Qubit>,Int64,Qubit)>, ICallable
    {
        public XIfQubitEqualToInt(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,Int64,Qubit)>, IApplyData
        {
            public In((IQArray<Qubit>,Int64,Qubit) data) : base(data)
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

        protected IUnitary<(IQArray<Qubit>,IQArray<Qubit>,Qubit)> XIfEqual
        {
            get;
            set;
        }

        protected IUnitary<(IQArray<Qubit>,Int64)> UtilsMathQFTAdderInt
        {
            get;
            set;
        }

        public override Func<(IQArray<Qubit>,Int64,Qubit), QVoid> Body => (__in__) =>
        {
            var (a,b,target) = __in__;
#line hidden
            {
#line 57 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
                var bQubit = Allocate.Apply(a.Length);
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 58 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
                    UtilsMathQFTAdderInt.Apply((bQubit, b));
#line 59 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
                    XIfEqual.Apply((a, bQubit, target));
#line 60 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
                    UtilsMathQFTAdderInt.Adjoint.Apply((bQubit, b));
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
                    Release.Apply(bQubit);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,Int64,Qubit), QVoid> AdjointBody => (__in__) =>
        {
            var (a,b,target) = __in__;
#line hidden
            {
#line hidden
                var __qsVar0__bQubit__ = Allocate.Apply(a.Length);
#line hidden
                Exception __arg1__ = null;
                try
                {
#line hidden
                    UtilsMathQFTAdderInt.Adjoint.Adjoint.Apply((__qsVar0__bQubit__, b));
#line hidden
                    XIfEqual.Adjoint.Apply((a, __qsVar0__bQubit__, target));
#line hidden
                    UtilsMathQFTAdderInt.Adjoint.Apply((__qsVar0__bQubit__, b));
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
                    Release.Apply(__qsVar0__bQubit__);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,(IQArray<Qubit>,Int64,Qubit)), QVoid> ControlledBody => (__in__) =>
        {
            var (__controlQubits__,(a,b,target)) = __in__;
#line hidden
            {
#line hidden
                var bQubit = Allocate.Apply(a.Length);
#line hidden
                Exception __arg1__ = null;
                try
                {
#line hidden
                    UtilsMathQFTAdderInt.Controlled.Apply((__controlQubits__, (bQubit, b)));
#line hidden
                    XIfEqual.Controlled.Apply((__controlQubits__, (a, bQubit, target)));
#line hidden
                    UtilsMathQFTAdderInt.Adjoint.Controlled.Apply((__controlQubits__, (bQubit, b)));
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
                    Release.Apply(bQubit);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,(IQArray<Qubit>,Int64,Qubit)), QVoid> ControlledAdjointBody => (__in__) =>
        {
            var (__controlQubits__,(a,b,target)) = __in__;
#line hidden
            {
#line hidden
                var __qsVar0__bQubit__ = Allocate.Apply(a.Length);
#line hidden
                Exception __arg1__ = null;
                try
                {
#line hidden
                    UtilsMathQFTAdderInt.Adjoint.Adjoint.Controlled.Apply((__controlQubits__, (__qsVar0__bQubit__, b)));
#line hidden
                    XIfEqual.Adjoint.Controlled.Apply((__controlQubits__, (a, __qsVar0__bQubit__, target)));
#line hidden
                    UtilsMathQFTAdderInt.Adjoint.Controlled.Apply((__controlQubits__, (__qsVar0__bQubit__, b)));
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
                    Release.Apply(__qsVar0__bQubit__);
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
            this.XIfEqual = this.Factory.Get<IUnitary<(IQArray<Qubit>,IQArray<Qubit>,Qubit)>>(typeof(XIfEqual));
            this.UtilsMathQFTAdderInt = this.Factory.Get<IUnitary<(IQArray<Qubit>,Int64)>>(typeof(Utils.Math.QFTAdderInt));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,Int64,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> a, Int64 b, Qubit target)
        {
            return __m__.Run<XIfQubitEqualToInt, (IQArray<Qubit>,Int64,Qubit), QVoid>((a, b, target));
        }
    }

    public partial class _TestXIfQubitEqualToIntImpl : Operation<(IQArray<Qubit>,Int64), QVoid>, ICallable
    {
        public _TestXIfQubitEqualToIntImpl(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,Int64)>, IApplyData
        {
            public In((IQArray<Qubit>,Int64) data) : base(data)
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

        protected ICallable<Qubit, Result> MicrosoftQuantumIntrinsicM
        {
            get;
            set;
        }

        protected ICallable<String, QVoid> MicrosoftQuantumIntrinsicMessage
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

        protected IUnitary<(IQArray<Qubit>,Int64,Qubit)> XIfQubitEqualToInt
        {
            get;
            set;
        }

        protected ICallable<IQArray<Qubit>, Int64> UtilsGeneralQubitsToInt
        {
            get;
            set;
        }

        public override Func<(IQArray<Qubit>,Int64), QVoid> Body => (__in__) =>
        {
            var (a,length) = __in__;
#line 69 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
            var aVal = UtilsGeneralQubitsToInt.Apply(a);
#line 70 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
            var maxA = (2L.Pow(a.Length) - 1L);
#line 72 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
            foreach (var b in new Range(0L, maxA))
#line hidden
            {
#line hidden
                {
#line 73 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
                    var qubits = Allocate.Apply(1L);
#line hidden
                    Exception __arg1__ = null;
                    try
                    {
#line 74 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
                        XIfQubitEqualToInt.Apply((a, b, qubits[0L]));
#line 76 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
                        var calcAns = MicrosoftQuantumCanonBoolFromResult.Apply(MicrosoftQuantumIntrinsicM.Apply(qubits[0L]));
#line 77 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
                        var trueAns = (aVal == b);
#line 78 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
                        MicrosoftQuantumCanonAssertBoolEqual.Apply((calcAns, trueAns, String.Format("{0} ?= {1}; calcAns: {2}, trueAns: {3}", aVal, b, calcAns, trueAns)));
#line 79 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
                        MicrosoftQuantumIntrinsicMessage.Apply(String.Format("{0} ?= {1} passed", aVal, b));
#line 80 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
                        MicrosoftQuantumIntrinsicResetAll.Apply(qubits);
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
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.MicrosoftQuantumIntrinsicM = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Intrinsic.M));
            this.MicrosoftQuantumIntrinsicMessage = this.Factory.Get<ICallable<String, QVoid>>(typeof(Microsoft.Quantum.Intrinsic.Message));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.MicrosoftQuantumIntrinsicResetAll = this.Factory.Get<ICallable<IQArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Intrinsic.ResetAll));
            this.XIfQubitEqualToInt = this.Factory.Get<IUnitary<(IQArray<Qubit>,Int64,Qubit)>>(typeof(XIfQubitEqualToInt));
            this.UtilsGeneralQubitsToInt = this.Factory.Get<ICallable<IQArray<Qubit>, Int64>>(typeof(Utils.General.QubitsToInt));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,Int64) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> a, Int64 length)
        {
            return __m__.Run<_TestXIfQubitEqualToIntImpl, (IQArray<Qubit>,Int64), QVoid>((a, length));
        }
    }

    public partial class _TestXIfQubitEqualToInt : Operation<Int64, QVoid>, ICallable
    {
        public _TestXIfQubitEqualToInt(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "_TestXIfQubitEqualToInt";
        String ICallable.FullName => "Utils.Compare._TestXIfQubitEqualToInt";
        protected ICallable<(IQArray<Qubit>,Int64), QVoid> _TestXIfQubitEqualToIntImpl
        {
            get;
            set;
        }

        protected ICallable<(Int64,ICallable), QVoid> UtilsTestingRunOnAllBinariesOfLength
        {
            get;
            set;
        }

        public override Func<Int64, QVoid> Body => (__in__) =>
        {
            var length = __in__;
#line 85 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
            UtilsTestingRunOnAllBinariesOfLength.Apply((length, _TestXIfQubitEqualToIntImpl.Partial(new Func<IQArray<Qubit>, (IQArray<Qubit>,Int64)>((__arg1__) => (__arg1__, length)))));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this._TestXIfQubitEqualToIntImpl = this.Factory.Get<ICallable<(IQArray<Qubit>,Int64), QVoid>>(typeof(_TestXIfQubitEqualToIntImpl));
            this.UtilsTestingRunOnAllBinariesOfLength = this.Factory.Get<ICallable<(Int64,ICallable), QVoid>>(typeof(Utils.Testing.RunOnAllBinariesOfLength));
        }

        public override IApplyData __dataIn(Int64 data) => new QTuple<Int64>(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Int64 length)
        {
            return __m__.Run<_TestXIfQubitEqualToInt, Int64, QVoid>(length);
        }
    }

    public partial class XIfLessThan : Unitary<(IQArray<Qubit>,IQArray<Qubit>,Qubit)>, ICallable
    {
        public XIfLessThan(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,IQArray<Qubit>,Qubit)>, IApplyData
        {
            public In((IQArray<Qubit>,IQArray<Qubit>,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "XIfLessThan";
        String ICallable.FullName => "Utils.Compare.XIfLessThan";
        protected ICallable MicrosoftQuantumArraysHead
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

        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumIntrinsicCNOT
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected IUnitary<(IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>)> UtilsMathBitSubtractor
        {
            get;
            set;
        }

        public override Func<(IQArray<Qubit>,IQArray<Qubit>,Qubit), QVoid> Body => (__in__) =>
        {
            var (a,b,target) = __in__;
#line hidden
            {
#line 90 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
                var borrows = Allocate.Apply((a.Length + 1L));
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 91 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
                    UtilsMathBitSubtractor.Apply((a, b, borrows));
#line 93 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
                    var indicator = MicrosoftQuantumArraysHead.Apply<Qubit>(borrows);
#line 94 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
                    MicrosoftQuantumIntrinsicCNOT.Apply((indicator, target));
#line 96 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
                    UtilsMathBitSubtractor.Adjoint.Apply((a, b, borrows));
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
                    Release.Apply(borrows);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,IQArray<Qubit>,Qubit), QVoid> AdjointBody => (__in__) =>
        {
            var (a,b,target) = __in__;
#line hidden
            {
#line hidden
                var __qsVar0__borrows__ = Allocate.Apply((a.Length + 1L));
#line hidden
                Exception __arg1__ = null;
                try
                {
#line hidden
                    var __qsVar1__indicator__ = MicrosoftQuantumArraysHead.Apply<Qubit>(__qsVar0__borrows__);
#line hidden
                    UtilsMathBitSubtractor.Adjoint.Adjoint.Apply((a, b, __qsVar0__borrows__));
#line hidden
                    MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((__qsVar1__indicator__, target));
#line hidden
                    UtilsMathBitSubtractor.Adjoint.Apply((a, b, __qsVar0__borrows__));
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
                    Release.Apply(__qsVar0__borrows__);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,(IQArray<Qubit>,IQArray<Qubit>,Qubit)), QVoid> ControlledBody => (__in__) =>
        {
            var (__controlQubits__,(a,b,target)) = __in__;
#line hidden
            {
#line hidden
                var borrows = Allocate.Apply((a.Length + 1L));
#line hidden
                Exception __arg1__ = null;
                try
                {
#line hidden
                    UtilsMathBitSubtractor.Controlled.Apply((__controlQubits__, (a, b, borrows)));
#line hidden
                    var indicator = MicrosoftQuantumArraysHead.Apply<Qubit>(borrows);
#line hidden
                    MicrosoftQuantumIntrinsicCNOT.Controlled.Apply((__controlQubits__, (indicator, target)));
#line hidden
                    UtilsMathBitSubtractor.Adjoint.Controlled.Apply((__controlQubits__, (a, b, borrows)));
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
                    Release.Apply(borrows);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,(IQArray<Qubit>,IQArray<Qubit>,Qubit)), QVoid> ControlledAdjointBody => (__in__) =>
        {
            var (__controlQubits__,(a,b,target)) = __in__;
#line hidden
            {
#line hidden
                var __qsVar0__borrows__ = Allocate.Apply((a.Length + 1L));
#line hidden
                Exception __arg1__ = null;
                try
                {
#line hidden
                    var __qsVar1__indicator__ = MicrosoftQuantumArraysHead.Apply<Qubit>(__qsVar0__borrows__);
#line hidden
                    UtilsMathBitSubtractor.Adjoint.Adjoint.Controlled.Apply((__controlQubits__, (a, b, __qsVar0__borrows__)));
#line hidden
                    MicrosoftQuantumIntrinsicCNOT.Adjoint.Controlled.Apply((__controlQubits__, (__qsVar1__indicator__, target)));
#line hidden
                    UtilsMathBitSubtractor.Adjoint.Controlled.Apply((__controlQubits__, (a, b, __qsVar0__borrows__)));
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
                    Release.Apply(__qsVar0__borrows__);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumArraysHead = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Arrays.Head<>));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.MicrosoftQuantumIntrinsicCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.CNOT));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.UtilsMathBitSubtractor = this.Factory.Get<IUnitary<(IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>)>>(typeof(Utils.Math.BitSubtractor));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,IQArray<Qubit>,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> a, IQArray<Qubit> b, Qubit target)
        {
            return __m__.Run<XIfLessThan, (IQArray<Qubit>,IQArray<Qubit>,Qubit), QVoid>((a, b, target));
        }
    }

    public partial class XIfLessThanOrEqual : Unitary<(IQArray<Qubit>,IQArray<Qubit>,Qubit)>, ICallable
    {
        public XIfLessThanOrEqual(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,IQArray<Qubit>,Qubit)>, IApplyData
        {
            public In((IQArray<Qubit>,IQArray<Qubit>,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "XIfLessThanOrEqual";
        String ICallable.FullName => "Utils.Compare.XIfLessThanOrEqual";
        protected ICallable MicrosoftQuantumArraysHead
        {
            get;
            set;
        }

        protected ICallable MicrosoftQuantumArraysMost
        {
            get;
            set;
        }

        protected ICallable MicrosoftQuantumArraysTail
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

        protected Release Release
        {
            get;
            set;
        }

        protected IUnitary<(IQArray<Qubit>,Qubit)> XIfAllZero
        {
            get;
            set;
        }

        protected IUnitary<(Qubit,Qubit,Qubit)> UtilsGeneralQubitOr
        {
            get;
            set;
        }

        protected IUnitary<(IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>)> UtilsMathBitSubtractor
        {
            get;
            set;
        }

        public override Func<(IQArray<Qubit>,IQArray<Qubit>,Qubit), QVoid> Body => (__in__) =>
        {
            var (a,b,target) = __in__;
#line hidden
            {
#line 107 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
                var qubits = Allocate.Apply((a.Length + 2L));
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 108 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
                    var borrows = (IQArray<Qubit>)MicrosoftQuantumArraysMost.Apply<IQArray<Qubit>>(qubits);
#line 109 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
                    var zeroTest = MicrosoftQuantumArraysTail.Apply<Qubit>(qubits);
#line 110 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
                    UtilsMathBitSubtractor.Apply((a, b, borrows));
#line 112 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
                    XIfAllZero.Apply((a, zeroTest));
#line 114 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
                    var indicator = MicrosoftQuantumArraysHead.Apply<Qubit>(borrows);
#line 115 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
                    UtilsGeneralQubitOr.Apply((indicator, zeroTest, target));
#line 117 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
                    XIfAllZero.Apply((a, zeroTest));
#line 119 "/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/Utils/Utilsv0.3/Compare.qs"
                    UtilsMathBitSubtractor.Adjoint.Apply((a, b, borrows));
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
        public override Func<(IQArray<Qubit>,IQArray<Qubit>,Qubit), QVoid> AdjointBody => (__in__) =>
        {
            var (a,b,target) = __in__;
#line hidden
            {
#line hidden
                var __qsVar0__qubits__ = Allocate.Apply((a.Length + 2L));
#line hidden
                Exception __arg1__ = null;
                try
                {
#line hidden
                    var __qsVar1__borrows__ = (IQArray<Qubit>)MicrosoftQuantumArraysMost.Apply<IQArray<Qubit>>(__qsVar0__qubits__);
#line hidden
                    var __qsVar2__zeroTest__ = MicrosoftQuantumArraysTail.Apply<Qubit>(__qsVar0__qubits__);
#line hidden
                    var __qsVar3__indicator__ = MicrosoftQuantumArraysHead.Apply<Qubit>(__qsVar1__borrows__);
#line hidden
                    UtilsMathBitSubtractor.Adjoint.Adjoint.Apply((a, b, __qsVar1__borrows__));
#line hidden
                    XIfAllZero.Adjoint.Apply((a, __qsVar2__zeroTest__));
#line hidden
                    UtilsGeneralQubitOr.Adjoint.Apply((__qsVar3__indicator__, __qsVar2__zeroTest__, target));
#line hidden
                    XIfAllZero.Adjoint.Apply((a, __qsVar2__zeroTest__));
#line hidden
                    UtilsMathBitSubtractor.Adjoint.Apply((a, b, __qsVar1__borrows__));
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
                    Release.Apply(__qsVar0__qubits__);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,(IQArray<Qubit>,IQArray<Qubit>,Qubit)), QVoid> ControlledBody => (__in__) =>
        {
            var (__controlQubits__,(a,b,target)) = __in__;
#line hidden
            {
#line hidden
                var qubits = Allocate.Apply((a.Length + 2L));
#line hidden
                Exception __arg1__ = null;
                try
                {
#line hidden
                    var borrows = (IQArray<Qubit>)MicrosoftQuantumArraysMost.Apply<IQArray<Qubit>>(qubits);
#line hidden
                    var zeroTest = MicrosoftQuantumArraysTail.Apply<Qubit>(qubits);
#line hidden
                    UtilsMathBitSubtractor.Controlled.Apply((__controlQubits__, (a, b, borrows)));
#line hidden
                    XIfAllZero.Controlled.Apply((__controlQubits__, (a, zeroTest)));
#line hidden
                    var indicator = MicrosoftQuantumArraysHead.Apply<Qubit>(borrows);
#line hidden
                    UtilsGeneralQubitOr.Controlled.Apply((__controlQubits__, (indicator, zeroTest, target)));
#line hidden
                    XIfAllZero.Controlled.Apply((__controlQubits__, (a, zeroTest)));
#line hidden
                    UtilsMathBitSubtractor.Adjoint.Controlled.Apply((__controlQubits__, (a, b, borrows)));
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
        public override Func<(IQArray<Qubit>,(IQArray<Qubit>,IQArray<Qubit>,Qubit)), QVoid> ControlledAdjointBody => (__in__) =>
        {
            var (__controlQubits__,(a,b,target)) = __in__;
#line hidden
            {
#line hidden
                var __qsVar0__qubits__ = Allocate.Apply((a.Length + 2L));
#line hidden
                Exception __arg1__ = null;
                try
                {
#line hidden
                    var __qsVar1__borrows__ = (IQArray<Qubit>)MicrosoftQuantumArraysMost.Apply<IQArray<Qubit>>(__qsVar0__qubits__);
#line hidden
                    var __qsVar2__zeroTest__ = MicrosoftQuantumArraysTail.Apply<Qubit>(__qsVar0__qubits__);
#line hidden
                    var __qsVar3__indicator__ = MicrosoftQuantumArraysHead.Apply<Qubit>(__qsVar1__borrows__);
#line hidden
                    UtilsMathBitSubtractor.Adjoint.Adjoint.Controlled.Apply((__controlQubits__, (a, b, __qsVar1__borrows__)));
#line hidden
                    XIfAllZero.Adjoint.Controlled.Apply((__controlQubits__, (a, __qsVar2__zeroTest__)));
#line hidden
                    UtilsGeneralQubitOr.Adjoint.Controlled.Apply((__controlQubits__, (__qsVar3__indicator__, __qsVar2__zeroTest__, target)));
#line hidden
                    XIfAllZero.Adjoint.Controlled.Apply((__controlQubits__, (a, __qsVar2__zeroTest__)));
#line hidden
                    UtilsMathBitSubtractor.Adjoint.Controlled.Apply((__controlQubits__, (a, b, __qsVar1__borrows__)));
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
                    Release.Apply(__qsVar0__qubits__);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumArraysHead = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Arrays.Head<>));
            this.MicrosoftQuantumArraysMost = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Arrays.Most<>));
            this.MicrosoftQuantumArraysTail = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Arrays.Tail<>));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.XIfAllZero = this.Factory.Get<IUnitary<(IQArray<Qubit>,Qubit)>>(typeof(XIfAllZero));
            this.UtilsGeneralQubitOr = this.Factory.Get<IUnitary<(Qubit,Qubit,Qubit)>>(typeof(Utils.General.QubitOr));
            this.UtilsMathBitSubtractor = this.Factory.Get<IUnitary<(IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>)>>(typeof(Utils.Math.BitSubtractor));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,IQArray<Qubit>,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> a, IQArray<Qubit> b, Qubit target)
        {
            return __m__.Run<XIfLessThanOrEqual, (IQArray<Qubit>,IQArray<Qubit>,Qubit), QVoid>((a, b, target));
        }
    }
}