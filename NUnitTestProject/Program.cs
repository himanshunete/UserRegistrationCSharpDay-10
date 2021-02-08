using System;
using System.Text.RegularExpressions;

namespace TestRegex
{
    public class Program
    {
        /// <summary>
        /// Patterns
        /// </summary>
        string firstNamePattern = "^[A-Z]{1}[a-z]{2,}$";
        string lastNamePattern = "^[A-Z]{1}[a-z]{2,}$";
        string emailPattern = "^[0-9a-zA-Z]+([._+-]?[0-9a-zA-Z]+)*@[0-9A-Za-z]+.([c]{1}[o]{1}[m]{1})*([n]{1}[e]{1}[t]{1})*[,]*([.][a]{1}[u]{1})*([.][c]{1}[o]{1}[m]{1})*$";
        string mobileNumberPattern = "^[9]{1}[1]{1}[ ][0-9]{10}$";
        string passwordRule4Pattern = "^[A-Z]{1}[a-zA-Z]{7,}([0-9]+)[@#$%^&*+-_]{1}$";

        /// <summary>
        /// Pre-Defined Inputs
        /// </summary>
        string[] patternFirstName = { "Himanshu", "vineet" };
        string[] patternLastName = { "Nete", "Kadwe" };
        string[] patternEmail = { "himnshuneteh@gmil.com", "vineetkdwe@gmil.com" };
        string[] patternMobileNumber = { "91 8803829504", "7378138447" };
        string[] patternPasswordRule4 = { "Himanshunete18$", "Vineetkdwe9##" };
        string[] patternSampleEmail = {"abc@yahoo.com"
                                            , "abc-100@yahoo.com,"
                                            , "abc.100@yahoo.com"
                                            , "abc111@abc.com,"
                                            , "abc-100@abc.net,"
                                            , "abc.100@abc.com.au"
                                            , "abc@1.com,"
                                            , "abc@gmail.com.com"
                                            , "abc+100@gmail.com"
                                            , "abc"
                                            , "abc@.com.my"
                                            , "abc123@gmail.a"
                                            , "abc123@.com"
                                            , "abc@.com.com"
                                            , ".abc@abc.com"
                                            , "abc()*@gmail.com"
                                            , "abc@%*.com"
                                            , "abc..2002@gmail.com"
                                            , "abc.@gmail.com"
                                            , "abc@abc@gmail.com"
                                            , "abc@gmail.com.1a"
                                            , "abc@gmail.com.aa.au"};
        
        /// <summary>
        /// Validate First Name
        /// </summary>
        public bool FirstNameValidationNunitTest()
        {
            Regex regex = new Regex(firstNamePattern);
            var result = regex.Match(patternFirstName[1]);
            return result.Success;


        }

        /// <summary>
        ///  Validate Last Name
        /// </summary>
        public bool LastNameValidationNunitTest()
        {
            Regex regex = new Regex(lastNamePattern);
            var result = regex.Match(patternLastName[1]);
            return result.Success;

        }

        /// <summary>
        ///  Validate Email
        /// </summary>
        public bool EmailAddressValidationNunitTest()
        {
            Regex regex = new Regex(emailPattern);
            var result = regex.Match(patternEmail[1]);
            return result.Success;

        }

        /// <summary>
        ///  Validate Mobile Number
        /// </summary>
        public bool MobileNumberValidationNunitTest()
        {
            Regex regex = new Regex(mobileNumberPattern);
            var result = regex.Match(patternMobileNumber[1]);
            return result.Success;


        }

        /// <summary>
        ///  Validate Password
        /// </summary>
        public bool PasswordRule4ValidationNunitTest()
        {
            Regex regex = new Regex(passwordRule4Pattern);
            var result = regex.Match(patternPasswordRule4[1]);
            return result.Success;


        }


        /// <summary>
        /// Call from Main Method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //     Program regex = new Program();
            //     regex.FirstNameValidationTestForNunit();
            //     Console.WriteLine("**************************");
            //     regex.lastName();
            //     Console.WriteLine("**************************");
            //     regex.email();
            //     Console.WriteLine("**************************");
            //     regex.mobileNumber();
            //     Console.WriteLine("**************************");
            //     regex.password();
            Console.WriteLine();
        }
    }
}
