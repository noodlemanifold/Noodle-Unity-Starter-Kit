
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
    //lots of somewhat important stuff
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
    
    public abstract void ImplementMe(float a, int b);//must be implemented by any child class
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
//you can restrict a generic to be a class, a struct, inherit from a base class, or implement an interface all with :

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
The next 3 sections will each cover one. They are using the Actions API, PlayerInput Events, and Quick & Dirty Hardcoding. The Actions API
is the recommended method and has all input behavior defined in code, as opposed to having links in the editor, which can make debugging easier. It also allows
for more custom behavior. However, it does require more code. PlayerInput Events lets you set up events that will trigger your code 
when needed. This results in less code, but can make de-bugging trickier. This approach does have a baked in solution for local
multiplayer when combined with the PlayerInputManager. Quick & Dirty Hardcoding completely bypasses action maps, actions, and bindings,
and just lets you quickly check if a button is pressed. This is good for prototyping and game jams, but shouldn't be used for anything serious.

## Actions API
[📓](https://docs.unity3d.com/Packages/com.unity.inputsystem@1.11/manual/Workflow-Actions.html)  
There are several ways to do this style in of itself O_o. They all have Pros and Cons I guess.
### Polling
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

### Events
```csharp
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

### Code Generation
[📓](https://docs.unity3d.com/Packages/com.unity.inputsystem@1.11/manual/ActionAssets.html#type-safe-c-api-generation)  
For this to work, *single*-click your actions asset to see its settings in the inspector. Tick the box labelled Generate C# Class.
Put in a class name you would like (and optionally a file name or namespace). I'll use SampleKitInputs. Then click apply.
For your script, all you have to do is this:
```csharp
public class InputScript : MonoBehaviour, SampleKitInputs.IPlayerActions { //the interface will be named after your action map

    SampleKitInputs inputs;
    
    void Start(){
        inputs = new SampleKitInputs();
        inputs.Player.SetCallbacks(this);//send input callbacks to this object
        inputs.Player.Enable();//enable player action map
    }
    
    public void OnMove(InputAction.CallbackContext context){
        Vector2 moveValue = context.ReadValue<Vector2>();
    }

    public void OnJump(InputAction.CallbackContext context){
        bool jumpValue = context.ReadValueAsButton();
    }
    ...
}
```
*and thats it O_o*. This method is very elegant, but it does make you make a function for every action in the map.

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
int bindingIndex = moveAction.GetBindingIndex(InputBinding.MaskByGroup("Gamepad"));//rebind Gamepad input

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

## Floats
[📓](https://docs.unity3d.com/ScriptReference/Mathf.html)  
Beyond the basic arithmetic operators built into C# (+,-,*,/,%), the rest of the Math functionality for floats is found in the
Mathf class. These are what I think are the most useful features of it. Full list is in the documentation as always. :)

```csharp
//static constants

float degrees = Mathf.Rad2Deg * 1.54f;//convert radians to degrees
float radians = Mathf.Deg2Rad * 90f;//convert degrees to radians

float tau = Mathf.PI * 2f;// π constant
float eep = Mathf.Epsilon;//really tiny but not quite zero number. useful for avoiding dividing by zero.
```
```csharp
//static functions

float abs = Mathf.Abs(-5f);//takes the absolute value
float sign = Mathf.Sign(-5f);//returns the sign of a number. Either -1 or 1.

bool closeEnough = Mathf.Approximately(1.0f, 10.0f / 10.0f);//returns if two floats are the same despite floating point inaccuracies.

int round = Mathf.RoundToInt(1.5f);//returns closet int according to rounding rules
int two = Mathf.CielToInt(1.1f);//returns next int above the float value
int one = Mathf.FloorToInt(1.9f);//returns next int below the float value

float daClaaaaamps = Mathf.Clamp(value,minimum,maximum);//sets value to be between minimum and maximum if it is not

float max = Mathf.Max(1f,5f);//returns the greater of two values
float min = Mathf.Min(1f,5f);//returns the smaller of two values

float whatsALog = Mathf.Log(value,bas);//calculates the log of the specified value and base
float exp = Mathf.Pow(value, exponent);//returns value raised to the power of exponent
float sqrt = Mathf.Sqrt(value);//takes the square root mate
```
```csharp
//trigonometry
float sin = Mathf.Sin(0f);
float cos = Mathf.Cos(0f);
float tan = Mathf.Tan(0f);

float arcsin = Mathf.Asin(0f);
float arccos = Mathf.Acos(0f);
float arctan = Mathf.Atan(0f);

Vector2 someLine = new Vector2(1f,1f).Normalize();
float angle = Mathf.Atan2(someLine.y, someLine.x);//returns angle in radians whose Tan is y/x
                                                  //can be thought of as angle between 2D vector and X axis. Very Helpful.
```
```csharp
//leeeeerping
float leeerp = Mathf.Lerp(min, max, fac);//returns value between min and max weighted by fac. fac should go from 0 -> 1
float angleLerp = Mathf.LerpAngle(min, max, fac);//lerps for angles in degrees. Same as Lerp, but handles rolling over 360 degrees.
float noClampssss = Mathf.LerpUnclamped(min, max, fac);//same as lerp, but fac can go above 1 or below 0. very fun.
//realtime lerp formula
float value = Mathf.Lerp(value, target, 1-pow(rate,Time.deltaTime));//thank u Freya :3

float fac = Mathf.InverseLerp(min, max, value);//determines where a value is between two other values. Actually quite useful!

float shmooth = Mathf.SmoothStep(min, max, fac);//interpolates between min and max in an S curve instead of linearly.
```
(By the way, if u are working with doubles instead of floats, there is an identical matching set of functions for them under
the Math class without the f :3)

## Vectors
[📓](https://docs.unity3d.com/ScriptReference/Vector3.html)  
These examples will use the 3D Vector Vector3, but most of these functions (excluding Dot(), Cross(), ProjectOnPlane(), and Slerp()) will work with Vector2
and Vector4s as well!

3D Vectors in Unity can be thought of as Points or Directions, and it is used to represent both. Sometimes the math is the
same for both, and sometimes Unity will have different functions for points or directions. For instance, use Lerp() when your
Vector3 is a point and Slerp() when your Vector3 is a direction. If your math doesn't quite work, make sure you aren't mistreating
your directions or points!

### Basics

```csharp
//creating and modifying a vector
Vector3 vector = new Vector3(1f,1f,1f);

vector.x = 2f;//transform.position and transform.scale don't allow you to edit components directly like this
vector.y = 3f;//but you can with any Vector3 that you create and most other Vector3s in Unity.
vector.z = 4f;

Debug.Log("Vertical Component is "+vector.y);
```
Vectors in unity, like all math classes, are [structs](#classes--structs), which means they are [value types, not reference types](#object-instances).
```csharp
Vector3 vecA = new Vector3(1f,1f,1f);
Vector3 vecB = vecA;//copies vecA into vecB
vecA.y = 2f;
Debug.Log(vecB.y);//prints 1f;
```
Vectors can be added or subtracted only from other vectors. They can only be multiplied or divided by scalars (ints or floats).
```csharp
Vector3 vecA = new Vector3(1f,1f,1f);
Vector3 vecB = new Vector3(1f,1f,1f);
//addition & subtraction
Vector3 vecC = vecA+vecB;
vecA = vecC - vecB;
//multiplication & division
vecA = vecA *2f;
vecA *= 2f;//shorthand identical to the previous line
vecB = vecB / 2f;
vecB /= 2f;//shorthand identical to the previous line
```
You can compare two different vectors and get results as you would expect
```csharp
Vector3 vecA = new Vector3(1f,1f,1f);
Vector3 vecB = new Vector3(1f,1f,1f);

if (vecA == vecB){//this check is passed
    Debug.Log("Huzzah!");//this gets printed
}
```
Useful built-in properties:
```csharp
Vector3 vec;
vec = Vector3.zero;   //same as new Vector3(0f,0f,0f);
vec = Vector3.one;    //same as new Vector3(1f,1f,1f);
vec = Vector3.right;  //same as new Vector3(1f,0f,0f);
vec = Vector3.left;   //same as new Vector3(-1f,0f,0f);
vec = Vector3.up;     //same as new Vector3(0f,1f,0f);
vec = Vector3.down;   //same as new Vector3(0f,-1f,0f);
vec = Vector3.forward;//same as new Vector3(0f,0f,1f);
vec = Vector3.back;   //same as new Vector3(0f,0f,-1f);

float length = vec.magnitude;//returns length of the vector
float sqrLength = vec.sqrMagnitude;//returns square of the vector length. Much less expensive to compute, use this if you can.
Vector3 vecNorm = vec.normalized;//returns a copy of this vector that has the same direction, but a length of one.
```

### Functions

```csharp
Vector3 vecA = Vector3.forward;
Vector3 vecB = Vector3.up;

float angle = Vector3.Angle(vecA,vecB);//returns smallest angle between the two vectors
float signedAngle = Vector3.SignedAngle(vecA, vecB, Vector3.right);//still returns smallest angle between the two vectors,
                                        //but uses the 3rd axis parameter to assign a sign according to the left-hand rule.
                                        //always returns between -180 degrees and 180 degrees.
```
```csharp
Vector3 maxComponents = Vector3.Max(vecA, vecB);//returns the max of each vector component individually in a new vector
Vector3 minComponents = Vector3.Min(vecA, vecB);//returns the min of each vector component individually in a new vector

float dist = Vector3.Distance(vecA, vecB);//returns distance between the two vectors as points
Vector3 newVec = Vector3.MoveTowards(vecA, vecB, 0.5f);//returns vecA moved towards vecB a distance no further than the 3rd parameter.
```
```csharp
float dot = Vector3.Dot(vecA, vecB);//projects vecA onto vecB, returns its new length. The direction is just vecB.normalized
Vector3 cross = Vector3.Cross(vecA, vecB);//returns new vector orthogonal to the two parameters. Direction determined by left-hand rule

Vector3 unit = Vector3.Normalize(vecA);//returns vecA normalized
Vector3.OrthoNormalize(ref vecA, ref vecB);//normalizes vecA, normalizes vecB and makes it orthogonal to vecA
```
```csharp
Vector3 proj = Vector3.Project(vecA, vecB);//projects vecA onto vecB. its the same as Vector3.Dot(), but returns a whole vector
Vector3 proj2 = Vector3.ProjectOnPlane(vecA, vecB);//projects vecA onto a plane defined with vecB as its normal.
Vector3 reflect = Vector3.Reflect(vecA, vecB);//returns vecA reflected off a plane defined with vecB as its normal.

Vector3 mov = Vector3.MoveTowards(vecA,vecB,5f);//moves point vecA towards vecB without exceeding the max distance given
Vector3 rot = Vector3.RotateTowards(vecA, vecB,Mathf.Pi/4f,1f);//returns vecA rotated and scaled towards vecB while staying below 
                                                //the maximum angle(in radians) and length delta specified by parameters 3 & 4.
```
```csharp                                                
Vector3 lerp = Vector3.Lerp(vecA, vecB, 0.3f);//returns vector linearly interpolated between vecA and vecB by a percentage
Vector3 noClamps = Vector3.LerpUnclamped(vecA, vecB, 1.3f);//same as lerp, but the percentage can go above 1 or below 0 O-o
//realtime lerp forumla
float rate;
vecA = Vector3.Lerp(vecA, vecB, 1-pow(rate,Time.deltaTime));//thank u Freya :3

Vector3 yummy = Vector3.Slerp(vecA, vecB,0.3f);//same as lerp, except vectors are treated as directions, not points.
                      //if both vectors have the same length, they are interpolated over the surface of a sphere, hence slerp.
Vector3 noSlamps = Vector3.SlerpUnclamped(vecA, vecB, 1.3f);//same as slerp, but the percentage can go above 1 or below 0 O-o
```

## Quaternions
[📓](https://docs.unity3d.com/ScriptReference/Quaternion.html)  
Quaternions are 4 dimensional unit vectors that lie on the surface of a 4 dimensional sphere with a radius of one. 
By the magic of group theory, those vectors can be used to represent rotations for objects in 3D space.
Fortunately, Unity hides all that complexity, and gives us an API to work with them in a simple way. 
Remember, they are not Vector4s, they work differently and have different rules!

Quaternions are used exclusively for working with rotations in Unity. They are better than Euler Angles because they interpolate
smoothly from one rotation to another, they never experience gimbal lock, and they don't have any issues with wrapping around
360 degrees. For these reasons, I will only be covering Quaternions.

Quaternions can be thought of as not storing rotations, but storing a rotational movement from a starting rotation, if that
makes any sense. It is the rotational equivalent of storing a distance, not a location. If you just have one Quaternion, it represents a movement from the default (identity) rotation to a new rotation.
When you combine Quaternions, these movements can instead start from a different rotation. This is how you do math with Quaternions,
by combining different rotational movements to build a new rotation. If you play with this idea in your head, you can see 
why Quaternion combinations are not commutative. The order in which you apply them matters.

There are almost no circumstances where you will create or modify the individual components of a Quaternion. In 99% of cases
it is better to start with existing rotations from GameObjects or Quaternion functions and manipulate those. If you are a member
of the 1%, here is how to do it anyways.
```csharp
//don't do this ever unless you *really* like 4D math and group theory
Quaternion oNo = new Quaternion (0f,0f,0f,1f);
oNo.x = 1f;
oNo.y = -oNo.y;
oNo.z = -oNo.z;
oNo.w = 0f;//w is the 4th component not the first, don't ask why
```
Here is how you should create Quaternions:
```csharp
// useful Quaternion creation functions
Quaternion rot = transform.rotation;//just yoink an existing object's rotation
Quaternion default = Quaternion.identity;//same as a Euler rotation of 0,0,0
Quaternion y90 = Quaternion.AngleAxis(90f, Vector3.up);//creates a rotational movement 90 degrees around the y axis.
                              //when multiplied with another Quaternion, it will rotate it around the axis by the given angle.
Quaternion ew = Quaternion.Euler(20f,30f,45f);//creates a quaternion from a euler rotation. 
                              //rotation around each axis is applied in the order Z -> X -> Y
Quaternion sbin = Quaternion.FromToRotation(transform.up,Vector3.up);//creates a rotational movement that if applied to the
                              //first vector, will rotate it so that it is aligned with the second vector.
Quaternion look = Quaternion.LookRotation(transform.forward, Vector3.up);//creates a rotation defined by a forward and up vector.
                              //Note: the vectors do not have to be orthogonal, Unity will match forward and do its best with up.
```
Quaternions do not have any defined addition, subtraction, or division operators. They do use the multiplication operator,
but in practice it should just be thought of as combining or applying, not multiplying.
```csharp
Quaternion rotA = Quaternion.AngleAxis(90f, Vector3.up);
Quaternion rotB = Quaternion.AngleAxis(90f, Vector3.up);

Quaternion rotC = rotA * rotB;//combines 2 90 degree y axis rotations into one y axis 180 degree rotation
Quaternion rotD = Quaternion.AngleAxis(180f, Vector3.up);
Debug.Log(rotC == rotD);//prints "true"
```
```csharp
//Quaternion combination is not commutative;
Quaternion rot90 = Quaternion.AngleAxis(90f, Vector3.up);

Quaternion resultA = rot90 * transform.rotation;
Quaternion resultB = transform.rotation * rot90;
Debug.Log(resultA == resultB);//prints "false"
------
//here is the difference:
Quaternion resultA = rot90 * transform.rotation;//this rotates transform.rotation in *world* space
Quaternion resultB = transform.rotation * rot90;//this rotates transform.rotation in *local* space
//this sorta makes sense if you think about it but it still blows my mind
Quaternion resultC = Quaternion.AngleAxis(90f, transform.up) * transform.rotation;
Debug.Log(resultB == resultC);//prints "true:
```
```csharp
//you can also combine quaternions with vectors to rotate vectors!
Vector3 rotated = Quaternion.AngleAxis(90f, Vector3.up) * Vector3.forward;//only works in this order
Debug.Log(rotated);//prints (1,0,0);
```
Other Quaternion Functions:
```csharp
float angle = Quaternion.Angle(quaternionA, quaternionB);//returns the angle between two rotations
Quaternion inv = Quaternion.Inverse(quaternion);//creates the opposite rotation of the rotation given. Useful for "subtracting" quaternions
Quaternion result = Quaternion.RotateTowards(quatA, quatB, maxAngle);//gives rotation going from quatA to quatB that rotates
                                                //a maximum of maxAngle degrees.
                                                
Quaternion lerp = Quaternion.Lerp(quatA, quatB, 0.3f);//returns a linearly interpolated rotation between quatA and quatB by a percent.
Quaternion ulerp = Quaternion.LerpUnclamped(quatA, quatB, 1.3f);//same as lerp, but the percent can be above 1 or below 0.
//realtime lerp formula
float rate;
transform.rotation = Quaternion.Lerp(transform.rotation, rotTarget, 1-pow(rate,Time.deltaTime));//thank u Freya :3

Quaternion lerp = Quaternion.Slerp(quatA, quatB, 0.3f);//for quaternions, this just slightly changes the path interpolated rotations take
                                                //from quatA to quatB. Just use whichever u like more :)
Quaternion ulerp = Quaternion.SlerpUnclamped(quatA, quatB, 1.3f);//same as slerp, but the percent can be above 1 or below 0.
```
Common Use Case Examples:
```csharp
//rotate around some axis by x degrees
transform.rotation = Quaternion.AngleAxis(angle, axis) * transform.rotation;

//"subtract" a quaternion instead of "adding" it
Quaternion superCoolRot = Quaternion.blablabla();
transform.rotation = Quaternion.Inverse(superCoolRot) * transform.rotation;

//rotate to look at a point
Vector3 lookDir = targetPoint - transform.position;
transform.rotation = Quaternion.LookRotation(lookDir,Vector3.up);//make Vector3.up the direction of up in ur game.
```

## Matrices

## Time
All the stuff you need related to time is just a static variable you can get from the Time class.
```csharp
float delta = Time.deltaTime;//time since last frame
float frames = Time.frameCount;//number of frames rendered since the game started
float duration = Time.realtimeSinceStartup;//time in seconds the game has been running
float frameTime = Time.time;//time in seconds the game was running when this current fram started.

float stepDelta = Time.fixedDeltaTime;//time between physics ticks
float stepTime = Time.fixedTime;//time in seconds the game was running when this physics tick started
bool inTick = Time.inFixedTimeStep;//returns true if this function was called from a physics event, false otherwise

float levelTime = Time.timeSinceLevelLoad;//time in seconds since the last *non additive* scene load
```

## RNG
Unity has a Random class for all the fun quirky random needs you may have. Note: there is also a built-in C# class called
Random, and if you are `using System;` in your script, they will conflict. To use Unity's, either don't include System,
call it using UnityEngine.Random, or put `using Random = UnityEngine.Random;` at the top of your file.
```csharp
//properties:
Vector2 circle = Random.insideUnitCircle;//gives a random point inside the unit circle.
Vector3 sphere = Random.insideUnitSphere;//gives a random point inside the unit sphere.
Vector3 randomDir = Random.onUnitSphere;//gives a random point on the surface of the unit sphere.
                                        //This is effectively a random direction generator
Quaternion randomRot = Random.rotationUniform;//gives a random rotation.
Random.State state = Random.state;//get *or set* the internal randomization state. this allows you to seed RNG.

float value = Random.value;//returns a float between 0->1 inclusive. 
```
```csharp
functions:
Color randomColor = Random.ColorHSV();//random color
Color randomColor2 = Random.ColorHSV(hueMin,hueMax,saturationMin,saturationMax,valueMin,valueMax,alphaMin,alphaMax);
                                    //random color within a specified HSV range!

Random.InitState(5);//seeds the random number generator

float range = Random.Range(3f,5.5f);//returns a random float between the two parameters inclusive.
```

## Misc
Plane, Ray, Rect

# 📄 2D
[📓](https://docs.unity3d.com/6000.0/Documentation/Manual/Unity2D.html)  
I could honestly make an entire other cheat sheet on just 2D stuff, but here is an overview of the most important things
for making 2D games in Unity!

## Perspective
2D games are made with the orthographic perspective. That means things do not get smaller as they get further from the camera.
This is necessary so players can't feel how flat the game truly is. When making a 2D game, there are still all kinds of perspective styles you can choose.
There is top down, where you look at the world from the perspective of a cloud. The straight side on view from Mario is a classic. You can pick a middle ground between side
view and top down that looks down at the world at an angle, like in Stardew Valley. If you then rotate the Camera on an imaginary
vertical axis, your camera is angled in two different axises, and the result is the Isometric Perspective, as seen in Monument Valley. 
If you have another idea, feel free to try it, the only rule here is that it must be fun!


## Depth
In order to make a 2D game in Unity, you don't have to change anything in the editor. Just enable the "View Options" scene 
view toolbar and hit the 2D button. This just changes the scene view Camera to be orthographic and to look down the Z axis.
2D games in Unity are still 3D and fully capable of being a 3D game. This means it is possible to make 2.5D games, but it
also means every 2D Unity game still has the third dimension. The Z coordinate is used to determine which sprites are drawn
on top of which other sprites. The term for this is [sorting](#sorting).

## Sprites
[📓](https://docs.unity3d.com/6000.0/Documentation/Manual/sprite/sprite-landing.html)  
Sprites are just 2D images for your 2D game. It may seem simple, but they can get kinda complicated!

### Asset Import
[📓](https://docs.unity3d.com/6000.0/Documentation/Manual/sprite/import-images-sprites/import-images-sprites-landing.html)  
If you just drag and drop an image into your Unity project, it won't work as a sprite. You must first change its import settings.
Single click the image in the assets pane, and its import settings will appear in the inspector pane. Change the Texture Type
at the top from Default to Sprite (2D and UI). When you do this, new options will appear. Change the pixels per unit variable to
determine how large your sprite is rendered in the world. The higher the number, the smaller it will be. Click the button labelled Open Sprite Editor. A preview of your sprite will appear. 
Left-click hold the top left of your sprite, drag to the bottom right of your sprite, and release. A bounding box defining your 
sprite will appear. You can click and drag the corners to adjust it. This is the workflow for simple object sprites, there is 
more you can do later with tile maps and 9-slicing. When you are happy, click Apply in the top right, and close the sprite editor.
Back in the inspector, tick the Alpha is Transparency box if your sprite has any
transparency in it. The other important settings are found at the bottom. Wrap mode changes how the texture behaves if it
ever encounters UV coordinates above 1 or below 0. Filter mode changes how the artwork is sampled by Unity for rendering. If
you are using pixel art, make sure you change this from Bilinear to Point. Below this are the texture's compression options, but
the defaults for those are usually fine. IMPORTANT: After you change any of these asset import settings, you must hit the Apply button at
the very end below all the settings for any changes to be saved!!!

### Adding to a Scene
If your import settings are set up correctly, you can just drag your sprite from the assets pane into the scene or the scene
hierarchy! ^-^

### Sorting
[📓](https://docs.unity3d.com/6000.0/Documentation/Manual/sprite/sort-sprites/sort-sprites-landing.html)  
There are a few ways to sort which sprites render on top!

Sprites with higher Z axis coordinates will render on top of sprites with lower Z axis coordinates.

If two sprites have the same Z axis coordinate, Order is determined by the Order in Layer field in their Sprite Renderer Component.
Higher values are rendered on top of lower values. You can also group sprites into sorting layers. Assign a sorting layer to a sprite
in its Sprite Renderer Component. You can change the Sorting Layer order by going to Project Settings > Tage and Layers > Sorting Layers.
Sorting layers take priority over Order in Layer.
```csharp
int sortWeight = 100;
//sort by depth
Vector3 pos = transform.position;
pos.z = sortWeight;
transform.position = pos;
//sort by order in layer
SpriteRenderer sr = GetComponent<SpriteRenderer>();
sr.sortingOrder = sortWeight;
```

### 9-Slicing
[📓](https://docs.unity3d.com/6000.0/Documentation/Manual/sprite/9-slice/9-slice-landing.html)  
9-Slicing is a technique to make resizeable sprites without any stretching. The sprite is sliced into 9 rectangles. When
resized, the corners just move without changing shape, the edges tile only along the axis they are parallel to, and the center
tiles in both directions to fill the space. This is a very powerful technique for making 2D levels and backgrounds, as one sprite
can be used to make entire levels of a game.

In order to set up 9-Slicing, drag and drop your 9-Slice sprite artwork into the assets pane and follow the [sprite import instructions](#asset-import) above.
When you are finished, under the Sprite Mode section, change Mesh Type from Tight to Full Rect. Then click the Open Sprite Editor
Button. Along the edges of your sprite bounds you should see green dots. Click and drag those in towards the center of your sprite.
After doing this for all 4 edges, you should have green lines defining 9 rectangular sections of your sprite within the sprite bounds.
Click Apply in the Sprite Editor, close it, and click Apply on the Sprite Import Settings.

To use your 9-Sliced sprite, click and drag it from the assets pane into the scene. Go to its Sprite Renderer Component, and change
the Draw Mode from Simple to either Sliced or Tiled. Sliced will stretch the individual sections of the 9-Slice, and Tiled will tile
them. Choose one, change the size of your sprite, and see how it looks! NOTE: 9-Slicing only works when you change the width or height
of the sprite in the SpriteRenderer component or using the Rect tool in the scene window. Scaling the transform will still stretch the sprite.

## Sprite Sheets
Sprite sheets allow you to have many sprites and/or sprite animation frames all on one image file. This is better for performance,
since the GPU just has to shift UV coordinates instead of uploading an entire new image for each sprite or animation frame.

In order to set up a sprite sheet, drag and drop your sprite sheet file into the assets pane and follow the [sprite import instructions](#asset-import).
After you are finished, click the Open Sprite Editor Button. In the top left, click the Slice Button. The first option is Slice Type. There 
are a few options, but I find Grid by Cell Count easiest, so we will do that. Click the dropdown next to Type and choose Grid by Cell Count.
Put in the number of columns and rows of sprites on your sprite sheet, and include any offsets or padding if you used those when drawing. When you are happy
with where the red lines are slicing your sheet, hit slice! Now your sprite is a grid of individual sprites. You can now go in
and individually change the bounds of any sprite, or even 9-slice some of them. When you are happy, hit Apply in the top right
and close the Sprite Editor.

Now, your sprite sheet asset in the assets pane will have an arrow pointing to the right over the image. Click that to expand it.
A list of every sprite in the sprite sheet will appear in the assets pane. Click and drag any of them into your scene to add them,
just like with any other sprite!

## Tile Maps
[📓](https://docs.unity3d.com/6000.0/Documentation/Manual/tilemaps/tilemaps-landing.html)  
Tile Maps are a package in Unity that allows you to turn sprite sheets into a set of brushes to quickly paint levels! I'm just
going to go over rectangular tile maps here, but there are also hexagonal and isometric tile maps as well! Check the documentation
or look up guides for those styles if you need them.

To create a tile map, Click GameObject > 2D Object > Tilemap > Rectangular. This creates a grid and a Tilemap below it. You can
have multiple tilemaps per grid for different layers. To do that, right-click the Grid gameobject in the scene hierarchy, then click
2D Object > Tilemap > Rectangular.

Select your tilemap gameobject in the scene hierarchy. In the bottom right of the scene view, there will be a little button that
says Open Tile Palette. Click it! This window has the tile palette for your tilemap. Drag and drop any number of sprites or
sprites from a spritesheet into the section where it says to do so. The editor will prompt you to select a folder. It doesn't 
tell you this, but it is about to put a ton of new files in whatever folder you select, so make sure to make a new folder for your
tilemap and choose that one.

Once you have some sprites, the tile palette is split into three sections. The top one has a bar of tools that you can use to paint
your tilemap with sprites. There is also a dropdown to select which tilemap you are editing if you have multiple. The middle section
is a grid of every sprite in your tile palette. You can keep dragging more sprite assets in here to build your palette. There is a dropdown to switch which tile palette you are painting with. Tile maps and
tile palettes are totally separate from each other, so you can make multiple tile palettes to your liking and use them on any tile map
in your game! To the right of that dropdown there are 3 buttons. The pencil button lets you use the tools in the top bar to edit and move
the sprites in your tile palette instead of sprites in the tile map. Use this to organize your palette. The other two buttons are options
to show the grid and show gizmos in your palette. The bottom section holds scriptable brushes. There are a few defaults, but you
can also create your own or find some online. Press the gear icon to hide this section if you aren't using it.

If you aren't happy with the size of your sprites in a grid space, change their pixels per unit in their import settings. By default,
one tilemap cell is one unit by one unit. If you would like to change this, select the Grid gameobject in your scene hierarchy and change the grid size.

A quick note on Physics: you can add a TilemapCollider2D Component to your tile map gameobject, and it will automagically generate 
colliders for every tile in your tile map!!

## Sprite Shapes
If you want an alternative to tilemaps that is less of a rigid grid and allows for fluid curves and angles, sprite shape is for you!
Sprite Shapes is a package that lets you set up sprites to be drawn along lines you draw in the editor in any shape you please. There is
a lot of depth and functionality here I'm going to gloss over, but know there are a lot more options if you need them!

There are two parts to make a sprite shape: sprite shape profiles and sprite shape controllers. Sprite shape profiles can be thought of
as the material for your sprite shape. To create one, click Assets > Create > 2D > Shape Sprite Profile. There sure are a lot of
settings to tweak, lets go through them! The fill sprite is what is tiled to fill in a closed shape. If you make an open shape (a line),
this goes unused. Below that there is a large circle. The way this works is you can define an angle range by dragging the handles
at the bottom or typing in values at the bottom. The blue handle at the top is your preview angle. If you drag the preview angle beyond your
allowed angle range, a Create Range button appears. Click this to add another set of handles to define a second range! Each angle range has
its own sprite(s) that it uses. You can assign the sprite(s) it will use below the angle limit variables. This allows you to use different sprites
for flat ground versus steep slopes or walls. Also, make sure any sprites you use are set to the Full Rect mesh type, and have their
wrap mode set to Repeat. There are also options below this to use bespoke sprites for various corner types if you use any sharp corners.

Create a sprite shape controller by clicking GameObject > 2D Object > Sprite Shape > Open Shape or Closed Shape. Open shapes are just
lines with control points. Closed shapes are polygons with a closed interior that will be filled with your fill sprite. Select your
shape after you create it and look at its Sprite Shape Controller component. Assign you sprite shape profile to the variable named profile.
under that there is a button to edit the shape. Click that. You can drag any control points to anywhere you like. Click on a line between 
two points to add a new control point there. Press the delete key with a control point selected to delete it. In the bottom right of the
scene view, you can select which type of control point you would like it to be and manually type in values for it. There are other
options in the sprite shape controller but honestly the defaults seem fine.

Attach a PolygonCollider2D or an EdgeCollider2D to you sprite shape controller to enable collision!

## Animations
2D animations are actually super easy to do! Easy once you have the sprites done 😬. Animations in general are covered in the main [Animations](#-animations) section,
but here is how to set up an animation for sprites specifically.

To set up your animated character or whatever, you could add an Animator component to your gameobject with a Sprite Renderer,
create an Animation Controller Asset, assign that controller to the Animator Component, Click Window > Animation > Animation to
open the Animation Window, select your character, click Create Animation, save the file in your project, click Add Property,
select the Sprite variable under Sprite Renderer, and add keyframes for each sprite of your animation, OR, you could do the shortcut.
Select multiple sprites from a sprite sheet in the asset pane, then click and drag them into the scene hierarchy. Give your animation
a name and save it somewhere nice in your project. Now all of what I just described has been done for you automatically. Adjust the 
auto-generated keyframes as necessary. To make more animations, click the dropdown in the top left of the animation window,
then click Create New Clip. Give it a name and save it. In the new clip, click Add Property, then select Sprite under Sprite Renderer.
Add keyframes for the various sprites you want. This new animation will show up in your animation controller, and you can set up
the transitions from there. Happy animating!

(If you want you can also just change the active sprite in the Sprite Renderer component in code and just make your own animation
system if you don't like how Unity does it)
```csharp
public Sprite sprite;//asign sprite asset to this in the editor
------
SpriteRenderer sr = GetComponent<SpriteRenderer>();
sr.sprite = sprite;//do this a bunch for every animation frame
```

## Physics2D
2D Physics uses all the same class, component, and collider names as normal 3D physics, just with a 2D stuck on the end.
2D Rigidbodies are Rigidbody2D, Colliders are of type Collider2D, you do raycasts with Physics2D.Raycast(), yada yada. This
means if you are comfortable with 3D physics, using 2D physics is actually a pretty easy transition! If you aren't comfortable
with 3D physics, check out the [Physics Section](#-physics). I will just be covering the specific differences to 2D physics here.

Rigidbody2D is pretty much the same as the normal Rigidbody. Add it to things to give them physics simulation. Angular Velocity,
Rotation, and Angular Inertia are all just floats now because it's 2D. I think that's all!

All your favorite Collider types are back! BoxCollider is now BoxCollider2D, CapsuleCollider is now CapsuleCollider2D, and 
SphereCollider is now CircleCollider2D! Because 2D physics is computationally so much lighter than 3D, there are also a lot 
more options for colliders that don't have 3D equivalents. CompositeCollider2D will merge the shape of any other colliders into
one big collider. EdgeCollider2D lets you draw a line that will collide with things from both sides of the line. PolygonCollider2D
does the same, but instead lets you define your own wacky closed shape to match any sprite you wish. Keep in mind, unlike with 3D
physics, there is no restriction on concave colliders. You can make your rigidbody colliders whatever wacky shape you please. Also 
keep in mind the Z coordinate is completely ignored for calculations. Use layers if you need objects to pass through each other.

The Physics2D class is very similar to the Physics class. It has a lot of functions, the most useful ones being the overlap functions,
collider cast functions, and ray cast functions. These are all similar to their 3D equivalents, except they use Vector2s instead of
Vector3s. You can find documentation for all these functions [here](https://docs.unity3d.com/ScriptReference/Physics2D.html).

There are also more joints available for 2D physics than for 3D. Unity has support for distance joints, fixed joints, friction
joints, hinge joints, relative joints, slider joints, spring joints, target joints, and wheel (suspension) joints. Have fun!

2D physics has a concept of its own that is missing from 3D physics: effectors. Effectors are basically built in functionality 
for trigger colliders. You set one up by first creating a trigger collider. Anything inside this trigger collider will be effected
by the effector. Make sure both Is Trigger and Used by Effector are both ticked. Then, all you have to do is add an effector as a component to the gameobject.
Your options are: Area effector, buoyancy effector, platform effector, point effector, and surface effector. The area effector 
just constantly applies a force in a specified direction. The buoyancy effector "simulates" a fluid with a specified density and
surface level. Platform effectors are meant for platformers. They make their colliders have one way collisions, remove side friction,
remove bounciness, and quote, "more". Don't make your collider(s) a trigger when using this effector. Point effectors will apply a force
towards a specified point, like a magnet. Surface effectors simulate a movement speed along their edges without actually moving, useful
for conveyor belts and such. Again with this one, don't use trigger colliders, make them normal colliders.

## Lighting
If you are using the 2D version of the Universal Render Pipeline (setup automatically with the 2D project template), then Unity
actually has some really cool 2D lighting options available to you! By adding 2D lights and shadows to your scene, Unity will generate
render textures on top of all your sprites to make them appear as if they are being lit and casting shadows in certain directions.
Note: This is not physically accurate AT ALL, it's just a neat aesthetic. This only works if your project is set up in a very specific
way. If you are interested, I highly recommend making your project from the 2D template so it just works out of the box.

If your project is set up right, to add a light, just click GameObject > Light > select any light ending in 2D. Your new light will
now shine onto any sprite in its range. Keep in mind, if your sprite is white, it can't get any brighter so you won't see anything.
Spot lights are point lights that let u define an angle range for them. Sprite lights cast light in the shape of any sprite you select.
Freeform lights let you draw a polygon that will cast light a set distance away from it. Global lights just add light to everything globally (only seems to work with the additive blend mode for some reason?).

To add shadows, first make sure you have a 2D light in your scene that isn't a global light, and that light has shadows enabled. Also make
sure you have some kind of background sprite, shadows will not cast over the skybox. For every sprite that you want to have shadows,
add a Shadow Caster 2D component to it. Tada! Shadows! If you want shadows from multiple objects to play nicely with each other, make sure
each object also has the Composite Shadow Caster 2D component attached to it as well in addition to the Shadow Caster 2D component.

Lights and shadows can both be restricted to various sorting layers to achieve complex layered results. The sprite Z coordinate is not considered
at all, so you must use sorting layers.


# 🌐 Meshes

# 🥏 Physics

# 🔊 Audio

# 🎥 Rendering

# 🖥️ UI

# 🏃 Animations

# 🗄️ Multiplayer

# 🏗️ Probuilder

# 📉 Shader Graph

# 🎆 VFX Graph

- add images for prefab open and override buttons?
- hotkeys? like search is Ctrl + K?
- Gizmos!
- Color and Gradient?
- custom inspector buttons and sliders and stuff

