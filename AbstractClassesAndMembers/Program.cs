// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;

namespace AbstractClassesAndMembers // Note: actual namespace depends on the project name.
{
    public static class Program
    {   

        static void Main(string[] args)
        {
            
        }
    }
}

/*
 I'm going to talk about the abstract modifier that can be applied on classes and their members including

methods and properties and then I'll tell you about the rules that you need to know about abstract classes

and members.

So what does the abstract modifier do.

The abstract modifier indicates that a class or a member is missing implementation.



Abstract Members

The first one is that an abstract member cannot include implementation.

So as you saw in the previous example the dramas didn't have a body.

It was purely a declaration.

The second rule is that if a member is declared as an abstract the containing class needs to be declared as abstract to the third one.

Is that in a derived class you must implement all abstract members in the base abstract class.

So in this case our shape method had only one abstract method that was draw.

If it had three abstract methods you had to override all this three abstract methods and the last one

is abstract classes cannot be instantiated. So when we declare the shape class as an abstract we cannot create a new instance of shape.

So this line will compile.


Why to use Abstract?
When you want to provide some common behaviour, while forcing other developers to follow your design.

What's the benefit you use Amtrak when you want to provide some common behavior while forcing other developers to follow your design.

Well in our shaping example are declaring the draw method as abstract. We'll make sure that anytime a developer derives a class from the shape they will provide an implementation for the draw method.



 */