// Quiz made by Caleb Nelson

/* This code is 2 levels of a multipul choice Maori quiz, the first having 15 questions with them getting harder as
quiz goes on. The second level is a 5 Maori sentence based multipul choice question quiz

Code starts

Score variables are stated

-Intro to quiz-

It asks you if you would like to start with level 2, if yes it goes to level 2, if no it continues with level 1.
It then asks you to press enter to start.

Question 1, if the answer is wrong it makes doesn't add anything to the score variable and then it tells you what the correct answer is and moves on to the next question.
But if it is correct it adds 1 to the score variable and then moves to the next question.

Question 2, if the answer is wrong it makes doesn't add anything to the score variable and then it tells you what the correct answer is and moves on to the next question.
But if it is correct it adds 1 to the score variable and then moves to the next question.

What happens to question 1 and 2 happen to every question up until question 15.

The code then tells you that you finished level 1 and then displays the score you got using the score variable (out of 15)

It then asks you if you would like to restart level 1, if yes then it goes to the start, if no then it moves onto level 2

-Intro to level 2-

It then asks you to press enter to start level 2

Question 1, if the answer is wrong it makes doesn't add anything to the score variable and then it tells you what the correct answer is and moves on to the next question.
But if it is correct it adds 1 to the score variable and then moves to the next question.

Question 2, if the answer is wrong it makes doesn't add anything to the score variable and then it tells you what the correct answer is and moves on to the next question.
But if it is correct it adds 1 to the score variable and then moves to the next question.

This happens for the rest of the questions up to question 5.

The code then tells you that you finished level 2 and then it displays the score using the score variable (score out of 5)

It the asks you if you would like to retry level 2 to get a better score, if yes it goes to the start of level 2.
If no it asks you if you would like to retry the whole quiz, if yes it goes to the begining.
If no again it says "Have a nice day"

Code ends
*/

int score = 0;
int scorelv2 = 0;

static bool passingScore(int score = 6, 5, 4, 3,)
{
    bool passed = false;
    return passed;
}

static void correctAnswer() // This shows when the user gets a question right. I did this so I dont have to type as much.
{
    Console.WriteLine("You are correct, well done!");
}

static void invalidInput() // This gets shown when the user inputs a invalid letter or word when answering some questions. Also did this so I dont have to type as much.
{
    Console.WriteLine("This input is invalid, try again!");
}


//Intro to quiz:
Console.WriteLine(" ");
Console.WriteLine("This is a multi level Te Reo Maori word and phrase quiz.");
Console.WriteLine("Please enter A, B or C when answering the questions otherwise you will be wrong.");
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
    invalidInput();
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

Console.Clear();
Console.WriteLine("Goodluck!");
Console.WriteLine(" ");
Console.WriteLine("Question 1: What is the Maori word for family?");
Console.WriteLine("A: Whanau");
Console.WriteLine("B: Aotearoa");
Console.WriteLine("C: Haka");

