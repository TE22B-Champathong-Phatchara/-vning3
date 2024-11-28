

// Hello32();


// static void Hello32()
// {
//     for (int i = 0; i < 32; i++)
//     {
//         System.Console.WriteLine("Hello world!");
//     }
// }

// Console.ReadLine();


// static int Square()
// {
    

//     int num = GetNumberInput();

//     return num*num;



// }

// int res = Square();
// System.Console.WriteLine(res);


// static int Multi()
// {
//     int Num1 = GetNumberInput();

//     int Num2 = GetNumberInput();

//     return Num1 * Num2;


// }

// int res = Multi();
// System.Console.WriteLine(res);





static float RightTriangleArea()
{
    System.Console.WriteLine("Input Triangle's Length and Height.");
    int Num1 = GetNumberInput();
    int Num2 = GetNumberInput();

    return (Num1 * Num2)/2f;

}



float res = RightTriangleArea();

System.Console.WriteLine(res);





static int GetNumberInput()
{
    

    while(true)
    {
        System.Console.Write("Enter a number: ");
        string Input = Console.ReadLine();
        int ToInt;
        bool True = int.TryParse(Input, out ToInt);

        if (True)
        {
            return ToInt;
        }
        else
        {
            System.Console.WriteLine("Invalid.");
            continue;
            
        }
    }

}



 Console.ReadLine();