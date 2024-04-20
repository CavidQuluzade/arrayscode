//#1
int[] number = { 200, 100, 300, 50, 150, 400 };

for (int i = 0; i < number.Length; i++)
{
    Console.WriteLine(number[i]);
}
Console.WriteLine();
//***********************************
//#2
int[] numbers = { 200, 100, 300, 50, 150, 400 };
int sum = 0;
for (int i = 0;i < numbers.Length; i++)
{
    sum += numbers[i];
}
Console.WriteLine(sum);
Console.WriteLine();

//***********************************
//#3
int[] num = { 200, 100, 300, 50, 150, 400 };
for (int j = num.Length-1; j >= 0; j--)
{
    Console.WriteLine(num[j]);
}
Console.WriteLine();
//**********************************
//#4
int[] arr = { 200, 100, 300, 50, 150, 400 };
for (int i = 0; i < arr.Length / 2; i++)
{
    int tmp = arr[i];
    arr[i] = arr[arr.Length - i - 1];
    arr[arr.Length - i - 1] = tmp;
}
for (int k = 0; k < arr.Length; k++)
{
    Console.WriteLine(arr[k]);
}
Console.WriteLine();
//****************************
//#5
int[] maxarr = { 200, 100, 300, 50, 150, 400 };

Console.WriteLine(maxarr.Max());
Console.WriteLine();
//*****************************
//#6
int[] sizearr = { 200, 100, 300, 50, 150, 400 };
int Length = sizearr.Length;
Console.WriteLine(Length);
Console.WriteLine();
//*****************************
//#7
int[] sortarr = { 200, 100, 300, 50, 150, 400 };
int temp = 0;
for (int i = 0; i < sortarr.Length; i++)
{
    for (int j = 0; j < sortarr.Length - 1; j++)
    {
        
        if (sortarr[j] > sortarr[j + 1])
        {
            temp = sortarr[j + 1];
            sortarr[j + 1] = sortarr[j];
            sortarr[j] = temp;
        }
    }
}

for (int i = 0; i < sortarr.Length; i++)
{
    Console.Write(sortarr[i] + " ");
    Console.WriteLine();
}

Console.WriteLine();
//*****************************
//#8
int[] array = { 1, 0 ,5 , 8, 4, 0, 7 };
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (0 == array[i])
            count++;  
}
Console.WriteLine(count);
Console.WriteLine();
//***************************
//#9
int[] negarray = { 1, 0, 5, -8, 4, 0, -7, -2, 3 };
int counts = 0;
for (int i = 0; i < negarray.Length; i++)
{
    if (0 > negarray[i])
        counts++;
}
Console.WriteLine(counts);
Console.WriteLine();
//**************************
//#10
int[] posarray = { 1, 0, 5, -8, 4, 0, -7, -2, 3 };
int poscount = 0;
for (int i = 0; i < negarray.Length; i++)
{
    if (0 < negarray[i])
        poscount++;
}
Console.WriteLine(poscount);
Console.WriteLine();
//***************************
//#11
int[] powarr = { 1, 0, 5, -8, 4, 0, -7, -2, 3 };
for (int z = 0; z < powarr.Length; z++)
{
    powarr[z] = powarr[z] * powarr[z];
}
for (int k = 0; k < powarr.Length; k++)
{
    Console.WriteLine(powarr[k]);
}
Console.WriteLine();
//***************************
//#12
int[] arrs = { 1, 25, 6, 7, 9, 12 };
int temps;
for (int l = 0;l < arrs.Length-1; l++)
{
    for (int m = l +1; m < arrs.Length; m++)
    {
        if (arrs[l] < arrs[m])
        {
            temps = arrs[l];
            arrs[l] = arrs[m];
            arrs[m] = temps;

        }
    }
}
foreach (int value in arrs)
{
    Console.WriteLine(value);
}
