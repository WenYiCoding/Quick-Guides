# Comment

'''Comment 
Block'''

"""Comment 
Block"""

# Console print
print("Hello World!")

# Declare variables
strVar = "Hello World"
intVar = 10
floatVar = 10.5
complexVar = 1j
listVar = ["apple", "banana", "cherry"]
tupleVar = ("apple", "banana", "cherry")
rangeVar = range(10)
dictVar = {"name" : "John", "age" : 10}
setVar = {"apple", "banana", "cherry"}
frozensetVar = frozenset({"apple", "banana", "cherry"})	
boolVar = True
bitVar = 0b101
bytesVar = b"Hello"
bytearrayVar = bytearray(10)
memoryviewVar = memoryview(bytes(10))
NoneTypeVar = None

type(NoneTypeVar) ##Return data type

# User input
inputVar = input("Input: ") ##Argument will be printed, return inputs before Return/Enter key

# String manipulation/methods
var1, var2, var3 = "A", "B", "Abc aBC abc ABC" ##Assign multiple variables in line
# 0. Escape characters
escQuote = "\'"     ##Single Quote
escBackslash = "\\"	##Backslash
escNewLine = "\n"	##New Line
escReturn = "\r"	##Carriage Return
escTab = "\t"       ##Tab
escBackspace = "\b"	##Backspace
escFormFeed = "\f"	##Form Feed, old printers will eject page
escOct = "\101\102\103"	##Octal value, base-8
escHex = "\x41\x42\x43"	##Hex value, base-16
# 1. String concatenation/combination
strConcat = var1 + var2
strJoin = " ".join([var1, var2])
strComma = (var1, var2)
# 2. String formatting
strModulo = ("% s % s" % (var1, var2))
strFormat = "{} {}".format(var1, var2)
strFstring = f"{var1} {var2}"
# 3. Upper/lower case change
strUpper = var3.upper()
strLower = var3.lower()
strTitle = var3.title()
# 4. Find and replace
strFind = var3.find("a")    ##Return index of the 1st found
strIndex = var3.index("a")  ##Return index of the 1st found
strReplace = var3.replace("ABC","123") ##Find match and replace
strSlicing = var3[8:11]     ##Slice from start index to before end index
# 5. String check
strIsalnum = var3.isalnum()	##If all alphanumeric
strIsalpha = var3.isalpha()	##If all in the alphabet
strIsdigit = var3.isdigit()	##If all digits
strIsupper = var3.isupper()	##If all upper case
strIslower = var3.islower()	##If all lower case

# Operators
var1, var2 = 5, 10
var3, var4 = 0b0101, 0b0011
lst1 = [1, 2, 3, 4, 5, 6]
# 1. Arithmetic operators
numAdd = var1 + var2	##Addition
numSub = var1 - var2	##Subtraction
numMul = var1 * var2	##Multiplication
numPwr = var1 ** var2	##Exponentiation
numDiv = var1 / var2	##Division
numFlr = var1 // var2	##Floor division
numMod = var1 % var2	##Modulus
# 2. Bitwise operators
bitAND = var3 & var4
bitOR = var3 | var4
bitXOR = var3 ^ var4
bitNOT = ~var3
bitLeftShift = var3 << 1	##Pushing zeros from the right to left
bitRightShift = var3 >> 1	##Pushing bits from left to right
# 3. Assignment operators
print("numAssgn1 := var1", numAssgn1 := var1) ##Walrus/Assignment expression operator, assign whithin statement
numAssgn1 = var2
numAssgn1 += var2
numAssgn1 -= var2
numAssgn1 *= var2
numAssgn1 /= var2
numAssgn1 %= var2
numAssgn1 //= var2
numAssgn1 **= var2
numAssgn2 = var3
numAssgn2 &= var4
numAssgn2 |= var4
numAssgn2 ^= var4
numAssgn2 >>= var4
numAssgn2 <<= var4
# 4. Comparison operators
compEqual = (var1 == var2)  	##Equal
compNotEqual = (var1 != var2)	##Not equal
compGreater = (var1 > var2) 	##Greater than
compLess = (var1 < var2)    	##Less than
compGreatEqual = (var1 >= var2)	##Greater than or equal to
compLessEqual = (var1 <= var2)	##Less than or equal to
# 5. Logical operators
logicAnd = (var1 > var2) and (var1 < var2)
logicOr = (var1 > var2) or (var1 < var2)
logicNot = not(var1 > var2)
# 6. Identity operators
idenSame = (var1 is var2)       	##If both the same object
idenNotSame = (var1 is not var2)	##If both not the same object
# 7. Membership operators
memberIn = (var1 in lst1)       	##If a sequence with the specified value is present in the object	x in y	
memberNotIn = (var1 not in lst1)	##If a sequence with the specified value is not present in the object

