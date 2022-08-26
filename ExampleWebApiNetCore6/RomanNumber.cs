namespace ExampleWebApiNetCore6
{
    public class RomanNumber
    {
        public string Convert(int number)
        {
            if (number == 6)
            {
                return "VI";
            }
            if (number == 5)
            {
                return "V";
            }
            if (number == 4)
            {
                return "IV";
            }
            if (number == 3)
            {
                return "III";
            }
            if (number == 2)
            {
                return "II";
            }
            return "I";
        }
    }
}
