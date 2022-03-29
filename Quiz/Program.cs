// This code asks you 10 multi choice questions about the Maori language

int q1Answer, q2Answer, q3Answer, q4Answer, q5Answer, q6Answer, q7Answer, q8Answer, q9Answer, q10Answer, q11Answer, q12Answer, q13Answer, q14Answer, q15Answer;
int score = 0;
Console.WriteLine(" ");
Console.WriteLine("This is a Te Reo Maori word and phrase quiz.");
Console.WriteLine("If you enter any other character that is not a, b, or c you will be incorrect.");
Console.WriteLine("There are 10 questions and you only have one shot at each one so make it count.");
Console.WriteLine("The questions start off easy and get harder as the quiz goes on.\n");
/*Console.WriteLine("Would you like to start with the harder questions?");
string q0 = (Console.ReadLine().ToUpper());
if (q0 == "YES")
{
goto harderQuestions;
}
*/
quizStart:
Console.WriteLine(" ");
Console.WriteLine("Question 1: What is the Maori word for family?");
Console.WriteLine("A: Whanau");
Console.WriteLine("B: Aotearoa");
Console.WriteLine("C: Haka");

string q1 = (Console.ReadLine().ToUpper());
if (q1 == "A")
{
    Console.WriteLine("You are correct");
    q1Answer = 1;
    score = score + 1;
}
else
{
    Console.WriteLine("This is incorrect, the answer is A");
    q1Answer = 0;
}

Console.WriteLine(" ");
Console.WriteLine("Question 2: What is the Maori word for Love?");
Console.WriteLine("A: Awa");
Console.WriteLine("B: Aroha");
Console.WriteLine("C: Kai");

string q2 = (Console.ReadLine().ToUpper());

if (q2 == "B")
{
    Console.WriteLine("You are correct");
    q2Answer = 1;
    score = score + 1;
}
else
{
    Console.WriteLine("This is incorrect, the answer is B");
    q2Answer = 0;
}

Console.WriteLine(" ");
Console.WriteLine("Question 3: What is the Maori word for Work?");
Console.WriteLine("A: Mahi ");
Console.WriteLine("B: Kiwi");
Console.WriteLine("C: Marae");

string q3 = (Console.ReadLine().ToUpper());
if (q3 == "A")
{
    Console.WriteLine("You are correct");
    q3Answer = 1;
    score = score + 1;
}
else
{
    Console.WriteLine("This is incorrect, the answer is A");
    q3Answer = 0;
}

Console.WriteLine(" ");
Console.WriteLine("Question 4: What is Maori for the word Hello?");
Console.WriteLine("A: Mōrena");
Console.WriteLine("B: Kapa Haka");
Console.WriteLine("C: Kia ora");

string q4 = (Console.ReadLine().ToUpper());
if (q4 == "C")
{
    Console.WriteLine("You are correct");
    q4Answer = 1;
    score = score + 1;
}
else
{
    Console.WriteLine("This is incorrect, the answer is C");
    q4Answer = 0;
}

Console.WriteLine(" ");
Console.WriteLine("Now the questions are going to get harder, good luck.");

Console.WriteLine(" ");
Console.WriteLine("Question 5: What is the Maori phrase for Welcome");
Console.WriteLine("A: Tēnā koe");
Console.WriteLine("B: Haere mai");
Console.WriteLine("C: E noho");

string q5 = (Console.ReadLine().ToUpper());
if (q5 == "B")
{
    Console.WriteLine("You are correct");
    q5Answer = 1;
    score = score + 1;
}
else
{
    Console.WriteLine("This is incorrect, the answer is B");
    q5Answer = 0;
}

Console.WriteLine(" ");
Console.WriteLine("Question 6: What is the Maori word for children");
Console.WriteLine("A: Waiata");
Console.WriteLine("B: Tamāhine");
Console.WriteLine("C: Tamariki ");

string q6 = (Console.ReadLine().ToUpper());
if (q6 == "C")
{
    Console.WriteLine("You are correct");
    q6Answer = 1;
    score = score + 1;
}
else
{
    Console.WriteLine("This is incorrect, the answer is C");
    q6Answer = 0;
}


Console.WriteLine(" ");
Console.WriteLine("Question 7: What is the Maori word for funeral");
Console.WriteLine("A: Taonga");
Console.WriteLine("B: Tangi");
Console.WriteLine("C: Tāne");

//harderQuestions:
string q7 = (Console.ReadLine().ToUpper());
if (q7 == "B")
{
    Console.WriteLine("You are correct");
    q7Answer = 1;
    score = score + 1;
}
else
{
    Console.WriteLine("This is incorrect");
    q7Answer = 0;
}

Console.WriteLine(" ");
Console.WriteLine("Question 8: What is the Maori word for elder");
Console.WriteLine("A: Manuhiri");
Console.WriteLine("B: Kaumatua");
Console.WriteLine("C: Whenua");

