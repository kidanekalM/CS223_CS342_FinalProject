/*
**************************************************************************************
Admin   - Me / my account
		- view everything about agents GET ALL EMPLOYEES WITH DEPARTMENT NAME (FUNC)
		- GET ALL CLIENTS JOIN AGENTS (FUNC)
		- GET EVERYTHING ABOUT ALL PROPERTIES (FUNC)	
		- GET ALL BUYS WITH EVERYTHING 
		- 
***************************************************************************************
Agent   - GET ALL APPOINTMENTS WITH EVERYTHING (FUNC)
		- CLIENTS INFORMATION 
		- ADD EDIT DELETE PROPERTY AND BUYS
		- 
		- 
		- 
***************************************************************************************
Client  -
	    -
		-
		-
		-
		-
***************************************************************************************
-- INSERT TRIGGER --cleaning the data trim, uppercase             2
					Add Employee check if it is an admin          1
					trigger for assignming agent for new customer 1
					TRIGGER for calculating the comission         1
_________________________________________________________________________________________
					  TOTAL												                   [5-7/8]

FUNCTION			function for login for all-0/1                			3
					client for user control view          					1
					Appointment for user control view     					1
					employees for user control view       					1
					property for user control view        					1
					function for calculating the number of years worked		1
					GET DETAILS												-
_______________________________________________________________________________________________________
                                          TOTAL                                        		[8-10]
_______________________________________________________________________________________________________

ADMINSTRATION					Add properties
								edit employees

Add photo for clients 
get details of [id] / search d/t for double click and searching 

get all functions 
*****************************************************************************************

*****************************************************************************************
		REQ
		minimum 5 table
		minimum 5 procedure per table
		minimum 5 function and trigger for the whole database
		cursor(as much we want //has no requirement)
*/
go
--Database creating

CREATE DATABASE RealEstate
GO
--Change Database
USE RealEstate

-- Creating Tables 
CREATE TABLE Contractor(
ID INT PRIMARY KEY IDENTITY,
Name VARCHAR(100)  NOT NULL,
PhoneNumber VARCHAR(10)  UNIQUE  NOT NULL,
)
CREATE TABLE Department(
ID INT PRIMARY KEY IDENTITY,
Name VARCHAR(100)  NOT NULL
)

CREATE TABLE Employee(
ID INT PRIMARY KEY IDENTITY ,
FirstName VARCHAR(100)NOT NULL,
LastName VARCHAR(100)NOT NULL,
PhoneNumber VARCHAR(11) UNIQUE,
Password VARCHAR(100)NOT NULL,
Photo VARBINARY(MAX) ,
EmpType VARCHAR(100) NOT NULL,
EmpDate DATE NOT NULL,
DepartmentID INT /*CONSTRAINT FK_DepartmentId*/FOREIGN KEY REFERENCES Department(ID)
)
CREATE TABLE Client(
ID INT PRIMARY KEY IDENTITY,
FirstName VARCHAR(100) NOT NULL,
LastName VARCHAR(100) NOT NULL,
Photo VARBINARY(MAX) , 
PhoneNumber VARCHAR(11)  UNIQUE,
Email VARCHAR(100) NOT NULL UNIQUE CONSTRAINT CHK_CLIENT_EMAIL CHECK (email LIKE '%@%.'),
Password VARCHAR(100) NOT NULL,
EmpId INT /*CONSTRAINT FK_EMPID*/ FOREIGN KEY REFERENCES Employee(ID)  NOT NULL
)

CREATE TABLE Property(
ID INT PRIMARY KEY IDENTITY  NOT NULL,
Address VARCHAR(100)  NOT NULL,
Price FLOAT  NOT NULL,
Type VARCHAR(100)  NOT NULL,
Area FLOAT  NOT NULL,
Status BIT NOT NULL,
ContractorID INT FOREIGN KEY REFERENCES Contractor(ID)  NOT NULL,
Description VARCHAR(100)  NOT NULL
)
CREATE TABLE PropertyPhoto(
PropertyID INT FOREIGN KEY REFERENCES Property(ID)  NOT NULL,
Photo VARBINARY(MAX)  NOT NULL
)
CREATE TABLE Buy(
ID INT PRIMARY KEY IDENTITY  NOT NULL,
PropertyID INT /*CONSTRAINT FK_PropertyId*/ FOREIGN KEY REFERENCES Property(ID)  NOT NULL,
ClientID INT /*CONSTRAINT FK_ClientID*/ FOREIGN KEY REFERENCES Client(id)  NOT NULL,
AgentID INT /*CONSTRAINT FK_AGENTID*/ FOREIGN KEY REFERENCES EMPLOYEE(ID)  NOT NULL,
SellDate DATETIME  NOT NULL,
Comission MONEY
)
CREATE TABLE Appointment(
ID INT PRIMARY KEY IDENTITY NOT NULL,
AppointmentDate DATETIME  NOT NULL,
Comment NVARCHAR(100)  NOT NULL,
ClientID INT /*CONSTRAINT FK_ClientID*/ FOREIGN KEY REFERENCES Client(id)  NOT NULL,
AgentID INT /*CONSTRAINT FK_AGENTID*/ FOREIGN KEY REFERENCES EMPLOYEE(ID) NOT NULL
)

