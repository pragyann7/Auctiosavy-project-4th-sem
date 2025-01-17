create database auctiondb;

CREATE TABLE AuctionItems (
    item_id VARCHAR(10) PRIMARY KEY,
    item_name VARCHAR(100) NOT NULL,
    item_photo_path VARBINARY(MAX) not null,  -- Changed to VARCHAR(255) for photo path
    description TEXT,
    category VARCHAR(50) NOT NULL,
    starting_price DECIMAL(10, 2) NOT NULL CHECK (starting_price > 0),
    start_time DATETIME NOT NULL,
    end_time DATETIME NOT NULL,
    created_date DATETIME NOT NULL DEFAULT GETDATE(),
    current_bid DECIMAL(10, 2) NULL,
    status VARCHAR(10) DEFAULT 'pending',
    CONSTRAINT CK_AuctionTime CHECK (end_time > start_time)
);


-- UserDatabase

CREATE TABLE userdetails (
    user_id INT IDENTITY(101,1) PRIMARY KEY NOT NULL,
    name VARCHAR(50) NOT NULL,
    contact VARCHAR(15) NOT NULL UNIQUE,
    email VARCHAR(100) NOT NULL UNIQUE,
    username VARCHAR(50) NOT NULL UNIQUE,
    password VARCHAR(255) NOT NULL,
	security1 VARCHAR(50) NOT NULL,
	security2 VARCHAR(50) NOT NULL,
	security3 VARCHAR(50) NOT NULL,
    created_date DATETIME NOT NULL DEFAULT GETDATE(),
    last_password_reset DATETIME NULL,
    role VARCHAR(10) NOT NULL DEFAULT 'user',
    last_updated_date DATETIME NOT NULL DEFAULT GETDATE(),
    user_photo VARbinary(MAX)
);

CREATE TABLE Bids (
    bid_id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    item_id VARCHAR(10) NOT NULL,
    user_id INT NOT NULL,
    bid_amount DECIMAL(12, 2) NOT NULL,
    bid_time DATETIME NOT NULL DEFAULT GETDATE(),
    FOREIGN KEY (item_id) REFERENCES AuctionItems(item_id),
    FOREIGN KEY (user_id) REFERENCES userdetails(user_id),
    CONSTRAINT CK_BidAmount CHECK (bid_amount > 0)
);


CREATE TABLE Winners (
    winner_id INT IDENTITY PRIMARY KEY,
    item_id VARCHAR(10) NOT NULL,
    user_id INT NOT NULL,
    winning_bid DECIMAL(10, 2) NOT NULL,
    winning_time DATETIME NOT NULL DEFAULT GETDATE(),
    FOREIGN KEY (item_id) REFERENCES AuctionItems(item_id),
    FOREIGN KEY (user_id) REFERENCES userdetails(user_id)
);


update userdetails set role = 'admin' where user_id = 101;

SELECT * FROM AuctionItems WHERE end_time <= GETDATE();
SELECT * FROM Bids;



delete from AuctionItems;


select * from Winners;
select * from bids;
select * from AuctionItems;
select * from userdetails;
delete from AuctionItems where item_id = '00p12345';
drop table userdetails;
drop table AuctionItems;
drop table Bids;
drop table Winners;
update userdetails set user_photo = null where user_id = 108;

SELECT SYSDATETIMEOFFSET();
SELECT GETDATE() AT TIME ZONE 'UTC' AT TIME ZONE 'Nepal Standard Time';
SELECT SYSDATETIMEOFFSET() AT TIME ZONE 'Nepal Standard Time';

