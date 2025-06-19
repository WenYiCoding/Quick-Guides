//This is a comment
/*This is a 
comment block*/
import java.util.Scanner;     //Import other elements. Format is {import Package.Name.Class} ({*} to include all)

public class qg {       //Every file must have 1 main {public} class, name must same as file name
    public static void main(String[] args) {    //Main class must have 1 {public static void main} function
        System.out.print("\033[H\033[2J");  
        System.out.flush();

        // Declare variables
        // 1. Integers
        byte byteVar = -128;
        short shortVar = -32768;
        int intVar = -2147483648;
        long longVar = -9223372036854775808L;   //Suffix {l/L} is needed
        // 2. Floating points
        float floatVar = 10.1234567f;           //Suffix {f/F} is preferable
        double doubleVar = 10.123456789012345d; //Suffix {d/D} is preferable
        float scnNum = 12E10f;                  //Infix {e/E} is needed, it represents exponent of 10
        // 3. Others
        boolean boolVar = true;
        char charVar = 'A';         //Must be single charactor, must using single quote
        String strVar = "ABC";      //Must using double quote, Non-primitive (like Array) compared to mentioned types (Hint is syntax cap)
        // 4. Type casting
        double intToDbl = 10;           //Auto widening casting only from small to large type (byte -> short -> char -> int -> long -> float -> double)
        int dblToInt = (int) 10.50d;    //Manual narrowing casting if reverse data size
        // 5. Multiple variables
        int num1 = 10, num2 = 20, byte1 = 5, byte2 = 7; //Only possible for multiple var with same type
        int var1, var2, var3;
        var1 = var2 = var3 = 1000;      //Multiple var with same value

        // java.util.Scanner, class for user input
        Scanner scannerObj = new Scanner(System.in); //Declare a object for scanner
        System.out.println("Enter: ");  //Better make a prompt using cli or gui
        String userInput = scannerObj.nextLine();   //Use {object.nextLine()} for retrieve strings before user enter

        // Operators
        int total, total1, total2 = 0;
        boolean condition1, condition2, condition3;
        // 1. Arithmetic operators
        total = num1 + num2;
        total = num1 - num2;
        total = num1 * num2;
        total = num1 / num2;
        total = num1 % num2;
        total = num1++;         //Increament, add 1
        total = num1--;         //Decreament, sub 1
        // 2. Bitwise operators
        total = byte1 & byte2;  //And
        total = byte1 | byte2;  //Or
        total = byte1 ^ byte2;  //Xor
        total = ~byte1;         //Not
        total = byte1 << 1;     //Left shift
        total = byte1 >> 1;     //Right shift
        total = byte1 >>> 1;    //Unsigned right shift
        // 3. Assignment operators
        total1 = num1;
        total1 += num1;
        total1 -= num1;
        total1 *= num1;
        total1 /= num1;
        total1 %= num1;
        total2 &= byte1;
        total2 |= byte1;
        total2 ^= byte1;
        total2 >>= 2;
        total2 <<= 2;
        // 4. Comparison operators
        condition1 = (num1 == num2);
        condition1 = (num1 != num2);
        condition1 = (num1 > num2);
        condition2 = (num1 < num2);
        condition2 = (num1 >= num2);
        condition2 = (num1 <= num2);
        // 5. Logical operators
        condition3 = (condition1 && condition2);
        condition3 = (condition1 || condition2);
        condition3 = !(condition1);
        System.out.println("Hello World");

        //String manipulation
        String string1, escapeChars;
        // 1. String concatenation
        string1 = "test" + "ing" + 1 + " " + "!";   //Numbers will be treated as string when adding strings
        string1.concat("!!");
        // 2. Escape/Special characters
        escapeChars = "\'" + "\"" + "\\";
        escapeChars += "\n" + "\r" + "\t" + "\b" + "\f";
        // 3. Others
        string1.length();
        string1.toUpperCase();
        string1.toLowerCase();
        string1.indexOf("s");
        string1.charAt(0);
        string1.contains("est");

        //Condition check
        // 1. If else
        if (condition1) {

        }
        else if (condition2) {
            
        }
        else {

        }
        // 2. Switch
        switch (string1) {
            case "A":
                break;
            case "B":
                break;
            case "C":
                break;
            case "D":   //Make OR conditions
            case "E":
                break;
            default:
                break;
        }
        // 3. Ternary operator
        String conditionalVar = (condition1) ? "True" : "False";

        //Iterations
        // 1. While loop
        while (condition1) { 
            break;
        }
        // 2. For loop
        for (int i = 0; i < 10; i++) {
            continue;
        }
        // 3. For each loop
        int[] arrayInt = {1, 2, 3, 4};
        for (int item: arrayInt) {
            break;
        }

        // Array
        char[] arrayChar = {'a', 'b', 'c', 'd', 'd'};
        char item = arrayChar[0];
        arrayChar[4] = 'e';

        // Method call
        int argument1 = 0, argument2 = 0;
        myMethod1(argument1, argument2);
        myMethod1(arrayInt);

        // Create object, check below for declaration
        class1 object1 = new class1(40);
        int objAttr1 = object1.attribute1;
        object1.attribute1 = 10;
        //object1.attribute4 = 10;      //Cause error because attribute is final/constant
        class1.class1StaticMethod();   //Accessing static method through class
        object1.class1PublicMethod();   //Accessing non-static method through object
    }

    // Method declaration
    static int myMethod1(int parameter1, int parameter2) {
        return parameter1 + parameter2;
    }
    static void myMethod1(int[] args) {     //Method overloading, same method name but different workings
        int localVar = 0;   //This variable only for block scope
    }

    // Recursion, method call itself, check needed
    static int recursionMethod(int count) {
        int result = (count <= 0) ? 0 : recursionMethod(count);
        return result;
    }
}

class class1 {  //Declare class
    int attribute1 = 0;     //Declare class attributes
    int attribute2;
    int attribute3;
    public class1(int x) {           //Constructor for initialize attributes when creating instance
        attribute2 = 20;
        attribute3 = x;
    }

    // Modifiers
    // 1. Accesibility
    public void class1PublicMethod() {}    //Public make the function able to be called from other classes
    private void class1PrivateMethod() {}  //Private make the function only can be called from its class
    protected void class1ProtectedMethod() {} //Protected make the function only can be called from its own subclass
    // 2. Others
    final int attribute4 = 0;      //Final make this attribute immutable, constant
    static void class1StaticMethod() {}    //Static make the function can be called without instance

    // Encapsulation
    private int privateVar1 = 0;    //Declare private variable to prevent accidental access
    public int getPrivateVar1() {   //Make a function to get value explicitly
        return privateVar1;
    }
    public void setPrivateVar1(int var1Value) { //Make a function to set value explicitly
        this.privateVar1 = var1Value;
    }
}