CREATE TABLE ChoosenProperty(
ID INT FOREIGN KEY REFERENCES Appointment(ID)  NOT NULL,
PropertyID INT /*CONSTRAINT FK_PropertyId*/ FOREIGN KEY  REFERENCES Property(ID)  NOT NULL
CONSTRAINT PKChoosenProperty PRIMARY KEY (ID,PropertyID)  
)
GO

/*******************************************************
         Contractor Stored Procedures 
*******************************************************/
CREATE PROC [Add Contractor]
	@Name VARCHAR(100),
	@PhoneNumber VARCHAR(10)
	AS
	BEGIN
		INSERT INTO Contractor(Name,PhoneNumber) 
		VALUES (@Name,@PhoneNumber)
	END
GO
CREATE PROC [Update Contractor]
	@id INT,
	@Name VARCHAR(100),
	@PhoneNumber VARCHAR(10)
	AS
	BEGIN
		UPDATE Contractor 
		SET Name = @Name,
			PhoneNumber = @PhoneNumber
			WHERE ID = @id
	END

GO

CREATE PROC [Search Contractor By Name]
	@Name VARCHAR(100)
	AS
	BEGIN
		SELECT ID,Name,PhoneNumber 
		FROM Contractor 
		WHERE Name LIKE '%'+@Name+'%'
	END

GO

CREATE PROC [Search Contractor By Id]
	@ID INT
	AS
	BEGIN
		SELECT ID,Name,PhoneNumber 
		FROM Contractor
		WHERE ID LIKE '%'+CAST(@ID AS VARCHAR(20))+'%'
	END
GO

CREATE PROC [Delete Contractor]
	@ID INT
	AS
	BEGIN
		DELETE FROM Contractor 
		WHERE ID = @ID 
	END
GO

/********************************************************
         Department Stored Procedures 
*********************************************************/
CREATE PROC [Add Department]
	@Name VARCHAR(100)
	AS
	BEGIN
		INSERT INTO Department(Name)
		VALUES (@Name)
	END
GO

CREATE PROC [Update Department]
	@Name VARCHAR(100),
	@ID INT
	AS
	BEGIN
		UPDATE Department
		SET Name = TRIM(@Name)
		WHERE ID = @ID
	END
GO

CREATE PROC [Delete Department]
	@ID INT
	AS
	BEGIN
		DELETE FROM Department 
		WHERE ID = @ID
	END
GO

CREATE PROC [Search Department By ID]
	@ID INT
	AS
	BEGIN
		SELECT ID,Name
		FROM Department
		WHERE ID LIKE '%'+CAST( @ID AS VARCHAR(20))+'%'
	END
GO

CREATE PROC [Search Department By Name]
	@Name VARCHAR(100)
	AS
	BEGIN
		SELECT ID,Name
		FROM Department
		WHERE Name LIKE '%' + TRIM(@Name) + '%'
	END
GO
/********************************************************
         Employee Stored Procedures 
*********************************************************/
CREATE PROC [Add Employee]
	@FirstName VARCHAR(100),
	@LastName VARCHAR(100),
	@PhoneNumber VARCHAR(11),
	@Password VARCHAR(100),
	@Photo VARBINARY(MAX),
	@EmpType VARCHAR(100),
	@EmpDate DATE,
	@DepartmentID INT
	AS
	BEGIN
		INSERT INTO Employee(FirstName,LastName,PhoneNumber,Password,Photo,EmpType,EmpDate,DepartmentID)
		VALUES (@FirstName,@LastName,@PhoneNumber,@Password,@Photo,@EmpType,@EmpDate,@DepartmentID)
	END
GO
CREATE PROC [Update Employee]
	@ID INT,
	@FirstName VARCHAR(100),
	@LastName VARCHAR(100),
	@PhoneNumber VARCHAR(11),
	@Password VARCHAR(100),
	@Photo VARBINARY(MAX),
	@EmpType VARCHAR(100),
	@EmpDate DATE,
	@DepartmentID INT
	
	AS
	BEGIN
		UPDATE Employee
		SET 
		FirstName = @FirstName, 
		LastName = @LastName, 
		PhoneNumber = @PhoneNumber, 
		Password = @Password, 
		Photo = @Photo, 
		EmpType = @EmpType, 
		EmpDate = @EmpDate, 
		DepartmentID = @DepartmentID 
		WHERE ID = @ID
	END
GO

CREATE PROC [Delete Employee]
	@ID INT
	AS
	BEGIN
		DELETE FROM Employee
		WHERE ID = @ID
	END
