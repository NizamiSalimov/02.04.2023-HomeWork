namespace _1Test
{
    internal class Program
    {
        static void Main(string[] args)
        {



            Fullname(out string name, out string lastName);

            Fathername();

            Age();

            Fin();

            Phonenumber();

            Option();

            Salary();

            Console.WriteLine("The employee  " + name + " " + lastName + " " + "has been added to the system.");










        }
        static void Fullname(out string name, out string lastName)
        {
            Console.Write("Please enter the employee's name:");
            name = Console.ReadLine()!;
            Console.WriteLine();

            bool lengthError = false;
            bool letterError = false;
            bool firstLetterError = false;

            if (name.Length < 2 || name.Length > 20)
            {
                lengthError = true;
            }
            if (!name.All(Char.IsLetter))
            {
                letterError = true;
            }
            if (!Char.IsUpper(name[0]))
            {
                firstLetterError = true;
            }

            if (lengthError || letterError || firstLetterError)
            {
                Console.WriteLine("The following errors have occurred:");
                Console.WriteLine();

                if (lengthError)
                {
                    Console.WriteLine("The name you enter must be between 2 and 20 letters long!");
                    Console.WriteLine();
                }
                if (letterError)
                {
                    Console.WriteLine("The name you enter must contain only letters!");
                    Console.WriteLine();
                }
                if (firstLetterError)
                {
                    Console.WriteLine("The first letter of the name you enter must be capitalized!");
                    Console.WriteLine();
                }

            }















            Console.Write("Please enter the employee's last name:");
            lastName = Console.ReadLine();
            Console.WriteLine();

            bool lengthError1 = false;
            bool letterError1 = false;
            bool firstLetterError1 = false;

            if (lastName.Length < 2 || lastName.Length > 35)
            {
                lengthError1 = true;
            }
            if (!lastName.All(Char.IsLetter))
            {
                letterError1 = true;
            }
            if (!Char.IsUpper(lastName[0]))
            {
                firstLetterError1 = true;
            }

            if (lengthError1 || letterError1 || firstLetterError1)
            {
                Console.WriteLine("The following errors have occurred:");
                if (lengthError1)
                {
                    Console.WriteLine("The last name you enter must be between 2 and 20 letters long!");
                }
                if (letterError1)
                {
                    Console.WriteLine("The last name you enter must contain only letters!");
                }
                if (firstLetterError1)
                {
                    Console.WriteLine("The first letter of the last name you enter must be capitalized!");
                }
            }



        }










        static void Fathername()
        {
            Console.Write("Please enter the employee's father's name: ");
            string fatherName = Console.ReadLine();
            Console.WriteLine();

            bool lengthError = false;
            bool letterError = false;
            bool firstLetterError = false;

            if (fatherName.Length < 2 || fatherName.Length > 20)
            {
                lengthError = true;
            }
            if (!fatherName.All(Char.IsLetter))
            {
                letterError = true;
            }
            if (!Char.IsUpper(fatherName[0]))
            {
                firstLetterError = true;
            }

            if (lengthError || letterError || firstLetterError)
            {
                Console.WriteLine("The following errors have occurred:");
                if (lengthError)
                {
                    Console.WriteLine("The name you enter must be between 2 and 20 letters long!");
                }
                if (letterError)
                {
                    Console.WriteLine("The name you enter must contain only letters!");
                }
                if (firstLetterError)
                {
                    Console.WriteLine("The first letter of the name you enter must be capitalized!");
                }
            }




        }

        static void Age()
        {
            Console.Write("Please enter the employee's age: ");

            int age;
            if (!int.TryParse(Console.ReadLine(), out age))
            {
                Console.WriteLine("Please enter a valid number.");
                return;
            }

            if (age < 18 || age > 65)
            {
                Console.WriteLine("The age limit should be between 18-65.");
            }
            Console.WriteLine();

        }

        static void Fin()
        {
            Console.Write("Please enter a Fin number:");
            string fin = Console.ReadLine();

            bool isFinValid = (fin.Length == 7) || (fin.All(char.IsUpper) || fin.All(char.IsDigit));

            if (isFinValid)
            {
                Console.WriteLine();
            }

            if (!isFinValid)
            {
                Console.WriteLine("The fin you entered is not correct");
            }


        }

        static void Phonenumber()
        {
            Console.Write("Please enter the employee's phone number (+994xxxxxxxxx): ");
            string phoneNumber = Console.ReadLine();
            Console.WriteLine();

            if (phoneNumber.Length != 13 || !phoneNumber.StartsWith("+994"))
            {
                Console.WriteLine("Enter a phone number in the correct format. (For example: +994xxxxxxxxx)");
            }


        }

        static void Option()
        {
            Console.WriteLine("Please make your selection: 1-HR, 2-Audit, 3-Engineer");
            string option = Console.ReadLine();
            Console.WriteLine();

            if (option == "1")
            {
                Console.WriteLine("Your option: HR");
            }
            else if (option == "2")
            {
                Console.WriteLine("Your option: Audit");
            }
            else if (option == "3")
            {
                Console.WriteLine("Your option: Engineer");
            }
            else
            {
                Console.WriteLine("Invalid option.");
            }
            Console.WriteLine();
        }
        static void Salary()
        {
            Console.Write("Enter the employee's salary: ");
            int maas = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (maas < 1500 || maas > 5000)
            {
                Console.WriteLine("Salary should be between 1500-5000..");
            }


        }











    }
}

