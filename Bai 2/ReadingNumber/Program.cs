class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");
        int number = 0;

        while (true)
        {
            string input = Console.ReadLine();
            if (int.TryParse(input, out number) && number >= 0 && number <= 999)
                break;
            else
                Console.WriteLine("Vui lòng nhập một số nguyên không âm có tối đa 3 chữ số.");
        }

        string result = ConvertNumberToWords(number);
        Console.WriteLine(result);
    }

    static string ConvertNumberToWords(int number)
    {
        if (number == 0)
            return "zero";

        string[] units = { "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        string[] teens = { "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
        string[] tens = { "", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

        string words = "";

        int hundreds = number / 100;
        int remainder = number % 100;
        int tensDigit = remainder / 10;
        int unitsDigit = remainder % 10;

        switch (hundreds)
        {
            case 1:
                words += "one hundred";
                break;
            case 2:
                words += "two hundred";
                break;
            case 3:
                words += "three hundred";
                break;
            case 4:
                words += "four hundred";
                break;
            case 5:
                words += "five hundred";
                break;
            case 6:
                words += "six hundred";
                break;
            case 7:
                words += "seven hundred";
                break;
            case 8:
                words += "eight hundred";
                break;
            case 9:
                words += "nine hundred";
                break;
        }

        if (remainder > 0)
        {
            if (hundreds > 0)
                words += " and ";

            if (remainder >= 11 && remainder <= 19)
            {
                words += teens[remainder - 11];
            }
            else
            {
                switch (tensDigit)
                {
                    case 1:
                        words += tens[tensDigit];
                        break;
                    case 2:
                        words += "twenty";
                        break;
                    case 3:
                        words += "thirty";
                        break;
                    case 4:
                        words += "forty";
                        break;
                    case 5:
                        words += "fifty";
                        break;
                    case 6:
                        words += "sixty";
                        break;
                    case 7:
                        words += "seventy";
                        break;
                    case 8:
                        words += "eighty";
                        break;
                    case 9:
                        words += "ninety";
                        break;
                }

                if (unitsDigit > 0)
                    words += (tensDigit > 0 ? " " : "") + units[unitsDigit];
            }
        }

        return words;
    }
}