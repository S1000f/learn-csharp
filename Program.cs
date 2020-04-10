using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp1 {

    class Product {
        public String name { get; set; }
        public int price { get; set; }

        public override string ToString() {
            return name + " : " + price + " won";
        }
    }

    class Student {
        public String name { get; set; }
        public double score { get; set; }

        public Student(String name, double score) {
            this.name = name;
            this.score = score;
        }

        public override string ToString() {
            return name + " : " + score;
        }
    }

    class Students {
        private List<Student> list = new List<Student>();
        public delegate void PrintProcess(Student student);

        public void Add(Student student) {
            list.Add(student);
        }

        public void Print(PrintProcess printProcess) {
            foreach (var item in list) {
                printProcess(item);
            }
        }

        public void Print() {
            Print(s => Console.WriteLine(s));
        }

        public PrintProcess pp = s => Console.WriteLine(s);

        public void Print2() {
            Print(pp);
        }
    }

    static class Program {
        public delegate void asdf();

        [STAThread]
        static void Main() {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form6_thread());

            Students studentList = new Students();
            studentList.Add(new Student("a", 4.5));
            studentList.Add(new Student("c", 3.5));
            studentList.Add(new Student("b", 2.8));

            studentList.Print();
            studentList.Print2();

            List<Product> list = new List<Product>() {
                new Product() { name = "aaa", price = 300},
                new Product() { name = "ccc", price = 240},
                new Product() { name = "bbb", price = 154}
            };

            // 무명델리게이터
            list.Sort(delegate (Product a, Product b) {
                return a.price.CompareTo(b.price);
            });

            foreach (var e in list) {
                Console.WriteLine(e.name + " : " + e.price);
            }

            Comparison<Product> example = sortWithPrice;
            list.Sort(example);

            Console.WriteLine();
            foreach (var e in list) {
                Console.WriteLine(e.name + " : " + e.price);
            }

            list.Sort((Product a, Product b) => a.name.CompareTo(b.name));

            Console.WriteLine();
            foreach (var e in list) {
                Console.WriteLine(e.name + " : " + e.price);
            }

            Thread thread = new Thread(() => {
                for(int i = 0; i < 100; i++) {
                    Console.Write("Black Mesa");
                }
            });

            //thread.Start();

            Thread thread1 = new Thread(print);
            //thread1.Start();
            Console.WriteLine();

            List<int> input = new List<int>() { 1, 2, 3, 4, 5, 6, 7,8,9,10,11,12 };

            var output = from item in input
                         where (item > 2) && (item % 2 == 0)
                         orderby item descending
                         select item * item;

            foreach (var e in output) {
                Console.Write(e + "\t");
            }

            Console.WriteLine();
            foreach (var e in input) {
                if(e > 2 && e % 2 == 0) {
                    Console.WriteLine(e * e);
                }
            }

            var out2 = from e in input
                       where e > 5
                       select new {
                           aa = e + 1,
                           bb = e * 2,
                           cc = e * e
                       };

            Console.WriteLine();
            foreach(var e in out2) {
                Console.WriteLine("aa : " + e.aa);
                Console.WriteLine("bb : " + e.bb);
                Console.WriteLine("cc : " + e.cc);
                Console.WriteLine("--------------------");
            }

            Console.WriteLine("============================");

            List<Product> list2 = new List<Product>() {
                new Product() {name = "potato", price = 345},
                new Product() {name = "meloon", price = 245},
                new Product() {name = "orange", price = 875},
                new Product() {name = "apple", price = 45},
                new Product() {name = "banana", price = 115}
                
            };

            var out3 = from e in list2
                       where e.price > 100
                       orderby e.price ascending
                       select e;

            foreach (var item in out3) {
                Console.WriteLine(item);
            }

            String url = "http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=1150061500";
            XElement xe = XElement.Load(url);
            var xmlQuery = from e in xe.Descendants("data")
                           select e;

            foreach (var item in xmlQuery) {
                Console.WriteLine(item.Element("hour").Value + "\t");
                Console.WriteLine(item.Element("day").Value + "\t");
                Console.WriteLine(item.Element("temp").Value + "\t");
                Console.WriteLine(item.Element("tmx").Value + "\t");
                Console.WriteLine(item.Element("sky").Value + "\t");
                Console.WriteLine(item.Element("pty").Value + "\t");
                Console.WriteLine(item.Element("wfKor").Value + "\t");
                Console.WriteLine("------------");
            }
        }

        static void print() {
            for(int i = 0; i < 100; i++) {
                Console.Write("0");
            }
        }

        private static int sortWithPrice(Product x, Product y) {
            return y.price.CompareTo(x.price);
        }


    }
}
