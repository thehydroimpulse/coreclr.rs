using System;
using System.Runtime.InteropServices;

namespace HelloWorld {
    class HelloWorldMain {
        [DllImport("../target/libcoreclr-2f035440f818dfd3.dylib", CallingConvention = CallingConvention.StdCall)]
            private static extern int from_rust(int a);

        [DllImport("../target/libcoreclr-2f035440f818dfd3.dylib", CallingConvention = CallingConvention.StdCall)]
            private static extern void set_age(Person person, int age);

        [StructLayout (LayoutKind.Sequential)]
        public class Person {
            public int age;
        }

        public static void Main(string[] args) {
            try {
                Console.WriteLine("Calling from Rust");
                int result = from_rust(5);
                Console.WriteLine("Result: {0}", result);
                Person p = new Person();
                set_age(p, 15);
                Console.WriteLine("New Age: {0}", p.age);
            } finally {
                Console.WriteLine("Done.");
            }
        }
    }
}
