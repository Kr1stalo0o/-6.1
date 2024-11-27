////.1.
//Console.Write("Enter the number of employees: ");
//int employeeCount = int.Parse(Console.ReadLine());
//double totalSalary = 0;

//for (int i = 1; i <= employeeCount; i++)
//{
//    Console.Write($"Enter the salary of employee {i}: ");
//    totalSalary += double.Parse(Console.ReadLine());
//}

//double averageSalary = totalSalary / employeeCount;
//Console.WriteLine($"Average salary: {averageSalary:F2}");
////.2.
//Console.Write("Enter the number of rows: ");
//int rowCount = int.Parse(Console.ReadLine());

//for (int row = 1; row <= rowCount; row++)
//{
//    Console.WriteLine(new string('*', row));
//}
////.3.
//Console.Write("Enter the maximum number: ");
//int maxNumber = int.Parse(Console.ReadLine());

//Console.WriteLine("Prime numbers:");
//for (int number = 2; number <= maxNumber; number++)
//{
//    bool isPrime = true;

//    for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
//    {
//        if (number % divisor == 0)
//        {
//            isPrime = false;
//            break;
//        }
//    }

//    if (isPrime)
//    {
//        Console.Write(number + " ");
//    }
//}
////.4.
//Console.Write("Enter a password: ");
//string password = Console.ReadLine();

//bool hasDigit = false;
//bool hasSpecialChar = false;

//for (int i = 0; i < password.Length; i++)
//{
//    char character = password[i];

//    if (char.IsDigit(character))
//    {
//        hasDigit = true;
//    }
//    if ("!@#$%^&*".Contains(character))
//    {
//        hasSpecialChar = true;
//    }
//}

//if (password.Length >= 8 && hasDigit && hasSpecialChar)
//{
//    Console.WriteLine("Password is valid.");
//}
//else
//{
//    Console.WriteLine("Password is invalid.");
//}
////.5.
//Console.Write("Enter the number of Fibonacci numbers: ");
//int count = int.Parse(Console.ReadLine());

//int previousNumber = 0, currentNumber = 1;
//Console.Write(previousNumber);

//for (int i = 1; i < count; i++)
//{
//    Console.Write(", " + currentNumber);
//    int nextNumber = previousNumber + currentNumber;
//    previousNumber = currentNumber;
//    currentNumber = nextNumber;
//}
////.6.
//Console.Write("Enter the number of hours worked: ");
//double hoursWorked = double.Parse(Console.ReadLine());
//Console.Write("Enter the hourly rate: ");
//double hourlyRate = double.Parse(Console.ReadLine());

//double dailyWage = hoursWorked * hourlyRate;
//Console.WriteLine($"Daily wage: {dailyWage:F2}");
////.7.
//Console.Write("Enter a number: ");
//int number = int.Parse(Console.ReadLine());

//for (int multiplier = 1; multiplier <= 10; multiplier++)
//{
//    Console.WriteLine($"{number} x {multiplier} = {number * multiplier}");
//}
////.8.
//Console.Write("Enter a number: ");
//int numberT8 = int.Parse(Console.ReadLine());
//bool isPrime = true;

//if (numberT8 < 2)
//{
//    isPrime = false;
//}
//else
//{
//    for (int divisor = 2; divisor <= Math.Sqrt(numberT8); divisor++)
//    {
//        if (numberT8 % divisor == 0)
//        {
//            isPrime = false;
//            break;
//        }
//    }
//}

//if (isPrime)
//{
//    Console.WriteLine("The number is prime.");
//}
//else
//{
//    Console.WriteLine("The number is not prime.");
//}