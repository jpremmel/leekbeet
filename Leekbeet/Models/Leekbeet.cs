namespace Translator
{
    public class Leekbeet
    {
        public string Translate(string input)
        {
            string[] inputArray = input.Split(' ');
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (char.ToLower(inputArray[i][0]) == 'a')
                {
                    inputArray[i] = "asparagus";
                }
            }
            
            
            
            string output = string.Join(" ", inputArray);
            return output;
        }
    }
}