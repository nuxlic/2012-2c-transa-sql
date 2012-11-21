USE GD2C2012
BEGIN TRANSACTION;
/****** ESQUEMA ******/
IF NOT EXISTS (SELECT * FROM sys.schemas WHERE name = N'TRANSA_SQL')  
EXEC sys.sp_executesql N'CREATE SCHEMA [TRANSA_SQL] AUTHORIZATION [gd]'
COMMIT;

--  Drop Foreign Key Constraints 
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('TRANSA_SQL.FK_Card_CardType') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE TRANSA_SQL.Card DROP CONSTRAINT FK_Card_CardType


IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('TRANSA_SQL.FK_Card_Customer') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE TRANSA_SQL.Card DROP CONSTRAINT FK_Card_Customer


IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('TRANSA_SQL.FK_ConsumedCoupon_Bill') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE TRANSA_SQL.ConsumedCoupon DROP CONSTRAINT FK_ConsumedCoupon_Bill


IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('TRANSA_SQL.FK_ConsumedCoupon_CouponBook') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE TRANSA_SQL.ConsumedCoupon DROP CONSTRAINT FK_ConsumedCoupon_CouponBook


IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('TRANSA_SQL.FK_ConsumedCoupon_Customer') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE TRANSA_SQL.ConsumedCoupon DROP CONSTRAINT FK_ConsumedCoupon_Customer


IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('TRANSA_SQL.FK_CouponBook_PublishedCouponBook') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE TRANSA_SQL.CouponBook DROP CONSTRAINT FK_CouponBook_PublishedCouponBook


IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('TRANSA_SQL.FK_CreditLoad_Customer') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE TRANSA_SQL.CreditLoad DROP CONSTRAINT FK_CreditLoad_Customer


IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('TRANSA_SQL.FK_CreditLoad_PaymentType') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE TRANSA_SQL.CreditLoad DROP CONSTRAINT FK_CreditLoad_PaymentType


IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('TRANSA_SQL.FK_Customer_PersonalData') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE TRANSA_SQL.Customer DROP CONSTRAINT FK_Customer_PersonalData


IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('TRANSA_SQL.FK_Customer_User') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE TRANSA_SQL.Customer DROP CONSTRAINT FK_Customer_User


IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('TRANSA_SQL.FK_CustomerCity_City') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE TRANSA_SQL.CustomerCity DROP CONSTRAINT FK_CustomerCity_City


IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('TRANSA_SQL.FK_GiftCard_Customer_origin') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE TRANSA_SQL.GiftCard DROP CONSTRAINT FK_GiftCard_Customer_origin


IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('TRANSA_SQL.FK_GiftCard_Customer_des') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE TRANSA_SQL.GiftCard DROP CONSTRAINT FK_GiftCard_Customer_des


IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('TRANSA_SQL.FK_PersonalData_User') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE TRANSA_SQL.PersonalData DROP CONSTRAINT FK_PersonalData_User


IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('TRANSA_SQL.FK_PublishedCouponBook_CouponBook') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE TRANSA_SQL.PublishedCouponBook DROP CONSTRAINT FK_PublishedCouponBook_CouponBook


IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('TRANSA_SQL.FK_Purchase_CouponBook') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE TRANSA_SQL.Purchase DROP CONSTRAINT FK_Purchase_CouponBook


IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('TRANSA_SQL.FK_Purchase_Customer') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE TRANSA_SQL.Purchase DROP CONSTRAINT FK_Purchase_Customer


IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('TRANSA_SQL.FK_Refund_CouponBook') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE TRANSA_SQL.Refund DROP CONSTRAINT FK_Refund_CouponBook


IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('TRANSA_SQL.FK_Refund_Customer') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE TRANSA_SQL.Refund DROP CONSTRAINT FK_Refund_Customer


IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('TRANSA_SQL.FK_Refund_Reason') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE TRANSA_SQL.Refund DROP CONSTRAINT FK_Refund_Reason


IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('TRANSA_SQL.FK_RolePermission_Permission') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE TRANSA_SQL.RolePermission DROP CONSTRAINT FK_RolePermission_Permission


IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('TRANSA_SQL.FK_Supplier_City') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE TRANSA_SQL.Supplier DROP CONSTRAINT FK_Supplier_City


IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('TRANSA_SQL.FK_Supplier_Entry') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE TRANSA_SQL.Supplier DROP CONSTRAINT FK_Supplier_Entry


IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('TRANSA_SQL.FK_Supplier_PersonalData') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE TRANSA_SQL.Supplier DROP CONSTRAINT FK_Supplier_PersonalData


IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('TRANSA_SQL.FK_Supplier_User') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE TRANSA_SQL.Supplier DROP CONSTRAINT FK_Supplier_User


IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('TRANSA_SQL.FK_ZonePerCouponBook_City') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE TRANSA_SQL.ZonePerCouponBook DROP CONSTRAINT FK_ZonePerCouponBook_City


IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('TRANSA_SQL.FK_ZonePerCouponBook_CouponBook') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE TRANSA_SQL.ZonePerCouponBook DROP CONSTRAINT FK_ZonePerCouponBook_CouponBook



--  Drop Tables, Stored Procedures and Views 

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('TRANSA_SQL.Bill') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE TRANSA_SQL.Bill


IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('TRANSA_SQL.Card') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE TRANSA_SQL.Card


IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('TRANSA_SQL.CardType') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE TRANSA_SQL.CardType


IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('TRANSA_SQL.City') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE TRANSA_SQL.City


IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('TRANSA_SQL.ConsumedCoupon') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE TRANSA_SQL.ConsumedCoupon


IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('TRANSA_SQL.CouponBook') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE TRANSA_SQL.CouponBook


IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('TRANSA_SQL.CreditLoad') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE TRANSA_SQL.CreditLoad


IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('TRANSA_SQL.CuponeteUser') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE TRANSA_SQL.CuponeteUser


IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('TRANSA_SQL.Customer') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE TRANSA_SQL.Customer


IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('TRANSA_SQL.CustomerCity') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE TRANSA_SQL.CustomerCity


IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('TRANSA_SQL.Entry') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE TRANSA_SQL.Entry


IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('TRANSA_SQL.GiftCard') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE TRANSA_SQL.GiftCard


IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('TRANSA_SQL.PaymentType') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE TRANSA_SQL.PaymentType


IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('TRANSA_SQL.Permission') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE TRANSA_SQL.Permission


IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('TRANSA_SQL.PersonalData') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE TRANSA_SQL.PersonalData


IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('TRANSA_SQL.PublishedCouponBook') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE TRANSA_SQL.PublishedCouponBook


IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('TRANSA_SQL.Purchase') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE TRANSA_SQL.Purchase


IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('TRANSA_SQL.Reason') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE TRANSA_SQL.Reason


IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('TRANSA_SQL.Refund') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE TRANSA_SQL.Refund


IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('TRANSA_SQL.Role') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE TRANSA_SQL.Role


IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('TRANSA_SQL.RolePermission') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE TRANSA_SQL.RolePermission


IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('TRANSA_SQL.Supplier') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE TRANSA_SQL.Supplier


IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('TRANSA_SQL.ZonePerCouponBook') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE TRANSA_SQL.ZonePerCouponBook



--  Create Tables 
CREATE TABLE TRANSA_SQL.Bill ( 
	BillId int identity(1,1)  NOT NULL,
	Number numeric(18),
	BillDate datetime,
	Amount money,
	SupplierId int
)


CREATE TABLE TRANSA_SQL.Card ( 
	CardId int identity(1,1)  NOT NULL,
	CustomerId int,
	Number nvarchar(10),
	CardTypeId tinyint
)


CREATE TABLE TRANSA_SQL.CardType ( 
	CardTypeId tinyint identity(1,1)  NOT NULL,
	Name nvarchar(20)
)


CREATE TABLE TRANSA_SQL.City ( 
	CityId int identity(1,1)  NOT NULL,
	Name nvarchar(255)
)


CREATE TABLE TRANSA_SQL.ConsumedCoupon ( 
	ConsumedCouponId int identity(1,1)  NOT NULL,
	ConsumedDate datetime,
	CouponBookId int,
	CustomerId int,
	BillId int
)


CREATE TABLE TRANSA_SQL.CouponBook ( 
	CouponBookId int identity(1,1)  NOT NULL,
	SupplierId int,
	CouponCode nvarchar(50),
	CouponDescription nvarchar(255),
	Stock numeric(18),
	MaximunAmountAllowed int,
	IssueDate datetime,
	OfferMaturityDate datetime,
	ConsumptionMaturityDate datetime,
	RealPrice numeric(18,2),
	FictitiousPrice numeric(18,2),
	PublishedCouponBookId int
)


CREATE TABLE TRANSA_SQL.CreditLoad ( 
	CreditLoadId int identity(1,1)  NOT NULL,
	CustomerId int,
	LoadDate datetime,
	PaymentTypeId tinyint,
	Amount numeric(18,2)    --  es un importe mayor a 15 
)


CREATE TABLE TRANSA_SQL.CuponeteUser ( 
	UserId int identity(1,1)  NOT NULL,
	Username nvarchar(255) NOT NULL,
	Password nvarchar(255) NOT NULL,
	FailedAttemps tinyint NOT NULL,
	RoleId int,
	Enabled bit,
	Deleted bit
)


CREATE TABLE TRANSA_SQL.Customer ( 
	CustomerId int identity(1,1)  NOT NULL,
	Dni numeric(18) NOT NULL,
	PhoneNumber numeric(18) NOT NULL,
	UserId int,
	FirstLogin bit,    --  indica si el usuario esta iniciando sesion por primera vez puesto que en ese caso se le debe pedir el ingreso de sus datos personales 
	Name nvarchar(255),
	Surname nvarchar(255),
	Birthday datetime,
	Amount money,    --  el valor inicial es 10 pesos 
	PersonalDataId int
)


CREATE TABLE TRANSA_SQL.CustomerCity ( 
	CustomerCityId int identity(1,1)  NOT NULL,
	CustomerId int NOT NULL,
	CityId int NOT NULL
)


CREATE TABLE TRANSA_SQL.Entry ( 
	EntryId int identity(1,1)  NOT NULL,
	Name nvarchar(100)
)


CREATE TABLE TRANSA_SQL.GiftCard ( 
	GiftCardId int identity(1,1)  NOT NULL,
	GiftDate datetime,
	Amount numeric(18,2),
	CustomerOriginId int,
	CustomerDestinityId int
)


CREATE TABLE TRANSA_SQL.PaymentType ( 
	PaymentTypeId tinyint identity(1,1)  NOT NULL,
	Name nvarchar(100)
)


CREATE TABLE TRANSA_SQL.Permission ( 
	PermissionId int identity(1,1)  NOT NULL,
	Name varchar(27)
)


CREATE TABLE TRANSA_SQL.PersonalData ( 
	PersonalDataId int identity(1,1)  NOT NULL,
	UserId int,
	Email nvarchar(255),
	PostalCode nvarchar(8),
	Address nvarchar(255)
)


CREATE TABLE TRANSA_SQL.PublishedCouponBook ( 
	PublishedCouponId int identity(1,1)  NOT NULL,
	PublishedDate datetime,
	CouponBookId int
)


CREATE TABLE TRANSA_SQL.Purchase ( 
	PurchaseId int identity(1,1)  NOT NULL,
	PurchaseDate datetime,
	CouponBookId int,
	CustomerId int
)


CREATE TABLE TRANSA_SQL.Reason ( 
	ReasonId int identity(1,1)  NOT NULL,
	Description nvarchar(255)
)


CREATE TABLE TRANSA_SQL.Refund ( 
	RefundId int identity(1,1)  NOT NULL,
	RefundDate datetime,
	CustomerId int,
	CouponBookId int,
	ReasonId int
)


CREATE TABLE TRANSA_SQL.Role ( 
	RoleId int identity(1,1)  NOT NULL,
	Name varchar(15),
	Enabled bit
)


