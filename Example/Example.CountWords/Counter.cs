using System;

namespace Example.CountWords
{
    public class Counter
    {

        public int CountWords(string input)
        {
            throw new NotImplementedException();
        }

        //1
        //public int CountWords(string input)
        //{
        //    return 0;
        //}

        //2
        //public int CountWords(string input)
        //{
        //    if (string.IsNullOrWhiteSpace(input))
        //        return 0;
        //    else
        //        return 1;
        //}

        //3
        //public int CountWords(string input)
        //{
        //    if (string.IsNullOrWhiteSpace(input))
        //        return 0;
        //    else if (input.Contains(" "))
        //        return 2;
        //    else
        //        return 1;
        //}

        //3 - Refactored
        //public int CountWords(string input)
        //{
        //    if (string.IsNullOrWhiteSpace(input))
        //        return 0;

        //    return (input.Split(' ').Length);
        //}

        //// 4
        //public int CountWords(string input)
        //{
        //    if (string.IsNullOrWhiteSpace(input))
        //        return 0;

        //    return (input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length);
        //}

    }
}
