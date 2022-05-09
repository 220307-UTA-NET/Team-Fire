CREATE SCHEMA Firecard;
GO

CREATE TABLE Firecard.CustomerList(
    Customer_ID INT PRIMARY KEY IDENTITY, -- remove
    PWord NVARCHAR (30),
    FirstName NVARCHAR (150),
    LastName NVARCHAR (150),
    Address1 NVARCHAR (255),
    Address2 NVARCHAR (255),
    City NVARCHAR (255),
    StateAbb NVARCHAR (2),
    Zip NVARCHAR (10),
    Phone NVARCHAR (20),
    Email NVARCHAR (100)
) 

CREATE TABLE Firecard.CardList(
    Card_ID INT PRIMARY KEY IDENTITY, --We can make these be all totally random.
    Card_Number BIGINT,
    PurchaseDate NVARCHAR (10),
    InitialBalance MONEY,
    CurrentBalance MONEY,
    Customer INT
)

INSERT INTO Firecard.CustomerList (PWord, FirstName, LastName, Address1, Address2, City, StateAbb, Zip, Phone, Email) VALUES ('dijiAXsUtBSh4tk', 'Robert', 'Muller', '271 Third Way', '4', 'Greenville', 'MN', '60459', '435-897-6957', 'RobertMuller566@google.com')
CREATE TABLE Firecard.Customer0( TransactionDate NVARCHAR (10), TransactionAmount MONEY, Purchase NVARCHAR (1), CardNumber BIGINT)
INSERT INTO Firecard.CustomerList (PWord, FirstName, LastName, Address1, Address2, City, StateAbb, Zip, Phone, Email) VALUES (')8\#BMiD8INRQ', 'Peter', 'Brown', '141 Aspen Dr', '', 'Bristol', 'CA', '58072', '245-050-0657', 'PeterBrown334@google.com')
CREATE TABLE Firecard.Customer1( TransactionDate NVARCHAR (10), TransactionAmount MONEY, Purchase NVARCHAR (1), CardNumber BIGINT)
INSERT INTO Firecard.CustomerList (PWord, FirstName, LastName, Address1, Address2, City, StateAbb, Zip, Phone, Email) VALUES ('`RN%Sa.*@F', 'Rita', 'Silva', '471 River Dr', '', 'Centerville', 'NJ', '56112', '157-754-7870', 'RitaSilva48@google.com')
CREATE TABLE Firecard.Customer2( TransactionDate NVARCHAR (10), TransactionAmount MONEY, Purchase NVARCHAR (1), CardNumber BIGINT)
INSERT INTO Firecard.Customer2 (TransactionDate, TransactionAmount, Purchase, CardNumber) VALUES ('04/29/2022', 411, 'P', 581092127548)
INSERT INTO Firecard.Customer2 (TransactionDate, TransactionAmount, Purchase, CardNumber) VALUES ('04/29/2022', -330, 'S', 581092127548)
INSERT INTO Firecard.Customer2 (TransactionDate, TransactionAmount, Purchase, CardNumber) VALUES ('04/29/2022', -165, 'S', 581092127548)
INSERT INTO Firecard.CardList (Card_Number, PurchaseDate, InitialBalance, CurrentBalance, Customer) VALUES (581092127548, '2019/10/22', 548, 414, 2)
INSERT INTO Firecard.Customer1 (TransactionDate, TransactionAmount, Purchase, CardNumber) VALUES ('04/29/2022', 356, 'P', 358444628196)
INSERT INTO Firecard.Customer1 (TransactionDate, TransactionAmount, Purchase, CardNumber) VALUES ('04/29/2022', -525, 'S', 358444628196)
INSERT INTO Firecard.Customer1 (TransactionDate, TransactionAmount, Purchase, CardNumber) VALUES ('04/29/2022', 627, 'P', 358444628196)
INSERT INTO Firecard.CardList (Card_Number, PurchaseDate, InitialBalance, CurrentBalance, Customer) VALUES (358444628196, '2010/9/15', 808, 704, 1)
INSERT INTO Firecard.Customer0 (TransactionDate, TransactionAmount, Purchase, CardNumber) VALUES ('04/29/2022', 226, 'P', 607593030741)
INSERT INTO Firecard.CardList (Card_Number, PurchaseDate, InitialBalance, CurrentBalance, Customer) VALUES (607593030741, '2018/3/30', 762, 466, 0)
INSERT INTO Firecard.Customer0 (TransactionDate, TransactionAmount, Purchase, CardNumber) VALUES ('04/29/2022', 2, 'P', 958378528895)
INSERT INTO Firecard.Customer0 (TransactionDate, TransactionAmount, Purchase, CardNumber) VALUES ('04/29/2022', 8, 'P', 958378528895)
INSERT INTO Firecard.CardList (Card_Number, PurchaseDate, InitialBalance, CurrentBalance, Customer) VALUES (958378528895, '2016/11/24', 14, 11, 0)
INSERT INTO Firecard.Customer0 (TransactionDate, TransactionAmount, Purchase, CardNumber) VALUES ('04/29/2022', 436, 'P', 437093031510)
INSERT INTO Firecard.Customer0 (TransactionDate, TransactionAmount, Purchase, CardNumber) VALUES ('04/29/2022', 181, 'P', 437093031510)
INSERT INTO Firecard.Customer0 (TransactionDate, TransactionAmount, Purchase, CardNumber) VALUES ('04/29/2022', 116, 'P', 437093031510)
INSERT INTO Firecard.CardList (Card_Number, PurchaseDate, InitialBalance, CurrentBalance, Customer) VALUES (437093031510, '2019/2/3', 602, 481, 0)
INSERT INTO Firecard.Customer0 (TransactionDate, TransactionAmount, Purchase, CardNumber) VALUES ('04/29/2022', 113, 'P', 877985691869)
INSERT INTO Firecard.CardList (Card_Number, PurchaseDate, InitialBalance, CurrentBalance, Customer) VALUES (877985691869, '2016/4/1', 934, 176, 0)
INSERT INTO Firecard.Customer1 (TransactionDate, TransactionAmount, Purchase, CardNumber) VALUES ('04/29/2022', 13, 'P', 101393820519)
INSERT INTO Firecard.Customer1 (TransactionDate, TransactionAmount, Purchase, CardNumber) VALUES ('04/29/2022', -875, 'S', 101393820519)
INSERT INTO Firecard.Customer1 (TransactionDate, TransactionAmount, Purchase, CardNumber) VALUES ('04/29/2022', 189, 'P', 101393820519)
INSERT INTO Firecard.CardList (Card_Number, PurchaseDate, InitialBalance, CurrentBalance, Customer) VALUES (101393820519, '2011/2/11', 583, 961, 1)
INSERT INTO Firecard.Customer1 (TransactionDate, TransactionAmount, Purchase, CardNumber) VALUES ('04/29/2022', 977, 'P', 994569365059)
INSERT INTO Firecard.CardList (Card_Number, PurchaseDate, InitialBalance, CurrentBalance, Customer) VALUES (994569365059, '2014/11/18', 743, 1251, 1)





SELECT * FROM Firecard.CustomerList
SELECT * FROM Firecard.CardList
SELECT * FROM Firecard.Customer0
SELECT * FROM Firecard.Customer1
SELECT * FROM Firecard.Customer2