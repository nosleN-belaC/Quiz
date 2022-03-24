// Made by Caleb Nelson
Console.WriteLine("This is a Te Reo Maori word and phrase quiz.");
Console.WriteLine("If you enter any other character that is not a, b, or c you will be incorrect.");
Console.WriteLine("There are 10 questions and you only have one shot at each one so make it count.");
Console.WriteLine("The questions start off easy and get harder as the quiz goes on.\n");
Console.WriteLine("Question 1: What is the Maori word for family?");
Console.WriteLine("A: Whanau");
Console.WriteLine("B: Aotearoa");
Console.WriteLine("C: Haka");

string q1 = (Console.ReadLine());
string upper_q1 = q1.ToUpper();
if (upper_q1 == "A")
{
    Console.WriteLine("You are correct");
}
else
{
    Console.WriteLine("This is incorrect, the answer is A");
}
Console.WriteLine(" ");
Console.WriteLine("Question 2: What is the Maori word for Love?");
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
    Console.WriteLine("This is incorrect, the answer is B");
}
Console.WriteLine(" ");
Console.WriteLine("Question 3: What is the Maori word for Work?");
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
    Console.WriteLine("This is incorrect, the answer is A");
}
Console.WriteLine(" ");
Console.WriteLine("Question 4: What is Maori for the word Hello?");
Console.WriteLine("A: Mōrena");
Console.WriteLine("B: Kapa Haka");
Console.WriteLine("C: Kia ora");

string q4 = Console.ReadLine();
string upper_q4 = q4.ToUpper();
if (upper_q4 == "C")
{
    Console.WriteLine("You are correct");
}
else
{
    Console.WriteLine("This is incorrect, the answer is C");
}
Console.WriteLine(" ");
    Console.WriteLine("Now the questions are going to get harder, good luck.");

Console.WriteLine(" ");
Console.WriteLine("Question 5: What is the Maori phrase for Welcome");
Console.WriteLine("A: Tēnā koe");
Console.WriteLine("B: Haere mai");
Console.WriteLine("C: E noho");

string q5 = Console.ReadLine();
string upper_q5 = q5.ToUpper();
if (upper_q5 == "B")
{
    Console.WriteLine("You are correct");
}
else
{
    Console.WriteLine("This is incorrect, the answer is B");
}
Console.WriteLine(" ");
Console.WriteLine("Question 6: What is the Maori word for children");
Console.WriteLine("A: Waiata");
Console.WriteLine("B: Tamāhine");
Console.WriteLine("C: Tamariki ");

string q6 = Console.ReadLine();
string upper_q6 = q6.ToUpper();
if (upper_q6 == "C")
{
    Console.WriteLine("You are correct");
}
else
{
    Console.WriteLine("This is incorrect, the answer is C");
}
Console.WriteLine(" ");
Console.WriteLine("Question 7: What is the Maori word for funeral");
Console.WriteLine("A: Taonga");
Console.WriteLine("B: Tangi");
Console.WriteLine("C: Tāne");

string q7 = Console.ReadLine();
string upper_q7 = q7.ToUpper();
if (upper_q7 == "B")
{
    Console.WriteLine("You are correct");
}
else
{
    Console.WriteLine("This is incorrect");
}
Console.WriteLine(" ");
Console.WriteLine("Question 8: What is the Maori word for elder");
Console.WriteLine("A: Manuhiri");
Console.WriteLine("B: Kaumatua");
Console.WriteLine("C: Whenua");

string q8 = Console.ReadLine();
string upper_q8 = q8.ToUpper();
if (upper_q8 == "B")
{
    Console.WriteLine("You are correct");
}
else
{
    Console.WriteLine("This is incorrect, the answer is B");
}
Console.WriteLine(" ");
Console.WriteLine("Question 9: What is the name for a Maori chief?");
Console.WriteLine("A: Whare whakairo");
Console.WriteLine("B: Rangatira");
Console.WriteLine("C: Whanaunga");

string q9 = Console.ReadLine();
string upper_q9 = q9.ToUpper();
if (upper_q9 == "B")
{
    Console.WriteLine("You are correct");
}
else
{
    Console.WriteLine("This is incorrect, the answer is B");
}
Console.WriteLine(" ");
Console.WriteLine("Question 10: What does Manuhiri mean in English?");
Console.WriteLine("A: Greenstone");
Console.WriteLine("B: Goodbye");
Console.WriteLine("C: Guests");

string q10 = Console.ReadLine();
string upper_q10 = q10.ToUpper();
if (upper_q10 == "C")
{
    Console.WriteLine("You are correct");
}
else
{
    Console.WriteLine("This is incorrect, the answer is C");
}
Console.WriteLine(" ");
Console.WriteLine("Well done you have finished the quiz!");
Console.WriteLine("You got a score of:  ");