GO

CREATE PROC [Search Employee By ID]
	@ID INT
	AS
	BEGIN
		SELECT ID,FirstName,LastName,PhoneNumber,Password,PhoneNumber,EmpType,EmpDate,DepartmentID
		FROM Employee
		WHERE ID LIKE '%'+CAST( @ID AS VARCHAR(20))+'%'
	END
GO

CREATE PROC [Search Employee By Name]
	@Name VARCHAR(100)
	AS
	BEGIN
		SELECT ID,FirstName,LastName,PhoneNumber,Password,PhoneNumber,EmpType,EmpDate,DepartmentID
		FROM Employee
		WHERE FirstName LIKE '%' + TRIM(@Name) + '%' OR 
				LastName LIKE '%' + TRIM(@Name) + '%'
	END
GO



/********************************************************
         Client Stored Procedures 
*********************************************************/
CREATE PROC [Add Client]
	@FirstName VARCHAR(100),
	@LastName VARCHAR(100),
	@Photo VARBINARY(MAX),
	@PhoneNumber VARCHAR(11),
	@Email VARCHAR(100),
	@Password VARCHAR(100) ,
	@EmpId INT = NULL
	AS
	BEGIN
		INSERT INTO Client(FirstName,LastName,Photo,PhoneNumber,Email,Password,EmpId)
		VALUES (@FirstName ,@LastName,@Photo, @PhoneNumber,@Email, @Password,@EmpId ) 
	END
GO
CREATE PROC [Update Client]
	@ID INT,
	@FirstName VARCHAR(100),
	@LastName VARCHAR(100),
	@Photo VARBINARY(MAX),
	@PhoneNumber VARCHAR(11) ,
	@Email VARCHAR(100),
	@Password VARCHAR(100) ,
	@EmpId INT
	
	AS
	BEGIN
		UPDATE Client
		SET FirstName = @FirstName,
			LastName = @LastName,
			Photo = @Photo,
			Email = @Email, 
			Password = @Password,
			PhoneNumber = @PhoneNumber,
			EmpId = @EmpId
		WHERE ID = @ID
	END
GO

CREATE PROC [Delete Client]
	@ID INT
	AS
	BEGIN
		DELETE FROM Client
		WHERE ID = @ID
	END
GO

CREATE PROC [Search Client By ID]
	@ID INT
	AS
	BEGIN
		SELECT ID,FirstName,LastName,Photo,PhoneNumber,Email ,Password,EmpId
		FROM Client
		WHERE ID LIKE '%'+CAST( @ID AS VARCHAR(20))+'%'
	END
GO

CREATE PROC [Search Client By Name]
	@Name VARCHAR(100)
	AS
	BEGIN
		SELECT ID,FirstName,LastName,Photo,PhoneNumber,Email ,Password,EmpId
		FROM Client
		WHERE FirstName LIKE '%' + TRIM(@Name) + '%' OR LastName LIKE '%' + TRIM(@Name) + '%' 
	END
GO

/********************************************************
         Property Stored Procedures 
*********************************************************/
CREATE PROC [Add Property]
	@ID INT ,
	@Address VARCHAR(100),
	@Price FLOAT,
	@Type VARCHAR(100),
	@Area FLOAT,
	@Status BIT,
	@ContractorID INT,
	@Description VARCHAR(100)

	AS
	BEGIN
		INSERT INTO Property(Address,Price,Type,Area,Status,ContractorID,Description)
		VALUES (@Address,@Price,@Type,@Area,@Status,@ContractorID,@Description)
	END
GO

CREATE PROC [Update Property]
	@ID INT ,
	@Address VARCHAR(100),
	@Price FLOAT,
	@Type VARCHAR(100),
	@Area FLOAT,
	@Status BIT,
	@ContractorID INT,
	@Description VARCHAR(100)
	
	AS
	BEGIN
		UPDATE Property
		SET Address = @Address,
			Price = @Price,
			Type = @Type,
			Area = @Area,
			Status = @Status,
			ContractorID = @ContractorID,
			Description = @Description
		WHERE ID = @ID
	END
GO

CREATE PROC [Delete Property]
	@ID INT
	AS
	BEGIN
		DELETE FROM Property
		WHERE ID = @ID
	END
GO

CREATE PROC [Search Property By ID]
	@ID INT
	AS
	BEGIN
		SELECT ID,Address,Price,Type,Area,Status,ContractorID,Description
		FROM Property
		WHERE ID LIKE '%'+CAST( @ID AS VARCHAR(20))+'%'
	END
GO

CREATE PROC [Search Property By Type]
	@Type VARCHAR(100)
	AS
	BEGIN
		SELECT ID,Address,Price,Type,Area,Status,ContractorID,Description
		FROM Property
		WHERE Type LIKE '%' + TRIM(@Type) + '%'
	END
