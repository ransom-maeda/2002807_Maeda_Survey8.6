using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team1_Wumpus
{

    
    public class TriviaManagement
    {
        List<Trivia> TriviaQuestions = new List<Trivia>();
        int index = 0;

        public void CreateQuestions()
        {
            Trivia q1 = new Trivia("What is 1+1?", "2", "3", "4", 1);
            Trivia q2 = new Trivia("Who was the first president of the United States?", "Thomas Jefferson", "George Washington", "Bob Marley", 2);
            Trivia q3 = new Trivia("What is 30 + 12", "24", "52", "42", 3);
            Trivia q4 = new Trivia("Who is the current president of the united States", "George Bush", "Barack Obama", "Donald Trump", 3);
            Trivia q5 = new Trivia("What year was Shrek released?", "2001", "2003", "2010", 1);
            Trivia q6 = new Trivia("What is the capital of China?", "Shanghai", "Nanjing", "Beijing", 3);
            Trivia q7 = new Trivia("What is the capital of Australia?", "Sydney", "Canberra", "Melbourne", 2);
            Trivia q8 = new Trivia("What is the capital of New Zealand?", "Auckland", "Napier-Hastings", "Wellington", 3);
            Trivia q9 = new Trivia("What is the capital of Tennessee?", "Memphis", "Nashville", "Knoxville", 2);
            Trivia q10 = new Trivia("Who was the first leader of the Ottoman Empire?", "Selim I", "Mehmed Vahideddin", "Osman I", 3);
            Trivia q11 = new Trivia("What is the capital of Chad?", "Moundou", "Sarh", "N'Djamena", 3);
            Trivia q12 = new Trivia("What is the capital of Canada?", "Ottawa", "Montreal", "Toronto", 1);
            Trivia q13 = new Trivia("What is the capital of Turkey?", "Istanbul", "Ankara", "Izmir", 2);
            Trivia q14 = new Trivia("What year were the Oscars first introduced?", "1929", "1923", "1953", 1);
            Trivia q15 = new Trivia("What year was Tom & Jerry created?", "1958", "1994", "1940", 3);
            //adds questions to list
            TriviaQuestions.Add(q1);
            TriviaQuestions.Add(q2);
            TriviaQuestions.Add(q3);
            TriviaQuestions.Add(q4);
            TriviaQuestions.Add(q5);
            TriviaQuestions.Add(q6);
            TriviaQuestions.Add(q7);
            TriviaQuestions.Add(q8);
            TriviaQuestions.Add(q9);
            TriviaQuestions.Add(q10);
            TriviaQuestions.Add(q11);
            TriviaQuestions.Add(q12);
            TriviaQuestions.Add(q13);
            TriviaQuestions.Add(q14);
            TriviaQuestions.Add(q15);
        }

        public Trivia Get3Questions()
        {
            index++;
            if (index >= 3) index = 0;
            return TriviaQuestions[index];
        }

        public Trivia Get5Questions()
        {
            index++;
            if (index >= 3) index = 0;
            return TriviaQuestions[index];
        }

        
        
    }
}
