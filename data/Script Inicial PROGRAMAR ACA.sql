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
	CouponCode nvarchar(50),
	CustomerId int,
	BillId int
)


CREATE TABLE TRANSA_SQL.CouponBook ( 
	CouponBookId int identity(1,1)  NOT NULL,
	SupplierId int,
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
	FirstLogin bit,    --  indica si el usuario esta iniciando sesion por primera vez puesto que en ese caso se le debe pedir el ingreso de sus datos personales 
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
	PermissionId int /*identity(1,1)*/  NOT NULL,
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
	CouponCode nvarchar(50),
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
	CouponCode nvarchar(50),
	ReasonId int
)


CREATE TABLE TRANSA_SQL.Role ( 
	RoleId int /*identity(1,1)*/  NOT NULL,
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

ALTER TABLE TRANSA_SQL.Permission
	ADD CONSTRAINT UQ_Permission_PermissionId UNIQUE (PermissionId)


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
insert into TRANSA_SQL.[Role] 
	values (1,'Administrator',1),(2,'Customer',1),(3,'Supplier',1)

/*tabla permisos*/
INSERT INTO TRANSA_SQL.Permission  VALUES (1,'RoleCreate')
INSERT INTO TRANSA_SQL.Permission  VALUES (2,'RoleDelete')
INSERT INTO TRANSA_SQL.Permission  VALUES (3,'RoleUpdate')
INSERT INTO TRANSA_SQL.Permission  VALUES (4,'CustomerCreate')
INSERT INTO TRANSA_SQL.Permission  VALUES (5,'CustomerDelete')
INSERT INTO TRANSA_SQL.Permission  VALUES (6,'CustomerUpdate')
INSERT INTO TRANSA_SQL.Permission  VALUES (7,'SupplierCreate')
INSERT INTO TRANSA_SQL.Permission  VALUES (8,'SupplierDelete')
INSERT INTO TRANSA_SQL.Permission  VALUES (9,'SupplierUpdate')
INSERT INTO TRANSA_SQL.Permission  VALUES (10,'CreditLoad')
INSERT INTO TRANSA_SQL.Permission  VALUES (11,'BuyGiftCard')
INSERT INTO TRANSA_SQL.Permission  VALUES (12,'BuyCoupon')
INSERT INTO TRANSA_SQL.Permission  VALUES (13,'RequestRefound')
INSERT INTO TRANSA_SQL.Permission  VALUES (14,'RequestCouponBuyedHistory')
INSERT INTO TRANSA_SQL.Permission  VALUES (15,'CouponBookCreate')
INSERT INTO TRANSA_SQL.Permission  VALUES (16,'RegisterConsumedCoupon')
INSERT INTO TRANSA_SQL.Permission  VALUES (17,'PublishCouponBook')
INSERT INTO TRANSA_SQL.Permission  VALUES (18,'SupplierInvoice')
INSERT INTO TRANSA_SQL.Permission  VALUES (19,'StatisticalList')

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
	(SELECT RoleId FROM TRANSA_SQL.Role WHERE Name = 'Administrator'),
	(SELECT PermissionId FROM TRANSA_SQL.Permission WHERE Name = 'CreditLoad')
	)

INSERT INTO TRANSA_SQL.RolePermission (RoleId, PermissionId) 
VALUES 
	( 
	(SELECT RoleId FROM TRANSA_SQL.Role WHERE Name = 'Administrator'),
	(SELECT PermissionId FROM TRANSA_SQL.Permission WHERE Name = 'BuyGiftCard')
	)

INSERT INTO TRANSA_SQL.RolePermission (RoleId, PermissionId) 
VALUES 
	( 
	(SELECT RoleId FROM TRANSA_SQL.Role WHERE Name = 'Administrator'),
	(SELECT PermissionId FROM TRANSA_SQL.Permission WHERE Name = 'BuyCoupon')
	)
	
INSERT INTO TRANSA_SQL.RolePermission (RoleId, PermissionId) 
VALUES 
	( 
	(SELECT RoleId FROM TRANSA_SQL.Role WHERE Name = 'Administrator'),
	(SELECT PermissionId FROM TRANSA_SQL.Permission WHERE Name = 'RequestRefound')
	)
	
INSERT INTO TRANSA_SQL.RolePermission (RoleId, PermissionId) 
VALUES 
	(
	(SELECT RoleId FROM TRANSA_SQL.Role WHERE Name = 'Administrator'),
	(SELECT PermissionId FROM TRANSA_SQL.Permission WHERE Name = 'RequestCouponBuyedHistory')
	)

INSERT INTO TRANSA_SQL.RolePermission (RoleId, PermissionId) 
VALUES 
	(
	(SELECT RoleId FROM TRANSA_SQL.Role WHERE Name = 'Administrator'),
	(SELECT PermissionId FROM TRANSA_SQL.Permission WHERE Name = 'CouponBookCreate')
	)
	
INSERT INTO TRANSA_SQL.RolePermission (RoleId, PermissionId) 
VALUES 
	(
	(SELECT RoleId FROM TRANSA_SQL.Role WHERE Name = 'Administrator'),
	(SELECT PermissionId FROM TRANSA_SQL.Permission WHERE Name = 'RegisterConsumedCoupon')
	)
	
INSERT INTO TRANSA_SQL.RolePermission (RoleId, PermissionId) 
VALUES 
	( 
	(SELECT RoleId FROM TRANSA_SQL.Role WHERE Name = 'Administrator'),
	(SELECT PermissionId FROM TRANSA_SQL.Permission WHERE Name = 'PublishCouponBook')
	)