GO
CREATE PROC [Filter Property]
	@Address VARCHAR(100) = '',
	@Price MONEY  = 9999999999999999,
	@Type VARCHAR(100) = '',
	@Area FLOAT = 9999999999999999,
	@Status BIT = 1,
	@Description VARCHAR(100) = ''
	AS
	BEGIN
		SELECT ID,Address,Price,Type,Area,Status,ContractorID,Description
		FROM Property
		WHERE Type LIKE '%' + TRIM(@Type) + '%' OR
			Address LIKE '%' + @Address + '%' OR
			Price <= @Price+(@Price*0.25) OR
			Type LIKE '%' + @Type + '%' OR
			Area <= @Area +(@Area*0.25) OR
			Status = @Status OR
			Description LIKE '%' + @Description + '%'
	END
GO

/********************************************************
         Property Photo Stored Procedures 
*********************************************************/
CREATE PROC [Add Property Photo]
	@PropertyID INT,
	@Photo VARBINARY(MAX)
	AS
	BEGIN
		INSERT INTO PropertyPhoto
		VALUES (@PropertyID,@Photo)
	END
GO

CREATE PROC [Update Property Photo]
	@OldPhoto VARBINARY(MAX),
	@NewPhoto VARBINARY(MAX)
	AS
	BEGIN
		UPDATE PropertyPhoto
		SET Photo = @NewPhoto
		WHERE CAST(Photo AS VARBINARY(MAX)) = CAST (@OldPhoto AS VARBINARY(MAX))
	END
GO

CREATE PROC [Delete Property Photo]
	@Photo VARBINARY(MAX)
	AS
	BEGIN
		DELETE FROM PropertyPhoto
		WHERE Photo = @Photo
	END
GO

CREATE PROC [Search Property Photo By ID]
	@PropertyID INT
	AS
	BEGIN
		SELECT PropertyID, Photo
		FROM PropertyPhoto
		WHERE PropertyID LIKE '%'+CAST( @PropertyID AS VARCHAR(20))+'%'
	END
GO

CREATE PROC [Delete Property Photo By Id]
	@PropertyId INT
	AS
	BEGIN
		DELETE FROM PropertyPhoto
		WHERE PropertyID = @PropertyId
	END
GO
/********************************************************
         Buy Stored Procedures 
*********************************************************/
CREATE PROC [Add Buy]
	@PropertyId INT,
	@ClientId INT,
	@AgentId INT,
	@SellDate DATETIME,
	@Comission MONEY = 0
	AS
	BEGIN 
		INSERT INTO Buy(PropertyID,ClientID,AgentID,SellDate,Comission)
		VALUES (@PropertyId,@ClientId,@AgentId,@SellDate,@Comission)
	END
GO

CREATE PROC [Update Buy]
	@ID INT,
	@PropertyId INT,
	@ClientId INT,
	@AgentId INT,
	@SellDate DATETIME,
	@Comission MONEY
	
	AS
	BEGIN
		UPDATE Buy
		SET PropertyID = @PropertyId,
			SellDate = @SellDate,
			Comission = @Comission,
			ClientID = @ClientId, 
			AgentID = @AgentId
		WHERE ID = @ID
	END
GO

CREATE PROC [Delete Buy]
	@ID INT
	AS
	BEGIN
		DELETE FROM Buy
		WHERE ID = @ID
	END
GO

CREATE PROC [Search Buy By ClientID]
	@ClientID INT
	AS
	BEGIN
		SELECT ID,PropertyID,ClientID,AgentID,SellDate,Comission
		FROM Buy
		WHERE ClientID LIKE '%'+CAST(@ClientID  AS VARCHAR(20))+'%'
	END
GO

CREATE PROC [Search Buy By AgentId]
	@AgentId INT
	AS
	BEGIN
		SELECT ID,PropertyID,ClientID,AgentID,SellDate,Comission
		FROM Buy
		WHERE AgentID LIKE '%' + CAST(@AgentId AS VARCHAR(20))+'%'
	END
GO
CREATE PROC [Search Total Sold By Employee]
@EmpId VARCHAR(100)
AS
BEGIN
	SELECT COUNT(AgentID)
	FROM Buy
	WHERE AgentID = @EmpId
END
GO
/********************************************************
          ChoosenProperty Stored Procedures 
*********************************************************/

CREATE PROC [Add Choosen Property]
	@AppointmentId INT,
	@PropertyID INT
	AS
	BEGIN
		INSERT INTO ChoosenProperty
		VALUES (@AppointmentId,@PropertyID)
	END
GO

CREATE PROC [Update Choosen Property]
	@AppointmentId INT,
	@OldPropertyId INT,
	@NewPropertyId INT
	AS
	BEGIN
		UPDATE ChoosenProperty
		SET ID = @NewPropertyId
		WHERE ID = @OldPropertyId
	END
GO

CREATE PROC [Delete Choosen Property]
	@AppointmentId INT,
	@PropertyId INT
	AS
	BEGIN
		DELETE FROM ChoosenProperty
		WHERE ID = @AppointmentId AND PropertyID = @PropertyId
	END
