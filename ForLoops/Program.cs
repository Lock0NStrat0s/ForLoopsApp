

//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine($"The value of i is {i}");
//}

//string data = "Tim,Bob,Sue,Jane";
//List<string> firstNames = data.Split(',').ToList();

//for (int i = 0; i < firstNames.Count; i++)
//{
//    Console.WriteLine($"{firstNames[i]} is in attendance.");
//}

List<decimal> charges = new();

charges.Add(23.78M);
charges.Add(15.89M);
charges.Add(125M);

decimal total = 0;

for (int i = 0; i < charges.Count; i++)
{
    total += charges[i];
}

Console.WriteLine($"Our total charge is {total}.");