using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomPwdGen
{
    class Program
    {
        static void Main(string[] args)
        {
            //made several attempts to get a random password generator
            //created a list of strings and ints that could be used as password parts
            string myPwdList = "abcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            //created a spot that would be delared for my actual password
            string myActualPwd = "";
            //declared the Random() method 
            Random random = new Random();
            //used a for condition that declared an int i that would equal a number 0 and i had to be greater than or equal to 7 and i would then iterate that by one. 
            for (int i = 0; i <= 10; i++)
            {
                //created an in rand and had it generate a random.Next that would randomize 11 times against the password length minus 1
                int rand = random.Next(11, myPwdList.Length - 1);
                //the substring created from the above random my pwd would be added to it or equal to the int and the minus the 1
                myActualPwd += myPwdList.Substring(rand, 1);
            }
            Console.WriteLine( myActualPwd);
        }















        /* Still need to learn how to create a method for it
        public static string GeneratePassword()
            {
                string myPwdList = "abcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                string myActualPwd = "";
                Random random = new Random();
                for (int i = 0; i <= 7; i++)
                {
                    int rand = random.Next(5, myPwdList.Length - 1);
                    myActualPwd += myPwdList.Substring(rand, 1);
                }
                return myActualPwd;
            }
            */
        }
    }