CREATE TABLE TRANSA_SQL.RolePermission ( 
	RolePermissionId int identity(1,1)  NOT NULL,
	RoleId int NOT NULL,
	PermissionId int NOT NULL
)


CREATE TABLE TRANSA_SQL.Supplier ( 
	SupplierId int identity(1,1)  NOT NULL,
	CorporateName nvarchar(100) NOT NULL,
	Cuit nvarchar(20) NOT NULL,
	UserId int,
	PhoneNumber numeric(18),
	FirstLogin bit,
	CityId int,
	EntryId int,
	ContactName nvarchar(27),
	PersonalDataId int
)


CREATE TABLE TRANSA_SQL.ZonePerCouponBook ( 
	ZonePerCouponBookId int identity(1,1)  NOT NULL,
	CouponBookId int,
	CityId int
)



--  Create Indexes 
ALTER TABLE TRANSA_SQL.Bill
	ADD CONSTRAINT UQ_Bill_BillId UNIQUE (BillId)


ALTER TABLE TRANSA_SQL.Bill
	ADD CONSTRAINT UQ_Bill_Number UNIQUE (Number)


ALTER TABLE TRANSA_SQL.Card
	ADD CONSTRAINT UQ_Card_CardId UNIQUE (CardId)


ALTER TABLE TRANSA_SQL.CardType
	ADD CONSTRAINT UQ_CardType_CardTypeId UNIQUE (CardTypeId)


ALTER TABLE TRANSA_SQL.City
	ADD CONSTRAINT UQ_City_CityId UNIQUE (CityId)


ALTER TABLE TRANSA_SQL.ConsumedCoupon
	ADD CONSTRAINT UQ_ConsumedCoupon_ConsumedCouponId UNIQUE (ConsumedCouponId)


ALTER TABLE TRANSA_SQL.CouponBook
	ADD CONSTRAINT UQ_CouponBook_CouponBookId UNIQUE (CouponBookId)


ALTER TABLE TRANSA_SQL.CouponBook
	ADD CONSTRAINT UQ_CouponBook_CouponCode UNIQUE (CouponCode)


ALTER TABLE TRANSA_SQL.CreditLoad
	ADD CONSTRAINT UQ_CreditLoad_CreditLoadId UNIQUE (CreditLoadId)


ALTER TABLE TRANSA_SQL.CuponeteUser
	ADD CONSTRAINT UQ_User_UserId UNIQUE (UserId)


ALTER TABLE TRANSA_SQL.CuponeteUser
	ADD CONSTRAINT UQ_User_Username UNIQUE (Username)


ALTER TABLE TRANSA_SQL.Customer
	ADD CONSTRAINT UQ_Customer_CustomerId UNIQUE (CustomerId)


ALTER TABLE TRANSA_SQL.Customer
	ADD CONSTRAINT UQ_Customer_Dni UNIQUE (Dni)


ALTER TABLE TRANSA_SQL.Customer
	ADD CONSTRAINT UQ_Customer_PhoneNumber UNIQUE (PhoneNumber)


ALTER TABLE TRANSA_SQL.CustomerCity
	ADD CONSTRAINT UQ_CustomerCity_CustomerCityId UNIQUE (CustomerCityId)


ALTER TABLE TRANSA_SQL.Entry
	ADD CONSTRAINT UQ_Entry_EntryId UNIQUE (EntryId)


ALTER TABLE TRANSA_SQL.GiftCard
	ADD CONSTRAINT UQ_GiftCard_GiftCardId UNIQUE (GiftCardId)


ALTER TABLE TRANSA_SQL.PaymentType
	ADD CONSTRAINT UQ_PaymentType_PaymentTypeId UNIQUE (PaymentTypeId)


ALTER TABLE TRANSA_SQL.PersonalData
	ADD CONSTRAINT UQ_PersonalData_PersonalDataId UNIQUE (PersonalDataId)


ALTER TABLE TRANSA_SQL.PublishedCouponBook
	ADD CONSTRAINT UQ_PublishedCouponBook_PublishedCouponId UNIQUE (PublishedCouponId)


ALTER TABLE TRANSA_SQL.Purchase
	ADD CONSTRAINT UQ_Purchase_PurchaseId UNIQUE (PurchaseId)


ALTER TABLE TRANSA_SQL.Reason
	ADD CONSTRAINT UQ_Reason_ReasonId UNIQUE (ReasonId)


ALTER TABLE TRANSA_SQL.Refund
	ADD CONSTRAINT UQ_Refund_RefundId UNIQUE (RefundId)


ALTER TABLE TRANSA_SQL.Role
	ADD CONSTRAINT UQ_Role_RoleId UNIQUE (RoleId)


ALTER TABLE TRANSA_SQL.RolePermission
	ADD CONSTRAINT UQ_RolePermission_RolePermissionId UNIQUE (RolePermissionId)


ALTER TABLE TRANSA_SQL.Supplier
	ADD CONSTRAINT UQ_Supplier_CorporateName UNIQUE (CorporateName)


ALTER TABLE TRANSA_SQL.Supplier
	ADD CONSTRAINT UQ_Supplier_Cuit UNIQUE (Cuit)


ALTER TABLE TRANSA_SQL.Supplier
	ADD CONSTRAINT UQ_Supplier_SupplierId UNIQUE (SupplierId)


ALTER TABLE TRANSA_SQL.ZonePerCouponBook
	ADD CONSTRAINT UQ_ZonePerCouponBook_ZonePerCouponBookId UNIQUE (ZonePerCouponBookId)


--  Create Primary Key Constraints 
ALTER TABLE TRANSA_SQL.Bill ADD CONSTRAINT PK_Bill 
	PRIMARY KEY CLUSTERED (BillId)


ALTER TABLE TRANSA_SQL.Card ADD CONSTRAINT PK_Card 
	PRIMARY KEY CLUSTERED (CardId)


ALTER TABLE TRANSA_SQL.CardType ADD CONSTRAINT PK_CardType 
	PRIMARY KEY CLUSTERED (CardTypeId)


