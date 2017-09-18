using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace AwesomeConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            MainConsole();

        }


        public static void MainConsole()
        {
            Abc();

            Console.WriteLine("Exit (Y) or Restart (R)");
            string final = Console.ReadLine();
            string upperString = final.ToUpper();
            if (upperString == "Y")
            {
                return;
            }
            else if (upperString == "R")
            {
                restart();
            }
        }

        public static void restart()
        {
            MainConsole();
        }

        public static void Abc()
        {
            Console.WriteLine("Enter the letter you want: ");
            string characters = Console.ReadLine();
            for (int str = 0; str <= characters.Length - 1; str++)

                if (characters.Contains("A"))
                {
                    Console.WriteLine("..######..\n..#....#..\n..######..\n..#....#..\n..#....#..\n\n");
                }
            if (characters.Contains("a"))
            {
                Console.WriteLine("..######..\n..#....#..\n..######..\n..#....#..\n..#....#..\n\n");
            }
            if (characters.Contains("B"))
            {
                Console.WriteLine("..######..\n..#....#..\n..#####...\n..#....#..\n..######..\n\n");
            }
            if (characters.Contains("b"))
            {
                Console.WriteLine("..######..\n..#....#..\n..#####...\n..#....#..\n..######..\n\n");
            }
            if (characters.Contains("C"))
            {
                Console.WriteLine("..######..\n..#.......\n..#.......\n..#.......\n..######..\n\n");
            }
            if (characters.Contains("c"))
            {
                Console.WriteLine("..######..\n..#.......\n..#.......\n..#.......\n..######..\n\n");
            }
            if (characters.Contains("D"))
            {
                Console.WriteLine("..#####...\n..#....#..\n..#....#..\n..#....#..\n..#####...\n\n");
            }
            if (characters.Contains("d"))
            {
                Console.WriteLine("..#####...\n..#....#..\n..#....#..\n..#....#..\n..#####...\n\n");
            }
            if (characters.Contains("E"))
            {
                Console.WriteLine("..######..\n..#.......\n..#####...\n..#.......\n..######..\n\n");
            }
            if (characters.Contains("e"))
            {
                Console.WriteLine("..######..\n..#.......\n..#####...\n..#.......\n..######..\n\n");
            }
            if (characters.Contains("F"))
            {
                Console.WriteLine("..######..\n..#.......\n..#####...\n..#.......\n..#.......\n\n");
            }
            if (characters.Contains("f"))
            {
                Console.WriteLine("..######..\n..#.......\n..#####...\n..#.......\n..#.......\n\n");
            }
            if (characters.Contains("G"))
            {
                Console.WriteLine("..######..\n..#.......\n..#####...\n..#....#..\n..#####...\n\n");
            }
            if (characters.Contains("g"))
            {
                Console.WriteLine("..######..\n..#.......\n..#####...\n..#....#..\n..#####...\n\n");
            }
            if (characters.Contains("H"))
            {
                Console.WriteLine("..#....#..\n..#....#..\n..######..\n..#....#..\n..#....#..\n\n");
            }
            if (characters.Contains("h"))
            {
                Console.WriteLine("..#....#..\n..#....#..\n..######..\n..#....#..\n..#....#..\n\n");
            }
            if (characters.Contains("I"))
            {
                Console.WriteLine("..######..\n....##....\n....##....\n....##....\n..######..\n\n");
            }
            if (characters.Contains("i"))
            {
                Console.WriteLine("..######..\n....##....\n....##....\n....##....\n..######..\n\n");
            }
            if (characters.Contains("J"))
            {
                Console.WriteLine("..######..\n....##....\n....##....\n..#.##....\n..####....\n\n");
            }
            if (characters.Contains("j"))
            {
                Console.WriteLine("..######..\n....##....\n....##....\n..#.##....\n..####....\n\n");
            }
            if (characters.Contains("K"))
            {
                Console.WriteLine("..#...#...\n..#..#....\n..##......\n..#..#....\n..#...#...\n\n");
            }
            if (characters.Contains("k"))
            {
                Console.WriteLine("..#...#...\n..#..#....\n..##......\n..#..#....\n..#...#...\n\n");
            }
            if (characters.Contains("L"))
            {
                Console.WriteLine("..#.......\n..#.......\n..#.......\n..#.......\n..######..\n\n");
            }
            if (characters.Contains("l"))
            {
                Console.WriteLine("..#.......\n..#.......\n..#.......\n..#.......\n..######..\n\n");
            }
            if (characters.Contains("M"))
            {
                Console.WriteLine("..#....#..\n..##..##..\n..#.##.#..\n..#....#..\n..#....#..\n\n");
            }
            if (characters.Contains("m"))
            {
                Console.WriteLine("..#....#..\n..##..##..\n..#.##.#..\n..#....#..\n..#....#..\n\n");
            }
            if (characters.Contains("N"))
            {
                Console.WriteLine("..#....#..\n..##...#..\n..#.#..#..\n..#..#.#..\n..#...##..\n\n");
            }
            if (characters.Contains("n"))
            {
                Console.WriteLine("..#....#..\n..##...#..\n..#.#..#..\n..#..#.#..\n..#...##..\n\n");
            }
            if (characters.Contains("O"))
            {
                Console.WriteLine("..######..\n..#....#..\n..#....#..\n..#....#..\n..######..\n\n");
            }
            if (characters.Contains("o"))
            {
                Console.WriteLine("..######..\n..#....#..\n..#....#..\n..#....#..\n..######..\n\n");
            }
            if (characters.Contains("P"))
            {
                Console.WriteLine("..######..\n..#....#..\n..######..\n..#.......\n..#.......\n\n");
            }
            if (characters.Contains("p"))
            {
                Console.WriteLine("..######..\n..#....#..\n..######..\n..#.......\n..#.......\n\n");
            }
            if (characters.Contains("Q"))
            {
                Console.WriteLine("..######..\n..#....#..\n..#.#..#..\n..#..#.#..\n..######..\n\n");
            }
            if (characters.Contains("q"))
            {
                Console.WriteLine("..######..\n..#....#..\n..#.#..#..\n..#..#.#..\n..######..\n\n");
            }
            if (characters.Contains("R"))
            {
                Console.WriteLine("..######..\n..#....#..\n..#.##...\n..#...#...\n..#....#..\n\n");
            }
            if (characters.Contains("r"))
            {
                Console.WriteLine("..######..\n..#....#..\n..#.##...\n..#...#...\n..#....#..\n\n");
            }
            if (characters.Contains("S"))
            {
                Console.WriteLine("..######..\n..#.......\n..######..\n.......#..\n..######..\n\n");
            }
            if (characters.Contains("s"))
            {
                Console.WriteLine("..######..\n..#.......\n..######..\n.......#..\n..######..\n\n");
            }
            if (characters.Contains("T"))
            {
                Console.WriteLine("..######..\n....##....\n....##....\n....##....\n....##....\n\n");
            }
            if (characters.Contains("t"))
            {
                Console.WriteLine("..######..\n....##....\n....##....\n....##....\n....##....\n\n");
            }
            if (characters.Contains("U"))
            {
                Console.WriteLine("..#....#..\n..#....#..\n..#....#..\n..#....#..\n..######..\n\n");
            }
            if (characters.Contains("u"))
            {
                Console.WriteLine("..#....#..\n..#....#..\n..#....#..\n..#....#..\n..######..\n\n");
            }
            if (characters.Contains("V"))
            {
                Console.WriteLine("..#....#..\n..#....#..\n..#....#..\n...#..#...\n....##....\n\n");
            }
            if (characters.Contains("v"))
            {
                Console.WriteLine("..#....#..\n..#....#..\n..#....#..\n...#..#...\n....##....\n\n");
            }
            if (characters.Contains("W"))
            {
                Console.WriteLine("..#....#..\n..#....#..\n..#.##.#..\n..##..##..\n..#....#..\n\n");
            }
            if (characters.Contains("w"))
            {
                Console.WriteLine("..#....#..\n..#....#..\n..#.##.#..\n..##..##..\n..#....#..\n\n");
            }
            if (characters.Contains("X"))
            {
                Console.WriteLine("..#....#..\n...#..#...\n....##....\n...#..#...\n..#....#..\n\n");
            }
            if (characters.Contains("x"))
            {
                Console.WriteLine("..#....#..\n...#..#...\n....##....\n...#..#...\n..#....#..\n\n");
            }
            if (characters.Contains("Y"))
            {
                Console.WriteLine("..#....#..\n...#..#...\n....##....\n....##....\n....##....\n\n");
            }
            if (characters.Contains("y"))
            {
                Console.WriteLine("..#....#..\n...#..#...\n....##....\n....##....\n....##....\n\n");
            }
            if (characters.Contains("Z"))
            {
                Console.WriteLine("..######..\n......#...\n.....#....\n....#.....\n..######..\n\n");
            }
            if (characters.Contains("z"))
            {
                Console.WriteLine("..######..\n......#...\n.....#....\n....#.....\n..######..\n\n");
            }
            if (characters.Contains(" "))
            {
                Console.WriteLine("..........\n..........\n..........\n..........\n\n");
            }
            if (characters.Contains("  "))
            {
                Console.WriteLine("..........\n..........\n..........\n..........\n\n");
            }
            if (characters.Contains("."))
            {
                Console.WriteLine("----..----\n\n");
            }
        }
    }
}