INSERT INTO TRANSA_SQL.RolePermission (RoleId, PermissionId) 
VALUES 
	( 
	(SELECT RoleId FROM TRANSA_SQL.Role WHERE Name = 'Administrator'),
	(SELECT PermissionId FROM TRANSA_SQL.Permission WHERE Name = 'RoleCreate')
	)INSERT INTO TRANSA_SQL.RolePermission (RoleId, PermissionId) 
VALUES 
	( 
	(SELECT RoleId FROM TRANSA_SQL.Role WHERE Name = 'Administrator'),
	(SELECT PermissionId FROM TRANSA_SQL.Permission WHERE Name = 'RoleDelete')
	)
	
	INSERT INTO TRANSA_SQL.RolePermission (RoleId, PermissionId) 
VALUES 
	( 
	(SELECT RoleId FROM TRANSA_SQL.Role WHERE Name = 'Administrator'),
	(SELECT PermissionId FROM TRANSA_SQL.Permission WHERE Name = 'RoleUpdate')
	)
	INSERT INTO TRANSA_SQL.RolePermission (RoleId, PermissionId) 
VALUES 
	( 
	(SELECT RoleId FROM TRANSA_SQL.Role WHERE Name = 'Administrator'),
	(SELECT PermissionId FROM TRANSA_SQL.Permission WHERE Name = 'CustomerCreate')
	)
	INSERT INTO TRANSA_SQL.RolePermission (RoleId, PermissionId) 
VALUES 
	( 
	(SELECT RoleId FROM TRANSA_SQL.Role WHERE Name = 'Administrator'),
	(SELECT PermissionId FROM TRANSA_SQL.Permission WHERE Name = 'CustomerDelete')
	)
	INSERT INTO TRANSA_SQL.RolePermission (RoleId, PermissionId) 
VALUES 
	( 
	(SELECT RoleId FROM TRANSA_SQL.Role WHERE Name = 'Administrator'),
	(SELECT PermissionId FROM TRANSA_SQL.Permission WHERE Name = 'CustomerUpdate')
	)
	INSERT INTO TRANSA_SQL.RolePermission (RoleId, PermissionId) 
VALUES 
	( 
	(SELECT RoleId FROM TRANSA_SQL.Role WHERE Name = 'Administrator'),
	(SELECT PermissionId FROM TRANSA_SQL.Permission WHERE Name = 'SupplierCreate')
	)
	INSERT INTO TRANSA_SQL.RolePermission (RoleId, PermissionId) 
VALUES 
	( 
	(SELECT RoleId FROM TRANSA_SQL.Role WHERE Name = 'Administrator'),
	(SELECT PermissionId FROM TRANSA_SQL.Permission WHERE Name = 'SupplierDelete')
	)
	INSERT INTO TRANSA_SQL.RolePermission (RoleId, PermissionId) 
VALUES 
	( 
	(SELECT RoleId FROM TRANSA_SQL.Role WHERE Name = 'Administrator'),
	(SELECT PermissionId FROM TRANSA_SQL.Permission WHERE Name = 'SupplierUpdate')
	)
	INSERT INTO TRANSA_SQL.RolePermission (RoleId, PermissionId) 
VALUES 
	( 
	(SELECT RoleId FROM TRANSA_SQL.Role WHERE Name = 'Administrator'),
	(SELECT PermissionId FROM TRANSA_SQL.Permission WHERE Name = 'SupplierInvoice')
	)
INSERT INTO TRANSA_SQL.RolePermission (RoleId, PermissionId) 
VALUES 
	( 
	(SELECT RoleId FROM TRANSA_SQL.Role WHERE Name = 'Administrator'),
	(SELECT PermissionId FROM TRANSA_SQL.Permission WHERE Name = 'StatisticalList')
	)
	

/*tabla usuario*/

insert into TRANSA_SQL.CuponeteUser values ('admin','e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7',
											0,0,(select TRANSA_SQL.[Role].RoleId from TRANSA_SQL.[Role] where TRANSA_SQL.[Role].Name='Administrator'),1,0)

insert into TRANSA_SQL.CuponeteUser 
	select distinct gd_esquema.Maestra.Cli_Telefono, '47f5390d283f8cbcc8272dbc288b2cae42ec57d13cb8abea14cd7754f2be57dd',
					1,0,TRANSA_SQL.[Role].RoleId,1,0
		from gd_esquema.Maestra, TRANSA_SQL.[Role]
		where gd_esquema.Maestra.Cli_Telefono is not null and 
					TRANSA_SQL.[Role].Name='Customer'
		

insert into TRANSA_SQL.CuponeteUser 
	select distinct gd_esquema.Maestra.Provee_CUIT, '47f5390d283f8cbcc8272dbc288b2cae42ec57d13cb8abea14cd7754f2be57dd',
					1,0,TRANSA_SQL.[Role].RoleId,1,0
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
select distinct maestra.Provee_RS,maestra.Provee_CUIT,Cusr.UserId,maestra.Provee_Telefono,city.CityId,TRANSA_SQL.Entry.EntryId,null,perD.PersonalDataId
from gd_esquema.Maestra maestra join TRANSA_SQL.CuponeteUser Cusr on Cusr.Username= convert(nvarchar(50),maestra.Provee_CUIT) 
		join TRANSA_SQL.City city on maestra.Provee_Ciudad=city.Name 
			join TRANSA_SQL.PersonalData perD on Cusr.UserId=perD.UserId join TRANSA_SQL.Entry on TRANSA_SQL.Entry.Name=maestra.Provee_Rubro


/*tabla cuponBook y publicacionDeCuponBook*/
insert into TRANSA_SQL.CouponBook
	select distinct supplier.SupplierId,maestra.Groupon_Descripcion,maestra.Groupon_Cantidad,null,maestra.Groupon_Fecha,maestra.Groupon_Fecha_Venc,null,maestra.Groupon_Precio,maestra.Groupon_Precio_Ficticio,null
	from gd_esquema.Maestra maestra join TRANSA_SQL.Supplier supplier on supplier.Cuit=maestra.Provee_CUIT
	group by supplier.SupplierId,maestra.Groupon_Descripcion,maestra.Groupon_Cantidad,maestra.Groupon_Fecha,maestra.Groupon_Fecha_Venc,maestra.Groupon_Precio,maestra.Groupon_Precio_Ficticio

