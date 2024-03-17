namespace problem_53_158B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int count1 = 0, count2 = 0, count3 = 0, count4 = 0, min_taxi = 0;
            string[] input = Console.ReadLine().Split(' ');

            int[] numbers = new int[a];

            for(int i=0; i<a; i++)
            {
                numbers[i] = int.Parse(input[i]);

                if (numbers[i] == 1) count1++;
                if (numbers[i] == 2) count2++;
                if (numbers[i] == 3) count3++;
                if (numbers[i] == 4) count4++;
            }

            min_taxi += count4;

            while(count1 !=0 && count3 !=0)
            {
                count3 -= 1;
                count1 -= 1;
                min_taxi++;
            }

            if(count1 == 0 && count3 !=0)
            {
                min_taxi += count3;
                count3 = 0;
            }

            min_taxi += count2 / 2;

            if(count2%2 !=0)
            {
                if(count1<=2)
                {
                    min_taxi++;
                    count2 = 0;
                    count1 = 0;
                }
                else
                {
                    count1 -= 2;
                    min_taxi++;
                    count2 = 0;
                }
            }

            if(count1 != 0)
            {
                min_taxi += count1 / 4;
                if(count1%4 !=0)
                {
                    min_taxi++;
                }
            }

            Console.WriteLine(min_taxi);


        }
    }
}
