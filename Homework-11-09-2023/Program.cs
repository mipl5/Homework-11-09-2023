using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
// Answers to homework in computer science - 11.09.2023:
namespace Homework_11_09_2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Answer to the first question:
            Console.WriteLine("Please enter the number of times the student impressed the teachers:");
            int impressions_number = int.Parse(Console.ReadLine());
            if (impressions_number > 5)
            {
                Console.WriteLine("Inviting parents to the school.");
            }
            else if (impressions_number < 0)
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Warning.");
            }
            // Answer to the second question:
            int retirement_age = 65;
            Console.WriteLine("Please enter the user's age here:");
            int age = int.Parse(Console.ReadLine());
            if (age >= 0)
            {
                if (age >= retirement_age)
                {
                    Console.WriteLine("The user is retired.");
                }
                else
                {
                    Console.WriteLine("The user is not yet retired.");
                    int the_number_of_years_until_retirement = (65 - age);
                    Console.WriteLine("The number of years left until retirement is: {0}",the_number_of_years_until_retirement);
                }
            }
            else
            {
                Console.WriteLine("Something went wrong.");
            }
            // Answer to the third question:
            Console.WriteLine("Please enter here the balance in the user's bank account in U.S.D.:");
            double users_bank_balance_usd = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter here the amount of money the user wants to withdraw from his bank account:");
            double the_amount_of_money_the_user_wants_to_withdraw = double.Parse(Console.ReadLine());
            double users_new_balance = (users_bank_balance_usd - the_amount_of_money_the_user_wants_to_withdraw);
            Console.WriteLine("The user's new balance is: {0}",users_new_balance+"$");
            // Answer to the fourth question:
            Console.WriteLine("Please enter here the number of the row you would like to sit in:");
            int line_number = int.Parse(Console.ReadLine());
            int price_nis;
            int hagais_ticket_price;
            Console.WriteLine("Please enter the number of Hagai's friends here:");
            int number_of_hagis_friends = int.Parse(Console.ReadLine());
            if (line_number <= 10)
            {
                price_nis = 60;
                hagais_ticket_price = price_nis;
                int the_total_amount_of_money_hagi_has_to_pay = hagais_ticket_price + (price_nis * number_of_hagis_friends);
                Console.WriteLine("The total amount of money Hagi has to pay in NIS is {0}", the_total_amount_of_money_hagi_has_to_pay);
            }
            else
            {
                price_nis = 40;
                hagais_ticket_price = price_nis;
                int the_total_amount_of_money_hagi_has_to_pay = hagais_ticket_price + (price_nis * number_of_hagis_friends);
                Console.WriteLine("The total amount of money Hagi has to pay in N.I.S. is {0}", the_total_amount_of_money_hagi_has_to_pay);
            }
            // Answer to the fifth question:
            double number = double.Parse(Console.ReadLine());
            if (number == 0)
            {
                double absolute_value_of_the_number = number;
                Console.WriteLine("|{0}|", number + "=" + absolute_value_of_the_number);
            }
            else if (number < 0)
            {
                double absolute_value_of_the_number = - number;
                Console.Write("|{0}|=", number);
                Console.Write(absolute_value_of_the_number);
            }
            else
            {
                double absolute_value_of_the_number = number;
                Console.WriteLine("|{0}|={absolute_value_of_the_number}", number,absolute_value_of_the_number);
            }
            // Answer to the sixth question:
            Console.WriteLine("Please enter here the number of calls that the user made:");
            int number_of_calls = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the price of the call in N.I.S. here:");
            float call_price_nis = float.Parse(Console.ReadLine());
            float amount_of_money_to_be_paid_nis = call_price_nis * number_of_calls;
            if (amount_of_money_to_be_paid_nis > 500)
            {
                Console.WriteLine("The user is chatty.");
            }
            if (amount_of_money_to_be_paid_nis >= 0 && amount_of_money_to_be_paid_nis < 150)
            {
                Console.WriteLine("The user is thrifty.");
            }
            else
            {
                Console.WriteLine("The amount of money to be paid is reasonable.");
            }
            // Answer to the seventh question:
            Console.WriteLine("Please enter the first number here:");
            double first_number = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second number here:");
            double second_number = double.Parse(Console.ReadLine());
            if (first_number > second_number)
            {
                Console.WriteLine(first_number);
            }
            else if  (second_number > first_number)
            {
                Console.WriteLine(second_number);
            }
            else
            {
                Console.WriteLine("The two numbers are equal to each other.");
            }
            // Answer to the eighth question:
            Console.WriteLine("Please enter the number here:");
            double number_sv = double.Parse(Console.ReadLine());
            if (number_sv > 0)
            {
                Console.WriteLine("The number is positive.");
            }
            else if (number_sv < 0)
            {
                Console.WriteLine("The number is negative.");
            }
            else
            {
                Console.WriteLine("The number is neutral, i.e. 0.");
            }
            // Answer to the ninth question:
            Console.WriteLine("Please enter here the value for variable:");
            double A = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter here the value for variable:");
            double B = double.Parse(Console.ReadLine());
            if (A < B)
            {
                Console.WriteLine(A + "," + B);
            }
            else if (A > B)
            {
                double A_sv = A;
                A = B;
                B = A_sv;
                Console.WriteLine(A + "," + B);
            }
            else
            {
                Console.WriteLine("Both numbers are equal to each other, they cannot be displayed in ascending series.");
            }
            // Answer to the tenth question:
            Console.WriteLine("Please enter the user's electricity use here in K.W.H.:");
            float electricity_use_kwh = float.Parse(Console.ReadLine());
            if (electricity_use_kwh < 0)
            {
                Environment.Exit(0);
            }
            float price_per_kilowatt_hour;
            if (electricity_use_kwh >= 0 && electricity_use_kwh < 20)
            {
                price_per_kilowatt_hour = 10;
                float amount_of_money_to_be_paid = price_per_kilowatt_hour * electricity_use_kwh;
                float amount_of_money_to_be_paid_with_tax = (amount_of_money_to_be_paid * 1.16f);
                if (amount_of_money_to_be_paid_with_tax >= 100)
                {
                    Console.WriteLine("The amount of money to be paid with the tax is: {0}", amount_of_money_to_be_paid_with_tax);
                }
                else
                {
                    Console.WriteLine("The amount of money to be paid with the tax is: {0}", 100);
                }
            }
            else if (electricity_use_kwh >= 20)
            {
                price_per_kilowatt_hour = 15;
                float amount_of_money_to_be_paid = price_per_kilowatt_hour * electricity_use_kwh;
                float amount_of_money_to_be_paid_with_tax = (amount_of_money_to_be_paid * 1.16f);
                if (amount_of_money_to_be_paid_with_tax >= 100)
                {
                    Console.WriteLine("The amount of money to be paid with the tax is: {0}", amount_of_money_to_be_paid_with_tax);
                }
                else
                {
                    Console.WriteLine("The amount of money to be paid with the tax is: {0}", 100);
                }
            }
            else
            {
                Console.WriteLine("Something went wrong.");
            }
            // Answer to the eleventh question:
            Console.WriteLine("Please enter the first number here:");
            double first_number_sv = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second number here:");
            double second_number_sv = double.Parse(Console.ReadLine());
            if (first_number < 0 && second_number < 0)
            {
                Console.WriteLine("Both numbers are negative numbers.");
            }
            else
            {
                Console.WriteLine("Not all numbers are negative numbers.");
            }
            // Answer to the twelfth question:
            Console.WriteLine("Please enter the first number here:");
            double first_number_tv = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second number here:");
            double second_number_tv = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the third number here:");
            double third_number = double.Parse(Console.ReadLine());
            if (first_number_tv > second_number_tv && first_number_tv > third_number)
            {
                Console.WriteLine(first_number_tv);
            }
            else if (second_number_tv > first_number_tv && second_number_tv > third_number)
            {
                Console.WriteLine(second_number_tv);
            }
            else if (third_number > first_number_tv && third_number > second_number_tv)
            {
                Console.WriteLine(third_number);
            }
            else
            {
                Console.WriteLine("There is no output.");
            }
            // Answer to the thirteenth question:
            Console.WriteLine("Please enter the first number here:");
            double first_number_fv = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second number here:");
            double second_number_fv = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the third number here:");
            double third_number_sv = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the fourth number here:");
            double fourth_number = double.Parse(Console.ReadLine());
            if (first_number_fv > second_number_fv && first_number_fv > third_number_sv && first_number_fv > fourth_number)
            {
                Console.WriteLine(first_number_fv);
            }
            else if (second_number_fv > first_number_fv && second_number_fv > third_number_sv && second_number_fv > fourth_number)
            {
                Console.WriteLine(second_number_fv);
            }
            else if (third_number_sv > first_number_fv && third_number_sv > second_number_sv && third_number_sv > fourth_number)
            {
                Console.WriteLine(third_number_sv);
            }
            else if (fourth_number > first_number_fv && fourth_number > second_number_sv && fourth_number > third_number_sv)
            {
                Console.WriteLine(third_number_sv);
            }
            else
            {
                Console.WriteLine("There is no output.");
            }
            // Answer to the fifteenth question:
            Console.WriteLine("Please enter a natural number here:");
            int natural_number = int.Parse(Console.ReadLine());
            if (natural_number > 0)
            {
                if (natural_number % 2 == 0)
                {
                    Console.WriteLine("The number is even.");
                }
                else
                {
                    Console.WriteLine("The number isn't even.");
                }
            }
            else
            {
                Console.WriteLine("There is something wrong.");
            }
            // Answer to the sixteenth question:
            int tamar_savings_nis = 500;
            Console.WriteLine("Please enter the price of the scarf here:");
            int scarf_price_nis = int.Parse(Console.ReadLine());
            int the_number_of_scarves_that_can_be_bought = tamar_savings_nis / scarf_price_nis;
            Console.WriteLine("The number of scarves that can be bought in the store is:{0}", the_number_of_scarves_that_can_be_bought);
            float excess = tamar_savings_nis % scarf_price_nis;
            if (excess >= 7)
            {
                Console.WriteLine("You can also buy a poster that costs NIS 7.");
            }
            else
            {
                Console.WriteLine("You can't also buy a poster that costs NIS 7.");
            }
            // Answer to the seventeenth question:
            Console.WriteLine("Please enter a natural number here:");
            int natural_number_sv = int.Parse(Console.ReadLine());
            if (natural_number_sv >= 10 && natural_number_sv <= 99)
            {
                string natural_number_sv_str = Convert.ToString(natural_number_sv);
                if (natural_number_sv_str.Contains('5'))
                {
                    Console.WriteLine("That number has the digit 5.");
                }
                if (natural_number_sv % 5 == 0)
                {
                    Console.WriteLine('The number is divisible by 5.');
                }
                if (natural_number_sv_str.Contains('5') && (natural_number_sv % 5 == 0))
                {
                    Console.WriteLine("That number has the digit 5 and is divisible by 5.");
                }
                else
                {
                    Console.WriteLine("sorry.");
                }
            }
        }
    }
}