# List, Python heterogenous data collections/array, ordered, changeable, and allow duplicate values
# 1. Declare list
lst1 = [1,2,3,4,5]
lst2 = list([16,17,18,19,10]) ##Constructor, arguments must be iterables
# 2. Access list items
item = lst1[0]
item = lst1[-0]     ##From right
item = lst1[1:4]    ##Slice from start index to before end index
# 3. Check if contain item
check = (1 in lst1)
# 4. Change item value
lst1[4] = 15
lst1[1:4] = [11,12,13,14] ##Find and change the slice, can add/remove values
# 5. Insert value
lst1.append(16)
lst1.insert(1, 10)  ##Insert value before index
# 6. Remove value
lst1.remove(10)     ##Remove first found value
lst1.pop(-0)        ##Remove value of index, pop last item if no args
del lst1[0]         ##Identical to pop
lst2.clear()        ##Clear all items, leave empty list
del lst2            ##Remove whole list
# 7. Loop through list
for item in lst1:           ##Strag1: iterate all items
    pass
for i in range(len(lst1)):  ##Strag2: range from 0 to list length
    pass
i = 0                       ##Strag3: while loop with numeric comparison
while i <= len(lst1):
    i = i + 1
# 8. List comprehension, similar to strag1 but simpler
lst2 = [item for item in lst1 if (item > 13)] ##Format: {expression} for {loopItem} in {iterable} if {filter condition}
# 9. Sort
lst1.sort()                 ##Rearrange alphanumerically
lst1.sort(reverse = True)
lst1.sort(key = int.bit_length) ##Sort with custom key function
lst1.reverse()
# 10. Shallow copy list
lst1 = [1, 2, 3]
lst2 = lst1         ##This is not copy but reference to, original list change = refer list change
lst2 = lst1.copy()  ##Copy and assign
lst2 = list(lst1)   ##List constructor
lst2 = lst1[:]      ##List slicing
# 11. Deep copy list
lst1 = [1, 2, [21, 22, 23], 3] ##As shallow-copied list have same object as original, original inner list change = copied inner list change 
import copy
lst2 = copy.deepcopy(lst1) ##Copied list is new by itself
# 12. Join lists
lst1 = [1, 2, 3]
lst2 = [4, 5, 6]
lst1.extend(lst2)       ##Append another iterables
lst1 = lst1 + lst2

# Enumerate, convert iterables items to object by adding index to each item
lst1 = ["A", "B", "C", "D"]
enumVar = enumerate(lst1)
for index, item in lst1:    ##Good for {for} loop
    pass

# Tuple, Python heterogenous data collections/array, ordered, unchangeable and allow duplicate values
tpl1 = (1, 2, 3)        ##Declare and create tuple, then pack values
tpl1 = tuple((1, 2, 3)) ##Constructor, other iterables will be converted
tpl2 = (4,)             ##Create with 1 item, comma is needed
tplAccess = tpl1[0]     ##Access
tplSlice = tpl1[1:2]    ##Slice
tplLength = len(tpl1)   ##Find length
for item in tpl1:       ##Iterate all items
    pass
# 1. Change item value by converting it to list, change value then convert back
temp = list(tpl2)
temp[0] = 5
tpl2 = tuple(temp)
# 2. Join/append tuples
tpl1 += tpl2
# 3. Unpack values
var1, var2, var3, var4 = tpl1   ##Must unpack all by matching variable count and value count
var1, var2, *varRest = tpl1     ##Add asterisk to cramp remainding values
var1, *varRest, var3 = tpl1     ##Add asterisk to cramp middle values