string q8 = (Console.ReadLine().ToUpper());
if (q8 == "B")
{
    Console.WriteLine("You are correct");
    q8Answer = 1;
    score = score + 1;
}
else
{
    Console.WriteLine("This is incorrect, the answer is B");
    q8Answer = 0;
}

Console.WriteLine(" ");
Console.WriteLine("Question 9: What is the name for a Maori chief?");
Console.WriteLine("A: Whare whakairo");
Console.WriteLine("B: Rangatira");
Console.WriteLine("C: Whanaunga");

string q9 = (Console.ReadLine().ToUpper());
if (q9 == "B")
{
    Console.WriteLine("You are correct");
    q9Answer = 1;
    score = score + 1;
}
else
{
    Console.WriteLine("This is incorrect, the answer is B");
    q9Answer = 0;
}

Console.WriteLine(" ");
Console.WriteLine("Question 10: What does Manuhiri mean in English?");
Console.WriteLine("A: Greenstone");
Console.WriteLine("B: Goodbye");
Console.WriteLine("C: Guests");

string q10 = (Console.ReadLine().ToUpper());
if (q10 == "C")
{
    Console.WriteLine("You are correct");
    q10Answer = 1;
    score = score + 1;
}
else
{
    Console.WriteLine("This is incorrect, the answer is C");
    q10Answer = 0;
}

Console.WriteLine(" ");
Console.WriteLine("Question 11: What does Hei āpōpō mean in English?");
Console.WriteLine("A: See you tomorrow");
Console.WriteLine("B: Many thanks");
Console.WriteLine("C: Regards");

string q11 = (Console.ReadLine().ToUpper());
if (q11 == "A")
{
    Console.WriteLine("You are correct");
    q11Answer = 1;
    score = score + 1;
}
else
{
    Console.WriteLine("This is incorrect, the answer is A");
    q11Answer = 0;
 
}

Console.WriteLine(" ");
Console.WriteLine("Question 12: What does Hospitality, kindness, generosity, support mean in Maori?");
Console.WriteLine("A: Waiata");
Console.WriteLine("B: Manaakitanga");
Console.WriteLine("C: Kaikōrero");

string q12 = (Console.ReadLine().ToUpper());
if (q12 == "B")
{
    Console.WriteLine("You are correct");
    q12Answer = 1;
    score = score + 1;
}
else
{
    Console.WriteLine("This is incorrect, the answer is B");
    q12Answer = 0;
}

Console.WriteLine(" ");
Console.WriteLine("Question 13: What does Whanaungatanga mean in English?");
Console.WriteLine("A: Relationship, kinship, sense of family connection");
Console.WriteLine("B: Respect for hosts or kindness to guests, to entertain, to look after");
Console.WriteLine("C: Confiscate, take by force");

string q13 = (Console.ReadLine().ToUpper());
if (q13 == "A")
{
    Console.WriteLine("You are correct");
    q13Answer = 1;
    score = score + 1;
}
else
{
    Console.WriteLine("This is incorrect, the answer is B");
    q13Answer = 0;
}

Console.WriteLine(" ");
Console.WriteLine("Question 14: What is Toilet in Maori?");
Console.WriteLine("A: Rohe");
Console.WriteLine("B: Noa");
Console.WriteLine("C: Whare paku");

string q14 = (Console.ReadLine().ToUpper());
if (q14 == "C")
{
    Console.WriteLine("You are correct");
    q14Answer = 1;
    score = score + 1;
}
else
{
    Console.WriteLine("This is incorrect, the answer is C");
    q14Answer = 0;
}

Console.WriteLine(" ");
Console.WriteLine("Question 15: What does Tūrangawaewae mean in English?");
Console.WriteLine("A: Fostered or adopted child");
Console.WriteLine("B: Genealogy");
Console.WriteLine("C: A place to stand, a place to belong to, a seat or location of identity");

string q15 = (Console.ReadLine().ToUpper());
if (q15 == "C")
{
    Console.WriteLine("You are correct");
    q15Answer = 1;
    score = score + 1;
}
else
{
    Console.WriteLine("This is incorrect, the answer is C");
    q15Answer = 0;
}

Console.WriteLine(" ");
Console.WriteLine("Well done you have finished the quiz!");
Console.WriteLine("You got a score of: " + (q15Answer + q14Answer + q13Answer + q12Answer + q11Answer + q10Answer + q9Answer + q8Answer + q7Answer + q6Answer + q5Answer + q4Answer + q3Answer + q2Answer + q1Answer));
Console.WriteLine("Test: " + score);
Console.WriteLine(" ");
Console.WriteLine("Would you like to try again and try get a better score? \n[YES]/[NO]");
string retry = (Console.ReadLine().ToUpper());
if (retry == "YES")
{
    goto quizStart;
}
else
{
    Console.WriteLine("Have a nice day.");
}
