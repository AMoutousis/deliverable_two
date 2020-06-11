using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Deliverable_Two
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;

            int numTransition = 64;
            int index;
            int checksum = 0;


            Console.WriteLine("Hello! Please write a message.");

            input = Console.ReadLine();
            string uppercaseInput = input.ToUpper();

            //must declare int array after input, otherwise will error
            int[] message = new int[uppercaseInput.Length];

            //take uppercase string and convert it to ascii unicode using built in encoding library
            byte[] asciiBytes = Encoding.ASCII.GetBytes(uppercaseInput);

            //for the length of the uppercase string, add all array values together
            foreach(byte b in asciiBytes)
            {
                checksum += b;
            }

            //loop through user input, assign each letter to a char then convert the char into the numerical value of its place in the alphabet
            for (int i = 0; i < uppercaseInput.Length; i++)
            {
                char c = uppercaseInput[i];

                //convert individual letter to numerical place in alphabet
                index = char.ToUpper(c) - numTransition;

                message[i] = index;
            }

            //return the original message
            //DELETE BEFORE SUBMISSION
            Console.WriteLine("Your message is " + uppercaseInput);
            //return the unicode value
            Console.WriteLine("Message checksum is " + checksum);
            //return the encoded value
            Console.WriteLine("Your encoded message is " + string.Join("-", message));
        
        
        }
    }
}
