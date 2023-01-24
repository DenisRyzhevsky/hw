
String[] array = { "Hello", "2", "world", ":)" };

int simvol = array[0].Length;
int size = array.Length;

for (int i = 0; i < size; i++)
{
    if (array[i].Length < 3)
    {
        System.Console.WriteLine(array[i]);
    }

}
