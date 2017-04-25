namespace Task6
{
    class SuperStack
    {
        static int cursor = 0;
        static int[] stack;

        public SuperStack(uint size)
        {
            stack = new int[size];
        }

        public void Push(int k)
        {
            if (cursor >= stack.Length)
                return;

            stack[cursor++] = k;
        }

        public void Pop()
        {
            if (cursor > 0)
            {
                cursor--;
            }
        }

        public void Inc(int a, int b)
        {
            for (int i = 0; (i < a && i < cursor); i++)
            {
                stack[i] += b;
            }
        }

        public string Peek()
        {
            if (cursor == 0)
            {
                return "EMPTY";
            }

            return stack[cursor - 1].ToString();
        }

    }
}