# Set, Python heterogenous data collections/array, unordered, unchangeable* and doesnt allow duplicate
set1 = {1, 2, 3, 1}         ##Duplicate will be ignored
set1 = set({1, 2, 3, 1})    
set2 = {True, False, 0, 1}  ##True and 1 is same, False and 0 is same
setLength = len(set1)       ##Find length
# 1. Access item in unordered collection
for item in set1:           ##Only through iteration
    pass
# 2. Add item altough unchangable*
set1.add(4)
# 3. Join other sets
setUnion = set1.union(set2)     ##Create new set by union multiple iterables
setUnion = set1 | set2          ##Same as union, only applied to sets
set1.update(set2)               ##Update by adding other iterable items, same as {|=}
setIntersect = set1.intersection(set2)  ##Create new set, intersect same other iterables item
setIntersect = set1 & set2      ##Same as intersection, only for sets
set1.intersection_update(set2)  ##Update original set by doing itersection, same as {&=}
setDiff = set1.difference(set2) ##Create new set, keep items not present in other iterables
setDiff = set1 - set2           ##Same as difference, only for sets
set1.difference_update(set2)    ##Update original set by doing difference, same as {-=}
setSymDiff = set1.symmetric_difference(set2)    ##Create new set, keep items not in both iterables
setSymDiff = set1 ^ set2        ##Same as symmetric difference, only for sets
set1.symmetric_difference_update(set2)          ##Update by doing symmetric difference, same as {^=}
# 4. Check set
set1.isdisjoint(set2)   ##If original set doesnt hv same item as target set
set1.issubset(set2)     ##If all original set items contained in target set, same as {<=}{<}
set1.issuperset(set2)   ##If all target set items contained in original set, same as {>=}{>}
# 5. Remove item altough unchangable*
set1.remove(1)      ##Find and remove the item, raise error if not found
set1.discard(4)     ##Find and discard item, ignore if not found
set1.pop()          ##Pop out random item
set1.clear()        ##Empties the set
del set1            ##Delete the set completely

# Dictionary, Python key:value-pairs collections, ordered, changeable and do not allow duplicates
dict1 = {
    "key1": 1,
    2: "value2",
    "key3": "same",
    "key3": "same1" ##This value will replace value of last key
}
dict1 = dict(key1 = 1, key2 = "value2", key3 = "same")
dictLength = len(dict1) ##Get length
# 1. Access items
dict1["key1"]   ##Get value for target key
dict1.get("key1")
dict1.keys()    ##List all keys
# 2. Change/Add items
dict1["key1"] = 10 ##Find and change value, add new pair if not found
dict1.update({"key1": 1}) ##Update multiple keys, add new pairs if not found
# 3. Remove items
dict1.pop("key3")   ##Pop target key
dict1.popitem()     ##Pop last item
del dict1["key1"]   ##Delete target key
dict1.clear()       ##Clear dictionary
del dict1           ##Delete dictionary

# Conditions
condition1, condition2 = True, True
if condition1:
    pass
elif condition2:
    pass
else:
    pass

# Loops
# 1. While loop
while condition1:
    break
# 2. For loop
iterable = []
for item in iterable:
    continue
else:
    pass    ##Not execute if loop is break

# Functions
argument = 0
arbitraryArguments = []
keyWordArguments = {"key1": 1, "key2": 2, "key3": 3}
def function(parameter, default = 0, *args, **kwargs):
    return parameter, default, args, kwargs
function(argument, arbitraryArguments, keyWordArguments)

def positionsOnly(arg, /):   ##This will reject keyword arguments
    pass

def keywordsOnly(*, kwarg):   ##This will reject positional arguments
    pass

def specifiedArg(arg, /, *, kwarg):   ##Param before {/} is positional-only, after {*} is keywords-only
    pass

def recursion(n):   ##Elegent and effective than interation(while, for loop)
    if (n == 1):
        return 0
    else:
        n -= 1
        recursion(n)
recursion(3)

