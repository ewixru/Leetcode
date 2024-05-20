namespace Leetcode;

public class FizzBuzzAnswers
{
    public IList<string> FizzBuzz(int n)
    {
        IList<string> answers = new List<string>();
        for (int i = 1; i <= n; i++)
        {
            string answer = "";
            if (i % 3 == 0) answer += "Fizz";
            if (i % 5 == 0) answer += "Buzz";
            if (answer.Length == 0) answer += i;
            answers.Add(answer);
        }
        return answers;
    }
}
