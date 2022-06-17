public class Solution {
    public bool IsPalindrome(string s) {
        int i = 0, j = s.Length -1;
        while(i < j){
            // Shift pointer down until alphanumeric.
            while(i < s.Length && !Char.IsLetterOrDigit(s[i])){
                ++i;
            }
            // Shift pointer up until alphanumeric.
            while(j >= 0 && !Char.IsLetterOrDigit(s[j])){
                --j;
            }
            // If pointers had reached eachother then search space was exhausted.
            if(i >= j){
                break;
            }
            // Assert running palindrome.
            if(Char.ToLower(s[i++]) != Char.ToLower(s[j--])){
                return false;
            }
        }
        // If search is done then it's a palindrome.
        return true;
    }
}