namespace ExtensionMethods
{
    public static class AppExtensions
    {
        public static int WordCount(this string str) 
            => str.Split(new char[] { ' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;

        //---------------------------------

        //Extend Predefined Types
        public static void Increment(this int number)
            => number++;

        // Take note of the extra ref keyword here
        public static void RefIncrement(this ref int number)
            => number++;

    }
}

