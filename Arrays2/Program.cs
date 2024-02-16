/* string line = Console.ReadLine();
int size = 0;

bool success  = false;

success = int.TryParse(line, out size);

if (success)
{
    string[] naems = new string[size];

    for(int i=0; i< size; i++)
    {
        naems[i] = Console.ReadLine();
    }

    string middlePersonName = naems[naems.Length / 2];
    Console.WriteLine(middlePersonName);
}

else
{
    Console.WriteLine("Size is not correct format");
}

*/

int[][] jaggedArray = new int[3][];

jaggedArray[0] =  new int[2];
jaggedArray[1] =  new int[3];
jaggedArray[2] =  new int[4];

jaggedArray[0][0] = 79;
jaggedArray[0][1] = 49;
jaggedArray[1][0] = 80;
jaggedArray[1][1] = 68;
jaggedArray[1][2] = 56;
jaggedArray[2][0] = 57;
jaggedArray[2][1] = 34;
jaggedArray[2][2] = 88;
jaggedArray[2][3] = 92;

for(int i=0; i< jaggedArray.GetLength(0); i++)
{
    double avg = 0;
    for(int j=0; j< jaggedArray[i].Length; j++)
    {
        avg += jaggedArray[i][j];

    }
    Console.WriteLine(avg / jaggedArray[i].Length);
}

