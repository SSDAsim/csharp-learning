## Strings 
### String Interning
Strings are **immuteable**. If you want to override the string, it will create a new memory location and link the variable name to that new memory location. But if you override the string with the same value, it does not create a new memory location to store the value. This is *C# string interning*.

### String Builder
Suppose you run a loop and in each iteration of the loop, you are concatenating something with the previous string. Now, in every iteration, the previous memory location will go for the garbage collection and new concatenated string will be stored in a new memory location. This may cause decrease in the efficiency of the program. To solve the above String Concatenation Problem in C#, the .NET Framework provides the **StringBuilder** class. As the name itself says everything, the string builder class in C# is used to build a string by concatenating the strings. If you use string builder then fresh objects are not going to be created every time you concatenate something to the string variable in C#.

With **StringBuilder**, every time the for loop runs it will not create fresh objects rather than it will use the same memory location i.e. the same old object which drastically improves the application performance.

## Properties in C#
### What is a Property in C#?
A Property in C# is a member of a class that is used to set and get the data from a data field (i.e. variable) of a class. The most important point that you need to remember is that a property in C# is never used to store any data, it just acts as an interface or medium to transfer the data. They are actually special methods called accessors. They help us to achieve the *Encapsulation Principle*.

### What are the Different types of Properties Supported by C#.NET?     
The C#.NET supports four types of properties. They are as follows

- Read-Only Property
- Write Only Property
- Read Write Property
- Auto-Implemented Property

## Difference Between Convert.ToString and ToString Method in C#
### Convert.ToString and ToString Method in C#
Both these methods are used to convert a value to a string. The difference is Convert.ToString() method handles null whereas the ToString() doesn’t handle null in C#.

## Checked and Unchecked Keywords in C#

### Understand Checked Keyword in C#
```csharp
    int a = 2147483647;
    int b= 2147483647;
    int c = checked(a + b);

    // this will throw an overflow exception
```

### Unchecked keyword in C#
Let us understand the need and use of unchecked keyword in C#. The unchecked keyword behaves almost the same way as the default behavior of the compiler.   
With the default behavior, compiler will throw a compile time error if there's an integral overflow. However, with the `unchecked` it will suppress this particular behavior of the compiler and there will be no compile time error.

## Boxing and Unboxing in C# with Examples

### Boxing in C#:
Boxing is the process of converting a value type (like int, double, struct) to a reference type (object). When a value type is boxed, a new object is allocated to the heap, and the value is copied into it.

### Unboxing in C#:
Unboxing is the reverse process of boxing, where a value is extracted from an object. It involves explicitly converting a reference type (object) into a value type. This operation also involves a copy operation, where the value is copied from the heap into the stack.

```csharp
{
    int x = 10;
    object y = x;   //Boxing
    int z = (int)y; //Unboxing
}
```

## Object Oriented Programming in C#

### Classes and Object 
In C# we have the below types of classes

1. Abstract Class
2. Concrete class
3. Sealed Class
4. Partial Class
5. Static Class

### Constructor in C# Class
### What does a Constructor have in C#?

- The constructor can have all the legal C#.NET legal statements except return statements with value.   
- We can place a return; in the constructor.
- It can have a throws clause which means we can throw an exception from the constructor.

### Copy Constructor in C#:
If we want to create multiple instances with the same values then we need to use the copy constructor in C#, in a copy constructor the constructor takes the same class as a parameter to it.    
Suppose your constructor takes 10 or 20 or more arguments, then this is some time taking process. We can overcome this difficulty using **Copy Constructor**. The copy constructor takes a parameter of same class type. How we can pass a class name as a parameter. This is because a class is a user-defined data type.

```csharp
public class CopyConstructor {
    int x;

    // Parameterized constructor 
    public CopyConstructor(int i) {
        x = i;
    }

    // Copy Constructor 
    public CopyConstructor(CopyConstructor Obj) {
        x = Obj.x;
    }

    public void Display() { }
}
```

This is how it will be utilized:
```csharp 
using System;
namespace CopyConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            CopyConstructor obj1 = new CopyConstructor(10);
            obj1.Dispaly();
            // initialize using copy constructor 
            CopyConstructor obj2 = new CopyConstructor(obj1);
            obj2.Dispaly();

            Console.ReadKey();
        }
    }
}

// obj1.x and obj2.x will both have value 10
```

### How many Constructors can be Defined in a Class in C#?
You can define any number of constructors in the class just make sure that *each and every constructor must have different signature* i.e. the number, type and parameter order should be different. 

### Static Constructor in C#
Static constructor is explicitly declared using *static* keyword. In static constructor, you can not use any access modifiers like public, private, protected. 

```csharp 
public class Test
{
    // Static Constructor
    static Test()
    {

    }
}
```

### Points to Remember while working with Static Constructors in C#:
Static Constructors are responsible for initializing static variables and these constructors are never called explicitly.They are called implicitly and they are first to excute in the class.  

```csharp
using System;
namespace ConstructorDemo
{
    public class StaticConstructor
    {
        static StaticConstructor()
        {
            Console.WriteLine("Static Constructor Executed!");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Main Method Exceution Started...");
            Console.ReadKey();
        }
    }
}

// Static constructor will be executed first and then the main method.
```

- The non-static constructors are never called implicitly, they are always called explicitly whereas the static constructor never called explicitly, they are always going to be called implicitly.   
- The program execution will start from the Main method but before executing any statement inside the Main method, it will first execute the Static constructor and once the Static Constructor execution is completed, then it will continue the execution of the Main method. So, the static constructor is the first block of code in a class to be executed.
- Static constructor cannot be parameterized, so overloading of static constructor is not possible. The reason is Static Constructor is executed implicitly and also as it is the first block to be executed in the class, so we do not get to pass it any value.

### Points To Remember About Static Constructor in C#:
1. There can be only one static constructor in a class.
2. It can’t be called explicitly, it is always called implicitly.
3. The static constructor should be without any parameters.
4. It can only access the static members of the class.
5. There should not be any access specifiers in the static constructor definition.
6. If a class is static then we cannot create the object for the static class.
7. It is called automatically to initialize the static members.
8. Static constructor will be invoked only once i.e. at the time of class loading.
9. It is not possible to initialize non-static data members within a static constructor

## Private Constructors in C# 
When a class contains a *private constructor* and it does not contain any other *public constructor*, then you can not create an object for that class outside of the class. But we can create object of the class within the class.     
**Use Case:** The use case of Private Constructor in C# is that if you don’t want your class to be instantiated from outside the class, then add a private constructor without any public constructor in your class.    

### Private Constructor Restricting Inheritance in C#

A child class requires a *publicly accessible constructor* to establish a *parent-child* relationship. That means if your class has a public constructor then you can inherit the class no matter if you have a private constructor or not.

#### Child class within the Parent Class

