/* This code is 2 levels of a multipul choice Maori quiz, the first having 15 questions with them getting harder as
quiz goes on. The second level is a 5 Maori sentence based multipul choice question quiz */

int q1Answer, q2Answer, q3Answer, q4Answer, q5Answer, q6Answer, q7Answer, q8Answer, q9Answer, q10Answer, q11Answer, q12Answer, q13Answer, q14Answer, q15Answer;

//Intro to quiz:
Console.WriteLine(" ");
Console.WriteLine("This is a Te Reo Maori word and phrase quiz.");
Console.WriteLine("If you enter any other character that is not a, b, or c you will be incorrect.");
Console.WriteLine("There are 2 levels, 15 in level 1 and 5 in level 2.");
Console.WriteLine("The questions in level 1 start off easy and get harder as the quiz goes on.");
Console.WriteLine("Level 2 is mainly about Maori sentances.\n");
level2Check:
Console.WriteLine("Would you rather start with the harder Maori quiz (Level 2)?\n[YES]/[NO]");
string startLevel2 = Console.ReadLine().ToUpper();
if (startLevel2 == "YES")
{
    goto level2;
}
else if (startLevel2 == "NO")
{
    goto quizStart;
}
else
{
    Console.WriteLine("This input is invaild, try again!");
    goto level2Check;
}

quizStart:
Console.WriteLine("Press enter to start level 1");
string enterStart = (Console.ReadLine().ToUpper());
if (enterStart == " ")
{
    Console.WriteLine("Goodluck!");
}
else
{
    Console.WriteLine("Goodluck!");
}

//Question 1 starts here
Console.Clear();
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
}
else
{
    Console.WriteLine("This is incorrect, the answer is A");
    q1Answer = 0;
}

//Question 2 starts here
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
}
else
{
    Console.WriteLine("This is incorrect, the answer is B");
    q2Answer = 0;
}

//Question 3 starts here
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
}
else
{
    Console.WriteLine("This is incorrect, the answer is A");
    q3Answer = 0;
}

//Question 4 starts here
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
}
else
{
    Console.WriteLine("This is incorrect, the answer is C");
    q4Answer = 0;
}

Console.WriteLine(" ");
Console.WriteLine("Now the questions are going to get harder, good luck.");
// This is when the questions generally start to get a bit harder.

//Question 5 starts here
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
}
else
{
    Console.WriteLine("This is incorrect, the answer is B");
    q5Answer = 0;
}

//Question 6 starts here
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
}
else
{
    Console.WriteLine("This is incorrect, the answer is C");
    q6Answer = 0;
}

//Question 7 starts here
Console.WriteLine(" ");
Console.WriteLine("Question 7: What is the Maori word for funeral");
Console.WriteLine("A: Taonga");
Console.WriteLine("B: Tangi");
Console.WriteLine("C: Tāne");

string q7 = (Console.ReadLine().ToUpper());
if (q7 == "B")
{
    Console.WriteLine("You are correct");
    q7Answer = 1;
}
else
{
    Console.WriteLine("This is incorrect");
    q7Answer = 0;
}

//Question 8 starts here
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
}
else
{
    Console.WriteLine("This is incorrect, the answer is B");
    q8Answer = 0;
}

//Question 9 starts here
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
}
else
{
    Console.WriteLine("This is incorrect, the answer is B");
    q9Answer = 0;
}

//Question 10 starts here
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
}
else
{
    Console.WriteLine("This is incorrect, the answer is C");
    q10Answer = 0;
}

//Question 11 starts here
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
}
else
{
    Console.WriteLine("This is incorrect, the answer is A");
    q11Answer = 0;
 
}

//Question 12 starts here
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
}
else
{
    Console.WriteLine("This is incorrect, the answer is B");
    q12Answer = 0;
}

//Question 13 starts here
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
}
else
{
    Console.WriteLine("This is incorrect, the answer is B");
    q13Answer = 0;
}

//Question 14 starts here
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
}
else
{
    Console.WriteLine("This is incorrect, the answer is C");
    q14Answer = 0;
}

//Question 15 starts here
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
}
else
{
    Console.WriteLine("This is incorrect, the answer is C");
    q15Answer = 0;
}

Console.Clear();
Console.WriteLine(" ");
Console.WriteLine("Well done you have finished level 1!");
// The bit of code underneath this comment adds all the scores from questions 1-15 and displays them as a number out of 15.
Console.WriteLine("You got a score of: " + (q15Answer + q14Answer + q13Answer + q12Answer + q11Answer + q10Answer + q9Answer + q8Answer + q7Answer + q6Answer + q5Answer + q4Answer + q3Answer + q2Answer + q1Answer));
Console.WriteLine(" ");
/*The code underneath asks the user if they would like to retry level 1 and try get a better score.
 If they say no they are asked if they would like to start level 2, if they still say no it will exit the quiz.7*/