insert into TRANSA_SQL.PublishedCouponBook
	select TRANSA_SQL.CouponBook.IssueDate, TRANSA_SQL.CouponBook.CouponBookId
	from TRANSA_SQL.CouponBook

update TRANSA_SQL.CouponBook
	set PublishedCouponBookId=TRANSA_SQL.PublishedCouponBook.PublishedCouponId
	from TRANSA_SQL.PublishedCouponBook
	where TRANSA_SQL.PublishedCouponBook.CouponBookId=TRANSA_SQL.CouponBook.CouponBookId

/*tabla zonePerCouponBook*/
insert into TRANSA_SQL.ZonePerCouponBook
	select distinct cb.CouponBookId, city.CityId 
	from TRANSA_SQL.CouponBook cb join TRANSA_SQL.Supplier su on su.SupplierId=cb.SupplierId join gd_esquema.Maestra m on m.Groupon_Descripcion=cb.CouponDescription and m.Groupon_Fecha=cb.IssueDate and m.Groupon_Precio=cb.RealPrice and m.Groupon_Precio_Ficticio=cb.FictitiousPrice and m.Groupon_Cantidad=cb.Stock and su.Cuit=m.Provee_CUIT join TRANSA_SQL.City city on city.Name=m.Cli_Ciudad
	order by cb.CouponBookId
	
/*tabla clientes */
insert into TRANSA_SQL.Customer
	select distinct maestra.Cli_Dni,maestra.Cli_Telefono,usr.UserId,maestra.Cli_Nombre,maestra.Cli_Apellido,maestra.Cli_Fecha_Nac,0,persD.PersonalDataId
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


/*tabla purchase*/
insert into TRANSA_SQL.Purchase
	select distinct m.Groupon_Fecha_Compra,cb.CouponBookId,m.Groupon_Codigo,cli.CustomerId
	from TRANSA_SQL.CouponBook cb join TRANSA_SQL.Supplier su on su.SupplierId=cb.SupplierId join gd_esquema.Maestra m on m.Groupon_Descripcion=cb.CouponDescription and m.Groupon_Fecha=cb.IssueDate and m.Groupon_Fecha_Venc=cb.OfferMaturityDate and m.Groupon_Precio=cb.RealPrice and m.Groupon_Precio_Ficticio=cb.FictitiousPrice and m.Groupon_Cantidad=cb.Stock and su.Cuit=m.Provee_CUIT join TRANSA_SQL.Customer cli on cli.PhoneNumber=m.Cli_Telefono
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
	

/*tabla refund*/--LA RAZON ESTA EN NULL PUES NO LA TENEMOS Y NO SE PUEDE INVENTAR
insert into TRANSA_SQL.Refund
	--por ahi tenemos que meter un distinct
	select m.Groupon_Devolucion_Fecha,cli.CustomerId,cb.CouponBookId,m.Groupon_Codigo,NULL
	from TRANSA_SQL.CouponBook cb join TRANSA_SQL.Supplier su on su.SupplierId=cb.SupplierId join gd_esquema.Maestra m on m.Groupon_Fecha_Venc=cb.OfferMaturityDate and m.Groupon_Descripcion=cb.CouponDescription and m.Groupon_Fecha=cb.IssueDate and m.Groupon_Precio=cb.RealPrice and m.Groupon_Precio_Ficticio=cb.FictitiousPrice and m.Groupon_Cantidad=cb.Stock and su.Cuit=m.Provee_CUIT join TRANSA_SQL.Customer cli on cli.PhoneNumber=m.Cli_Telefono 
	where m.Groupon_Devolucion_Fecha is not null

/*tabla ConsumedCoupon*/
--SE ARREGLO EL ERROR
insert into TRANSA_SQL.ConsumedCoupon
--por ahi tenemos que meter un distinct	
	select m.Groupon_Entregado_Fecha,cb.CouponBookId,m.Groupon_Codigo,cli.CustomerId,null
	from TRANSA_SQL.CouponBook cb join TRANSA_SQL.Supplier su on su.SupplierId=cb.SupplierId join gd_esquema.Maestra m on m.Groupon_Fecha_Venc=cb.OfferMaturityDate and m.Groupon_Descripcion=cb.CouponDescription and m.Groupon_Fecha=cb.IssueDate and m.Groupon_Precio=cb.RealPrice and m.Groupon_Precio_Ficticio=cb.FictitiousPrice and m.Groupon_Cantidad=cb.Stock and su.Cuit=m.Provee_CUIT join TRANSA_SQL.Customer cli on cli.PhoneNumber=m.Cli_Telefono 
	where m.Groupon_Entregado_Fecha is not null


/*tabla bill*/
--SE FACTURA EL 50% DEL CUPON DICE EN EL GRUPO
insert into TRANSA_SQL.Bill
	select m.Factura_Nro,m.Factura_Fecha,sum(0.5*m.Groupon_Precio), s.SupplierId
		from gd_esquema.Maestra m join TRANSA_SQL.Supplier s on s.Cuit=m.Provee_CUIT
		where m.Factura_Nro is not null
		group by m.Factura_Nro,m.Factura_Fecha,s.SupplierId
		
