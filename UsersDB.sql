CREATE TABLE AuctionItems (
    item_id VARCHAR(10) PRIMARY KEY,
    item_name VARCHAR(100) NOT NULL,
	item_photo_path VARBINARY(MAX),   --    VARCHAR(255)<-- use this
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
    user_photo VARbinary(255) NOT NULL DEFAULT '"C:\Users\ME\Desktop\userphoto.png"'
);



select * from AuctionItems;
delete from AuctionItems where item_id = '00p12345';
drop table AuctionItems;

SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'AuctionItems';
