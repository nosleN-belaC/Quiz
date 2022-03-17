Console.WriteLine("This is a Te Reo Maori word quiz.");
Console.WriteLine("You only have one shot at each question so make it count");
Console.WriteLine("Question 1: What is the Maori word for family?");
Console.WriteLine("A: Whanau");
Console.WriteLine("B: Aotearoa");
Console.WriteLine("C: Haka");
string q1 = Console.ReadLine();
if (q1 == "A" || q1 == "a")
{
    Console.WriteLine("You are correct");
}
else if (q1 == "B" || q1 == "C" || q1 == "b" || q1 == "c")
{
    Console.WriteLine("This is incorrect");
}
Console.WriteLine("Question 2: What is the Maori word for Love");
Console.WriteLine("A: Awa");
Console.WriteLine("B: Aroha");
Console.WriteLine("C: Kai");
string q2 = Console.ReadLine();
if (q2 == "B" || q2 == "b")
{
    Console.WriteLine("You are correct");
}
else if (q2 == "A" || q2 == "C" || q2 == "a" || q2 == "c")
{
    Console.WriteLine("This is incorrect");
}
Console.WriteLine("Question 3: What is the Maori word for Work ");
Console.WriteLine("A: Mahi ");
Console.WriteLine("B: Kiwi");
Console.WriteLine("C: Marae");
string q3 = Console.ReadLine();
if (q3 == "A" || q3 == "a")
{
    Console.WriteLine("You are correct");
}
else if (q3 == "B" || q3 == "C" || q3 == "b" || q3 == "c")
{
    Console.WriteLine("This is incorrect");
}