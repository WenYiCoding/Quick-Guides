using System;
using System.Linq;  // Importing LINQ for array manipulation and other operations

namespace HelloWorld    // Every C# program starts with a namespace declaration
{
    class Program   // Every C# program contains a class
    {
        static void Main(string[] args) // The Main method is the entry point of the program
        {
            Console.Clear();  // Clear the console terminal

            // Comment: This is a single-line comment in C#
            /*
            This is a multi-line
            comment in C#
            */

            // Declaring variables
            // 1. Numeric types
            // 1a. Integer types
            int intVar = 42;  // Integer type
            long longVar = 1234567890123456789L;  // Long type, 'L' suffix indicates a long literal
            // 1b. Floating-point types
            float floatVar = 3.14f;  // Float type, 'f' suffix indicates a float literal
            float exponentialFloatVar = 1.5e2f;  // Float with exponential notation, 'e' indicates exponent
            double doubleVar = 3.141592653589793;  // Double type
            // 2. Boolean type
            bool boolVar = true;  // Boolean type
            // 3. Character type
            char charVar = 'A';  // Character type
            // 4. String type
            string stringVar = "Hello, C#";  // String type

            // Declaring multiple same-type variables in one line
            int anotherIntVar = 100, yetAnotherIntVar = 200;  // Multiple integers declared in one line
            // Declaring variables without initialization
            int withoutInitialization;  // Variable declared but not initialized
            withoutInitialization = 100;  // Now initialized
            // Declaring a constant variable
            const int constantValue = 10;  // Constant variable, cannot be changed
            // constantValue = 20;  // This will cause a compile-time error, uncommenting for error
            // Implicitly typed variable
            var inferredTypeVar = "This is a string";  // Implicitly typed variable, type is determined at compile time depending on the assigned value

            // Type casting
            // 1. Implicit casting (widening conversion: char > int > long > float > double), safe conversions
            int implicitInt = charVar;  // Implicit conversion from char to int
            long implicitLong = intVar;  // Implicit conversion from int to long
            double implicitDouble = floatVar;  // Implicit conversion from float to double
            // 2. Explicit casting (narrowing conversion: double > float > long > int > char), may lose data
            // 2a. Placing a cast operator (type with parentheses) before the value to convert
            double explicitDouble = 3.14;  // Double type
            float explicitFloat = (float)explicitDouble;  // Explicit conversion from double to float
            int explicitInt = (int)explicitFloat;  // Explicit conversion from float to int, may lose precision
            // 2b. Using Convert class for conversion
            string numberString = "123";  // String representation of a number
            int convertedInt = Convert.ToInt32(numberString);  // Convert string to int using Convert class
            double convertedDouble = Convert.ToDouble(numberString);  // Convert string to double using Convert class

            // Console class for input/output
            // 1. Writing output to the console
            Console.Write("Hello World!");  // Using console to print text
            Console.WriteLine("Hello World!");  // Same but with a new line at the end
            // 2. Reading input from the console
            ConsoleKeyInfo consoleKeyInfo;
            consoleKeyInfo = Console.ReadKey();  // Reads a single key press from the console, returns a ConsoleKeyInfo object
            Console.WriteLine();  // Print a new line after reading the key
            Console.WriteLine("You entered: " + consoleKeyInfo.KeyChar);
            String inputString;
            inputString = Console.ReadLine();  // Reads a line of input from the console, returns a string, need casting to other types if needed
            Console.WriteLine("You entered: " + inputString);

            // Operators
            int num1 = 5;
            int num2 = 10;
            int bitVar = 3;
            // 1. Arithmetic operators
            int sum = num1 + num2;  // Addition
            int difference = num1 - num2;  // Subtraction
            int product = num1 * num2;  // Multiplication
            int quotient = num1 / num2;  // Division
            int remainder = num1 % num2;  // Modulus, gives the remainder of division
            int incrementedValue = ++num1;  // Increment
            int decrementedValue = --num2;  // Decrement
            // 2. Bitwise operators
            int andVar = num1 & num2;  // Bitwise AND
            int orVar = num1 | num2;  // Bitwise OR
            int xorVar = num1 ^ num2;  // Bitwise XOR
            int leftShiftVar = num1 << 1;  // Left shift
            int rightShiftVar = num2 >> 1;  // Right shift
            // 3. Comparison operators
            bool isEqual = num1 == num2;  // Equality
            bool isNotEqual = num1 != num2;  // Inequality
            bool isGreater = num1 > num2;  // Greater than
            bool isLess = num1 < num2;  // Less than
            bool isGreaterOrEqual = num1 >= num2;  // Greater than or equal to
            bool isLessOrEqual = num1 <= num2;  // Less than or equal to
            // 4. Logical operators
            bool andCondition = (num1 > 0) && (num2 > 0);  // Logical AND
            bool orCondition = (num1 > 0) || (num2 < 0);  // Logical OR
            bool notCondition = !(num1 < num2);  // Logical NOT
            // 5. Assignment operators
            intVar = 10;  // Simple assignment
            intVar += 5;  // Add and assign
            intVar -= 3;  // Subtract and assign
            intVar *= 2;  // Multiply and assign
            intVar /= 4;  // Divide and assign
            intVar %= 3;  // Modulus and assign
            bitVar &= 2;  // Bitwise AND and assign
            bitVar |= 1;  // Bitwise OR and assign
            bitVar ^= 3;  // Bitwise XOR and assign
            bitVar <<= 1;  // Left shift and assign
            bitVar >>= 1;  // Right shift and assign
            // 6. Ternary operator
            string result = (num1 > num2) ? "num1 is greater" : "num2 is greater";  // Ternary operator for conditional assignment
            Console.WriteLine(result);  // Output the result of the ternary operation
            // 7. Null-coalescing operator
            string nullableString = null;  // Nullable string
            string nonNullableString = nullableString ?? "Default Value";  // If nullableString is null, use "Default Value"
            Console.WriteLine(nonNullableString);  // Output the result of the null-coalescing operation

            // Math class for mathematical operations
            int minVar = Math.Min(num1, num2);  // Minimum of two numbers
            int maxVar = Math.Max(num1, num2);  // Maximum of two numbers
            double power = Math.Pow(2, 3);  // Power function
            double squareRoot = Math.Sqrt(16);  // Square root of a number
            int absVar = Math.Abs(-10);  // Absolute value of a number, turns negative to positive
            int roundVar = (int)Math.Round(3.6);  // Rounding a number, converts to nearest integer, must cast to int
            int floorVar = (int)Math.Floor(3.6);  // Floor function, rounds down to nearest integer, must cast to int
            int ceilVar = (int)Math.Ceiling(3.6);  // Ceiling function, rounds up to nearest integer, must cast to int
            double randomValue = new Random().NextDouble();  // Generates a random double between 0.0 and 1.0
            int randomInt = new Random().Next(1, 100);  // Generates a random integer between inclusive 1 and exclusive 100

            // String manipulation 
            string text1 = "Hello";
            string text2 = "World";
            // 1. Length of a string
            int lengthOfText1 = text1.Length;  // Length of the string
            // 2. Accessing characters in a string
            char firstChar = text1[0];  // Accessing the first character of the string
            // 3. Substring
            string substring = text1.Substring(1, 3);  // Extracting a substring from the string, starting at index 1 and taking 3 characters
            // 4. String methods
            string upperText = text1.ToUpper();  // Converting string to uppercase
            string lowerText = text2.ToLower();  // Converting string to lowercase
            // 5. String comparison
            bool areEqual = text1.Equals(text2);  // Comparing two strings for equality
            bool containsText = text1.Contains("ell");  // Checking if a string contains a substring
            // 6. String formatting
            string formattedText = string.Format("Formatted: {0} {1}", text1, text2);  // Formatting strings using string.Format
            // 7. String splitting
            string[] splitText = text1.Split('l');  // Splitting a string into an array based on a delimiter
            // 8. String joining
            string joinedText = string.Join(", ", splitText);  // Joining an array of strings into a single string with a delimiter
            // 9. String trimming
            string trimmedText = "   Trim me   ".Trim();  // Trimming whitespace from both ends of a string
            // 10. String replacement
            string replacedText = text1.Replace("Hello", "Hi");  // Replacing a substring in a string
            // 11. String concatenation
            string concatenatedText = text1 + " " + text2;  // Concatenation
            Console.WriteLine(concatenatedText);
            Console.WriteLine("Small Number: " + intVar);  // Concatenating string with variable
            Console.WriteLine(num1 + num2);  // Numbers will not concatenate, expression will be evaluated instead
            // 12. Interpolation
            string interpolatedText = $"{text1} {text2}";  // Using string interpolation
            // 13. Special characters in strings, escaping characters
            string singleQuoteString = "\'";  // Single quote in a string
            string doubleQuoteString = "\"";  // Double quote in a string
            string backslashString = "\\";  // Backslash in a string
            string newLineString = "New\nLine";  // New line in a string
            string tabString = "Tab\tCharacter";  // Tab character in a string
            string backspaceString = "Backspace\bCharacter";  // Backspace character in a string
            string carriageReturnString = "Carriage\rReturn";  // Carriage return character in a string
            string formFeedString = "FormFeed\fCharacter";  // Form feed character in a string
            string unicodeString = "\u0041";  // Unicode character, \u followed by 4 hex digits
            string hexString = "\x41";  // Hexadecimal character, \x followed by hex digits
            // 14. Verbatim strings, allows multi-line and special characters without escaping
            string verbatimString = @"This is a verbatim string, it can contain
            new lines and special characters like \ without escaping. Escape double quotes "" like this.";
            // string doesNotWork = @'';  // Only double quotes can be used in verbatim strings

            // Conditional statements
            // 1. If statement
            if (num1 > num2)  // If condition
            {
                Console.WriteLine("num1 is greater than num2");
            }
            else if (num1 < num2)  // Else if condition
            {
                Console.WriteLine("num1 is less than num2");
            }
            else  // Else condition
            {
                Console.WriteLine("num1 is equal to num2");
            }
            // 2. Switch statement
            switch (num1)  // Switch on num1
            {
                case 5:  // Case for 5
                    Console.WriteLine("num1 is 5");
                    break;  // Break to exit switch
                case 10:  // Case for 10
                    Console.WriteLine("num1 is 10");
                    break;  // Break to exit switch
                default:  // Default case if no match
                    Console.WriteLine("num1 is neither 5 nor 10");
                    break;  // Break to exit switch
            }
            // 3. Ternary operator
            bool resultMessage = (num1 > num2) ? true : false;  // Ternary operator for conditional assignment

            // Loops
            // 1. While loop
            int counter = 0;  // Initialize counter
            while (counter < 5)  // While condition
            {
                Console.WriteLine("Counter: " + counter);  // Print counter value
                counter++;  // Increment counter
            }
            // 2. Do-while loop
            int doCounter = 0;  // Initialize do-while counter
            do
            {
                Console.WriteLine("Do-While Counter: " + doCounter);  // Print do-while counter value
                doCounter++;  // Increment do-while counter
            } while (doCounter < 5);  // Do-while condition
            // 3. For loop
            for (int i = 0; i < 5; i++)  // For loop with initialization, condition, and increment
            {
                Console.WriteLine("For Loop Counter: " + i);  // Print for loop counter value
            }
            // 4. Foreach loop
            string[] names = { "Alice", "Bob", "Charlie" };  // Array of names
            foreach (string name in names)  // Foreach loop to iterate over array
            {
                Console.WriteLine("Name: " + name);  // Print each name
            }
            // 5. Break statement
            for (int i = 0; i < 10; i++)  // For loop
            {
                if (i == 5)  // If condition to break
                {
                    Console.WriteLine("Breaking at i = " + i);  // Print message before breaking
                    break;  // Break out of the loop
                }
                Console.WriteLine("i: " + i);  // Print current value of i
            }
            // 6. Continue statement
            for (int i = 0; i < 10; i++)  // For loop
            {
                if (i % 2 == 0)  // If condition to continue
                {
                    Console.WriteLine("Skipping even number: " + i);  // Print message for even numbers
                    continue;  // Skip the rest of the loop for this iteration
                }
                Console.WriteLine("Odd number: " + i);  // Print odd numbers
            }
            // 7. Return statement
            int ReturnExample(int number)  // Method to demonstrate return statement
            {
                if (number < 0)  // If condition
                {
                    return -1;  // Return -1 for negative numbers
                }
                else if (number == 0)  // Else if condition
                {
                    return 0;  // Return 0 for zero
                }
                else  // Else condition
                {
                    return number * number;  // Return square of the number for positive numbers
                }
            }

            // Arrays
            // 1. Declaring and initializing an array
            int[] numbersArray1 = new int[5];  // Declaring an array of integers with size 5
            numbersArray1[0] = 1;  // Assigning values to the array
            numbersArray1[1] = 2;  // Assigning values to the array
                                   // Note: empty elements in an array are initialized to default values (0 for int, null for reference types)
                                   // 2. Declaring and initializing an array with values
            int[] initializedArray = { 1, 2, 3, 4, 5 };  // Declaring and initializing an array with values
            int[] initializedArray2 = new int[6] { 1, 2, 3, 4, 5, 6 };  // Declaring and initializing an array with values, size can be omitted if values are provided
            // 3. Accessing array elements
            int firstElement = initializedArray[0];  // Accessing the first element of the array
            int lastElement = initializedArray[initializedArray.Length - 1];  // Accessing the last element of the array
            // 4. Array manipulation
            int arrayLength = initializedArray.Length;  // Getting the length of the array
            int indexOfValue = Array.IndexOf(initializedArray, 3);  // Finding the index of a value in the array
            bool containsValue = initializedArray.Contains(3);  // Checking if the array contains a value
            Array.Sort(initializedArray);  // Sorting the array in ascending order
            Array.Reverse(initializedArray);  // Reversing the array
            Array.Resize(ref initializedArray, 10);  // Resizing the array to a new size, must use ref keyword
            initializedArray.Max();  // Getting the maximum value in the array, must use System.Linq namespace
            initializedArray.Min();  // Getting the minimum value in the array, must use System.Linq namespace
            initializedArray.Sum();  // Getting the sum of all elements in the array, must use System.Linq namespace

            // Methods
            // 1a. Normal method
            void NormalMethod(int parameter)  // Method with a parameter, structure is "returnType methodName(parameterType parameterName) { ... }"
            {
                Console.WriteLine("Method called with parameter: " + parameter);  // Print the parameter value
            }
            NormalMethod(5);
            // 1b. Method without parameters
            void MethodWithoutParameters()  // Method without parameters
            {
                Console.WriteLine("Method without parameters called");  // Print a message
            }
            MethodWithoutParameters();
            // 1c. Method with infinite parameters
            void MethodWithParams(params int[] parameters)  // Method that accepts a variable number of integer parameters
            {
                Console.WriteLine("Method called with " + parameters.Length + " parameters");  // Print the number of parameters
                foreach (var param in parameters)  // Iterate through each parameter
                {
                    Console.WriteLine("Parameter: " + param);  // Print each parameter value
                }
            }
            MethodWithParams(1, 2, 3, 4, 5);  // Calling the method with multiple parameters
            MethodWithParams(10, 20);  // Calling the method with fewer parameters
            // 1d. Method with optional parameters
            void MethodWithOptionalParameters(int requiredParam, int optionalParam = 10)  // Method with a required and an optional parameter
            {
                Console.WriteLine("Required: " + requiredParam + ", Optional: " + optionalParam);  // Print the parameters
            }
            MethodWithOptionalParameters(5);  // Calling the method with only the required parameter
            MethodWithOptionalParameters(5, 15);  // Calling the method with both parameters
            // 1e. Method with named parameters
            void MethodWithNamedParameters(int firstParam, int secondParam)  // Method with named parameters
            {
                Console.WriteLine("First: " + firstParam + ", Second: " + secondParam);  // Print the parameters
            }
            MethodWithNamedParameters(secondParam: 20, firstParam: 10);  // Calling the method with named parameters
            // 1f. Method with return value
            int MethodWithReturnValue(int number)  // Method that returns an integer value
            {
                return number * number;  // Return the square of the number
            }
            int methodReturnResult = MethodWithReturnValue(5);  // Calling the method and storing the result
            Console.WriteLine("Result of MethodWithReturnValue: " + methodReturnResult);  // Print the result
            // 1g. Method with out parameter
            void MethodWithOutParameter(out int outParam)  // Method with an out parameter
            {
                outParam = 42;  // Assign a value to the out parameter
                Console.WriteLine("Out parameter set to: " + outParam);  // Print the value of the out parameter
            }
            int outValue;  // Declare an integer variable to hold the out parameter value
            MethodWithOutParameter(out outValue);  // Calling the method with the out parameter
            Console.WriteLine("Value from out parameter: " + outValue);  // Print the value returned by the out parameter
            // 1h. Calling overloaded methods
            OverloadedMethod(10);  // Calling the overloaded method with an integer parameter
            OverloadedMethod("Hello");  // Calling the overloaded method with a string parameter

            // Create an instance of a class [Label1
            SampleClass sampleInstance = new SampleClass();  // Creating an instance of SampleClass
            // privateProperty1 = 100;  // Accessing private field from the class, this will cause an error if not within the class
            sampleInstance.publicProperty1 = 200;  // Accessing public property from the class
            SampleClass.staticProperty1 = 300;  // Accessing static property from the class, shared across all instances
            sampleInstance.instanceProperty1 = 400;  // Accessing instance property
        }
        // 1h. Overloaded methods, cannot perform overloading in one method
        static void OverloadedMethod(int number)  // Method with one integer parameter
        {
            Console.WriteLine("Overloaded method with int: " + number);  // Print the integer parameter
        }
        static void OverloadedMethod(string text)  // Overloaded method with one string parameter
        {
            Console.WriteLine("Overloaded method with string: " + text);  // Print the string parameter
        }

        // Class with properties and methods [Label1
        class SampleClass  // Class definition
        {
            // Properties with different access modifiers
            int privateProperty1;  // Private field with private access modifier
            private string privateProperty2;  // Private field with private access modifier
            public int publicProperty1; // Public property with public access modifier

            // Static properties and instance properties
            static public int staticProperty1;  // Static property, shared across all instances of the class
            public int instanceProperty1;  // Instance property, unique to each instance of the class

            // Constructor
            public SampleClass()  // Constructor, called when an instance of the class is created
            {
                privateProperty1 = 0;  // Initializing private property
                publicProperty1 = 0;  // Initializing public property
                staticProperty1 = 0;  // Initializing static property
                instanceProperty1 = 0;  // Initializing instance property
            }
        }
    }
}