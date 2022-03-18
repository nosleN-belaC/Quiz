/*Console.WriteLine(
    FiggleFonts.Orge.Render("Hello World"));
*/


// Made by Caleb Nelson
Console.WriteLine("This is a Te Reo Maori word quiz.");
Console.WriteLine("You only have one shot at each question so make it count");
Console.WriteLine(" ");
Console.WriteLine("Question 1: What is the Maori word for family?");
Console.WriteLine("A: Whanau");
Console.WriteLine("B: Aotearoa");
Console.WriteLine("C: Haka");

// This makes it so the answer no matter what case it will make it capital
string q1 = (Console.ReadLine());
string upper_q1 = q1.ToUpper();
if (upper_q1 == "A")
{
    Console.WriteLine("You are correct");
}
else
{
    Console.WriteLine("This is incorrect");
}
Console.WriteLine("Question 2: What is the Maori word for Love");
Console.WriteLine("A: Awa");
Console.WriteLine("B: Aroha");
Console.WriteLine("C: Kai");

string q2 = Console.ReadLine();
string upper_q2 = q2.ToUpper();
if (upper_q2 == "B")
{
    Console.WriteLine("You are correct");
}
else 
{
    Console.WriteLine("This is incorrect");
}
Console.WriteLine("Question 3: What is the Maori word for Work ");
Console.WriteLine("A: Mahi ");
Console.WriteLine("B: Kiwi");
Console.WriteLine("C: Marae");

string q3 = Console.ReadLine();
string upper_q3 = q3.ToUpper();
if (upper_q3 == "A")
{
    Console.WriteLine("You are correct");
}
else
{
    Console.WriteLine("This is incorrect");
}