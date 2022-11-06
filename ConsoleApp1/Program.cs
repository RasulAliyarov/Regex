using System.Text.RegularExpressions;

//string number = "+994-55-555-55-55";

//Regex regex = new Regex(@"^\+994\-[0-9]{2}\-[0-9]{3}\-[0-9]{2}\-[0-9]{2}");

//Match match = regex.Match(number);

//Console.WriteLine(match.Success);





//string firstName = "Rasul";
//string secondName = "Aliyarov";

//Regex regex = new Regex(@"^[A-Z]{1}[a-z]{1,15}$");

//Match match = regex.Match(firstName);
//Match match2 = regex.Match(secondName);

//Console.WriteLine(match.Success);
//Console.WriteLine(match2.Success);




Console.WriteLine("\n\t---------------------Register-----------------------");

string username;
string name;
string surname;
string age;
string email;
string phoneNumber;
string password;



ERROR1:
Console.Write("Username: "); username = Console.ReadLine();
Console.Write("Password: "); password = Console.ReadLine();

if (username != null && password != null)
{
    Regex regexUserName = new Regex(@"^[a-zA-Z0-9.\-_$@*!]+$");
    Match matchUserName = regexUserName.Match(username);

    Regex regexPassword = new Regex(@"^\S[a-zA-Z0-9]{3,15}$");
    Match matchPassword = regexPassword.Match(password);


    if (matchUserName.Success == true && matchPassword.Success == true)
    {
        Console.WriteLine("------------");
    }
    else
    {
        Console.WriteLine("Write other Username or Password!!!");
        goto ERROR1;
    }
}

ERROR2:
Console.Write("Name: "); name = Console.ReadLine();
Console.Write("Surname: "); surname = Console.ReadLine();


Regex regexNS = new Regex(@"^[A-Z]{1}[a-z]{1,15}$");
Match matchName = regexNS.Match(name);
Match matchSurname = regexNS.Match(surname);

if (name != null && surname != null)
{

    if (matchName.Success == true && matchSurname.Success == true)
    {
        Console.WriteLine("------------");
    }
    else
    {
        Console.WriteLine("Change nom Name and Surname");
        goto ERROR2;
    }
}

ERROR3:
Console.Write("Phone number: "); phoneNumber = Console.ReadLine();

Regex regexPhoneNumber = new Regex(@"^\+994\-[0-9]{2}\-[0-9]{3}\-[0-9]{2}\-[0-9]{2}");

Match matchPhoneNumber = regexPhoneNumber.Match(phoneNumber);


if (phoneNumber != null)
{

    if (matchPhoneNumber.Success == true)
    {
        Console.WriteLine("------------");
    }
    else
    {
        Console.WriteLine("Write correct Phone number");
        goto ERROR3;
    }
}

ERROR4:
Console.Write("E-mail: "); email = Console.ReadLine();

Regex regexEmail = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
Match matchEmail = regexEmail.Match(email);


if (email != null)
{

    if (matchEmail.Success == true)
    {
        Console.WriteLine("------------");
    }
    else
    {
        Console.WriteLine("Write correct E-mail");
        goto ERROR4;
    }
}

ERROR5:
Console.Write("Age: "); age = Console.ReadLine();

Regex regexAge = new Regex(@"^(0?[1-9]|[1-9][0-9]|[1][1-9][1-9]|200)$");
Match matchAge = regexAge.Match(age);

if (age != null)
{

    if (matchAge.Success == true)
    {
        Console.WriteLine("----------");
    }
    else
    {
        Console.WriteLine("Write correct Age");
        goto ERROR5;

    }
}

var cloud = new { userName = username, name = name, surname = surname, password = password, age = age, email = email, phoneNumber = phoneNumber };

object[] mass = new object[0];
Array.Resize(ref mass, mass.Length + 1);
mass[mass.Length - 1] = cloud;


for (int i = 0; i < mass.Length; i++)
{
    Console.WriteLine(mass[i]);
}