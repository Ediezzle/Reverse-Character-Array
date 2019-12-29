using System;

namespace ReverseCharArray
{
    class Program
    {
		public static char[] Reverse(char[] array)
		{
			string s = "";
			for (int i = array.Length - 1; i >= 0; i--)
			{
				s += array[i];

			}
			char[] charArray = s.ToCharArray();
			return charArray;
		}
		static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
			char[] cA = { 'a', 'b', 'c', 'd' };
			Console.WriteLine(Reverse(cA));
		}
    }
}
