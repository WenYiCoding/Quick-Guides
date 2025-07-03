<?php declare(strict_types=1);    // set PHP to become type-strict, must be first PHP statement
# PHP single line comment
// PHP single line comment
/* PHP multiline
comment*/

// Echo to print output into console
echo "Hello World\n";
echo phpversion(), "\n";
echo "\n";

// Declaring variables, PHP is loosely typed, no need type declaration
$var1 = "String";   // string
$var2 = 10;         // int
$var3 = 12.34;      // float
$var4 = true;       // bool
$var5 = null;       // NULL

echo "\$var1: ", $var1, "\n";
echo "\$var2: ", $var2, "\n";
echo "\$var3: ", $var3, "\n";
echo "\$var4: ", $var4, "\n";
echo "\$var5: ", $var5, "\n";
echo "\n";

// Return the type of variables
var_dump($var1);
var_dump($var2);
var_dump($var3);
var_dump($var4);
var_dump($var5);
echo "\n";

// Assign same value on multiple variables
$var6 = $var7 = "Same";
echo "\$var6: ", $var6, "\n";
echo "> ";
var_dump($var6);
echo "\$var7: ", $var7, "\n";
echo "> ";
var_dump($var7);
echo "\n";

// Console echo
echo "Echo without parenthesis\n";
echo("Echo with parenthesis\n");
echo "\n";

// Console print vs echo
$printVar = print "Print returns status code '1'\n";
echo "\$printVar: ", $printVar, "\n";
echo "Echo doesnt return\n";
echo "\n";

// Echo/print often used to output HTML
echo "<h1>This is PHP echo output<h1>";
echo "\n\n";

// Variable in string
$var8 = "simple";
$var9 = "This is $var8";  // Double-quote string will process special characters, can directly insert variable
echo "\$var8: ", $var8, "\n";
echo "\$var9: ", $var9, "\n";
echo "\n";

$var10 = "complex";
$var11 = 'This is '. $var10;  // Single-quote string is literal, need concatenation to insert variable 
echo "\$var10: ", $var10, "\n";
echo "\$var11: ", $var11, "\n";
echo "\n";

// String count
echo 'strlen("123456789") = '. strlen("123456789"), "\n";   // strlen() return string length
echo 'str_word_count("Two words") = '. str_word_count("Two words"), "\n";   // str_word_count() return word count
echo "\n";

// String search
$var12 = "tryFind waldoInthis weirdstring";
echo 'strpos($var12, "waldo") = ', strpos($var12, "waldo"), "\n";   // strpos() find needle (arg2) in haystack (arg1), return 1st char index
echo "\n";

$ifWaldoFound = strpos($var12, "Waldo");
echo 'strpos($var12, "Waldo") = ', $ifWaldoFound, "\n";
echo "\$ifWaldoFound: ", $ifWaldoFound, "\n";
echo "> ";
var_dump($ifWaldoFound);   // return False if not found
echo "\n";

// String manipulation
$oriStr = " Original String !! ";
echo $oriStr, "\n";
echo strtoupper($oriStr), "\n"; // to UPPERCASE
echo strtolower($oriStr), "\n"; // to lowercase
echo str_replace("Original","Replaced",$oriStr), "\n"; // replace substring
echo strrev($oriStr), "\n"; // reverse string
echo trim($oriStr), "\n"; // trim whitespaces
$bitsStr = explode(" ",$oriStr);  // explode string into array
echo "\n";

// String concatenation
$strVar1 = "Happy" . "Birthday";
echo $strVar1, "\n";   // using dot
echo "\n";

// String slicing
echo substr($oriStr, 10, 6), "\n";  // slice (arg1) from index (arg2, not inclusive) to (arg3) characters 
echo substr($oriStr, 10), "\n";  // empty (arg3) means to infinite
echo substr($oriStr, -10, 6), "\n";  // negative (arg2) means slicing from end
echo substr($oriStr, 10, -4), "\n";  // slice to end index (arg3)
echo "\n";

// Escape special characters
echo "\\\" = \"Double quotes\"", "\n";
echo '\\\' = \'Single quotes\'', "\n";
echo "\\\$ = \$ PHP variable", "\n";
echo "\\n = \n new line", "\n";
echo "\\t = \t tab", "\n";
echo "\\ooo = \200 octal value", "\n";
echo "\\xhh = \x11 hex value", "\n";
echo "\n";

// Numbers
$intVar = 12;
$floatVar = 1.234;
$infVar = 1.5e600;  // shown as INF if value is too large
$nanVar = acos(20); // shown as NAN if value is invalid operation
echo "\$intVar: ", $intVar, "\n";
echo "> ";
var_dump($intVar);
echo "\$infVar: ", $infVar, "\n";
echo "> ";
var_dump($infVar);
echo "\$floatVar: ", $floatVar, "\n";
echo "> ";
var_dump($floatVar);
echo "\$nanVar: ", $nanVar, "\n";
echo "> ";
var_dump($nanVar);
echo "\n";

