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




