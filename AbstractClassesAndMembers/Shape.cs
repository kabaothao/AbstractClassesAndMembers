using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesAndMembers
{
    public abstract class Shape
    {

            public int Width { get; set; }
            public int Height { get; set; }

        public abstract void Draw();
        
        public void Copy()
        {
            Console.WriteLine("Copy shape into clipboard.");
        }

        public void Select()
        {
            Console.WriteLine("Select the shape.");
        }
        
    }
}


/*
 So here is the benefit of abstract modifier.

It's not something that you use every day in your programming career but it's a tool that you can use

when you're facing situations like this when you want to force your design to be followed everywhere

in the code base.

Now before we finished this lecture I want to show you a couple more things.
 */