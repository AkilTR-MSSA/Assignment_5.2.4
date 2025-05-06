Console.Write("Input a string: ");
string input = Console.ReadLine();
Console.WriteLine(IsPalindrome_Recursive(input, 0 , input.Length - 1));

bool IsPalindrome_Recursive(string s, int left, int right) {
    if (left >= right)
    {
        return true;
    }
    if (s[left] != s[right])
    {
        return false;
    }
    return IsPalindrome_Recursive(s, left + 1, right - 1);
}