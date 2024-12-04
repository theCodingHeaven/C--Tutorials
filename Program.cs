using System.Globalization;

namespace HelloC_;

class Program
{   

    // Out entry point, dotnet will look for it
    static void Main(string[] args)
    {
        // Variables
        string username = "Alex";
        int age = 17;
        double availableFunds = 10000; // general use, more accurate precision
        float deposit = 500.50f; // less memory usage but lower precision
        char gender = 'M';
        bool isSingle = true;


        Console.WriteLine("We have a new user!");
        Console.WriteLine("Username: "  + username);
        Console.WriteLine("Current user age is:" + age + "\n" + "Available Funds: $" + availableFunds);

        //String interpolation
        Console.WriteLine($"Current user marriage status is signle: {isSingle}");

        Console.WriteLine("Adding a deposit...$" + deposit);
        //Console.WriteLine("New Balance is: $" + (deposit + availableFunds));

        Console.WriteLine("Before deposit:" + availableFunds);

        // Change our variable value (or reassign)
        //availableFunds += deposit; 
        
        // another way to write it: 
        //availableFunds = availableFunds + deposit

        Console.WriteLine("After deposit:" + availableFunds);



        /* Control Flow - If/Else statement

        double withdrawalAmount = 7500;

        // We have <, >, <=, >=, == comparison operators
        if(withdrawalAmount >= availableFunds){ 

            Console.WriteLine("Not enough funds!");
        }

        else if(withdrawalAmount == availableFunds){

            availableFunds -= withdrawalAmount; 
            Console.WriteLine("Withdrawing all available funds. Current balance is" + availableFunds);
        }
        else{
            availableFunds = availableFunds - withdrawalAmount; 
            Console.WriteLine("Success! Your current balance is:" + availableFunds);
        }
   


        // Logican operators: AND, OR, NOT, XOR
        
        // age > 18, funds > 2000 or deposit is 4000 or more
        if(age >= 18 && (availableFunds > 2000 || deposit >= 4000)){
            Console.WriteLine("Eligible for loan!");
        }
        else if (age < 18 && availableFunds > 10000 && !isSingle){
            Console.WriteLine("Eligible for loan!");
        }
        else if(isSingle ^ (availableFunds == 10000)){
            Console.WriteLine("Eligible for loan! Based on single offer!");
        }
        else{
            Console.WriteLine("Not eligible for loan.");
        }


        //Switch statements

        int option = 2;

        switch(option){

                case 1:
                 Console.WriteLine("Option selected: deposit");
                 break;
                case 2:
                 Console.WriteLine("Option selected: withdraw");
                 break;
                case 3:
                 Console.WriteLine("Option selected: display balance");
                 break;
                default:
                 Console.WriteLine("Invalid option!");
                 break;

        }
     */
            //  LOOPS: DO WHILE, WHILE, FOR 
            //Manage interest payment

            int loan = 0;
            int monthlyPayment = 500; 

            int totalPaymentsNumber = loan/monthlyPayment;

            /*Do while execute AT LEAST ONCE*/
            /*
            do{
                loan -= monthlyPayment;
                if(loan < 0){
                    Console.WriteLine($"Congradilations! You paid it off!");
                    break;
                }

                Console.WriteLine("Remaining Balance: " + loan);
                totalPaymentsNumber -= 1;
                Console.WriteLine("Payments Left: " + totalPaymentsNumber);

            }
            while(loan > 0); */


            /*WHILE will execute only if condition met*/
            
            while(loan > 0){

                loan -= monthlyPayment;
                Console.WriteLine("Remaining Balance: " + loan);
                totalPaymentsNumber -= 1;
                Console.WriteLine("Payments Left: " + totalPaymentsNumber);
            }


            /*FOR LOOP, perfect for iteration where you know how many times you need to repeat it*/

            double initialDeposit = 3200;
            double interestRate = 4.65 / 12/ 100; // get interest per month
            int monthNumber = 6;

            for(int i = 0; i < monthNumber; i++){
                initialDeposit += initialDeposit * interestRate;
                Console.WriteLine($"Current balance ${initialDeposit.ToString("F2")}"); // format output
            }

    }




}
