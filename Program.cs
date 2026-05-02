Console.Write("How many small rugs do you have? ");
int small = int.Parse(Console.ReadLine());

Console.Write("How many large rugs do you have? ");
int large = int.Parse(Console.ReadLine());

Console.WriteLine($"Number of small carpets: {small}");
Console.WriteLine($"Number of large carpets: {large}");

Console.WriteLine("Price per small carpet: $25");
Console.WriteLine("Price per large carpet: $35");

Console.WriteLine($"Cost: ${small * 25 + large * 35}");
Console.WriteLine($"Tax: ${6.6}");

Console.WriteLine($"Total estimate : ${small * 25 + large * 35 + 6.6}");

Console.WriteLine("This estimate is valid for 30 days.");