ALTER TABLE TRANSA_SQL.City ADD CONSTRAINT PK_City 
	PRIMARY KEY CLUSTERED (CityId)


ALTER TABLE TRANSA_SQL.ConsumedCoupon ADD CONSTRAINT PK_ConsumedCoupon 
	PRIMARY KEY CLUSTERED (ConsumedCouponId)


ALTER TABLE TRANSA_SQL.CouponBook ADD CONSTRAINT PK_CouponBook 
	PRIMARY KEY CLUSTERED (CouponBookId)


ALTER TABLE TRANSA_SQL.CreditLoad ADD CONSTRAINT PK_CreditLoad 
	PRIMARY KEY CLUSTERED (CreditLoadId)


ALTER TABLE TRANSA_SQL.CuponeteUser ADD CONSTRAINT PK_User 
	PRIMARY KEY CLUSTERED (UserId)


ALTER TABLE TRANSA_SQL.Customer ADD CONSTRAINT PK_Customer 
	PRIMARY KEY CLUSTERED (CustomerId)


ALTER TABLE TRANSA_SQL.CustomerCity ADD CONSTRAINT PK_CustomerCity 
	PRIMARY KEY CLUSTERED (CustomerCityId, CustomerId, CityId)


ALTER TABLE TRANSA_SQL.Entry ADD CONSTRAINT PK_Entry 
	PRIMARY KEY CLUSTERED (EntryId)


ALTER TABLE TRANSA_SQL.GiftCard ADD CONSTRAINT PK_GiftCard 
	PRIMARY KEY CLUSTERED (GiftCardId)


ALTER TABLE TRANSA_SQL.PaymentType ADD CONSTRAINT PK_PaymentType 
	PRIMARY KEY CLUSTERED (PaymentTypeId)


ALTER TABLE TRANSA_SQL.Permission ADD CONSTRAINT PK_Permission 
	PRIMARY KEY CLUSTERED (PermissionId)


ALTER TABLE TRANSA_SQL.PersonalData ADD CONSTRAINT PK_PersonalData 
	PRIMARY KEY CLUSTERED (PersonalDataId)


ALTER TABLE TRANSA_SQL.PublishedCouponBook ADD CONSTRAINT PK_PublishedCouponBook 
	PRIMARY KEY CLUSTERED (PublishedCouponId)


ALTER TABLE TRANSA_SQL.Purchase ADD CONSTRAINT PK_Purchase 
	PRIMARY KEY CLUSTERED (PurchaseId)


ALTER TABLE TRANSA_SQL.Reason ADD CONSTRAINT PK_Reason 
	PRIMARY KEY CLUSTERED (ReasonId)


ALTER TABLE TRANSA_SQL.Refund ADD CONSTRAINT PK_Refund 
	PRIMARY KEY CLUSTERED (RefundId)


ALTER TABLE TRANSA_SQL.Role ADD CONSTRAINT PK_Role 
	PRIMARY KEY CLUSTERED (RoleId)


ALTER TABLE TRANSA_SQL.RolePermission ADD CONSTRAINT PK_RolePermission 
	PRIMARY KEY CLUSTERED (RolePermissionId, RoleId, PermissionId)


ALTER TABLE TRANSA_SQL.Supplier ADD CONSTRAINT PK_Supplier 
	PRIMARY KEY CLUSTERED (SupplierId)


ALTER TABLE TRANSA_SQL.ZonePerCouponBook ADD CONSTRAINT PK_ZonePerCouponBook 
	PRIMARY KEY CLUSTERED (ZonePerCouponBookId)




--  Create Foreign Key Constraints 
ALTER TABLE TRANSA_SQL.Card ADD CONSTRAINT FK_Card_CardType 
	FOREIGN KEY (CardTypeId) REFERENCES TRANSA_SQL.CardType (CardTypeId)


ALTER TABLE TRANSA_SQL.Card ADD CONSTRAINT FK_Card_Customer 
	FOREIGN KEY (CustomerId) REFERENCES TRANSA_SQL.Customer (CustomerId)


ALTER TABLE TRANSA_SQL.ConsumedCoupon ADD CONSTRAINT FK_ConsumedCoupon_Bill 
	FOREIGN KEY (BillId) REFERENCES TRANSA_SQL.Bill (BillId)


ALTER TABLE TRANSA_SQL.ConsumedCoupon ADD CONSTRAINT FK_ConsumedCoupon_CouponBook 
	FOREIGN KEY (CouponBookId) REFERENCES TRANSA_SQL.CouponBook (CouponBookId)


ALTER TABLE TRANSA_SQL.ConsumedCoupon ADD CONSTRAINT FK_ConsumedCoupon_Customer 
	FOREIGN KEY (CustomerId) REFERENCES TRANSA_SQL.Customer (CustomerId)


ALTER TABLE TRANSA_SQL.CouponBook ADD CONSTRAINT FK_CouponBook_PublishedCouponBook 
	FOREIGN KEY (PublishedCouponBookId) REFERENCES TRANSA_SQL.PublishedCouponBook (PublishedCouponId)


ALTER TABLE TRANSA_SQL.CreditLoad ADD CONSTRAINT FK_CreditLoad_Customer 
	FOREIGN KEY (CustomerId) REFERENCES TRANSA_SQL.Customer (CustomerId)


ALTER TABLE TRANSA_SQL.CreditLoad ADD CONSTRAINT FK_CreditLoad_PaymentType 
	FOREIGN KEY (PaymentTypeId) REFERENCES TRANSA_SQL.PaymentType (PaymentTypeId)


ALTER TABLE TRANSA_SQL.Customer ADD CONSTRAINT FK_Customer_PersonalData 
	FOREIGN KEY (PersonalDataId) REFERENCES TRANSA_SQL.PersonalData (PersonalDataId)


ALTER TABLE TRANSA_SQL.Customer ADD CONSTRAINT FK_Customer_User 
	FOREIGN KEY (UserId) REFERENCES TRANSA_SQL.CuponeteUser (UserId)


