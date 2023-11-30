using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WillMather.FizzBuzz;

public class FizzBuzzer
{
  public string RunFzzBuzz(int input)
  {
        if(input % 3 == 0)
        {
            return "Fizz";
        }
        if(input % 5 == 0)
        {
            return "Buzz";
        }
        return input.ToString();
  }
}
