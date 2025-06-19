//Based on JavaScript but with type syntax, read JavaScript folder for more basic guides

// Declare variables
// 1. Explicit
let strVar: string = "string";
let numVar: number = 0;
let boolVar: boolean = false;   //{Boolean} != {boolean}
let anyVar: any = "4545";   //Accepts any type as value but beat purpose of Ts
let unknownVar: unknown = "4545";   //Like {any} but cannot use to prevent errors. Can cast, type check then use this var later
let nullVar: null = null;   //Null for null
let undefVar: undefined = undefined;    //Undefined for undefined
// 2. Implicit
let inferVar = 0; //TypeScript will "determine data type" / infer
let anyTypeVar = func(0);    //Ts will infer {any} type

function func(i) {
    return 0
}

// Array
let arrayVar1 = ["str1", "str2", "str3"];   //Ts will infer this as array. Js way to define array
let arrayVar2: string[] = ["str1", "str2", "str3"];
const arrayConst: string[] = ["str1", "str2", "str3"];  //Still able to manipulate
const aryReadOnly: readonly string[] = ["str1", "str2", "str3"];    //Truthly unable to manipulate

// Tuple
let tupleVar: [string, number, boolean] = ["str", 0, true]; //Each element must match its type in order
tupleVar.push("wrong"); //Not enforce types for new element
const tupleConst: readonly [string, number, boolean] = ["str", 0, true];    //{readonly} makes variable immutable

// Object
let object1 = {     //Js way to define object, Ts will infer this as obj
    property1: 0,
    property2: "str",
    property3: true
}
let object2: {
    property1: number,
    property2: string,
    property3: boolean,
    property4?: number} = { //This line declare optional property which you can define later
    property1: 0,
    property2: "str",
    property3: true
}
object2.property4 = 2000;   //Optional property is defined
let object3: {
    [index: string]: number //Allow multiple property with the same type declared
} = {
    property1: 10,
    property2: 20,
    property3: 30
}

// Enumerates
enum enumVar1{   //{enum} is a list of indexed constants
    valueA,
    valueB,
    valueC,
    valueD
}
enum enumVar2{   //Assign a staring index will make subsequent value increment its index
    valueA = 10,
    valueB,
    valueC,
    valueD
}
enum enumVar3{   //Fully assign indexes will stop auto-assign
    valueA = 22,
    valueB = 44,
    valueC = 66,
    valueD = 88
}
enum enumVar4{   //Index can be string
    valueA = "A",
    valueB = "B",
    valueC = "C",
    valueD = "D"
}

// Alternative type name
// 1. Aliases
type stringAlias = string;
let aliasTypeVar: stringAlias = "test";
// 2. Interface, alias for object
interface objInterface {
    property1: number,
    property2: string,
    property3: boolean
}
let object4: objInterface = {
    property1: 0,
    property2: "string",
    property3: true
}
// 3. Extends interface, duplicate existing interface and adding new property type
interface objInterfaceEx extends objInterface {
    property4: any
}
let object5: objInterfaceEx = {
    property1: 0,
    property2: "string",
    property3: true,
    property4: "454"
}

// Union (OR{|}) types, allow both type in one variable
let strPlusNum1: string | number = 0;
let strPlusNum2: string | number = "zero";

// Function
function function1() {  //Ts will infer return value
    return 0;
}
function function2(): number {  //Define return type
    return 0;
}
function function3(): void {  //Define void function
}
function function4(x: number, y: number) {  //Define parameter type, infer as {any} if no type defined
}
function function5(z?: number) {  //Define optional parameter using {?}
}
function function6(x = 10, y: number = 20) {  //Define default parameter, infer if no type defined
}
function function7({x,y}: {x: number, y: number}) {  //Define named parameter (technically its object passing as no such mechanics)
}
function function8(...args: number[]) {  //Define rest parameter, must be array
}
type func9Type = (x: number) => number;  //Define types ahead for arrow function format
let function9a: func9Type = (x) => x;

// Casting
unknownVar as string;   //Cast a variable by appending {as} with type behind the variable, but data is not converted and may cause error
<unknown>unknownVar;    //Same as {as} casting
unknownVar as unknown as string; //Cast better by cast it as {unknown} then target type

// Class
// 1. Define the class
class class1 {
    prop1: string;
}
let class1Var = new class1();
class1Var.prop1 = "string";
// 2. Constructor
class class2 {
    constructor(prop1: number) {}
}
// 3. Visibility modifiers
class class3 {
    public prop1: string;   //Can be accessed outside class
    private prop2: number;  //Only accessed inside class
    protected prop3: boolean;   //Only accessed inside class and its child
}

// Generics
// Utility types
// Keyof
// Null
// Definitely type