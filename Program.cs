using System.Text.RegularExpressions;

namespace Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] palindromes = ["","e", "2002", "level", "radar", "madam", "civic", "racecar", "refer", "deified", "repaper", "reviver", "detartrated", "rotator", "redivider", "Aibohphobia", "noon", "peep", "wow", "rotor", "kayak", "tenet", "stats", "solos", "redder", "reifier", "meem", "pip", "nun", "anna", "bob", "otto", "mum", "tattarrattat", "Eva, can I see bees in a cave?", "Mr. Owl ate my metal worm.", "A man, a plan, a canal, Panama!", "Madam, in Eden, I’m Adam.", "Was it a car or a cat I saw?", "No lemon, no melon.", "Go hang a salami I’m a lasagna hog.", "Sir, I demand, I am a maid named Iris.", "Don’t nod.", "Never a foot too far, even.", "Won’t lovers revolt now?", "Do geese see God?", "Yo, Banana Boy!", "Are we not pure? “No, sir!” Panama’s moody Noriega brags. “It is garbage!” Irony dooms a man—a prisoner up to new era.", "Able was I ere I saw Elba.", "Evil is a name of a foeman, as I live.", "Rats live on no evil star.", "Red roses run no risk, sir, on Nurse’s order.", "No ‘x’ in Nixon."];

            foreach (var palindrome in palindromes)
            {
                var isPal = IsPalindrome(palindrome);
                Console.WriteLine($"{palindrome} is{(isPal ? string.Empty : """ NOT""")} a palindrome.");
            }

        }

        public static bool IsPalindrome(string input)
        {
            if (input == null)
                return false;

            Regex regex = new("[^a-zA-Z0-9]", RegexOptions.IgnoreCase);
            input = regex.Replace(input, "").ToLower();

            var inputLength = input.Length;

            var lastIndex = inputLength - 1;

            bool isPalindrome = false;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != input[lastIndex - i])
                {
                    isPalindrome = false;
                    break;
                }
                else
                    isPalindrome = true;
            }
            return isPalindrome;
        }
    }
}