Consider that the Parent class has only private constructor and no public constructor. Now, if the Child class is from outside the Parent class then it is not accessible to the Parent class private constructor. But if the child class is an Inner class of the Parent class, then inheritance is possible.

**Tip:** If you want to restrict inheritance then don’t go for the private constructor, instead, make the Class *Sealed* which will restrict the class to be inherited from either outside or inside.    

### Static Class

We can access the static members as we are unable to create the instance as well as unable to make the inheritance relationship? You can access the static members of a class directly by using the class name and static members get memory allocation only once i.e. only one copy of the static members is available and that is too for the first time when the execution start.

### Is Private Constructor going to be Parameterless in C#?

In C#, constructors are overloaded. That means we can define multiple constructors with multiple parameters. In overloading, the only important thing is the name and the parameters and it does not consider access specifiers like private, public, protected etc as part of the overloading. So it is possible to define multiple private constructors in C#.

### What is Singleton Pattern in C#?

The Singleton Design Pattern ensures that only one instance of a particular class is goind to be created and then provide simple global access to that instance for the entire application.

### How to Implement Singleton Design Pattern in C#?

The following are the steps to implement the Singleton Design Pattern in C#.

1. there should only be one constructor in the class and that should be private and parameterless. It makes the class instantiable only within the class.
2. The class should be declared *sealed* which will make sure it can not be inherited. 
3. You need to create a private static variable that is going to hold the reference of the single created instance of the class. 
4. You need to create a public static method/property which will return the single-created instance of the singleton class. This method/property first checks if the instance of the singleton class is available or not. If available, it will return the instance. If not, it will create the instance and then return the instance. 

```csharp
using System;
namespace PrivateConstructorDemo
{
    public sealed class Singleton
    {
        private static int counter = 0;
        private static Singleton instance = null;
        private static readonly object Instancelock = new object();
        public static Singleton GetSingletonInstance()
        {
            lock (Instancelock)
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }
        private Singleton()
        {
            counter++;
            Console.WriteLine($"Singleton Constructor Executed {counter} Time");
        }
        public void SomeMethod(string Message)
        {
            Console.WriteLine($"Some Method Called : {Message}");
        }
    }
}
```

And the main method will be 
```csharp
using System;
namespace PrivateConstructorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton fromPlace1 = Singleton.GetSingletonInstance();
            fromPlace1.SomeMethod("From Place 1");
            Singleton fromPlace2 = Singleton.GetSingletonInstance();
            fromPlace2.SomeMethod("From Place 2");
            Console.ReadKey();
        }
    }
}
```

## Destructors in C# 

### What are Destructors in C#?

Destructors also called *Finalizers* in C# are used to perform any necessary clean-up when a class instance is being collected by the garbage collector. Destructor is explicitly called when the object of a class is destroyed.    
1. Destructor can't be parameterized.
2. It can't be overloaded. 
3. It can not be applied with any modifier e.g. private, public.

### When will the Object of a Class get Destroyed in C#?
The object of a class in C# will be destroyed by the garbage collector in any of the following cases

1. At the end of the program execution, each and every object that is associated with the program will be destroyed by the garbage collector.
2. The Implicit calling of the garbage collector occurs sometime in the middle of the program execution provided the memory is full so the garbage collector will identify unused objects of the program and destroys them.
3. The Explicit calling of the garbage collector can also be done in the middle of program execution by the programmer with the help of the “Collect()” statement so that if there are any unused objects associated with the program will be destroyed in the middle of the program execution.

### Pints to Remember while working with Destructors in C#:
1. Destructors are only defined for classes and not in structs.
2. They can not be called explicitly. The most we can do is to call the garbage collector using GC.Collect()

### Explicit Release of Resources using Dispose Pattern in C#:  

If our application is using an expensive external resource, then it is recommended to provide an explicit way to release the resources before the garbage collector frees the object. To release the resource, it is recommended to implement a Dispose method of the IDisposable interface that performs the necessary clean-up for the object. So, basically, we need our class to inherit from the IDisposable interface and provide the implementation.

## Garbage Collection in C#

Garbage collection is a routine or a background process thread that identifies which object are not being used by the program and de-allocates the memory to these objects. 

### Managed and Unmanaged Objects in .NET Framework:

Whenever you create an EXE or any web application using any .NET supported language, these applications are run under the control of *CLR* (Common Language Runtime). If your applications have unused objects, then CLR will clean those objects using the Garbage Collector.

However if you have any other EXE for example Skype, PowerPoint which are made with C++, or C, these will not be under control of CLR. Rather they will run in C++ Runtime environment or their specific environment.


#### Managed Code 
The codes that run under the complete control of CLR are called **Managed Code** in the .NET Framework. CLR will provide all the facilities and features of .NET to the managed code execution like Language Interoperability, Automatic Memory Management, Exception Handling Mechanism, Code Access Security, etc

#### Unmanaged Code

The code (EXE, Web App) that is not run under the control of CLR is called **unmanaged code**. CLR will not provide any facilities and features of .NET to the unmanaged code. Skype, PowerPoint, and Microsoft Excel do not require dot net runtime. They run under their own environment.

#### Managed Objects 

Managed objects are allocated on the managed heap and controlled by the .NET Garbage Collector (GC). These objects are typically instances of classes and structures defined in .NET. The GC automatically manages the memory for managed objects.

#### Unmanaged Objects

The memory of these objects is not managed by the .NET GC. These are objects allocated using the native code, such as call to windows API or using languages such as C or C++. *The developer is responsible for allocating and deallocating the memory of unmanaged objects.*

### Garbage Collection Generations in .NET Framework:

Suppose you have five managed objects in you program. Whenever any new objects are created, they are move into a *Generation 0 Bucket*. Garbage Collector will run as background process thread and continuously check if there are *unused managed objects* in the program.  
Let's say the application has two unused managed objects, GC will destroy these two objects and move the remaining objects into *Generation 1 Bucket*. Now if our application creates two new objects, they will be moved into *Generation 0 Bucket*.    
Now the GC will run again, starts from G 0 Bucket, if both objects are unused it will clean the memory and then it will check the G 1 Bucket and suppose one out of three objects is unused, GC will reclaim memory from that object. And move other two used objects into the G 2 Bucket. 

### What are Generations?

Generation define how long the object will stay in the memory. If an object is in G 0, it means that it is short lived and will be destroyed soon. 

### Why do we need Generations?

In large applications, going to check a generation for unused managed objects will be a bulky process. So we divide the generation into three kinds. By doing so, we know if an object is G 2, then it is long lived object and needed by the program so there's no point going and checking them again and again. However, if an object is in G 0, then we know it is short lived.    
In that way, we visit the G 0 more often than G 2.

**Note:** Garbage collectors will only clean up the managed code. In other words, for any unmanaged code, for those codes to be cleaned up, it has to be provided by unmanaged code, and the garbage collector does not have any control over them to clean up the memory.

