CREATE DATABASE QUANLIQUANAN;
GO
USE master
DROP DATABASE QUANLIQUANAN
USE QUANLIQUANAN;
GO

-- MENU_ITEM, TABLE_FOOD, MENU_CATEGORY, ACCOUNT, BILL, BILL_DETAIL, EMPLOYEE, RESERVATION, CUSTOMER

CREATE TABLE TABLE_FOOD (
    ID INT IDENTITY PRIMARY KEY,
    TABLE_NAME NVARCHAR(100) NOT NULL,
    STATUS NVARCHAR(50)		DEFAULT N'Trống'-- AVAILABLE || OCCUPIED
);
GO

CREATE TABLE ACCOUNT (
    USERNAME NVARCHAR(100) PRIMARY KEY,
    DISPLAY_NAME NVARCHAR(100) NOT NULL,
    PASSWORD NVARCHAR(100) NOT NULL,
    ACCOUNT_TYPE INT NOT NULL DEFAULT 0 -- 0: EMPLOYEE, 1: ADMIN
);
GO

CREATE TABLE MENU_CATEGORY (
    ID INT IDENTITY PRIMARY KEY,
    CATEGORY_NAME NVARCHAR(100) NOT NULL
);
GO

CREATE TABLE MENU_ITEM (
    ID INT IDENTITY PRIMARY KEY,
    ITEM_NAME NVARCHAR(100) NOT NULL,
    CATEGORY_ID INT,
    PRICE FLOAT NOT NULL,
    DESCRIPTION TEXT,
    FOREIGN KEY (CATEGORY_ID) REFERENCES MENU_CATEGORY(ID)
);
GO

CREATE TABLE BILL (
    ID INT IDENTITY PRIMARY KEY,
    CHECKIN DATETIME NOT NULL DEFAULT GETDATE(),
    CHECKOUT DATETIME,
    TABLE_ID INT NOT NULL,
    STATUS INT NOT NULL DEFAULT 0,
    FOREIGN KEY (TABLE_ID) REFERENCES TABLE_FOOD(ID)
);
GO

CREATE TABLE BILL_DETAIL (
    ID INT IDENTITY PRIMARY KEY,
    BILL_ID INT NOT NULL,
    ITEM_ID INT NOT NULL,
    QUANTITY INT NOT NULL DEFAULT 0,
	TOTAL_PAYMENT FLOAT NOT NULL DEFAULT 0,
    FOREIGN KEY (BILL_ID) REFERENCES BILL(ID),
    FOREIGN KEY (ITEM_ID) REFERENCES MENU_ITEM(ID)
);
GO


CREATE TABLE EMPLOYEE (
    ID INT IDENTITY PRIMARY KEY,
    FULL_NAME NVARCHAR(100) NOT NULL,
    ROLE NVARCHAR(50) NOT NULL, 
    PHONE_NUMBER NVARCHAR(15),
    HIRE_DATE DATE NOT NULL,
    ACCOUNT_USERNAME NVARCHAR(100),
    FOREIGN KEY (ACCOUNT_USERNAME) REFERENCES ACCOUNT(USERNAME)
);
GO


CREATE TABLE CUSTOMER (
    ID INT IDENTITY PRIMARY KEY,
    FULL_NAME NVARCHAR(100) NOT NULL,
    PHONE_NUMBER NVARCHAR(15),
    ADDRESS NVARCHAR(200)
);
GO

CREATE TABLE RESERVATION (
    ID INT IDENTITY PRIMARY KEY,
    CUSTOMER_ID INT NOT NULL,
    TABLE_ID INT NOT NULL,
    RESERVATION_TIME DATETIME NOT NULL,
    NUMBER_OF_GUESTS INT NOT NULL,
    STATUS NVARCHAR(50) DEFAULT 'PENDING', -- PENDING || CONFIRMED || CANCELLED
    FOREIGN KEY (CUSTOMER_ID) REFERENCES CUSTOMER(ID),
    FOREIGN KEY (TABLE_ID) REFERENCES TABLE_FOOD(ID)
);
GO
INSERT INTO dbo.Account
(
    UserName,
    DISPLAY_NAME,
    PassWord,
    ACCOUNT_TYPE
)
VALUES
(
    N'Admin',          -- UserName = nvarchar(100)
    N'Quản Lí',      -- DisplayName = nvarchar(100)
    N'1',           -- PassWord = nvarchar(1000)
    1               -- Type = int
);

INSERT INTO dbo.Account
(
    UserName,
    DISPLAY_NAME,
    PassWord,
    ACCOUNT_TYPE
)
VALUES
(
    N'staff',         -- UserName = nvarchar(100)
    N'Nhân viên',      -- DisplayName = nvarchar(100)
    N'1',           -- PassWord = nvarchar(1000)
    0               -- Type = int
);
GO

