using System;

namespace Translator
{
    public class Leekbeet
    {
        public string Translate(string input)
        {
            string[] exceptions = { "and", "the", "a", "I", "but", "also", "in", "of", "for", "to", "with", "are", "I'm", "you", "your", "this", "there", "they're", "their", "am", "if", "is", "was", "my", "at", "that's", "from", "like", "since", "until", "our"};
            string[] inputArray = input.Split(' ');

            for (int i = 0; i < inputArray.Length; i++)
            {
                bool punctuation = false;
                string lastChar = "";
                if (inputArray[i].EndsWith(".") || inputArray[i].EndsWith(",") || inputArray[i].EndsWith("?") || inputArray[i].EndsWith("!"))
                {
                    lastChar = inputArray[i][inputArray[i].Length - 1].ToString();
                    Console.WriteLine(lastChar);
                    punctuation = true;
                    inputArray[i] = inputArray[i].Remove(inputArray[i].Length - 1);
                }


                int pos = Array.IndexOf(exceptions, inputArray[i]);
                if (pos < 0)
                {
                    if (char.ToLower(inputArray[i][0]) == 'a')
                    {
                        inputArray[i] = "asparagus";
                    }
                    else if (char.ToLower(inputArray[i][0]) == 'b')
                    {
                        inputArray[i] = "beet";
                    }
                    else if (char.ToLower(inputArray[i][0]) == 'c')
                    {
                        inputArray[i] = "carrot";
                    }
                    else if (char.ToLower(inputArray[i][0]) == 'd')
                    {
                        inputArray[i] = "dill";
                    }
                    else if (char.ToLower(inputArray[i][0]) == 'e')
                    {
                        inputArray[i] = "eggplant";
                    }
                    else if (char.ToLower(inputArray[i][0]) == 'f')
                    {
                        inputArray[i] = "fennel";
                    }
                    else if (char.ToLower(inputArray[i][0]) == 'g')
                    {
                        inputArray[i] = "garlic";
                    }
                    else if (char.ToLower(inputArray[i][0]) == 'h')
                    {
                        inputArray[i] = "horseradish";
                    }
                    // else if (char.ToLower(inputArray[i][0]) == 'i')
                    // {
                    //     inputArray[i] = "iceberg lettuce";
                    // }
                    else if (char.ToLower(inputArray[i][0]) == 'j')
                    {
                        inputArray[i] = "jicama";
                    }
                    else if (char.ToLower(inputArray[i][0]) == 'k')
                    {
                        inputArray[i] = "kale";
                    }
                    else if (char.ToLower(inputArray[i][0]) == 'l')
                    {
                        inputArray[i] = "leek";
                    }
                    else if (char.ToLower(inputArray[i][0]) == 'm')
                    {
                        inputArray[i] = "mint";
                    }
                    else if (char.ToLower(inputArray[i][0]) == 'n')
                    {
                        inputArray[i] = "nutmeg";
                    }
                    else if (char.ToLower(inputArray[i][0]) == 'o')
                    {
                        inputArray[i] = "onion";
                    }
                    else if (char.ToLower(inputArray[i][0]) == 'p')
                    {
                        inputArray[i] = "potato";
                    }
                    else if (char.ToLower(inputArray[i][0]) == 'q')
                    {
                        inputArray[i] = "quinoa";
                    }
                    else if (char.ToLower(inputArray[i][0]) == 'r')
                    {
                        inputArray[i] = "radish";
                    }
                    else if (char.ToLower(inputArray[i][0]) == 's')
                    {
                        inputArray[i] = "squash";
                    }
                    else if (char.ToLower(inputArray[i][0]) == 't')
                    {
                        inputArray[i] = "turnip";
                    }
                    else if (char.ToLower(inputArray[i][0]) == 'u')
                    {
                        inputArray[i] = "unagi";
                    }
                    else if (char.ToLower(inputArray[i][0]) == 'v')
                    {
                        inputArray[i] = "vanilla";
                    }
                    else if (char.ToLower(inputArray[i][0]) == 'w')
                    {
                        inputArray[i] = "watercress";
                    }
                    else if (char.ToLower(inputArray[i][0]) == 'x')
                    {
                        inputArray[i] = "xigua";
                    }
                    else if (char.ToLower(inputArray[i][0]) == 'y')
                    {
                        inputArray[i] = "yam";
                    }
                    else if (char.ToLower(inputArray[i][0]) == 'z')
                    {
                        inputArray[i] = "zucchini";
                    }
                }

                if (punctuation)
                {
                    inputArray[i] += lastChar;
                }

            }
            string output = string.Join(" ", inputArray);
            return output;
        }
    }
}