### How does using a Destructor in a Class end up in a Double Garbage Collector Loop?

When you define a destructor in your class, the Garbage Collector before destroying the object, will go and ask the question to class, do you have a destructor, if you have a destructor, then move the object to the next generation bucket. In other words, it will not clean up the object having a destructor at that moment itself, even though it is not used. So, it will wait for the destructor to run, and then it will go and clean up the object. Because of this, you will find more objects in Generation 1 and Generation 2 than in Generation 0.

#### How to Overcome the above Problem?

This problem can be overcome by using something called the Finalized Dispose pattern. To implement this, your class should implement the IDisposable interface and provide the implementation for the Dispose method. Within the Dispose method, you need to write the clean-up code for unmanaged objects, and in the end, you need to call GC.SuppressFinalize(true) method by passing true as the input value. This method suppresses any kind of destructor and just goes and cleans up the objects.

## Differences Between Finalize and Dispose in C#

### Finalize Method in C#:

- **Purpose:** used for clean up operations before an object is garbage collected. It's typically overridden to release the unmanaged resources that the object holds. GC calls Finalize method automatically.
- Finalize is inherited from *Object* class. It should always call the Finalize method of the base if overridden to ensure that all resources are released properly. 

### Dispose Method:
- **Purpose:** part of *IDisposable* interface and is implemented to release both managed and unmanaged resources deterministically.
- Unlike Finalize, it is called explicitly in your code. Usually when you are done using an object.  
- when implementing Dispose, it's common to follow the dispose pattern, which includes a finalizer call (GC.SuppressFinalize(this)) to prevent Garbage Collector from calling Finalize if Dispose has already been called.  


## Access Specifiers in C#:

### Understand Type and Type Members in C#:

If you declare a class and its properties. The *class* is a **Type** and the properties are **Type Members**. Type only allows *internal* or *public* access specifier by default. However, the *type members* are allowed all 6 Access Specifiers by default.   

In general classes, structs, enums, interfaces, and delegates are called types, and variables, properties, constructors, methods, etc. that normally reside within a type are called type members. By default, if we have not specified any access specifier, then for the type it is going to be *internal* and for type members it is going to be *private*. 

### What are Assemblies in .NET Framework?

Assemblies are precompiled .NET code that can be run by CLR (Common Language Runtime).   
- Console Application => Assembly is EXE => can be run directly
- Class Library Project => Assembly is DLL => can't be run directly

### Access Specifiers for Type Members:

#### Scope of PRIVATE Member 

1. With the class: *YES*
2. Derived Class in the same Assembly: *NO*
3. Non-derived class in the same Assembly: *NO*
5. Derived class in other assemblies: *NO*
4. Non-derived class in other assemblies: *NO*


#### Scope of PUBLIC Member 

1. With the class: *YES*
2. Derived Class in the same Assembly: *YES*
3. Non-derived class in the same Assembly: *YES*
5. Derived class in other assemblies: *YES*
4. Non-derived class in other assemblies: *YES*

#### Scope of PROTECTED Member 

Protected members are available within the parent class(i.e. containing type) and also within the derived class (classes derived from the containing type).

1. With the class: *YES*
2. Derived Class in the same Assembly: *YES*
3. Non-derived class in the same Assembly: *NO*
5. Derived class in other assemblies: *YES*
4. Non-derived class in other assemblies: *NO*

#### Scope of INTERNAL ACCESS Member 

A member declared with *internal* access modifier is available anywhere within the containing assembly.

1. With the class: *YES*
2. Derived Class in the same Assembly: *YES*
3. Non-derived class in the same Assembly: *YES*
5. Derived class in other assemblies: *NO*
4. Non-derived class in other assemblies: *NO*

#### Scope of PROTECTED INTERNAL Member 

Protected internal members in C# can be accessed anywhere in the containing assembly i.e. in which it is declared or from within the derived class in other assembly. 

1. With the class: *YES*
2. Derived Class in the same Assembly: *YES*
3. Non-derived class in the same Assembly: *YES*
5. Derived class in other assemblies: *YES*
4. Non-derived class in other assemblies: *NO*

#### Scope of PRIVATE PROTECTED Member 

Private Protected members in C# can be accessed within the class and within the derived classes in the same assembly but not in other assembly.

1. With the class: *YES*
2. Derived Class in the same Assembly: *YES*
3. Non-derived class in the same Assembly: *NO*
5. Derived class in other assemblies: *NO*
4. Non-derived class in other assemblies: *NO*

### Access Specifiers for Type (e.g. class, struct etc):

If a type is declared as *internal* then it is only accessible and available within the same assembly. (Can be inherited only in the same assembly where it is created). In case of *public*, then it can be accessed within same assembly where it is created as well as in other assemblies.

## Encapsulation in C#

### What is the Encapsulation Principle in C#?

Encapsulation hides the internal state and functionality of an object and only allows access through a public set of functions. It binds the state (i.e. Data Memebers) and Behavior (i.e. Methods) into a single unit.

#### How can we Implement Data Hiding or Data Encapsulation in C#?

In C#, Data Encapsulation is implemented.

1. By declaring the variables as private (to restrict their direct access from outside the class)
2. By defining one pair of public setter and getter methods or properties to access private variables from outside the class.

#### What are the Advantages of Providing Variable Access via Setter and Getter Methods in C#?

- allows us to validate user-given data before storing the value in the variable.

## Abstraction in C#

### What is Abstraction in C#?

A process of defining a class by providing the necessary details to call the object operations (i.e., methods) by hiding its implementation details. It is called *abstraction* in C#. It means we need to expose what is necessary and compulsory, and we need to hide unnecessary things from the outside world. Programmatically, we can define abstraction as the process of hiding implementation details of the object’s feature and showing only the essential information of the feature to the user.   

#### How to Implement Abstraction Principle in C#?

Abstraction in C# can be implemented in two ways.
1. Using Interface
2. Using Abstract Classes and Abstract Methods

Both *interface* and *abstract classes* and abstract methods provide some mechanism to hide the implementation details by only exposing the services.

### Encapsulation vs Abstraction in C#

1. Encapsulation => data (or information) hiding, Abstraction => detailed (implementation) hiding
2. With the Encapsulation Principle, we group data members and member functions into a single unit called class, interface, enum, etc. On the other hand, with the Abstraction Principle, we are exposing the interface or abstract class to the user and hiding implementation details, i.e., hiding the child class information.

## Inheritence in C#

### Why is Parent Class Constructor Accessible to Child Class? (And Rules of Inheritence in C#)

- The reason to call the parent class constructor first is we have to initialize the data members of the parent first in order to pass them to the child class. 