ALTER TABLE TRANSA_SQL.CustomerCity ADD CONSTRAINT FK_CustomerCity_City 
	FOREIGN KEY (CityId) REFERENCES TRANSA_SQL.City (CityId)


ALTER TABLE TRANSA_SQL.GiftCard ADD CONSTRAINT FK_GiftCard_Customer_origin 
	FOREIGN KEY (CustomerOriginId) REFERENCES TRANSA_SQL.Customer (CustomerId)


ALTER TABLE TRANSA_SQL.PersonalData ADD CONSTRAINT FK_PersonalData_User 
	FOREIGN KEY (UserId) REFERENCES TRANSA_SQL.CuponeteUser (UserId)


ALTER TABLE TRANSA_SQL.PublishedCouponBook ADD CONSTRAINT FK_PublishedCouponBook_CouponBook 
	FOREIGN KEY (CouponBookId) REFERENCES TRANSA_SQL.CouponBook (CouponBookId)


ALTER TABLE TRANSA_SQL.Purchase ADD CONSTRAINT FK_Purchase_CouponBook 
	FOREIGN KEY (CouponBookId) REFERENCES TRANSA_SQL.CouponBook (CouponBookId)


ALTER TABLE TRANSA_SQL.Purchase ADD CONSTRAINT FK_Purchase_Customer 
	FOREIGN KEY (CustomerId) REFERENCES TRANSA_SQL.Customer (CustomerId)


ALTER TABLE TRANSA_SQL.Refund ADD CONSTRAINT FK_Refund_CouponBook 
	FOREIGN KEY (CouponBookId) REFERENCES TRANSA_SQL.CouponBook (CouponBookId)


ALTER TABLE TRANSA_SQL.Refund ADD CONSTRAINT FK_Refund_Customer 
	FOREIGN KEY (CustomerId) REFERENCES TRANSA_SQL.Customer (CustomerId)


ALTER TABLE TRANSA_SQL.Refund ADD CONSTRAINT FK_Refund_Reason 
	FOREIGN KEY (ReasonId) REFERENCES TRANSA_SQL.Reason (ReasonId)


ALTER TABLE TRANSA_SQL.RolePermission ADD CONSTRAINT FK_RolePermission_Permission 
	FOREIGN KEY (PermissionId) REFERENCES TRANSA_SQL.Permission (PermissionId)


ALTER TABLE TRANSA_SQL.Supplier ADD CONSTRAINT FK_Supplier_City 
	FOREIGN KEY (CityId) REFERENCES TRANSA_SQL.City (CityId)


ALTER TABLE TRANSA_SQL.Supplier ADD CONSTRAINT FK_Supplier_Entry 
	FOREIGN KEY (EntryId) REFERENCES TRANSA_SQL.Entry (EntryId)


ALTER TABLE TRANSA_SQL.Supplier ADD CONSTRAINT FK_Supplier_PersonalData 
	FOREIGN KEY (PersonalDataId) REFERENCES TRANSA_SQL.PersonalData (PersonalDataId)


ALTER TABLE TRANSA_SQL.Supplier ADD CONSTRAINT FK_Supplier_User 
	FOREIGN KEY (UserId) REFERENCES TRANSA_SQL.CuponeteUser (UserId)


ALTER TABLE TRANSA_SQL.ZonePerCouponBook ADD CONSTRAINT FK_ZonePerCouponBook_City 
	FOREIGN KEY (CityId) REFERENCES TRANSA_SQL.City (CityId)


ALTER TABLE TRANSA_SQL.ZonePerCouponBook ADD CONSTRAINT FK_ZonePerCouponBook_CouponBook 
	FOREIGN KEY (CouponBookId) REFERENCES TRANSA_SQL.CouponBook (CouponBookId)



/*migracion de datos*/
go
/*tabla role*/
insert into TRANSA_SQL.[Role](Name,[Enabled]) 
	values ('Administrator',1),('Customer',1),('Supplier',1)

/*tabla permisos*/
INSERT INTO TRANSA_SQL.Permission (Name) VALUES ('RoleCreate')
INSERT INTO TRANSA_SQL.Permission (Name) VALUES ('RoleDelete')
INSERT INTO TRANSA_SQL.Permission (Name) VALUES ('RoleUpdate')
INSERT INTO TRANSA_SQL.Permission (Name) VALUES ('CustomerCreate')
INSERT INTO TRANSA_SQL.Permission (Name) VALUES ('CustomerDelete')
INSERT INTO TRANSA_SQL.Permission (Name) VALUES ('CustomerUpdate')
INSERT INTO TRANSA_SQL.Permission (Name) VALUES ('SupplierCreate')
INSERT INTO TRANSA_SQL.Permission (Name) VALUES ('SupplierDelete')
INSERT INTO TRANSA_SQL.Permission (Name) VALUES ('SupplierUpdate')
INSERT INTO TRANSA_SQL.Permission (Name) VALUES ('CreditLoad')
INSERT INTO TRANSA_SQL.Permission (Name) VALUES ('BuyGiftCard')
INSERT INTO TRANSA_SQL.Permission (Name) VALUES ('BuyCoupon')
INSERT INTO TRANSA_SQL.Permission (Name) VALUES ('RequestRefound')
INSERT INTO TRANSA_SQL.Permission (Name) VALUES ('RequestCouponBuyedHistory')
INSERT INTO TRANSA_SQL.Permission (Name) VALUES ('CouponBookCreate')
INSERT INTO TRANSA_SQL.Permission (Name) VALUES ('RegisterConsumedCoupon')
INSERT INTO TRANSA_SQL.Permission (Name) VALUES ('PublishCouponBook')
INSERT INTO TRANSA_SQL.Permission (Name) VALUES ('SupplierInvoice')
INSERT INTO TRANSA_SQL.Permission (Name) VALUES ('StatisticalList')

/*tabla roles por permiso*/
INSERT INTO TRANSA_SQL.RolePermission (RoleId, PermissionId) 
VALUES 
	( 
	(SELECT RoleId FROM TRANSA_SQL.Role WHERE Name = 'Customer'),
	(SELECT PermissionId FROM TRANSA_SQL.Permission WHERE Name = 'CreditLoad')
	)

