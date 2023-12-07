// See https://aka.ms/new-console-template for more information


for(int k  = 1; k <=5; k++)
{
    Console.WriteLine($"Enter number {k} ");
    int numb = int.Parse(Console.ReadLine());
}

for(int j =1 ;j <=5;j++)
{
    Console.WriteLine($"Enter student {j}");
    string name = Console.ReadLine();

    Console.WriteLine($"Enter {name} score");
    int score = int.Parse(Console.ReadLine());
}
  Console.WriteLine("Enter any number of  your choice");
    int num = int.Parse(Console.ReadLine());
 //Using for loop   
 for( int l = 1; l<=12; l++)
 {
    Console.WriteLine($"{num} * {l} = {num*l}");
  }

  //For while loop
   int i =1; 
  while(i <= 12)
  {
    Console.WriteLine($"{num} * {i} = {num*i}");
    i++;
  }
  //Example
 bool a =true;
 while(a)
 {
 Console.WriteLine("Enter first number");
 int num1 =int.Parse(Console.ReadLine());
 Console.WriteLine("Enter second number");
 int num2 =int.Parse(Console.ReadLine());
 Console.WriteLine($"what is {num1} + {num2}");
 int sum =int.Parse(Console.ReadLine());
 if(sum == (num1 + num2))
 {
    Console.WriteLine("You are correct");
 }
else 
{
   Console.WriteLine("You are wrong");
}
Console.WriteLine("Do you want to play again ? yes or no");
string opt= Console.ReadLine();

if (opt == "yes")
{
    a = true;
}
else
{
   a= false;
   Console.WriteLine("Thank you");
}
}


bool d = true;
while (d)
{
                        Console.WriteLine(@" Enter + for addition
                                             Enter * for multiplication
                                             Enter / for division
                                             Enter - for subtraction ");
                        char arith = char.Parse(Console.ReadLine());
                       switch(arith)
                        {
                           case '+' :
                           Console.WriteLine("Enter your first value");
                           int value = int.Parse(Console.ReadLine());
 
                           Console.WriteLine("Enter your second value");
                           int value1 = int.Parse(Console.ReadLine());
                           
                           int sum = value + value1;
                           Console.WriteLine($"Your answer is {sum}");
                           break;

                           case '-' :
                           Console.WriteLine("Enter your first value");
                           int value2 = int.Parse(Console.ReadLine());

                           Console.WriteLine("Enter your second value");
                           int value3 = int.Parse(Console.ReadLine());
                           
                           int minus = value2 - value3;
                           Console.WriteLine($"Your answer is {minus}");
                           break;

                           case '*':
                           Console.WriteLine("Enter your first value");
                           int value4 = int.Parse(Console.ReadLine());

                           Console.WriteLine("Enter your second value");
                           int value5 = int.Parse(Console.ReadLine());
                           
                           int mul = value4 * value5;
                           Console.WriteLine($"Your answer is {mul}");
                           break;

                           case '/' :
                           Console.WriteLine("Enter your first value");
                           int value6 = int.Parse(Console.ReadLine());

                           Console.WriteLine("Enter your second value");
                           int value7 = int.Parse(Console.ReadLine());
                           
                           int div = value6 + value7;
                           Console.WriteLine($"Your answer is {div}");
                           break;

                           default :
                           Console.WriteLine("The operator you entered is invalid");
                           break;
                        }
                     Console.WriteLine("Do you still want to make use of the simple calculator? yes or no");
                     string reply = Console.ReadLine();
                     if (reply.ToLower() == "yes")
                     {
                        a = true;
                     }
                     else
                      {
                        a = false;
                        Console.WriteLine("Thank you");
                     }

         }



    int m = 0;
    while(m <=100)
    {
      if (m % 2 == 0)
      {
         Console.Write(m + ", ");
      }  
      else 
      {
         
         Console.Write(i *-1 + ", ");
      }
        i++;
    }

   double accountBalance = 5000.00;
   bool acc = true;
   while(acc)
   {
      Console.WriteLine("How much do you want to withdraw from your account ?");
      double withdrawal = double.Parse(Console.ReadLine());

      if(withdrawal > accountBalance)
      {
         
      Console.WriteLine("Insufficient funds, kindly check your account balance");
        break;
      }
      
      else
      {
         Console.WriteLine("Withdrawal in progress ....");
         
      }
       
       accountBalance =accountBalance - withdrawal;
       Console.WriteLine("Your balance is : " + accountBalance);
      
       Console.WriteLine("Do you want to withdraw again? Enter yes or no" );
       string answer = Console.ReadLine();
       
       if(answer.ToLower() == "yes")
       {
         acc = true;
      
       }
       
       else 
       {
          acc =false;
          Console.WriteLine(" Thank you for banking with us");
       }
   }
   


