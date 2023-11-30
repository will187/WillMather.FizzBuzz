using WillMather.FizzBuzz;

FizzBuzzer fizzBuzzer = new FizzBuzzer();
for(int i =1; i < 101; i++)
{
    Console.WriteLine(fizzBuzzer.RunFizzBuzz(i));
}
Console.ReadKey();
