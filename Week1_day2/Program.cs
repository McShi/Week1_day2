using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_day2
{
    class Program
    {
        static void Main(string[] args)
        {
            //What data types have we talked about so far?
            //An int is a whole number (no decimals)
            //A string is a collection of characters

            char firstInitial = 'D';
            //Characters or chars are single letters, numbers or symbols

            bool isTired = true;
            //Boolean or bool is true or False
            //Default value is true if not declared

            //Other number data types
            float number = 2.164403304907294849383961032f;
            decimal partialNum = 2.164403304907294849383961032m;
            double someNumber = 2.164403304907294849383961032;

            Console.WriteLine(number);
            Console.WriteLine(partialNum);
            Console.WriteLine(someNumber);

            //Now let's talk about operators!
            // + adds two operands
            // - subtracts second operand from the first
            // * multiplies both operands
            // / divides first operand by the second operand
            // % modulus - divides and checks remainder
            // ++  increments operator by one and is used for ints
            // -- decrements - decreases value by one

            //RELATIONAL OPERATORS
            // == checks if the vaules of two operands are equal
            // and if they are, returns bool true
            // != checks if the values of two operands are equal or not
            // and if they are NOT equal, returns bool true

            int jarrydAge = 29;
            int danielAge = 32;
            Console.WriteLine(jarrydAge == danielAge);

            /*
             *  > checks if the value of the left operand is greater than the vaule of the right operand, 
             *  and if yes then the condition is true
             *  
             *  < checks if the value of the left operand is less than the value of the right operand, 
             *  and if yes then condition is true
             *  
             *  >= checks if the value of the left operand is greater than or equal to the value of the right operand,
             *  and if yes then condition becomes true
             *  
             *  <= checks if the value of the left operand is less than or equal to the value of the right operand,
             *  and if yes then condition becomes true
             *  
             *  
        }
    }
}