update TRANSA_SQL.ConsumedCoupon set BillId=b.BillId
from gd_esquema.Maestra m join TRANSA_SQL.Bill b on b.Number=m.Factura_Nro join TRANSA_SQL.Supplier s on s.SupplierId=b.SupplierId
where m.Factura_Nro is not null and TRANSA_SQL.ConsumedCoupon.CouponCode=m.Groupon_Codigo and s.Cuit=m.Provee_CUIT

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
go
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'TRANSA_SQL.actsaldogift'))
DROP TRIGGER TRANSA_SQL.actsaldogift

go

create trigger TRANSA_SQL.actsaldogift on TRANSA_SQL.GiftCard
for insert as begin
	update TRANSA_SQL.Customer set Amount-=i.Amount
	from inserted i
	where i.CustomerOriginId=CustomerId
	
	update TRANSA_SQL.Customer set Amount+=i.Amount
	from inserted i
	where i.CustomerDestinityId=CustomerId
	
	
	end
go
--REGALO DE 10 PESOS
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'TRANSA_SQL.regaloCredDeBienvenida'))
DROP TRIGGER TRANSA_SQL.regaloCredDeBienvenida

go
create trigger TRANSA_SQL.regaloCredDeBienvenida on TRANSA_SQL.Customer
for insert as begin
	update TRANSA_SQL.Customer set Amount=10
	from inserted i
	where i.CustomerId=TRANSA_SQL.Customer.CustomerId
end

go

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'TRANSA_SQL.actsaldoporcompra'))
DROP TRIGGER TRANSA_SQL.actsaldoporcompra

go
create trigger TRANSA_SQL.actsaldoporcompra on TRANSA_SQL.Purchase
after insert
as begin
	update TRANSA_SQL.Customer set Amount-=cb.RealPrice
	from inserted i join TRANSA_SQL.CouponBook cb on i.CouponBookId=cb.CouponBookId
	where TRANSA_SQL.Customer.CustomerId=i.CustomerId
	
	update TRANSA_SQL.CouponBook set Stock-=(select COUNT(*) from inserted i where i.CouponBookId=TRANSA_SQL.CouponBook.CouponBookId and ins.PurchaseId=i.PurchaseId)
	from inserted ins
	where TRANSA_SQL.CouponBook.CouponBookId=ins.CouponBookId
end

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'TRANSA_SQL.actStockYsaldoPorDev'))
DROP TRIGGER TRANSA_SQL.actStockYsaldoPorDev

go
create trigger TRANSA_SQL.actStockYsaldoPorDev on TRANSA_SQL.Refund
after insert
as begin
	update TRANSA_SQL.CouponBook set Stock-=1
		from inserted i
	where TRANSA_SQL.CouponBook.CouponBookId=i.CouponBookId
	update TRANSA_SQL.Customer set Amount+=cb.RealPrice
	from inserted i join TRANSA_SQL.CouponBook cb on cb.CouponBookId=i.CouponBookId
	where TRANSA_SQL.Customer.CustomerId=i.CustomerId
end
/*Stored Procedures*/
go
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'TRANSA_SQL.altaProveedor'))
DROP procedure TRANSA_SQL.altaProveedor

go
create procedure TRANSA_SQL.altaProveedor(@razonSoc nvarchar(100),@mail nvarchar(255),@phone numeric(18,0),@addr nvarchar(255),@postalCode nvarchar(8),@city nvarchar(255), @entry nvarchar(100),@cuit nvarchar(20),@contact nvarchar(27))
as begin
	declare @entryId int
	declare @cityId int
	declare @RoleId int
	declare @UserId int
	declare @PersonalDataId int
	select * from TRANSA_SQL.Supplier s where s.CorporateName=@razonSoc or s.Cuit=@cuit
	if @@ROWCOUNT >0
	begin
		return
	end
	select @entryId=e.EntryId from TRANSA_SQL.Entry e where e.Name=@entry
	if(@entryId is null)
	begin
		insert into TRANSA_SQL.Entry values (@entry)
		select @entryId=e.EntryId from TRANSA_SQL.Entry e where e.Name=@entry
	end
	
	select @cityId=c.CityId from TRANSA_SQL.City c where c.Name=@city
	if(@cityId is null)
	begin
		insert into TRANSA_SQL.City values (@city)
		select @cityId=c.CityId from TRANSA_SQL.City c where c.Name=@city
	end
	select @RoleId=r.RoleId from TRANSA_SQL.Role r where r.Name='Supplier'	
	insert into TRANSA_SQL.CuponeteUser values (@cuit,'47f5390d283f8cbcc8272dbc288b2cae42ec57d13cb8abea14cd7754f2be57dd',1,0,@RoleId,1,0)
	select @UserId=cu.UserId from TRANSA_SQL.CuponeteUser cu where cu.Username=@cuit
	insert into TRANSA_SQL.PersonalData values (@UserId,@mail,@postalCode,@addr)
	select @PersonalDataId=pd.PersonalDataId from TRANSA_SQL.PersonalData pd where pd.UserId=@UserId
	insert into TRANSA_SQL.Supplier values (@razonSoc,@cuit,@UserId,@phone,@cityId,@entryId,@contact,@PersonalDataId)
end

go
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'TRANSA_SQL.filtrarProveedor'))
DROP procedure TRANSA_SQL.filtrarProveedor

go
create procedure TRANSA_SQL.filtrarProveedor(@userid int=null,@razonSoc nvarchar(100)=null,@mail nvarchar(255)=null,@cuit nvarchar(20)=null)
as begin

select s.CorporateName "Razon Social",p.Email "Mail",s.PhoneNumber "Telefono",p.Address "Direccion",p.PostalCode "Codigo Postal",c.Name "Ciudad",s.Cuit "Cuit",e.Name "Rubro",s.ContactName "Nombre Contacto" from TRANSA_SQL.Supplier s join TRANSA_SQL.PersonalData p on p.PersonalDataId=s.PersonalDataId join TRANSA_SQL.City c on c.CityId=s.CityId join TRANSA_SQL.Entry e on e.EntryId=s.EntryId 
where s.Cuit=ISNULL(@cuit,s.Cuit) and
		s.CorporateName like ISNULL( '%'+@razonSoc+'%', s.CorporateName) and
		(p.Email like ISNULL('%'+@mail+'%',p.Email) or p.Email is null) and
		s.UserId=ISNULL(@userid,s.UserId)
