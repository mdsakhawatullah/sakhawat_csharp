namespace problem_75_131A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] chars = input.ToCharArray();
            int c = 0, d = 0;

            for(int i=1; i<chars.Length; i++)
            {

                if (chars[i] == char.ToLower(chars[i]))
                {
                    c++;
                }
            }
            for(int i=0; i<chars.Length; i++)
            {
                if (chars[i] == char.ToUpper(chars[i]))
                {
                    d++;
                }
            }
            if (chars[0] == char.ToLower(chars[0]) && c==0)
            {
                chars[0] = char.ToUpper(chars[0]);
                for(int i=1; i<chars.Length; i++)
                {
                    chars[i] = char.ToLower(chars[i]);
                }
                string result = new string(chars);
                Console.WriteLine(result);
                return;
            }
            if(d== chars.Length)
            {
                for(int i=0; i<chars.Length;i++)
                {
                    chars[i] = char.ToLower(chars[i]);
                }

                string result = new string(chars);
                Console.WriteLine(result);
            }
            else
            {
                string result = new string(chars);
                Console.WriteLine(result);
            }

          
        }
    }
}
