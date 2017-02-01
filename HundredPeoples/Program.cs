using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhoIsLeft
{
    class Alive
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of People: ");
            int TotalNoOfPeople = Convert.ToInt16(Console.ReadLine());
            int[] People = new int[TotalNoOfPeople];
            int counter = 1;
            for (int index = 0; index < TotalNoOfPeople; index++)
            {
                People[index] = counter;
                counter++;
            }
            int Answer = ManEscaped(People);
            Console.Write("The one who managed to survive is " + Answer + "th person");
            Console.ReadLine();
        }
        static int ManEscaped(int[] Number)
        {
            int TotalPeople = Number.Length;
            if (TotalPeople == 1)
                return Number[0];
            int[] PeopleWhoDied = new int[(TotalPeople + 1) / 2];
            int countForNewPeople = 0;
            for (int index = 0; index < TotalPeople; index += 2)
            {
                PeopleWhoDied[countForNewPeople] = Number[index];
                countForNewPeople++;
            }
            if (TotalPeople % 2 == 0)
                return ManEscaped(PeopleWhoDied);
            else
            {
                int[] temp = new int[(TotalPeople + 1) / 2];
                for (int index = 1; index < countForNewPeople; index++)
                {
                    temp[index] = PeopleWhoDied[index - 1];
                    temp[0] = PeopleWhoDied[index];
                }
                return ManEscaped(temp);
            }
        }
    }
}

