CREATE TABLE Locations
(
    StoreID TINYINT PRIMARY KEY,
    City NVARCHAR(25) NOT NULL,
    Manager NVARCHAR(100) NOT NULL,
)

CREATE TABLE Inventory
(
    ItemID TINYINT,
    StoreID TINYINT FOREIGN KEY REFERENCES Locations(StoreID) NOT NULL, 
    Quantity SMALLINT,
    PRIMARY KEY (ItemID, StoreID),
)

CREATE TABLE Items
(
    ItemID TINYINT PRIMARY KEY,
    ItemName NVARCHAR(30) NOT NULL,
    ItemDescrip NVARCHAR(300),
)
ALTER TABLE Inventory ADD FOREIGN KEY (ItemID) REFERENCES Items(ItemID)



INSERT INTO Inventory
(ItemID, StoreID, Quantity)
VALUES
    (1, 1, 500),
    (2, 1, 500),
    (3, 1, 150),
    (4, 1, 150),
    (5, 1, 150);

INSERT INTO Locations
(StoreID, City, Manager)
VALUES
(1, 'Minneapolis', 'Jim Helsinki'),
(2, 'Robbinsdale', 'Terri McCollough'),
(3, 'Plymouth', 'Jameson Catterly'),
(4, 'Maple Grove', 'Dianne Potterton');

INSERT INTO Items
(ItemID, ItemName, ItemDescrip)
VALUES
(1, '', ''),
(2, '', ''),
(3, '', ''),
(4, '', ''),
(5, '', '');