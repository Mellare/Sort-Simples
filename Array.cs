int [] array = new int[3];
int [] arrayOriginal = new int[3];

int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());
int z = int.Parse(Console.ReadLine());

array[0] = x;
array[1] = y;
array[2] = z;

Array.Copy(array,arrayOriginal,3);
Array.Sort(array);

foreach(var i in array){
    Console.WriteLine(i);
}

Console.WriteLine(" ");

foreach(var j in arrayOriginal){
    Console.WriteLine(j);
}
