using System;
using System.Collections.Generic;

namespace BigMammaUML3 {
    public static class Program {

        public static void Main() {
            MenuCatalog menu = new MenuCatalog();
            CommandReader commandReader = new CommandReader("data\\menu.txt");
            menu.ReadFromFile(commandReader);
            menu.PrintPizzasMenu();
            menu.PrintPastaMenu();
            read();
        }

        public static void print(string s) {
            Console.WriteLine(s);
        }
        public static string read() {
            return Console.ReadLine();
        }
    }
}