# Class
# 1. Basics
class varClass:     ##This line declare class
    classVar1 = 0   ##This line declare class variable
    def __init__(self, arg):    ##This declaration initiate object properties when created
        self.objProp1 = arg
    def __str__(self):          ##Return this if object is converted to/printed as string
        return f"String: {self.objProp1}"
    def __repr__(self):         ##Return if whole object is printed
        return f"Representation: {self.objProp1}"
    def function1(self):        ##Decalre object methods, 1st param is always needed as refer to current instance
        pass
object1 = varClass(10)          ##This line create object
object1.function1()             ##This line call object function
object1.objProp1 = 200          ##Change object properties
del object1.objProp1            ##Delete object properties
del object1                     ##Delete object entirely
# 2. Inheritance
class parent1:
    def __init__(self, prntProp2):
        self.prntProp1 = 10
        self.prntProp2 = prntProp2
    def __str__(self):
        return f"self.prntProp1 {self.prntProp1} self.prntProp2 {self.prntProp2}"
    def prntFunction1():
        pass
class child1(parent1):
    def __init__(self, prntProp2, chldProp2):   ##Will override parent __init__
        parent1.__init__(self, prntProp2)       ##Call parent __init__ to inherit its properties
        super().__init__(prntProp2)             ##Same as last line but simpler
        self.chldProp1 = 100
        self.chldProp2 = chldProp2
    def chldFunction1():
        pass
    def prntFunction1():    ##Will override function with same name from parent
        pass
# 3. Polymorphism, different class with same method name yet different expressions
class class1:
    def function(self):
        return 10
class class2:
    def function(self):
        return 20
class class3:
    def function(self):
        return 30

object1, object2, object3 = class1(), class2(), class3()
print(f"object1.function() {object1.function()}")
print(f"object2.function() {object2.function()}")
print(f"object3.function() {object3.function()}")

# Scopes
# 1. Local scope
def function1():
    func1Var = 10
    print(f"func1Var {func1Var}")
#print(func1Var) ##Compile error as the argument is not declared globally
# 2. Global scope
globalVar1 = 100
globalVar3 = 300
def function2():
    globalVar1 = 10     ##This variable is manipulated as local scope
    print(f"function2() -> globalVar1 {globalVar1}")   
    global globalVar2   ##This variable will created as global
    globalVar2 = 200
    global globalVar3   ##This will convert variable from local to global
    globalVar3 = 30
function2()
print(f"globalVar1 {globalVar1}")       ##This variable is not manipulated as global
print(f"globalVar2 {globalVar2}")       ##This variable is global after function called
print(f"globalVar3 {globalVar3}")       ##This variable is manipulated as global
# 3. Non local scope, similar to global but for nested scopes
def function3():
    func3Var1 = 3000
    func3Var2 = 6000
    print(f"function3 -> func3Var1 {func3Var1}")
    def function3a():
        func3Var1 = 310                           ##This manipulate variable as inner local
        nonlocal func3Var2                        ##This convert variable as outer local
        func3Var2 = 320                           ##This manipulate variable as outer local
        print(f"function3a -> func3Var1 {func3Var1}")
        print(f"function3a -> func3Var1 {func3Var2}")
    function3a()
    print(f"function3 -> func3Var1 {func3Var1}")  ##This not manipulate variable as outer local
    print(f"function3 -> func3Var2 {func3Var2}")
function3()

# Modules, every .py file is considered module
import platform
import platform as pltfm    ##Give import a alias
from platform import system ##Selective import, can import individual function or global variable
importFunc = platform.system()
importFunc = pltfm.system()
importFunc = system()
importList = dir(pltfm)     ##List all functions and global variables of that module
print(f"importFunc {importFunc}")
print(f"importList {importList}")

# Exception handling, prevent unexpected errors
try:
    #print(missing)
    print("missing")
except NameError:   ##Capture and execute if this error found
    print("NameError captured")
except:             ##Capture and execute if unstated error is found
    print("Other errors is captured")
else:               ##Execute if no error is found
    print("Everything is okay")
finally:
    print("This block always executed")

try:
    raise Exception("Exception raised") ##Argument will printed if exception occured
except:
    print("Raised exception captured")

# Check execution
if __name__ == "__main__":
    pass