GO

CREATE PROC [Search Choosen Property By Appintment]
	@AppointmentID INT
	AS
	BEGIN
		SELECT ID,PropertyID
		FROM ChoosenProperty
		WHERE ID LIKE '%'+CAST( @AppointmentID AS VARCHAR(20))+'%'
	END
GO
CREATE PROC [Search Choosen Property By Property]
	@PropertyID INT
	AS
	BEGIN
		SELECT ID,PropertyID
		FROM ChoosenProperty
		WHERE PropertyID LIKE '%'+CAST( @PropertyID AS VARCHAR(20))+'%'
	END
GO

 
/********************************************************
         Appointment Stored Procedures 
*********************************************************/
CREATE PROC [Add Appointment]
	--@Id INT,
	@AppointmentDate DATETIME,
	@Comment VARCHAR(100),
	@ClientId INT,
	@AgentId INT
	AS
	BEGIN
		INSERT INTO Appointment(AppointmentDate,Comment,ClientID,AgentID)
		VALUES (@AppointmentDate,@Comment,@ClientId,@AgentId)
	END
GO

CREATE PROC [Update Appointment]
	@Id INT,
	@AppointmentDate DATETIME,
	@Comment VARCHAR(100),
	@ClientId INT,
	@AgentId INT
	
	AS
	BEGIN
		UPDATE Appointment
		SET AppointmentDate = @AppointmentDate ,
			Comment = @Comment ,
			ClientId =  @ClientId ,
			AgentID = @AgentId
		WHERE ID = @ID
	END
GO

CREATE PROC [Delete Appointment]
	@ID INT
	AS
	BEGIN
		DELETE FROM Appointment
		WHERE ID = @ID
	END
GO

CREATE PROC [Search Appointment By ID]
	@ID INT
	AS
	BEGIN
		SELECT ID,AppointmentDate,Comment,ClientID,AgentID
		FROM Appointment
		WHERE ID LIKE '%'+CAST( @ID AS VARCHAR(20))+'%'
	END
GO

CREATE PROC [Search Appointment By ClientID]
	@ClientID INT
	AS
	BEGIN
		SELECT ID,AppointmentDate,Comment,ClientID,AgentID
		FROM Appointment
		WHERE ClientID LIKE '%'+CAST( @ClientID AS VARCHAR(20))+'%'
	END
GO
CREATE PROC [Search Appointment By AgentID]
	@AgentID INT
	AS
	BEGIN
		SELECT ID,AppointmentDate,Comment,ClientID,AgentID
		FROM Appointment
		WHERE AgentID LIKE '%'+CAST( @AgentID AS VARCHAR(20))+'%'
	END
GO
CREATE PROC [Search Appointment By Date]
	@Date DATETIME
	AS
	BEGIN
		SELECT ID,AppointmentDate,Comment,ClientID,AgentID
		FROM Appointment
		WHERE AppointmentDate LIKE '%'+CAST( @Date AS VARCHAR(20))+'%'
	END
GO
/****************************************************************************
   Creating functions 
   (to be used to populate user control initially)
****************************************************************************/
CREATE FUNCTION [Get All Employees]()
RETURNS TABLE 
AS
RETURN (
		SELECT E.ID,E.Photo,E.FirstName,E.LastName,E.PhoneNumber
		FROM Employee E JOIN Department D ON E.DepartmentID = D.ID
		)
GO
CREATE FUNCTION [Get All Clients]()
RETURNS TABLE
AS
RETURN (
		SELECT ID,Photo,FirstName,LastName,PhoneNumber
		FROM Client
		)
GO
CREATE FUNCTION [Get All Properties]()
RETURNS TABLE
AS
RETURN (
		SELECT P.ID,MIN(Ph.Photo)as [Property Photo],P.Address,P.Price,P.Status
			,SUBSTRING(P.Description,1,50)+'...' AS [Description]
		FROM Property P JOIN PropertyPhoto Ph
		ON P.ID = Ph.PropertyID
		GROUP BY P.ID,p.Address,p.Price,p.Status,P.Description
		)
GO
CREATE FUNCTION [Get All Appointments]()
RETURNS TABLE 
AS
RETURN  (
		SELECT A.ID,C.FirstName+' '+C.LastName AS [Client],E.FirstName+' '+E.LastName AS [Agent],A.AppointmentDate
				,SUBSTRING(A.Comment,1,50)+'...' AS [Comment]
		FROM Appointment A JOIN Employee E 
		ON A.AgentID = E.ID JOIN Client C
		ON A.ClientID = C.ID
		)