INSERT INTO TRANSA_SQL.RolePermission (RoleId, PermissionId) 
VALUES 
	( 
	(SELECT RoleId FROM TRANSA_SQL.Role WHERE Name = 'Customer'),
	(SELECT PermissionId FROM TRANSA_SQL.Permission WHERE Name = 'BuyGiftCard')
	)

INSERT INTO TRANSA_SQL.RolePermission (RoleId, PermissionId) 
VALUES 
	( 
	(SELECT RoleId FROM TRANSA_SQL.Role WHERE Name = 'Customer'),
	(SELECT PermissionId FROM TRANSA_SQL.Permission WHERE Name = 'BuyCoupon')
	)
	
INSERT INTO TRANSA_SQL.RolePermission (RoleId, PermissionId) 
VALUES 
	( 
	(SELECT RoleId FROM TRANSA_SQL.Role WHERE Name = 'Customer'),
	(SELECT PermissionId FROM TRANSA_SQL.Permission WHERE Name = 'RequestRefound')
	)
	
INSERT INTO TRANSA_SQL.RolePermission (RoleId, PermissionId) 
VALUES 
	(
	(SELECT RoleId FROM TRANSA_SQL.Role WHERE Name = 'Customer'),
	(SELECT PermissionId FROM TRANSA_SQL.Permission WHERE Name = 'RequestCouponBuyedHistory')
	)

INSERT INTO TRANSA_SQL.RolePermission (RoleId, PermissionId) 
VALUES 
	(
	(SELECT RoleId FROM TRANSA_SQL.Role WHERE Name = 'Supplier'),
	(SELECT PermissionId FROM TRANSA_SQL.Permission WHERE Name = 'CouponBookCreate')
	)
	
INSERT INTO TRANSA_SQL.RolePermission (RoleId, PermissionId) 
VALUES 
	(
	(SELECT RoleId FROM TRANSA_SQL.Role WHERE Name = 'Supplier'),
	(SELECT PermissionId FROM TRANSA_SQL.Permission WHERE Name = 'RegisterConsumedCoupon')
	)
	
INSERT INTO TRANSA_SQL.RolePermission (RoleId, PermissionId) 
VALUES 
	( 
	(SELECT RoleId FROM TRANSA_SQL.Role WHERE Name = 'Supplier'),
	(SELECT PermissionId FROM TRANSA_SQL.Permission WHERE Name = 'PublishCouponBook')
	)
	

/*tabla usuario*/

insert into TRANSA_SQL.CuponeteUser values ('admin','e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7',
											0,(select TRANSA_SQL.[Role].RoleId from TRANSA_SQL.[Role] where TRANSA_SQL.[Role].Name='Administrator'),1,0)

insert into TRANSA_SQL.CuponeteUser 
	select distinct gd_esquema.Maestra.Cli_Telefono, '47f5390d283f8cbcc8272dbc288b2cae42ec57d13cb8abea14cd7754f2be57dd',
					0,TRANSA_SQL.[Role].RoleId,1,0
		from gd_esquema.Maestra, TRANSA_SQL.[Role]
		where gd_esquema.Maestra.Cli_Telefono is not null and 
					TRANSA_SQL.[Role].Name='Customer'
		

insert into TRANSA_SQL.CuponeteUser 
	select distinct gd_esquema.Maestra.Provee_CUIT, '47f5390d283f8cbcc8272dbc288b2cae42ec57d13cb8abea14cd7754f2be57dd',
					0,TRANSA_SQL.[Role].RoleId,1,0
		from gd_esquema.Maestra, TRANSA_SQL.[Role]
		where gd_esquema.Maestra.Provee_CUIT is not null and 
					TRANSA_SQL.[Role].Name='Supplier'
/*tabla personalData*/
/*para los clientes*/

insert into TRANSA_SQL.PersonalData 
select distinct TRANSA_SQL.CuponeteUser.UserId, gd_esquema.Maestra.Cli_Mail,null,gd_esquema.Maestra.Cli_Direccion
	from TRANSA_SQL.CuponeteUser join gd_esquema.Maestra on TRANSA_SQL.CuponeteUser.Username=convert(nvarchar(50),gd_esquema.Maestra.Cli_Telefono)
/*para los proveedores*/

insert into TRANSA_SQL.PersonalData
select distinct TRANSA_SQL.CuponeteUser.UserId,null,null,gd_esquema.Maestra.Provee_Dom
	from TRANSA_SQL.CuponeteUser join gd_esquema.Maestra on TRANSA_SQL.CuponeteUser.Username=convert(nvarchar(50),gd_esquema.Maestra.Provee_CUIT)
/*tabla de ciudades*/

insert into TRANSA_SQL.City
		select gd_esquema.Maestra.Cli_Ciudad
			from gd_esquema.Maestra
			where gd_esquema.Maestra.Cli_Ciudad is not null
		union select gd_esquema.Maestra.Provee_Ciudad
				from gd_esquema.Maestra
				where gd_esquema.Maestra.Provee_Ciudad is not null

/*tabla rubros*/
insert into TRANSA_SQL.Entry
	select distinct maestra.Provee_Rubro
	from gd_esquema.Maestra maestra
	where maestra.Provee_Rubro is not null

/*tabla proveedores*/
insert into TRANSA_SQL.Supplier
select distinct maestra.Provee_RS,maestra.Provee_CUIT,Cusr.UserId,maestra.Provee_Telefono,1,city.CityId,TRANSA_SQL.Entry.EntryId,null,perD.PersonalDataId
from gd_esquema.Maestra maestra join TRANSA_SQL.CuponeteUser Cusr on Cusr.Username= convert(nvarchar(50),maestra.Provee_CUIT) 
		join TRANSA_SQL.City city on maestra.Provee_Ciudad=city.Name 
			join TRANSA_SQL.PersonalData perD on Cusr.UserId=perD.UserId join TRANSA_SQL.Entry on TRANSA_SQL.Entry.Name=maestra.Provee_Rubro