- We can Initialize a Parent class variable by using the child class instance to make it a reference variable so that the reference will be consuming the memory of the child class instance. But in this case, also, we cannot call any pure child class members using the reference.
```csharp
{
    static void Main(string[] args) {
        // A is parent class while B is child class
        A p;
        B q = new B();

        // we can initialize a Parent class variable using child class instance
        p = q;

        // now using 'p', you can call any member of A class (i.e Parent class)
        p.method1(); 

        // you can not call a member which is purely defined in the child class

        // you need to rememebr References are just pointers to instances. 'p' is just a Reference while 'q' is an instance. Memory will be allocated for the instance and not for the reference.   
    }
}
```

- Object is the parent class for all the classes defined in our Base Class Library as well as all the classes that we defined in our application, so the members (Equals, GetHashCode, GetType, and ToString) of the Object class are accessible from anywhere.

#### GetType()

The *GetType()* method returns the exact runtime type of the current instance. It will tell you the fully qualified name i.e. namespace and class name.
```csharp 
Console.WriteLine($"obj1 type: {obj1.GetType()}"); 
```

- In C#, we don’t have support for multiple inheritances through classes. What we are provided is only a Single Inheritance through classes.

- If parent class has a parameterless constructor, then it will be called implicitly when the child object is created. However, if the Parent class has *Parameterized Constructor*, then it is the responsibility of the programmer to call the Parent constructor explicitly and pass the parameters to the constructor. 
```csharp
public class A {
    public A (int x){
        //.....
    }
    
    //...
}

// now the child class will have to pass the paramter using 'base' when calling the constructor
public class B : A {
    public B() : base(10){
        //....
    }

    // alternatively you can pass dynamic value  
    public B(int num) : base(num){
        //...
    }
    //....

    // while making an instance of the class (using dynamic value)
    B obj1 = new B(10);
}
```

### Types of Inheritence 
If a child class has one immediate Parent class, call it **Single Inheritance**, and if more than one immediate Parent class, call it is **multiple inheritance**.

```csharp
{
    // single inheritence 
    public class Child : Parent {

    }

    // multiple inheritence
    public class Child : Parent1 , Parent2 {

    }
}
```

### Classification of Inheritance in C#

1. **Implementation Inheritence:** Whenever a class is derived from another class, then it is called Implementation Inheritence. 
2. **Interface Inheritence:** Whenever a class is derived from an interface, then it is known as Interface Inheritence.


## IsA and HasA Relationship in C#

### IsA Relationship(Inheritence)

IsA relationship is achieved through *inheritence*. In an IsA relationship, the derived class is a *specialized* version of the base class.   
#### Characteristics:

- **Inheritance**: The derived class inherits properties and methods from the base class.
- **Polymorphism**: The derived class can override or extend the functionalities of the base class.
- **Substitutability**: Objects of the derived class can be treated as base class objects.

### HasA Relationship (Composition):

This relationship denotes usage or composition. This indicates that object from one class *contains* or *is composed* of objects from another class. This relationship is less tightly coupled than inheritence. 

#### Characteristics:

- **Composition**: A class contains or is composed of objects from another class. 
- **Independence**: The contained object (e.g. Engine) can exist independently of the container (e.g. Car).
- **Encapsulation**: The internal working of the contained object is usually hidden from the outside class. 
- **Flexibility and Reusability**: Objects can be easily replaced or changed, providing more flexibility in code design.

Suppose a class called Cuboid is inherited from rectangle so we can say that *Cuboid* **IsA** *Rectangle*.  
Suppose our class *Table* has a top variable of type *Rectangle*. That means *Table* has an object of *Rectangle* class. So this is *HasA* relationship. **Table HasA Rectangle.**

*Private* members are acessible only with the class, *protected* and *public* members are accessible within the derived classes (*IsA* relationship) and *public* members are accessible outside the derived classes (*HasA* relationship)   

### How do you decide what to implement between IS-A and HAS-A?

Ask the question yourself. For example, if I ask you the question, which statement gives you more sense from the two statements below?
```
Employee IS-A Address
Employee HAS-A Address
```

Then definitely, you will tell Employee HAS-A Address gives more sense than Employee IS-A Address. If I ask you, which statement gives you a better sense of the two statements?
```
BMW IS-A Car
BMW HAS-A Car
```
Then, your answer will be definitely BMW IS-A Car.   
**Note:** In C#, the *IS-A relationship* is implemented using **Inheritance**, and the *HAS-A relationship* is implemented using **Composition**, i.e., declaring a variable. So, whenever we declare a variable of one class inside another class, we call it a Composition, or you can say HAS-A relationship.

## Generalization and Specialization

### Specialization
Suppose Rectangle is a class and Cuboid class is inherited from it. Now, does *Rectangle* exists? Of course, it does. So, in specialization, the parent is existing and the child is defined later. 

### Generalization
In generalization, the child class was existing then we define the base class. Suppose *Car* is a general class. Does Car exists? No it does not. It is just a virtual term. Does its child (INNOVA, BMW) exist? They do. So a *Car* is just a term and not an actual thing.     

In *specialization*, the base class has something to give to the child class whereas, in *generalization*, the base class doesn’t have anything to give to their child classes. Just their purpose is to group them together so that we can easily manage all those things.

**Note:** Both generalization and specialization achieve using only *inheritance*. So, specialization is a top-down approach and generalization is a bottom-up approach.

**Purpose:** The purpose of generalization is *Polymorphism* while the purpose of specialization is *to share its features* with its child classes.

## Abstract Classes and Abstract Methods in C# 

### Abstract Methods in C#

- In C#, *abstract methods* are declared within an abstract class or interface. 
- They do not have any function body or implementation at the time of declaration
- the responsibility for implementing the function is delegated to concrete(non-abstract) classes that derive from that abstract class or interface. 

```csharp
// you should explicitly use the abstract modifier in order to declare an abstract method.
public abstract void Add(int num1, int num2);
```

### Abstract Classes in C#

- Abstract classes serve as a blueprint for other classes. 
- Abstract class can not be instantiated directly, but they can serve as a base class to derive child classes from them. 
- We must define the abstract method within the abstract only and we can not just define them anywhere. 
- it imposes some restrictions on the Child classes. And children or Child classes have to follow or fulfill those restrictions. And that is the basic idea of abstract class in C#
- every abstract method declared in abstract must and should be implemented by Child class successfully, otherwise we will get a compile-time error.
- Abstract class can contain non-abstract methods.
- non-abstract class => non-abstract methods
- abstract class => abstract + non-abstract methods
- To consume the non-abstract methods of the abstract parent class, the child class must first implement all the abstract methods of the abstract parent class.
- The abstract class does not have any static members. If there are any static members, you can call them directly using the class name. But, for calling non-static members, we need an instance..
- An abstract class may or may not have abstract methods. But if a class contains an abstract method then it must be declared as abstract.
```csharp
public abstract class Calculator {
    public abstract void Add(int num1, int num2);
}
```
### Why Abstract Class Cannot Be Instantiated in C#?

