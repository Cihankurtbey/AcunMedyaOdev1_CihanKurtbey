

// 1: Sayının Pozitif, Negatif veya Sıfır Olduğunu Belirleme (if-else)

/*
 Console.WriteLine("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0)
{
    Console.WriteLine("Number is positive ");
}
else if (number == 0)
{
    Console.WriteLine("Number is zero");
}
else
{
    Console.WriteLine("Number is negative");
}
*/





// 2: Gün İsmi Belirleme (switch-case)


/* Console.WriteLine("Enter day number:");
int dayNumber = Convert.ToInt32(Console.ReadLine());

switch (dayNumber)
{
    case 1:
        Console.WriteLine("Today is Monday");
        break;
    case 2:
        Console.WriteLine("Today is Tuesday");
        break;
    case 3:
        Console.WriteLine("Today is Wednesday");
        break;
    case 4:
        Console.WriteLine("Today is Thursday");
        break;
    case 5:
        Console.WriteLine("Today is Friday");
        break;
    case 6:
        Console.WriteLine("Today is Saturday");
        break;
    case 7:
        Console.WriteLine("Today is Sunday");
        break;
    default:
        Console.WriteLine("İnvalid Day Number");
        break;
        
}
*/




// 3-Basit Hesap Makinesi (switch-case)

/* Console.WriteLine("Enter two numbers: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Select a transaction number: ");
Console.WriteLine("1-  +");
Console.WriteLine("2-  -");
Console.WriteLine("3-  *");
Console.WriteLine("4-  /");

int operateNumber = Convert.ToInt32(Console.ReadLine());

switch (operateNumber)
{
    case 1:
        Console.WriteLine("Process result:"+(num1+num2));
        break;
    case 2:
        Console.WriteLine("Process result:" + (num1-num2));
        break;
    case 3:
        Console.WriteLine("Process result:" + (num1*num2));
        break;
    case 4:
        Console.WriteLine("Process result:" + (num1/num2));
        break;
    default:
        Console.WriteLine("Invalid Number");
        break;
}

*/


// 4-Üç Sayının En Büyüğünü Bulma (if-else)

/*Console.WriteLine("Enter three numbers: ");

int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int num3 = Convert.ToInt32(Console.ReadLine());

if(num1>num2 && num1 > num3)
{
    Console.WriteLine("The biggest number is "+num1);
}

else if (num2 > num3 && num2 > num1)
{
    Console.WriteLine("The biggest number is " + num2);
}

else
{
    Console.WriteLine("The biggest number is " + num3);
}
*/



//5-Şifre Güçlülüğünü Kontrol Etme (if-else)

/*
 Console.WriteLine("Enter a password: ");
string password = Console.ReadLine();

if (password.Length < 8)
{
    Console.WriteLine("Password must not be less than 8 characters");
}
else if (!(password.Contains("@") || password.Contains("#") || password.Contains("$") || password.Contains("%")))
{
    Console.WriteLine("Your password must have the following special characters=> (@, #, $, %)");
}

else
{
    bool capitalLetter = false;

    for (int i = 0; i < password.Length; i++)
    {
        if (char.IsUpper(password[i]))
        {
            capitalLetter = true;
            break;
        }
    }


    if (!capitalLetter)
    {
        Console.WriteLine("Password must have a capital letter");
    }
    else
    {
        Console.WriteLine("Password is very strong");
    }
}
*/

