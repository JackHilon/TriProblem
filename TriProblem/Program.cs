using System;

namespace TriProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            //      Tri problem
            //   https://open.kattis.com/problems/tri
            
            // given three positive integers... guess the operation given the same order


            //var Tri = StringLineToIntArray(Console.ReadLine());
            //int r = Tri[0];
            //int s = Tri[1];
            //int t = Tri[2];

            // ---### Fast way ###---
            var str = Console.ReadLine();
            var arr = str.Split(' ');
            int r = int.Parse(arr[0]);
            int s = int.Parse(arr[1]);
            int t = int.Parse(arr[2]);
            // ---###



            var operation = FirstCheck(r, s, t);

            if (operation != " ")
                Console.WriteLine(operation);
            else
                Console.WriteLine(SecondCheck(r, s, t));
        }
        private static string FirstCheck(int x, int y, int z)
        {
            var str = " ";

            if (x + y == z)
                str = $"{x}+{y}={z}";
            if (x - y == z)
                str = $"{x}-{y}={z}"; 
            if (x * y == z)
                str = $"{x}*{y}={z}"; 
            if (x / y == z)
                str = $"{x}/{y}={z}"; 
            
            return str;
        }
        private static string SecondCheck(int x, int y, int z)
        {
            var str = " ";

            if (x == y + z)
                str = $"{x}={y}+{z}";
            if (x == y - z)
                str = $"{x}={y}-{z}";
            if (x == y * z)
                str = $"{x}=={y}*{z}";
            if (x == y / z)
                str = $"{x}={y}/{z}";

            return str;
        }


        private static int[] StringLineToIntArray(string line)
        {
            var str = new string[1];
            int[] res = new int[3] { 0, 0, 0 };


            int a = 0;
            int b = 0;
            int c = 0;
            try
            {
                str = line.Split(' ');

                a = int.Parse(str[0]);
                b = int.Parse(str[1]);
                c = int.Parse(str[2]);

                if (a <= 0 || b <= 0 || c <= 0)
                    throw new ArgumentException();
                if (str.Length != 3)
                    throw new IndexOutOfRangeException();
            }

            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message} || {ex.GetType().FullName}");
                line = Console.ReadLine();
                res = StringLineToIntArray(line);
                return res;
            }

            res[0] = a;
            res[1] = b;
            res[2] = c;

            return res;
        }
    }
}
