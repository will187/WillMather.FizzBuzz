using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WillMather.FizzBuzz;

public class FizzBuzzer
{
  public string RunFizzBuzz(int input)
  {
        string result = string.Empty;

        if(input % 3 == 0)
        {
            result = "Fizz";
        }
        if(input % 5 == 0)
        {
            result += "Buzz";
        }
        if(result == string.Empty)
        {
            result = input.ToString();
        }
        return result;
  }
}
