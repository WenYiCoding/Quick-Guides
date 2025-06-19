//Comment Line
/*
Comment Block
*/

// Output
console.log("output");

// Declare variables
// 1. Basics
x = 0;  //Will declared when used
let y = 0;  //Declare variable as block scope, prefered syntax
var z = 0;  //Declare variable as function scope
const w = 0;
// 2. Multiple declarations
let var1 = 1, var2 = 2, var3 = 3;   //Declare multiple variables in a line
// 3. Redefine
var z;      //Does not have error
//let y;     //This will cause error 
// 4. Naming convention
let $mainFunc;  //{$} normally is for main function alias
let _hiddenVar;     //{_} normally used for hidden/private variables

// Data Types, type is not enforced. Use TypeScript if need enforce data type safety
// 1. String
let str1Var = "abc";
let str2Var = "def";
// 2. Number, 64-bit floating point
let num1Var = 9007199254740991;     //Can be treated as integer
let num2Var = 9.20;     //Can be treated as floating point
// 3. BigInt
let bigInt1Var = 99999999999999999999n; //Append suffix {n} to number
let bigInt2Var = BigInt(99999999999999999999);  //Use {BigInt()} to convert number 
// 4. Boolean
let bool1Var = true;
let bool2Var = false;
// 5. Undefined
let undefVar;
// 6. Null
let nullVar = null;
// 7. Symbol, immutable and unique
let symbol1Var = Symbol();
let symbol2Var = Symbol(0);
let symbol3Var = Symbol("asd");
// 8. Built-in object types
let objVar = new Object();
let aryVar = new Array();
let dateVar = new Date();
let mapVar = new Map();
let setVar = new Set();
let intAry1Var = new Int8Array();
let intAry2Var = new Int16Array();
let intAry3Var = new Int32Array();
let floatAry1Var = new Float32Array();
let floatAry2Var = new Float64Array();
let promiseVar = new Promise(function(myResolve, myReject) {
    myResolve();
    myReject();
});;

// Operators
// 1. Arithmetic Operators
num1Var + num2Var;  //Addition
num1Var - num2Var;  //Substraction
num1Var * num2Var;  //Multiplication
num1Var ** num2Var; //Exponentation
num1Var / num2Var;  //Division
num1Var % num2Var;  //Modulus
num1Var++;  //Increment
num1Var--;  //Decrement
// 2. Assignment Operators
let total = 0;
total += num1Var;
total -= num1Var;
total *= num1Var;
total **= num1Var;
total /= num1Var;
total %= num1Var;
// 3. Comparison Operators, return boolean as result
num1Var == num2Var;     //Equal value
num1Var === num2Var;    //Equal value and type
num1Var != num2Var;     //Not equal value
num1Var !== num2Var;    //Not equal value or type
num1Var > num2Var;
num1Var >= num2Var;
num1Var < num2Var;
num1Var <= num2Var;
// 4. String Operators
str1Var + str2Var;  //Concatination for string
str1Var + num1Var;  //Number will be treated as string if concat
(num1Var + num2Var) + str1Var;    //Numbers can be added before concatinate string, order is important
str1Var > str2Var;      //Strings also can be compared alphabatically
// 5. Logical Operators
bool1Var && bool2Var;
bool1Var || bool2Var;
!bool1Var;
// 6. Type Operators
typeof var1;    //Return type name
var2 instanceof Object; //Return boolean as result
// 7. Bitwise Operators
num1Var & num2Var;  //AND
num1Var | num2Var;  //OR
~num1Var;   //NOT
num1Var ^ num2Var;  //XOR
num1Var << 1;   //Left shift
num1Var >> 1;   //Right shift
num1Var >>> 1;   //Unsigned right shift

// Conditionals
// 1. If-else
if (bool1Var) {
}
else if (bool2Var) {
}
else {
}
// 2. Ternary operator
let ternaryVar = bool1Var ? true : false;
// 3. Switch
switch (str1Var) {
    case 0:
        break;
    case 1:
    case 2:     //This case will become {OR} with previous case
        break;
    default:    //Else
        break;
}

// Array
let ary1Var = [1, 2, 3];    //Declare and assign
let ary2Var = new Array(4, 5, 6);   //Declare using constructor, create unexpected array if only one element
ary1Var[0];     //Access array element
ary1Var[0] = 0; //Change element value of index
ary1Var[4] = 10; //Add new element if index not found, create {undefined} "holes" if index is too far
ary1Var.push(20);   //Append new element
ary1Var.pop();  //Remove and return last element
ary1Var.length; //Check array length
ary1Var.toString(); //Convert array to string

// Iteration loop
// 1. While loop
while(bool1Var) {
    break;  //{break} to force end the current loop
}
// 2. For loop
// 2a. Counting
for (let i = 0; i < 10; i++) {
    continue;   //{continue} to skip the current iteration
}
// 2b. For-In, iterate each item as index
for (let index in ary2Var) {
}
// 2c. For-Of, iterate each item as variable
for (let item of ary2Var) {
}

// Functions
let argument1 = 0, argument2 = 1;
function function1(parameter1, parameter2) {    //Function defined with parameters
    return parameter1 + parameter2;     //Give the value and end the function
}
function1(argument1, argument2)     //Function is invoked/called

function function2(...args) {   //The parameter is "spread"ed
}

// Objects
// 1. Declare object
let obj1Var = {prop1: 10, prop2: 20, prop3: 30};    //Declare using literals
let obj2Var = new Object(); //Declare using constructor
obj2Var.prop1 = 0;
obj2Var.prop2 = 0;
obj2Var.prop3 = 0;
obj2Var.prop4 = 0;
// 2. Access properties
obj2Var.prop1;
obj2Var["prop1"];
// 3. Object method
let obj3Var = {
    prop1: 1,
    prop2: function() {
        return this.prop1;  //{this} refers to instance
    }
}
// 4. Create constructor
function objConstructor(prop1, prop2, prop3) {
    this.prop1 = prop1;
    this.prop2 = prop2;
    this.prop3 = prop3;
    this.defaultProp = "default";
}
let obj4Var = new objConstructor(10, 20, 30);
objConstructor.prototype.newProp = "new";  //Add new property to constructor

// Class
class class1 {
    constructor(prop1) {
        this.prop1 = prop1;
    }
    method1() {
    }
}
let obj5Var = new class1(10);
