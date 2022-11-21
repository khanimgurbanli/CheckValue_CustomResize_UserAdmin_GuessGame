

//using Homeworks;
//Console.WriteLine("Enter name");
//string name=Console.ReadLine();
//Console.WriteLine("Enter surname");
//string surname = Console.ReadLine();
//Console.WriteLine("Enter password");
//string password = Console.ReadLine();
//Admin admin=new Admin(name, surname,password);
//admin.Registration();
//admin.Login();

using Homeworks;

Guess guess = new();
guess.MyGues();


























//int[] arr = GetValue();

//double resultSum = Sum(arr);
//Console.WriteLine($"Result: {resultSum}");

//static double Sum(int[] arr)
//{
//    double sum = 0;
//    for (int i = 0; i < arr.Length; i++)
//    {
//        sum += arr[i];
//    }
//    return sum;
//}


//static int[] GetValue()
//{
//    int Number = 0;

//    int[] arr = new int[0];
//    for (int i = 0; i < 2; i++)
//    {
//        bool check = true;

//        while (check)
//        {
//            Console.WriteLine($"Enter please correct formtat {i + 1}. number");
//            string value = Console.ReadLine();
//            bool numberMessage = IsNumberOrNot(value, out Number);

//            if (numberMessage) check = false;
//        }
//        Resize(ref arr, i + 1);
//        arr[i] = Number;
//    }
//    return arr;
//}

//static void Resize(ref int[] arr, int size)
//{
//    int[] myArray = new int[size];

//    if (arr.Length > myArray.Length)
//    {
//        for (int i = 0; i < myArray.Length; i++)
//        {
//            myArray[i] = arr[i];
//        }
//    }
//    else
//    {
//        for (int i = 0; i < arr.Length; i++)
//        {
//            myArray[i] = arr[i];
//        }
//    }
//    arr= myArray;   
//}

//static bool IsNumberOrNot(string value, out int Number)
//{
//    bool message = int.TryParse(value, out Number);
//    return message;
//}