GO
CREATE FUNCTION [Get All Buys]()
RETURNS TABLE 
AS
RETURN (
		SELECT P.ID,C.FirstName+' '+ C.LastName AS Client,E.FirstName+' '+E.LastName AS Agent,B.Comission,B.SellDate,B.SellDate
		FROM Buy B JOIN Employee E 
		ON E.ID = B.AgentID JOIN Client C
		ON B.ClientID = C.ID JOIN Property P
		ON P.ID = B.PropertyID
		)

--login Admin function
GO
CREATE FUNCTION [Login Admin](@ID INT, @Upwd VARCHAR(100))
RETURNS BIT
AS
BEGIN
	DECLARE @pwd VARCHAR(100),@VAL BIT
	SELECT @pwd = Password 
	FROM Employee 
	WHERE DepartmentID = 0 AND ID = @ID 
	IF ((@pwd) IS NOT NULL AND @pwd = @Upwd )
		SET @VAL = 1
	ELSE 
		SET @VAL = 0

	RETURN @VAL
END
GO
CREATE FUNCTION [Login Agent](@ID INT, @Upwd VARCHAR(100))
RETURNS BIT
AS
BEGIN
	DECLARE @pwd VARCHAR(100),@VAL BIT
	SELECT @pwd = Password 
	FROM Employee 
	WHERE DepartmentID = 1 AND ID = @ID 
	IF ((@pwd) IS NOT NULL AND @pwd = @Upwd )
		SET @VAL = 1
	ELSE 
		SET @VAL = 0

	RETURN @VAL
END

GO
CREATE FUNCTION [Login Client](@ID INT, @Upwd VARCHAR(100))
RETURNS BIT
AS
BEGIN
	DECLARE @pwd VARCHAR(100),@VAL BIT
	SELECT @pwd = Password 
	FROM Client
	WHERE ID = @ID AND @pwd = Password
	IF ((@pwd) IS NOT NULL )
		SET @VAL = 1
	ELSE 
		SET @VAL = 0

	RETURN @VAL
END
GO
--edit string
CREATE FUNCTION [Clean Names](@name VARCHAR(100))
RETURNS VARCHAR(100)
AS
BEGIN
	RETURN (
			UPPER( SUBSTRING(TRIM(@name),1,1))+LOWER(SUBSTRING (TRIM(@name),2,LEN(TRIM(@name))))
			)
END
GO
/**********************************************************
				Creating triggers
**********************************************************/
CREATE TRIGGER [Clean Employee Names]
ON Employee
INSTEAD OF INSERT, UPDATE
AS 
BEGIN
	INSERT INTO Employee(FirstName,LastName,PhoneNumber,Password,Photo,EmpType,EmpDate,DepartmentID)
	(
	SELECT dbo.[Clean Names](FirstName)	,dbo.[Clean Names](LastName), PhoneNumber,Password,Photo,EmpType,EmpDate,DepartmentID 
	FROM INSERTED
	)
END
GO
CREATE TRIGGER [Assign Agents]
ON Client 
INSTEAD OF INSERT
AS
BEGIN
	INSERT INTO Client(FirstName,LastName,Photo,PhoneNumber,Email,Password,EmpId) 
	(
	SELECT dbo.[Clean Names]( FirstName),dbo.[Clean Names]( LastName),Photo,PhoneNumber,Email,Password,(SELECT TOP 1 EmpId FROM Client GROUP BY EmpId ORDER BY COUNT(EmpId)  )
	FROM INSERTED
	)
	SELECT EmpId FROM Client GROUP BY EmpId ORDER BY EmpId 
END
GO
CREATE TRIGGER [Property Photo Limit]
ON PropertyPhoto
INSTEAD OF INSERT
AS
BEGIN
	IF ((SELECT COUNT(*) FROM PropertyPhoto WHERE PropertyID = (SELECT PropertyID FROM PropertyPhoto)) < 5)
		INSERT INTO PropertyPhoto(PropertyID,Photo)
		(
			SELECT PropertyID,Photo
			FROM INSERTED
		)
	ELSE 
		RAISERROR('Cannot insert more than 5 photos for one property',16,1)

END
GO
CREATE TRIGGER [Clean Appointment]
ON Appointment
INSTEAD OF INSERT
AS
BEGIN
	IF ((SELECT AppointmentDate FROM inserted)>GETDATE())
	INSERT INTO Appointment(AppointmentDate,Comment,ClientID,AgentID)
	(
		SELECT AppointmentDate,trim(Comment),ClientID,AgentID
		FROM INSERTED
	)
	ELSE 
		RAISERROR('Cannot insert appointment date before the current date',16,1)
END
GO
CREATE TRIGGER [Clean Department]
ON Department
INSTEAD OF INSERT
AS
BEGIN
	INSERT INTO Department(Name)
	(
		SELECT dbo.[Clean Names](name)
		FROM INSERTED
	)
END
GO
/*******************************************************
		creating logins
********************************************************/
CREATE LOGIN [Admin Login] WITH PASSWORD = '0'
	CREATE USER [Admin] FOR LOGIN [Admin Login]