end

go
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'TRANSA_SQL.modificarProveedor'))
DROP procedure TRANSA_SQL.modificarProveedor

go
create procedure TRANSA_SQL.modificarProveedor(@razonSoc nvarchar(100)=null,@mail nvarchar(255)=null,@phone numeric(18,0)=null,@addr nvarchar(255)=null,@postalCode nvarchar(8)=null,@city nvarchar(255)=null, @entry nvarchar(100)=null,@cuit nvarchar(20)=null,@contact nvarchar(27)=null)
as begin

	declare @entryId int
	declare @cityId int
	declare @PersonalDataId int
	select @entryId=e.EntryId from TRANSA_SQL.Entry e where e.Name=@entry
	if(@entryId is null)
	begin
		insert into TRANSA_SQL.Entry values (@entry)
		select @entryId=e.EntryId from TRANSA_SQL.Entry e where e.Name=@entry
	end
	
	select @cityId=c.CityId from TRANSA_SQL.City c where c.Name=@city
	if(@cityId is null)
	begin
		insert into TRANSA_SQL.City values (@city)
		select @cityId=c.CityId from TRANSA_SQL.City c where c.Name=@city
	end
	select @PersonalDataId=pd.PersonalDataId from TRANSA_SQL.PersonalData pd where pd.UserId=(select s.UserId from TRANSA_SQL.Supplier s where s.Cuit=@cuit)
	
	update TRANSA_SQL.PersonalData set Email=ISNULL( @mail,Email),
										Address=ISNULL(@addr,Address),
										PostalCode=ISNULL(@postalCode,PostalCode)
	where TRANSA_SQL.PersonalData.PersonalDataId=@PersonalDataId
	
	update TRANSA_SQL.Supplier set CorporateName= ISNULL(  @razonSoc,CorporateName),
								PhoneNumber=ISNULL( @phone,PhoneNumber),
								Cuit=ISNULL( @cuit,Cuit),
								ContactName=isnull( @contact,ContactName),
								EntryId= ISNULL( @entryId,EntryId),
								CityId= ISNULL( @cityId,CityId)
	where TRANSA_SQL.Supplier.PersonalDataId=@PersonalDataId
end

go
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'TRANSA_SQL.filtrarCliente'))
DROP procedure TRANSA_SQL.filtrarCliente

go
create procedure TRANSA_SQL.filtrarCliente(@userid int =null,@nombre nvarchar(255)=null,@mail nvarchar(255)=null,@apellido nvarchar(255)=null,@dni numeric(18,0)=null,@telefono numeric(18,0)=null)
as begin

select c.Dni "Dni",p.Email "Mail",c.PhoneNumber "Telefono",p.Address "Direccion",p.PostalCode "Codigo Postal",c.Name "Nombre",c.Surname "Apellido",c.Birthday "Fecha de nacimiento" 
from TRANSA_SQL.Customer c join TRANSA_SQL.PersonalData p on p.PersonalDataId=c.PersonalDataId 
where 
c.Name like isnull('%'+@nombre+'%',c.Name) and
(p.Email like ISNULL('%'+@mail+'%',p.Email) or p.Email is null) and
c.Surname like isnull('%'+@apellido+'%',c.Surname)
and c.Dni=ISNULL( @dni,c.Dni)
and c.PhoneNumber=ISNULL(@telefono,c.PhoneNumber)
and c.UserId=ISNULL(@userid,c.UserId)
end

go
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'TRANSA_SQL.chauFirstLogin'))
DROP procedure TRANSA_SQL.chauFirstLogin

go
create procedure TRANSA_SQL.chauFirstLogin(@username nvarchar(255)=null,@userId int =null)
as begin
	update TRANSA_SQL.CuponeteUser set FirstLogin=0
	where Username=isnull(@username,Username) and
	UserId=ISNULL(@userId,UserId)
end

go
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'TRANSA_SQL.modificarCliente'))
DROP procedure TRANSA_SQL.modificarCliente

go
create procedure TRANSA_SQL.modificarCliente(@apellido nvarchar(255)=null,@dni numeric(18,0)=null,@mail nvarchar(255)=null,@phone numeric(18,0)=null,@addr nvarchar(255)=null,@postalCode nvarchar(8)=null,@nombre nvarchar(255)=null,@fechaNac datetime, @userId int=null)
as begin
	declare @PersonalDataId int
	
	if(@userId is null)
	begin
		set @userId=(select c.UserId from TRANSA_SQL.Customer c where c.PhoneNumber=@phone)
	end
	
	
	select @PersonalDataId=pd.PersonalDataId from TRANSA_SQL.PersonalData pd where pd.UserId=@userId
	
	update TRANSA_SQL.PersonalData set Email=ISNULL( @mail,Email),
										Address=ISNULL(@addr,Address),
										PostalCode=ISNULL(@postalCode,PostalCode)
	where TRANSA_SQL.PersonalData.PersonalDataId=@PersonalDataId
	
	update TRANSA_SQL.Customer set Dni=ISNULL( @dni,Dni),
									PhoneNumber=ISNULL(@phone,PhoneNumber),
									Name=ISNULL(@nombre,Name),
									Surname=ISNULL(@apellido,Surname),
									Birthday=ISNULL(@fechaNac,Birthday)
	where TRANSA_SQL.Customer.PersonalDataId=@PersonalDataId 
end