CREATE PROC USP_GetAccountByUserName
@UserNAME nvarchar(100)
AS
BEGIN
	SELECT * FROM ACCOUNT WHERE USERNAME=@UserNAME
END
GO

EXEC USP_GetAccountByUserName @UserNAME = N'Admin'
GO
Select * from ACCOUNT Where USERNAME = N'Admin' AND PASSWORD = N'1'
go

CREATE PROC USP_LOGIN
@UserName nvarchar(100), @PassWord nvarchar(100)
AS
BEGIN
	SELECT * FROM ACCOUNT WHERE USERNAME = @UserName and PASSWORD = @PassWord
END
go
--THEM BAN
DECLARE @i INT = 1;

WHILE @i <= 15
BEGIN
    INSERT INTO dbo.TABLE_FOOD (TABLE_NAME)
    VALUES (N'Bàn' + CAST(@i AS nvarchar(100)));
    SET @i = @i + 1;
END;
go


CREATE PROC USP_GetTableList
AS SELECT * FROM dbo.TABLE_FOOD
GO
UPdate TABLE_FOOD set STATUS =N'Có Người' where id=9

GO

EXEC dbo.USP_GetTableList

SELECT * FROM dbo.BILL
GO

--THEM CATEGORY 
INSERT dbo.MENU_CATEGORY
	(CATEGORY_NAME)
VALUES (N'Món nướng') -- name - nvarchar(100) 		
INSERT dbo.MENU_CATEGORY
	(CATEGORY_NAME)
VALUES (N'Món xào ') 
INSERT dbo.MENU_CATEGORY
	(CATEGORY_NAME)
VALUES (N'Món hấp ') 
INSERT dbo.MENU_CATEGORY
	(CATEGORY_NAME)
VALUES (N'Món luộc ') 		
INSERT dbo.MENU_CATEGORY
	(CATEGORY_NAME)
VALUES (N'Món chiên') 
INSERT dbo.MENU_CATEGORY
	(CATEGORY_NAME)
VALUES (N'Món hầm ')
INSERT dbo.MENU_CATEGORY
	(CATEGORY_NAME)
VALUES (N'Món kho ') 
INSERT dbo.MENU_CATEGORY
	(CATEGORY_NAME)
VALUES (N'Món lẩu ')
INSERT dbo.MENU_CATEGORY
	(CATEGORY_NAME)
VALUES (N'Gỏi ')
INSERT dbo.MENU_CATEGORY
	(CATEGORY_NAME)
VALUES (N'Súp ') 
INSERT dbo.MENU_CATEGORY
	(CATEGORY_NAME)
VALUES (N'Đồ uống ')
INSERT dbo.MENU_CATEGORY
	(CATEGORY_NAME)
VALUES (N'Tráng miệng ') 
-- thêm món ăn
INSERT INTO MENU_ITEM
    (ITEM_NAME, CATEGORY_ID, PRICE)
VALUES 
    (N'Sò điệp nướng mỡ hành', 1, 100000),
    (N'Thịt nướng than hoa', 1, 150000),
    (N'Hải sản nướng phô mai', 1, 180000),
    (N'Gà nướng mật ong', 1, 160000),
	(N'Nui xào bò', 2, 100000),
    (N'Rau muống xào tỏi', 2, 70000),
    (N'Mì xào hải sản', 2, 120000),
    (N'Mực xào chua ngọt', 2, 90000),
	(N'Cá chẽm hấp xì dầu', 3, 200000),
    (N'Gà hấp muối', 3, 180000),
    (N'Dê hấp tía tô', 3, 120000),
    (N'Nghêu hấp xả', 3, 90000),
	(N'Tôm luộc nước dừa', 4, 200000),
    (N'Ghẹ luộc', 4, 250000),
    (N'Sò huyết luộc', 4, 120000),
    (N'Gà luộc', 4, 90000),
	(N'Cơm chiên cá mặn', 5, 90000),
    (N'Cánh gà chiên nước mắm', 5, 140000),
    (N'Tôm chiên xù', 5, 170000),
    (N'Chả giò chiên', 5, 90000),
	(N'Gà hầm thuốc bắc', 6, 200000),
    (N'Vịt hầm tiêu xanh', 6, 220000),
    (N'Sườn non hầm ngũ vị', 6, 210000),
    (N'CĐậu hũ hầm nấm', 6, 90000),
	(N'Cá kho tộ', 7, 140000),
    (N'Thịt vịt kho gừng', 7, 170000),
    (N'Sườn kho tiêu', 7, 180000),
    (N'Cá basa kho nghệ', 7, 190000),
	(N'Lẩu thập cẩm', 8, 300000),
    (N'Lẩu hải sản', 8, 350000),
    (N'Lẩu gà lá giang', 8, 320000),
    (N'Lẩu cá kèo', 8, 250000),
	(N'Gỏi đu đủ ', 9, 90000),
    (N'Gỏi bò tái chanh', 9, 160000),
    (N'Gỏi gà măng cụt', 9, 200000),
    (N'Gỏi bắp cải tôm thịt', 9, 80000),
	(N'Súp cua trứng gà ', 10, 90000),
    (N'Súp gà ngô non', 10, 100000),
    (N'Súp hải sản', 10, 100000),
    (N'Súp bí đỏ', 10, 60000),
	(N'Coca-Cola ', 11, 15000),
    (N'Pepsi', 11, 15000),
    (N'7-Up', 11, 15000),
    (N'Sprite', 11, 15000),
	(N'Bia Saigon ', 11, 25000),
    (N'Bia Tiger', 11, 30000),
    (N'Bia Heineken', 11, 35000),
    (N'Bia Budweiser', 11, 40000),
	(N'Trái cây thập cẩm ', 12, 60000),
    (N'Rau câu', 12, 30000),
    (N'Chè thập cẩm', 12, 35000),
    (N'Kem vani socola', 12, 40000);
