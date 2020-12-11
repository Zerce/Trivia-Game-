//Trivia Game by Rigo Cervantes
//Assistance from Owen Duffy, Kharissma Thompsom
//Intro to Programming 10/12/20
using System;
using System.Collections.Generic;
using System.Text;
namespace Trivia
{
    class Game
    {
        string gameName = "Trivia Game by Rigoberto Cervantes";
        Player player;

        public Game()
        {
            Console.Title = gameName;
            Console.WriteLine("Welcome to " + gameName);

            Console.WriteLine("When asked a question, please type in your answer and then press Enter on your keyboard");
            Play();

        }

        private void Play()

        {
            player = new Player();
            Console.WriteLine("Please enter your name");

            //string playerName = Console.ReadLine();
            player.name = Console.ReadLine();
            Console.WriteLine("Welcome " + player.name);
            int score = 0;
            string input = " ";

            //add statements here for game
            //Creates item1 and gives question and answer
            TriviaItem item1 = new TriviaItem();
            item1.setAnswers();
            item1.setQuestions();

            for (int i = 0; i < 10; i++)
            {

                Console.WriteLine(item1.getQuestion(i));

                input = Console.ReadLine();
                input = input.ToUpper(); //makes input all caps so that caps don't matter for correct answer

                Console.WriteLine("The correct answer was " + item1.getAnswer(i));

                if (input == item1.getAnswer(i)) //Checks to see if answer is correct
                {
                    score = score + 1; //Adds +1 to score if answer was correct
                    Console.WriteLine("Congralations, you're answer was correct");
                }
                else
                {
                    Console.WriteLine("Sorry, you're answer was incorrect");
                }

                Console.WriteLine("Current score: " + score + "/10"); //Displays current score

                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();



            }

            //End of Quiz
            Console.WriteLine("End of quiz, " + player.name);
            Console.WriteLine("You're score: " + score + "/10");
            if (score == 10) //Checks to see if you got a perfect score
            {
                Console.WriteLine("Congratulations, " + player.name + "! You got a perfect score");
            }
            if (score == 0) //Checks to see if you got no answers
            {
                Console.WriteLine("You didn't get any of 'em! Try harder next time, bub.");
            }
            Console.ReadKey();
        }
    }
}