go
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'TRANSA_SQL.comprarGiftCard'))
DROP procedure TRANSA_SQL.comprarGiftCard

go
create procedure TRANSA_SQL.comprarGiftCard(@orig numeric(18,0),@dest numeric(18,0),@monto numeric(18,2),@fecha datetime)
as begin
	declare @origId int,@destId int
	select @origId=c.CustomerId
	from TRANSA_SQL.Customer c
	where c.PhoneNumber=@orig
	select @destId=c.CustomerId
	from TRANSA_SQL.Customer c
	where c.PhoneNumber=@dest
	
	insert into TRANSA_SQL.GiftCard values (@fecha,@monto,@origId,@destId)
end

go
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'TRANSA_SQL.buscarCupones'))
DROP procedure TRANSA_SQL.buscarCupones

go

create procedure TRANSA_SQL.buscarCupones(@cliente numeric(18,0)=null,@fecha datetime)
as begin
	select cb.CouponBookId,cb.CouponDescription "Descripcion",cb.OfferMaturityDate "Vencimiento de la oferta",cb.FictitiousPrice "Precio sin descuento",cb.RealPrice "Precio de la oferta",cb.Stock,cb.MaximunAmountAllowed
	from TRANSA_SQL.CouponBook cb join TRANSA_SQL.PublishedCouponBook pcb on pcb.CouponBookId=cb.CouponBookId join TRANSA_SQL.ZonePerCouponBook zcb on zcb.CouponBookId=cb.CouponBookId join TRANSA_SQL.CustomerCity cc on cc.CityId=zcb.CityId join TRANSA_SQL.Customer c on c.CustomerId=cc.CustomerId and c.PhoneNumber=isnull(@cliente,c.PhoneNumber)
	where @fecha between pcb.PublishedDate and cb.OfferMaturityDate
end

go
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'TRANSA_SQL.teLoCompro'))
DROP procedure TRANSA_SQL.teLoCompro

go
create procedure TRANSA_SQL.teLoCompro(@cliente numeric(18,0),@couponId int,@fecha datetime)
as begin
	declare @code nvarchar(50)
		set @code=(select top 1 p.CouponCode from TRANSA_SQL.Purchase p order by 1 asc)
		if(@code !='0')
		begin
			set @code='0'
		end
		else
		begin
			declare @contador int =1
			while(exists (select p.CouponCode from TRANSA_SQL.Purchase p where p.CouponCode=CONVERT(nvarchar(50),@contador)))
			begin
				set @contador+=1
			end
			
			set @code=CONVERT(nvarchar(50),@contador)
		end
		insert into TRANSA_SQL.Purchase values (@fecha,@couponId,@code,(select c.CustomerId from TRANSA_SQL.Customer c where c.PhoneNumber=@cliente))
	
end

go
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'TRANSA_SQL.historial'))
DROP procedure TRANSA_SQL.historial

go
create procedure TRANSA_SQL.historial(@cliente numeric(18,0),@fecha1 datetime,@fecha2 datetime)
as begin
	select cb.CouponDescription "Descripcion",p.CouponCode "Codigo",p.PurchaseDate "Fecha de Compra",cb.ConsumptionMaturityDate "vencimiento de canje",TRANSA_SQL.devuelveEstadoCupon(cb.CouponBookId,p.CouponCode) "Estado"
	 from TRANSA_SQL.Purchase p join TRANSA_SQL.Customer c on c.CustomerId=p.CustomerId and c.PhoneNumber=@cliente join TRANSA_SQL.CouponBook cb on cb.CouponBookId=p.CouponBookId
	 where p.PurchaseDate between @fecha1 and @fecha2
end

/*TODO PARA EL ABM Cliente*/


GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'TRANSA_SQL.insertarCiudad'))
DROP PROCEDURE TRANSA_SQL.insertarCiudad

GO
CREATE PROCEDURE TRANSA_SQL.insertarCiudad (@CustomerId INT, @CityName NVARCHAR(255))
AS
BEGIN
	DECLARE @CityId INT
	
	SET @CityId = (SELECT C.CityId FROM TRANSA_SQL.City C WHERE C.Name=@CityName)
	
	INSERT INTO TRANSA_SQL.CustomerCity (CustomerId, CityId)
	VALUES(@CustomerId, @CityId)
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'TRANSA_SQL.eliminarCiudades'))
DROP PROCEDURE TRANSA_SQL.eliminarCiudades

GO
CREATE PROCEDURE TRANSA_SQL.eliminarCiudades (@CustomerId INT)
AS
BEGIN
	DELETE FROM TRANSA_SQL.CustomerCity
	WHERE CustomerId=@CustomerId
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'TRANSA_SQL.altaCliente'))
DROP PROCEDURE TRANSA_SQL.altaCliente

