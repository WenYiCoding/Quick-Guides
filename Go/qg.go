// Comment line
/*
Comment block
*/

package main // Used as "main" package

import (
	"fmt"
) // Import "fmt" package

func main() {
	// Declare variables
	var var1 string = "abc" // Type is explicitly declared
	var var2 = "def"        // Type is inferred
	var3 := "ghi"           // Type is inferred, this declare method only can be used inside function

	var var4 string // No type is declared
	var4 = "jkl"    //Now the variable is initialized with type

	// Decalre multiple variables
	var var5, var6 int = 5, -6 // Same type
	var var7, var8 = "7", 8    // Different types
	var9, var10 := "9", 10.0
	var ( // Declare in a block
		var11 int
		var12 = "12"
	)

	fmt.Println("Variables declared:\n", var5, var6, var7, var8, var9, var10, var11, var12) // All variables must be used for output

	fmt.Print("\n")

	// Constants
	const CONST1 string = "constant" // Should name it in FULL UPPERCASE to differentiate
	const CONST2 = 0                 // Should name it in FULL UPPERCASE to differentiate
	const (                          // Declare in block
		CONST3 int = 3
		CONST4     = -4
	)

	// Variable types
	var (
		intVar    int     = 20
		floatVar  float32 = 12.34
		stringVar string  = "string"
		boolVar   bool    = true
	)

	// Console print, using "fmt" package
	fmt.Print(var1, var2, var3)                           // No whitespace and newline added
	fmt.Println(var1, var2, var3)                         // Whitespace added between arguments and newline added at the end
	fmt.Printf("var4\nvalue: %v\ntype: %T\n", var4, var4) // Print with format, no newline

	fmt.Print("\n")

	// Print format
	// 1. General formatting verbs
	fmt.Printf("%v\n", var7) // Print value
	fmt.Printf("%v\n", var8)
	fmt.Printf("%#v\n", var7) // Print value in Go-syntax format
	fmt.Printf("%#v\n", var8)
	fmt.Printf("%v%%\n", var7) // Print with % sign
	fmt.Printf("%v%%\n", var8)
	fmt.Printf("%T\n", var7) // Print type of the value
	fmt.Printf("%T\n", var8)

	// 2. Integer formattting verbs
	fmt.Printf("%b\n", intVar)   // as binary, base2
	fmt.Printf("%d\n", intVar)   // as decimal, base10
	fmt.Printf("%+d\n", intVar)  // as decimal with sign(+/-)
	fmt.Printf("%o\n", intVar)   // as octal, base8
	fmt.Printf("%O\n", intVar)   // as octal with 0o
	fmt.Printf("%x\n", intVar)   // as lowercase haXadecimal, base 16
	fmt.Printf("%X\n", intVar)   // as uppercase haXadecimal
	fmt.Printf("%#x\n", intVar)  // haxadecimal with 0x
	fmt.Printf("%4d\n", intVar)  // pad with spaces, right justified
	fmt.Printf("%-4d\n", intVar) // pad with spaces, left justified
	fmt.Printf("%04d\n", intVar) // pad with zeroes

	fmt.Print("\n")

	// 3. Float formatting verbs
	fmt.Printf("%e\n", floatVar)    // as scientific notation, with exponent
	fmt.Printf("%f\n", floatVar)    // as decimal point, without exponent
	fmt.Printf("%.2f\n", floatVar)  // with precision
	fmt.Printf("%6.2f\n", floatVar) // pad with spaces, right justified
	fmt.Printf("%g\n", floatVar)    // exponent as needed

	fmt.Print("\n")

	// 4. String formatting verbs
	fmt.Printf("%s\n", stringVar)   // as plain string
	fmt.Printf("%q\n", stringVar)   // as double-quoted string
	fmt.Printf("%8s\n", stringVar)  // pad with spaces, right justified
	fmt.Printf("%-8s\n", stringVar) // pad with spaces, left justified
	fmt.Printf("%x\n", stringVar)   // as hex dump
	fmt.Printf("% x\n", stringVar)  // as hex dump, spaces between hex

	fmt.Print("\n")

	// 5. Boolean formatting verbs
	fmt.Printf("%t\n", boolVar) // Print value

	fmt.Print("\n")

	// Array
	var array1 = [3]string{"a", "b", "c"}   // Explicitly declare length
	var array2 = [...]string{"d", "e", "f"} // Inferredly declare length

	fmt.Println(array1[0]) // Access element
	array2[1] = "E"        // Change element

	fmt.Print("\n")

	var array3 = [5]string{"g", "h", "i"} // Fill empty elements with 0 or ""
	fmt.Println(array3, "\n")             // Print whole array, notice default value

	var array4 = [3]int{1: 8, 2: 4} // Initialize specific elements
	fmt.Println(array4, "\n")

	fmt.Printf("Lengths\narray1:%v\narray2:%v\narray3:%v\narray4:%v\n\n", len(array1), len(array2), len(array3), len(array4))

	// Slices, similar to array but dynamic size
	var slice1 = []int{}        // Declare empty slice
	var slice2 = []int{1, 2, 3} // Declare slice with initialization

	fmt.Println("slice1: ", slice1)
	fmt.Println("slice1 length: ", len(slice1))         // Show slice length
	fmt.Println("slice1 capacity: ", cap(slice1), "\n") // Show slice capacity

	fmt.Println("slice2: ", slice2)
	fmt.Println("slice2 length: ", len(slice2))
	fmt.Println("slice2 capacity: ", cap(slice2), "\n")

	var slice3 = array3[1:2] // Create slice from array, [fromIndex: beforeIndex]
	fmt.Println("slice3: ", slice3)
	fmt.Println("slice3 length: ", len(slice3))
	fmt.Println("slice3 capacity: ", cap(slice3), "\n")

	var slice4 = make([]string, 3, 6) // make([]type, length, capacity), capacity = length if not defined
	fmt.Println("slice4: ", slice4)
	fmt.Println("slice4 length: ", len(slice4))
	fmt.Println("slice4 capacity: ", cap(slice4), "\n")

	slice4[2] = "j"                     // change slice element
	slice4 = append(slice4, "k", "l")   // update slice by appending new elements
	slice5 := append(slice3, slice4...) // "..." is always needed
	fmt.Println("slice4: ", slice4)
	fmt.Println("slice5: ", slice5, "\n")

	slice5 = slice5[3:4] // reduce size by slicing
	fmt.Println("slice5: ", slice5)
	fmt.Println("slice5 length: ", len(slice5))
	fmt.Println("slice5 capacity: ", cap(slice5), "\n")

	slice5 = append(slice5, "m", "n") // adding size by appending
	fmt.Println("slice5: ", slice5)
	fmt.Println("slice5 length: ", len(slice5))
	fmt.Println("slice5 capacity: ", cap(slice5), "\n")

	slice6 := []string{"o", "p", "q"}
	copy(slice6, slice5[1:3]) // copy(dest, src), copy elements from "src" to "dest" until no elements
	// useful for using elements from large array/slice
	fmt.Println("slice6: ", slice6)
	fmt.Println("slice6 length: ", len(slice6))
	fmt.Println("slice6 capacity: ", cap(slice6), "\n")

	// Operators
	var num1 = 2
	num2 := 4
	var (
		num3 = 6
		num4 = 8
	)
	// 1. Arithmatic
	fmt.Println(num1 + num2)
	fmt.Println(num1 - num2)
	fmt.Println(num1 * num2)
	fmt.Println(num1 / num2)
	fmt.Println(num1 % num2)
	num1++
	fmt.Println(num1)
	num1--
	fmt.Println(num1, "\n")
	// 2. Comparison
	fmt.Println(num3 == num3)
	fmt.Println(num3 != num4)
	fmt.Println(num4 > num3)
	fmt.Println(num3 < num4)
	fmt.Println(num3 >= num3)
	fmt.Println(num3 <= num3, "\n")
	// 3. Logical
	fmt.Println(num3 == num3 && num3 == num3)
	fmt.Println(num3 == num4 || num3 == num3)
	fmt.Println(!(num3 == num3), "\n")
	// 4. Bitwise
	fmt.Println(num1 & num1)
	fmt.Println(num1 | num1)
	fmt.Println(num1 ^ num1)
	fmt.Println(num1 << 2)
	fmt.Println(num1>>2, "\n")
	// 5. Assignment
	num5 := 10
	num6 := 12
	num5 += num6
	fmt.Println(num5)
	num5 -= num6
	fmt.Println(num5)
	num5 *= num6
	fmt.Println(num5)
	num5 /= num6
	fmt.Println(num5)
	num5 %= num6
	fmt.Println(num5, "\n")
	num7 := 2
	num8 := 4
	num7 &= num8
	fmt.Println(num7)
	num7 |= num8
	fmt.Println(num7)
	num7 ^= num8
	fmt.Println(num7)
	num7 >>= 2
	fmt.Println(num7)
	num7 <<= 2
	fmt.Println(num7, "\n")

	// Conditional statement
	stringVar2 := "B"
	if stringVar2 == "A" {
		fmt.Println("stringVar2 is A")
	} else if stringVar2 == "B" {
		fmt.Println("stringVar2 is B")
	} else {
		fmt.Println("stringVar2 is something else")
	}

	fmt.Println()

	switch stringVar2 {
	case "A":
		fmt.Println("stringVar2 is A")
	case "B":
		fmt.Println("stringVar2 is B")
	case "C":
		fmt.Println("stringVar2 is C")
	case "D", "E", "F":
		fmt.Println("stringVar2 is D, E, or F")
	default:
		fmt.Println("stringVar2 is something else")
	}

	fmt.Println()

	// Loops
	var i = 0
	for i < 10 { // golang does not have while loop, this is the substitude
		fmt.Println("Golang doesnt have while loop")
		i++
	}

	fmt.Println()

	for i := 0; i <= 10; i++ { // for loop
		if i == 4 {
			fmt.Println()
			continue
		} else if i == 10 {
			break
		} else {
			fmt.Printf("loop no.%v\n", i)
		}
	}

	fmt.Println()

	array5 := []int{2, 4, 6, 8, 10}
	for idx, val := range array5 { // iterate elements [for index, value := range array/slice/map]
		fmt.Printf("%v |\t%v\n", idx, val)
	}

	fmt.Println()

	for _, val := range array5 { // "_" will be omited
		fmt.Println(val)
	}

	// Call functions [ref1]
	func1()
	func2("text", 0) // put arguments
	var (            // store return values
		resultFunc3                = func3(1, 2)
		resultFunc4                = func4()
		resultFunc5a, resultFunc5b = func5()
	)
	fmt.Println()
	fmt.Printf("Results\nresultFunc3: %v\nresultFunc4: %v\nresultFunc5: %v, %v\n\n", resultFunc3, resultFunc4, resultFunc5a, resultFunc5b)

	// Structures, object-like
	type structType1 struct { // Declare a structure
		member1 string
		member2 int
		member3 bool
	}
	var structVar1 structType1 // use default value if no initialization
	fmt.Println(structVar1)
	structVar1.member1 = "Member1" // access struct members
	fmt.Println(structVar1.member1, "\n")

	// Maps, key-value pairs
	var mapVar1 = map[string]int{"First": 20, "Second": 40} // init map with string:int pair
	var mapVar2 = map[int]string{0: "Car", 1: "Van"}        // init map with int:string pair
	var mapVar3 = make(map[int]bool)                        // make empty int:bool map variable without init
	var mapVar4 map[int]int                                 // create empty int:int, not encourage as can cause panic/error
	fmt.Println("Map variables:")
	fmt.Println(mapVar1)
	fmt.Println(mapVar2)
	fmt.Println(mapVar3)
	fmt.Println(mapVar4, "\n")

	fmt.Print("mapVar1[\"First\"]: ")
	fmt.Println(mapVar1["First"]) // access map elements
	fmt.Print("mapVar2[0]: ")
	fmt.Println(mapVar2[0], "\n")

	fmt.Print("mapVar1[\"A\"]: ")
	fmt.Println(mapVar1["A"]) // default value will given if not found
	fmt.Print("mapVar2[100]: ")
	fmt.Println(mapVar2[100], "\n")

	mapVar1["Third"] = 60 // change map element, add if not found
	fmt.Print("mapVar1[\"Third\"]: ")
	fmt.Println(mapVar1["Third"], "\n")

	delete(mapVar1, "Third") // remove map element
	fmt.Print("mapVar1[\"Third\"]: ")
	fmt.Println(mapVar1["Third"], "\n")

	mapVar1Third, mapVar1ThirdExist := mapVar1["Third"] // first var holds value, second var hold bool for existance
	fmt.Println("mapVar1[\"Third\"]:", mapVar1Third, "| If exist:", mapVar1ThirdExist, "\n")

	_, mapVar1FourthExist := mapVar1["Fourth"] // "_" will be omited
	fmt.Println("If mapVar1[\"Fourth\"] exist:", mapVar1FourthExist, "\n")

	var mapVar5 = mapVar1 // maps are references
	fmt.Println("Before")
	fmt.Println("mapVar1:", mapVar1)
	fmt.Println("mapVar5:", mapVar5)
	mapVar1["Third"] = 100 // they share same hash table, they will change together
	fmt.Println("After")
	fmt.Println("mapVar1:", mapVar1)
	fmt.Println("mapVar5:", mapVar5, "\n")

	fmt.Println("Iterate mapVar1: ", mapVar1) // map can be iterated over, but not always in order
	for key, val := range mapVar1 {
		fmt.Printf("%v: %v\n", key, val)
	}

	fmt.Println()

	var mapVar1Order []string
	mapVar1Order = append(mapVar1Order, "Third", "Second", "First") // define an array of keys for order
	fmt.Println("Iterate mapVar1: ", mapVar1)
	for _, mapVar1Idx := range mapVar1Order {
		fmt.Printf("%v: %v\n", mapVar1Idx, mapVar1[mapVar1Idx])
	}

}

// Create functions [ref1]
func func1() {
	fmt.Println("func1")
}
func func2(input1 string, input2 int) { // with multiple parameters
	fmt.Println("func2:", input1, input2)
}
func func3(input1 int, input2 int) int { // with single return value
	return input1 + input2
}
func func4() (result string) { // with named return value
	result = "function 4 have a named return value"
	return
}
func func5() (string, string) { // with multiple return values, can be named as well
	return "multiple", "results"
}

// https://www.w3schools.com/go/go_maps.php
