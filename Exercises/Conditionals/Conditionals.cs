public class Conditionals {
  public void EnterNumber() 
  {
    Console.Write("Enter a number between 1 to 10: ");
    var input = Console.ReadLine();
    var number = Convert.ToInt32(input);
    if(number >= 1 && number <= 10)
      Console.WriteLine("Valid");
    else 
      Console.WriteLine("Invalid");
  }

  public void Maximum() 
  {
    Console.Write("Enter a number: ");
    var input1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter a second number: ");
    var input2 = Convert.ToInt32(Console.ReadLine());

    var max = input1 > input2 ? input1 : input2;
    Console.WriteLine("Max is " + max);
  }

  public void ImageType()
  {
    Console.Write("Image width: ");
    var width = Convert.ToInt32(Console.ReadLine());

    Console.Write("Image height: ");
    var height = Convert.ToInt32(Console.ReadLine());

    // var orientation = width > height ? ImageOrientation.Landscape : ImageOrientation.Portrait;
    var orientation = width > height ? "landscape" : "portrait";
    Console.WriteLine("Image orientation is " + orientation);
  }
}