string q1 = (Console.ReadLine().ToUpper());
if (q1 == "A")
{
    correctAnswer();
    score++;
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

string q2 = (Console.ReadLine().ToUpper());

if (q2 == "B")
{
    correctAnswer();
    score++;
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

string q3 = (Console.ReadLine().ToUpper());
if (q3 == "A")
{
    correctAnswer();
    score++;
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

string q4 = (Console.ReadLine().ToUpper());
if (q4 == "C")
{
    correctAnswer();
    score++;
}
else
{
    Console.WriteLine("This is incorrect, the answer is C");
}

Console.WriteLine(" ");
Console.WriteLine("Now the questions are going to get harder, good luck.");
// This is when the questions generally start to get a bit harder.

Console.WriteLine(" ");
Console.WriteLine("Question 5: What is the Maori phrase for Welcome");
Console.WriteLine("A: Tēnā koe");
Console.WriteLine("B: Haere mai");
Console.WriteLine("C: E noho");

string q5 = (Console.ReadLine().ToUpper());
if (q5 == "B")
{
    correctAnswer();
    score++;
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

string q6 = (Console.ReadLine().ToUpper());
if (q6 == "C")
{
    correctAnswer();
    score++;
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

string q7 = (Console.ReadLine().ToUpper());
if (q7 == "B")
{
    correctAnswer();
    score++;
}
else
{
    Console.WriteLine("This is incorrect, the answer is B");
}

Console.WriteLine(" ");
Console.WriteLine("Question 8: What is the Maori word for elder");
Console.WriteLine("A: Manuhiri");
Console.WriteLine("B: Kaumatua");
Console.WriteLine("C: Whenua");

string q8 = (Console.ReadLine().ToUpper());
if (q8 == "B")
{
    correctAnswer();
    score++;
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

string q9 = (Console.ReadLine().ToUpper());
if (q9 == "B")
{
    correctAnswer();
    score++;
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

string q10 = (Console.ReadLine().ToUpper());
if (q10 == "C")
{
    correctAnswer();
    score++;
}
else
{
    Console.WriteLine("This is incorrect, the answer is C");
}

Console.WriteLine(" ");
Console.WriteLine("Question 11: What does Hei āpōpō mean in English?");
Console.WriteLine("A: See you tomorrow");
Console.WriteLine("B: Many thanks");
Console.WriteLine("C: Regards");

string q11 = (Console.ReadLine().ToUpper());
if (q11 == "A")
{
    correctAnswer();
    score++;
}
else
{
    Console.WriteLine("This is incorrect, the answer is A");
}

Console.WriteLine(" ");
Console.WriteLine("Question 12: What does Hospitality, kindness, generosity, support mean in Maori?");
Console.WriteLine("A: Waiata");
Console.WriteLine("B: Manaakitanga");
Console.WriteLine("C: Kaikōrero");

string q12 = (Console.ReadLine().ToUpper());
if (q12 == "B")
{
    correctAnswer();
    score++;
}
else
{
    Console.WriteLine("This is incorrect, the answer is B");
}

Console.WriteLine(" ");
Console.WriteLine("Question 13: What does Whanaungatanga mean in English?");
Console.WriteLine("A: Relationship, kinship, sense of family connection");
Console.WriteLine("B: Respect for hosts or kindness to guests, to entertain, to look after");
Console.WriteLine("C: Confiscate, take by force");

string q13 = (Console.ReadLine().ToUpper());
if (q13 == "A")
{
    correctAnswer();
    score++;
}
else
{
    Console.WriteLine("This is incorrect, the answer is A");
}

Console.WriteLine(" ");
Console.WriteLine("Question 14: What is Toilet in Maori?");
Console.WriteLine("A: Rohe");
Console.WriteLine("B: Noa");
Console.WriteLine("C: Whare paku");

string q14 = (Console.ReadLine().ToUpper());
if (q14 == "C")
{
    correctAnswer();
    score++;
}
else
{
    Console.WriteLine("This is incorrect, the answer is C");
}

Console.WriteLine(" ");
Console.WriteLine("Question 15: What does Tūrangawaewae mean in English?");
Console.WriteLine("A: Fostered or adopted child");
Console.WriteLine("B: Genealogy");
Console.WriteLine("C: A place to stand, a place to belong to, a seat or location of identity");

string q15 = (Console.ReadLine().ToUpper());
if (q15 == "C")
{
    correctAnswer();
    score++;
}
else
{
    Console.WriteLine("This is incorrect, the answer is C");
}

Console.Clear();
Console.WriteLine(" ");
Console.WriteLine("Well done you have finished level 1!");
// The bit of code underneath this comment adds all the scores from questions 1-15 and displays them as a number out of 15.
Console.WriteLine("You got a score of " + score + " out of 15");
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
    invalidInput();
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
    invalidInput();
    goto level1Check;
}

level2:

// This is where level 2 begins
Console.Clear();
Console.WriteLine("Goodluck!\n");
Console.WriteLine("Level 2 begins here\n");
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

Console.Clear();
Console.WriteLine(" ");
Console.WriteLine("Question 1: What does Haere mai ki konei mean in English?");
Console.WriteLine("A: Come over here");
Console.WriteLine("B: How are you");
Console.WriteLine("C: What are you doing");

string q16 = (Console.ReadLine().ToUpper());
if (q16 == "A")
{
    correctAnswer();
    scorelv2++;
}
else
{
    Console.WriteLine("This is incorrect, the answer is A");
}

Console.WriteLine(" ");
Console.WriteLine("Question 2: What does Tēnā homai he kapu tī mean?");
Console.WriteLine("A: Can I have some food please?");
Console.WriteLine("B: Where are you going?");
Console.WriteLine("C: Please provide a cup of tea");

string q17 = (Console.ReadLine().ToUpper());
if (q17 == "C")
{
    correctAnswer();
    scorelv2++;
}
else
{
    Console.WriteLine("This is incorrect, the answer C");
}

Console.WriteLine(" ");
Console.WriteLine("Question 3: What does Me haere tāua ki te tina mean in English?");
Console.WriteLine("A: Shall I meet you (one person) for lunch?");
Console.WriteLine("B: Meet me at the Library");
Console.WriteLine("C: Would like a water?");

string q18 = (Console.ReadLine().ToUpper());
if (q18 == "A")
{
    correctAnswer();
    scorelv2++;
}
else
{
    Console.WriteLine("This is incorrect, the answer is A");
}

Console.WriteLine(" ");
Console.WriteLine("Question 4: What does Āe, taihoa ake nei mean?");
Console.WriteLine("A: Where are you?");
Console.WriteLine("B: Yes, one moment please");
Console.WriteLine("C: Wait a minute");

string q19 = (Console.ReadLine().ToUpper());
if (q19 == "B")
{
    correctAnswer();
    scorelv2++;
}
else
{
    Console.WriteLine("This is incorrect, the answer is B");
}

Console.WriteLine(" ");
Console.WriteLine("Question 5: What does Me hui tahi tāua mean?");
Console.WriteLine("A: My computer is broken");
Console.WriteLine("B: The internet is slow today");
Console.WriteLine("C: I would like to meet with you");

string q20 = (Console.ReadLine().ToUpper());
if (q20 == "")
{
    correctAnswer();
    scorelv2++;
}
else
{
    Console.WriteLine("This is incorrect, the answer is C");
}


Console.Clear();
Console.WriteLine(" ");
Console.WriteLine("Well done you have finished level 2!");
Console.WriteLine("You got a score of: " + scorelv2 + " out of 5");
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
    invalidInput();
    goto retryLevel2;
}

string retryQuiz = (Console.ReadLine().ToUpper());
if (retryQuiz == "YES")
{
goto quizStart;
}

else if (retryQuiz == "NO")
{
    goto quizEnd;
}
else
{
    invalidInput();
    goto retryLevel2;
}

Console.Clear();
quizEnd:
Console.WriteLine("Have a nice day!");
// This is the end of the quiz.