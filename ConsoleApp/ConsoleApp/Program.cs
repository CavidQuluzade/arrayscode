//#1
int[,] arr =
{
    { 100, 200, 300 },
    {400, 500, 600},
    {700, 800, 900}
};

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        Console.Write(arr[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
//#2
int[,] arr1 =
{
    { 100, 200, 300 },
    {400, 500, 600},
    {700, 800, 900}
};
int sum = 0;
for (int i = 0; i < arr1.GetLength(0); i++)
{
    for (int j = 0; j < arr1.GetLength(1); j++)
    {
        sum += arr[i, j];
    }
}
Console.WriteLine(sum);
Console.WriteLine();
//#3
int[,] arr2 =
{
    { 100, 200, 300 },
    {400, 500, 600},
    {700, 800, 900}
};
int sum1 = 0;
for (int i = 0; i < arr2.GetLength(0); i++)
{
    sum1 += arr2[i, 0];
}
Console.WriteLine(sum1);
Console.WriteLine();
//#4
int[,] arr3 =
{
    { -100, 200, 300 },
    {400, -500, 600},
    {-700, 800, -900}
};

for (int i = 0; i < arr3.GetLength(0); i++)
{
    for (int j = 0; j < arr3.GetLength(1); j++)
        if (arr3[i, j] < 0)
        {
            Console.WriteLine(arr3[i, j]);
        }
}
Console.WriteLine();
//#5
int[,] arr4 =
{
    { -100, 200, 300 },
    {400, -500, 600},
    {-700, 800, -900}
};
int max = 0;
int min = 0;

for (int i = 0; i < arr4.GetLength(0); i++)
{
    for (int j = 0; j < arr4.GetLength(1); j++)
    {

        if (arr4[i, j] > max)
        {
            max = arr4[i, j];
        }

        if (arr4[i, j] < min)
        {
            min = arr4[i, j];
        }
    }
}
Console.WriteLine("Minimum is " + min);
Console.WriteLine("Maximum is " + max);
Console.WriteLine();
//#6
int[,] arr5 =
{
    { 100, -203, 300 },
    {407, -500, 0},
    {-700, -835, -900}
};

for (int i = 0; i < arr5.GetLength(0); i++)
{
    for (int j = 0; j < arr5.GetLength(1); j++)
    {
        if (arr5[i, j] > 0)
        {
            if (arr5[i, j] % 2 == 0 && arr5[i, j] > 0)
            {
                arr5[i, j] = 2;
            }

            else if (arr5[i, j] % 2 == 1 && arr5[i, j] > 0)
            {
                arr5[i, j] = 1;
            }
        }
        else if (arr5[i, j] % 2 == 0 && arr5[i, j] < 0)
        {
            arr5[i, j] = -2;
        }
        else if (arr5[i, j] % 2 == -1)
        {
            arr5[i, j] = -1;
        }
        else
        {
            arr5[i, j] = 0;
        }
        Console.Write(arr5[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
//#7
int[,] arr6 =
{
    { 100, 203, 300, 350},
    {407, -500, 0, 330},
    {-700, 835, -900, 130},
    {-50, 70, 100, 530}
};

for (int i = 0; i < arr6.GetLength(0); i++)
{
    for (int j = 0; j < arr6.GetLength(1); j++)
    {

        arr6[1, j] = 0;
        Console.Write(arr6[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
//#8
int[,] arr7 =
{
    { 100, 203, 300},
    {407, -500, 0},
    {-50, 70, 100}
};

for (int i = 0; i < arr7.GetLength(0); i++)
{
    for (int j = 0; j < arr7.GetLength(1); j++)
    {

        arr7[i, 2] = 0;
        Console.Write(arr7[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
//#9
int[,] arr8 =
{
    { 100, 203, 300},
    {407, -500, 0},
    {-50, 70, 100}
};
int sum2 = 0;
for (int i = 0; i < arr8.GetLength(0); i++)
{
    for (int j = 0; j < arr8.GetLength(1); j++)
    {
        if (i == j)
        {
            sum2 += arr8[i, j];
        }
    }
}
Console.WriteLine(sum2);
Console.WriteLine();
//#10
int[,] arr9 =
{
    { 100, 203, 300, 233},
    {407, -500, 0, 189},
    {-50, 70, 100, 160},
    {4, -900, 0, 400},
};
int sum3 = 0;
for (int i = 0; i < arr9.GetLength(0); i++)
{
    for (int j = 0; j < arr9.GetLength(1); j++)
    {
        if (i + j == 3)
        {
            sum3 += arr9[i, j];
        }
    }
}
Console.WriteLine(sum3);
Console.WriteLine();
//#11
int[,] arr10 =
{
    { 100, 203, 300, 233, 978},
    {407, -500, 0, 189, 243},
    {-50, 70, 100, 160, 687},
    {4, -900, 0, 400, 345},
    {3, -456, 0, 745, 9}
};

for (int i = 0; i < arr10.GetLength(0); i++)
{
    for (int j = 0; j < i; j++)
    {
        arr10[i, j] = 0;
    }
    for (int k = 0; k < arr10.GetLength(1); k++)
    {
        Console.Write(arr10[i, k] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
//#12
int[,] arr11 =
{
    { 100, 203, 300, 233, 978},
    {407, -500, 23, 189, 243},
    {-50, 70, 100, 160, 687},
    {4, -900, 11, 400, 345},
    {3, -456, 3, 745, 9}
};

for (int i = 0; i < arr11.GetLength(0); i++)
{
    for (int j = i; j < arr11.GetLength(1); j++)
    {
        arr11[i, j] = 0;
    }
    for (int k = 0; k < arr11.GetLength(1); k++)
    {
        Console.Write(arr11[i, k] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
//#13
int[,] arr12 =
{
    { 100, 200, 300 },
    {400, 500, 600},
    {700, 800, 900}
};

int[,] arr13 =
{
    { 100, 203, 300},
    {407, -500, 0},
    {-50, 70, 100}
};
int[,] arr14 = new int[3, 3];

for (int i = 0; i < arr14.GetLength(0); i++)
{
    for (int j = 0; j < arr14.GetLength(1); j++)
    {
        arr14[i, j] = arr12[i, j] + arr13[i, j];

        Console.Write(arr14[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
//#14
int[,] arr15 =
{
    { 100, 200, 300 },
    {400, 500, 600},
    {700, 800, 900}
};
int sum4 = 0;
for (int i = 0; i < arr15.GetLength(0); i++)
{

    for (int j = 0; j < arr15.GetLength(1); j++)
    {
        sum4 += arr15[i, j];
    }
    Console.WriteLine(sum4);
    sum4 = 0;
}
Console.WriteLine();
//#15
int[,] arr16 =
{
    { 100, 200, 300 },
    {400, 500, 600},
    {700, 800, 900}
};

for (int i = 0; i < arr16.GetLength(0); i++)
{
    int sum5 = 0;

    for (int j = 0; j < arr16.GetLength(1); j++)
    {

        sum5 += arr16[j, i];
    }
    Console.WriteLine(sum5);
}
Console.WriteLine();
//#16
int[,] arr17 =
{
    {1, 1, 5, 0, 1, 1},
    {1, 1, 2, 0, 1, 1},
    {1, 1, 3, 0, 1, 1},
    {1, 1, 4, 0, 1, 1}
};
Console.WriteLine("shift = 3");
int shift = 3;

for (int i = 0; i < arr17.GetLength(0); i++)
{

    for (int j = arr17.GetLength(1)-1; j >= 0; j--)
    {
        if (j - shift >= 0)
        {
            arr17[i, j] = arr17[i, j - shift];
        }
        else
        {
            arr17[i, j] = 0;
        }
    }
}

for (int i = 0; i < arr17.GetLength(0); i++)
{
    for (int j = 0; j < arr17.GetLength(1); j++)
    {
        Console.Write(arr17[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
//#17
int[,] arr18 =
{
    { 100, 200, 300 },
    {400, 500, 600},
    {700, 800, 900}
};
int[,] arr19 =
{
    { 100, 203, 300},
    {407, -500, 0},
    {-50, 70, 100}
};
int[,] arr20 = new int[arr19.GetLength(0), arr19.GetLength(1)];
for (int i = 0;i < arr19.GetLength(0); i++)
{
    for (int j = 0;j < arr19.GetLength(1); j++)
    {
        arr20[i, j] = arr19[i, j] * arr18[i, j];
        Console.Write(arr20[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
//#18
int[,] arr21 =
{
    { 100, 203, 300},
    {407, -500, 13},
    {-50, 70, 100}
};

for (int i = 0; i < arr21.GetLength(0); i++)
{
    for(int j = 0; j < arr21.GetLength(1); j++)
    {
        if (arr21[i,j] < 0 || arr21[i, j] ==1)
            continue;

        bool isComplex = false;

        int root = Convert.ToInt32(Math.Sqrt(arr21[i, j]));

        for (int k = 2; k <= root ; k++)
        {
            if (arr21[i, j] % k == 0)
            {
                isComplex = true;
            }
        }

        if (!isComplex)
        {
            Console.WriteLine(arr21[i,j]);
        }
    }
}

