using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1 {
    public class Class1 {
        class Parent {
            public Parent() {
                Console.WriteLine("parent constructor");
            }
        }

        class Child : Parent {
            public Child() {
                Console.WriteLine("child constructor");
            }
        }

        static void Test(String[] args) {
            Child child = new Child();
        }

    }
}
