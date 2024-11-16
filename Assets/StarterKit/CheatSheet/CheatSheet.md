
# Welcome!

This is Roxy's Cheatsheet for developing games in Unity! It has notes, syntax, and guides for a lot of things in the 
engine! I wrote this with beginners in mind, but there are still advanced sections for more experienced developers. 
If you see a section and have no idea whats going on, thats ok! All the necessary sections are accessible and easy. 
All the content in this document is layed out in the table of contents below. Click on any section to jump to it. 
Section headers may be followed with a 📓. Clicking 📓 will take you to any relevant documentation. Let me know if there is anything left out that you would like me to include! Take a 
deep breath, relax, and have fun creating! 💗

# Table of Contents
1. [🎓 Reference (Documentation & Tutorials)](#-reference)
2. [🎼 C# Syntax](#-c-syntax)
    1. [Types](#types)
    2. [Fields](#fields)
    3. [Properties](#properties)
    4. [Functions](#functions)
    5. [Classes & Structs](#classes--structs)
    6. [Interfaces](#interfaces)
    7. [Collections](#collections)
    8. [Delegates](#delegates)
    9. [Generics](#generics)
    10. [Misc](#misc)
3. [🖼️ Scenes](#-scenes)
4. [🦴 GameObjects](#-gameobjects)
5. [🫙 MonoBehaviors](#-monobehaviours)
6. [🚋 Transforms](#-transforms)
7. [📦️ Prefabs](#-prefabs)
8. [🕹️ Inputs](#-inputs)
9. [🧮 Math](#-math)
10. [🌐 Meshes](#-meshes)
11. [🥏 Physics](#-physics)
12. [🔊 Audio](#-audio)
13. [🎥 Rendering](#-rendering)
14. [🖥️ UI](#-ui)
15. [🏃‍➡️ Animations](#-animations)
16. [🏗️ Probuilder](#-probuilder)
17. [📉 Shader Graph](#-shader-graph)
18. [🎆 VFX Graph](#-vfx-graph)

# 🎓 Reference

## Unity Documentation

[Unity 6 Resources](https://unity.com/campaign/unity-6-resources)  
[Unity 6 Documentation](https://docs.unity3d.com/Manual/index.html)  
[Unity 6 Package Documentation](https://docs.unity3d.com/Manual/pack-safe.html)  
[Universal RP Shader Documentation](https://www.cyanilux.com/tutorials/urp-shader-code/)  

## Tutorials

[Editor Tutorial (GMTK)](https://www.youtube.com/watch?v=XtQMytORBmM&t=146s)  
[Unity Basics Tutorials (Code Monkey)](https://www.youtube.com/watch?v=E6A4WvsDeLE&list=PLzDRvYVwl53vxdAPq8OznBAdjf0eeiipT)  
[Beginner Project Tutorials (Unity)](https://learn.unity.com/courses/?k=%5B%22lang%3Aen%22%2C%22sl%3Afoundational%22%2C%22sl%3Abeginner%22%2C%22ind%3A5816ce9a32b30600171bef5a%22%5D&ob=recency)  
[Advanced Project Tutorials (Catlike Coding)](https://catlikecoding.com/unity/tutorials/)  
[Game Development Mathematics (Freya Holmér)](https://www.youtube.com/watch?v=fjOdtSu4Lm4&list=PLImQaTpSAdsArRFFj8bIfqMk2X7Vlf3XF)  

# 🎼 C# Syntax

## Types
[📓](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/built-in-types)

### Overview
Types in C# define what kind of information can be stored in a variable. It is important to note, there are two
categories of types: Value types and Reference Types. Value types can be thought of as variables that are
the data itself. Assigning a value type variable to another variable duplicates the data. Reference type variables 
point to the location where the actual data is stored. Passing around or assigning multiple variables to a
reference type just moves around and duplicates this pointer without changing or duplicating the data itself.
Here are good ones to know:
```csharp
///common value types
int number = 1; //32 bit signed integer
float single = 1f; //32 bit decimal number
double dub = 100d; //64 bit decimal number

bool boolean = true; // true or false
char character = 'a'; //a single character. can be cast to an int
```
```csharp
///Uncommon value types you may encounter
uint unsigned = 1U; // 32 bit unsigned integer. can only be positive or zero
long loooooong = 100L; // 64 bit signed integer.
ulong ulooooong = 100UL; // 64 bit unsigned integer.
short shrt = 1; //16 bit integer.
ushort ushrt = 1; //16 bit unsigned integer.
byte b = 0; //8 bit *unsigned* integer.
sbyte sb = -1; //8 bit *signed* integer.
decimal quad = 1000.0000001m; //128 bit decimal number O_o
```
```csharp
///reference types
string hi = "hello!";
object obj = new(); //parent type of all classes!
```

### Casting
[📓](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/numeric-conversions)
```csharp
//when information is not lost, C# will automatically cast types
float floatType = 1;//int to float cast

//when you want to cast anyway, you can manually force it with parenthesis
int intType = (int)2.5f;//float to int cast

//it is also possible to cast sub classes to and from their parent class
//in this example, BoxCollider is a child class of Collider
Collider col1 = new BoxCollider();//cast up
BoxCollider col1Box = (BoxCollider)col1;//cast down
```

### String Conversions
(String Formatting Documentation: [📓](https://learn.microsoft.com/en-us/dotnet/standard/base-types/composite-formatting))
```csharp
//casting a number to a string
//all of these result in "5"
int num = 5;
string a = ""+num; 
string b = num.ToString(); 
string c = string.Format("{0:0.##}",num);//maximum of 2 decimal places
```
```csharp
//casting a string to a number: .Parse()
string input = "12345";
try{
    int result = int.Parse(input);
    Debug.Log(result); //prints 12345
}
catch (FormatException){
    Debug.Log("AAAAAAA");
}
```
```csharp
//casting a string to a number: .TryParse()
const string input2 = "123.45";
if (float.TryParse(input2, out float value)){
    Debug.Log(value); //prints 123.45
}
else{
    Debug.Log("AAAAAAA");
}
```

### Enumerations (Enums)
[📓](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/enum)
```csharp
//basic enum
enum Week{
    Sunday,
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday
}
------
Week weekday = Week.Sunday;
if (weekday == Week.Wednesday){
    Debug.Log("Its Wednesday my dudes!");
}
```
```csharp
//enum with specified type and values
enum Versions: short{
    Unity_5 = 5,
    Unity_2018 = 2018,
    Unity_2019 = 2019,
    Unity_2020 = 2020,
    Unity_2021 = 2021,
    Unity_2022 = 2022,
    Unity_6 = 6
}
------
Debug.Log((ushort)Versions.Unity_6); //prints "6"
```
```csharp
//enum as a bit flag/mask
enum Layers{
    None = 0b_0000_0000,
    Default = 0b_0000_0001,
    Players = 0b_0000_0010,
    Trigger = 0b_0000_0100,
    All = Default | Players | Trigger
}
```

### Tuples
[📓](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/value-tuples)  
Quick and easy way to group variables together. They're mostly intended for [returning multiple values from a function](#multiple-return-values), but they can be used anywhere. Honestly they are the most underrated language feature I love them.
```csharp
//basic tuple
(double, int) tuppy = (2.5, 5);
Debug.Log(tuppy.Item1+"  "+tuppy.Item2);

//big tuple
(int, short, long, float, double, decimal) iLikeNumbers = (1,2,3L,4f,5d,6M);

//named members
(Vector3 pos, Vector3 vel) state = (Vector3.zero, Vector3.forward);
Debug.Log(state.pos+"  "+state.vel);
```

## Fields
[📓](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/fields)

### Declaration
Fields are variables. They can be declared like this:
```csharp
//format:
[optional access modifier] [optional modifier] [type] [name]

//primitive typed examples:
int number; //always initialized to default value
private int number2 = 10;
public static float decimalNumber = 100f;
private string hello = "hello!";

//object typed examples:
GameObject gameobject; //uninitialized
GameObject newGameObject = new GameObject(); //initialized with new object
GameObject oldGameObject = transform.gameObject; //initialized with existing object (doesn't make a copy!!)
```

### Shortcuts
IMO these make coding more enjoyable but code less easy to read. var: [📓](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/declarations#implicitly-typed-local-variables) new: [📓](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/new-operator#constructor-invocation)
```csharp
var idkWhatTypeToPut = transform.rotation; //var declares a new variable, and gives it the type of what you assign it.
var thisIsntAllowed; //this wont work, you must assign it when you declare it.
Vector3 vector3 = new(); //new automatically calls the class constructor for you based on the variable type!
Vector3 wooow = new(1f,1f,1f); //even works with parameters!
Dictionary<string,Transform> crazyDict = new(); //works with crazy list types which is very nice!
var wat = new(); //this will not work, you must specify a type somewhere!
```

### Access levels/ Accessibility
[📓](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/access-modifiers)
```csharp
public int pub = 1; //accessible anywhere
private int priv = 1; //accessible within the class or struct
protected int proc = 1; //accessible within the class or any sub-classes
internal int inter = 1; //accessible within the assembly(C# term that is complicated but basically just means your whole project)
protected internal int protInt = 1; //accessible within assembly *or* derived class
protected private int protPriv = 1; //accessible within assembly *and* if in the same class or a derived class
file int fileInt = 1; //accessible anywhere in this file only. Not usable until Unity upgrades from C# 9.0 to 11.0 :(
```

### Nullability
[📓](https://learn.microsoft.com/en-us/dotnet/csharp/nullable-references#nullable-variable-annotations)
```csharp
string notNull = ""; //this variable can never be null
string? nullString = null; //this variable can be!
GameObject objectVar = null; //object variables can be null by default

string? maybeNull = "who knows lol";
string error = maybeNull; //this wont work. nullable types cannot be assigned to non-nullable types
string allowed = maybeNull!; //this will work. adding ! tells the compiler you are sure it won't be null.

GameObject nullObject = null;
nullObject.SetActive(false); //this will throw an error
nullObject?.SetActive(false); //adding ? only runs .SetActive() if nullObject exists. otherwise returns null.
```

### Static Fields
[📓](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/static-classes-and-static-class-members#static-members)
```csharp
//static variables are shared variables across all objects of a class.
class Time{
    public static float deltaTime = 0.01f;
------
float fps = 1f/Time.deltaTime;
```

### Constants
[📓](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/constants)
```csharp
public const float pi = 3.14159f; //can never be changed
```


## Properties
[📓](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/properties)

Properties allow you to specify custom behavior for reading or writing to a value while still appearing as a variable
to code in other classes. They are not actually a variable and do not hold any data themselves. For that, they need a 
backing field (variable).

Property Examples:
```csharp
//property equivalent to a normal public variable
private string nameData = "";
public string nameProperty{
    get {
        return nameField;
    }
    set{
        nameField = value;
    }
}
```
```csharp
//if you leave the get & set blocks empty, C# will auto-generate a backing field for you
//this is equivalent to the first example
public string nameProperty {get;set;}

//get and set blocks can have their own access levels
public string privateSet {get; private set;}

//use init instead of set to only allow writes in constructors
public string writeOnce {get; init;}
```
```csharp
//usage examples
nameProperty = "Roxy";
Debug.Log(nameProperty);//prints "Roxy:

Debug.Log(privateSet);//this works
privateSet = "uh oh!";//this only works if we are in the same class as privateSet
```
```csharp
//complex example that puts everything together!
[SerializeField] private float inverseMass = 1f;
public float mass {
    get {
        if (mass == 0) {
            return float.PositiveInfinity;
        }
        else {
            return 1 / inverseMass;
        }
    }
    private set {
        if (value == 0) {
            inverseMass = float.MaxValue;
        }
        else if (float.IsPositiveInfinity(value)) {
            inverseMass = 0;
        }
        else {
            inverseMass = Mathf.Abs(1 / value);
        }
    }
}
```

## Functions
[📓](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/methods)

### Definition
Functions are modular sections of code that can be called elsewhere. They are composed of two parts: the signature and the code block.
```csharp
//signature format:
[optional access] [optional modifiers] [return type] [function name]<Optional Generic Types>([Optional Parameters]);
//examples:
public void SayHello();
protected static int calcVelocity(Vector3 pos1, Vector3 pos2);
private abstract T getStateObject<T>(); //more on this stuff in the generics section
```
```csharp
//code blocks: any single line of code or lines of code in curly brackets
return true; //valid code block
{ float result = Mathf.Pow(2f,2f); return result;} //valid code block
```
```csharp
//All together now, here are some examples!
private void SayHi()
    Debug.Log("Hello!");
void Integrate(float deltaTime) {
    transform.position += velocity * deltaTime + acceleration * deltaTime * deltaTime * 0.5f;
    velocity += acceleration * deltaTime;
    velocity *= Mathf.Pow(dampingFactor, deltaTime);
}
public static float DotProduct(Vector3 a, Vector3 b){
    float result = a.x*b.x + a.y*b.y + a.z*b.z;
    return result;
}
```

### Calling/Invoking
```csharp
//no return type, no parameters
SayHello();
//no return type, some parameters
SetPhysicsState(position, rotation, velocity);
//return type and parameters
float result = ToRadians(myDegreeMeasurement);//return value saved in variable result
```

### Access levels/ Accessibility
[📓](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/access-modifiers)
```csharp
public void A(){} //accessible anywhere
private void B(){} //accessible within the class or struct
protected void C(){} //accessible within the class or any sub-classes
internal void D(){} //accessible within the assembly(C# term that is complicated but basically just means your whole project)
protected internal void E(){} //accessible within assembly *or* derived class
protected private void F(){} //accessible within assembly *and* if in the same class or a derived class
file void G(){} //accessible anywhere in this file only. Not usable until Unity upgrades from C# 9.0 to 11.0 :(
```

### Function Modifiers
```csharp
static void A(){} //makes function callable without any object instances, called by using the class name itself
abstract void B(){} //marks function that must be implemented by child classes
virtual void C(){} //marks a function that can be overridden in a child class
override void D(){} //over-writes a function that already exists in the parent class
```

### Multiple Return Values
There are several ways to have a function return multiple values or objects, here are my favorites:
```csharp
//---pass by reference---
//ref keyword is only needed for primitives and structs, objects are always pass by reference
void IncrementBothRef(ref int a, ref int b){
    a++;
    b++;
}
-------
int a = 0;
int b = 0;
IncrementBothRef(ref a, ref b);
Debug.Log(a+"  "+b); // will print "1  1"
```
```csharp
//---encapsulate in a struct---
struct MyData{
    public int a;
    public int b;
}
MyData IncrementBothStruct(MyData data){
    data.a++;
    data.b++;
    return data;
}
-------
MyData data = new MyData();
data.a=0;
data.b=0;
MyData result = IncrementBothStruct(data);
Debug.Log(result.a+"  "+result.b); // will print "1  1"
```
```csharp
//---encapsulate in a tuple--- (the best one)
(int, int) IncrementBothTuple(int a, int b){
    a++;
    b++;
    return (a,b);
}
-------
int a = 0;
int b = 0;
(int, int) result = IncrementBothTuple(a,b);
Debug.Log(result.Item1+"  "+result.Item2); // will print "1  1"
```

## Classes & Structs
[📓](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/types/classes)

Classes and Structs are groups of variables & functions that define how an object instance works.

### Definition
```csharp
//format:
[access modifier] [class or struct] [name]
//examples:
public class ImAClass{
    //lots of very important stuff
}
private struct WhatIsAStruct{
    //lost of somewhat important stuff
}
```

### Overloading
```csharp
//you can declare multiple functions with the same name if they have different parameters
//C# will figure out which to call from what variables you pass
public class MathStuff{
    public static float Multiply(float a){
        return a*2;
    }
    public static float Multiply(float a, float b){
        return a*b;
    }
}
------
float a = MathStuff.Multiply(5f);
float b = MathStuff.Multiply(5f,6f);
Debug.Log(a+"  "+b); //prints "10  30"
```

### Constructors
[📓](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/types/classes#constructors-and-initialization)  
Constructors are functions with no name that can be called to create an object instance of your class or struct.
```csharp
//examples
public class SocialConstruct{
    public SocialConstruct(){
        //I am a constructor!
        //If you include no constructor, C# makes a default one like this that does nothing
    }
}
public struct PuttingTheStructInConstructor{
    float itsStructinTime;
    float structinAllOver;
    public PuttingTheStructInConstructor(float a, float b){
        itsStructinTime = a;
        structinAllOver = b;
    }
}
//don't forget, you can have multiple constructors with overloading as well!
```


### Object Instances
[📓](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/object-oriented/objects)  
This here is the main difference between structs and classes. Class objects are reference types, and Struct objects are
value types. This means struct variables have the data of the struct directly tied to them. If you assign a struct variable
to another variable it will copy the object, and either could be modified independently. Class variables are just pointers
to the location where the real data is stored. Assigning a class variable to another variable just results in both variables
pointing to the same data. If you modify one variable the changes are present in the other variable.

```csharp
//class object manipulation
GameObject go; //uninitialized, points nowhere
go = new GameObject();// keyword new creates a new object of type GameObject
                      // variable go points to that new object
GameObject go2; //uninitialized
go2 = go; //go2 points to the same object as go
go.name = "Nate" //update object name
Debug.Log(go.name+"  "+go2.name);//prints "Nate  Nate". the change to go is also seen in go2, because they are the same object
```
```csharp
//struct object manipulation
Vector3 vector; //creates an object with all default values
                //yes, Vector3 is a struct!
Debug.Log(vector);//prints (0,0,0)

vector = new Vector3(0f,1f,0f);//creates a new struct object and replaces the old one
Vector3 vector2 = vector;//copies vector into vector2
vector.y = 0f;//only modifies vector variable, vector2 is unchanged
Debug.Log(vector.y+"  "+vector2.y);//prints "0  1"
```

### Inheritance
[📓](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/object-oriented/inheritance)
```csharp
//adding : after the class declaration makes class a child of a class (and/or implements interfaces!)
public class CoolCollider : Collider{
    //all variables and functions from Collider are accessible as if they were declared here
    //the only thing that does not come over are constructors
    public void NewFunc(){
        Debug.Log(isTrigger);//got isTrigger from Collider
    }
}
```
```csharp
//abstract classes cannot be created as an object. They must use static variables/functions are be inherited by a child class
public abstract class AbstractClass{
    public static void float favoriteNumber = 24f;//accessbile with AbstractClass.favoriteNumber
    
    public abstract void ImplementMe(float a, int b);//must be implmenets by any child class
}
```
```csharp
public class BaseClass{
    public virtual void OverrideMe(){
        Debug.Log("Im the base function!");
    }
}
public class ChildClass: BaseClass{
    public override void OverrideMe(){
        Debug.Log("Im the child class function now!");
    }
}
------
BaseClass bc = new BaseClass();
ChildClass cc = new ChildClass();
bc.OverrideMe();//prints "Im the base function!"
cc.OverrideMe();//prints "Im the child class function now!"
```
### Equality
[📓](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/object-oriented/objects#object-identity-vs-value-equality)
```csharp
//to see if two class variables point to the same object in memory, use Object.Equals()
GameObject go = new GameObject();
go2 = go;
Debug.Log(go.Equals(go2));//prints true
```
```csharp
//to see if two structs have all their internal variables set to the same value, use ValueType.Equals()
//it does not matter if they are the same struct object or not, all that is checked is the internal variables
Vector3 v1 = new Vector3(0f,1f,0f);
Vector3 v2 = new Vector3(0f,1f,0f);
Debug.Log(v1.Equals(v2));//prints true
```

## Interfaces
Interfaces are a set of methods a class promises that it has. This is useful for making the same code work
for multiple classes.
```csharp
interface IHop{//interface names dont have to start with I but they tend to
    public void Hop();//interfaces only have function signatures, no actual code
}
class Frog: IHop{//implements interface
    public void Hop(){ //interface function implementation
        transform.position += Vector3.up*1f;
    }
}
class PogoStick: IHop{//also implements interface
    public void Hop(){//implements same function
        rb.velocity += Vector3.up*10f;
    }
}
------
void Hopper(IHop h){
    h.Hop();
}
void Start(){
   Hopper(new Frog());//both of these work in the same function thanks to interfaces!
   Hopper(new PogoStick());
}
```

## Collections
[📓](https://learn.microsoft.com/en-us/dotnet/standard/collections/commonly-used-collection-types)

Collections are built-in classes to organize/list data. There are a ton of them, but here are the most common ones
along with common functions you may see. Check the documentation for a complete list!

### Arrays
[📓](https://learn.microsoft.com/en-us/dotnet/api/system.array?view=net-8.0)
```csharp
//declaration of 1D arrays
int[] nullArray;
int[] initializedArray = new int[10];//must specify a size
int[] inlineArray = {1, 2, 3, 4, 5}; //initializes the array and all elements!
```
```csharp
//accessing arrays and common functions
string[] myArray = new string[5] {"one", "two", "three", "four", "five"};
string first = myArray[0];
string last = myArray[4];
int arrLength = myArray.Length;
Array.Sort(myArray);//sorts elements based on IComparable interface. lots of overrides with settings in the documentation!
Array.Reverse(myArray);//flips array
int index = Array.IndexOf(myArray, "one"); //returns index of "one" string in the array
string[] myCopy = new string[5];
Array.Copy(myArray, myCopy, arrLength); //copies elements of first array to the second. you have to give the length too!
Array.Clear(myArray, 0, arrLength); //clears array from first index inclusive to last index exclusive
```
```csharp
//loops
string[] myArray = new string[5] {"one", "two", "three", "four", "five"};
for (int i = 0; i < myArray.Length; i++){
    Debug.Log(myArray[i]);
}
foreach (string str in myArray){
    Debug.Log(str);
}
```
```csharp
//multi dimensional arrays
int[,] twoD = new int[3,5]; //2d array
int[,] inlineTwoD = {{1,2,3},{4,5,6},{7,8,9}}; //inline 2d array
int[,,] threeD = new int[3,3,9]; //3d array
int accessing = inlineTwoD[1,2];
```
```csharp
//jagged arrays: every row can have arbitary size!
int[][] jaaag = new int[3][];
jaaag[0] = new int[] {1,2,3};
jaaag[1] = new int[10];
jaaag[2] = new int[] {4,5,6,7};
int accessing2 = jaaag[2][3];
//you can get crazy with these
int[][,] cardStackArray = new int[5][,];
```

### Lists
[📓](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=net-8.0)
```csharp
List<string> list = new List<string>(); //primitive list
List<Transform> transList = new List<Transform>(); //object list
```
```csharp
list.Add("hoi!"); //adds element to the end
list.Insert(1,"hello!"); //adds element at the index, scoots rest of the list right
```
```csharp
int length = list.Count; //get number of objects in the list
bool contained = list.Contains("wuh!?"); //returns if object is in list
string gotIt = list[1]; //get an element
list.Reverse(); //flip list
list.Sort(); //sort list
```
```csharp
for (int i = 0; i < list.Count; i++){ //for loop
    Debug.Log(list[i]);
}
foreach (string item in list){ //foreach loop
    Debug.Log(item);
}
```
```csharp
list.Remove("hello!"); //remove object if it is in the list
list.RemoveAt(1); // remove object at the index, scoots rest of the list left to fill the hole
list.Clear(); //empty the list
```
### Dictionaries
[📓](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2?view=net-8.0)
```csharp
Dictionary<string, Vector3> dictionary = new Dictionary<string, Vector3>();
dictionary.Add("up", new Vector3(0f,1f,0f));
dictionary.Add("forward", new Vector3(0f,0f,1f));
```
```csharp
Vector3 gotIt = dictionary["up"]; //access a value
int entryCount = dictionary.Count;
bool hasKey = dictionary.ContainsKey("right"); //check if a key is present
bool hasValue = dictionary.ContainsValue(Vector3.right); //check if a value is in the dictionary
```
```csharp
foreach( KeyValuePair<string, Vector3> entry in dictionary ){ //loop through entries
    Debug.Log(entry.Key + "  " + entry.Value);
}
Dictionary<string, Vector3>.KeyCollection dictKeys = dictionary.Keys; //loop through keys
foreach (string key in dictKeys){
    Debug.Log(key);
}
Dictionary<string, Vector3>.ValueCollection dictValues = dictionary.Values; //loop through values
foreach (Vector3 value in dictValues){
    Debug.Log(value);
}
```
```csharp
dictionary.Remove("up"); //remove entry with this key
dictionary.Clear();//remove all entries
```

### Queues
[📓](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.queue-1?view=net-8.0)
```csharp
//first in first out list
Queue<string> queue = new Queue<string>();
queue.Enqueue("one");
queue.Enqueue("two");
```
```csharp
string first = queue.Peek(); //returns oldest value without removing it
string firstPop = queue.Dequeue(); //returns oldest value and removes it from the queue
bool inQueue = queue.Contains("three"); //checks if object is in the queue
```
```csharp
foreach (string str in queue){ //loop!
    Debug.Log(str);
}
```
```csharp
queue.Clear(); //emptys all elements in the queue
```

### Stacks
[📓](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.stack-1?view=net-8.0)
```csharp
//first in first out list
Stack<string> stack = new Stack<string>();
stack.Push("one");
stack.Push("two");
```
```csharp
string last = stack.Peek(); //returns newest value without removing it
string lastPop = stack.Pop(); //returns newest value and removes it from the stack
bool inQueue = stack.Contains("three"); //checks if object is in the stack
```
```csharp
foreach (string str in stack){ //loop!
    Debug.Log(str);
}
```
```csharp
stack.Clear(); //emptys all elements in the queue
```

### LINQ
[📓](https://learn.microsoft.com/en-us/dotnet/csharp/linq/)  
Language Integrate Query (LINQ) is basically just SQL built into C# in a nice way.
```csharp
float[] speeds = [5, 0, -1, 3.2]; //data set

IEnumerable<float> speedQuery = //variable storing results of the query
    from speed in speeds //sql style query
    where speed >= 0
    select speed;

foreach (float speed in speedQuery){ //looping through every entry in the query result
    Debug.Log(speed);//prints 5, 0, 3.2
}
```

## Delegates
[📓](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/delegates/using-delegates)  
Delegates allow you to store and pass functions around inside of a variable, just like if it was a class variable.

### Callbacks
There are many use cases for delegates, but callbacks are one of the most common. If there is a slow function that takes
a long time, like a file download, it may allow the caller to give it a callback funtion that it will call when the 
download/task is complete, to notify the caller.
```csharp
//simple callback example
public delegate void CallbackDelegate (string msg);//declare delegate type with matching parameters and return type
                                                   //to the function(s) you wish to store in it
public void CallbackFunc(string msg){
    //boy howdy I match the return type and parameters of the delegate type CallbackDelegate!!
    Debug.Log(msg);
    //maybe do other stuff too ooo la la
}
------
public void SuperSlowAsyncFunc(CallbackDelegate cb){
    //super duper slow code stuff
    cb("Im done!");
}

void Start(){
    CallbackDelegate callback = CallBackFunc;//just assign function name, nothing else
    SuperSlowAsyncFunc(callback);//after a long time, this prints "Im done!"
}
```

### Events
[📓](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/events/)  
Events are a way for a class to notify anyone else who is interested that something has just occured.
```csharp
//delegates can also hold multiple methods at once. this is SUPER useful for events
public delegate void StringDelegate (string msg);

public void StringFunc1(string msg){
    Debug.Log(msg);
}
public void StringFunc2(string msg){
    Debug.Log(msg+" I'm different!");
}
------
void Start(){
    StringDelegate d1 = StringFunc1;
    StringDelegate d2 = StringFunc1;
    StringDelegate d3 = StringFunc2;
    StringDelegate all = d1 + d2;
    all += d3;
    all("Hello!");//prints "Hello!" "Hello!" "Hello! I'm Different!")
    all -= d2;
    all("Hi!");//prints "Hi!" "Hi! I'm Different!"
}
```

## Generics
[📓](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/generics/generic-type-parameters)  
Generics are similar to delegates. Where delegates make it possible to have a function in a variable, generics make it
possible to have a type in a variable.
```csharp
//generic function example
void Swapsies<T>(T a, T B){
    T temp;
    temp = a;
    a = b;
    b = temp;
}
------
GameObject a = new GameObject("Roxy");
GameObject b = new GameObject("Nate");
Swapsies<GameObject>(a,b);
Debug.log(a.name+"  "+b.name);// prints "Nate  Roxy"
```
```csharp
//generic class example
class CoolCollection<T>{
    public void Add(T input){
        //very cool fancy data structure
    }
    public void Remove(T input){
        //very pog data yes yes
    }
}
------
CoolCollection<Vector3> cool = new CoolCollection<Vector3>();
cool.Add(Vector3.up);
cool.Add(Vector3.forward);
cool.Remove(Vector3.up);
```
```csharp
//you can restrict a generic to be a class, a struct, inherit from a base class, or implement and interface all with :

interface IState{
    public void Step(float time);
    public void CheckTransitions();
}

public void ExecuteStep<T>(float time) where T : IState{
    T.Step(time);//because we know T implements the IState interface
    T.CheckTransitions();//we can call methods from it without actually knowing the class
}

```
## Misc

### Lambdas
[📓](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/lambda-expressions)  
Lambdas (=>) are a way to create a function without explicitly making a function with a signature and a block. They are 
never required, but they can make switch statements, properties, and delegates with simple functionality much more readable.
I am not totally comfortable with them and they are much more powerful than these examples show, this is just the tip of the iceberg.
```csharp
//delegate example
//lambda format: (parameters) => expression or {code block}
Func<int,int> lambdaExample = (int x) => x*=2;

void lambdaEquivalent (int x){
    return x*=2;
}

Debug.Log(lambdaEquivalent(3));// prints 6
Debug.Log(lambdaExample(3));// prints 6
```
```csharp
//lambda as a parameter example
//there are several useful built in functions this work with
List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6 };
List<int> evenNumbers = list.FindAll(x => (x % 2) == 0);//List that contains 2, 4, 6
```
```csharp
//LINQ example
List<GameObject> gos = new List<GameObjects>() {
    new GameObject("Roxy"),
    new GameObject("Nate"),
    new GameObject("Thalia"),
};
List<string> names = gos.Select(x => x.name);//list of strings, each was a name of a go in the list
```


### Pattern Matching
Pattern matching is nebulous and hard to describe, but basically it is several shortcuts for checking conditions.
```csharp
//null checking example
string? couldBeNull = "AAAA";
if (couldBeNull is int notNull){//checks if couldBeNull is an int, and if so puts it in variable notNull
    Debug.Log(notNull);//prints "AAAA"
}else{
    Debug.Log("String is null!");
}

int? nullNum = null;
if (nullNum is not null){//this check fails because nullNum is null
    nullNum *=2;
}
```
```csharp
//type testing example
void OnTriggerEnter(Collider collider){
    if (collider is BoxCollider boxCol){
        Debug.Log("Box Trigger!");
        Debug.Log(boxCol.bounds);
    }else{
        Debug.Log("Other Trigger!");
    }
}
```
```csharp
//switch statement example
public string Vector2String(Vector3 v){
    string result = v switch{
        Vector3.up => "up",
        Vector3.forward => "forward",
        Vector3.right => "right",
        _ => "everything else"
    }
    return result;
}
```
```csharp
//comparison switch statement example
int celciusWaterTemp = 40;
string state = celciusWaterTemp switch {
    (>0) and (<100) => "liquid",
    <0 => "solid",
    >100 => "gas",
    0 => "solid-liquid transition",
    100 => "liquid-gas transition"
}
```
# 🖼️ Scenes
[📓](https://docs.unity3d.com/Manual/CreatingScenes.html)  
Scenes are assets that store a heirarchy of gameobjects that make up a level or area, as well as some settings
such as the skybox and light maps.

You can create a scene by clicking File > New Scene > Select a Template > Create. Save any open scene(s) by pressing
Ctrl+S or clicking File > Save. Open a scene by double-clicking the scene asset in the assets pane or clicking 
File > Open Scene.

## Scene Templates
[📓](https://docs.unity3d.com/Manual/scene-templates.html)  
Scene Templates allow you to create a blueprint for the starting settings and objects in a scene that can be selected from 
in the scene creation window.

To create a scene template, right-click a scene asset in the assets pane and click Create > Scene > Create Template from Scene.

Edit a scene template by selecting it in the assets pane. The top section specifies the template name, description, and 
the thumbnail that will appear in the scene creation window. The bottom section contains a list of assets in the template,
along with tickboxes to specify if they are cloned or not. Objects that are not cloned will behave a bit like prefabs. 
If the object is modified in the scene template, those changes will also show up in scenes created from that template.
However, if the object is cloned, any changes to the scene template will not be copied over to the created scene.

## Multiple Scenes
[📓](https://docs.unity3d.com/Manual/setupmultiplescenes.html)  
You can have multiple scenes open at once! This is useful for managers or UI or anything that should persist between levels.
To open a second scene, just click and drag it into the scene hierarchy.  

When multiple scenes are open, the lighting and skybox settings are pulled from the active scene. You can set the active 
scene by right-clicking it in the scene hierarchy and clicking Set Active Scene.  

Right-Click a scene and select Remove Scene
to remove it.

## Managing Scenes in Code
[📓](https://docs.unity3d.com/ScriptReference/SceneManagement.SceneManager.html)

```csharp
//loading scenes in

//load single scene on its own
SceneManager.LoadScene(0);//number is the build index
SceneManager.LoadScene("My Super Awesome Scene");

//load additively
SceneManager.LoadScene(1, LoadSceneMode.Additive);//number is the build index
SceneManager.LoadScene("My Kinda Mid Scene", LoadSceneMode.Additive);
```

```csharp
//loading scenes *asynchronously*
//this lets u make fancy loading screens and stuff
public GameObject LoadingScreen;
IEnumerator LoadSceneAsync(string scene){
    LoadingScreen.SetActive(true);
    AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(scene);
   
    // Wait until the asynchronous scene fully loads
    while (!asyncLoad.isDone){
        Debug.Log(scene+" is " + (asyncLoad.progress*10) + "% done loading!");
        yield return null;
    }
    LoadingScreen.SetActive(false);
}
```

```csharp
//unloading a scene
//this is only necessary when working with scenes additively
//for some reason this can only be done async 乁༼☯‿☯✿༽ㄏ

//doesnt need to be in a couroutine if you dont wanna do anything while you wait
SceneManager.UnloadSceneAsync("Additive Scene");
```

```csharp
//miscellaneous useful scene stuffs
//theres more in the docs obvs

int sceneCount = SceneManager.loadedSceneCount;//number of scenes loaded
Scene scene0 = SceneManager.GetSceneByBuildIndex(0);//returns scene 0 from build scenes list
Scene bigScene = SceneManager.GetSceneByName("Big Ass Scene");//returns a scene by name
Scene activeScene = SceneManager.GetActiveScene();//returns active scene
SceneManager.SetActiveScene(bigScene);//sets active scene. SCENE MUST BE LOADED FIRST

SceneManager.activeSceneChanged += ActiveSceneCallback;//delegate for when active scene is changed
SceneManager.sceneLoaded += LoadSceneCallback;//delegate that fires when a scene is loaded
SceneManager.sceneUnloaded += UnloadSceneCallback;//delegate that fires when a scene is unloaded
```

# 🦴 GameObjects
[📓](https://docs.unity3d.com/ScriptReference/GameObject.html)  
GameObject is the base class anything in the scene must be derived from. This includes lights, particle systems, characters,
levels, props, or anything in the scene hierarchy. Because GameObjects are so universal, they are also very generic, so there is not much
functionality to cover, but here are a few useful things about them! 

```csharp
GameObject go = new GameObject("Nice Name");//creates an empty gameobject and assigns it to go
                                            //use prefabs for creating anything with any more complexity than this

bool enabled = go.activeSelf;//Read Only Boolean for if the GameObject is enabled or not
go.SetActive(true);//Function to set the GameObject as enabled or disabled
go.name = "New Name";//set or get the GameObject name
go.layer = 8;//set or get the GameObject's layer. mostly used for physics, but not always.
go.tag = "TaggyTagTag";//set or get the GameObject's tag. Useful for tracking types of GameObjects
Debug.Log(go.transform.position);//get a gameobject's transform

Rigidbody[] AllRBsLoaded = FindObjectsByType<Rigidbody>(FindObjectsSortMode.None);//returns a list of all RigidBodies in the scene
GameObject go2 = GameObject.Find("Camera");//Returns any GameObject with the specified name. Kinda Laggy.
GameObject[] props = GameObject.FindGameObjectsWithTag("Prop");//Returns array of all active GameObjects tagged "Prop"

Destroy(go);//delete the GameObject before the next frame
DestroyImmediate(go);//delete the GameObject *Immediately*. (Worse for performance)
```

# 🫙 MonoBehaviours
[📓](https://docs.unity3d.com/ScriptReference/MonoBehaviour.html)  
MonoBehaviour is a base class that all components in Unity derive from. It automatically calls many functions that fire for
certain events or give information. The most common of these are the Start() and Update() functions. It also handles
coroutines and the GetComponent() function.

To create a new MonoBehaviour, click Assets > Create > Scripting > MonoBehaviour Script. The name of this new file must
match your MonoBehaviour's name, so pick a good one. To attach it to a GameObject, click and drag your script file from the
assets pane onto the GameObject in the scene hierarchy, or onto the bottom of the inspector pane if you have a GameObject selected.

## Messages
These are not all the events that MonoBehaviour will send, but I think these are the most important ones. They are listed
in the order they are called.
```csharp
//Rendering/Frame Loop

void Awake(){}//called when loaded in the first time
void OnEnable(){}//called when loaded or whenever the monobehaviour is enabled
void Start(){}//called before the first frame is processed. Meant for initialization
//loop starts here
void Update(){}//called every frame before Unity's internal rendering and updating and stuff
void LateUpdate(){}//called every frame after Unity's internal rendering and updating and stuff
void OnDrawGizmos(){}//call all your Gizmos.DrawXXX() stuff here
void OnApplicationPause(bool pauseStatus){}//sent when game is paused or unpaused from losing focus
//loop ends here
void OnApplicationQuit(){}//called if the game is closed :(
void OnDisable(){}//called when monobehaviour is disabled. if reenabled, OnEnable() is called again
void OnDestroy(){}//called right before this monobehaviour is unloaded
```

```csharp
//Physics Loop

//loop starts here
void FixedUpdate(){}//called on every physics loop before the interal physics is advanced
//internal physics update happens here
void OnTriggerEnter(Collider col){}//called once the tick a collider enters a trigger
                            //called on both the trigger and the entering collider
                            //parameter col is the other collider of the interaction
void OnTriggerStay(Collider col){}//called every tick for every collider is inside a trigger
                            //called on both the trigger and the entering collider
                            //parameter col is the other collider of the interaction
void OnTriggerExit(Collider col){}//called once the tick a collider exits a trigger
                            //called on both the trigger and the entering collider
                            //parameter col is the other collider of the interaction
void OnCollisionEnter(Collision col){}//called once the tick two colliders start colliding
                            //called on both involved colliders
                            //parameter col contains all the info of the collision
void OnCollisionStay(Collision col){}//called every tick for every collision this object is involved in
                            //called on both involved colliders
                            //parameter col contains all the info of the collision
void OnCollisionExit(Collision col){}//called once the tick two colliders start colliding
                            //called on both involved colliders
                            //parameter col contains all the info of the collision
//loop ends here
```

## Managing in Code

```csharp
//except for AddComponent, all of these can be done on gameobjects, monobehaviours, or transforms.
//when done on a monobehaviour or transform, it calls the function on the gameobject is is attached to.

BoxCollider box = gameObject.AddComponent<BoxCollider>();//box holds the new BoxCollider that was added to this gameobject
BoxCollider box2 = GetComponenet<BoxCollider>();//box2 holds the first BoxCollider found on this GameObject.
BoxCollider boxChild = transform.GetChild(0).GetComponent<BoxCollider>();//boxChild holds the first BoxCollider found on this transform's 0th child.
BoxCollider[] boxes = GetComponents<BoxCollider>();//boxes holds an array of all BoxColliders on this gameobject
Destroy(box);//removes box from this gameobject before the next frame
DestroyImmediate(box);//removes box from this gameobject *immediately*. worse for performance.
Destroy(this.gameObject);//Destroy() is used for removing components and gameobjects from a scene.
//Destroy can remove assets as well, useful for preventing memory leaks with procedural textures or meshes.
```

## Coroutines

Coroutines are a really nice way to run code in-between frames asynchronously without needing to spin up another thread.
They are useful for animations, timers, waiting for asynchronous functions like loading scenes, and more. NOTE:
Coroutines are executed by the monobehaviour they are called from. If their monobehaviour is disabled or destoryed, they
are also disabled or destroyed.

```csharp
//Coroutine declaration.
//They're just functions that return an IEnumerator
IEnumerator ImACoroutine(string message){
    float time = 0;
    while(true){
        time += Time.delatTime;
        Debug.Log("I've been saying "+message+" for "+time+" seconds!");//this prints every frame
        yield return null;//stops running code until the next frame/Update()
    }
}
```
```csharp
//Coroutines can also wait for a time in seconds
IEnumerator ICanSpellCoroutine(){
    while(true){
        Debug.Log("C-O-R-O-U-T-I-N-E");//this prints every 5 seconds
        yield return new WaitForSeconds(5f);//stops running code for 5 seconds
    }
}
```
```csharp
//Coroutines can be tied to the physics loop instead of the game loop as well
IEnumerator PhysicsCoroutine(){
    while(true){
        Debug.Log("Don't touch me!!!");//this prints every physics tick
        yield return new WaitForFixedUpdate();//stops running code until the next physics tick/FixedUpdate()
    }
}
```
```csharp
//starting and stopping coroutines
IEnumerator coroutine = ImACoroutine("Yaaaay parameters!");//sets up coroutine
StartCoroutine(coroutine);//actually starts executing the coroutine
------
StopCoroutine(coroutine);//cancels executing the coroutine if it is still running
```

# 🚋 Transforms
[📓](https://docs.unity3d.com/ScriptReference/Transform.html)  
Transform is the one mandatory component every GameObject must have. It stores and allows modification of a GameObject's
position, rotation, and scale. It also contains a GameObject's parent and any children GameObjects in the hierarchy.

## Position, Rotation, and Scale
```csharp
//how to access world position, rotation, and scale.
//look at the math section for how to actually work with them

Vector3 pos = transform.position;//get world position
pos.x = -pos.x;
transform.position = pos;//set world position
                        //cannot directly edit transform.position.x unfort

Quaternion rot = transform.rotation;//get world rotation
transform.rotation = Quaternion.identity;//set world rotation

Vector3 rot2 = transform.eulerAngles;//get world rotation converted to euler angles 🤢

Vector3 globalScale = transform.lossyScale;//read only global scale. Will be messed up if any parent transforms are rotated
```
```csharp
//how to access local position, rotation, and scale.
//look at the math section for how to actually work with them

Vector3 localPos = transform.localPosition;//get position relative to parent

Quaternion localRot = transform.localRotation;//get rotation relative to parent
Vector3 localEulerAngles = transform.localEulerAngles;//get rotation relative to parent converted to euler angles 🤢

Vector3 scale = transform.localScale;//scale relative to parent transform
```
```csharp
//helpful class variables

Vector3 forwardDirection = transform.forward;//blue vector of editor position gizmo
Vector3 upDirection = transform.up;//green vector of editor position gizmo
Vector3 rightDirection = transform.right;//red vector of editor position gizmo
GameObject go = transform.gameObject;//get gameobject for this transform

Matrix4x4 localToWorld = transform.localToWorldMatrix;//matrix that when multiplied with a position in local space,
                                                      //gives you that position in world space.
Matrix4x4 worldToLocal = transform.worldToLocalMatrix;//matrix that when multiplied with a position in world space,
                                                      //gives you that position in local space.
```
```csharp
//utility functions for all your transformation needs

transform.LookAt(Vector3.zero, Vector3.up);//rotates the transform to look at the first parameter.
                                           //optional second parameter specifies a second direction Unity will try to match the
                                                //transform's up direction to as best it can.
transform.RotateAround(new Vector3(100f,20f,-300f), Vector3.up, 35f);//rotates transform around the specified location
                                                            //along specified axis by the specified angle in degrees

Vector3 worldPoint = transform.TransformPoint(localPoint);//transform local position to world position
Vector3 worldDirection = transform.TransformDirection(Vector3.up);//transform local direction to world direction

Vector3 localPoint = transform.InverseTransformPoint(worldPoint);//transform world position to local position
Vector3 localDirection = transform.InverseTransformDirection(transform.up);//transform world direction to local direction
```

## Hierarchy
```csharp
//working with parents and children
//if only it was this easy

Transform parent = transform.parent;//parent in the hierarchy
Transform root = transform.root;//topmost transform we are a descendent of

int childCount = transform.childCount;//number of children we have
for (int i =0; i < childCount; i++){//loop through all children of this transform
    Debug.log(transform.GetChild(i));//get child by its index
}

Transform hiChi = transform.Find("Hiiii");//finds a child of this transform with this name

Transform firstChild = transform.GetChild(0);
firstChild.SetSiblingIndex(1);//reorder a transform relative to its siblings. this makes it the second child.
```

# 📦️ Prefabs
[📓](https://docs.unity3d.com/Manual/Prefabs.html)  

Prefabs allow you to save a gameobject and its children as an asset in your project that can be resued multiple times or
created at runtime. When you edit the prefab asset, any changes you make are automatically sent to any instances in any 
of your scenes.

To create a prefab, simply drag and drop a gameobject from the scene hierarchy into a folder in the assets pane. Prefabs
can be added to a scene by clicking and dragging them from the assets pane into the scene hierarchy!

To edit a prefab, double-click the prefab in the assets pane. To edit a prefab with the surroundings of one of its instances
still visible, click that instance in the scene hierarchy, and click open at the top in the inspector pane.

To remove all prefab behavior from a prefab instance, right-click an instance in the scene hierarchy and select Prefab > Unpack
Completely.

## Overrides

Prefab instances can be altered from the prefab asset they were created from. You can do this by adding, removing, or
altering the exposed variables of any component on any object in the prefab. You cannot remove or re-parent objects though.
Overridden settings will be bolded in the inspector pane.

To manage overrides, select a prefab instance in the scene hierarchy, and click the Overrides button at the top of the
inspector pane. This will show you everything that is overridden in the instance, and allows you to revert it to the 
way it is in the prefab, or apply those changes to the root prefab asset so all other instances have that change
as well.

## Variants

Prefab variants allow you to make a copy of a prefab with some alterations, and use that as its own prefab. It works the 
same as material variants. 

To create a variant, right-click a prefab and select Create > Prefab Variant. Editing them is the same as editing normal
prefabs. Any changes you make in an prefab instance work just like the overrides system. Values you change yourself will
stay, but any values that are unchanged will still inherit from the root prefab asset it was created from.

## Using at Runtime

```csharp
public GameObject myPrefab; //assign prefab asset to this field in the inspector

void Start(){
    GameObject instance = Instantiate(myPrefab, Vector3.zero, Quaternion.identity);//create instance from prefab
    Debug.Log(instance.name);
    Destroy(instance);//remove the instance (or any gameobject) before the next frame
    DestroyImmediate(instance);//remove the instance (or any gameobject) *instantly*. Worse for performance.
}
```

# 🕹️ Inputs
[📓](https://docs.unity3d.com/Packages/com.unity.inputsystem@1.11/manual/index.html)  
In Unity 6, game input is handled with the Input System package. This is different from the old built in Input Manager, 
so be careful when looking up guides. The Input System supports actions, action maps, runtime rebinding, and a ton of 
devices! There's a ton of theory for this one, so I've broken it up into sections. Good luck!

## Terminology
[📓](https://docs.unity3d.com/Packages/com.unity.inputsystem@1.11/manual/Concepts.html)  
- A **user** is a player of your game. 
- A **device** is the input hardware they are using (controller, keyboard & mouse, pen, etc...).
- A **control** is an individual sensor or group of sensors on a device. Most commonly these are buttons, but they also include
joysticks, triggers, and mouse movement.
- An **action** is a verb or, well, action, that happens in your game. Common ones are "Move", "Jump", and "Fire". Actions
have a type as well. They can be a bool, float, Vector2, and other exotic things I've never used.
- An **action map** is a group of actions that go with a scenario in your game. By default, there are two: "Player" and "UI".
Additional ones could be "Vehicle", "Battle", or "Editor".
- A **binding** is a link between an action and a control. The most common example is a bool action triggered by a button.
One action can have multiple bindings. These can be for different devices or multiple controls on the same device. 

## Theory
The idea behind the Input System is to have one actions asset for your entire project, with all the actions maps, actions, and bindings
for your project in one location. Your game will listen to different action maps in different situations, as you define in your code. You can have one action map
active at a time, or listen to multiple at once. You can also have the game listen to one input device at a time, or allow mixed
inputs from multiple devices. Every input you need for your game should live as an action under some action map in this action asset.
How you choose to use the structure is up to you. You can have a lot of action maps, or just make one large action map with all your
actions in it.

## Setting up Actions
Unity 6 will generate an actions asset for you in the Assets folder of your project. Double-click it to open it. Save your changes
or enable Auto Save in the top right. 

To add an Action Map, click the Plus at the top of the Action Maps section, type in a name,
and press enter. Left-click an action map to edit its actions. 

To add an action, click the plus at the top of the Actions section,
type in a name, and press enter. To edit an action, left click it, and options will appear in the Properties panel on the
right. Select button to make it a simple on or off, or select value to make it a float, Vector2, or another type. Here you can
also add Interactions to make things like double click or hold, and Processors to invert, normalize, add deadzones, and more
to input values.

To add a binding, select an action and click the plus to the right of its name. Most of the time you will just want to 
click Add Binding, but if you wish to make a multi-key combo, like WASD for movement, click Add Composite (Modifier bindings are used 
for things like Shift+Click. I've never used them). Left-click a binding to edit it, and its settings will appear in the Properties
section on the right. Click the box to the right of path and navigate through the menus to select which input you would like, or
search for it at the top. Below that it asks which control scheme you wish for that binding to be active in. Select the scheme
that matches the input device you set the bind for. Interactions and Processors can be added for individual bindings as well below.

## Implementation in Code
[📓](https://docs.unity3d.com/Packages/com.unity.inputsystem@1.11/manual/Workflows.html)  
Unity intends for there to be 3 different ways for you to interact with the Input System, each with different pros and cons.
The next 3 sections will each cover one. They are Direct Polling, PlayerInput Events, and Quick & Dirty Hardcoding. Direct Polling
has all input behavior defined in code, as opposed to having links in the editor, which can make debugging easier. It also allows
for more custom behavior. However, it does require more code. PlayerInput Events lets you set up events that will trigger your code 
when needed. This results in less code, but can make de-bugging trickier. This approach does have a baked in solution for local
multiplayer when combined with the PlayerInputManager. Quick & Dirty Hardcoding completely bypasses action maps, actions, and bindings,
and just lets you quickly check if a button is pressed. This is good for prototyping and game jams, but shouldn't be used for anything serious.

## Direct Polling
[📓](https://docs.unity3d.com/Packages/com.unity.inputsystem@1.11/manual/Workflow-Actions.html)  
```csharp
using UnityEngine.InputSystem;
------
InputAction moveAction;//variables to hold references to actions
InputAction jumpAction;

void Start(){
    moveAction = InputSystem.actions.FindAction("Player/Move");//get references to the actions
    jumpAction = InputSystem.actions.FindAction("Player/Jump");//dont do this in Update(), its a bit laggy
}

void Update(){
    Vector2 moveValue = moveAction.ReadValue<Vector2>();
    bool jumpValue = jumpAction.WasPressedThisFrame();
    if (jumpValue){
        Debug.Log("Jump Pressed!");
    }
}
```
```csharp
//sneaky suprise way to do events with the direct method :O
//this is basically just what PlayerInput does for you
using UnityEngine.InputSystem;
------
InputAction moveAction;

void Start(){
    moveAction = InputSystem.actions.FindAction("Player/Move");//get references to the actions
    moveAction.started += MoveCallback;//the callback context will say if it is started, performed, or cancelled
    moveAction.performed += MoveCallback;//how that works depends on the binding, action type, and all that. Google it 
    moveAction.canceled += MoveCallback;//if you arent sure!
}

void MoveCallback(InputAction.CallbackContext context){
    Vector2 moveValue = context.ReadValue<Vector2>();
}

void OnDestroy(){
    moveAction.started -= MoveCallback;//if you don't do this I think it causes a memory leak
    moveAction.performed -= MoveCallback;
    moveAction.canceled -= MoveCallback;
}
```

## PlayerInput Events
[📓](https://docs.unity3d.com/Packages/com.unity.inputsystem@1.11/manual/Workflow-PlayerInput.html)  
This method requires some setup in the editor first. Add a PlayerInput component to a GameObject in your scene (probably
the player character). Click the dropdown next to Behaviour and select Unity Events.

To make a function to get the value of an action, make a script with a function that looks like this:
```csharp
using UnityEngine.InputSystem;
------
public void MoveCallback(InputAction.CallbackContext context){
    Vector2 moveValue = context.ReadValue<Vector2>();
}
```
Now, in the Unity Editor, select the GameObject with your Player Input Component. In the inspector, go to the PlayerInput
component, and expand the section for Events. Open the Action Map you want, scroll down to the action you want, and click the
plus at the bottom of the box below it. Drag the GameObject with your input script into the field that says "None (Object)".
Now click the dropdown to the right of that field. Hover over your input script, and then select the appropriate method 
from the section at the top labelled Dynamic CallbackContext. If you don't see it, make sure it matches the function above.
All Done! ^-^

```csharp
//switching action maps
PlayerInput playerInput = GetComponent<PlayerInput>();
playerInput.SwitchCurrentActionMap("Player");
```

## Quick & Dirty Hardcoding
[📓](https://docs.unity3d.com/Packages/com.unity.inputsystem@1.11/manual/Workflow-Direct.html)  
```csharp
//sometimes we like it a little quick and dirty
using UnityEngine.InputSystem;
------
if (Gamepad.current == null) return;
if (Gamepad.current.rightShoulder.wasPressedThisFrame){
    Debug.Log("Cold Shoulder");
}
Vector2 leftStick = Gamepad.current.leftStick.value;

if (Keyboard.current == null) return;
bool press = Keyboard.current.spaceKey.isPressed;

if (Mouse.current == null) return;
bool click = Mouse.current.leftButton.wasPressedThisFrame;
```

## Reading Values
```csharp
using UnityEngine.InputSystem;
------
public void MoveCallback(InputAction.CallbackContext context){
    //if the action is a button type
    bool moveValue = context.ReadValueAsButton();
    //if the action is a value type
    Vector2 moveValue = context.ReadValue<Vector2>();
}
```

## Runtime Rebinding
[📓](https://docs.unity3d.com/Packages/com.unity.inputsystem@1.11/manual/ActionBindings.html#interactive-rebinding)  
```csharp
//interactive rebinding where the user presses the button they want bound
//this will work for most cases but not all. For those cases, look at the documentation for changing the default rebinding settings.
InputAction moveAction = InputSystem.actions.FindAction("Player/Move");
        
int bindingIndex = moveAction.GetBindingIndex(InputBinding.MaskByGroup("Gamepad"));
var rebind = moveAction.PerformInteractiveRebinding(bindingIndex);
rebind.OnComplete(//callback lambda function for when the rebind is complete
   operation => {
       Debug.Log($"Rebound '{moveAction}' to '{operation.selectedControl}'");
       operation.Dispose();//must dispose to avoid memory leak
   });
rebind.Start();//start the rebind. this happens in the background asynchronously.
```
```csharp
//saving and loading the user's custom rebinds. this is shockingly easy

void OnApplicationQuit(){//monobehaviour message
    //save rebinds to PlayerPrefs
    var rebinds = playerInput.actions.SaveBindingOverridesAsJson();
    PlayerPrefs.SetString("rebinds", rebinds);
}

void Start(){
    //load rebinds from PlayerPrefs
    var rebinds = PlayerPrefs.GetString("rebinds");
    playerInput.actions.LoadBindingOverridesFromJson(rebinds);
}
```
```csharp
//restoring default keybinds

InputAction moveAction = InputSystem.actions.FindAction("Player/Move");
        
moveAction.RemoveBindingOverride(InputBinding.MaskByGroup("Gamepad"));//reset Gamepad bindings for this action
moveAction.RemoveAllBindingOverrides();//reset bindings for all devices for this action
InputSystem.actions.RemoveAllBindingOverrides();//reset all bindings for all actions
```

# 🧮 Math

# 🌐 Meshes

# 🥏 Physics

# 🔊 Audio

# 🎥 Rendering

# 🖥️ UI

# 🏃 Animations

# 🏗️ Probuilder

# 📉 Shader Graph

# 🎆 VFX Graph

- add images for prefab open and override buttons?
- hotkeys? like search is Alt + K?
- Gizmos!