GO
CREATE PROCEDURE TRANSA_SQL.altaCliente (@Name NVARCHAR(255), @Surname NVARCHAR(255), @Dni NUMERIC(18,0), @Email NVARCHAR(255), @PhoneNumber NUMERIC(18,0), @Address NVARCHAR(255), @PostalCode NVARCHAR(8), @Birthday DATETIME)
AS
BEGIN

	DECLARE @RoleId INT
	DECLARE @UserId INT
	DECLARE @PersonalDataId INT
	
	SELECT * FROM TRANSA_SQL.Customer C WHERE C.Dni=@Dni OR C.PhoneNumber=@PhoneNumber
	IF (@@ROWCOUNT >0)
	BEGIN
		RETURN @@ROWCOUNT
	END
	
	SELECT @RoleId=R.RoleId FROM TRANSA_SQL.Role R WHERE R.Name='Customer'
		
	INSERT INTO TRANSA_SQL.CuponeteUser (Username, Password, FirstLogin, FailedAttemps, RoleId, Enabled, Deleted)
	VALUES (@PhoneNumber, '47f5390d283f8cbcc8272dbc288b2cae42ec57d13cb8abea14cd7754f2be57dd', 1, 0, @RoleId, 1, 0)
	
	SELECT @UserId=CU.UserId FROM TRANSA_SQL.CuponeteUser CU WHERE CU.Username=CAST(@PhoneNumber AS NVARCHAR(255))
	
	INSERT INTO TRANSA_SQL.PersonalData (UserId, Email, PostalCode, Address)
	VALUES (@UserId, @Email, @PostalCode, @Address)
	
	SELECT @PersonalDataId=PD.PersonalDataId FROM TRANSA_SQL.PersonalData PD WHERE PD.UserId=@UserId

	INSERT INTO TRANSA_SQL.Customer (Dni, PhoneNumber, UserId, Name, Surname, Birthday, PersonalDataId)
	VALUES (@Dni, @PhoneNumber, @UserId, @Name, @Surname, @Birthday, @PersonalDataId)
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'TRANSA_SQL.eliminarCliente'))
DROP PROCEDURE TRANSA_SQL.eliminarCliente

GO
CREATE PROCEDURE TRANSA_SQL.eliminarCliente (@UserId INT)
AS
BEGIN
	UPDATE TRANSA_SQL.CuponeteUser SET Deleted=1 WHERE UserId=@UserId
END

go
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'TRANSA_SQL.devolverCupon'))
DROP procedure TRANSA_SQL.devolverCupon

go
create procedure TRANSA_SQL.devolverCupon(@cliente numeric(18,0),@Code nvarchar(50),@reason nvarchar(max),@fecha datetime)
as begin
	declare @cId int
	declare @reasonId int
	select @cId=c.CustomerId from TRANSA_SQL.Customer c where c.PhoneNumber=@cliente
	declare @couponbookid int
	set @couponbookid=(select top 1 p.CouponBookId from TRANSA_SQL.Purchase p where p.CouponCode=@Code)
	
	
	if not exists (select * from TRANSA_SQL.Purchase p where p.CouponCode=@Code and p.CustomerId=@cId)
	begin
		rollback tran
		return
	end
	if not exists (select * from TRANSA_SQL.Reason r where r.Description=@reason)
	begin
		insert into TRANSA_SQL.Reason values (@reason)
	end
	set @reasonId=(select r.ReasonId from TRANSA_SQL.Reason r where r.Description=@reason)
	insert into TRANSA_SQL.Refund values (@fecha,@cId,@couponbookid,@Code,@reasonId)
end

go
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'TRANSA_SQL.armarCupon'))
DROP procedure TRANSA_SQL.armarCupon

go
create procedure TRANSA_SQL.armarCupon(@proveedor nvarchar(20),@desc nvarchar(255),@fechapub datetime,@fechavencof datetime,@fechavenccons datetime,@pReal numeric(18,2),@pFic numeric(18,2),@stock numeric(18,0),@maxallow int)
as begin
	
	insert into TRANSA_SQL.CouponBook
	select top 1 s.SupplierId,@desc,@stock,@maxallow,@fechapub,@fechavencof,@fechavenccons,@pReal,@pFic,null
	from TRANSA_SQL.Supplier s where s.Cuit=@proveedor
	
end
go
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'TRANSA_SQL.insertarZonaPerCoupon'))
DROP procedure TRANSA_SQL.insertarZonaPerCoupon

GO
CREATE PROCEDURE TRANSA_SQL.insertarZonaPerCoupon (@CouponBookId int, @CityName NVARCHAR(255))
AS
BEGIN
	DECLARE @CityId INT
	SET @CityId = (SELECT C.CityId FROM TRANSA_SQL.City C WHERE C.Name=@CityName)
	
	INSERT INTO TRANSA_SQL.ZonePerCouponBook (CouponBookId, CityId)
	VALUES(@CouponBookId, @CityId)
END

go
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'TRANSA_SQL.registrarConsumo'))
DROP procedure TRANSA_SQL.registrarConsumo

go

create procedure TRANSA_SQL.registrarConsumo(@proveedor nvarchar(255),@couponCode nvarchar(50),@fecha datetime)
as begin

	insert into TRANSA_SQL.ConsumedCoupon
	select top 1 @fecha,p.CouponBookId,@couponCode,p.CustomerId,null
	from TRANSA_SQL.Purchase p join TRANSA_SQL.CouponBook cb on cb.CouponBookId=p.CouponBookId join TRANSA_SQL.Supplier s on s.SupplierId=cb.SupplierId
	where p.CouponCode=@couponCode and s.Cuit=@proveedor
end
go
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'TRANSA_SQL.buscarCuponesApublicar'))
DROP procedure TRANSA_SQL.buscarCuponesApublicar

go
create procedure TRANSA_SQL.buscarCuponesApublicar(@proveedor nvarchar(255)=null,@fecha datetime)
as begin

	if(@proveedor is not null)
	begin
		select s.CorporateName "Proveedor",cb.CouponBookId,cb.CouponDescription "Descripcion",cb.IssueDate "Fecha de publicacion",cb.OfferMaturityDate "Vencimiento de la oferta",cb.ConsumptionMaturityDate "Vencimiento para consumo",cb.RealPrice "Precio Oferta",cb.FictitiousPrice "Precio sin oferta",cb.Stock "Stock",cb.MaximunAmountAllowed "Maximo por cliente" 
		from TRANSA_SQL.CouponBook cb join TRANSA_SQL.Supplier s on s.SupplierId=cb.SupplierId and s.Cuit=@proveedor and cb.PublishedCouponBookId is null
	end
	else
	begin
		select s.CorporateName "Proveedor",cb.CouponBookId,cb.CouponDescription "Descripcion",cb.IssueDate "Fecha de publicacion",cb.OfferMaturityDate "Vencimiento de la oferta",cb.ConsumptionMaturityDate "Vencimiento para consumo",cb.RealPrice "Precio Oferta",cb.FictitiousPrice "Precio sin oferta",cb.Stock "Stock",cb.MaximunAmountAllowed "Maximo por cliente" 
		from TRANSA_SQL.CouponBook cb join TRANSA_SQL.Supplier s on s.SupplierId=cb.SupplierId and cb.PublishedCouponBookId is null
	end 