// Check if variable is number/numeric
$numVar1 = 10;
$numVar2 = 20;
$numVar3 = "30";
$numVar4 = "30OO";
var_dump(is_numeric($numVar1));
var_dump(is_numeric($numVar2));
var_dump(is_numeric($numVar3));
var_dump(is_numeric($numVar4));
echo "\n";

// Type casting, cast by putting bracket with a target type in front of the variable
$oriVar = 1;
var_dump((string) $oriVar);
var_dump((int) $oriVar);
var_dump((float) $oriVar);
var_dump((bool) $oriVar);
echo "\n";

// PHP contains mathematic functions
echo pi(), "\n";
echo min(0, 150, 30, 20, -8, -200), "\n";
echo max(0, 150, 30, 20, -8, -200), "\n";
echo abs(-6.7), "\n";
echo sqrt(64), "\n";
echo round(0.60), "\n";
echo round(0.49), "\n";
echo rand(), "\n";
echo rand(10, 100), "\n";    // random between (arg1) and (arg2), both inclusive
echo "\n";

// Declare constants
const CONST_INT1 = 100; // cannot create inside block scope
define("CONST_INT2", 200);  // always global
echo CONST_INT1, "\n";
echo CONST_INT2, "\n";
echo "\n";

// Operators
// 1. arithmatic
echo $numVar1 + $numVar2, "\n";
echo $numVar1 - $numVar2, "\n";
echo $numVar1 * $numVar2, "\n";
echo $numVar1 / $numVar2, "\n";
echo $numVar1 % $numVar2, "\n";
echo $numVar1 ** $numVar2, "\n";
echo "\n";
// 2. increments
echo ++$numVar1, "\n";
echo $numVar1++, "\n";
echo --$numVar1, "\n";
echo $numVar1--, "\n";
echo "\n";
// 3. assignment
$oriVar = $numVar1;
echo $oriVar, "\n";
$oriVar += $numVar1;
echo $oriVar, "\n";
$oriVar -= $numVar1;
echo $oriVar, "\n";
$oriVar *= $numVar1;
echo $oriVar, "\n";
$oriVar /= $numVar1;
echo $oriVar, "\n";
$oriVar %= $numVar1;
echo $oriVar, "\n";
$oriVar .= $numVar1;
echo $oriVar, "\n";
echo "\n";
// 4. comparison
var_dump($numVar1 == $numVar2);
var_dump($numVar1 === $numVar2);
var_dump($numVar1 != $numVar2);
var_dump($numVar1 <> $numVar2);  // same as !=
var_dump($numVar1 > $numVar2);
var_dump($numVar1 >= $numVar2);
var_dump($numVar1 < $numVar2);
var_dump($numVar1 <= $numVar2);
var_dump($numVar1 <=> $numVar2); // spaceship, -1 = less then, 0 = equal, 1 = greater than
echo "\n";
// 5. logical
$true = true;
$false = false;
var_dump($true and $true);
var_dump($true && $true);
var_dump($true or $false);
var_dump($true || $false);
var_dump($true xor $false);
var_dump(!$true);
echo "\n";
// 6. conditional assignment
$result1 = $true ? "true" : "false"; // varName = statement ? value if true : value if false;
echo $result1, "\n";
$result2 = "not NULL" ?? "NULL"; // varName = value ?? if value is null;
echo $result2, "\n";
echo "\n";