/*tabla cuponBook y publicacionDeCuponBook*/
insert into TRANSA_SQL.CouponBook
	select distinct supplier.SupplierId,maestra.Groupon_Codigo,maestra.Groupon_Descripcion,maestra.Groupon_Cantidad,null,maestra.Groupon_Fecha,maestra.Groupon_Fecha_Venc,null,maestra.Groupon_Precio,maestra.Groupon_Precio_Ficticio,null
	from gd_esquema.Maestra maestra join TRANSA_SQL.Supplier supplier on supplier.Cuit=maestra.Provee_CUIT

insert into TRANSA_SQL.PublishedCouponBook
	select TRANSA_SQL.CouponBook.IssueDate, TRANSA_SQL.CouponBook.CouponBookId
	from TRANSA_SQL.CouponBook

update TRANSA_SQL.CouponBook
	set PublishedCouponBookId=TRANSA_SQL.PublishedCouponBook.PublishedCouponId
	from TRANSA_SQL.PublishedCouponBook
	where TRANSA_SQL.PublishedCouponBook.CouponBookId=TRANSA_SQL.CouponBook.CouponBookId

/*tabla zonePerCouponBook*/
insert into TRANSA_SQL.ZonePerCouponBook
	select distinct couponBook.CouponBookId, city.CityId 
	from gd_esquema.Maestra maestra join TRANSA_SQL.CouponBook couponBook on maestra.Groupon_Codigo=couponBook.CouponCode join TRANSA_SQL.City city on city.Name=maestra.Cli_Ciudad
	order by couponBook.CouponBookId
	
/*tabla clientes */
insert into TRANSA_SQL.Customer
	select distinct maestra.Cli_Dni,maestra.Cli_Telefono,usr.UserId,1,maestra.Cli_Nombre,maestra.Cli_Apellido,maestra.Cli_Fecha_Nac,0,persD.PersonalDataId
	from gd_esquema.Maestra maestra join TRANSA_SQL.CuponeteUser usr on usr.Username=CONVERT(nvarchar(50), maestra.Cli_Telefono) join TRANSA_SQL.PersonalData persD on persD.UserId=usr.UserId


/*tabla tipoPago*/
insert into TRANSA_SQL.PaymentType
	select distinct m.Tipo_Pago_Desc
	from gd_esquema.Maestra m
	where m.Tipo_Pago_Desc is not null

/*tabla creditLoad*/
insert into TRANSA_SQL.CreditLoad
	select cli.CustomerId,m.Carga_Fecha,pt.PaymentTypeId, m.Carga_Credito
	from gd_esquema.Maestra m join  TRANSA_SQL.Customer cli on cli.PhoneNumber=m.Cli_Telefono join TRANSA_SQL.PaymentType pt on m.Tipo_Pago_Desc=pt.Name
	where m.Carga_Credito is not null

/*Tabla CardType*/
INSERT INTO TRANSA_SQL.CardType(Name) VALUES ('Crédito')
INSERT INTO TRANSA_SQL.CardType(Name) VALUES ('Debito')

/*Tabla Card*/
--	EN EL GRUPO DICE QUE ESTOS DATOS DEBEN ESTAR EN NULL Y QUE EL CLIENTE LOS INGRESA EN EL PRIMER LOGIN
/*INSERT INTO TRANSA_SQL.Card
	SELECT DISTINCT C.CustomerId, '1234123412341234', (SELECT CardTypeId FROM TRANSA_SQL.CardType WHERE Name='Credito') AS 'CardTypeId'
	FROM TRANSA_SQL.Customer C JOIN gd_esquema.Maestra M ON C.PhoneNumber = M.Cli_Telefono
	WHERE M.Tipo_Pago_Desc='Cr\E9dito'
	ORDER BY C.CustomerId ASC
*/	
/*tabla purchase*/
insert into TRANSA_SQL.Purchase
	select m.Groupon_Fecha_Compra,cb.CouponBookId,cli.CustomerId
	from gd_esquema.Maestra m join TRANSA_SQL.Customer cli on cli.PhoneNumber=m.Cli_Telefono join TRANSA_SQL.CouponBook cb on cb.CouponCode=m.Groupon_Codigo
	where m.Groupon_Fecha_Compra is not null and m.Groupon_Devolucion_Fecha is null and m.Groupon_Entregado_Fecha is null 
	
/*tabla customerCity*/
insert into TRANSA_SQL.CustomerCity
	select distinct cli.CustomerId,c.CityId
	from gd_esquema.Maestra m join TRANSA_SQL.Customer cli on  m.Cli_Telefono=cli.PhoneNumber join TRANSA_SQL.City c on m.Cli_Ciudad=c.Name

/*tabla giftcard*/
insert into TRANSA_SQL.GiftCard
	select m.GiftCard_Fecha,m.GiftCard_Monto,cli.CustomerId,clid.CustomerId
	from gd_esquema.Maestra m join TRANSA_SQL.Customer cli on cli.PhoneNumber=m.Cli_Telefono join TRANSA_SQL.Customer clid on m.Cli_Dest_Telefono=clid.PhoneNumber
	where m.GiftCard_Fecha is not null
	order by 3,4
	
/*tabla Reason (AGREGAR MAS POSIBLES RAZONES)*/
--POSIBLEMENTE ESTO NO TENGA QUE ESTAR
/*insert into TRANSA_SQL.Reason values
	('no se cumplian los terminos y condiciones'),('el local fundio'),('No puede asistir el cliente'),('motivos varios')
*/
/*tabla refund*/--LA RAZON ESTA EN NULL PUES NO LA TENEMOS Y NO SE PUEDE INVENTAR
insert into TRANSA_SQL.Refund
	select m.Groupon_Devolucion_Fecha,cli.CustomerId,cb.CouponBookId,NULL
	from gd_esquema.Maestra m join TRANSA_SQL.Customer cli on cli.PhoneNumber=m.Cli_Telefono join TRANSA_SQL.CouponBook cb on cb.CouponCode=m.Groupon_Codigo
	where m.Groupon_Devolucion_Fecha is not null


