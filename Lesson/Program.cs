void FillArray (int[] arr, int len)

{
    for (int i=0; i < len; i++)
     
    {
        arr[i] = new Random().Next(1, 11);
    }
}


int N = Convert.ToInt32(Console.ReadLine());
//1)
int [] array = new int[N];

//2)
FillArray(array, N);

//Name, return value, parameters

//3)
int sum = 0;
float result = 0;
int cuntOfEvens = 0;
for (int i=0; i < N; i++)
{
    //1. Обратиться к четному элементу
   if (array[i] % 2 == 0)
    {
        //2. прибавить его к сумме
        sum += array [i];
        //3.вести подчет четных чисел
        cuntOfEvens++;

    } 
}

result = (float)sum / cuntOfEvens;
Console.WriteLine(result);
