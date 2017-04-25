using System;

namespace task6
{
    class Program
    {
        static void Main(string[] args)
        {
            uint stackSize;

            string stdi = Console.ReadLine();
            uint.TryParse(stdi, out stackSize);

            var stack = new Task6.SuperStack(stackSize);

            int a;
            int b;

            while (stdi != "q")
            {
                stdi = Console.ReadLine();
                string[] spl = stdi.Split(' ');
                switch (spl[0])
                {
                    case "push":
                        int.TryParse(spl[1], out a);
                        stack.Push(a);
                        break;
                    case "pop":
                        stack.Pop();
                        break;
                    case "inc":
                        int.TryParse(spl[1], out a);
                        int.TryParse(spl[2], out b);
                        stack.Inc(a, b);
                        break;
                    default:
                        return;
                }

                var res = stack.Peek();

                var resStr = (res == null) ? "EMPTY" : ((int)res).ToString();

                Console.WriteLine(resStr);
            }
        }


    }
}