Its abstract methods cannot be executed because it is not a fully implemented class. If the compiler allows us to create the object for an abstract class, we can invoke the abstract method using that object, which CLR cannot execute at runtime. Hence, to restrict calling abstract methods, the compiler does not allow us to instantiate an abstract class.

#### Implementing Abstract Methods in Child Class

```csharp
public class AbsChild : AbsParent
{
    public override void Mul(int x, int y)
    {
        Console.WriteLine($"Multiplication of {x} and {y} is : {x * y}");
    }
    public override void Div(int x, int y)
    {
        Console.WriteLine($"Division of {x} and {y} is : {x / y}");
    }
}

// this is how we implement abstract methods from parent class in child class. Note the 'override' keyword.
// Now child can consume the non-abstract methods of the parent
```

### Abstract Classes and Abstract Methods Interview Questions

#### Can we Create a Reference for the Abstract Class in C#?
Yes we can create a reference for the abstract class in C# and make it hold the instance of the child class. 

```csharp
    // child class instance
    AbsChild absChild = new AbsChild();
    // creating parent class reference and holding child class instance
    AbsParent absPar = absChild;
```

**Note:** The parent class references can also call the child class overridden members but cannot call the pure child class members.

#### When to use Abstract classes and Methods in C#?

- **Common Base:** When you have several classes with common properties and methods.
- **Enforce a Contract:** Enforce a contract to which the derived classes must adhere. 
- **Flexibility:** Abstract class can contain abstract as well as concrete methods. Giving dervied classes the flexibility to implement parent class methods or override them with their specific implementation.
- **Implement Polymorphism:** You can create a collection of objects of different derived classes but treat them uniformly through the abstract base class or interface.

#### Why should the method have an abstract keyword if it does not have a body in C#?

In a class, we are allowed only to define a method with the body. Since we are changing its default behavior (which means removing its body) it must have the abstract keyword in its prototype.

#### When Should a Class be Declared as Abstract in C#?

1. If the class has any abstract methods, then we need to declare the class as abstract.
2. If the child does not provide implementation to any of the parent abstract methods, then again, the child class needs to be declared as an abstract class.
3. If the child class does not provide implementation to any of the methods of an interface, then the child class needs to be declared as an abstract class as well as needs to declare the method as abstract. By default, Interface Methods are public and abstract.

#### Will abstract class members be created when a subclass object is created?

Yes, its non-static members get memory when its concrete sub-class object is created.

#### Can we Declare an Abstract Method as Static in C#?

No, we are not allowed to declare an abstract method as static in C#. It leads to Compile Time Error. If the compiler allows us to declare it as static, it can be invoked directly using the class name which cannot be executed by CLR at runtime.

#### Can we Declare an Abstract Method as Sealed/Private in C#?

No because it has to overridden in the child classes. If we will try to use sealed then we will get a Compile Time Error. 

#### Can we Declare a Concrete Class as Abstract in C#?

We can define an abstract class with only non-abstract methods. Defining a class as abstract is a way of preventing someone from instantiating a class that is supposed to be extended first.


## What is an Interface in C#?

- It defines a contract or set of rules, a class must adhere to. 
- It specifies a list of methods, properties, events or indexes a class implementing the interface must provide. 
- Interfaces allow you to define a common set of functionality that multiple classes can share.
- Like class, interface is also a user-defined datatype.
- If a class has an interface as a Parent, then class is responsible for implementing all the abstract methods of the interface.
- A class can inherit from a class and interface(s) at a time.

### Differences Between Concrete Class, Abstract Class, and Interface in C#:

- **Concrete class** contains only Non-Abstract Methods
- **Abstract class** contains non-abstract as well as concrete methods.
- **Interface** contains only abstract methods.

**Note:** Every abstract method of an interface should be implemented by the child class of the interface without fail (Mandatory).

### How to Define an Interface in C#?

```csharp
interface ITestInterface
{
    //....abstract members declarations

    // in case of abstract class 
    public abstract void Add(int num1, int num2);

    // but in case of interface 
    // by default this method is abstract and public
    void Add(int num1, int num2);
}
```

### Rules while working with the Interfaces:

- default scope for interface members is *public*. which is private in case of *class*
- by default, every member of an interface is *abstract*
- we can not declare fields/variables, constructors, destructors in interfaces.
- An interface can inherit from another interface. 
- every member of interface must be implemented successfully in the child class with modifier public and we do not need the 'override' keyword as we do in case of class.
- we can not create an instance of the interface but we can create a reference of an interface. The interface reference will hold the child class instance. We can only invoke the methods declared in the interface using the interface reference.

### What are the Members we can and can’t define in an interface in C#?

An interface can contain:

1. Abstract methods
2. Properties
3. Indexes
4. Events

An interface cannot contain:
1. Non-abstract functions
2. Data fields
3. Constructors
4. Destructors

### When to use Interface in C#?

- **Defining a Common Contract**: To ensure that multiple classes provide a common set of methods, properties, events, or indexers.
- **Implement Multiple Inheritence:** C# does not support multiple inheritence but it does support *multiple interface inheritence*.
- **Enforce a specific structure**
- **Implement Polymorphism:** 
- **Testing and Mocking:** Interfaces are valuable in unit testing scenarios. You can create interfaces for external dependencies or services and then create mock implementations of those interfaces for testing purposes. This enables you to isolate and test individual components of your codebase more effectively.
- **Collaboration in Teams:** Interfaces can help teams collaborate more effectively on large codebases. By defining clear interfaces, developers can work independently on different parts of a project, knowing that their code will integrate seamlessly as long as it adheres to the specified interfaces.
- **Dependency Injection:** When using dependency injection, interfaces often define dependencies that can be injected into classes. This helps achieve loose coupling and makes it easier to switch implementations at runtime.

## Multiple Inheritence 

### Why Multiple Inheritance Not Supported Through Classes in C#?

Multiple Inheritence is not supported cause it causes **Ambiguity Problem** . Consider if a class has two methods with the same signature. When you call any of them, the compiler will gets confused to call which one. Consider the following code

```csharp
internal class Program
{
    static void Main(string[] args)
    {
        Class3 obj = new Class3();
        obj.Test();
        // compiler will through error : The call is ambiguous between the following methods or properties: ‘Class3.Test()’ and ‘Class3.Test()’ 
    }
}

class Class3{
    public void Test() {}
    public void Test() {}
}
```

If a class is inherited from more than one parent, and the parents have a method with same signature then we will face same *ambiguity problem*. 

```csharp

public Class1{
    public void Test(){}
}

public Class2{
    public void Test(){}
}

public Class3: Class1, Class2{
    public void Test() {}
    // this will cause compile time error cause of ambiguity problem.
}

```

While in case of **Interfaces**, there is no implementation of the method. so class inherting form the interfaces will have its own implementation of the method, that is why there is no ambiguity problem in case of multiple inheritence by Interfaces.