CREATE LOGIN [Agent Login] WITH PASSWORD = '0'
	CREATE USER [Agent] FOR LOGIN [Agent Login]

CREATE LOGIN [Customer Login] WITH PASSWORD = '0'
	CREATE USER [Customer] FOR LOGIN [Customer Login]

GO
USE RealEstate
--					Admin permissions

GRANT EXECUTE ON [dbo].[Search Choosen Property By Appintment] TO [Admin]
GRANT EXECUTE ON [dbo].[Update Property] TO [Admin]
GRANT EXECUTE ON [dbo].[Search Choosen Property By Property] TO [Admin]
GRANT EXECUTE ON [dbo].[Search Appointment By ID] TO [Admin]
GRANT EXECUTE ON [dbo].[Update Client] TO [Admin]
GRANT EXECUTE ON [dbo].[Add Choosen Property] TO [Admin]
GRANT EXECUTE ON [dbo].[Update Contractor] TO [Admin]
GRANT EXECUTE ON [dbo].[Add Buy] TO [Admin]
GRANT EXECUTE ON [dbo].[Search Appointment By AgentID] TO [Admin]
GRANT EXECUTE ON [dbo].[Delete Property Photo By Id] TO [Admin]
GRANT EXECUTE ON [dbo].[Update Employee] TO [Admin]
GRANT SELECT ON [dbo].[Get All Properties] TO [Admin]
GRANT EXECUTE ON [dbo].[Search Client By Name] TO [Admin]
GRANT EXECUTE ON [dbo].[Search Buy By ClientID] TO [Admin]
GRANT EXECUTE ON [dbo].[Add Property Photo] TO [Admin]
GRANT EXECUTE ON [dbo].[Update Choosen Property] TO [Admin]
GRANT EXECUTE ON [dbo].[Delete Employee] TO [Admin]
GRANT EXECUTE ON [dbo].[Add Appointment] TO [Admin]
GRANT EXECUTE ON [dbo].[Search Employee By Name] TO [Admin]
GRANT EXECUTE ON [dbo].[Add Contractor] TO [Admin]
GRANT EXECUTE ON [dbo].[Search Property Photo By ID] TO [Admin]
GRANT EXECUTE ON [dbo].[Delete Appointment] TO [Admin]
GRANT EXECUTE ON [dbo].[Search Department By Name] TO [Admin]
GRANT EXECUTE ON [dbo].[Delete Property] TO [Admin]
GRANT EXECUTE ON [dbo].[Delete Property Photo] TO [Admin]
GRANT EXECUTE ON [dbo].[Add Property] TO [Admin]
GRANT EXECUTE ON [dbo].[Search Employee By ID] TO [Admin]
GRANT EXECUTE ON [dbo].[Search Total Sold By Employee] TO [Admin]
GRANT EXECUTE ON [dbo].[Search Property By ID] TO [Admin]
GRANT EXECUTE ON [dbo].[Delete Department] TO [Admin]
GRANT EXECUTE ON [dbo].[Search Client By ID] TO [Admin]
GRANT EXECUTE ON [dbo].[Add Employee] TO [Admin]
GRANT EXECUTE ON [dbo].[Add Department] TO [Admin]
GRANT EXECUTE ON [dbo].[Search Contractor By Name] TO [Admin]
GRANT EXECUTE ON [dbo].[Search Appointment By Date] TO [Admin]
GRANT SELECT ON [dbo].[Get All Appointments] TO [Admin]
GRANT SELECT ON [dbo].[Get All Employees] TO [Admin]
GRANT EXECUTE ON [dbo].[Update Property Photo] TO [Admin]
GRANT EXECUTE ON [dbo].[Search Contractor By Id] TO [Admin]
GRANT EXECUTE ON [dbo].[Delete Contractor] TO [Admin]
GRANT EXECUTE ON [dbo].[Update Department] TO [Admin]
GRANT EXECUTE ON [dbo].[Filter Property] TO [Admin]
GRANT EXECUTE ON [dbo].[Update Buy] TO [Admin]
GRANT EXECUTE ON [dbo].[Search Department By ID] TO [Admin]
GRANT SELECT ON [dbo].[Get All Clients] TO [Admin]
GRANT EXECUTE ON [dbo].[Delete Choosen Property] TO [Admin]
GRANT EXECUTE ON [dbo].[Update Appointment] TO [Admin]
GRANT EXECUTE ON [dbo].[Search Buy By AgentId] TO [Admin]
GRANT EXECUTE ON [dbo].[Search Property By Type] TO [Admin]
GRANT EXECUTE ON [dbo].[Add Client] TO [Admin]
GRANT EXECUTE ON [dbo].[Delete Client] TO [Admin]
GRANT EXECUTE ON [dbo].[Delete Buy] TO [Admin]
GRANT EXECUTE ON [dbo].[Search Appointment By ClientID] TO [Admin]

