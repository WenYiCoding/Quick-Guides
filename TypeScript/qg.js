//Based on JavaScript but with type syntax, read JavaScript folder for more basic guides
// Declare variables
// 1. Explicit
var strVar = "string";
var numVar = 0;
var boolVar = false; //{Boolean} != {boolean}
var anyVar = "4545"; //Accepts any type as value but beat purpose of Ts
var unknownVar = "4545"; //Like {any} but cannot use to prevent errors. Can cast, type check then use this var later
var nullVar = null; //Null for null
var undefVar = undefined; //Undefined for undefined
// 2. Implicit
var inferVar = 0; //TypeScript will "determine data type" / infer
var anyTypeVar = func(0); //Ts will infer {any} type
function func(i) {
    return 0;
}
// Array
var arrayVar1 = ["str1", "str2", "str3"]; //Ts will infer this as array. Js way to define array
var arrayVar2 = ["str1", "str2", "str3"];
var arrayConst = ["str1", "str2", "str3"]; //Still able to manipulate
var aryReadOnly = ["str1", "str2", "str3"]; //Truthly unable to manipulate
// Tuple
var tupleVar = ["str", 0, true]; //Each element must match its type in order
tupleVar.push("wrong"); //Not enforce types for new element
var tupleConst = ["str", 0, true]; //{readonly} makes variable immutable
// Object
var object1 = {
    property1: 0,
    property2: "str",
    property3: true
};
var object2 = {
    property1: 0,
    property2: "str",
    property3: true
};
object2.property4 = 2000; //Optional property is defined
var object3 = {
    property1: 10,
    property2: 20,
    property3: 30
};
// Enumerates
var enumVar1;
(function (enumVar1) {
    enumVar1[enumVar1["valueA"] = 0] = "valueA";
    enumVar1[enumVar1["valueB"] = 1] = "valueB";
    enumVar1[enumVar1["valueC"] = 2] = "valueC";
    enumVar1[enumVar1["valueD"] = 3] = "valueD";
})(enumVar1 || (enumVar1 = {}));
var enumVar2;
(function (enumVar2) {
    enumVar2[enumVar2["valueA"] = 10] = "valueA";
    enumVar2[enumVar2["valueB"] = 11] = "valueB";
    enumVar2[enumVar2["valueC"] = 12] = "valueC";
    enumVar2[enumVar2["valueD"] = 13] = "valueD";
})(enumVar2 || (enumVar2 = {}));
var enumVar3;
(function (enumVar3) {
    enumVar3[enumVar3["valueA"] = 22] = "valueA";
    enumVar3[enumVar3["valueB"] = 44] = "valueB";
    enumVar3[enumVar3["valueC"] = 66] = "valueC";
    enumVar3[enumVar3["valueD"] = 88] = "valueD";
})(enumVar3 || (enumVar3 = {}));
var enumVar4;
(function (enumVar4) {
    enumVar4["valueA"] = "A";
    enumVar4["valueB"] = "B";
    enumVar4["valueC"] = "C";
    enumVar4["valueD"] = "D";
})(enumVar4 || (enumVar4 = {}));
var aliasTypeVar = "test";
var object4 = {
    property1: 0,
    property2: "string",
    property3: true
};
var object5 = {
    property1: 0,
    property2: "string",
    property3: true,
    property4: "454"
};
// Union (OR{|}) types, allow both type in one variable
var strPlusNum1 = 0;
var strPlusNum2 = "zero";