```csharp 

public interface Interface1{
    void Test();
}

public interface Interface2{
    void Test();
}

public class MultipleInheritenceTest : Interface1, Interface2{
    // since both interface do not know about each other, each interface will think that this Test() is implementation of the Test() declared in interface.
    public void Test()
    {
        Console.WriteLine("Test Method is Implemented in Child Class");
    }
}

```

### If a class inherits an interface, what are the 2 options available for that class?

**Option 01**: Provide implementation for all the members inherited from the interface. 
**Option 02**: If class does not wish to provide implementation . 


## Multiple Inheritence Real Time Example

**Multiple inheritence**: inheriting from  more than one parent.   
Suppose we have a printer interface which has four methods. Now, We have two classes that will implement this interface. One of these two classes want all four methods of the interface but the other class wants only two of the four methods. Now, the class which want only two methods will have to implement all four methods (two other methods as well) which is not a good thing. So, what we can do is split our main iterface into two or three interfaces. Main one will have two methods and other methods are split into single method interfaces. 


```csharp

public interface IPrinterTasks {
    void Print(string PrintContent);
    void Scand(string ScanContent);
}

public interface IFaxTasks {
    void Fax(string content);
}

public interface IDuplexTask {
    void PrintDuplex(sting content);
}

// now using multiple inheritence the class can implement whichever interface it wants 
public class HPLaserJetPrinter : IPrinterTasks, IFaxTasks, IPrintDuplexTasks {
    //......
}

class LiquidInkjetPrinter : IPrinterTasks {
    //....
}
```

## What is Polymorphism in C#?

Polymorphisms mean existance of something in more than one form. In the programming world, these things can be operators or functions.    
Polymorphism is a concept by which we can perform a single task in different ways. That is, when a single entity behaves differently in different cases, it is called polymorphism in C#. The term polymorphism is an object-oriented programming term that means a function or an operator behaves differently in different scenarios.    

Technically, we can say that when a function shows different behaviors when we pass different types and numbers of input values, then it is called Polymorphism in C#.   


### Types of Polymorphism 

1. Static Polymorphism / Compile Time Polymorphism / Early Binding 
- Method Overloading 
- Opertor Overloading
- Method Hiding
2. Dynamic Polymorphism / Run Time Polymorphism / Late Binding 
- Method Overriding

### Compile Time Polymorphism 

The function call is bounded to the class at the time of compilation; if the function is going to be executed from the same bounded class at run-time, then it is *Compile Time Polymorphism*. This happens in the case of Method Overloading because, in this case, each method will have a different signature, and based on the method call, we can easily recognize the method that matches the method signature.    

In Static Polymorphism, the behavior of a method is decided at compile time. That means the C# compiler binds the method call with method method definition/body during the compilation only. Therefore it is called **Compile Time Polymorhpism**.     

As the binding (link between method call and method definition) is perfromed at compile time, it is known as **Early Binding**.

### Run Time Polymorphism 

- Behavior of method is decided at run-time. 
- Common Language Runtime (CLR) binds the method call with the method body at runtime and invokes the relevant method during the runtime when method is called. 
- the function call is bounded to the class at the time of compilation, if the function is going to be executed from the other class rather than the class bounded at the time of compilation, then it is called **Run-Time Polymorphism**. 
- happens in the case of *Method Overriding*, in this case we have multiple methods with same signature i.e. Parent Class and the Child Class have the same method implementation. So, in this case, we will be able to know at runtime from which class the method is going to be executed. 
- It is also called **Dynamic Polymorphism** or **Late Binding**.

```csharp 
using System;
namespace PolymorphismDemo
{
    class Class1
    {
        //Virtual Function (Overridable Method)
        public virtual void Show()
        {
            //Parent Class Logic Same for All Child Classes
            Console.WriteLine("Parent Class Show Method");
        }
    }
    class Class2 : Class1
    {
        //Overriding Method
        public override void Show()
        {
            //Child Class Reimplementing the Logic
            Console.WriteLine("Child Class Show Method");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Class1 obj1 = new Class2();
            obj1.Show(); //Resolve at Runtime
            
            Console.ReadKey();
        }
    }
}

// we have same implementation of Show() in both parent and child. we are creating an instance of the child class and storing it in the reference of the parent class. In this case, from which Class the Show() is going to be executed will be decided at run-time only. 
```

#### Method HIDING

Method hiding happens when a derived class defines a method with the same name as a base class method using the new keyword. In method HIDING a base class reference variable pointing to a child class object will invoke the hidden method in the BASE class. Then method hiding is compile-time polymorphism.    

Runtime polymorphism in C# uses virtual, override, and dynamic dispatch in method definiton by the child.

## What is Method Overloading or Function Overloading in C#?

Approach to defining multiple functions under a class with a single name. However, the parameters of all those methods should be different (different in terms of number, type, and order of the parameters).    

If we are defining multiple methods with the same name but with a different signature in a class or in the Parent and Child Classes, then it is called Method Overloading in C#. That means C#.NET not only allows method overloading in the same class but also allows method overloading in Parent and Child classes.   

The **signature** of a method consists of the name of the method and the data type, number, order, and kind (Value, Ref or Out) of parameters. Signature of a method **does not** include the *return type* and the *params modifiers*. So it is not possible to overload a method just based on the return type and params modifier.

### Why Return Type is not considered as part of Method Overloading in C#?

The return types come into the picture at the end of the method execution.But here, the confusion is not at the end of the method execution, but the confusion is about where to start, and which method to invoke.So, the compiler does not have any clarity to start the method execution, and talking about the end of the method execution does not make any sense. So, this is the reason why return type is never taken into consideration while defining method overloading in C#.   

### When is a method considered an overloaded method in C#?

The rule we should check is both methods must have different parameter Types/Numbers/Orders. But there is no rule on return type, access specifier and access modifier means overloading methods can have their own return type (void, float, int, string, etc), own access specifier (public, private, protected, etc.), and access modifier (sealed, static, virtual, etc.) because overloading methods are different methods.

### Can we Overload Methods in the Same Class?

Yes, it is possible. No Compile Time Error, and No Runtime Error. Methods can be overloaded in the same or in super and sub classes because overloaded methods are different methods. But we can’t override a method in the same class it leads to Compile Time Error: “Method is Already Defined” because **overriding methods** are the *same methods with a different implementation*.

## Operator Overloading in C#

It's a type of polymorhpism in which an operator is overloaded to give it user-defined methods. By overloading the operators, we can give additional meaning to the operators like +-*/=.,= etc.   

In C#, it is possible to make operators work with user-defined data types like classes. That means the C# has an ability to provide the operator with a special meaning for a data type. For example, we can overload the + operator in a class like String so that we can concatenate two strings by just using +.    

### The syntax for C# Operator Overloading:

```csharp 
public static return_type operator + (Type t)
{
    // Statements
}
// where type must be struct or class
```

1. The return type is the return type of the function.
2. the operator is a keyword.
3. Op is the symbol of the operator that we want to overload. Like: +, <, -, ++, etc.
4. The type must be a class or struct. It can also have more parameters.
5. It should be a static function.

```csharp 
internal class Program
{
    static void Main(string[] args)
    {
        Complex C1 = new Complex(1, 2);
        Complex C2 = new Complex(3, 4);
        //Complex C3 = Complex.Add(C1, C2);
        Complex C3 = C1 + C2;
        C3.Display();

        Console.ReadKey();
    }
}

public class Complex
{
    private int real;
    private int img;
    public Complex(int r = 0, int i = 0)
    {
        real = r;
        img = i;
    }

    // operator overloading 
    //public static Complex Add(Complex a, Complex b)
    public static Complex operator +(Complex a, Complex b)
    {
        Complex temp = new Complex();
        temp.real = a.real + b.real;
        temp.img = a.img + b.img;
        return temp;
    }

    public void Display()
    {
        Console.WriteLine($"{real} + i{img}");
    }
}
```

## What is Method Overriding in C#?

Method overriding is an approach to implement Run-time Polymorphism. The process of implementing the super class non-static, non-private, and non-sealed method in the subclass with the **same signature** is called **Method Overriding**. Same signature means the name and the paramters (type, number and order of paramteres) should be the same.    

The reason of the method overriding could be that the Parent Class method is not fulfilling the logic of the child class method. Then the sub-class overrided the parent class method with requried business logic. Usually, in most real-time applications, the Parent Class methods are implemented with generic logic which is common for all the next-level sub-classes. The subclass method is treated as the overriding method and the superclass method is treated as the overridden method.

### How can we Override a Parent Class Method under Child Class in C#?

