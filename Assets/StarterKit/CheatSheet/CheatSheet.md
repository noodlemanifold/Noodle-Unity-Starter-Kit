# Welcome!

This is Roxy's Cheatsheet for developing games in Unity! It has notes, syntax, and guides for a lot of things in the
engine! I wrote this with beginners in mind, but there are still advanced sections for more experienced developers.
If you see a section and have no idea what's going on, that's ok! All the necessary sections are accessible and easy.
All the content in this document is layed out in the table of contents below. Click on any section to jump to it.
Section headers may be followed with a 📓. Clicking 📓 will take you to any relevant documentation. Let me know if
there is anything left out that you would like me to include! Take a deep breath, relax, and have fun creating! 💗

# Table of Contents

* [🎓 Reference](#-reference)
  * [Unity Documentation](#unity-documentation)
  * [Tutorials](#tutorials)
* [🔥 Hotkeys](#-hotkeys)
* [🎼 C# Syntax](#-c-syntax)
  * [Types](#types)
  * [Fields](#fields)
  * [Properties](#properties)
  * [Functions](#functions)
  * [Classes & Structs](#classes--structs)
  * [Interfaces](#interfaces)
  * [Collections](#collections)
  * [Delegates](#delegates)
  * [Generics](#generics)
  * [Misc](#misc)
* [🖼️ Scenes](#-scenes)
  * [Scene Templates](#scene-templates)
  * [Multiple Scenes](#multiple-scenes)
  * [Managing Scenes in Code](#managing-scenes-in-code)
* [🦴 GameObjects](#-gameobjects)
* [🫙 MonoBehaviours](#-monobehaviours)
  * [Messages](#messages)
  * [Managing in Code](#managing-in-code)
  * [Coroutines](#coroutines)
* [🚋 Transforms](#-transforms)
  * [Position, Rotation, and Scale](#position-rotation-and-scale)
  * [Hierarchy](#hierarchy)
* [📦️ Prefabs](#-prefabs)
  * [Overrides](#overrides)
  * [Variants](#variants)
  * [Using at Runtime](#using-at-runtime)
* [🕹️ Inputs](#-inputs)
  * [Terminology](#terminology)
  * [Theory](#theory)
  * [Setting up Actions](#setting-up-actions)
  * [Implementation in Code](#implementation-in-code)
  * [Actions API](#actions-api)
  * [PlayerInput Events](#playerinput-events)
  * [Quick & Dirty Hardcoding](#quick--dirty-hardcoding)
  * [Reading Values](#reading-values)
  * [Runtime Rebinding](#runtime-rebinding)
* [🧮 Math](#-math)
  * [Floats](#floats)
  * [Vectors](#vectors)
  * [Quaternions](#quaternions)
  * [Matrices](#matrices)
  * [Time](#time)
  * [RNG](#rng)
  * [Misc](#misc-1)
* [📄 2D](#-2d)
  * [Perspective](#perspective)
  * [Depth](#depth)
  * [Sprites](#sprites)
  * [Sprite Sheets](#sprite-sheets)
  * [Tile Maps](#tile-maps)
  * [Sprite Shapes](#sprite-shapes)
  * [Animations](#animations)
  * [Physics2D](#physics2d)
  * [Lighting](#lighting)
* [🎥 Rendering](#-rendering)
  * [Universal Render Pipeline](#universal-render-pipeline)
  * [Camera](#camera)
  * [Importing Models](#importing-models)
  * [MeshRenderer](#meshrenderer)
  * [Materials](#materials)
  * [Lighting](#lighting-1)
  * [Shadows](#shadows)
* [🏃 Animations](#-animations)
  * [Animation Window](#animation-window)
  * [Animation Clips](#animation-clips)
  * [Animation Manager](#animation-manager)
  * [Playing Animations](#playing-animations)
  * [Rigging & Procedural Animation](#rigging--procedural-animation)
  * [Animating Variables](#animating-variables)
* [🥏 Physics](#-physics)
  * [Rigidbody](#rigidbody)
  * [Colliders](#colliders)
  * [ArticulationBody](#articulationbody)
  * [The Physics Class](#the-physics-class)
  * [Writing Physics Code](#writing-physics-code)
  * [Physics Settings](#physics-settings)
* [🔊 Audio](#-audio)
  * [Audio Clip](#audio-clip)
  * [Audio Listener](#audio-listener)
  * [Audio Source](#audio-source)
  * [Audio Mixer](#audio-mixer)
  * [Project Audio Settings](#project-audio-settings)
  * [Tracker Modules](#tracker-modules)
  * [Native Audio SDK](#native-audio-sdk)
* [🖥️ UI](#-ui)
  * [Building a UI](#building-a-ui)
  * [Hooking UI Components Up to Code](#hooking-ui-components-up-to-code)
  * [Custom UI Components](#custom-ui-components)
  * [Composing UI in Code](#composing-ui-in-code)
* [💾 Managing Data](#-managing-data)
  * [Static Class](#static-class)
  * [Singleton Class](#singleton-class)
  * [ScriptableObject](#scriptableobject)
  * [Serialization & Saving to Disk](#serialization--saving-to-disk)
  * [PlayerPrefs](#playerprefs)
  * [A Note on Save Files](#a-note-on-save-files)
* [✏️ Editor Scripting](#-editor-scripting)
  * [Attributes](#attributes)
  * [Gizmos](#gizmos)
  * [Custom Inspectors](#custom-inspectors)
  * [Custom Windows](#custom-windows)
* [🗄️ Multiplayer](#-multiplayer)
  * [Theory & Terminology](#theory--terminology)
  * [Setup](#setup-1)
  * [Sync Components](#sync-components)
  * [Network Variables](#network-variables)
  * [RPCs](#rpcs)
  * [Connections](#connections)
* [📈 Profiler](#-profiler)
* [🏗️ Probuilder](#-probuilder)
* [🕶️ Shader Graph](#-shader-graph)
* [🎆 VFX Graph](#-vfx-graph)
* [🫥 DOTS](#-dots)

# 🎓 Reference

## Unity Documentation

[Unity 6 Resources](https://unity.com/campaign/unity-6-resources)  
[Unity 6 Documentation](https://docs.unity3d.com/Manual/index.html)  
[Unity 6 Package Documentation](https://docs.unity3d.com/Manual/pack-safe.html)  
[Unity 6 Editor Design System](https://www.foundations.unity.com/)  
[Universal RP Shader Documentation](https://www.cyanilux.com/tutorials/urp-shader-code/)

## Tutorials

[Unity Editor Tutorial (GMTK)](https://www.youtube.com/watch?v=XtQMytORBmM&t=146s)  
[Unity Basics Tutorials (Code Monkey)](https://www.youtube.com/watch?v=E6A4WvsDeLE&list=PLzDRvYVwl53vxdAPq8OznBAdjf0eeiipT)  
[Beginner Project Tutorials (Unity)](https://learn.unity.com/courses/?k=%5B%22lang%3Aen%22%2C%22sl%3Afoundational%22%2C%22sl%3Abeginner%22%2C%22ind%3A5816ce9a32b30600171bef5a%22%5D&ob=recency)  
[Advanced Project Tutorials (Catlike Coding)](https://catlikecoding.com/unity/tutorials/)  
[Game Development Mathematics (Freya Holmér)](https://www.youtube.com/watch?v=fjOdtSu4Lm4&list=PLImQaTpSAdsArRFFj8bIfqMk2X7Vlf3XF)

# 🔥 Hotkeys

All key binds are searchable and changeable in Edit > Shortcuts. Here are the bangers:

Editor:

- Project Search: Ctrl + k
- Reload Assets Folder: Ctrl + R
- Invert Selection: Ctrl + I
- Select Children: Shift + C
- Add Component: Ctrl + Shift + A
- Duplicate: Ctrl + D
- Enter Play Mode: Ctrl + P
- Pause Play Mode: Ctrl + Shift + P
- Undo: Ctrl + Z
- Redo: Ctrl + Y
- Build and Run: Ctrl + B
- Build Profiles: Ctrl + Shift + B
- New Scene: Ctrl + N
- Open Scene: Ctrl + O
- Save Scene: Ctrl + S
- Create Empty GameObject: Ctrl + Shift + N
- Create Empty GameObject Child: Alt + Shift + N
- Toggle Grid Snapping: \
- Increase Grid Size: Ctrl + ]
- Decrease Grid Size: Ctrl + [
- Create Folder: Ctrl + Shift + N

Scene View:

- Select: Left Click
- Menu: Rick Click
- Focus: Middle Click
- Box Select: Hold Left Click
- Look: Hold Right Click
- Pan: Hold Middle Click
- Pan: Ctrl + Alt + Left Click
- Orbit: Alt + Left Click
- Zoom: Alt + Right Click
- Render Wireframe: Alt + 1
- Render Shaded Wireframe: Alt + 2
- Render Unlit: Alt + 3
- Render Shaded: Alt + 4

Scene Tools:

- Grabby Hand: Q
- Move: W
- Rotate: E
- Scale: R
- Rect: T
- Transform: Y
- Toggle Pivot or Center: Z
- Toggle Global or Local: X

Windows:

- Scene Window: Ctrl + 1
- Game Window: Ctrl + 2
- Inspector Window: Ctrl + 3
- Hierarchy Window: Ctrl + 4
- Project Window: Ctrl + 5
- Animation Window: Ctrl + 6
- Profiler Window: Ctrl + 7
- Audio Mixer Window: Ctrl + 8
- Lighting Window: Ctrl + 9
- Package Manager Window: Ctrl + 0

Animation:

- Play: Space
- Keyframe Selected: K
- Keyframe Modified: Shift + K

Input Action Window:

- Save : Ctrl + s
- Add Action Map: Alt + M
- Add Action: Alt + A
- Add Binding: Alt + B

# 🎼 C# Syntax

## Types

[📓](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/built-in-types)

### Overview

Types in C# define what kind of information can be stored in a variable. It is important to note, there are two
categories of types: Value types and Reference Types. Value types can be thought of as variables that are the data
itself. Assigning a value type variable to another variable duplicates the data. Reference type variables point to the
location where the actual data is stored. Passing around or assigning multiple variables to a reference type just moves
around and duplicates this pointer without changing or duplicating the data itself. Here are good ones to know:

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

(String Formatting
Documentation: [📓](https://learn.microsoft.com/en-us/dotnet/standard/base-types/composite-formatting))

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
Quick and easy way to group variables together. They're mostly intended
for [returning multiple values from a function](#multiple-return-values), but they can be used anywhere. Honestly they
are the most underrated language feature I love them.

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

IMO these make coding more enjoyable but code less easy to read.
var: [📓](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/declarations#implicitly-typed-local-variables)
new: [📓](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/new-operator#constructor-invocation)

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

Properties allow you to specify custom behavior for reading or writing to a value while still appearing as a variable to
code in other classes. They are not actually a variable and do not hold any data themselves. For that, they need a
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

Functions are modular sections of code that can be called elsewhere. They are composed of two parts: the signature and
the code block.

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
value types. This means struct variables have the data of the struct directly tied to them. If you assign a struct
variable to another variable it will copy the object, and either could be modified independently. Class variables are
just pointers to the location where the real data is stored. Assigning a class variable to another variable just results
in both variables pointing to the same data. If you modify one variable the changes are present in the other variable.

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

Interfaces are a set of methods a class promises that it has. This is useful for making the same code work for multiple
classes.

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

Collections are built-in classes to organize/list data. There are a ton of them, but here are the most common ones along
with common functions you may see. Check the documentation for a complete list!

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
never required, but they can make switch statements, properties, and delegates with simple functionality much more
readable. I am not totally comfortable with them and they are much more powerful than these examples show, this is just
the tip of the iceberg.

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
Scenes are assets that store a heirarchy of gameobjects that make up a level or area, as well as some settings such as
the skybox and light maps.

You can create a scene by clicking File > New Scene > Select a Template > Create. Save any open scene(s) by pressing
Ctrl+S or clicking File > Save. Open a scene by double-clicking the scene asset in the assets pane or clicking File >
Open Scene.

## Scene Templates

[📓](https://docs.unity3d.com/Manual/scene-templates.html)  
Scene Templates allow you to create a blueprint for the starting settings and objects in a scene that can be selected
from in the scene creation window.

To create a scene template, right-click a scene asset in the assets pane and click Create > Scene > Create Template from
Scene.

Edit a scene template by selecting it in the assets pane. The top section specifies the template name, description, and
the thumbnail that will appear in the scene creation window. The bottom section contains a list of assets in the
template, along with tickboxes to specify if they are cloned or not. Objects that are not cloned will behave a bit like
prefabs. If the object is modified in the scene template, those changes will also show up in scenes created from that
template. However, if the object is cloned, any changes to the scene template will not be copied over to the created
scene.

## Multiple Scenes

[📓](https://docs.unity3d.com/Manual/setupmultiplescenes.html)  
You can have multiple scenes open at once! This is useful for managers or UI or anything that should persist between
levels. To open a second scene, just click and drag it into the scene hierarchy.

When multiple scenes are open, the lighting and skybox settings are pulled from the active scene. You can set the active
scene by right-clicking it in the scene hierarchy and clicking Set Active Scene.

Right-Click a scene and select Remove Scene to remove it.

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
GameObject is the base class anything in the scene must be derived from. This includes lights, particle systems,
characters, levels, props, or anything in the scene hierarchy. Because GameObjects are so universal, they are also very
generic, so there is not much functionality to cover, but here are a few useful things about them!

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
MonoBehaviour is a base class that all components in Unity derive from. It automatically calls many functions that fire
for certain events or give information. The most common of these are the Start() and Update() functions. It also handles
coroutines and the GetComponent() function.

To create a new MonoBehaviour, click Assets > Create > Scripting > MonoBehaviour Script. The name of this new file must
match your MonoBehaviour's name, so pick a good one. To attach it to a GameObject, click and drag your script file from
the assets pane onto the GameObject in the scene hierarchy, or onto the bottom of the inspector pane if you have a
GameObject selected.

## Messages

These are not all the events that MonoBehaviour will send, but I think these are the most important ones. They are
listed in the order they are called.

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

//Physics Loop
void FixedUpdate(){}//called on every physics loop before the interal physics is advanced
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

To edit a prefab, double-click the prefab in the assets pane. To edit a prefab with the surroundings of one of its
instances still visible, click that instance in the scene hierarchy, and click open at the top in the inspector pane.

To remove all prefab behavior from a prefab instance, right-click an instance in the scene hierarchy and select Prefab >
Unpack Completely.

## Overrides

Prefab instances can be altered from the prefab asset they were created from. You can do this by adding, removing, or
altering the exposed variables of any component on any object in the prefab. You cannot remove or re-parent objects
though. Overridden settings will be bolded in the inspector pane.

To manage overrides, select a prefab instance in the scene hierarchy, and click the Overrides button at the top of the
inspector pane. This will show you everything that is overridden in the instance, and allows you to revert it to the way
it is in the prefab, or apply those changes to the root prefab asset so all other instances have that change as well.

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
- A **control** is an individual sensor or group of sensors on a device. Most commonly these are buttons, but they also
  include joysticks, triggers, and mouse movement.
- An **action** is a verb or, well, action, that happens in your game. Common ones are "Move", "Jump", and "Fire".
  Actions have a type as well. They can be a bool, float, Vector2, and other exotic things I've never used.
- An **action map** is a group of actions that go with a scenario in your game. By default, there are two: "Player"and "
  UI". Additional ones could be "Vehicle", "Battle", or "Editor".
- A **binding** is a link between an action and a control. The most common example is a bool action triggered by a
  button. One action can have multiple bindings. These can be for different devices or multiple controls on the same
  device.

## Theory

The idea behind the Input System is to have one actions asset for your entire project, with all the actions maps,
actions, and bindings for your project in one location. Your game will listen to different action maps in different
situations, as you define in your code. You can have one action map active at a time, or listen to multiple at once. You
can also have the game listen to one input device at a time, or allow mixed inputs from multiple devices. Every input
you need for your game should live as an action under some action map in this action asset. How you choose to use the
structure is up to you. You can have a lot of action maps, or just make one large action map with all your actions in
it.

## Setting up Actions

Unity 6 will generate an actions asset for you in the Assets folder of your project. Double-click it to open it. Save
your changes or enable Auto Save in the top right.

To add an Action Map, click the Plus at the top of the Action Maps section, type in a name, and press enter. Left-click
an action map to edit its actions.

To add an action, click the plus at the top of the Actions section, type in a name, and press enter. To edit an action,
left click it, and options will appear in the Properties panel on the right. Select button to make it a simple on or
off, or select value to make it a float, Vector2, or another type. Here you can also add Interactions to make things
like double click or hold, and Processors to invert, normalize, add deadzones, and more to input values.

To add a binding, select an action and click the plus to the right of its name. Most of the time you will just want to
click Add Binding, but if you wish to make a multi-key combo, like WASD for movement, click Add Composite (Modifier
bindings are used for things like Shift+Click. I've never used them). Left-click a binding to edit it, and its settings
will appear in the Properties section on the right. Click the box to the right of path and navigate through the menus to
select which input you would like, or search for it at the top. Below that it asks which control scheme you wish for
that binding to be active in. Select the scheme that matches the input device you set the bind for. Interactions and
Processors can be added for individual bindings as well below.

## Implementation in Code

[📓](https://docs.unity3d.com/Packages/com.unity.inputsystem@1.11/manual/Workflows.html)  
Unity intends for there to be 3 different ways for you to interact with the Input System, each with different pros and
cons. The next 3 sections will each cover one. They are using the Actions API, PlayerInput Events, and Quick & Dirty
Hardcoding. The Actions API is the recommended method and has all input behavior defined in code, as opposed to having
links in the editor, which can make debugging easier. It also allows for more custom behavior. However, it does require
more code. PlayerInput Events lets you set up events that will trigger your code when needed. This results in less code,
but can make de-bugging trickier. This approach does have a baked in solution for local multiplayer when combined with
the PlayerInputManager. Quick & Dirty Hardcoding completely bypasses action maps, actions, and bindings, and just lets
you quickly check if a button is pressed. This is good for prototyping and game jams, but shouldn't be used for anything
serious.

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
For this to work, *single*-click your actions asset to see its settings in the inspector. Tick the box labelled Generate
C# Class. Put in a class name you would like (and optionally a file name or namespace). I'll use SampleKitInputs. Then
click apply. For your script, all you have to do is this:

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

Now, in the Unity Editor, select the GameObject with your Player Input Component. In the inspector, go to the
PlayerInput component, and expand the section for Events. Open the Action Map you want, scroll down to the action you
want, and click the plus at the bottom of the box below it. Drag the GameObject with your input script into the field
that says "None (Object)". Now click the dropdown to the right of that field. Hover over your input script, and then
select the appropriate method from the section at the top labelled Dynamic CallbackContext. If you don't see it, make
sure it matches the function above. All Done! ^-^

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
Beyond the basic arithmetic operators built into C# (+,-,*,/,%), the rest of the Math functionality for floats is found
in the Mathf class. These are what I think are the most useful features of it. Full list is in the documentation as
always. :)

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

(By the way, if u are working with doubles instead of floats, there is an identical matching set of functions for them
under
the Math class without the f :3)

## Vectors

[📓](https://docs.unity3d.com/ScriptReference/Vector3.html)  
These examples will use the 3D Vector Vector3, but most of these functions (excluding Dot(), Cross(), ProjectOnPlane(),
and Slerp()) will work with Vector2 and Vector4s as well!

3D Vectors in Unity can be thought of as Points or Directions, and it is used to represent both. Sometimes the math is
the same for both, and sometimes Unity will have different functions for points or directions. For instance, use Lerp()
when your Vector3 is a point and Slerp() when your Vector3 is a direction. If your math doesn't quite work, make sure
you aren't mistreating your directions or points!

### Basics

```csharp
//creating and modifying a vector
Vector3 vector = new Vector3(1f,1f,1f);

vector.x = 2f;//transform.position and transform.scale don't allow you to edit components directly like this
vector.y = 3f;//but you can with any Vector3 that you create and most other Vector3s in Unity.
vector.z = 4f;

Debug.Log("Vertical Component is "+vector.y);
```

Vectors in unity, like all math classes, are [structs](#classes--structs), which means they
are [value types, not reference types](#object-instances).

```csharp
Vector3 vecA = new Vector3(1f,1f,1f);
Vector3 vecB = vecA;//copies vecA into vecB
vecA.y = 2f;
Debug.Log(vecB.y);//prints 1f;
```

Vectors can be added or subtracted only from other vectors. They can only be multiplied or divided by scalars (ints or
floats).

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
Quaternions are 4 dimensional unit vectors that lie on the surface of a 4 dimensional sphere with a radius of one. By
the magic of group theory, those vectors can be used to represent rotations for objects in 3D space. Fortunately, Unity
hides all that complexity, and gives us an API to work with them in a simple way. remember, they are not Vector4s, they
work differently and have different rules!

Quaternions are used exclusively for working with rotations in Unity. They are better than Euler Angles because they
interpolate smoothly from one rotation to another, they never experience gimbal lock, and they don't have any issues
with wrapping around 360 degrees. For these reasons, I will only be covering Quaternions.

Quaternions can be thought of as not storing rotations, but storing a rotational movement from a starting rotation, if
that makes any sense. It is the rotational equivalent of storing a distance, not a location. If you just have one
Quaternion, it represents a movement from the default (identity) rotation to a new rotation. When you combine
Quaternions, these movements can instead start from a different rotation. This is how you do math with Quaternions, by
combining different rotational movements to build a new rotation. If you play with this idea in your head, you can see
why Quaternion combinations are not commutative. The order in which you apply them matters.

There are almost no circumstances where you will create or modify the individual components of a Quaternion. In 99% of
cases it is better to start with existing rotations from GameObjects or Quaternion functions and manipulate those. If
you are a member of the 1%, here is how to do it anyways.

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
Quaternion defaultRot = Quaternion.identity;//same as a Euler rotation of 0,0,0
Quaternion y90 = Quaternion.AngleAxis(90f, Vector3.up);//creates a rotational movement 90 degrees around the y axis.
                              //when multiplied with another Quaternion, it will rotate it around the axis by the given angle.
Quaternion ew = Quaternion.Euler(20f,30f,45f);//creates a quaternion from a euler rotation. 
                              //rotation around each axis is applied in the order Z -> X -> Y
Quaternion sbin = Quaternion.FromToRotation(transform.up,Vector3.up);//creates a rotational movement that if applied to the
                              //first vector, will rotate it so that it is aligned with the second vector.
Quaternion look = Quaternion.LookRotation(transform.forward, Vector3.up);//creates a rotation defined by a forward and up vector.
                              //Note: the vectors do not have to be orthogonal, Unity will match forward and do its best with up.
```

Quaternions do not have any defined addition, subtraction, or division operators. They do use the multiplication
operator,
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

[📓](https://docs.unity3d.com/ScriptReference/Matrix4x4.html)  
Matrices are a mathematical structure that stores a small grid of numbers. Unity has a few Matrix types, but by far and
away the most common of them is Matrix4x4, so I will be covering that. Matrices are most used for representing
transformations(positions, rotation, scale) of objects in various coordinate spaces (world, local, view); Here is how to
use them in Unity!

Matrices in Unity are column-major and use homogenous coordinates. For the 4x4 matrix, the first column represents the X
axis, second the Y axis, third the Z axis, and 4th the translation.

```csharp
//creation
Matrix4x4 emptyMat = Matrix4x4.identity;
Matrix4x4 identityMat = Matrix4x4.identity;
Vector4 column0, column1, column2, column3;
Matrix4x4 initialized = new Matrix4x4(column0,column1,column2,column3);

Vector3 position;
Quaternion rotation;
Vector3 scale;
Matrix4x4 posMat = Matrix4x4.Translate(position);//creates a translation matrix that translates by the specified point
Matrix4x4 rotMat = Matrix4x4.Rotate(rotation);//creates a rotation matrix that matches the specified quaternion's rotation
Matrix4x4 sclMat = Matrix4x4.Scale(scale);//creates a scaling matrix that has the same scaling as the specified scaling vector
Matrix4x4 allTogetherNow = Matrix4x4.TRS(position,rotation,scale);//creates a full transformation matrix with the specified
                                        //position, rotation, and scale
Vector3 fromPos, toPos, upDirection;
Martix4x4 peep = Matrix4x4.LookAt(fromPos,toPos,upDirection);//creates a transform matrix at fromPos looking at toPos

//these use the OpenGL convention. these may be wrong if Unity is using another graphics API. Use GL.GetGPUProjectionMatrix if so
float fov, aspectRatio, nearClippingDist, farClippingDist;
Matrix4x4 perspective = Matrix4x4.Perspective(fov, aspectRatio, nearClippingDist, farClippingDist);//creates perpective view matrix
float leftCoord, rightCoord, bottomCoord, topCoord, nearDist, farDist;
Matrix4x4 ortho = Matrix4x4.Orthographic(leftCoord, rightCoord, bottomCoord, topCoord, nearDist, farDist);
Matrix4x4 viewMat = Matrix4x4.Frustum(leftCoord, rightCoord, bottomCoord, topCoord, nearDist, farDist);//different that Ortho somehow?
```

```csharp
//variables
FrustumPlanes projectionFrustum = mat.decomposeProjection;//if  a projection matrix, returns the 6 planes that define the frustum
float determinant = mat.determinant;//determinant. yup.
Matrix4x4 inverse = mat.inverse;//returns a new matrix that is the inverse of mat
bool isIdentity = mat.isIdentity;//returns true if mat is an identity matrix
Vector3 lossyScale = mat.lossyScale;//attempts to return scaling in a Vector3. may be wrong if other transformations are applied.
Quaternion rotation = mat.rotation;//gets just the rotation described in this matrix
Matrix4x4 transpose = mat.transpose;//returns a new matrix that is the transpose of mat

int a,b;
float element = mat[a,b];//gets an element of the matrix. a is the row, b is the column. both must be between 0->3 inclusive.
```

```csharp
//functions
Vector4 lastColumn = mat.GetColumn(3);//returns the nth column. parameter is an int thats 0->3 inclusive
Vector4 firstRow = mat.GetRow(0);//returns the nth row. parameter is an int thats 0->3 inclusive
Vector4 bla = Vector4.one;
mat.SetColumn(0,bla);//replaces the specified column with the Vector4 given.
mat.SetRow(3,bla);//replaces the specified row with the Vector4 given.

Vector3 pos = mat.GetPosition();//returns the position encoded inside of this matrix
Vector3 newPoint = mat.MultiplyPoint(Vector3.one);//returns the point multiplied by this matrix
Vector3 newDirection = mat.MultiplyVector(Vector3.up);//returns the direction multiplied by this matrix.
Plane plane;
Plane newPlane = mat.TransformPlane(plane);//transforms a plane with this matrix

Vector3 position;
Quaternion rotation;
Vector3 scale;
mat.SetTRS(position,rotation,scale);//sets this matrix to be a translation-rotation-scale matrix with the specified 
                            //position, rotation, and scale
bool isTRS = mat.ValidTRS();//returns true if this matrix is a valid translation-rotation-scale matrix
```

## Time

[📓](https://docs.unity3d.com/ScriptReference/Time.html)  
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

[📓](https://docs.unity3d.com/ScriptReference/Random.html)  
Unity has a Random class for all the fun quirky random needs you may have. Note: there is also a built-in C# class
called Random, and if you are `using System;` in your script, they will conflict. To use Unity's, either don't include
System, call it using UnityEngine.Random, or put `using Random = UnityEngine.Random;` at the top of your file.

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

These are some miscellaneous math classes you may run into but are not super common.

### Ray

[📓](https://docs.unity3d.com/ScriptReference/Ray.html)  
A Ray represents an infinite line starting at one point, and then going off to infinity in some direction.

```csharp
Vector3 point;
Vector3 direction;
Ray ray = new Ray(point, direction);

ray.origin = Vector3.one;//ray starting point
ray.direction = Vector3.up;//ray direction

Vector3 alongBy10 = ray.GetPoint(10f);//returns a point some distance along the ray from its starting point.
```

### Rect

[📓](https://docs.unity3d.com/ScriptReference/Rect.html)  
Rect is a class that represents a 2D rectangle. It simultaneously supports two ways to represent the rectangle. One way
is specifying a point, and then storing the width and height of the rectangle from that point. The other is storing the
x coordinate for the left and right sides of the box, called xMin and xMax, and the y coordinates of the top and bottom
of the box, called yMin and yMax. You can use either representation method or use them interchangeably with the same
Rect object.

```csharp
//create a Rect
float pointX, pointY, width, height;
Rect rect = new Rect(pointX, pointY, width, height);
float xMin, yMin, xMax, yMax;
Rect rect2 = Rect.MinMaxRect(xMin, yMin, xMax, yMax);
```

```csharp
//variables
float pX = rect.x;//x coord of point size representation. Modifying this will translate the rect
float pY = rect.y;//y coord of point size representation. Modifying this will translate the rect
float w = rect.width;//width of point size representation. Modifying this will resize the rect
float h = rect.height;//height of point size representation. Modifying this will resize the rect

float xMi = rect.xMin;//left side coord . Modifying this will resize the rect
float yMi = rect.yMin;//bottom side coord. Modifying this will resize the rect
float xMa = rect.xMax;//right side coord. Modifying this will resize the rect
float yMa = rect.yMax;//top side coord. Modifying this will resize the rect

Vector2 center = rect.center;//center point of the rect
Vector2 min = rect.min;//bottom left point of the rect
Vector2 max = rect.max;//top right point of the rect
Vector2 size = rect.size;//the width and height of the rect
```

```csharp
Vector2 point = new Vector2(0f,1f);
bool inside = rect.Contains(point);//returns true if the point is in the rect, false otherwise
Rect rect2;
bool overlap = rect.Overlaps(rect2);//returns true if the two rects overlap each other
```

### Bounds

[📓](https://docs.unity3d.com/ScriptReference/Bounds.html)  
This class is similar to Rect, but for 3D. It represents an axis-aligned bounding box, which you may have seen
abreviated as AABB. Since the box is never rotated, it can be represented with just a center point and a size.

```csharp
Vector3 centerPoint;
Vector3 sideLengths;
Bounds bounds = new Bounds(centerPoint,sideLengths);
```

```csharp
Vector3 center = bounds.center;//center point of the bounds.
Vector3 size = bounds.size;//lengths of the 3 sides of the bounding box
Vector3 extents = bounds.extents;//half the length of the sides. always equivalent to bounds.size/2f;
Vector3 min = bounds.min;//the corner of the box that has the smallest x,y,and z coords. equal to center - extents.
Vector3 max = bounds.max;//the corner of the box that has the largest x,y,and z coords. equal to center + extents.
```

```csharp
Vector3 closest = bounds.ClosestPoint(Vector3.one);//returns closest point on or inside the bounds
bool inside = bounds.Contains(Vector3.one);//returns if the point is inside the bounds or not
bounds.Encapsulate(Vector3.zero);//grows the bounds to include the point if it is not included already
bounds.Expand(5f);//grows the length of each side by the specified amount
Ray ray;
bool touches = Bounds.IntersectRay(ray);//returns true if the ray intersects these bounds
Bounds bounds2;
bool intersect = bounds.Intersects(bounds2);//returns true if the two bounds intersect each other at all
float sqrDist = bounds.SqrDistance(Vector3.one);//returns the distance to the closest point on or in the bounds squared.
```

### Plane

[📓](https://docs.unity3d.com/ScriptReference/Plane.html)  
This class just represents a mathematical plane that extends off to infinity. It has a normal vector that is orthogonal
to the plane, and a single point that the plane goes through. This is enough information to define any plane.

```csharp
//creating a plane
Vector3 normal = Vector3.up;
Vector3 point = Vector3.one;
Plane plane = new Plane(normal, point);
```

```csharp
//variables
float dist = plane.distance;//smallest distance from the plane to the origin
Plane flip = plane.flipped;//returns this plane with its normal vector inverted
Vector3 normal = plane.normal;//the normal vector of the plane
```

```csharp
//functions
Vector3 closest = plane.ClosestPointOnPlane(Vector3.one);//returns the closest point to the specified point on the plane
plane.Flip();//flips the normal vector of the plane
float signedDist = plane.GetDistanceToPoint(Vector3.one);//returns the distance to the point from the plane. 
                                                //distance is negative if the point is below the plane.
bool side = plane.GetSide(Vector3.one);//returns if the point is above the plane or not

float enterDist;
Ray ray;
bool intersects = plane.Raycast(ray, out enterDist);//returns true if the ray intersects the plane. 
                               //if it does, enterDist is set to the distance along the ray the intersection occured at
```

# 📄 2D

[📓](https://docs.unity3d.com/6000.0/Documentation/Manual/Unity2D.html)  
I could honestly make an entire other cheat sheet on just 2D stuff, but here is an overview of the most important things
for making 2D games in Unity!

## Perspective

2D games are made with the orthographic perspective. That means things do not get smaller as they get further from the
camera. This is necessary so players can't feel how flat the game truly is. When making a 2D game, there are still all
kinds of perspective styles you can choose. There is top down, where you look at the world from the perspective of a
cloud. The straight side on view from Mario is a classic. You can pick a middle ground between side view and top down
that looks down at the world at an angle, like in Stardew Valley. If you then rotate the Camera on an imaginary vertical
axis, your camera is angled in two different axises, and the result is the Isometric Perspective, as seen in Monument
Valley. If you have another idea, feel free to try it, the only rule here is that it must be fun!

## Depth

In order to make a 2D game in Unity, you don't have to change anything in the editor. Just enable the "View Options"
scene view toolbar and hit the 2D button. This just changes the scene view Camera to be orthographic and to look down
the Z axis. 2D games in Unity are still 3D and fully capable of being a 3D game. This means it is possible to make 2.5D
games, but it also means every 2D Unity game still has the third dimension. The Z coordinate is used to determine which
sprites are drawn on top of which other sprites. The term for this is [sorting](#sorting).

## Sprites

[📓](https://docs.unity3d.com/6000.0/Documentation/Manual/sprite/sprite-landing.html)  
Sprites are just 2D images for your 2D game. It may seem simple, but they can get kinda complicated!

### Asset Import

[📓](https://docs.unity3d.com/6000.0/Documentation/Manual/sprite/import-images-sprites/import-images-sprites-landing.html)  
If you just drag and drop an image into your Unity project, it won't work as a sprite. You must first change its import
settings. Single click the image in the assets pane, and its import settings will appear in the inspector pane. Change
the Texture Type at the top from Default to Sprite (2D and UI). When you do this, new options will appear. Change the
pixels per unit variable to determine how large your sprite is rendered in the world. The higher the number, the smaller
it will be. Click the button labelled Open Sprite Editor. A preview of your sprite will appear. Left-click hold the top
left of your sprite, drag to the bottom right of your sprite, and release. A bounding box defining your sprite will
appear. You can click and drag the corners to adjust it. This is the workflow for simple object sprites, there is more
you can do later with tile maps and 9-slicing. When you are happy, click Apply in the top right, and close the sprite
editor. Back in the inspector, tick the Alpha is Transparency box if your sprite has any transparency in it. The other
important settings are found at the bottom. Wrap mode changes how the texture behaves if it ever encounters UV
coordinates above 1 or below 0. Filter mode changes how the artwork is sampled by Unity for rendering. If you are using
pixel art, make sure you change this from Bilinear to Point. Below this are the texture's compression options, but the
defaults for those are usually fine. IMPORTANT: After you change any of these asset import settings, you must hit the
Apply button at the very end below all the settings for any changes to be saved!!!

### Adding to a Scene

If your import settings are set up correctly, you can just drag your sprite from the assets pane into the scene or the
scene hierarchy! ^-^

### Sorting

[📓](https://docs.unity3d.com/6000.0/Documentation/Manual/sprite/sort-sprites/sort-sprites-landing.html)  
There are a few ways to sort which sprites render on top!

Sprites with higher Z axis coordinates will render on top of sprites with lower Z axis coordinates.

If two sprites have the same Z axis coordinate, Order is determined by the Order in Layer field in their Sprite Renderer
Component. Higher values are rendered on top of lower values. You can also group sprites into sorting layers. Assign a
sorting layer to a sprite in its Sprite Renderer Component. You can change the Sorting Layer order by going to Project
Settings > Tage and Layers > Sorting Layers. Sorting layers take priority over Order in Layer.

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
resized, the corners just move without changing shape, the edges tile only along the axis they are parallel to, and the
center tiles in both directions to fill the space. This is a very powerful technique for making 2D levels and
backgrounds, as one sprite can be used to make entire levels of a game.

In order to set up 9-Slicing, drag and drop your 9-Slice sprite artwork into the assets pane and follow
the [sprite import instructions](#asset-import) above. When you are finished, under the Sprite Mode section, change Mesh
Type from Tight to Full Rect. Then click the Open Sprite Editor Button. Along the edges of your sprite bounds you should
see green dots. Click and drag those in towards the center of your sprite. After doing this for all 4 edges, you should
have green lines defining 9 rectangular sections of your sprite within the sprite bounds. Click Apply in the Sprite
Editor, close it, and click Apply on the Sprite Import Settings.

To use your 9-Sliced sprite, click and drag it from the assets pane into the scene. Go to its Sprite Renderer Component,
and change the Draw Mode from Simple to either Sliced or Tiled. Sliced will stretch the individual sections of the
9-Slice, and Tiled will tile them. Choose one, change the size of your sprite, and see how it looks! NOTE: 9-Slicing
only works when you change the width or height of the sprite in the SpriteRenderer component or using the Rect tool in
the scene window. Scaling the transform will still stretch the sprite.

## Sprite Sheets

Sprite sheets allow you to have many sprites and/or sprite animation frames all on one image file. This is better for
performance, since the GPU just has to shift UV coordinates instead of uploading an entire new image for each sprite or
animation frame.

In order to set up a sprite sheet, drag and drop your sprite sheet file into the assets pane and follow
the [sprite import instructions](#asset-import). After you are finished, click the Open Sprite Editor Button. In the top
left, click the Slice Button. The first option is Slice Type. There are a few options, but I find Grid by Cell Count
easiest, so we will do that. Click the dropdown next to Type and choose Grid by Cell Count. Put in the number of columns
and rows of sprites on your sprite sheet, and include any offsets or padding if you used those when drawing. When you
are happy with where the red lines are slicing your sheet, hit slice! Now your sprite is a grid of individual sprites.
You can now go in and individually change the bounds of any sprite, or even 9-slice some of them. When you are happy,
hit Apply in the top right and close the Sprite Editor.

Now, your sprite sheet asset in the assets pane will have an arrow pointing to the right over the image. Click that to
expand it. A list of every sprite in the sprite sheet will appear in the assets pane. Click and drag any of them into
your scene to add them, just like with any other sprite!

## Tile Maps

[📓](https://docs.unity3d.com/6000.0/Documentation/Manual/tilemaps/tilemaps-landing.html)  
Tile Maps are a package in Unity that allows you to turn sprite sheets into a set of brushes to quickly paint levels!I'm
just going to go over rectangular tile maps here, but there are also hexagonal and isometric tile maps as well! Check
the documentation or look up guides for those styles if you need them.

To create a tile map, Click GameObject > 2D Object > Tilemap > Rectangular. This creates a grid and a Tilemap below it.
You can have multiple tilemaps per grid for different layers. To do that, right-click the Grid gameobject in the scene
hierarchy, then click 2D Object > Tilemap > Rectangular.

Select your tilemap gameobject in the scene hierarchy. In the bottom right of the scene view, there will be a little
button that says Open Tile Palette. Click it! This window has the tile palette for your tilemap. Drag and drop any
number of sprites or sprites from a spritesheet into the section where it says to do so. The editor will prompt you to
select a folder. It doesn't tell you this, but it is about to put a ton of new files in whatever folder you select, so
make sure to make a new folder for your tilemap and choose that one.

Once you have some sprites, the tile palette is split into three sections. The top one has a bar of tools that you can
use to paint your tilemap with sprites. There is also a dropdown to select which tilemap you are editing if you have
multiple. The middle section is a grid of every sprite in your tile palette. You can keep dragging more sprite assets in
here to build your palette. There is a dropdown to switch which tile palette you are painting with. Tile maps and tile
palettes are totally separate from each other, so you can make multiple tile palettes to your liking and use them on any
tile map in your game! To the right of that dropdown there are 3 buttons. The pencil button lets you use the tools in
the top bar to edit and move the sprites in your tile palette instead of sprites in the tile map. Use this to organize
your palette. The other two buttons are options to show the grid and show gizmos in your palette. The bottom section
holds scriptable brushes. There are a few defaults, but you can also create your own or find some online. Press the gear
icon to hide this section if you aren't using it.

If you aren't happy with the size of your sprites in a grid space, change their pixels per unit in their import
settings. By default, one tilemap cell is one unit by one unit. If you would like to change this, select the Grid
gameobject in your scene hierarchy and change the grid size.

A quick note on Physics: you can add a TilemapCollider2D Component to your tile map gameobject, and it will
automagically generate colliders for every tile in your tile map!!

## Sprite Shapes

[📓](https://docs.unity3d.com/Packages/com.unity.2d.spriteshape@3.0/manual/index.html)  
If you want an alternative to tilemaps that is less of a rigid grid and allows for fluid curves and angles, sprite shape
is for you!Sprite Shapes is a package that lets you set up sprites to be drawn along lines you draw in the editor in any
shape you please. There is a lot of depth and functionality here I'm going to gloss over, but know there are a lot more
options if you need them!

There are two parts to make a sprite shape: sprite shape profiles and sprite shape controllers. Sprite shape profiles
can be thought of as the material for your sprite shape. To create one, click Assets > Create > 2D > Shape Sprite
Profile. There sure are a lot of settings to tweak, lets go through them! The fill sprite is what is tiled to fill in a
closed shape. If you make an open shape (a line), this goes unused. Below that there is a large circle. The way this
works is you can define an angle range by dragging the handles at the bottom or typing in values at the bottom. The blue
handle at the top is your preview angle. If you drag the preview angle beyond your allowed angle range, a Create Range
button appears. Click this to add another set of handles to define a second range!Each angle range has its own sprite(s)
that it uses. You can assign the sprite(s) it will use below the angle limit variables. This allows you to use different
sprites for flat ground versus steep slopes or walls. Also, make sure any sprites you use are set to the Full Rect mesh
type, and have their wrap mode set to Repeat. There are also options below this to use bespoke sprites for various
corner types if you use any sharp corners.

Create a sprite shape controller by clicking GameObject > 2D Object > Sprite Shape > Open Shape or Closed Shape. Open
shapes are just lines with control points. Closed shapes are polygons with a closed interior that will be filled with
your fill sprite. Select your shape after you create it and look at its Sprite Shape Controller component. Assign you
sprite shape profile to the variable named profile. under that there is a button to edit the shape. Click that. You can
drag any control points to anywhere you like. Click on a line between two points to add a new control point there. Press
the delete key with a control point selected to delete it. In the bottom right of the scene view, you can select which
type of control point you would like it to be and manually type in values for it. There are other options in the sprite
shape controller but honestly the defaults seem fine.

Attach a PolygonCollider2D or an EdgeCollider2D to you sprite shape controller to enable collision!

## Animations

2D animations are actually super easy to do! Easy once you have the sprites done 😬. Animations in general are covered in
the main [Animations](#-animations) section, but here is how to set up an animation for sprites specifically.

To set up your animated character or whatever, you could add an Animator component to your gameobject with a Sprite
Renderer, create an Animation Controller Asset, assign that controller to the Animator Component, Click Window >
Animation >Animation to open the Animation Window, select your character, click Create Animation, save the file in your
project, click Add Property, select the Sprite variable under Sprite Renderer, and add keyframes for each sprite of your
animation, OR, you could do the shortcut. Select multiple sprites from a sprite sheet in the asset pane, then click and
drag them into the scene hierarchy. Give your animation a name and save it somewhere nice in your project. Now all of
what I just described has been done for you automatically. Adjust the auto-generated keyframes as necessary. To make
more animations, click the dropdown in the top left of the animation window, then click Create New Clip. Give it a name
and save it. In the new clip, click Add Property, then select Sprite under Sprite Renderer. Add keyframes for the
various sprites you want. This new animation will show up in your animation controller, and you can set up the
transitions from there. Happy animating!

(If you want you can also just change the active sprite in the Sprite Renderer component in code and just make your own
animation system if you don't like how Unity does it)

```csharp
public Sprite sprite;//asign sprite asset to this in the editor
------
SpriteRenderer sr = GetComponent<SpriteRenderer>();
sr.sprite = sprite;//do this a bunch for every animation frame
```

## Physics2D

2D Physics uses all the same class, component, and collider names as normal 3D physics, just with a 2D stuck on the end.
2D Rigidbodies are Rigidbody2D, Colliders are of type Collider2D, you do raycasts with Physics2D.Raycast(), yada yada.
This means if you are comfortable with 3D physics, using 2D physics is actually a pretty easy transition! If you aren't
comfortable with 3D physics, check out the [Physics Section](#-physics). I will just be covering the specific
differences to 2D physics here.

Rigidbody2D is pretty much the same as the normal Rigidbody. Add it to things to give them physics simulation. Angular
Velocity, Rotation, and Angular Inertia are all just floats now because it's 2D. I think that's all!

All your favorite Collider types are back! BoxCollider is now BoxCollider2D, CapsuleCollider is now CapsuleCollider2D,
and SphereCollider is now CircleCollider2D! Because 2D physics is computationally so much lighter than 3D, there are
also a lot more options for colliders that don't have 3D equivalents. CompositeCollider2D will merge the shape of any
other colliders into one big collider. EdgeCollider2D lets you draw a line that will collide with things from both sides
of the line. PolygonCollider2D does the same, but instead lets you define your own wacky closed shape to match any
sprite you wish. Keep in mind, unlike with 3D physics, there is no restriction on concave colliders. You can make your
rigidbody colliders whatever wacky shape you please. Also keep in mind the Z coordinate is completely ignored for
calculations. Use layers if you need objects to pass through each other.

The Physics2D class is very similar to the Physics class. It has a lot of functions, the most useful ones being the
overlap functions, collider cast functions, and ray cast functions. These are all similar to their 3D equivalents,
except they use Vector2s instead of Vector3s. You can find documentation for all these
functions [here](https://docs.unity3d.com/ScriptReference/Physics2D.html).

There are also more joints available for 2D physics than for 3D. Unity has support for distance joints, fixed joints,
friction joints, hinge joints, relative joints, slider joints, spring joints, target joints, and wheel (suspension)
joints. Have fun!

2D physics has a concept of its own that is missing from 3D physics: effectors. Effectors are basically built in
functionality for trigger colliders. You set one up by first creating a trigger collider. Anything inside this trigger
collider will be effected by the effector. Make sure both Is Trigger and Used by Effector are both ticked. Then, all you
have to do is add an effector as a component to the gameobject. Your options are: Area effector, buoyancy effector,
platform effector, point effector, and surface effector. The area effector just constantly applies a force in a
specified direction. The buoyancy effector "simulates" a fluid with a specified density and surface level. Platform
effectors are meant for platformers. They make their colliders have one way collisions, remove side friction, remove
bounciness, and quote, "more". Don't make your collider(s) a trigger when using this effector. Point effectors will
apply a force towards a specified point, like a magnet. Surface effectors simulate a movement speed along their edges
without actually moving, useful for conveyor belts and such. Again with this one, don't use trigger colliders, make them
normal colliders.

## Lighting

[📓](https://docs.unity3d.com/6000.0/Documentation/Manual/urp/Lights-2D-intro.html)  
If you are using the 2D version of the Universal Render Pipeline (setup automatically with the 2D project template),
then Unity actually has some really cool 2D lighting options available to you! By adding 2D lights and shadows to your
scene, Unity will generate render textures on top of all your sprites to make them appear as if they are being lit and
casting shadows in certain directions. Note: This is not physically accurate AT ALL, it's just a neat aesthetic. This
only works if your project is set up in a very specific way. If you are interested, I highly recommend making your
project from the 2D template so it just works out of the box.

If your project is set up right, to add a light, just click GameObject > Light > select any light ending in 2D. Your new
light will now shine onto any sprite in its range. Keep in mind, if your sprite is white, it can't get any brighter so
you won't see anything. Spot lights are point lights that let u define an angle range for them. Sprite lights cast light
in the shape of any sprite you select. Freeform lights let you draw a polygon that will cast light a set distance away
from it. Global lights just add light to everything globally (only seems to work with the additive blend mode for some
reason?).

To add shadows, first make sure you have a 2D light in your scene that isn't a global light, and that light has shadows
enabled. Also make sure you have some kind of background sprite, shadows will not cast over the skybox. For every sprite
that you want to have shadows, add a Shadow Caster 2D component to it. Tada! Shadows! If you want shadows from multiple
objects to play nicely with each other, make sure each object also has the Composite Shadow Caster 2D component attached
to it as well in addition to the Shadow Caster 2D component.

Lights and shadows can both be restricted to various sorting layers to achieve complex layered results. The sprite Z
coordinate is not considered at all, so you must use sorting layers.

# 🎥 Rendering

## Universal Render Pipeline

## Camera

## Importing Models

## MeshRenderer

## Materials

## Lighting

### Realtime Lights

### Baked Lights

### Environment & Skybox

## Shadows

# 🏃 Animations
[📓](https://docs.unity3d.com/Manual/AnimationOverview.html)  
There are several ways to accomplish animations in Unity. You can make your own animations with the Animation Window, import
animations from blender, or even use a procedural animation system! I will go over the basics of all 3 here.

## Animation Clips
[📓](https://docs.unity3d.com/Manual/AnimationClips.html)  
Animation Clips are just the asset file type that Unity uses to store animations. They are just like Audio Clips but for
animation. They can be generated from files you import from other software, or created in Unity by using the Animation 
Window!

## Animator Component
The animator component is required to have on any object you wish to animate with Unity's animation system. for like 
99% of use cases you will be interacting with it from other places, like the [Animation Window](#animation-window) 
or the [Animator Controller](#animator-controller). This section is here for one reason: There is a legacy component 
still included with Unity called the Animation component. DO NOT USE IT. Animations made with the Animation 
component are not compatible with any of the other animations systems in the document. Make sure you are adding the 
Animat***or*** Component!

## Animation Window
[📓](https://docs.unity3d.com/Manual/AnimationEditorGuide.html)  
The Animation window lets your build animations from keyframes inside of Unity! You can access it by clicking Window > 
Animation > Animation. Now, if you click on any gameobject in the scene hierarchy, you can make animations for it here!
Note: any objects that you want to animate need an Animator Component on them. The Animation window will prompt you to do 
this if you forget. If the object has no animations yet, it will display a create button to make your first Animation Clip.
Click it, pick a name for your animation file, and save it. Now the full animation window is enabled! The right side is 
your timeline, any keyframes you add will show up there. You can select and move keyframes there. On the left you have play,
pause, and skip buttons. Next to them is a record mode that will automatically add keyframes if you change anything. Below 
that, there is a dropdown to select animation clips. Here you can switch between the animations you have for this object or
create a new one. To the right of the dropdown, there are buttons for adding keyframes and events. By default we have no
properties added to the animation. You can add any public number variable to be animated in an animation. This usually means
the position and rotation fields of the transform component, but you can also animate your own script variables as well!
To select something for animation, click add property, expand the component that has the variable you want, then click the 
plus button next to whichever one(s) you want. Now you can pose your object in the scene, move the animation playhead to 
where you would like to create a keyframe, and hit the add keyframe button. The animation length will automatically be set
to the duration between your first and last keyframes. Just close the window whenever you are done, your changes are 
automatically saved! Be sure to check out the [Hotkeys](#-hotkeys) section for some useful animation window hotkeys!

## Animator Controller
[📓](https://docs.unity3d.com/Manual/class-AnimatorController.html)  
The Animator Controller is essentially a state machine designed specifically for setting up animation systems. It can be 
added to the Animator component on any gameobject, and it will manage which animation(s) are being played on that object 
at any given time. To create one, click Assets > Create > Animation > Animator Controller. Give it a cool name and save 
it to your project. You can now click and drag it onto any Animator component for the object you want this controller to 
manage. Note: If you already created Animation Clips for an Animator component, Unity may have automatically created one
for you. Double-click the Animator Controller to open the editor for it. The Animator Component has a lot of features and 
shiny buttons, I won't go over all of them here, but I'll tell you the basics! Every block in the window represents a state.
You can click and drag any Animation Clip you wish to add into the Animator Controller and it will create a new state for 
it. The Entry state is always the state that will be active first, and can be used to transition to whichever 
animation you would like to start with. The pane on the left holds both your layers and the parameters for each 
layer. Layers let you set up multiple state machines and run them at the same time on one object. This is could be 
used, among many things, for having the animations of a characters' arms be independent of the animation for their 
legs. You can select the gear icon next to a layer to either create a mask to limit the layer's influence on the object,
or give it a weight. Parameters are variables that represent the conditions that a state will transition to another 
state. You can add a float, int, bool, or trigger parameter (triggers are essentially bools). To create a transition,
right-click on the state you would like to transition from, click Make Transition, and then click on the state you 
would like to transition to! An arrow will appear going from the first state to the second one. Click it to see its 
options. There are a lot of options to define the specific blend between the two states that would honestly probably 
get more confusing if I tried to explain them. These are the important ones:
- Has Exit Time: enables locking the transition to happen at a certain point in the animation
- Exit Time: If the previous option is enabled, this specifies the point in the animation where the state will begin 
  to transition.
- Transition Duration: How long the transition into the next state is.  

Below all these and the transition visualization, there is a conditions section. This is how you specify when this 
transition is activated. Click the little plus at the bottom to add a new condition. Select one of your parameters 
from the left dropdown. You can then choose to transition when the parameter is greater than or less than a certain 
value. We will be setting these parameters in code in the [Playing Animations](#playing-animations) section to 
actually control the state machine at runtime. Whenever you are happy, you can close the Animator Controller window 
at any time, it will auto save your changes. NOTE: you can click a state and change its playback speed, and even 
multiply it by the value of a parameter to change it dynamically at runtime!

## Playing Animations
The Animator Component will start executing the state machine(s) in its Animator Controller the second it is loaded 
and enabled. If you wish to disable animations, just disable the Animator Component like any other component. When 
you re-enable it, it will reset all your parameters and start from the Entry state again. If you want to just freeze 
the object for a bit instead, make a state with no animation and transition to that (You can do that by 
right-clicking the background of the Animator Controller window and clicking Create State > Empty). To switch what 
animation is being played, we change the value of the Animator Controller's parameters. When their values match the 
conditions for a transition from the current state, the Animator Controller will transition for us automatically! 
You can set parameter values in code just like this:
```csharp
Animator animator;
    
void Start () {
    animator = GetComponent<Animator>();
}

void UpdateParameters () {
    animator.SetFloat("ParameterName",1f);
    animator.SetInt("IntParam",0);
    animator.SetBool("isLit", true);
    animator.SetTrigger("Consumeee");//this just sets the trigger to true
                                     //triggers are automatically set back to false after the transition
    animator.ResetTrigger("Consumeee");//you can manually set them back to false like this
}
```

## Importing Animations from Blender
I'm just gonna assume you've made an animation in blender in the Action Editor and saved it as an action. This is a Unity 
cheat sheet after all, not a Blender one. Select the mesh AND the armature (and more if you want), then click File > 
Export > FBX. In the export window, make sure you have both the armature and mesh object types selected. (You may also 
wanna tick apply transform to avoid scaling weirdness.) Name you file and save it somewhere you'll remember! Now drag your 
textures and .fbx file you exported into Unity. If you click the .fbx file, you can see its import settings in the inspector.
You can click the animation tab to preview all your imported animations. Back in the assets window, your .fbx file should
have an right arrow over its icon. Clicking that will expand it to show all the assets inside of the file. This will include
you model, its generated material, its armature, and your animations! Animations will show up as little triangles that have 
go fast lines behind them. Click and drag the model from your .fbx file into the scene. Add an animator component to it, 
then create and add an [Animator Controller](#animator-controller), and open the animation controller. You can click and 
drag any animations from your .fbx file into the controller, and set them up how you would with any other animation!

## Rigging for Procedural Animation
[📓](https://docs.unity3d.com/Packages/com.unity.animation.rigging@1.0/manual/index.html)  
If instead of switching between pre-made animations with an Animator Controller, you want to use procedural 
animation (or a mix of both), you will need to set up your character's rigging inside of Unity. To get started, 
make sure you have the Animation Rigging package installed. Then import your character from Blender *with* its rig. 
Add your imported model into the scene hierarchy. Make sure both your mesh and armature are children of the root 
gameobject in the scene. Then, add the Animator component, Rig Builder component, and Bone Renderer component to that 
root gameobject. Now, select *every* bone in your armature, and click and drag them into the Transforms field of the 
Bone Renderer component. We will now create the rig inside Unity. (Note: this is a bit confusing, but the "rig" is 
not the armature of the model. It is a list of entirely new gameobjects that have components that define constraints 
for all of the bones in the armature.) Create a new gameobject that is a child of the root gameobject and call it 
something along the lines of "Rig". It should be a sibling of the armature. Now, add a Rig component to it. Then 
click and drag this rig gamobject into the Rig Layers field of the Rig Builder component on the root gameobject. You 
can now add constraints as children to the rig gameobject you just created, and they should work! There are a ton of 
constraint types, and you will need different ones depending on the armature of your character and what you want to 
be procedurally animated. You can see all the options by clicking the Add Component bottom at the bottom of the 
inspector, and clicking the Animation Rigging tab (make sure the search field is empty for this to work). Generally, 
the constrained object(s) field is a gameobject from the armature hierarchy of your model, and targets can be any 
old gameobject you want. If you need more help for a specific use case, look up "unity procedural animation rigging" 
on Youtube!

## Animating Variables
Sometimes when you are making a game, you need to smoothly animate the value of a variable over time. You could setup
an entire Animator Controller and make an animation for it, but that is clunky and not very dynamic. The first thing 
you might try is to make a timer variable and an if condition in your script's Update() function, and while that does 
work, there is a better way. Use [coroutines!](#coroutines) I won't go over coroutines again here, they are covered in
the [coroutines section](#coroutines), but here is some example code for how to use one to animate a variable.
```csharp
//linear animation function
IEnumerator AnimationCoroutine(ref float target, float endingValue, float time){
    float timer = 0;
    float startValue = target;//keep track of the starting value for the lerp function
    while(timer <= time){
        timer += Time.deltaTime;
        target = Mathf.Lerp(startValue, endValue, timer/time);//timer/time is our animation progress %
        yield return null;
    }
}
------
//put this wherever you want to animate a variable
float animateMe = 0f;
IEnumerator coroutine = AnimationCoroutine(ref animateMe, 4f, 1f);
StartCoroutine(coroutine);//this will start animating animateMe from 0 to 4 over 1 second
```
That example uses Lerp, which does linear interpolation, but you can use any other function you like! Unity has another
on built in called SmoothStep(), which animates in an S-Curve shape.
```csharp
IEnumerator AnimationSmooth(ref float target, float endingValue, float time){
    float timer = 0;
    float startValue = target;//keep track of the starting value for the lerp function
    while(timer <= time){
        timer += Time.deltaTime;
        target = Mathf.SmoothStep(startValue, endValue, timer/time);//Using a smooth function now!
        yield return null;
    }
}
```
Unity only has the Lerp() and SmoothStep() functions, but there is a whole world of animation functions out there. They
are called easing functions. You can do research to see what is out there or even make your own! You can find out more
about easing functions [here](https://thebookofshaders.com/05/).

# 🥏 Physics

[📓](https://docs.unity3d.com/ScriptReference/UnityEngine.PhysicsModule.html)

Unity has a built-in implementation of the Phys-X physics engine that is designed to be easy to set up and use. Lets get
started!

## Rigidbody

[📓](https://docs.unity3d.com/ScriptReference/Rigidbody.html)  
The Rigidbody Component adds a rigidbody physics simulation to any gameobject it is attached to. Rigidbody physics
simulate objects with no flexing or squishing or bending. There are other simulation types, for instance softbody
physics, but none of them are implemented in Unity. Generally, anytime you want any gameobject to interact with the
physics system, add the rigidbody component to it!

Rigidbodies will use all the collider components on the gameobject they are attached to, *and all the collider
components on all of its children as well*. This allows you to build some pretty complex collision objects and keep
colliders on the same gameobject as the mesh they represent. Unity will let you make rigidbodies children of other
rigidbodies, but the behavior is not really useful in most cases. If you want relationships between rigidbodies, you
likely want to use [articulation bodies](#articulationbody)!

### Variables & Settings

```csharp
//useful variables!
Rigidbody rb = GetComponent<Rigidbody>();

float mass = rb.mass;//get or set the mass of this rigidbody
bool gravity = rb.useGravity;//get or set if this rigidbody is affected by gravity
bool cantMove = rb.isKinematic;//get or set if this rigidbody is kinematic
                //kinematic means the rigidbody will never move or rotate, but will still interact with other rigidbodies.
                //to move a kinematic rigidbody, use rb.MovePosition or rb.MoveRotation, don't edit the transform

Vector3 position = rb.position;//get or set the rigibody's position. use rb.MovePosition tho, this doesnt do interpolation 
Vector3 vel = rb.linearVelocity;//get or set the velocity. Use .AddForce() unless you rly know what you are doing.
Quaternion rotation = rb.rotation;//get or set the rigibody's rotation. use rb.MoveRotation tho, this doesnt do interpolation 
Vector3 angVel = rb.angularVelocity;//returns rotational velocity around each axis in radians/second

//This is called Drag in the inspector
float linearDamping = rb.linearDamping;//slows down linear velocity. The higher the value, the more it slows.
//This is called Angular Drag in the inspector
float angularDamping = rb.angularDamping;//slows down rotational velocity. The higher the value, the more it slows.
Vector3 centerOfMass = rb.centerOfMass;//get or set the center of mass in local space
//theres a lot more in the documentation, but you very likely will never need to touch them :)
```

In addition to these, there are some settings in the Rigidbody Component in the inspector window that are important.

Interpolate: This setting changes how rigidbodies are visually positioned between physics ticks.

- None: Apply no interpolation. This is fine most of the time, unless the rigidbody appears to jitter.
- Interpolate: Use the last 2 physics frames to pose the rigidbody this frame. Can be more accurate, but may make the
  rigidbody visibly lag behind where it actually is.
- Extrapolate: Use the last physics frame position and velocity to guess where the rigidbody should be right now. This
  can make the rigidbody appear slightly ahead of where it really is, and is best when accuracy is not important, or the
  object is moving at a mostly constant velocity.

Collision Detection: This setting changes the method Unity uses to detect collisions.

- Discrete: Just check for intersections at each physics tick. Much faster than the other methods, but is only accurate
  at small/medium relative velocities.
- Continuous: Sweep-based collision detection against colliders *without a rigidbody*. Uses discrete for other
  rigidbodies. This is best for objects travelling fast enough to clip through terrain, but still interacts with other
  objects fine.
- Continuous Discrete: Sweep-based collision detection against colliders without a rigidbody and any other rigidbodies
  that are also set to Continuous Discrete collision detection. This is the laggiest method, so only use it if
  necessary.
- Continuous Speculative: Increases rigidbody collision detection radius with its velocity. Less accurate than
  Continuous Discrete, but also faster!

Constraints: Lock the rigidbodies ability to move or rotate along some axises!

There is also a section at the bottom to override what layers this rigidbody will or will not collide with. If these are
not modified, it will follow the normal collision rules for its layer.

### Functions

```csharp
Rigidbody rb = GetComponent<Rigidbody>();

float explosionForce,explosionRadius,upwardsCoefficient;
Vector3 explosionPos;
ForceMode forceType;//more on this bad boy in the Writing Physics Code Section!
rb.AddExplosionForce(explosionForce, explosionPos, explosionRadius, upwardsCoefficient, forceType);//applys the force to simulate and explosion
                            //This function is best utilized when put on a trigger collider and called on all objects inside the trigger.
Vector3 forceVector;
rb.AddForce(forceVector, forceType);
Vector3 torqueVector;
rb.AddTorque(torqueVector, forceType);
Vector3 worldPosition;
rb.AddForceAtPosition(forceVector, worldPosition, forceType);//imparts a force and torque based on the force's position. All in world space.
```

```csharp
Vector3 worldPos;
Vector3 pointVel = rb.GetPointVelocity(worldPos);//returns the velocity of the body at worldPos. Accounts for angular velocity.
Vector3 position;
Quaternion rotation;
rb.MovePosition(position);//moves the rigidbody to the specified position in the physics simulation
rb.MoveRotation(rotation);//rotates the rigidbody to the specified rotation in the physics simulation
rb.Move(position, rotation);//combination of MovePosition() and MoveRotation()

rb.ResetCenterOfMass();//restores the auto-calculated center of mass if you changed it at runtime.
rb.ResetInertiaTensor();//restores the auto-calculated inertia tensor if you changed it at runtime.

RaycastHit hitInfo;//more on this bad body in the Writing Physics Code Section!
float distance;
Vector3 direction;
QueryTriggerInteraction hitTriggers;//whether or not to count interactions with trigger colliders
if (rb.SweepTest(direction, out hitInfo, distance, hitTriggers)){
    //we hit something! :D
}

RaycastHit[] allHits = rb.SweepTestAll(direction, distance,hitTriggers);
if (allHits.Length > 0){
    //we hit something! :D
}
```

### Messages

```csharp
//These are called in the physics loop *after* the internal physics update
void OnCollisionEnter(Collision col){}//called once the tick two colliders start colliding
                            //called on both involved colliders
                            //parameter col contains all the info of the collision
void OnCollisionStay(Collision col){}//called every tick for every collision this object is involved in
                            //called on both involved colliders
                            //parameter col contains all the info of the collision
void OnCollisionExit(Collision col){}//called once the tick two colliders stop colliding
                            //called on both involved colliders
                            //parameter col contains all the info of the collision
```

## Colliders

[📓](https://docs.unity3d.com/ScriptReference/Collider.html)  
Colliders are components that define the shape of an object inside the physics simulation. If they will never ever move
ever, they can be placed in the scene on their own. However, if you ever need to move them ever, they *need* to be
attached to a rigidbody component. If you don't want the collider to react to collisions, make the rigidbody kinematic.

The colliders in Unity are the BoxCollider, SphereCollider, CapsuleCollider, and MeshCollider. All of them inherit from
the Collider class. I will list all the variables and functions in the Collider class common to all the Collider types,
and then put anything unique to a Collider in its own section below.

### Base Class

```csharp
//useful variables
Collider collider = GetComponent<Collider>();
Bounds bounds = collider.bounds;//get a bounding box for the collider
bool enabled = collider.enabled;//enables or disables collisions with this collider

bool trigger = collider.isTrigger;//gets or sets if this collider is a trigger collider or a normal collider.
                                //trigger colliders dont apply collision forces to rigidbodies. 
                                //Instead they just detect intersections with them.
                                //this is very useful for triggering dialogue, explosions, or whenever you want detect presence.

Layermask maskInc = collider.includeLayers;//overrides what a collider could normally collide with given its gameobject's layer.
Layermask maskExc = collider.excludeLayers;//overrides what a collider could normally can't collide with given its gameobject's layer.

PhysicsMaterial material = collider.material;//specific instance of this physics material used by this collider only
PhysicsMaterial sharedMaterial = collider.sharedMaterial;//physics material for the collider. modification may affect other colliders.
```

```csharp
//functions!
Vector3 pos;
Vector3 closest = collider.ClosestPoint(pos);//returns the closest point to pos that is on the surface of this collider.

Ray ray;
RaycastHit hit; //more on this bad body in the Writing Physics Code Section!
float maxDistance;
if (collider.Raycast(ray, out hit, maxDistance){//cast a ray that can only intersect with this collider, no others.
    //ray intersects this collider!
}
```

```csharp
//messages!
//These are called in the physics loop *after* the internal physics update
void OnTriggerEnter(Collider col){}//called once the tick a collider enters a trigger
                            //called on both the trigger and the entering collider
                            //parameter col is the other collider of the interaction
void OnTriggerStay(Collider col){}//called every tick for every collider is inside a trigger
                            //called on both the trigger and the entering collider
                            //parameter col is the other collider of the interaction
void OnTriggerExit(Collider col){}//called once the tick a collider exits a trigger
                            //called on both the trigger and the entering collider
                            //parameter col is the other collider of the interaction
```

### BoxCollider

[📓](https://docs.unity3d.com/ScriptReference/BoxCollider.html)

```csharp
BoxCollider box = GetComponent<BoxCollider>();

Vector3 center = box.center;//center point of the collider in *local* space. basically just an offset.
Vector3 size = box.size;//size of the box on each axis in *local* space. This does not include transform scaling.
```

### SphereCollider

[📓](https://docs.unity3d.com/ScriptReference/SphereCollider.html)

```csharp
SphereCollider sphere = GetComponent<SphereCollider>();

Vector3 center = sphere.center;//center point of the collider in *local* space. basically just an offset.
float rad = sphere.radius;//radius of the sphere in *local* space. This does not include transform scaling.
```

### CapsuleCollider

[📓](https://docs.unity3d.com/ScriptReference/CapsuleCollider.html)

```csharp
CapsuleCollider cap = GetComponent<SphereCollider>();

Vector3 center = cap.center;//center point of the collider in *local* space. basically just an offset.
float rad = cap.radius;//radius of the sphere the capsule is based on in *local* space. This does not include transform scaling.
int dir = cap.direction;//axis the capsule extends into. X axis = 0, Y axis = 1, Z axis = 2.
float height == cap.height;//height of the capsule from tip to tip in *local* space.
```

### MeshCollider

[📓](https://docs.unity3d.com/ScriptReference/MeshCollider.html)  
Mesh colliders will generate a collider from a mesh, but this comes with some restrictions. Mesh colliders essentially
have two modes: Convex and Non-Convex. Non-convex is the default, and will generate a collider that closely matches the
given mesh. However, in this mode the collider cannot be used on non-kinematic rigidbodies. It will also never collide
with other non-convex mesh colliders. Enabling convex mode will change how the collider is calculated. It will now sort
of shrink-wrap a sphere around your mesh. If the mesh has any large concave areas, this may result in incorrect
collision. Use multiple colliders if you really need concave collision. When convex, mesh colliders can be used like any
other collider. They can be on dynamic rigidbodies, and they can be triggers.

```csharp
MeshCollider meshCollider = GetComponent<MeshCollider>();

//warning: changing either of these are runtime will cause the collider to be re-calculated, which can be expensive!
bool convex = meshCollider.convex;//get or set if the collider is in convex mode or not
Mesh mesh = meshCollider.sharedMesh;//get or set the mesh this collider is based on.
```

### Physics Material

[📓](https://docs.unity3d.com/ScriptReference/PhysicsMaterial.html)  
Physics materials are a neat little asset that let you specify the friction and bounciness of a material. These can be
applied to any collider. You can create one by clicking Assets > Create > Physics Material (at the bottom of the
list ;)). Single click the file once you have created it to adjust its settings, and then drag and drop it onto any
collider to apply it.

## ArticulationBody

[📓](https://docs.unity3d.com/ScriptReference/ArticulationBody.html)  
Back in my day, when I was a young whippersnapper like yourself, rigidbody connections in Unity were done with joint
components. There were several types, and you could place them on rigidbodies to connect them in various ways. This
system was clunky, inaccurate for objects with greatly different masses, and infamously unstable. This system has now
been replaced with articulation bodies!Well, both systems are still supported, but as far as I can tell articulation
bodies are just better in every way, so I will only cover them here.

The ArticulationBody component is essentially the rigidbody component and an old joint component merged into one. To
start, add an ArticulationBody component (and a collider if you want) to a gameobject. To make a connection, add a child
gameobject to this one and add another ArticulationBody component to it! The scene hierarchy itself defines what is
connected to what.

Every articulation body in the hierarchy except the root articulation body will have options in their inspector to
configure the connection they have to their parent. There is a dropdown at the bottom of the inspector to select the
articulation joint type. Fixed is a static welded connection, prismatic is a telescopic/slider connection, revolute is a
hinge joint connection, and spherical is a ball joint connection. For every axis the joint allows motion on, settings
will appear to configure that axis. Changing an axis from free to limited will let you define a swing range either in
numbers or with a gizmo in the scene view. You can also specify stiffness, dampening, or a drive, which acts as a motor
that applies a torque to the hinge. The rabbit hole here is deep, I won't cover every possibility here. Have fun
experimenting!

ArticulationBody has a lot of variables and functions that are similar to their counterparts in the Rigidbody component.
I will only be covering the unique ones here.

```csharp
ArticulationBody art = GetComponent<ArticulationBody>();
Vector3 hingePos = art.anchorPosition;//joint position in local space
Quaternion hingeRot = art.anchorRotation;//joint rotation in local space

bool kinematic = art.immovable;//sets the body to be basically kinematic. only meant to work on the root body.
bool root = art.isRoot;//returns true if this articulation body is the root of a hierarchy or not.

//there are a ton of variables for configuring the joints in code.
//here are some of them, theres a lot more in the documentation!!
ArticulationReducedSpace force = art.driveForce;//force the drive is applying on each axis
                                //ArticulationReducedSpace is basically just an array long enough for each appplicable axis
ArticulationReducedSpace pos = art.jointPosition;//meters or radians the joint is currently along in its path of travel
ArticulationReducedSpace vel = art.jointVelocity;//meters/sec or radians/sec the joint is currently moving at
```

## The Physics Class

[📓](https://docs.unity3d.com/ScriptReference/Physics.html)  
The physics class is a static class that you can use to interact with the entire physics world as a whole. In practice,
it is mostly used for raycasting, but there are some other useful things in it as well!

```csharp
//variables!
//These are also all in the project physics settings if you just want to change them permanently
float bounceThreshold = Physics.bounceThreshold;//minimum relative speed things need to bounce. default is 2.
Vector3 gravity = Physics.gravity;//gravity vector of the physics simultaion
Vector3 clothGravity = Physics.clothGravity;//gravity vector used for cloth physics
float maxSpeed = Physics.defaultMaxAngularSpeed;//max speed things can rotate in radians/sec. default is 50
bool backfaces = Physics.queriesHitBackfaces;//get or set if ray/shape casts hit the back faces of colliders. default is false.
bool triggers = Physics.queriesHitTriggers;//get or set is ray/shape casts hit triggers by default.
```

```csharp
//cast functions
Vector3 position, direction;
Quaternion rotation;
float distance;
LayerMask mask;
QueryTriggerInteraction triggers;//whether or not to count interactions with trigger colliders
RaycastHit hitInfo;

Vector3 halfExtents;//half the length of each side of the box in each axis.
if (Physics.BoxCast(position,halfExtents,direction,out hitInfo, rotation, distance, mask, triggers)){
    // the box we sent out into the scene hit something!!
}
RaycastHit[] allHits = Physics.BoxCastAll(position,halfExtents,direction,out hitInfo, rotation, distance, mask, triggers);

float radius;
if (Physics.SphereCast(position, radius, direction, out hitInfo, distance, mask, triggers)){
    // the sphere we sent out into the scene hit something!!
}
RaycastHit[] allHits = Physics.SphereCastAll(position, radius ,direction, out hitInfo, distance, mask, triggers);

Vector3 sphereCenter1, sphereCenter2;//centers of two spheres that are connected to form a capsule
if (Physics.CapsuleCast(sphereCenter1, sphereCenter2, radius, direction, out hitInfo, distance, mask, triggers)){
    // the capsule we sent out into the scene hit something!!
}
RaycastHit[] allHits = Physics.CapsuleCastAll(sphereCenter1, sphereCenter2, radius, direction, out hitInfo, distance, mask, triggers);

if (Physics.RayCast(position, direction, out hitInfo, distance, mask, triggers)){
    // the ray we sent out into the scene hit something!!
}
RaycastHit[] allHits = Physics.RayCastAll(position, direction, out hitInfo, distance, mask, triggers);

Vector3 startPos, endPos;
if (Physics.LineCast(startPos, endPos, out hitInfo, mask, triggers)){
    // the line we put into the scene hit something!!
}
```

```csharp
//overlap functions
Vector3 position;
Quaternion rotation;
LayerMask mask;
QueryTriggerInteraction triggers;//whether or not to count interactions with trigger colliders

Vector3 halfExtents;//half the length of each side of the box in each axis.
if (Physics.CheckBox(position, halfExtents, rotation, mask, triggers)){
    // There is at least one collider overlapping this box!!
}
Collider[] allColldiers = Physics.OverlapBox(position, halfExtents, rotation, mask, triggers);

float radius;//half the length of each side of the box in each axis.
if (Physics.CheckSphere(position, radius, mask, triggers)){
    // There is at least one collider overlapping this sphere!!
}
Collider[] allColldiers = Physics.OverlapSphere(position, radius, mask, triggers);

Vector3 sphereCenter1, sphereCenter2;//centers of two spheres that are connected to form a capsule
if (Physics.CheckCapsule(sphereCenter1, sphereCenter2, radius, mask, triggers)){
    // There is at least one collider overlapping this box!!
}
Collider[] allColldiers = Physics.OverlapCapsule(sphereCenter1, sphereCenter2, radius, mask, triggers);
```

```csharp
//other functions
Vector3 position;
Quaternion rotation;
Collider collider;
Vector3 point;
Vector3 closestPoint = Physics.ClosestPoint(point, collider, position, rotation);//closest point on or in the collider to point.

Collider collider, collider2;
bool ignored = Physics.GetIgnoreCollision(collider,collider2);//gets if 2 colliders ignore collisions regardless of layer
Physics.IgnoreCollision(collider, collider2);//set 2 colliders to never collide regardless of their layer.
```

## Writing Physics Code

In Unity, physics is not tied to the framerate. It is on its own physics loop. That way, frame rate does not affect the
simulation. This means that anytime you want to interact with anything in physics, it is best to do it inside the
physics loop. You can do this by putting your physics code in the FixedUpdate() function instead of the Update()
function. FixedUpdate()is called right before every physics step.

All functions to add a force to a physics object in Unity have a parameter at the end of type ForceMode. ForceMode is a
struct that lets you decide how the force is calculated. Here are the options:

- ForceMode.Force: Input vector is treated as a force in newtons. The change to velocity = forceVector *Time.deltaTime /
  mass.
- ForceMode.Impulse: Input vector is treated as an impulse in newton-seconds. The change to velocity = forceVector /
  mass.
- ForceMode.Acceleration: Input vector is treated as an acceleration in m/s/s. The change to velocity = forceVector *
  Time.deltaTime.
- ForceMode.VelocityChange: Input vector is treated as a delta-V in m/s. The change to velocity = forceVector.

When you do a cast of any time (BoxCast, RayCast, LineCast, etc.), the function will output a struct of type RaycastHit.
This struct holds all the information you need about the collision. Here is some of the most useful stuff:

```csharp
RaycastHit hit;

//one or both of these can be null!!!
ArticulationBody ab = hit.articulationBody;//articulation body for the collider we hit
RigidBody rb = hit.rigidbody;//rigidbody for the collider we hit

Collider col = hit.collider;//the collider we hit
Transform trans = hit.transform;//transform of the collider or rigidbody we hit

Vector3 hitPos = hit.point;//position of the collision point in world space
Vector3 normal = hit.normal;//normal direction of the surface we hit in world space
float distance = hit.distance;//distance from the cast's starting location to where the collision occured

//for mesh colliders. check the type of hit.collider if you don't know what collider type you hit.
Vector3 bary = hit.barycentricCoordinate;//barycentric coordinate of the hit point on the triangle we hit. useful for interpolation.
Vector2 uvs = hit.textureCoord;
Vector2 uvChannel2 = hit.textureCoord2;
```

## Physics Settings

If you click Edit > Project Settings > Physics > Settings, there are project-wide settings to configure about how
physics works. It is separated into Shared, Game Object, and Cloth. Shared applies to both gameobjects and cloth
simulations.

Shared lets you specify the gravity vector that is applied to all rigidbodies or articulation bodies with gravity
enabled. The layer collision matrix lets you specify which layers collide with which other layers.

The Game Object tab has a ton of settings, most of which I think are either self-explanatory or don't need to be
touched. The ones you are most likely to need to change are:

- Default Material: Physics Material used when a collider has no Physics Material assigned.
- Queries Hit Backfaces: If Cast or Overlap functions hit the backside of colliders
- Queries Hit Triggers: If Cast or Overlap function hit colliders marked as trigger
- Enable Enhanced Determinism: Makes simulation deterministic at the cost of some performance
- Default Max Angular Speed: Maximum speed anything can rotate at

Cloth lets you override the shared gravity with a separate gravity for cloth (idk why they made it work like this), and
enable cloth inter-collisions.

# 🔊 Audio

[📓](https://docs.unity3d.com/Manual/Audio.html)  
Unity's audio system is an old one, but a good one. I believe it is the only major engine system that did not get a
total overhaul during Unity's annual release phase. It is quite simple, but it also leaves a lot of room for custom
behavior and extensibility.

## Audio Clip

[📓](https://docs.unity3d.com/ScriptReference/AudioClip.html)  
Audio Clips are containers for audio data in Unity. Any supported audio file dragged into your project has an Audio Clip
made for it. Because they are containers, they represent audio when it is loaded and unloaded. This lets you work with
audio and even check its length without it being loaded into memory. You can control when the clip is loaded or unloaded
yourself or have it loaded all the time, if memory is not an issue for you.

Click an Audio Clip in your Assets folder, and its settings will appear in the Inspector. Most of the settings are
related to loading or compression. Enabling Load in Background will make the audio clip load in a background thread
whenever it is loaded. The load type gives you options for if the file stays compressed in memory or not, and if you
would like to stream it instead. You can also set the compression algorithm and quality. Preload Audio Data is possibly
the most important option here. Ticking this box will keep the Audio Clip loaded in memory whenever this Audio Clip
asset is used in a scene. When this is unticked, you must manually call LoadAudioData() before the sound is played. If
you do neither of these things, Unity will load the sound from disk the frame you play the sound, which can cause
hitching and latency!

```csharp
public AudioClip audioClip;

void Start(){
    int channels = audioClip.channels;//number of channels in this clip
    int frequency = audioClip.frequency;//sample frequency of the audio clip
    float length = audioClip.length;//length of audio clip in seconds
    int samples = audioClip.samples;//number of samples in the audio clip
    
    bool backgroundLoad = audioClip.loadInBackground;//if the audio clip is loaded in the background or not
    bool preloading = audioClip.preloadAudioData;//if the audio clip is auto pre loaded or not
    //if this clip does not have preloading, you must call these before you play it!!!
    bool success = audioClip.LoadAudioData();
    bool success = audioClip.UnloadAudioData();
    
    //you can also make Audio Clips procedurally :O
    bool stream;
    int numberOfSamples,numberOfChannels,sampleFrequency;
    AudioClip newClip = AudioClip.Create("Name",numberOfSamples,numberOfChannels,sampleFrequency, stream);
    int[] samples;
    int offset;
    newClip.SetData(samples, offset);
    int[] getSamples = new int[newClip.samples];
    newClip.GetData(getSamples, offset);
}
```

## Audio Listener

[📓](https://docs.unity3d.com/Manual/class-AudioListener.html)  
The Audio Listener component is probably the thing you need to think about least out of anything in this document. It
just serves as the point where all the sounds of the scene are heard. There can only ever be one per scene, and it is
automatically added to the Camera when you create a scene. The only time you really have to interact with it is making
sure there is still only one in the scene when you have multiple cameras or have multiple player characters for
multiplayer. Still, here are some neat things it lets you do if you are interested:

```csharp
bool pause = AudioListener.pause;//get or set listener pause state. If true, all AudioSources are paused until it is false again.
float volume = AudioListener.volume;//set master game audio volume. values must be between 0 and 1

float[] samples;//size must be a power of 2
int channel;
AudioListener.GetOutputData(samples, channel);//fills the samples array with samples from the master output on the specified channel.
FFTWindow window;
AudioListener.GetSpectrumData(samples, channel, window);//fills the sample array with spectrum data from the master output with the specified channel.
```

## Audio Source

[📓](https://docs.unity3d.com/ScriptReference/AudioSource.html)  
Audio Sources are the bread and butter of playing audio in Unity. They are a component that you attach to a gameobject,
and they play AudioClips in the 3D space of the scene. The distance and relative velocity to the AudioListener are both
taken into account when the sound is played. Unity does not simulate other effects like echoes automatically, but you
can add them manually using [audio mixers to add effects](#audio-mixer). Audio Sources have one audio clip that they
take ownership of. They manage how and when the clip is played. They can also play quick one-shots of other audio clips
if need be.

```csharp
//as always, much more in the documentation
AudioSource source = GetComponent<AudioSource>();
AudioClip clip = source.clip;//main audio clip for this audio source
bool bypass = source.bypassEffects;//set to ignore audio effects
float doppler = source.dopplerLevel;//how much the doppler effect should affect this clip
bool heckDaListener = source.ignoreListenerPause;//ignores if the scene audio listener is paused. good for pause menu music!
bool getHecked = source.ignoreListenerVolume;//ingnore the audio listener's master volume setting
bool playing = source.isPlaying;//returns true if the main clip is being played
bool loop = source.loop;//set to make the clip auto-restart after it ends.
bool mute = source.mute;//sets the clip volume to zero, but keeps playing it. Don't do this on a ton of differnt audio sources at once.
AudioMixerGroup group = source.outputAudioMixerGroup;//what audio mixer group governs this audio source
float pan = source.panStereo;//pans the sound left or right. values can be from -1 to 1
float pitch = source.pitch;//modify the pitch of the audio clip. values are clamped from -3 to 3 :(
bool gogo = source.playOnAwake;//set to have this audio source start playing automatically on load
float spatialFactor = source.spatialBlend;//dertmines how much distance & doppler affect the sound. values must be between 0 and 1
float time = source.time;//number of seconds that have been played of the main audio clip
int samplesPlayed = source.timeSamples;//number of samples that have been played
float volume = source.volume;//volume of the audio source
int priority = source.priority;//if the platform we are on has limited audio channels, Unity will cull the lowest priority sounds first.
                               //values are from 0 to 255, lower values have higher priority than higher ones
```

```csharp
//functions!!
AudioSource source = GetComponent<AudioSource>();
source.Play();//start playing main audio clip
source.Pause();//pause playing main audio clip
source.UnPause();//resume playing main audio clip
source.Stop();//stop playing main audio clip and reset to the beginning
source.PlayDelayed(1f);//plays main audio clip with a delay in seconds

//audio source scheduling. To be totally honest I didn't super look into this but it sounds very useful for syncing to music
double currentAudioTime = AudioSettings.dspTime;
source.PlayScheduled(currentAudioTime+2);//schedule 2 seconds from now
source.SetScheduleStartTime(currentAudioTime+1);//if already scheduled, reschedule to a new time
source.SetScheduleEndTime(currentAudioTime+1.5);//if already scheduled, set scheduled end time regardless of clip length

//playing other audio clips!
AudioClip someOtherClipIDK;
source.PlayOneShot(someOtherClipIDK, volume);//plays another audio clip with this audio source's settings.
                                             //does not cancel other sounds from this audio source, they can overlap

Vector3 position;                                             
AudioSource.PlayClipAtPoint(someOtherClipIDK, position, volume);//STATIC METHOD TO EASILY PLAY CLIPS LETS GOOOOO!!!! :DDDD

float[] samples;//size must be a power of 2
int channel;
source.GetOutputData(samples, channel);//fills the samples array with samples from this audio source on the specified channel.
FFTWindow window;
source.GetSpectrumData(samples, channel, window);//fills the sample array with spectrum data from this audio source with the specified channel.
```

## Audio Mixer

[📓](https://docs.unity3d.com/Manual/AudioMixer.html)  
Audio Mixers are assets that can control the outputs of multiple audio sources at once. They have one master group, but
you can make more groups within the same mixer. You can have multiple mixers, and even pipe the output from one mixer
into another mixer to make a huge mixer chain!

To make your first Audio Mixer, click Assets > Create > Audio > Audio Mixer. Give it a banger name and open it. This
opens up the Audio Mixer window. Along the left are 4 categories. Mixers has a list of all the audio mixer assets in
your project. You can switch between them here. By default they output to the audio listener, but you can also route
them into other mixers here. The second section is snapshots. Snapshots are basically keyframes. They hold the state of
all the knobs and dials of the mixer. You can switch or fade between snapshots at runtime! The Groups section has all
the audio groups of your mixer. Audio sources send their output to these groups. You can assign an audio source to a
group by selecting the gameobject in the scene view, and then clicking and dragging the audio group onto the Output
field of the audio source. The views section just lets you save the visibility and color of all your mixer's groups, and
switch between them.

Click any mixer group to edit its effects in the Inspector. You can add and configure all sorts of effects. I do not
know enough about audio to convey how powerful these effects can be, but definitely don't gloss over this and forget
about it!!Right click any variable and click Expose to expose it to C# scripts!

```csharp
public AudioMixer mixer;//assign in inspector or smth im not ur mom
void Mixin(){
    AudioMixerGroup groupOutput = mixer.outputAudioMixerGroup;//audio group this mixer is outputting to.
    float outputValue;
    bool success1 = mixer.GetFloat("ExposedVariableName", out outputVariable);//get exposed variable
    bool success2 = mixer.SetFloat("ExposedVariableName", 1f);//set exposed variable
    bool success3 = mixer.ClearFloat("ExposedVariableName");//reset exposed variable to its default
    
    AudioMixerSnapshot snap = mixer.FindSnapshot("SnapshotName");//get a mixer snapshot by its name
    AudioMixerSnapshot[] snapshots;
    float[] weights;
    float transitionTime;
    mixer.TransitionToSnapshots(snapshots,weights,transitionTime);//sets the mixer to an interpolated mix of snapshots
                                                            //you can just pass an array of length one to set one snapshot
}
```

## Project Audio Settings

You can change some audio settings by going to Edit > Project Settings > Audio. You can change global volume, falloff,
and doppler, and some other things. Its honestly not super exciting it just felt important to mention.

## Tracker Modules

[📓](https://docs.unity3d.com/Manual/TrackerModules.html)  
Tracker modules are a more modern version of .midi files that are supported in Unity! You may know these as .mod files.
The supported formats are Impulse Tracker (.it), Scream Tracker (.s3m), Extended Module File Format (.xm), and the
original Module File Format (.mod). Drag and drop any of these into your project, and Unity will create an Audio Clip
for them just like any other audio file!

## Native Audio SDK

[📓](https://docs.unity3d.com/Manual/AudioMixerNativeAudioPlugin.html)  
Unity has a Native Audio Sdk for making custom audio effects, spatializers, and other things! I don't know much about
this but the target reader of this document really likes audio and I felt like he should know about this! Just click
that lil documentation book right above this paragraph and it'll take you to a great getting started page.

# 🖥️ UI

[📓](https://docs.unity3d.com/Manual/UIElements.html)  
For the longest time, UI in Unity used a gameobject-based system called Unity UI. It was crytpic and difficult to
achieve the result you wanted, and also made a huge screen in your scene that was annoying. There is now a new system
that is based on a Unity specific version of html & css called UI Toolkit! (formerly UI Elements) It is much better in
every way, but it currently does no support world space UI or custom shaders. Use the old system if you need either of
those features.

UI Toolkit is designed to be very similar to building a webpage but customized for use in Unity. Instead of html, css,
and javascript, we have uxml, uss, and C#. UXML uses a document hierarchy system just like html with flexbox-style
layouts. USS is just like css, where you can select classes and tag types and define style properties for them. UI
Toolkit UIs are designed to be very reusable. You can make UI layouts for different game functions and use them with
different style sheets in different projects, and you can define one project-wide style sheet to use with all of your UI
layouts!

## Building a UI

### The UI Builder

To get started, click Window > UI Toolkit > UI Builder. This window lets you visually build uxml and uss files. You can
still make them by hand but I will not assist your masochism. The UI Builder is overwhelming at first, but if you take a
deep breath and look a little closer, it is very similar to the main Unity interface. The center pane is your preview of
the UI, and the right pane is your inspector that holds all the options for any selected object. The left pane is split
in 3 parts. The top pane lets you select a stylesheet from your project and edit it. The middle pane displays the
hierarchy of your currently open uxml file. The bottom pane is a library of all the components you can add to your UI.
There is a selection of built in Unity components, and you can also create your own! If you would like to preview the
raw uxml and uss files, drag the bottom bar of the preview window up.

### Setup

If you click the root .uxml file in the Hierarchy pane, you will get some options for the file in the Inspector pane. I
recommend ticking Match Game View, and ticking the Background checkbox. You can choose a solid color, an image, or a
game camera. Note, this background is just a preview and is not actually saved into you UI. If you are making an editor
tool, make sure to tick the Editor Extension Authoring box to enable some Editor-Exclusive components. Hit Ctrl + S to
save your uxml file, and give it a name. Also create a new style or add one from your project by clicking the + in the
top left of the SheetStyles pane, and selecting one of the options.

### Adding and Styling Components

Lets just make a simple menu with a button. Click and drag a Visual Element component into your hierarchy. In the
Inspector, in the StyleSheet section, type .Background into the top text field and press enter. This adds a Background
uss class to this component. Now select your uss file in the top StyleSheets pane, and type .Background into the first
test field in the Inspector to add Background as a class in your stylesheet. Expand the arrow next to your stylesheet in
the StyleSheets pane if it is not already, and select the .Background selector. Now, in the inspector, you can modify
any properties you like, and now any component you add the .Background class to will inherit your style choices made
here. You can also add multiple classes to the same UI Component. Because you can add and remove classes in code in C#,
making classes for separate behaviours lets you easily trigger complex behaviour with one line of code. For instance,
you could have a .Hide class that hides anything, and then add or remove that class from components as needed in code.
For this example, just change the color under the Background section of the inspector. This should fill your UI preview
with the color you selected.

Next, add a text label as a child of your background visual element in the hierarchy. There are ways to drive text
labels with code, but just hard code a string for now. Under Attributes, set the Label field to the name of your menu.
You can either customize this field directly, or add a class to it, for instance .Header, and then set up that header in
your uss stylesheet, just like we did for the background. Components will inherit the style of any classes attached to
them, but they can also have their own personal style overrides. These are called inline styles. Make sure to pay
attention if you are editing a component style or a stylesheet class style, it can be easy to mix them up! To position
the label, you can hard code in position offsets, but in most cases it is better to use flex. Select the .Background
class selector in your uss file, and got to the flex section in the inspector. Here, you can define the positioning
behaviour of all child components. Set Align Items to center and Justify Items to center. This will center the label.
Any more components we add will form a nice little stack in the middle.

Add two more buttons as children to the background pane below the label component. You can do this by clicking and
dragging to the very bottom edge of the label component, and a blue line will appear. That's how you know it will be a
child with the same parent as the label component. As our hierarchy gets more complicated, the default component names
will make our UI hard to work with. Click each component and give it a good name at the very top of their inspectors.
You can also select for component names in your stylesheets by using a # instead of a . before the selector. If you put
nothing before the selector, that will look for component types of that name, for instance Button or Label. Anyways, add
a .Button class to all of your buttons, and customize them in your stylesheet as you please! However, when we hover over
the buttons, nothing happens. We can fix this with pseudo classes! Pseudo classes will only be selected/active when the
component is in some state. Add a .Button:hover class to your stylesheet and change the background color. Now in the
Viewport pane, click preview in the top right, and hover over your buttons. They should change color! Feel free to add
.Button:active class for when the button is clicked! Note at the bottom of the inspector there are settings for
transitions, so that the color change fades in and out instead of changing instantly. I cannot understate how powerful
this whole system is.

### Adding to the Scene

To add our UI to the scene, add an empty gameobject to the scene hierarchy and add a UI Document component. You may get
an error that you do not have a PanelSettings asset. To create one, click Assets > Create > UI Toolkit > Panel Settings
Asset. Give it a name and drag it into this component's Panel Settings field. Then drag the *uxml* file you just made
into the Source Asset field. If you click the Game tab, your UI should appear! You can use the panel settings asset you
made to adjust the UI output camera and its scaling settings, among other things.

## Hooking UI Components Up to Code

You can interact with UI Toolkit UI in code by getting a reference to the UI Document component that is rendering it.

### Button Clicks

```csharp
private UIDocument document;
private VisualElement rootUI;

private Button button1;
private Button button2;

void Start() {
    document = GetComponent<UIDocument>();
    rootUI = document.rootVisualElement;//get our UI hierarchy

    button1 = rootUI.Q<Button>("Button1");//find our buttons in the hierarchy by name
    button2 = rootUI.Q<Button>("Button2");
    
    button1.clickable = new Clickable(() => { Debug.Log("Lambda Function Click!");});//set up click functions
    button2.clicked += Clicked;//there are two ways of doing it, pick whichever you like best!
}

void Clicked() {
    Debug.Log("Delegate Event Click!");
}

private void OnDestroy() {
    button2.clicked -= Clicked;//you might not need this but I don't wanna risk it
}
```

### Data Binding
Binding C# variables to UI Toolkit variables is super easy! Open up your UI Layout in the UI Builder if it is not
open already. Hover over the UI variable you would like to bind a variable to in the Inspector pane. Most commonly this
will probably be the Label field of a UI component. When you hover over it, 3 little dots will appear to the left of
the variable name. Click those, then choose Add Binding. A window will appear to configure your data binding. You
can bind a scriptable object or a monobehaviour script. If you would like to use a scriptable object, click Object
as the source type, drag and drop your scriptable object into the field that says None (Scriptable Object), and then
just enter the target variable name for the data source path. Make sure the capitalization is the same! If you would
like to use a monobehaviour component, the process is really similar. Select Type as your data source type, then
click the Select Type button, and search for the class that you want. For the data source path, just
put in the variable name you would like to bind to from the class you selected! So far we have only told UI toolkit
what kind of script it will be binding to, but it doesn't know what specific instance to use. For that, at runtime,
you must make a script to give the UI an instance. That can be done by getting a reference to the UI Document
component displaying your UI and inserting this code:
```csharp
public MyCoolScript script;//assign this in the editor or put it on the same gameobject as the UI Document
public UIDocument document;//same goes for this one, just get a reference however you please.

void Start(){
    VisualElement uiRoot = document.rootVisualElement;
    uiRoot.Query<Label>("LabelName").dataSource = script;
            //replace Label with the UI Component type that you are targeting. Ex: Button, Toggle, TextField, etc...
            //replace "LabelName" with the name of the target UI Component in the layout.
}
```
For either scriptable objects or monobehaviours, both have an option for a binding mode. By default it is set to To
Target, which means your code will only modify the UI, not the other way around. However, for something like a
TextField or a Toggle, you may want the UI to write back to the variable when the user changes something. To enable
that, select Two Way from the dropdown. To Source and To Target Once are also both available options if you would
like. When you are happy with your settings, click the Add Binding button at the bottom of the window, and you're
all set!

NOTE: If UI Toolkit isn't recognizing the variable you wish to bind to, add the [CreateProperty] attribute above it.

### Doing Stuff

[📓](https://docs.unity3d.com/ScriptReference/UIElements.VisualElement.html)  
You can do anything in code at runtime that you can do in the UI Builder! Here is just some stuff I think is useful.

```csharp
UIDocument document = GetComponent<UIDocument>();//document component
VisualElement rootUI = document.rootVisualElement;//actual UI hierarchy

document.enabled = false;//disable drawing of the UI
document.enabled = true;//enable drawing of the UI

Label label = rootUI.Q<Label>("Label");//find UI components by name
label.style.color = Color.red;//change any style properties you want!
button1.style.visibility = Visibility.Hidden;//hide component
button1.style.visibility = Visibility.Visible;//show component

label.transform.scale = Vector3.one * 1.2f;//change scale without affecting neighbors

int childCount = label.childCount;
VisualElement lastChild = label.ElementAt(childCount-1);//get child element by index
VisualElement parent = label.parent;
label.Add(new VisualElement());//add a component as a child to this one

label.AddToClassList("Hide");//add any uss class to the component
label.RemoveFromClassList("Header");//remove any uss class to the component
```

## Custom UI Components

You can create custom UI components that either extend or modify existing built in components, or define a completely
brand-new component!

If you want to make a component that modifies a Unity component, make a new class extending from it. I am going to make
a new custom component here, so I will derive from `VisualElement`. This code block is gonna be a doozy, I'm sorry thats
just how it be sometimes.

```csharp
using Unity.Properties;
using UnityEngine;
using UnityEngine.UIElements;

[UxmlElement]
public partial class DialComponent: VisualElement {
    //Code based on this fantastic tutorial!: https://www.youtube.com/watch?v=6DcwHPxCE54
    
    //custom color stylesheet fields
    //unfort you gotta add these to your style sheets manually. Its really not bad but still :(
    static CustomStyleProperty<Color> FillColorProperty = new CustomStyleProperty<Color>("--fill-color");
    static CustomStyleProperty<Color> BackgroundColorProperty = new CustomStyleProperty<Color>("--background-color");

    private Color fillColor;//local color variables we update from stylesheet
    private Color backgroundColor;
    
    
    [SerializeField] [DontCreateProperty] 
    private float progressBack;//backing variable for our property

    [UxmlAttribute]
    [CreateProperty]//Create Property allows data binding with a C# class variable!
    public float progress {//property that is exposed in the UI Builder
        get => progressBack;
        set {
            progressBack = Mathf.Clamp(value, 0f, 100f);//clamp between 0-100%
            MarkDirtyRepaint();//trigger a redraw of our UI component
        }
    }

    public DialComponent() {
        RegisterCallback<CustomStyleResolvedEvent>(CustomStylesResolved);//get stylesheet updates
        generateVisualContent += GenerateVisualContent;//subscribe to the event to draw UI
    }

    void GenerateVisualContent(MeshGenerationContext context) {//draw our component
        float width = contentRect.width;
        float height = contentRect.height;
        //nanoVG/Immediate style screen drawing
        //here is a good tutorial for this kinda stuff from Miss ^-^ https://openplanet.dev/docs/tutorials/nanovg-introduction
        Painter2D painter = context.painter2D;
        painter.BeginPath();
        painter.lineWidth = 5f;
        painter.strokeColor = Color.black;
        painter.Arc(new Vector2(width/2f,height), width/2f, 180f, 0f);
        painter.ClosePath();
        painter.fillColor = backgroundColor;
        painter.Fill();
        painter.Stroke();
        
        float arcAngle = 180f * ((100f-progress) / 100f);
        arcAngle = Mathf.Clamp(arcAngle, 0f, 179.9f);//prevent drawing weirdness
        
        painter.BeginPath();
        painter.LineTo(new Vector2(width/2f,height));
        painter.lineWidth = 3f;
        painter.strokeColor = Color.black;
        painter.Arc(new Vector2(width/2f,height), width/2f, 180f, 0f-arcAngle);
        painter.ClosePath();
        painter.fillColor = fillColor;
        painter.Fill();
        painter.Stroke();
        
        painter.BeginPath();
        painter.Arc(new Vector2(width/2f,height), width/2f*0.75f, 180f, 0f);
        painter.ClosePath();
        painter.fillColor = Color.black;
        painter.Fill();
    }
    
    void CustomStylesResolved(CustomStyleResolvedEvent eventData){//uss styles being resolved
        if (eventData.currentTarget == this) {//if our uss was changed
            DialComponent us = (DialComponent)eventData.currentTarget;
            us.UpdateCustomStyles();//update our colors!!
        }

    }

    void UpdateCustomStyles() {//update our local colors with the static style colors
        bool repaint = false;
        if (customStyle.TryGetValue(FillColorProperty, out fillColor))
            repaint = true;
        if (customStyle.TryGetValue(BackgroundColorProperty, out backgroundColor))
            repaint = true;
        if (repaint)
            MarkDirtyRepaint();//redraw if any of the colors changed
        
    }
}
```

In this code block, we marked the progress property as being able to bind data. To actually bind data to it, hover over
it in the UI Builder, click the three little dots to the left of it, and click Bind Data. Click Type, then the class you
will put your data you wish to bind in. For Data Source Path, type in the name of the variable being bound. Optionally,
change the binding mode as well. In a script on your UI object, give it a refence to an object of the type you specified
like this:

```csharp
public ClassWithRelevantData dataSource;//assign in inspector or get a reference your favorite way
----
VisualElement rootUI = GetComponet<UIDocument>().rootVisualElement;
root.Q<DialComponent>("CoolDialName").dataSource = dataSource
```

## Composing UI in Code

You can compose UI Toolkit UI completely in code. This is useful for small editor scripts, or baking functionality into
one C# file you can move around. There are a ton of functions to do everything you can do in the UI Builder, but here is
the basics to get you started!

```csharp
VisualElement root = new VisualElement();

root.style.alignContent = Align.Center;//center children in the container
root.style.justifyContent = Justify.Center;

Label label = new Label("Hiii");//create label
label.style.fontSize = 24;//change any styling you wish

Button button = new Button();//make a new button
button.text = "Click!";//set button text
button.clickable = new Clickable(() => { Debug.Log("Clicked"); });//lambda function called on button click
button.style.marginTop = 10;//set some nice spacing

root.Add(label);//add components in the order you want
root.Add(button);
```

# 💾 Managing Data

The easiest way to track data in Unity is to add a variable to the top of your monobehaviour script. However, this has
several disadvantages. It is tied to that specific instance of that class, which can make it difficult to reference it
elsewhere in a spaget-free manner. When there are multiple instances of the object, it can be tricky to keep them in
sync. The variable is also tied to the lifecycle of the gameobject is it attached to. This means if the gameobject is
destroyed or the scene is unloaded, the variable and its data are also lost. This section has some (but not all) methods
for solving this problem, as well as saving and loading data to and from disk to persist between launches.

## Static Class

Static C# classes solve these problems. They are created once at the start of the program and last until the program is
terminated, which means they can be referenced anywhere always. There will also only ever be one of them, which makes
them a single point of truth. However, because they are static, they cannot
be [serialized](#serialization--saving-to-disk). This means their state cannot be easily saved to disk and you cannot
see or modify their contents in the inspector, which makes them very opaque.

```csharp
//class declaration:
public static class GameState{
    public static float lookAtMe = 1f;
}
----
//Anywhere in the project:
float look = GameState.lookAtMe;
```

## Singleton Class

Singletons are a programming pattern that guarantees only one instance of a class will ever be created. This preserves
the single point of truth and makes the instance accessible everywhere, just as with static classes. However, singletons
don't have to always be loaded. You can create them only when they are needed. They are also compatible
with [serialization](#serialization--saving-to-disk). However, you still cannot see or edit their contents in the
inspector, since they are not a Monobehaviour. They are also not a language feature, which means you have to make sure
there is only ever one class instance yourself. Here is a good way of doing that!

```csharp
public class GameState{
    //static variable to hold our one instance
    private static GameState instance;
    //private constructor, so no more instances can be made
    private GameState() {}

    public static GameState Instance(){
        if (instance == null){
            instance = new GameState();
        }
        return instance;
    }
    //actual data and functions below here!
    public float lookAtMeImNotStatic = 1f;
}
------
//anywhere in the project
float look = GameState.Instance().lookAtMeImNotStatic;
```

## ScriptableObject

[📓](https://docs.unity3d.com/Manual/class-ScriptableObject.html)  
Scriptable Objects are the hottest thing since sliced bread. They are very similar to monobehaviours. The only
difference is that they live in the project as an asset, instead of being attached to a gameobject in the scene
hierarchy. This means they persist independent of objects and scenes. There can be multiple instances of the same
scriptable object class, but because each instance is a named file, it is still easy to maintain a single point of
truth. They also support serialization for easy saving of state. However, unlike the two methods above, you can select
them in the assets window to see and modify all their variables in the inspector window! This is great for debugging and
rapid prototyping. They can also be used as managers that house functionality that should not belong to any one
monobehaviour.

To create a new ScriptableObject script, click Assets > Create > Scripting > ScriptableObject Script. The tag at the top
of your new class places it in the Assets > Create menu. Feel free to modify this. To create an new instance of your
class, Click Assets > Create > Place you specified in your script file.

For a scriptable object with the class name GameState, you can access and edit it like this:

```csharp
public class GameState : ScriptableObject {
    public float lookAtMe;
}
------
//in a monobehaviour, you can do this:
public GameState gameState;//drag and drop the GameState asset into this field in the editor

void Start(){
    float look = gameState.lookAtMe;
}
```

You can also make singleton scriptable objects!

```csharp
public class GameState : ScriptableObject {

    public static GameState instance { get; private set;}

    void Awake() {
        if (instance != null) {
            Debug.LogError("More than one instance of me, please fix!!!!!");
        }
        instance = this;
    }
    
    public float lookAtMe = 1f;
}
------
//elsewhere in the project:
float look = GameState.instance.lookAtMe;
```

NOTE: Even though scriptable objects will not revert if they are changed in play mode in the editor, they will not
automatically keep changes between runs of a build of your game. You must still explicitly save and load their state to
and from disk.

## Serialization & Saving to Disk

[📓](https://docs.unity3d.com/6000.0/Documentation/Manual/script-serialization.html)  
Serialization is a complex subject with lots of gotchas. I will touch on it at a really high level, but if you are doing
anything serious with it, check the documentation and look up some guides. Keep in mind, Unity has its own serialization
process built on top of from the one built in to C#.

Serialization is the process of taking variables and objects, and converting them to a file that can be saved on a disk.
Unity uses this to store all the public variables of all your gameobjects to the scene file. This is why the tag for
exposing private variabes to the inspector is called [SerializeField]. We can hook into this to save objects to our own
files on disk.

To mark a custom class as serializable, put the [System.Serializable] tag above its header. Any variable that is public(
or marked with [SerializeField]) *and* is compatible will be serialized when an object of the class is serialized. There
are a lot of compatability rules, but the biggest two are that the variable cannot be static and that is must be a
compatible type. Compatible types are either primitive types or classes that also have the [System.Serializable] tag
themself. If you want to serialize a variable of an unsupported type, you
must [make your own custom serialization for it like this](https://docs.unity3d.com/6000.0/Documentation/Manual/script-serialization-custom-serialization.html).

Here is how to save and load a serializable singleton to disk:

```csharp
using System.IO;
using UnityEngine;

[System.Serializable]
public class GameState{
    private static GameState instance;
    private GameState() {}
    public static string saveFilePath;

    public static GameState Instance(){
        if (instance == null){
            instance = new GameState();
        }
        return instance;
    }
    
    public static void Save(){
        string json = JsonUtility.ToJson(myObject);
        File.WriteAllText(saveFilePath,json);
    }
    
    public static void Load(){
        if (!File.Exists(saveFilePath)) return;
        string json = File.ReadAllText(saveFilePath);
        JsonUtility.FromJsonOverwrite(json, instance);
    }
    
    public float lookMaImOnDisk = 1f;
}
```

And here is how to save and load a serializable scriptable object:

```csharp
using System.IO;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "GameState", menuName = "Scriptable Objects/GameState")]
public class GameState : ScriptableObject {
    
    public float lookMaImOnDisk = 1f;
    
    public static string saveFilePath;
    
    void Save(){
        string json = JsonUtility.ToJson(this);
        File.WriteAllText(saveFilePath,json);
    }
    
    void Load(){
        if (!File.Exists(saveFilePath)) return;
        string json = File.ReadAllText(saveFilePath);
        JsonUtility.FromJsonOverwrite(json, this);
    }
}
```

## PlayerPrefs

[📓](https://docs.unity3d.com/ScriptReference/PlayerPrefs.html)  
PlayerPrefs are a quick and dirty way to save individual variables that are primitive data types. It is whats known as a
Keystore system, where you give unity a string, which acts as the key, and the variable you want to save. Later, you can
ask Unity for the value associated with that key and it will give it to you! PlayerPrefs persist on disk across
different runs of your game, so they are great for saving settings or little pieces of data. This system is super
perfomant, so don't use it for anything big.

```csharp
//saving variables into PlayerPrefs
int num;
float flo;
string str;
PlayerPrefs.SetInt("MY_INT", num);
PlayerPrefs.SetFloat("MY_FLOAT", flo);
PlayerPrefs.SetString("MY_STRING", str);

//get variables from PlayerPrefs
//second parameter to these functions is the default value if the key doesn't have a value
num = PlayerPrefs.GetInt("MY_INT", 0);
flo = PlayerPrefs.GetFloat("MY_FLOAT", 0f);
str = PlayerPrefs.GetString("MY_STRING", "bla");

PlayerPrefs.DeleteKey("BEGONE_KEY");//deletes data for this key if it exists
bool keyStored = PlayerPrefs.HasKey("MY_INT");//returns true if the key has a value stored
```

## A Note on Save Files

There is no single best way to create a save file system for your game. If you only need to save a level number and a
few other numbers, you can get away with just using PlayerPrefs to store everything. If your game has more information
that needs to be saved and loaded, make a serialized class or scriptable object and save that to disk. If your game has
a ton of data, for instance if there is a procedural world, it may be best to create your own data storage scheme and
save it to disk yourself with some C# functions. How you choose to save the data, as well as get and set the data to the
rest of your project, is up to you!

# ✏️ Editor Scripting

Editor scripting is truly what makes big projects in Unity possible. It is how you extend the tools Unity gives to make
any game and create tools to make your game specifically. There is an entire world of making editor scripts, here is
just the tip of the iceberg.

IMPORTANT NOTE: The Editor class is not included in builds of your game, so any class that extends it for an editor
script will cause the build to fail. To fix this, either put your editor scripts in a folder named Editor inside your
project's Assets folder, or surround any code depending on the Editor class with a `#if UNITY_EDITOR ... #endif`
preprocessor directive.

## Attributes

Attributes are a quick and easy way to customize the way your variables will look in the inspector without having to
write any code! You can put multiple of these before a variable and they will all still work.

### Unity Attributes

There are a ton of attributes included in Unity, these are just my favorites.

```csharp
public class MyClass{
    [Header("My Variables")]//adds a text header above the variable this attribute precedes
    
    [SerializeField] //makes non-public variables visible in the inspector (and serializes them)
    private float youCanStillSeeMe = 0f;
    
    [HideInInspector] //hides public or serialized variables from the inspector
    public float youCantSeeMeTho = 1f;
    
    [Space(10)] //adds a spacing of a number of pixels before the variable this attribute precedes
    
                   //displays this int or float as a slider between the two specified values. 
    [Range(0,20)] //Does not prevent this variable from exceeding those bounds when set via code
    public float range = 0f;
    
    [ToolTip("I'm so fun and helpful ^-^")]//displays a string when you hover over the variable name in the inspector.
    public int crypticVariableName;
    
                    //displays a string variable as an expanded text box. 
    [TextArea(5,10)]//Parameters are the minimum and maximum number of lines to display before switching to a scrollbar.
    public string smallNovel = "Hey Roxy how are you?";
}
```

### Custom Attributes

Property Drawers: [📓](https://docs.unity3d.com/ScriptReference/PropertyDrawer.html)  
Decoration Drawers: [📓](https://docs.unity3d.com/ScriptReference/DecoratorDrawer.html)  
You can make your own attributes!! :O  
As always, the rabbit hole here is very deep, but here is a basic example that adds a divider line between variables:

```csharp
public class DividerAttribute : PropertyAttribute {
    public float thickness;
    public float margin;

    public DividerAttribute(float thickness = 1, float margin = 20) {
        this.thickness = thickness;
        this.margin = margin;
    }
}

[CustomPropertyDrawer(typeof(DividerAttribute))]
public class DividerDrawer : DecoratorDrawer { //inherit from property drawer to change how a property is drawn

    public override VisualElement CreatePropertyGUI() {
        VisualElement container = new VisualElement();
        DividerAttribute divider = attribute as DividerAttribute;
        
        //optionally you can load in a .uxml file instead of defining the UI in code.
        //VisualTreeAsset tree = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>("Assets/DividerAttribute.uxml");
        //container = tree.Instantiate();
        
        VisualElement bar = new VisualElement();
        bar.style.backgroundColor = Color.gray;
        bar.style.height = divider!.thickness;
        bar.style.marginTop = divider!.margin;
        bar.style.marginBottom = divider!.margin;
        container.Add(bar);
        return container;
    }
}
```

```csharp
// our custom property works just like this!
public class SuperCoolScript : MonoBehaviour {
    public float coolFloat;
    [Divider(2, 20)]
    public int totallySeparateInt;
}
```

## Gizmos

[📓](https://docs.unity3d.com/ScriptReference/Gizmos.html)  
Gizmos are the quirky little overlays Unity draws when you select an object in the scene view. You can make your own
custom ones! Here is how:

```csharp
public class MyComponent : MonoBehaviour {
    //very good very important game code goes here yes yes
}
    
#if UNITY_EDITOR
public class MyComponent : Editor {
    //Gizmo types: https://docs.unity3d.com/ScriptReference/GizmoType.html
    [DrawGizmo(GizmoType.InSelectionHierarchy)]
    static void DrawMyGizmos(MyComponent script, GizmoType type){//you can call this anything
        //gizmos are drawn in a nanoVG/immediate-esque style.
        //If you've never used something like this, just know you have to call functions to set drawing settings
        //and then also call functions to actually draw separately after. 
        Gizmos.color = Color.magenta;//sets color of all gizmos drawn after this to pink
        Gizmos.matrix = Matrix4x4.identity;//set a transformation matrix to apply to all future gizmos
                                        //use this to rotate and scale Gizmos.
                                        //set this to transform.worldToLocalMatrix to draw gizmos on a transform
        Vector3 center, Vector3 size;
        Gizmos.DrawCube(center, size);
        Gizmos.DrawWireCube(center, size);
        Gizmos.DrawSphere(center, radius);
        Gizmos.DrawWireSphere(center, radius);
        Mesh mesh;
        Quaternion rotation;
        Gizmos.DrawMesh(mesh, center, rotation, size);//this one has its own transformation stuff for some reason.
        Gizmos.DrawWireMesh(mesh, center, rotation, size);
        Vector3 direction;
        Gizmos.DrawRay(center, direction);
        
        Gizmos.DrawFrustum(center,fov,farPlaneDist,nearPlaneDist,aspectRatio);
        
        Vector3 from, to;
        Gizmos.DrawLine(from,to);
        Vector3[] points;//must be an even number of points
        Gizmos.DrawLineList(points);//draws a line between points as from,to,from,to... till the end of the array.
        Vector3 pointsStrip;//can be odd
        bool loopToStart;
        Gizmos.DrawLineStrip(pointsStrip, loopToStart);//draws lines connecting all the points. useful for splines and stuff!
        
        //There are functions to draw icons but theyre annoying and I hate them so look that up if you want it :3
    }
}
#endif
```

## Custom Inspectors

[📓](https://docs.unity3d.com/6000.0/Documentation/Manual/UIE-HowTo-CreateCustomInspector.html)  
You can modify or completely redefine how your component looks in the inspector window. We can use [UI Toolkit](#-ui) to
define our own layout!

### Adding a Button

```csharp
public class CoolScript : MonoBehaviour {
    public float favoriteNumber = 24f;
    public void Clicked() {
        Debug.Log("Clicked!");
    }
}

#if UNITY_EDITOR
[CustomEditor ( typeof(CoolScript))]
public class InspectorCoolScript : Editor {
    public override VisualElement CreateInspectorGUI() {
        VisualElement container = new VisualElement();//create root element of our inspector UI
        CoolScript script = (CoolScript)target;//the component this is an inspector for
        
        InspectorElement.FillDefaultInspector(container, serializedObject, this);//draw the default inspector

        Button button = new Button();//make a new button
        button.text = "Click!";//set button text
        button.clickable = new Clickable(() => { script.Clicked(); });//lambda function called on button click
        button.style.marginTop = 10;//set some nice spacing
        
        container.Add(button);//append our button to the UI layout
        
        return container;//return our super cool layout
    }
}
#endif
```

### Completely Custom Example

```csharp
public class CoolScript : MonoBehaviour {
    public int hugMe;
    public float butDont;
    public Color touchMe;
}

#if UNITY_EDITOR
[CustomEditor ( typeof(CoolScript))]
public class InspectorCoolScript : Editor {
    public override VisualElement CreateInspectorGUI() {
        VisualElement container = new VisualElement();//create root element of our inspector UI
        CoolScript script = (CoolScript)target;//the component this is an inspector for

        PropertyField f1 = new PropertyField(serializedObject.FindProperty("hugMe"));//auto creates the right filed type
        f1.style.fontSize = new StyleLength(24);
        PropertyField f2 = new PropertyField(serializedObject.FindProperty("butDont"));
        f2.style.backgroundColor = Color.black; 
        PropertyField f3 = new PropertyField(serializedObject.FindProperty("touchMe"));
        f3.label = "";
        
        container.Add(f1);
        container.Add(f2);
        container.Add(f3);
        
        return container;//return our super cool layout
    }
}
#endif
```

### Loading a UXML Layout from File

For detailed instructions on how to configure your .uxml file
see [this unity page](https://docs.unity3d.com/6000.0/Documentation/Manual/UIE-HowTo-CreateCustomInspector.html). This
is just a simple code example! Make sure that for any variables you want to bind to elements, their Binding Path is set
to the variable name you want bound.

```csharp
public class CoolScript : MonoBehaviour {
    public int xmlMe;
}

#if UNITY_EDITOR
[CustomEditor ( typeof(CoolScript))]
public class InspectorCoolScript : Editor {
    public override VisualElement CreateInspectorGUI() {
        CoolScript script = (CoolScript)target;//the component this is an inspector for

        VisualTreeAsset myLayout = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>("Assets/CoolFolder/CoolScriptInspector.uxml");
        VisualElement element = myLayout.Instantiate();//actually build our layout from the file
        
        return element;//if you set your binding paths right, everything just works auto-magically!
    }
}
#endif
```

## Custom Windows

[📓](https://docs.unity3d.com/Manual/UIE-HowTo-CreateEditorWindow.html)  
Click Assets > Create > UI Toolkit > Editor Window. Put in the names and location you would like for all the new files.
Your new window will appear with Hello World! text! If you open the C# script for the window you just created, you can
change where the new window lives inside the Editor Menu. This template totally sets up everything you need, just add
functionality into the script or .uxml file from here!

# 🗄️ Multiplayer
[📓](https://docs-multiplayer.unity3d.com/netcode/current/about/)  

Unity has a ton of different packages, services, and supported architectures for multiplayer (what a world). There is a
lot to choose from and a lot of decisions to make that depend on the type of game you want to make. I will do my 
best to give a quick overview of everything here! This section was really hard to organize, so many concepts and 
classes depend on each other in a circular way, which makes writing them down in a linear way hard. My apologies if 
this gets a little confusing, I did my best! Let me know if you know how to do it a better way!

## Terminology
Here are some terms you may see a lot and what they mean!
- Netcode: Term for all code relating to networking a game
- UNet: The old deprecated networking API in Unity
- Netcode for Gameobjects: The new networking API package! (its very similar to UNet). It is a fork of the 
  multiplayer solution for DOTS, which has since been renamed Netcode for Entities.
- Multiplayer Center: Unity made so many multiplayer packages they made another multiplayer package to tell you 
  about all the other multiplayer packages
- Authority: having the permission to write data to the network that will be synced with everyone else
- Ownership: ok this is clearly different than Authority in Netcode for GameObjects somehow but I could never find a 
  clear answer online, I'll update this later if I do, if you're reading this bug Roxy about this.
- Authoritative Server: a game architecture where the client isn't trusted to do anything. The server makes all the 
  decisions about what happens in the game world.
- Transport: The underlying technology used to send network packets back and forth. Netcode for Gameobjects lets you 
  choose from different transport solutions or even make your own if you really want to.
- Relay server: a lightweight server that just connects clients and forwards packets between them. They are used for 
  connections between clients that are more secure and don't require port forwarding.
- Client Prediction: For server-authoritative games, waiting for the server to tell the client where the player has 
  moved to feels sluggish. Instead, you can have the client predict where the server will probably tell the 
  client it should be given the player's inputs. This way the client still feels responsive while remaining 
  server-authoritative.
- Client Reconciliation: If a client is predicting where the server will say the player should be, its prediction 
  may be wrong. If it is, when the client gets the position data from the server, it must reconcile that data with its 
  own prediction. This usually takes the form of sliding the player over to where the server says they should be.
- RPC: stands for remote procedure call. Allows you call a function on one machine from another machine. These are 
  used a lot in Unity netcode!

## Theory

There are an infinite number of ways to architect your multiplayer game, but the 3 most common ways are:

- Central Server: One central server runs the game simulation. It takes in the inputs from all the clients, runs
  the game world, and then sends the result to all the clients. This architecture is the most resilient to cheaters 
  and hackers, but it also requires more expensive server hosting. It can also be difficult to make the game feel 
  responsive and snappy while also having a 100% authoritative server. This is often the best choice for competitive 
  games, or games where players are in lobbies with strangers.
- Client Hosting: One of the player's clients also acts as a server. This client is called the host. This 
  architecture reduces the cost of server infrastructure, although relay servers are still needed to resolve 
  connections. This method is also vulnerable to hacked clients, especially if the host is not 100% authoritative. 
  This architecture is good for complex co-op games, where all the hosting player can be trusted.
- Peer to peer: This architecture has no central authority, instead every client has some authority over the game 
  world. Relay servers are still needed for security and routing reasons. This style can be easier to implement for 
  small projects, but I would imagine maintaining a coherent reality for a more complex game could get difficult. 
  Maybe not though! This architecture is good for small co-op games, where all players can be really trusted.

## Setup
Lets get started setting up a multiplayer project! By default, everything in Netcode for Gameobjects is server 
authoritative, and I will be using that architecture for these examples, but I will also mention how to change 
permissions to make anything client-authoritative instead!

First things first, make sure you have all the packages you need installed. Click Window > Package Manager, and then 
install Netcode for Gameobjects, Multiplayer Tools, and Multiplayer Play Mode. There are a *ton* of other multiplayer 
packages available for hosting, matchingmaking, lobbys, friends, voice chat, and more, but I'm just going to cover 
the basics here. Create an empty gameobject in your scene and call it the Network Manager. Attach the NetworkManager 
component to it. You will get a warning that you have no Transport selected. Click the dropdown and select Unity 
Transport. There are more transport options available from other Unity packages and services (I think?), and there 
are also probably third party ones as well. This lets you keep your netcode and hosting solutions separate, in case 
you ever need to switch! Selecting Unity Transport automatically adds a Unity Transport component to your network 
manager, and it has some network related settings you can fiddle with if you like. Make sure your currently open 
scene (or any scene with networking) is added your build. You can do this by clicking File > Build Profiles > Scene 
List, and adding the open scene. Now your project is ready for multiplayer!

## Multi-Player Play Mode
[📓](https://docs-multiplayer.unity3d.com/mppm/current/about/)  
First things first, lets set up one of the coolest new features of Unity 6: Multi-Player Play mode. Before, to test 
multiplayer code, you had to make a build of your game, run the build, then also hit play in the editor, and connect 
them. Now, you can run multiple game instances inside the editor! To do this, make sure you have the Multiplayer 
Play Mode package. Then, click Window > Multiplayer > Multiplayer Play Mode. Here you can enable or disable up to 3 
additional players to test with! When you click play, a new window will appear with your enabled virtual player(s). 
By default only the game and console views are visible, but you can click layout in the top right to also enable the 
hierarchy, inspector, and scene view panes! There will also now be a dropdown next to the Play button that lets you 
pick a play mode scenario. You can also configure new play mode scenarios at the bottom of that dropdown. Theres all 
kinds of crazy stuff in there that I don't know and honestly I think I'm good. You can Google it if you wanna. DM me 
if you do. NOTE: You *must* save the scene in order for your changes to be sent to the virtual players and update 
them! IDK why it works that way but it does!!

## Network Manager
[📓](https://docs-multiplayer.unity3d.com/netcode/current/components/networkmanager/)  
The network manager is the central point that, uh, manages all the network connections of your game. There can only 
ever be one of them active at a time. When your game is run, it will automatically set itself to not destroy on load, 
so that it will survive scene changes, and makes a nice static instance for you to get a reference to it ^-^. If you 
ever can't find your network manager when you hit play, it's in a little section at the bottom of your hierarchy 
called Don't Destroy On Load that is hidden by default. Expand it, and your network manager will be hiding there! The 
NetworkManager class has a ton of networking stuff in it my god. I'm just going to cover common things you may need 
it for here, but know there is much more if you need it.

### Connection Information
If you are using Unity Transport, you can set the connection IP and Port in the Unity Transport component. You can 
set them in code like this:
```csharp
NetworkManager netman = NetworkManager.Singleton;
netman.GetComponent<UnityTransport>().SetConnectionData(
    "127.0.0.1",  // The IP address 
    (ushort)12345 // The port number (an unsigned short)
);

//if you want your server to listen on all available IPs, add a third field of all zeros
//I dont entirely understand this but the Unity Documentation said its a good thing so
netman.GetComponent<UnityTransport>().SetConnectionData(
    "127.0.0.1",  // The IP address 
    (ushort)12345, // The port number 
    "0.0.0.0" // The server listen address 
);
```

### Startup and Shutdown
There are three buttons at the bottom of the NetworkManager Inspector that become active when you enter play mode. They
let you start a dedicated server, start a hosted client, or attempt a connection to a server. These can (and should) be
easily hooked up to [UI](#-ui) buttons, so you can trigger them at runtime in builds when you cannot see the inspector.
There is also a shutdown function as well! Shutting down a client will happen before the next frame, but note it may 
take a little while for a server or host to shut down.

```csharp
NetworkManager netman = NetworkManager.Singleton;
//dont do this in a network behaviour, it can cause weirdness. this starts the network stuff after all!
netman.StartServer();//call to start as a dedicated server
netman.StartHost();//call to start as a client and host
netman.StartClient();//call to start as just a client and attemp a connection

netman.Shutdown();//disconnects any connections and shuts down the whole networking system
```

### Network Prefabs

The Network Manager also creates a scriptable object in your project called Default Network Prefabs. If you click it
in the assets pane and look at it in the inspector, it has a list called Network Prefabs. *Every* prefab you *ever*
want to create at runtime and have it be synced over the network must be added to this list. If you want, you can
also have multiple Network Prefab List assets each with their own list, as long as they are added to the Network
Prefabs Lists field in the Inspector for your network manager. Unity may automatically add new prefabs with
NetworkObject components to the default list. This is a new thing in Unity 6 and I don't know how reliable it is yet, so
double check that your prefab is there just in case ^-^. *Every* prefab (and networked gameobject) *must* also have
a [NetworkObject](#networkobject) component attached to it. This is how the network manager keeps track of objects. To
create or delete network objects, it is very similar to the normal way. Here is the code! Note: All network code,
including this, must be in a class that inherits from [NetworkBehaviour](#networkbehaviour)!

```csharp
public GameObject banginPrefab;//assign in the inspector. must also be in a Network Prefabs List!!!
private GameObject newInstance;//variable for the prefab instance were gonna make

void SpawnNetObject(){
    bool destroyWithScene = true;//set true to destroy the network object if its scene is unloaded
    newInstance = Instantiate(banginPrefab);//just like you normally do
    newInstance.GetComponent<NetworkObject>().Spawn(destroyWithScene);//spawns in on the network!
    
    //Note: spawning in network objects can *only* be done on the server, and there is no way to override this
    //If you want a client to create an object, have it send a ServerRPC to the server and tell it to do so on its behalf
    //However, you can have the server give ownership of a created object to a client!
    ulong clientId;//there are various methods of getting client ids listed below
    newInstance.GetComponent<NetworkObject>().SpawnWithOwnership(clientId,destroyWithScene);
    //the server can also revoke ownership if it wants
    newInstance.GetComponent<NetworkObject>().RemoveOwnership();
}

void DestroyNetObject(){
    Destroy(newInstance);//this will remove it on the network as well and everything!
}
```

### Player Prefab
Most multiplayer games have a player gameobject that represents the player in the world. If your game has this, the 
network manager has built in functionality to handle spawning in players that connect automatically! If you have 
your player gameobject as a prefab *and* it is in the [Network Prefabs List](#network-prefabs) *and* it has a
[NetworkObject](#networkobject) component on it, you can put this prefab in the Default Player Prefab field of your 
network manager. Make sure there is no player in your scene by default, the network manager will create a player 
even for the host. Keep in mind, the network manager just spawns the prefab, but it doesn't do anything else. You 
will need to write a [NetworkBehaviour script](#networkbehaviour) to disable inputs and the audio listener on player 
instances that represent other clients.
```csharp
NetworkManager netman = NetworkManager.Singleton;
//you can get the player object for this game instance like this
NetworkObject player = NetworkManager.LocalClient.PlayerObject;

//the server can also get the player object for any client like this:
ulong clientId;//there are various methods of getting client ids listed below
netman.ConnectedClients[clientId].PlayerObject;
```

### Managing Clients
You can get the ids of all connected clients and their NetworkConnections like this:
```csharp
NetworkManager netman = NetworkManager.Singleton;

List<ulong> clientIds = netman.ConnectedClientsIds;
Dictionary<ulong,NetworkClient> clients = netman.ConnectedClients;
```
You can also get a specific client's ID from an [RPC](#rpcs) by the way!!

## NetworkObject
[📓](https://docs-multiplayer.unity3d.com/netcode/current/basics/networkobject/)  
The NetworkObject component adds a gameobject to the networking system. It will keep track of all the copies of this 
object on every instance of the game, server or client, and treat them as the "same" object for netcode purposes. 
This is hard to put into words but it'll make more sense as you learn more about networking in Unity. This component 
is required to be on any gameobject involved in networking in any way (except the network manager I guess). If you 
have parent and child gameobjects, you only have to put it on the parent, it will also keep track of the children
(although you have to do some special sauce if you wanna change a gameobjects parent at runtime).

## NetworkBehaviour
[📓](https://docs-multiplayer.unity3d.com/netcode/current/basics/networkbehavior-synchronize/)  
NetworkBehaviour is actually a subclass of [MonoBehaviour](#-monobehaviours). Anything you can do in a MonoBehaviour 
can also be done in a NetworkBehaviour, and if you are making a game with mandatory or optional multiplayer, you may 
just want to use NetworkBehaviour for all your scripts. The reason it is special is that it has built-in variables 
that provide information about the current network connection, and *all* netcode must be written in a class that 
inherits from it. Note: all NetworkBehaviour components must have a [NetworkObject](#networkobject) component on the 
same gameobject or one of the gameobject's parents. Here are some of the things you can do in a NetworkBehaviour!
```csharp
public class ImANetworkScript : NetworkBehaviour {
    void Examples(){
        //here are useful variables in NetworkBehaviour that you can just use. there are a lot more
        bool auth = HasAuthority;//true if this instance is authoritative over this NetworkObject
                                 //this is false if we are on a client and the server has not given us authority
        bool client = IsClient;//returns true if we are a client or a host
        bool server = IsServer;//returns true if we are a dedicated server or a host
        bool host = IsHost;//returns true if we are a host!
        bool serverIsHost = ServerIsHost;//returns if the server is a host, regardless of if that is us or not
        bool owner = IsOwner;//returns true if we own this object. Useful for disabling inputs on character prefabs!
        
        ushort behaviourID = NetworkBehaviourId;//gets the id of this network behaviour
        ulong objectID = NetworkObjectId;//gets the id of the network object we are attached to
        NetworkBehaviour netbehaviour = GetNetworkBehaviour(behaviourID);//get the local instance of any 
                                                                        //NetworkBehaviour *on this NetworkObject*
        NetworkObject netobject = GetNetworkObject(objectID);//get the local instance of any network object by ID
    }
    //here are some helpful events. Again, there are many many more!
    
    void OnNetworkSpawn(){}//when we are spawned on the network. basically Start() but for netcode
    void OnDestroy(){base.OnDestroy();}//called when the gameobject is destroyed. *must* invoke base class method!
}
```

## Sync Components
Unity has some built-in components that make common multiplayer stuff super duper easy. Here they are!
- NetworkTransform: Automatically syncs position, rotation, and scale for you! You can also untick any values you do 
  not need synced to save on bandwidth. The default Authority mode is Server, but you can also set it to Owner, 
  which makes the transform client-authoritative :O
- AnticipatedNetworkTransform: Same as NetworkTransform, but has functions that allow you to move to an anticipated 
  position separate from your server authoritative position. This lets you implement client prediction! Note: You 
  still have to set up the [RPCs](#rpcs) to the server and give it your inputs yourself. 
[Here](https://github.com/Unity-Technologies/com.unity.multiplayer.samples.bitesize/tree/main/Experimental/Anticipation%20Sample) 
  is an official Unity example project with client prediction using this!
- NetworkRigidbody: Used in conjunction with NetworkTransform, it will disable the object's rigidbody on instances 
  that do not have authority over this gameobject, so that physics still works correctly. There is also a tickbox to 
  use the Rigidbody's velocity to help inform the NetworkTransform. Might be worth a go enabling it!
- NetworkAnimator: Click and drag in an Animator, and it will sync it automatically for you. If you set up a 
  character's animations with Unity's Animator, this will just sync it for you with no code and like 2 clicks. Its 
  super awesome!

## Network Variables
[📓](https://docs-multiplayer.unity3d.com/netcode/current/basics/networkvariable/)  
Network Variables are variables that Unity will automatically keep synchronized between the server and client 
instances of this script. Its awesome. Heres how to use it!
```csharp
//make sure you do this in a NetworkBehaviour derived class!!!

//Network Variables *must* be initialized before the object is created on the network!!
//They must also be value types. That means only primitives and structs are allowed :(
private NetworkVariable<int> number = new NetworkVariable<int>(5);//replace the int in the angle brackets with
                                                                  //any type you want!
private NetworkVariable<Vector3> syncedVector = new NetworkVariable<Vector3>(new Vector3(1f,2f,3f));

//changing a network variable can be done like this!
number.Value = 10;
syncedVector.Value = Vector3.one * 5;
Debug.Log(syncedVector.Value);
```
```csharp
//strings in C# are reference types, which means they cannot be used as a network variable
//to fix this, Unity made a bunch of string types that are value types, but have a fixed size
//just make sure you pick a type big enough for your string! Remember one ASCII character is 1 byte!
private NetworkVariable<FixedString32Bytes> smol = new NetworkVariable<FixedString32Bytes>("schmol");
//theres more types with sizes in-between!
private NetworkVariable<FixedString4096Bytes> beeg = new NetworkVariable<FixedString4096Bytes>("bheeeeg");
```
```csharp
//by default, network variables are server authoritative. You can change the read and write permissions like this
private static NetworkVariableReadPermission allCanRead = NetworkVariableReadPermission.Everyone;
private static NetworkVariableWritePermission clientOwnerCanWrite = NetworkVariableWritePermission.Owner;
private NetworkVariable<float> clientAuthoritative = new NetworkVariable<float>(5f,allCanRead,clientOwnerCanWrite);
```
```csharp
//since network variables can change even if we havent changed it, you may want to know when it changes.
//instead of checking every frame in update, you can use the OnValueChanged callback! We love the observable pattern!

private NetworkVariable<int> number = new NetworkVariable<int>(5);

void OnNetworkSpawn(){
    number.OnValueChanged += ChangeObserver;//dont do this in Start()!!
}

void ChangeObserver(int previous, int newValue){
    Debug.Log("number changed from "+previous+" to "+newValue);
}
```
```csharp
// you can use network variables with custom structs (not classes), but you have to define the serialization yourself.
struct CharacterData : INetworkSerializable{
    public Color color;
    public string name;//this works for some reason we dont ask questions we just take it
    public int type;
    
    public void NetworkSerialize<T>(BufferSerializer<T> serializer) where T : IReaderWriter {//serializer
        serializer.SerializeValue(ref this.color);//just serialize all the variables
        serializer.SerializeValue(ref this.name);//its EZ
        serializer.SerializeValue(ref this.type);//you dont have to serialize all of these if you only want some synced
    }
}

private static CharacterData defaultChar = new CharacterData {
    color = Color.white,
    name = "Roxy",
    type = 2
};

private NetworkVariable<CharacterData> charData = new NetworkVariable<CharacterData>(defaultChar);//woohoo!
```

## RPCs
[📓](https://docs-multiplayer.unity3d.com/netcode/current/advanced-topics/message-system/rpc/)  
RPC stands for remote procedure call. RPCs let you call a function in a NetworkBehaviour on the version of that
NetworkBehaviour in another game instance. You can specify what instance you would like the RPC to be run on with an
enum that you'll see below. As an example, you can have an RPC that regardless of where it is called, executes on
the server. You can have ones that go to the client owner, all clients, all clients except the owner, and more. RPCs can
get very confusing on where they are actually running. Do your best, DM me if u get confused, and remember that they are
always called on the same network object, just on a different instance of the game.

```csharp
//you can declare an rpc like this
[Rpc(SendTo.Server)]//this attribute makes the function an RPC and sets its destination
void SpaghettiRpc(){//your function name *must* end in "Rpc" or Unity gets madge
    Debug.Log("Hello!");
}

//you call an rpc like this
void Update(){
    if (Keyboard.current.spaceKey.wasPressedThisFrame){
        SpaghettiRpc();//call our rpc. This will print "Hello!" on the server *only*
                       //regardless of whether it was called on the server or a client
    }
}
```
```csharp
//Rpcs can have parameters, but just like with network variables, they must be value types
//except strings work with these for some reason. Yay!

[Rpc(SendTo.Server)]
void ParamServerRpc(int number, string msg){
    Debug.Log(msg);
}

void Update(){
    if (Keyboard.current.spaceKey.wasPressedThisFrame){
        ParamServerRpc(5, "Hello Server! ^-^");
    }
}
```
```csharp
//the target destination of the RPC is specified by the value of the SendTo enum that you set in the attribute
//if the rpc is called on the same instance that it is targeting, it works like a normal function
//there are more of course, these are the most useful ones imo

[Rpc(SendTo.Server)]//run on the server
void ServerRpc(){}
[Rpc(SendTo.NotServer)]//run on all clients. Host is not included
void ClientRpc(){}
[Rpc(SendTo.ClientsAndHost)]//run on all clients. Host is included! ^-^
void ClientAndHostRpc(){}

[Rpc(SendTo.Owner)]//run on the owner of this network object
void OwnerRpc(){}
[Rpc(SendTo.NotOwner)]//run on everything but owner of this network object
void NotOwnerRpc(){}

[Rpc(SendTo.NotMe)]//run on everyone else!
void ScreamRpc(){}
[Rpc(SendTo.Everyone)]//run on everyone!!!
void AtEveryoneRpc(){}

[Rpc(SendTo.SpecifiedInParams)]//send to a specific instance, specified in the RpcSendParams struct
void YouInParticularRpc(RpcParams settings){}

void DespiteEverythingIAmStillAFunction(){
    ulong clientId;//get this via some method. Theres a good way in the next code block :)
    RpcParams targetSingle = RpcTarget.Single(clientId,RpcTargetUse.Temp);//targets client with ID clientId
    YouInParticularRpc(targetSingle);
    
    ulong[] clientIds;
    RpcParams targetMultiple = RpcTarget.Group(clientIds,RpcTargetUse.Temp);//targets all these client IDs
    YouInParticularRpc(targetMultiple);//yes u can change the same Rpc's destination at runtime, yes thats cool
}

```
```csharp
// you can optionally include a RpcParams object, and unity will populate the recieve data for you!
// you can use this in conjunction with the custom Rpc targets in the last code block
[Rpc(SendTo.Server)]
void SenderInfoRpc(int putUrOtherParamsBeforeNotAfter, RpcParams info = default){
    ulong clientId = info.Receive.SenderClientId;//get the client Id of whoever sent this Rpc!
    Debug.Log(clientId);
}

void Update(){
    if (Keyboard.current.spaceKey.wasPressedThisFrame){
        RpcInfoServerRpc(5);
    }
}
```
Note: When you look up tutorials for Netcode for GameObjects, they will likely be using attributes called [ServerRpc]
and [ClientRpc] instead of just [Rpc(SentTo.Bla)]. The reason is that [ClientRpc] and [ServerRpc] used to be how you 
specified the destination of the RPC. However, those attributes got deprecated in Unity 6. You can still use them if 
you wish to follow tutorials as closely as you can, but they will not work forever. You can replace [ServerRpc] with 
[Rpc(SendTo.Server)] and [ClientRpc] with [Rpc(SendTo.ClientsAndHost)] and the code should still all work the same!

# 📈 Profiler
[📓](https://docs.unity3d.com/Manual/Profiler.html)  
The Profiler is a powerful built-in tool to the Unity editor that lets you monitor and diagnose how your game is 
performing. You can access it by clicking Window > Analysis > Profiler. The profiler is broken up into modules. Each 
module will report data about one specific aspect of your game. You can see them along the left column of the window.
The most useful ones are CPU, Rendering, and Memory. You can toggle modules on or off in the dropdown in the top 
left of the profiler window. To actually start profiling, play your game. Live data will start streaming across all 
of your enabled modules. If you click on any of the charts of any module, Unity will pause your game and give you a 
deeper breakdown at the bottom of the window. What this looks like varies from module to module, but for the CPU 
module, Unity gives you a chart showing a bar for every script on every thread and exactly how long it took to 
execute. Keep in mind, when you actually build your game, the editor loop block will be gone! You can scrub through 
time by clicking anywhere on the top bar, or clicking and dragging the white line going down the center of the 
profiler chart. At the top of the window, there are controls for frame advance, clearing the data buffer, call 
stacks, saving and loading profiler data, and [Deep Profiling](#deep-profiling).

## Profiler Markers
[📓](https://docs.unity3d.com/Manual/profiler-adding-information-code.html)  
Profiler Markers lets you profile specific sections of code and even make your own profiler modules! As always, 
there is a whole rabbit hole to go down here, but these are the basics.

Adding markers to your code is super easy! You can do it just like this:
```csharp
static readonly ProfilerMarker marker = new ProfilerMarker("My Code Marker");

void Update() {
    marker.Begin();
    Debug.Log("Catch me if you can!!");
    marker.End();
}
```
This marker will show up in the CPU module as a block below whatever monobehaviour event it originated from.

Optionally, you can also pass in a string or number variable into the .Begin() function to give some context about 
this specific run of this code (like maybe a level name or enemy count or something).
```csharp
static readonly ProfilerMarker marker = new ProfilerMarker("My Code Marker");

void Update() {
    int counter = 5;
    marker.Begin(counter);
    Debug.Log("Catch me if you can!!");
    marker.End();
}
```

## Deep Profiling
[📓](https://docs.unity3d.com/Manual/profiler-deep-profiling.html)  
By default, Unity (outside of its own stuff) will only track the timings of your monobehaviour event functions 
(Start, Update, etc) and any custom [Profiler Markers](#profiler-markers) that you have set up. However, at the top 
of the profiler window, you can enable Deep Profiling. Deep Profiling will add markers to every single C# method 
call and track the timing of all of them. The reason this isn't on by default is because it takes a ton of memory 
and resources to do this. Your game *will* run slower when this is enabled, so only compare the relative timings you 
get when deep profiling. Unity states in their documentation that this is only meant for smaller projects and games. 
For bigger projects, the editor may run out of memory before it can even start running the game and crash. Try to 
reserve deep profiling for when you are truly desperate, and use [Profiler Markers](#profiler-markers) for 
everything else.

# 👷‍♀️ Making Builds
[📓](https://docs.unity3d.com/6000.0/Documentation/Manual/build-profiles.html)  
I thought I would put in a little section here about making builds of your game. Unity 6 introduced a whole new 
world of build tools that allows you to make build profiles, which lets you change aspects of your game depending on 
the platform (windows, mac, linux) and/or build type (debug, release, dedicated server). The new Build Profiles window
replaces the old Build Settings windows from previous Unity versions. You can open in by clicking File > Build Profiles
to get started!

## Shared Settings
Shared settings are similar to the old Build Settings window from previous Unity versions. They are basically the 
default settings any build is based on unless they are overriden. The default player settings are located under
Edit > Project Settings > Player. You can also get to them by clicking the Player Settings button at the top of the 
Build Profiles Window. The default scene list is located in the Build Profiles window. If you look on the left, 
there is a list of supported platforms. At the top of them is a section called Scene List. Here you can add scenes 
to your build like you would in Unity before. Build profiles can override this list if you want them to!

## Platforms
Along the left of the Build Profiles window, there is a list of all the platforms supported by Unity that you can 
export for. Platforms that are greyed out are not currently installed. If you click one of them, it will prompt you 
to install that platform from the Unity Hub. For platforms that are installed, you can click them to configure settings
for just that platform. These also count as shared settings that all build profiles inherit from.

## Build Profiles
[📓](https://docs.unity3d.com/6000.0/Documentation/Manual/BuildSettings.html)  
You can create Build Profiles in the bottom left of the Build Profiles window. Build Profiles are saved as an asset in
your project, which means they can be re-used or submitted to version control. When you go to create a build profile,
Unity will prompt you for what platform you would like this build profile to be for. You can select any of the ones you
have installed. Then click Add Profile. Now select your new build profile and if it is not already and click Switch
Profile. This will make it the active profile for your project! Build Profiles allow you to do several things, including
overriding player settings, overriding asset imports, and setting up custom scripting defines. Check out the 
documentation to learn more! Note: Scripting defines are a bit advanced but also super useful. They essentially
let you make variables that tell the compiler to conditionally include or exclude sections of your code. You use them
by putting `#if MY_SCRIPT_DEFINE` on its own line and then later `#endif`. [Here](https://docs.unity3d.com/6000.0/Documentation/Manual/custom-scripting-symbols.html)
is the documentation for them.

## Addendum
It's kinda obvious but I feel like I can't have a section called "Making Builds" and then not tell you that you make
a build by clicking either the Build or Build and Run button. Build just builds the game, Build and Run builds it and
then runs that build. You're welcome! ^-^

# 🏗️ ProBuilder
[📓](https://docs.unity3d.com/Packages/com.unity.probuilder@6.0/manual/index.html)
ProBuilder is a Unity package that allows you to quickly an easily create 3d objects inside the editor! It is 
intended for prototyping, testing, and design, but if you put enough time into it you can make some great 3D models! 
Not that I recommend that at all.

## Setup
Make sure you have the ProBuilder package installed from the Package Manager. That's all! 👍

## Creating Shapes
To get started with ProBuilder, you need to create a ProBuilder shape. There used to be a dedicated window for doing 
everything with ProBuilder, but now it is built directly into the editor UI. At the bottom of your toolbar in the 
scene window, after the Transform tool, there should be two buttons in their own section: Create Cube and Create 
Polyshape. Click Create Cube to make our first ProBuilder shape. The way ProBuilder shape tools work is that you 
first create a 2D slice of your shape, and then raise it up on the Y axis. To create a cube, hold down left-click 
where you want one corner of the cube, then drag to where you would like the opposite corner to be, and release. 
After you release, move your mouse up to define the height of the cube. When you are happy with it, left-click one 
final time to confirm. Now you have a cube! You can change the size of any ProBuilder shape after the fact by 
selecting it in the hierarchy and editing the Size variable of the ProBuilder Shape component in the Inspector. 
Alternatively, when you select a ProBuilder shape, an Edit Probuilder Shape tool gets added to your Scene Tools 
Toolbar, and you can use that to change the bounding box of your shape! Note: The click-and-drag shape creation 
tools are a lot more useful when you enable the editor's grid snapping feature!

To make a shape that isn't a cube, hold down left-click over the Create Cube tool. A little window will appear that 
lets you select a lot of other shapes! Release left click over any other shape to switch to it. Creating any of the 
other shapes works the same way as the cube. You click and drag a flat box and then raise your mouse to specify the 
height. The shape will fill the bounding box you specify. Notice, some of the other shapes will have more options in 
the ProBuilder Shape component after you make them. For instance, the sphere lets you specify a number of 
subdivisions, and the cylinder lets you specify a number of sides. You can always change these later! Underneath the 
Create Cube tool in the Scene Tools Toolbar, there is a Create Polyshape tool. For that tool, left click somewhere 
to create a point, then click somewhere else to make another point. Keep clicking to draw out the base of whatever 
shape you want to make. Once you click back on the first point you made, the shape will close, and it will enter 
height mode. Move your mouse up until you are happy with the height and left click. As always, you can change it 
later in the PolyShape component in the Inspector.

## Mesh Editing
Once you make a shape in ProBuilder, you can edit its mesh directly! If you select a ProBuilder shape, an orange 
grid tool will appear at the top of your Scene Tools Toolbar. When clicked, this will change the rest of the scene 
tools (transform, rotation, scale) to work on mesh selections instead of gameobject selections. When in mesh mode, 
there will also be new buttons at the top of the scene window to switch between vertex, edge, and face selection. 
Now you can select and translate shape meshes as your heart desires! To modify the actual topology of the mesh, all 
the modeling tools of ProBuilder now live in the right click menu. The options that appear in the right click menu 
depend on if you are in vertex, edge, or face selection mode. They operate only on what you have currently selected, 
so if you don't have a valid selection for a tool it will be greyed out. When you are done, click the orange 
grid tool again to put your scene tools back into the normal gameobject mode. Note: If you edit a shape's mesh like 
this, you can no longer change the settings of the original shape without reverting all of your changes.

## Advanced Tools
If you need more control over your ProBuilder meshes, there are more tools available! If you click Tools > 
ProBuilder > Editors, there are several windows that let you edit your meshes further. There is an editor for 
editing Materials, Smooth Shading, UVs, Vertex Colors, and Vertex Positions. When you have any of these windows open,
they will let you edit the currently selected ProBuilder mesh. I'm not going to go over all of these tools, but I 
think they are pretty self-explanatory!

## Exporting
If you want to export a ProBuilder mesh into another program, it is really easy! Select the meshes you want to 
export, then click Tools > ProBuilder > Export, and select what file type you would like to export. Normally I just 
do .obj, but there are other options. Select where you would like to save the file, hit Save, and tada! You're done!

# 🕶️ Shader Graph

# 🎆 VFX Graph

# 🫥 DOTS

This is just here for Roxy, pay no mind, move along!

Setup Notes:
- Go to Edit > Project Settings > Editor > Enter Play Mode Settings, and set to "Do not Reload Domain or Scene"
- Make sure your URP Renderer Asset had Forward+ lighting enabled

Notes:
- Add a subscene. Any gameobjects in the subscene will be converted to entities.
- above the inspector for gameobjects in a subscene, there is a circle button. this has authoring settings. 
  Authoring the gameobject mode that the entity is based on, and runtime is the preview of the entity that will be 
  created! You can also have multiple inspectors with different authoring settings!
- Click Window > Entities > Hierarchy to get the entities hierarchy window!
- Bust can be disabled or re-enabled with Jobs > Burst > Enable Compilation