// Arrays
$arrVar1 = array(1, 2, 3);  // declare array, this is indexed array
$arrVar2 = ["A", "B", "C",];    // shorthand way to declare
$arrVar3 = ["One"=>1, "Two"=>2, "Three"=>"3",]; // associative array, key-value pair
$arrVar4 = [0=>"1", 1=>"2", 2=>"3",];   // array works like this actualy
$arrVar4 = [true=>"1", "1"=>"2", 2=>"3", "Four"=>null, null=>6, 400];   // all key and value can be different data types, unnamed key will be default to index
var_dump($arrVar1); // proper way to output whole array
var_dump($arrVar2);
var_dump($arrVar3);
var_dump($arrVar4);
echo "\n";
echo '$arrVar1[0] = ', $arrVar1[0], "\n"; // access element in index array
echo '$arrVar4[true] = ', $arrVar4[true], "\n"; // access element in associative array
echo '$arrVar4[1] = ', $arrVar4[1], "\n"; // if the key is numeric, it can be called in integer or string
echo '$arrVar4["2"] = ', $arrVar4["2"], "\n";
echo '$arrVar4["Four"] = ', $arrVar4["Four"], "\n";
echo '$arrVar4[\'Four\'] = ', $arrVar4['Four'], "\n";   // key can be called using single or double quote
echo '$arrVar4[null] = ', $arrVar4[null], "\n";
echo "\n";
$arrVar4[null] = 500;    // update element value
$arrVar4[10] = 5;    // add new if not exist
array_push($arrVar4, "600", "700");    // push new element at the array end, notice its index is behind previous largest
$arrVar4[] = 800;    // shorthand way to push
$arrVar4 += [900, "thousand"=>1000];    // append new array
var_dump($arrVar4);
echo "\n";
array_splice($arrVar1,1,1); // remove (arg3) elements starting index (arg2) in array (arg1), indexed array will reindex
var_dump($arrVar1);
array_splice($arrVar4,1,1); // number-key treated as index and will reindex
var_dump($arrVar4);
unset($arrVar2[1]); // unset will remove element without reindex
var_dump($arrVar2);
$arrVar2 = array_diff($arrVar2, ["C"]); // array_diff() to return the difference between arrays but use it to remove elements
var_dump($arrVar2);
array_pop($arrVar4);    // pop last element
array_shift($arrVar4);  // remove first element
var_dump($arrVar4);
echo "\n";
sort($arrVar1); // sort in ascending order
var_dump($arrVar1);
rsort($arrVar1); // sort in decensing order
var_dump($arrVar1);
asort($arrVar4); // sort in ascending order, based on value
var_dump($arrVar4);
arsort($arrVar4); // sort in ascending order, based on value
var_dump($arrVar4);
ksort($arrVar4); // sort in ascending order, based on value
var_dump($arrVar4);
krsort($arrVar4); // sort in ascending order, based on value
var_dump($arrVar4);
echo "\n";

// Conditional Statements
// 1. if-elseif-else
if ($true) {
    echo "This is true \n";
}
elseif ($false) {
    echo "This is false \n";
}
else {
    echo "This is error \n";
}
echo "\n";
// 2. shorthand if
if ($true) echo "This is true \n";
echo "\n";
// 3. ternary operators
$result1 = $true ? "true" : "false";
echo $result1, "\n";
echo "\n";
// 4. switch
switch ($numVar1 <=> $numVar2) {
    case -1:
        echo "\$numVar1 < \$numVar2 \n";
        break;
    case 0:
    case 1:
        echo "\$numVar1 >= \$numVar2 \n";
        break;
    default:
        echo "This is error \n";
        break;
}
echo "\n";

// Loops
// 1. while
$i = 0;
while ($i < 5) {
    echo "\$i = $i\n";
    $i++;
}
echo "\n";
// 2. do-while
$i = 0;
do {
    echo "\$i = $i\n";
    $i++;
} while ($i < 5);
echo "\n";
// 3. for
for ($i = 0; $i < 5; $i++) {
    if ($i == 2) {
        continue;   // skips the current iteration
    }
    echo "\$i = $i\n";
    if ($i == 4) {
        break;  // break out the loop
    }
}
echo "\n";
// 4. foreach, loop through arrays
foreach ($arrVar1 as $x) {  // loop through indexed arr
    echo '$x = ', "$x", "\n";
}
echo "\n";
foreach ($arrVar4 as $k => $v) {    // loop through associative arr
    echo "$k => $v", "\n";
}
echo "\n";
foreach ($arrVar1 as &$x) {  // set reference variable to refer the originals, easy to update value in foreach
    $x = 1;
}
var_dump($arrVar1);
echo "\n";

// Functions
function funcVar1() {    // declare a function
    echo "funcVar1() called", "\n";
    echo "\n";
}
funcVar1();  // call a function

function funcVar2($param1, $param2) {   // with multiple arguments
    echo "funcVar2() called with param [$param1, $param2]", "\n";
    echo "\n";
}
funcVar2(1, "2");

function funcVar3($param1 = 50) {   // default argument value
    echo "funcVar3() called with param [$param1]", "\n";
    echo "\n";
}
funcVar3();
funcVar3(1);

function funcVar4() {   // with return value
    echo "funcVar4() returns this", "\n";
    echo "\n";
    return "Hi";
}
echo 'funcVar4() = ', funcVar4(), "\n";
echo "\n";

function funcVar5(&$refer) {   // argument by reference
    $refer *= 100;
}
$numVar1 = 10;
echo '$numVar1 = ', $numVar1, "\n";
funcVar5($numVar1);
echo '$numVar1 = ', $numVar1, "\n";
echo "\n";

function funcVar6($param1, ...$params) {   // with variadic arguments (only as last arg), making it variadic function
    echo '$param1 = ', $param1, "\n";
    foreach ($params as $x => $y) {
        echo "$x => $y", "\n";
    }
    echo "\n";
}
funcVar6(1, 2, "3", true, null);

function funcVar7(int $param1) : int {   // with strict_type on, PHP can explicitly typed
    return $param1 + "2";
}
echo 'funcVar7() = ', funcVar7(1), "\n";
echo "\n";

//https://www.w3schools.com/php/php_magic_constants.asp
?>