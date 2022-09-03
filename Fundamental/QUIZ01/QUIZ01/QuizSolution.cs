using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace QUIZ01
{
    internal class Solution
    {
        //2
        public static void SumDigit()
        {
            Console.Write("Enter number integer : ");
            int startValue = Convert.ToInt32(Console.ReadLine());
            int remainingValue = startValue;
            int sum = 0;
            while (remainingValue > 0)
            {
                int digit = remainingValue % 10;
                sum = sum + digit;
                remainingValue = remainingValue / 10;
            }
            Console.WriteLine("Total Sum : " + sum);
        }
        //3
        public static void ReverseNumber()
        {
            Console.Write("Enter number integer : ");
            int number = Convert.ToInt32(Console.ReadLine());
            int remainingValue = number;
            string ret = "";
            while (remainingValue > 0)
            {
                int digit = remainingValue % 10;
                //Console.Write(digit + " ");
                ret = ret + " " + digit;
                remainingValue = remainingValue / 10;
            }
            Console.WriteLine(ret);
        }
        //1
        public static void CountDigit()
        {
            Console.Write("Enter number integer : ");
            int number = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            int remainingValue = number;
            while (remainingValue > 0)
            {
                remainingValue = remainingValue / 10;
                count++;
            }
            Console.WriteLine("Count : " + count);

        }

        // input seconds then convert to day, hour, minute, seconds
        public static void DisplayElapseTime()
        {

        }
        //4
        public static void SecondGreatest()
        {
            int greatest = int.MinValue;
            int secondGreatest = int.MaxValue;

            Console.Write("Enter max number loop : ");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= number; i++)
            {
                if (i > greatest)
                {
                    secondGreatest = greatest;
                    greatest = i;
                }
                else
                {
                    if (i > secondGreatest)
                    {
                        secondGreatest = i;
                    }
                }
            }

            Console.WriteLine("Second Greatest : " + secondGreatest);
        }

        public static void SecondGreatest2()
        {
            int greatest = int.MinValue;
            int secondGreatest = int.MaxValue;



            // Input of ten numbers
            for (int order = 1; order <= 5; order++)
            {
                // Input
                Console.Write("Enter " + order.ToString() + ". number: ");
                string input = Console.ReadLine();
                int number = Convert.ToInt32(input);
                // Is it greater than the greatest so far?
                if (number > greatest)
                {

                    secondGreatest = greatest;

                    greatest = number;
                }
                else
                {

                    if (number > secondGreatest)
                    {
                        secondGreatest = number;
                    }
                }
            }

            Console.WriteLine("Second Greatest : " + secondGreatest);
        }


        //6
        public static void MaxNumber()
        {
            int max = int.MinValue;
            int result;
            do
            {
                Console.Write("Enter integer [ Type 0 for exit ] : ");
                var line = Console.ReadLine().Trim();
                int.TryParse(line, out result);
                if (result > max)
                {
                    max = result;
                }
            } while (result != 0);

            Console.WriteLine($"angka terbesar : {max}");
        }
        //7
        public static void FindDivisor()
        {
            Console.Write("Enter numbers : ");
            string input = Console.ReadLine();
            int.TryParse(input, out int value);

            for (int i = 1; i <= value / 2; i++)
            {
                if (value % i == 0)
                {
                    Console.Write($"{i} ");
                }
            }
        }

        //6
        public static void ShowPrimeNumberRange()
        {
            Console.Write("Enter limit number : ");
            string input = Console.ReadLine();
            int.TryParse(input, out int value);

            for (int i = 2; i < value; i++)
            {
                if (isPrime(i))
                {
                    Console.Write($"{i} ");
                }
            }
        }

        //8 prime
        static Boolean isPrime(int number)
        {
            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        //9 palindrone h
        
        public static void ShowPalindrome()
        {
            Console.Write("Enter strings : ");
            string? input = Console.ReadLine();

            bool isPalindrome = true;
            var kata = input.ToUpper().ToCharArray();

            for (int i = 0; i < kata.Length / 2; i++)
            {
                if (kata[i] != kata[kata.Length - 1 - i])
                {
                    isPalindrome = false;
                }
            }

            if (isPalindrome)
            {
                Console.WriteLine("String is palindrome");
            }
            else
            {
                Console.WriteLine("String is not palindrome");
            }

        }

        //10 Vocal consonan
        public static void CountVowel()
        {
            Console.Write("Enter strings : ");
            string? input = Console.ReadLine();

            int vowel = 0, consonant = 0;


            for (int i = 0; i < input.Length; i++)
            {
                char ch = input.ToUpper().ElementAt(i);
                if (ch == 'A' || ch == 'I' || ch == 'U' || ch == 'E' || ch == 'O')
                {
                    vowel++;
                }
                else if (ch >= 'A' && ch <= 'Z')
                {
                    consonant++;
                }
            }
            Console.WriteLine($"total vowel : {vowel}");
            Console.WriteLine($"total consonant : {consonant}");

        }

        // 11 Sum word at Paragraf
     
        public static void CountWord()
        {
            Console.Write("Enter strings : ");
            string? input = Console.ReadLine();

            int word = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsWhiteSpace(input.ElementAt(i)) || i == input.Length - 1)
                {
                    word++;
                }
            }

            Console.WriteLine($"Total Words : {word}");
        }

        //12 convert to star
        public static void ConvertMiddleToStar()
        {
            Console.Write("Enter strings : ");
            string? input = Console.ReadLine();

            int start = 0, end;
            string cutWord = "", word = "", joinCutWord = "";

            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsWhiteSpace(input.ElementAt(i)) || i == input.Length - 1)
                {
                    if (i == input.Length - 1)
                    {
                        end = i + 1;
                    }

                    else
                    {
                        end = i;
                    }


                    cutWord = input.Substring(start, end - start);
                    start = end + 1;

                    word = "";
                    char ch;
                    for (int j = 0; j < cutWord.Length; j++)
                    {
                        ch = cutWord.ElementAt(j);
                        if (j == 0 || j == cutWord.Length - 1)
                        {
                            word = word + ch;
                        }
                        else if (j > 0 && j < cutWord.Length - 1)
                        {
                            word = word + "*";
                        }
                    }
                    joinCutWord = joinCutWord + " " + word;

                }
            }
            Console.WriteLine(joinCutWord);
        }

        //13. Next Day
        public static void ILoveWeekend()
        {
            // Today's date
            DateTime today = DateTime.Today;
            // Moving day after day until hit on Friday
            DateTime date = today;
            while (date.DayOfWeek != DayOfWeek.Saturday)
            {
                date = date.AddDays(1);
            }
            // Calculating remaining days
            TimeSpan dateDifference = date - today;
            int daysRemaining = dateDifference.Days;
            // Outputs
            Console.WriteLine("Hari Sabtu: " + date.ToShortDateString());
            Console.WriteLine(daysRemaining.ToString() + " hari lagi!");
            if (daysRemaining == 0)
            {
                Console.WriteLine("Alhamdulillah!");
            }
        }

        //14 Total speech at word
        public static void CountStringInString()
        {
            Console.Write("Enter strings : ");
            string? input = Console.ReadLine();
            Console.Write("Find string: ");
            string? findStr = Console.ReadLine();



            int position = 0;
            int count = 0;
            int n = findStr.Length;
            while ((position = input.IndexOf(findStr, position)) != -1)
            {
                position = position + n;
                count++;
            }

            Console.WriteLine($"Total kata yang muncul : {count.ToString()} dari text : {input}");
        }

        //5 Guess Number
        public static void GuessNumber()
        {
            Console.WriteLine("Guess magic number between 0-20");
            Random random = new Random();
            int number = random.Next(0, 20);


            int guess;
            bool answer = true;
            do
            {
                do
                {
                printguess:
                    Console.Write("Enter you guess ? ");
                    string line = Console.ReadLine().Trim();
                    guess = Convert.ToInt32(line);

                    // cek kondisi
                    if (guess == number)
                    {
                        Console.WriteLine("Tebakan kamu benar, angka yg ditebak " + guess);
                        Console.WriteLine("Tebak lagi ?");
                        string input = Console.ReadLine();
                        if (string.Equals(input, "y"))
                        {
                            number = random.Next(0, 20);
                            goto printguess;
                        }
                        else
                        {
                            answer = false;
                            Console.WriteLine("Your quit");
                        }
                    }
                    else if (guess > number)
                    {
                        Console.WriteLine("your guess is too hight");
                    }
                    else
                    {
                        Console.WriteLine("your guess is too low");
                    }
                } while (number != guess);
            } while (answer);

        }
    }
}
