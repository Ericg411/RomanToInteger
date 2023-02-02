namespace RomanToInteger;
public class RomanToInteger
{
    public int RomanToInt(string s)
    {

        int answer = 0;

        for (int i = 0; i <= s.Length - 1; i++)
        {
            switch (s[i])
            {
                case 'M':
                    answer += 1000;
                    break;
                case 'D':
                    answer += 500;
                    break;
                case 'C':
                    if (i < s.Length - 1 && s[i + 1] == 'M')
                    {
                        answer += 900;
                        i++;
                        break;
                    }
                    else if (i < s.Length - 1 && s[i + 1] == 'D')
                    {
                        answer += 400;
                        i++;
                        break;
                    }
                    else
                    {
                        answer += 100;
                        break;
                    }
                case 'L':
                    answer += 50;
                    break;
                case 'X':
                    if (i < s.Length - 1 && s[i + 1] == 'C')
                    {
                        answer += 90;
                        i++;
                        break;
                    }
                    else if (i < s.Length - 1 && s[i + 1] == 'L')
                    {
                        answer += 40;
                        i++;
                        break;
                    }
                    else
                    {
                        answer += 10;
                    }
                    break;
                case 'V':
                    answer += 5;
                    break;
                case 'I':
                    if (i < s.Length - 1 && s[i + 1] == 'X')
                    {
                        answer += 9;
                        i++;
                        break;
                    }
                    else if (i < s.Length - 1 && s[i + 1] == 'V')
                    {
                        answer += 4;
                        i++;
                        break;
                    }
                    else
                    {
                        answer += 1;
                    }
                    break;
                default:
                    break;
            }
        }

        return answer;
    }
}
