using Project2EntityFramework.Data;

namespace Project2EntityFramework
{
    public class CreateCardDto
    {
        IDataBaseConnection connection;

        public CreateCardDto(IDataBaseConnection connection)
        {
            this.connection = connection;
        }

        public void GenerateCardNums(int cards)
        {
            Random rand = new Random();
            string newNum = (rand.Next(1, 9999)).ToString().PadLeft(4, '0') + (rand.Next(1, 9999)).ToString().PadLeft(4, '0') + (rand.Next(1, 9999)).ToString().PadLeft(4, '0');
            double newNumber = double.Parse(newNum);
            while (true)
            {
                if (this.connection.cardFound(cards))//in this if statement, check the database for duplicate card numbers and if one is found, do it. if one is not found, it runs the else and breaks the loop
                {
                    newNum = (rand.Next(1, 9999)).ToString().PadLeft(4, '0') + (rand.Next(1, 9999)).ToString().PadLeft(4, '0') + (rand.Next(1, 9999)).ToString().PadLeft(4, '0');
                    newNumber = double.Parse(newNum);
                }
                else
                {
                    break;
                }
            }
            //after the loop is run, it needs to add the new card to the database, or if that is done in another function, return just the card number it generated. New cards need: card number, purchase date, initial balance, current balance (which will be the same as current balance) and customer number (which we aren't doing right now so have it generate as customer 0
        }
    }
}