--			Agent permissions
USE RealEstate
GRANT EXECUTE ON [dbo].[Search Choosen Property By Appintment] TO [Agent]
GRANT EXECUTE ON [dbo].[Update Property] TO [Agent]
GRANT EXECUTE ON [dbo].[Search Choosen Property By Property] TO [Agent]
GRANT EXECUTE ON [dbo].[Search Appointment By ID] TO [Agent]
GRANT EXECUTE ON [dbo].[Update Client] TO [Agent]
GRANT EXECUTE ON [dbo].[Add Choosen Property] TO [Agent]
GRANT EXECUTE ON [dbo].[Search Appointment By AgentID] TO [Agent]
GRANT EXECUTE ON [dbo].[Delete Property Photo By Id] TO [Agent]
GRANT EXECUTE ON [dbo].[Update Employee] TO [Agent]
GRANT SELECT ON [dbo].[Get All Properties] TO [Agent]
GRANT EXECUTE ON [dbo].[Search Client By Name] TO [Agent]
GRANT EXECUTE ON [dbo].[Add Property Photo] TO [Agent]
GRANT EXECUTE ON [dbo].[Update Choosen Property] TO [Agent]
GRANT EXECUTE ON [dbo].[Delete Employee] TO [Agent]
GRANT EXECUTE ON [dbo].[Search Property Photo By ID] TO [Agent]
GRANT EXECUTE ON [dbo].[Search Department By Name] TO [Agent]
GRANT EXECUTE ON [dbo].[Delete Property] TO [Agent]
GRANT EXECUTE ON [dbo].[Delete Property Photo] TO [Agent]
GRANT EXECUTE ON [dbo].[Add Property] TO [Agent]
GRANT EXECUTE ON [dbo].[Search Employee By ID] TO [Agent]
GRANT EXECUTE ON [dbo].[Search Total Sold By Employee] TO [Agent]
GRANT EXECUTE ON [dbo].[Search Property By ID] TO [Agent]
GRANT EXECUTE ON [dbo].[Search Client By ID] TO [Agent]
GRANT EXECUTE ON [dbo].[Add Employee] TO [Agent]
GRANT EXECUTE ON [dbo].[Search Appointment By Date] TO [Agent]
GRANT SELECT ON [dbo].[Get All Appointments] TO [Agent]
GRANT EXECUTE ON [dbo].[Update Property Photo] TO [Agent]
GRANT EXECUTE ON [dbo].[Filter Property] TO [Agent]
GRANT EXECUTE ON [dbo].[Search Department By ID] TO [Agent]
GRANT SELECT ON [dbo].[Get All Clients] TO [Agent]
GRANT EXECUTE ON [dbo].[Delete Choosen Property] TO [Agent]
GRANT EXECUTE ON [dbo].[Search Buy By AgentId] TO [Agent]
GRANT EXECUTE ON [dbo].[Search Property By Type] TO [Agent]

---			Customer/client permissions
USE RealEstate
GRANT EXECUTE ON [dbo].[Search Choosen Property By Appintment] TO [Customer]
GRANT EXECUTE ON [dbo].[Search Choosen Property By Property] TO [Customer]
GRANT EXECUTE ON [dbo].[Search Appointment By ID] TO [Customer]
GRANT EXECUTE ON [dbo].[Update Client] TO [Customer]
GRANT EXECUTE ON [dbo].[Add Choosen Property] TO [Customer]
GRANT SELECT ON [dbo].[Get All Properties] TO [Customer]
GRANT EXECUTE ON [dbo].[Search Client By Name] TO [Customer]
GRANT EXECUTE ON [dbo].[Search Buy By ClientID] TO [Customer]
GRANT EXECUTE ON [dbo].[Add Appointment] TO [Customer]
GRANT EXECUTE ON [dbo].[Search Employee By Name] TO [Customer]
GRANT EXECUTE ON [dbo].[Search Property Photo By ID] TO [Customer]
GRANT EXECUTE ON [dbo].[Delete Appointment] TO [Customer]
GRANT EXECUTE ON [dbo].[Search Employee By ID] TO [Customer]
GRANT EXECUTE ON [dbo].[Search Property By ID] TO [Customer]
GRANT EXECUTE ON [dbo].[Search Client By ID] TO [Customer]
GRANT EXECUTE ON [dbo].[Search Appointment By Date] TO [Customer]
GRANT SELECT ON [dbo].[Get All Appointments] TO [Customer]
GRANT EXECUTE ON [dbo].[Filter Property] TO [Customer]
GRANT EXECUTE ON [dbo].[Update Appointment] TO [Customer]
GRANT EXECUTE ON [dbo].[Search Property By Type] TO [Customer]
GRANT EXECUTE ON [dbo].[Add Client] TO [Customer]
GRANT EXECUTE ON [dbo].[Delete Client] TO [Customer]
GRANT EXECUTE ON [dbo].[Search Appointment By ClientID] TO [Customer]