end


go
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'TRANSA_SQL.publicar'))
DROP procedure TRANSA_SQL.publicar

go
create procedure TRANSA_SQL.publicar(@couponBookId int,@fecha datetime)
as begin
	declare @pcbId int
	insert into TRANSA_SQL.PublishedCouponBook values (@fecha,@couponBookId)
	set @pcbId=(select top 1 pcb.PublishedCouponId 
	from TRANSA_SQL.PublishedCouponBook pcb 
	where pcb.CouponBookId=@couponBookId
	order by 1 desc)
	
	update TRANSA_SQL.CouponBook set PublishedCouponBookId=@pcbId
	where TRANSA_SQL.CouponBook.CouponBookId=@couponBookId
	
end


/*Functions*/
go
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'TRANSA_SQL.devuelveEstadoCupon'))
DROP function TRANSA_SQL.devuelveEstadoCupon

go
create function TRANSA_SQL.devuelveEstadoCupon(@couponId int, @couponCode nvarchar(50))
returns nvarchar(20)
as begin
	
	
	if exists (select * from TRANSA_SQL.ConsumedCoupon cc where cc.CouponBookId=@couponId and cc.CouponCode=@couponCode)
	begin
		return 'Canjeado'
	end
	
	if exists (select * from TRANSA_SQL.Refund cc where cc.CouponBookId=@couponId and cc.CouponCode=@couponCode)
	begin
		return 'Devuelto'
	end
	
	return 'Comprado'
end


GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'TRANSA_SQL.registrarCliente'))
DROP PROCEDURE TRANSA_SQL.registrarCliente

GO
CREATE PROCEDURE TRANSA_SQL.registrarCliente (@UserId INT, @Name NVARCHAR(255), @Surname NVARCHAR(255), @Dni NUMERIC(18,0), @Email NVARCHAR(255), @PhoneNumber NUMERIC(18,0), @Address NVARCHAR(255), @PostalCode NVARCHAR(8), @Birthday DATETIME)
AS
BEGIN

	DECLARE @RoleId INT
	DECLARE @PersonalDataId INT
	
	SELECT @RoleId=R.RoleId FROM TRANSA_SQL.Role R WHERE R.Name='Customer'
	
	INSERT INTO TRANSA_SQL.PersonalData (UserId, Email, PostalCode, Address)
	VALUES (@UserId, @Email, @PostalCode, @Address)
	
	SELECT @PersonalDataId=PD.PersonalDataId FROM TRANSA_SQL.PersonalData PD WHERE PD.UserId=@UserId

	INSERT INTO TRANSA_SQL.Customer (Dni, PhoneNumber, UserId, Name, Surname, Birthday, PersonalDataId)
	VALUES (@Dni, @PhoneNumber, @UserId, @Name, @Surname, @Birthday, @PersonalDataId)
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'TRANSA_SQL.registrarProveedor'))
DROP PROCEDURE TRANSA_SQL.registrarProveedor

GO
CREATE PROCEDURE TRANSA_SQL.registrarProveedor(@UserId INT, @RazonSoc NVARCHAR(100),@Mail NVARCHAR(255),@Phone NUMERIC(18,0),@Addr NVARCHAR(255),@PostalCode NVARCHAR(8),@City NVARCHAR(255), @Entry NVARCHAR(100),@Cuit NVARCHAR(20),@Contact NVARCHAR(27))
AS
BEGIN
	DECLARE @EntryId INT
	DECLARE @CityId INT
	DECLARE @RoleId INT
	DECLARE @PersonalDataId INT
	
	SELECT @EntryId=E.EntryId FROM TRANSA_SQL.Entry E WHERE E.Name=@Entry
	IF(@EntryId is null)
	BEGIN
		INSERT INTO TRANSA_SQL.Entry VALUES (@Entry)
		SELECT @EntryId=E.EntryId FROM TRANSA_SQL.Entry E WHERE E.Name=@Entry
	END
	
	SELECT @CityId=C.CityId FROM TRANSA_SQL.City C WHERE C.Name=@City
	IF(@CityId is null)
	BEGIN
		INSERT INTO TRANSA_SQL.City VALUES (@City)
		SELECT @CityId=C.CityId FROM TRANSA_SQL.City C WHERE C.Name=@City
	END
	
	SELECT @RoleId=R.RoleId FROM TRANSA_SQL.Role R WHERE R.Name='Supplier'	
	
	INSERT INTO TRANSA_SQL.PersonalData VALUES (@UserId,@Mail,@PostalCode,@Addr)
	
	SELECT @PersonalDataId=PD.PersonalDataId FROM TRANSA_SQL.PersonalData PD WHERE PD.UserId=@UserId
	INSERT INTO TRANSA_SQL.Supplier VALUES (@RazonSoc,@Cuit,@UserId,@Phone,@CityId,@EntryId,@Contact,@PersonalDataId)
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'TRANSA_SQL.agregarRolePermission'))
DROP PROCEDURE TRANSA_SQL.agregarRolePermission

GO
CREATE PROCEDURE TRANSA_SQL.agregarRolePermission(@RoleId INT, @PermissionId INT)
AS
BEGIN
	INSERT INTO TRANSA_SQL.RolePermission(RoleId, PermissionId) VALUES (@RoleId, @PermissionId)
END