level1Check:
Console.WriteLine("Would you like to try level 1 again and try get a better score? \n[YES]/[NO]");
string retry = (Console.ReadLine().ToUpper());
if (retry == "YES")
{
    goto quizStart;
}
else if (retry == "NO")
{
    Console.WriteLine(" ");    
    Console.WriteLine("Would you like to try level 2?\n[YES]/[NO]");
}
else
{
    Console.WriteLine("This input is invalid, try again!");
    goto level1Check;
}
string level2Start = (Console.ReadLine().ToUpper());
if (level2Start == "YES")
{
    goto level2;
}
else if (level2Start == "NO")
{
    goto quizEnd;
}
else
{
    Console.WriteLine("This input is invalid, try again!");
    goto level1Check;
}

level2:

// THis is where level 2 begins
Console.Clear();
Console.WriteLine("Level 2 begins here\n");
Console.WriteLine("");
Console.WriteLine("This level consists of Maori sentances and you have to translate them to English.");
Console.WriteLine("Press enter to begin level 2:");
string enterStart2 = (Console.ReadLine().ToUpper());
if (enterStart2 == " ")
{
    Console.WriteLine("Goodluck!");
}
else
{
    Console.WriteLine("Goodluck!");
}

int q16Answer, q17Answer, q18Answer, q19Answer, q20Answer;

Console.Clear();
Console.WriteLine(" ");
Console.WriteLine("Question 1: What does Haere mai ki konei mean in English?");
Console.WriteLine("A: Come over here");
Console.WriteLine("B: How are you");
Console.WriteLine("C: What are you doing");

string q16 = (Console.ReadLine().ToUpper());
if (q16 == "A")
{
    Console.WriteLine("You are correct");
    q16Answer = 1;
}
else
{
    Console.WriteLine("This is incorrect, the answer is A");
    q16Answer = 0;
}

Console.WriteLine(" ");
Console.WriteLine("Question 2: What does Tēnā homai he kapu tī mean?");
Console.WriteLine("A: Can I have some food please?");
Console.WriteLine("B: Where are you going?");
Console.WriteLine("C: Please provide a cup of tea");

string q17 = (Console.ReadLine().ToUpper());
if (q17 == "C")
{
    Console.WriteLine("You are correct");
    q17Answer = 1;
}
else
{
    Console.WriteLine("This is incorrect, the answer C");
    q17Answer = 0;
}

Console.WriteLine(" ");
Console.WriteLine("Question 3: What does Me haere tāua ki te tina mean in English?");
Console.WriteLine("A: Shall I meet you (one person) for lunch?");
Console.WriteLine("B: Meet me at the Library");
Console.WriteLine("C: Would like a water?");

string q18 = (Console.ReadLine().ToUpper());
if (q18 == "A")
{
    Console.WriteLine("You are correct");
    q18Answer = 1;
}
else
{
    Console.WriteLine("This is incorrect, the answer is A");
    q18Answer=0;
}

Console.WriteLine(" ");
Console.WriteLine("Question 4: What does Āe, taihoa ake nei mean?");
Console.WriteLine("A: Where are you?");
Console.WriteLine("B: Yes, one moment please");
Console.WriteLine("C: Wait a minute");

string q19 = (Console.ReadLine().ToUpper());
if (q19 == "B")
{
    Console.WriteLine("You are correct");
    q19Answer = 1;
}
else
{
    Console.WriteLine("This is incorrect, the answer is B");
    q19Answer = 0;
}

Console.WriteLine(" ");
Console.WriteLine("Question 5: What does Me hui tahi tāua mean?");
Console.WriteLine("A: My computer is broken");
Console.WriteLine("B: The internet is slow today");
Console.WriteLine("C: I would like to meet with you");

string q20 = (Console.ReadLine().ToUpper());
if (q20 == "")
{
    Console.WriteLine("You are correct");
    q20Answer = 1;
}
else
{
    Console.WriteLine("This is incorrect, the answer is C");
    q20Answer = 0;
}

Console.Clear();
Console.WriteLine(" ");
Console.WriteLine("Well done you have finished level 2!");
// The line underneath also adds the scores from question 1-5 in level 2 and displays them as a number.
Console.WriteLine("You got a score of: " + (q16Answer + q17Answer + q18Answer + q19Answer + q20Answer));
Console.WriteLine(" ");
// The code underneath asks you if you would like to retry level 2 or retry the whole quiz again.
retryLevel2:
Console.WriteLine("Would you like to try level 2 again and try get a better score? \n[YES]/[NO]");

string  retryL2= (Console.ReadLine().ToUpper());
if (retryL2== "YES")
{
goto level2;
}
else if (retryL2 == "NO")
{
Console.WriteLine(" ");
Console.WriteLine("Would you like to try restart the whole quiz?\n[YES]/[NO]");
}
else
{
    Console.WriteLine("This input is invalid, try again!");
    goto retryLevel2;
}

string retryQuiz = (Console.ReadLine().ToUpper());
if (retryQuiz == "YES")
{
goto quizStart;
}
// fix else
else
{
goto quizEnd;
}

quizEnd:
Console.Clear();
Console.WriteLine("Have a nice day!");
// This is the end of the quiz.