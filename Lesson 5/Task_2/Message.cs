using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Task_2
{
    public static class Message
    {
        public static string GetWords(string text, int lenght)
        {
            Regex.Replace(text, @"[-.?!)(,:;]", "");
            string[] wordArr = text.Split(' ');
            string[] result = new string[wordArr.Length];
            int count = 0;
            for (int i = 0; i < wordArr.Length; i++)
            {
                if (wordArr[i].Length <= lenght)
                {
                    result[count] = wordArr[i];
                    count++;
                }
            }
            Array.Resize(ref result, ++count);
            text = "";
            foreach (var r in result)
            {
                text += $"{r} ";
            }
            return text;
        }
        public static string DeleteWords(string text, char symbol)
        {
            string[] wordArr = text.Split(' ');
            string[] result = new string[wordArr.Length];
            int count = 0;
            for (int i = 0; i < wordArr.Length; i++)
            {
                if (wordArr[i][char.IsPunctuation(wordArr[i][wordArr[i].Length - 1]) ? wordArr[i].Length - 2 : wordArr[i].Length - 1] != symbol)
                {
                    result[count] = wordArr[i];
                    count++;
                }
            }
            Array.Resize(ref result, ++count);
            text = "";
            foreach (var r in result)
            {
                text += $"{r} ";
            }
            return text;
        }
        public static string MaxLengthWords(string text)
        {
            Regex.Replace(text, @"[-.?!)(,:;]", "");
            string[] wordArr = text.Split(' ');
            int maxLength = 0;
            string maxLengthWord = "";
            foreach (var word in wordArr)
            {
                if (word.Length > maxLength)
                {
                    maxLength = word.Length;
                    maxLengthWord = word;
                }
            }
            return maxLengthWord;
        }
        public static string MaxLengthWordText(string text)
        {
            Regex.Replace(text, @"[-.?!)(,:;]", "");
            string[] wordArr = text.Split(' ');
            int maxLength = 0;
            StringBuilder sb = new StringBuilder();
            foreach (var word in wordArr)
            {
                if (word.Length > maxLength)
                {
                    maxLength = word.Length;
                    sb.Clear();
                    sb.Append($"{word} ");
                }
                else if (word.Length == maxLength)
                {
                    sb.Append($"{word} ");
                }

            }
            return sb.ToString();
        }
        public static Dictionary<string, int> CounterWords(string[] words, string text)
        {
            Dictionary<string, int> countWords = new Dictionary<string, int>();
            foreach (var word in words)
            {
                int index = 0, count = 0;
                countWords.Add(word, count);
                do
                {
                    if (index == 0)
                    {
                        index = text.IndexOf(" " + word);
                    }
                    else if (index > 0)
                    {
                        countWords[word] = ++count;
                        index = text.IndexOf(" " + word, index + 1);
                    }
                } while (index != -1);
            }
            return countWords;
        }
    }
}
