using System;

namespace Prog
{
    class Program1
    {
        public void print()
        {
            Console.WriteLine("Hello word");
            Subject subject = new Subject("Panda");
            string str1 = subject.cse();
            Console.WriteLine(str1);
        }
    }

    class Subject
    {
        string str;
        public Subject(string s)
        {
            str=s;
        }
        public string cse()
        {
            return str;
        }
    }
}