-- Thêm BILL
/*
INSERT INTO BILL
    (CHECKIN, CHECKOUT, TABLE_ID, STATUS)
VALUES 
    (GETDATE(), NULL, 1, 0),
    (GETDATE(), NULL, 2, 1),
    (GETDATE(), GETDATE(), 3, 0);

-- Thêm BILL_DETAIL
INSERT INTO BILL_DETAIL
    (BILL_ID, ITEM_ID, QUANTITY, TOTAL_PAYMENT)
VALUES 
    (1, 1, 10, 120000),
    (2, 2, 10, 150000);
	*/
GO
/*
SELECT * FROM dbo.BILL
SELECT * FROM dbo.BILL_DETAIL
SELECT * FROM dbo.MENU_ITEM
SELECT * FROM dbo.MENU_CATEGORY
SELECT * FROM TABLE_FOOD
SELECT * FROM BILL WHERE ID = 1 AND STATUS = 0
SELECT * FROM BILL_DETAIL WHERE ID = 1
*/
/*
SELECT f.ITEM_NAME, bi.QUANTITY, f.PRICE, f.PRICE * bi.QUANTITY AS total_payment
FROM dbo.BILL_DETAIL AS bi
JOIN dbo.Bill AS b ON bi.BILL_ID = b.id
JOIN dbo.MENU_ITEM AS f ON bi.ITEM_ID = f.id
WHERE b.TABLE_ID = 1 and b.STATUS = 0; 
*/
go
CREATE PROC USP_InsertBill
@idTable INT 
AS
BEGIN
	INSERT BILL (CHECKIN,CHECKOUT,TABLE_ID,STATUS)
	VALUES (GETDATE(),NULL,@idTable,0)
END
GO

CREATE PROC USP_InsertBillDetail
@idBill INT, @idFood INT, @quantity INT
AS
BEGIN
    DECLARE @isExitsBillDetail INT
    DECLARE @foodQuantity INT = 1 

    -- Kiểm tra xem hóa đơn và món ăn có tồn tại trong BILL_DETAIL hay không
    SELECT @isExitsBillDetail = ID, @foodQuantity = QUANTITY 
    FROM BILL_DETAIL 
    WHERE BILL_ID = @idBill AND ITEM_ID = @idFood

    IF (@isExitsBillDetail > 0)
    BEGIN
        -- Nếu món đã tồn tại trong hóa đơn, cập nhật số lượng
        DECLARE @newQuantity INT = @foodQuantity + @quantity
        IF (@newQuantity > 0)
        BEGIN
            UPDATE BILL_DETAIL 
            SET QUANTITY = @foodQuantity + @quantity
            WHERE ITEM_ID = @idFood AND BILL_ID = @idBill
        END
        ELSE
        BEGIN
            -- Nếu số lượng mới <= 0, xóa món khỏi hóa đơn
            DELETE FROM BILL_DETAIL 
            WHERE BILL_ID = @idBill AND ITEM_ID = @idFood
        END
    END
    ELSE
    BEGIN
        -- Nếu món chưa tồn tại trong hóa đơn, thêm mới
        INSERT INTO BILL_DETAIL (BILL_ID, ITEM_ID, QUANTITY)
        VALUES (@idBill, @idFood, @quantity)
    END
END
GO