- method in the parent must be declard as *virtual* using the virtual keyword. Declaring method virtual means making it available to be overridden. 
- child class overrides the parent class method using *override* modifier. (overriding parent class method is not mandatory

```csharp
public class Class1{
    // virtual function (overridable)
    public virtual void Show(){
        //..some generic logic
    } 
}

public class Class2 : Class1{
    // overriding parent class method is optional
    public override void Show(){
        //..child specific implementation
    } 
}

class Program {
    static void Main(string args[]){
        Class1 obj1 = new Class2();
        obj1.Show(); // this will execute the child class Show()

        Class2 obj2 = new Class2();
        obj2.Show(); // this will also execute the child class Show()
    }
}
```

Super class reference variable can hold the subclass object reference but the reverse is not possible i.e. child class reference variable can never hold the super class object reference. (cause child will have all the parent methods but the parent may not have all the methods of the child).

```csharp 
Parent obj1 = new Child();

// obj1 => reference variable type = Parent
// obj1 => reference to object whose type = Child

// Compilation => Compiler will check the reference variable type
// Runtime => CLR will check the Object Type 

```

- At Compilation time: the compiler will check the *type of the reference variable* and will check if that method or function is available in that type or not. If available then compilation will be done successfully and if not available then compilation will fail and you will get a compilation error.  In our example, the Show method is available in Class1 (type of the reference variable obj1) and hence compilation is successful.
- At the time of program execution, *CLR* will check the object type (i.e. Child in our case) and is going to execute the method from that reference *object type*. If the method is not available in corresponding object type, it will try to execute the method from the Parent class of the object.  In our case, the Show method is available in the class Class2 and hence this method is going to be executed from the class Class2.

### What is Dynamic Polymorphism or Runtime Polymorphism?

The function call is bounded to the class at the time of compilation, if the function is going to be executed by CLR from a different class at run-time rather than the class bounded at compilation-time, then it is called **Run-Time Polymorphism** in C#. In this case, we will be able to know at runtime from which class the method is going to be executed.   
It is also called *Dynamic Polymorphism* or *Late Binding* as at Run-time we will be able to know from which class the method is going to be executed.

### What is Static Polymorphism or Compile Time Polymorphism?

The function call is bounded to the class at the time of compilation, if the function is going to be executed from the same bounded class at run-time, then it is called Compile-Time Polymorphism in C#. This happens in the case of Method Overloading because, in the case of overloading each method will have a different signature and based on the method call, we can easily recognize the method which matches the method signature.

It is also called *Static Polymorphism* or *Early Binding* as at the Compilation time we will be able to know from which class the method going to be executed.

### What if Parent Class virtual method is not overridden in Child Class?

Suppose, a child class does not override parent class method but still calls it, then what is going to happen? 
- Compiler at compile time will look to bind the method call with the method definition. if method is not found in child class it will look in the parent class. If found in parent class then compilation is successfull. 
- At execution time, CLR will try to execute the method from the child class. If not found in child class, the CLR will go to the parent class and tries to execute method from there. 

### How can we execute the superclass method if it is overridden in the sub-class in C#?

Once we re-implement the parent class methods under the child classes, then the object of the child class calls its own method but not its parent class method. But if you want to still consume or call the parent class’s methods from the child class, then it can be done in two different ways.

- By creating the parent class object under the child class, we can call the parent class methods from the child class, or 

```csharp 
class Class1
{
    public virtual void Show()
    {
        Console.WriteLine("Parent Class Show Method");
    }
}
class Class2 : Class1
{
    public override void Show()
    {
        //Creating an instance of Parent Class
        Class1 class1 = new Class1();
        //Calling Parent Class Show method
        class1.Show(); 
        Console.WriteLine("Child Class Show Method");
    }
}
```
- by using the base keyword, we can call parent class methods from the child class, but this and the base keyword cannot be used under the static block.

```csharp 
class Class1
{
    //Virtual Function (Overridable Method)
    public virtual void Show()
    {
        //Parent Class Logic Same for All Child Classes
        Console.WriteLine("Parent Class Show Method");
    }
}
class Class2 : Class1
{
    //Overriding Method
    public override void Show()
    {
        base.Show(); //Calling Parent Class Show method
        Console.WriteLine("Child Class Show Method");
    }
}
```


### What is the difference between Method Overloading and Method Overriding in C#?

#### Method Overloading in C#

1. It is an approach to defining multiple methods with the same name but with a different signature means by changing the number, type, and order of parameters.
2. Overloading a method can be performed within a class as well as between the Parent-Child classes also.
3. To overload a parent class method under the child classes, the child class does not require to take any permission from the parent.
4. This is all about defining multiple behaviors to a method.
5. Used to implement static polymorphism.
6. No separate keywords are used to implement function overloading.

#### Method Overriding in C#

1. It is an approach to defining multiple methods with the same name and with the same signature means the same number, type, and order of parameters.
2. Overriding of methods is not possible within the same class it must be performed under the child classes only.
3. To override a parent class method under the child classes, first, the child class requires to take permission from its parent.
4. This is all about changing the behavior of a method.
5. Used to implement dynamic polymorphism.
6. Use the virtual keyword for the base class function and override keyword in the derived class function to implement function overriding.

**Note:** Since the Show() method is declared as virtual, the call uses dynamic dispatch (runtime polymorphism). At compile time, the compiler only knows the static type of the reference (for example, A) and cannot determine whether it refers to an instance of A or a derived class such as B. Therefore, the actual implementation of Show() is selected at runtime based on the object’s runtime type.

## Method Hiding/Shadowing 

It is an approach to re-implement parent class methods in child classes without the Parent's permission.   

There are two ways to re-implement parent class methods in child class:
1. Method Overriding 
- overridden method in parent class is defined using *virtual* keyword. 
- overriding method in child class is defined using the *override* modifier. 
- Parent knows about the child's overriding method. 

2. Method Hiding 
- there is no need to define the method in parent as virtual. 
- re-implemented method in child should be defined using *new* keyword. If not defined using *new*, the compiler will give you a warning to confirm that you know that a method with the same signature exists in parent and you are intentionally hiding this method.
- Parent's permission is not taken so Parent does not know about the re-implementation method in the child.   

```csharp 
public class Parent {
    // overridden method
    public virtual void Show(){
        //....Parent Show()
    }

    public void Display(){
        //...Parent Display
    }  
}

public class Child : Parent {
    // overriding method 
    public override void Show(){
        //...Child Show()
    }

    // Method Hiding/Shadowing
    public new void Display() {
        //...Child Display()
    }
}
```

Now consider a scenario, a Parent class reference is holding a child class instance. And you call both method, then from which class the method will be executed. 

```csharp
class Program {
    static void Main(string[] args){
        Parent obj = new Child();
        obj.Show(); 
        // this will execute the child class method cause it was overridden by the child and parent knows about this 

        obj.Display();
        // this will execute the Parent class method cause parent reference variable does not know about the Display() implementation in Child class.
    }
}
```

So, if a Parent class reference variable is created using the Child class object reference, then using that Parent reference we can call the Child class overriding methods but we cannot call the child class hiding methods.

## Partial Class and Partial Method 

**Partial Class** is split into more than one file. Physically it is split but logically it is the same class. It is defined using the *partial* keyword. 

```csharp 
// PartialEmployeeOne.cs

public partial class PartialEmployee {
    //.... some code 
}

// PartialEmployeeTwo.cs
public partial class PartialEmployee {
    //..rest of the code of Employee class
}
```

### Things to consider while working with Partial Classes 

- Note the 'partial keyword and even though the class is split into multiple files, the class name is going to be the same. 
- All the parts of the partial class must have the same access modifier
- If any part is declard as abstract/sealed, whole class will be considered as abstarct/sealed. 
- If any part inherits a class, then the entire type inherits the class. 
- It is not possible that one part of the partial class inherits one parent class and other part of the partial class inherits other parent class. 
- It is, however possible that different parts of the partial class inherit different base interfaces and then the final partial class inherits all the base interfaces. 
- Any members that are declared in a partial definition are available to all of the other parts of the partial class. 

### When do we need to use Partial Class in C#?

1. When working on large projects, splitting a class over separate files allows multiple programmers to work on it simultaneously.
2. When working with automatically generated source code, the code can be added to the class without having to recreate the source file. Visual Studio uses this approach when creating windows form, Web service wrapper code, and so on.

### Partial Methods 

- Partial Methods should and must be declared inside a Partial Class or Struct 
- Partial Method declaration and definition must be different. It may be in the same class but you can not declare and implement a partial method at once. You need to declare it and the implement it somewhere else (maybe in same part of the class or maybe in other part of the class)
- Partial Method signature should match it's implementation (name of the method, type, name, number and order of parameters). Also with same access modifier.
- By default, partial methods are private. 
- If no implementation found for a partial method, the compiler will remove the function signature during the compilation.
- The return type of the Partial method must be *void*.

## Sealed Class in C#

A class which can not be inherited by other class(es) is called a *Sealed Class*. ```sealed class Class1 { } ```. 

### Points to Remember

- Sealed class is completely opposite of abstract class. 
- It can not contain any abstract method. 
- It is specially used to avoid further inheritance. 
- The keyword sealed can be used with classes, instance methods, and properties.
- A sealed class should be the *bottom-most* class in the inheritance hierarchy. 
- Even if a sealed class can not be inherited, we can still consume the class members from any other class by creating object of that class. 

### Sealed Class in C#

Every method in parent class is by default a sealed method unless you declare it with *virtual* keyword. Because with *virtual* keyword, the method becomaes overridable.    

Make an overridden method as sealed to stop it from further overriding:
```csharp
namespace SealedDemo
{
    class Parent
    {
        public virtual void Show() { }
    }
    class Child : Parent
    {
        public sealed override void Show() { }
    }
    class GrandChild : Child
    {
        //'GrandChild.Show()': cannot override inherited member 'Child.Show()' because it is sealed
        public override void Show() { }
    }
}
```

### Points to remember 

- Every method by default is sealed hence they can not be overridden under the child class. 
- If you declare a method as *virtual* in parent class then it can be overridden in child as well as in grandchild classes. 
- If you want to restrict the method, not to be overridden under the grandchild classes, then you need to make it sealed in the child class (as seen in the above code).
- If you want to declare a method as sealed, then it has to be declared *virtual* in base class.  
- In Inheritance, the sealed class is the bottom-most class because from this class no more inheritance is possible.

### When should a method be declared as sealed in C#?

If we don’t allow subclasses to override the superclass method and ensure that all sub-classes use the same superclass method logic then that method should be declared as sealed.

### What is the difference between the private and sealed methods in C#?

- The private method is not inherited while sealed method is inherited but cannot be overridden. 
- A private method cannot be called form the sub-class while a sealed method can be called from sub-classes.
- The same private method can be defined in sub-class and it does not lead to error.

### What are the differences between an abstract class and a sealed class in C#?

#### Abstract Class in C#:
1. A class that contains one or more abstract methods is known as an abstract class.
2. The abstract class can contain abstract and non-abstract methods.
3. Creating a new class from an abstract class is compulsory to consume the abstract class non-abstract members.
4. An abstract class cannot be instantiated directly; we need to create the object for its child classes to consume an abstract class.
5. We need to use the keyword abstract to make any class abstract.
6. An abstract class cannot be the bottom-most class within the inheritance hierarchy.

#### Sealed Class in C#:
1. A class from which it is not possible to derive a new class is known as a sealed class.
2. The sealed class can contain non-abstract methods; it cannot contain abstract and virtual methods.
3. It is not possible to create a new class from a sealed class.
4. We should create an object for a sealed class to consume its members.
5. We need to use the keyword sealed to make any class sealed.
7. The sealed class should be the bottom-most class within the inheritance hierarchy.