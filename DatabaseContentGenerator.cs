using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Diagnostics;
public class Maincode
{
    public static void Main()
    {
            int custNum = 5;
            CustList(custNum);
            int cardList = 10;
            List<double> nums = GenerateCardNums(cardList);

            CardList(cardList, custNum, nums);


    }

    public static void CustList(int repeat)
    {
        for(int j = 0; j < repeat; j++)
        {
        string[] firstNames = {"James", "Robert", "Mary", "Patricia", "John", "Jennifer", "Michael", "Linda", "William", "Elizabeth", "Nushi", "Jose", "Mohammed", "Ali", "Li", "Peter", "Sri", "Olga", "Rita", "Alexander"};
        string[] lastNames = {"Zhang", "Khan", "Ahmed", "Brown", "Jones", "Johnson", "Silva", "Tesfaye", "Smith", "Rodriguez", "Lee", "Torres", "Hansen", "Kone", "Nguyen", "Devi", "Muller","Lopez","Myers","Gray"};
        //string[] Usernames = new string[10]; I'll just have them be FirstnameLastname
        //string[] passwords = new string[10];
        //string[] address1num = new string[10];
        string[] address1stname = {"Cedar","Elm","First","Main","Oak","Elm","Hill","Wall","Park","Maple","Church","High","Green","The","King","Queen","Short","Sunset","Pleasant","Hillside","Second","Third","Shore","Meadow","Lake","River","Aspen","Cicero","Mill","North","South"};
        string[] address1stsuffix = {"St", "Ln", "Ave", "Rd", "Way", "Circle", "Dr", "Hwy"};
        string[] address2apts = {"1","2","3","4","A","B","C","1A","2A","1B","2B"};
        string[] cities = {"Washington","Springfield","Franklin","Greenville","Bristol","Madison","Clinton","Fairview","Salem","Georgetown","Centerville","CityTownVille"};
        string[] stateAbb = { "AL", "AK", "AS", "AZ", "AR", "CA", "CO", "CT", "DE", "DC", "FL", "GA", "GU", "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD", "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH", "NJ", "NM", "NY", "NC", "ND", "MP", "OH", "OK", "OR", "PA", "PR", "RI", "SC", "SD", "TN", "TX", "UT", "VT", "VA", "VI", "WA", "WV", "WI", "WY" };
        string[] emailsuffix = {"@google.com","@google.com","@google.com","@google.com","@google.com","@surfglobal.net","@hotmail.com","@yahoo.com", "@charter.net", "@comcast.net"};

        Random rand = new Random();
        int zip = rand.Next(10000,99999);
        string fname = firstNames[(rand.Next(0,19))];
        string lname = lastNames[(rand.Next(0,19))];
        string userName = fname + lname ;
        string email = userName;
        int num = rand.Next(0,999);
        if (num != 0)
        {
            email += num.ToString();
        }
        email += emailsuffix[(rand.Next(0,9))];
        string phoneNumber = (rand.Next(0,999)).ToString().PadLeft(3,'0') + "-" + (rand.Next(0,999)).ToString().PadLeft(3,'0') + "-" + (rand.Next(0,9999)).ToString().PadLeft(4,'0');
        string password ="";
        int charNum = rand.Next(5,30);
        string address1 = "";
        string address2="";
        for (int i = 0; i <= charNum; i++)
        {
            int unicode = rand.Next(34,126);
            if (unicode == 39)
            {
                unicode = 33;
            }
            password += ((char)unicode).ToString();
        }
        address1 += rand.Next(1,1000);
        if ((rand.Next(1,10)) > 7)
        {
            int prefix = rand.Next(1,4);
            switch(prefix)
            {
                case 1:
                address1 +=  " N";
                break;
                case 2:
                address1 += " E";
                break;
                case 3:
                address1 += " S";
                break;
                case 4:
                address1 += " W";
                break;
            }
        }
        address1 += " " + address1stname[(rand.Next(0,30))] + " " + address1stsuffix[(rand.Next(0,7))];
        if ((rand.Next(1,10)) > 7)
        {
            address2 += address2apts[(rand.Next(1,10))];
        }
        string full = ("INSERT INTO Firecard.CustomerList (PWord, FirstName, LastName, Address1, Address2, City, StateAbb, Zip, Phone, Email) VALUES ('" + password + "', '" + fname + "', '" + lname + "', '" + address1 + "', '" + address2 + "', '" + cities[(rand.Next(0,11))] + "', '" + stateAbb[(rand.Next(0,55))] + "', '" + zip + "', '" + phoneNumber + "', '" + email + "')");
        string record = ("CREATE TABLE Firecard.Customer" + j + "( TransactionDate NVARCHAR (10), TransactionAmount MONEY, Purchase NVARCHAR (1), CardNumber BIGINT)");
        Console.WriteLine(full);
        Console.WriteLine(record);
        }
    }
    public static void CardList(int repeat, int maxCust, List<double> numbers)
    {
        for(int j = 0; j < repeat; j++)
        {
        Random rand = new Random();
        int initBalance = rand.Next(1,1000);
        int nowBalance = rand.Next(0,(initBalance * 2));
        int month = rand.Next(1,12);
        int year = rand.Next(2010,2021);
        string date = year.ToString() + "/";
        int custNum = rand.Next(0,maxCust);
        switch (month)
        {
            case 1:
            case 3:
            case 5:
            case 7:
            case 9:
            case 11:
            date += month.ToString() + "/" + rand.Next(1,31).ToString();
            break;
            case 4:
            case 6:
            case 8:
            case 10:
            case 12:
            date += month.ToString() + "/" + rand.Next(1,30).ToString();
            break;
            case 2:
            if (year == 2012 || year == 2016 || year == 2020)
            {
            date += month.ToString() + "/" + rand.Next(1,29).ToString();
            }
            else
            {
            date += month.ToString() + "/" + rand.Next(1,28).ToString();
            }
            break;
        }
        string full = ("INSERT INTO Firecard.CardList (Card_Number, PurchaseDate, InitialBalance, CurrentBalance, Customer) VALUES (" + numbers[j] +  ", '" + date + "', "  + initBalance + ", " + nowBalance + ", "  + custNum + ")");
        CardHistory(numbers[j], custNum,nowBalance);
        Console.WriteLine(full);
        }
    }
    public static void CardHistory(double card, int cust, int balance)
    {
        Random rand = new Random();
        int transactions = rand.Next(1,4);
        string? purchase;
        for (int i = 0; i<transactions;i++)
        {
            double change = (rand.Next(0,(balance*100)))/100;
            double newBalance = 0;
            if(change%5 == 0)
            {
                newBalance = balance + change;
                change = 0 - change;
                purchase = "S";
            }
            else
            {
                newBalance = balance - change;
                purchase = "P";
            }
            string full = ("INSERT INTO Firecard.Customer" + cust + " (TransactionDate, TransactionAmount, Purchase, CardNumber) VALUES ('" + DateTime.Now.ToString("MM/dd/yyyy") + "', " + change + ", '" + purchase + "', "  + card + ")");

        Console.WriteLine(full);
        }
    }
    public static List<double> GenerateCardNums(int cards)
    {
        List<double> nums = new List<double>();
        Random rand = new Random();
        for (int i = 0; i < cards; i++)
        {
            string newNum = (rand.Next(1,9999)).ToString().PadLeft(4, '0') + (rand.Next(1,9999)).ToString().PadLeft(4, '0') + (rand.Next(1,9999)).ToString().PadLeft(4, '0');
            double newNumber = double.Parse(newNum);
            while (true)
            {
                if (nums.Contains(newNumber))
                {
                    newNum = (rand.Next(1,9999)).ToString().PadLeft(4, '0') + (rand.Next(1,9999)).ToString().PadLeft(4, '0') + (rand.Next(1,9999)).ToString().PadLeft(4, '0');
                    newNumber = double.Parse(newNum);
                }
                else
                {
                break;
                }
            }
            nums.Add(newNumber);
        }
        //Console.WriteLine(nums[0]);
        return nums;
    }

}
// Scaffold-DbContext Server=tcp:firsttryserver.database.windows.net,1433;Initial Catalog=FirstTryResourceGroupDatabase;Persist Security Info=False;User ID=Mechsrule1;Password=ed3MxmE23EKEsed;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30; -OutputDir Models -Context SunCardBackend2Context

//Microsoft.EntityFrameworkCore.SqlServer