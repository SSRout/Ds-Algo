// URLify: Write a method to replace all spaces in a string with '%20'. You may assume that the string
// has sufficient space at the end to hold the additional characters, and that you are given the "true"
// length of the string.

using System;

namespace CTCI_6th_Edition.Arrays_and_Strings
{
    public class URLify
    {
        int Count_the_number_of_spaces(char[] input)
        {
            var spaceCount = 0;
            foreach (var character in input)
            {
                if (character == ' ')
                    spaceCount++;
            }
            return spaceCount;
        }

        private void ReplaceSpaces(char[] input, int length)
        {
            var space = new[] { '0', '2', '%' };
            var spaceCount = Count_the_number_of_spaces(input);
            // calculate new string size
            var index = length + spaceCount * 2;
            void SetCharsAndMoveIndex(params char[] chars)
            {
                foreach (var c in chars)
                    input[index--] = c;
            }
            // copying the characters backwards and inserting %20
            for (var indexSource = length - 1; indexSource >= 0; indexSource--)
                if (input[indexSource] == ' ')
                    SetCharsAndMoveIndex(space);
                else SetCharsAndMoveIndex(input[indexSource]);
        }

        public void Result()
        {
            const string input = "abc d e f";
            var characterArray = new char[input.Length + 3 * 2 + 1];

            for (var i = 0; i < input.Length; i++)
            {
                characterArray[i] = input[i];
            }

            ReplaceSpaces(characterArray, input.Length);
            Console.WriteLine("{0} -> {1}", input, new string(characterArray));
        }
    }
}