/*tabla bill*/
--SE FACTURA EL 50% DEL CUPON DICE EN EL GRUPO
insert into TRANSA_SQL.Bill
	select m.Factura_Nro,m.Factura_Fecha,sum(0.5*Groupon_Precio), s.SupplierId
		from gd_esquema.Maestra m join TRANSA_SQL.CouponBook cb on cb.CouponCode=m.Groupon_Codigo join TRANSA_SQL.Supplier s on s.Cuit=m.Provee_CUIT
		where m.Factura_Nro is not null
		group by m.Factura_Nro,m.Factura_Fecha,s.SupplierId
		
/*tabla ConsumedCoupon*/
--SE ARREGLO EL ERROR
insert into TRANSA_SQL.ConsumedCoupon
	select m.Groupon_Entregado_Fecha,cb.CouponBookId,cli.CustomerId,null
	from TRANSA_SQL.CouponBook cb join gd_esquema.Maestra m on m.Groupon_Codigo=cb.CouponCode join TRANSA_SQL.Customer cli on cli.PhoneNumber=m.Cli_Telefono 
	where m.Groupon_Entregado_Fecha is not null 
update TRANSA_SQL.ConsumedCoupon set BillId=b.BillId
from TRANSA_SQL.ConsumedCoupon cc join TRANSA_SQL.CouponBook cb on cb.CouponBookId=cc.CouponBookId join TRANSA_SQL.Bill b on b.SupplierId=cb.SupplierId
where cc.CouponBookId=cb.CouponBookId

--actualiza saldo por gifcard recibida	
update TRANSA_SQL.Customer set Amount+=(select sum(gift.Amount)  from TRANSA_SQL.GiftCard gift join TRANSA_SQL.Customer cli on gift.CustomerDestinityId=cli.CustomerId where g.CustomerDestinityId=gift.CustomerDestinityId group by gift.CustomerDestinityId)
	from TRANSA_SQL.GiftCard g
	where g.CustomerDestinityId=TRANSA_SQL.Customer.CustomerId

--actualiza saldo por compras
update TRANSA_SQL.Customer set Amount-=(select sum(cb.RealPrice)  from TRANSA_SQL.Purchase pur join TRANSA_SQL.CouponBook cb on cb.CouponBookId=pur.CouponBookId where pur.CustomerId=p.CustomerId group by pur.CustomerId)
	from TRANSA_SQL.Purchase p
	where p.CustomerId=TRANSA_SQL.Customer.CustomerId
--actualiza saldo por devoluciones
update TRANSA_SQL.Customer set Amount+=(select sum(cb.RealPrice)  from TRANSA_SQL.Refund ref join TRANSA_SQL.CouponBook cb on cb.CouponBookId=ref.CouponBookId where ref.CustomerId=dev.CustomerId group by ref.CustomerId)
	from TRANSA_SQL.Refund dev 
	where dev.CustomerId=TRANSA_SQL.Customer.CustomerId
--actualizacion por carga de saldos
update TRANSA_SQL.Customer set TRANSA_SQL.Customer.Amount+=(select sum(cred.Amount) from TRANSA_SQL.CreditLoad cred where cred.CustomerId=cre.CustomerId group by cred.CustomerId)
	from TRANSA_SQL.CreditLoad cre
			where cre.CustomerId=TRANSA_SQL.Customer.CustomerId	


/*triggers*/
--actualizacion de saldo por carga de credito
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'TRANSA_SQL.actsaldocarga'))
DROP TRIGGER TRANSA_SQL.actsaldocarga

go

create trigger TRANSA_SQL.actsaldocarga on TRANSA_SQL.CreditLoad
for insert as begin
	update TRANSA_SQL.Customer set Amount+=i.Amount
	from inserted i
	where i.CustomerId=TRANSA_SQL.Customer.CustomerId
	end

--REGALO DE 10 PESOS
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'TRANSA_SQL.regaloCredDeBienvenida'))
DROP TRIGGER TRANSA_SQL.regaloCredDeBienvenida

go
create trigger TRANSA_SQL.regaloCredDeBienvenida on TRANSA_SQL.Customer
for insert as begin
	update TRANSA_SQL.Customer set Amount+=10
	from inserted i
	where i.CustomerId=TRANSA_SQL.Customer.CustomerId
end

/*Stored Procedures*/
go
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'TRANSA_SQL.eliminacionDelCliente'))
DROP procedure TRANSA_SQL.eliminacionDelCliente
go
create procedure TRANSA_SQL.eliminacionDelCliente
					@Name nvarchar(255),
					@Surname nvarchar(255),
					@Dni numeric(18,0),
					@Email nvarchar(255)
as begin
	update TRANSA_SQL.CuponeteUser set Deleted=1
	from TRANSA_SQL.CuponeteUser cu,(select cli.UserId, cli.Name,cli.Surname,cli.Dni,per.Email
												from TRANSA_SQL.Customer cli join TRANSA_SQL.PersonalData per on per.PersonalDataId=cli.PersonalDataId) cli
	where cu.UserId=cli.UserId and cli.Dni=@Dni and cli.Email=@Email and cli.Name=@Name and cli.Surname=@Surname
end
go
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'TRANSA_SQL.altaDelCliente'))
DROP procedure TRANSA_SQL.altaDelCliente
go
create procedure TRANSA_SQL.altaDelCliente
					@Name nvarchar(255),
					@Surname nvarchar(255),
					@Dni numeric(18,0),
					@Email nvarchar(255)
as begin
	update TRANSA_SQL.CuponeteUser set [Enabled]=1
	from TRANSA_SQL.CuponeteUser cu,(select cli.UserId, cli.Name,cli.Surname,cli.Dni,per.Email
												from TRANSA_SQL.Customer cli join TRANSA_SQL.PersonalData per on per.PersonalDataId=cli.PersonalDataId) cli
	where cu.UserId=cli.UserId and cli.Dni=@Dni and cli.Email=@Email and cli.Name=@Name and cli.Surname=@Surname
end
go
