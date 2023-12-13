using Conditionals;
// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// ***********************************
// var number = 2;
// var count = 10;
// var totalPrice = 20.95f;
// var isWorking = false;

// System.Console.WriteLine(number);
// System.Console.WriteLine(count);
// System.Console.WriteLine(totalPrice);
// System.Console.WriteLine(isWorking);

// ***********************************
// System.Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
// System.Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);

// ***********************************
// const float Pi = 3.14f;

// ************************************
// int i = 1000;
// byte b = (byte) i;
// Console.WriteLine(b);

// ***********************************
using Math;

try
{
  var number = "1234";
  int i = Convert.ToByte(number);
  System.Console.WriteLine(i);  

  string str = "true";
  bool b = Convert.ToBoolean(str);
  Console.WriteLine(b);
}
catch (System.Exception)
{
  System.Console.WriteLine("The number could not be converted to a byte");
  // throw;
}

var john = new Person();
john.FirstName = "John";
john.LastName = "Smith";
john.Introduce();

var result = Calculator.Add(1, 2);
System.Console.WriteLine(result);


// ARRAYS
int[] numbers = new int[3] { 1,2,3 };

// -----------------------------------------
int hour = 10;

if(hour > 0 && hour < 12)
{
  Console.WriteLine("It's morning.");
}
else if(hour >- 12 && hour < 18)
{
  Console.WriteLine("It's afternoon.");
}
else 
{
  Console.WriteLine("It's evening.");
}

bool isGoldCustomer = true;

float price = (isGoldCustomer) ? 19.95f : 29.95f;

Console.WriteLine(price);



// ----------------------------------------
  var season = Season.Autumn;

  switch (season)
  {
    case Season.Autumn:
      Console.WriteLine("It's autumn and a beautiful season.");
      break;

    case Season.Summer:
      Console.WriteLine("Ti's perfect to go to beach");
      break;

    default:
      Console.WriteLine("I don't understand that season");
      break;
  }
