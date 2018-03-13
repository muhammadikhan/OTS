/****** Object:  Table [dbo].[TailorRider]    Script Date: 03/13/2018 22:19:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TailorRider](
	[T_RiderID] [int] IDENTITY(1,1) NOT NULL,
	[Profile_Name] [nvarchar](max) NOT NULL,
	[Password] [nvarchar](20) NOT NULL,
	[First_Name] [char](10) NOT NULL,
	[Middle_Name] [char](10) NULL,
	[Last_Name] [char](10) NOT NULL,
	[Email_Address] [nvarchar](max) NOT NULL,
	[Contact_Number] [int] NOT NULL,
	[Cell_Number] [int] NULL,
	[QR_Code] [nvarchar](50) NOT NULL,
	[Rating] [int] NOT NULL,
	[Created_DateTime] [datetime] NOT NULL,
	[Created_By] [int] NOT NULL,
	[Modified_DateTime] [datetime] NOT NULL,
	[Modified_By] [int] NOT NULL,
	[Deleted] [bit] NOT NULL,
 CONSTRAINT [PK_TailorRider] PRIMARY KEY CLUSTERED 
(
	[T_RiderID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TailorCategory]    Script Date: 03/13/2018 22:19:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TailorCategory](
	[TailorCategory_ID] [int] NOT NULL,
	[TailorCategory_Name] [nvarchar](50) NOT NULL,
	[TailorCategory_Rating] [int] NOT NULL,
	[TailorCategory_Days] [int] NOT NULL,
	[DressCategory_ID] [int] NOT NULL,
	[Tailor_ID] [int] NOT NULL,
	[Created_DateTime] [datetime] NOT NULL,
	[Created_By] [int] NOT NULL,
	[Modified_DateTime] [datetime] NOT NULL,
	[Modified_By] [int] IDENTITY(1,1) NOT NULL,
	[Deleted] [char](1) NOT NULL,
 CONSTRAINT [PK_TailorCategory] PRIMARY KEY CLUSTERED 
(
	[TailorCategory_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tailor]    Script Date: 03/13/2018 22:19:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tailor](
	[Tailor_ID] [int] IDENTITY(1,1) NOT NULL,
	[Profile_Name] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](max) NOT NULL,
	[First_Name] [char](10) NOT NULL,
	[Middle_Name] [char](10) NULL,
	[Last_Name] [char](10) NOT NULL,
	[Email_Address] [nvarchar](50) NOT NULL,
	[Contact_Number] [int] NOT NULL,
	[Cell_Number] [int] NULL,
	[Location_ID] [int] NOT NULL,
	[PickUp_Address] [nvarchar](max) NOT NULL,
	[Drop_Address] [nvarchar](max) NOT NULL,
	[QR_Code] [nvarchar](50) NOT NULL,
	[Rating] [int] NOT NULL,
	[Created_DateTime] [datetime] NOT NULL,
	[Created_By] [int] NOT NULL,
	[Modified_DateTime] [datetime] NOT NULL,
	[Modified_By] [int] NOT NULL,
	[Deleted] [bit] NOT NULL,
 CONSTRAINT [PK_Tailor] PRIMARY KEY CLUSTERED 
(
	[Tailor_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Status]    Script Date: 03/13/2018 22:19:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Status](
	[Status_ID] [int] IDENTITY(1,1) NOT NULL,
	[Status_Name] [nvarchar](50) NOT NULL,
	[Created_DateTime] [datetime] NOT NULL,
	[Created_By] [int] NOT NULL,
	[Modified_DateTime] [datetime] NOT NULL,
	[Modified_By] [int] NOT NULL,
	[Deleted] [bit] NOT NULL,
 CONSTRAINT [PK_Status] PRIMARY KEY CLUSTERED 
(
	[Status_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order]    Script Date: 03/13/2018 22:19:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[Order_ID] [int] NOT NULL,
	[Client_ID] [int] NOT NULL,
	[C_Rider_ID] [int] NOT NULL,
	[Warehouse_ID] [int] NOT NULL,
	[T_Rider_ID] [int] NOT NULL,
	[Tailor_ID] [int] NOT NULL,
	[DressDetails_ID] [int] NOT NULL,
	[ClientSample_ID] [int] NULL,
	[Status_ID] [int] NOT NULL,
	[QR_Code] [nvarchar](50) NOT NULL,
	[Remarks] [nvarchar](50) NOT NULL,
	[Offer_ID] [int] NOT NULL,
	[Created_DateTime] [datetime] NOT NULL,
	[Created_By] [int] IDENTITY(1,1) NOT NULL,
	[Modified_DateTime] [datetime] NOT NULL,
	[Modified_By] [int] NOT NULL,
	[Deleted] [bit] NOT NULL,
 CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED 
(
	[Order_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Offers]    Script Date: 03/13/2018 22:19:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Offers](
	[Offer_ID] [int] IDENTITY(1,1) NOT NULL,
	[Offer_Name] [nvarchar](50) NOT NULL,
	[Offer_Event] [nvarchar](50) NOT NULL,
	[Offer_Valid_From] [datetime] NOT NULL,
	[Offer_Valid_Till] [datetime] NOT NULL,
	[Created_DateTime] [datetime] NOT NULL,
	[Created_By] [int] NOT NULL,
	[Modified_DateTime] [datetime] NOT NULL,
	[Modified_By] [int] NOT NULL,
	[Deleted] [bit] NOT NULL,
 CONSTRAINT [PK_Offers] PRIMARY KEY CLUSTERED 
(
	[Offer_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Locations]    Script Date: 03/13/2018 22:19:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Locations](
	[Location_ID] [int] NOT NULL,
	[Area_ID] [int] NOT NULL,
	[Map_ID] [int] NOT NULL,
	[City_ID] [int] NOT NULL,
	[Country_ID] [int] NOT NULL,
	[Created_DateTime] [datetime] NOT NULL,
	[Created_By] [int] NOT NULL,
	[Modified_DateTime] [datetime] NOT NULL,
	[Modified_By] [int] NOT NULL,
	[Deleted] [bit] NOT NULL,
 CONSTRAINT [PK_Locations] PRIMARY KEY CLUSTERED 
(
	[Location_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Entity_Order_Timeframe]    Script Date: 03/13/2018 22:19:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Entity_Order_Timeframe](
	[OrderTimeframe_ID] [int] IDENTITY(1,1) NOT NULL,
	[Order_ID] [int] NOT NULL,
	[Entity_ID] [int] NOT NULL,
	[Estimated_DateTime] [datetime] NOT NULL,
	[Actual_DateTime] [datetime] NOT NULL,
	[Pick] [datetime] NOT NULL,
	[Drop] [datetime] NOT NULL,
	[Created_DateTime] [datetime] NOT NULL,
	[Created_By] [int] NOT NULL,
	[Modified_DateTime] [datetime] NOT NULL,
	[Modified_By] [int] NOT NULL,
	[Deleted] [bit] NOT NULL,
 CONSTRAINT [PK_Entity_Order_Timeframe] PRIMARY KEY CLUSTERED 
(
	[OrderTimeframe_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Entity_Offer]    Script Date: 03/13/2018 22:19:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Entity_Offer](
	[Entity_Offer_ID] [int] NOT NULL,
	[Entity_ID] [int] IDENTITY(1,1) NOT NULL,
	[Offer_ID] [int] NOT NULL,
	[DressDetails_ID] [int] NOT NULL,
	[Rate] [int] NOT NULL,
	[Percentage_Discount] [nvarchar](50) NOT NULL,
	[Flat_Discount] [nvarchar](50) NOT NULL,
	[Created_DateTime] [datetime] NOT NULL,
	[Created_By] [int] NOT NULL,
	[Modified_DateTime] [datetime] NOT NULL,
	[Modified_By] [int] NOT NULL,
	[Deleted] [bit] NOT NULL,
 CONSTRAINT [PK_Entity_Offer] PRIMARY KEY CLUSTERED 
(
	[Entity_Offer_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Entity]    Script Date: 03/13/2018 22:19:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Entity](
	[Entity_ID] [int] IDENTITY(1,1) NOT NULL,
	[Entity_Name] [nvarchar](50) NOT NULL,
	[Created_DateTime] [datetime] NOT NULL,
	[Created_By] [int] NOT NULL,
	[Modified_DateTime] [datetime] NOT NULL,
	[Modified_By] [int] NOT NULL,
	[Deleted] [bit] NOT NULL,
 CONSTRAINT [PK_Entity] PRIMARY KEY CLUSTERED 
(
	[Entity_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DressType]    Script Date: 03/13/2018 22:19:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DressType](
	[DressType_ID] [int] IDENTITY(1,1) NOT NULL,
	[DressType_Name] [nvarchar](50) NOT NULL,
	[Created_DateTime] [datetime] NOT NULL,
	[Created_By] [int] NOT NULL,
	[Modified_DateTime] [datetime] NOT NULL,
	[Modified_By] [int] NOT NULL,
	[Deleted] [bit] NOT NULL,
 CONSTRAINT [PK_DressType] PRIMARY KEY CLUSTERED 
(
	[DressType_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DressStyle]    Script Date: 03/13/2018 22:19:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DressStyle](
	[DressStyle_ID] [int] IDENTITY(1,1) NOT NULL,
	[DressStyle_Name] [nvarchar](50) NOT NULL,
	[Created_DateTime] [datetime] NOT NULL,
	[Created_By] [int] NOT NULL,
	[Modified_DateTime] [datetime] NOT NULL,
	[Modified_By] [int] NOT NULL,
	[Deleted] [bit] NOT NULL,
 CONSTRAINT [PK_DressStyle] PRIMARY KEY CLUSTERED 
(
	[DressStyle_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DressDetails]    Script Date: 03/13/2018 22:19:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DressDetails](
	[DressDetails_ID] [int] IDENTITY(1,1) NOT NULL,
	[DressCategory_ID] [int] NOT NULL,
	[DressType_ID] [int] NOT NULL,
	[DressStyle_ID] [int] NOT NULL,
	[Dimension_ID] [int] NOT NULL,
	[Created_DateTime] [datetime] NOT NULL,
	[Created_By] [int] NOT NULL,
	[Modified_DateTime] [datetime] NOT NULL,
	[Modified_By] [int] NOT NULL,
	[Deleted] [bit] NOT NULL,
 CONSTRAINT [PK_DressDetails] PRIMARY KEY CLUSTERED 
(
	[DressDetails_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DressCategory]    Script Date: 03/13/2018 22:19:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DressCategory](
	[DressCategory_ID] [int] IDENTITY(1,1) NOT NULL,
	[DressCategory_Name] [nvarchar](50) NOT NULL,
	[Created_DateTime] [datetime] NOT NULL,
	[Created_By] [int] NOT NULL,
	[Modified_DateTime] [datetime] NOT NULL,
	[Modified_By] [int] NOT NULL,
	[Deleted] [bit] NOT NULL,
 CONSTRAINT [PK_DressCategory] PRIMARY KEY CLUSTERED 
(
	[DressCategory_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Dimension]    Script Date: 03/13/2018 22:19:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dimension](
	[Dimension_ID] [int] NOT NULL,
	[Dimension_Name] [nvarchar](50) NOT NULL,
	[Dimension_Value] [int] NOT NULL,
	[Created_DateTime] [datetime] NOT NULL,
	[Created_By] [int] NOT NULL,
	[Modified_DateTime] [datetime] NOT NULL,
	[Modified_By] [int] IDENTITY(1,1) NOT NULL,
	[Deleted] [bit] NOT NULL,
 CONSTRAINT [PK_Dimension] PRIMARY KEY CLUSTERED 
(
	[Dimension_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ClientSample]    Script Date: 03/13/2018 22:19:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ClientSample](
	[ClientSample_ID] [int] NOT NULL,
	[ClientSample_Name] [varchar](50) NOT NULL,
	[ClientSample_QR_Code] [nvarchar](50) NOT NULL,
	[Created_DateTime] [datetime] NOT NULL,
	[Created_By] [int] NOT NULL,
	[Modified_DateTime] [datetime] NOT NULL,
	[Modified_By] [int] IDENTITY(1,1) NOT NULL,
	[Deleted] [bit] NOT NULL,
 CONSTRAINT [PK_ClientSample] PRIMARY KEY CLUSTERED 
(
	[ClientSample_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ClientRider]    Script Date: 03/13/2018 22:19:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ClientRider](
	[C_RiderID] [int] IDENTITY(1,1) NOT NULL,
	[Profile_Name] [nvarchar](max) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[First_Name] [char](10) NOT NULL,
	[Middle_Name] [char](10) NULL,
	[Last_Name] [char](10) NOT NULL,
	[Email_Address] [nvarchar](50) NOT NULL,
	[Contact_Number] [int] NOT NULL,
	[Cell_Number] [int] NULL,
	[QR_Code] [nvarchar](max) NOT NULL,
	[Rating] [int] NOT NULL,
	[Created_DateTime] [datetime] NOT NULL,
	[Created_By] [int] NOT NULL,
	[Modified_DateTime] [datetime] NOT NULL,
	[Modified_By] [int] NOT NULL,
	[Deleted] [bit] NOT NULL,
 CONSTRAINT [PK_ClientRider] PRIMARY KEY CLUSTERED 
(
	[C_RiderID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Client]    Script Date: 03/13/2018 22:19:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Client](
	[Client_ID] [int] IDENTITY(1,1) NOT NULL,
	[Profile_Name] [nvarchar](100) NOT NULL,
	[Password] [nvarchar](max) NOT NULL,
	[First_Name] [nvarchar](20) NOT NULL,
	[Middle_Name] [nvarchar](20) NULL,
	[Last_Name] [nvarchar](20) NOT NULL,
	[Email_Address] [nvarchar](max) NOT NULL,
	[Contact_Number] [int] NULL,
	[Cell_Number] [int] NOT NULL,
	[Location_ID] [int] NOT NULL,
	[PickUp_Address] [nvarchar](max) NOT NULL,
	[Drop_Address] [nvarchar](max) NOT NULL,
	[QR_Code] [nvarchar](50) NOT NULL,
	[Rating] [int] NOT NULL,
	[Created_DateTime] [datetime2](7) NOT NULL,
	[Created_By] [int] NOT NULL,
	[Modified_DateTime] [datetime2](7) NOT NULL,
	[Modified_By] [int] NOT NULL,
	[Deleted] [bit] NOT NULL,
 CONSTRAINT [PK_Client] PRIMARY KEY CLUSTERED 
(
	[Client_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Warehouse]    Script Date: 03/13/2018 22:19:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Warehouse](
	[Warehouse_ID] [int] IDENTITY(1,1) NOT NULL,
	[Warehouse_Name] [nvarchar](max) NOT NULL,
	[Onwer_Name] [char](20) NOT NULL,
	[Onwer_Details] [nvarchar](max) NOT NULL,
	[Landline_Number] [int] NOT NULL,
	[Fax_Number] [int] NULL,
	[Email_Address] [nvarchar](50) NOT NULL,
	[Contact_Number] [int] NOT NULL,
	[Cell_Number] [int] NULL,
	[Location_ID] [int] NOT NULL,
	[QR_Code] [nvarchar](50) NOT NULL,
	[Rating] [int] NOT NULL,
	[Created_DateTime] [datetime] NOT NULL,
	[Created_By] [int] NOT NULL,
	[Modified_DateTime] [datetime] NOT NULL,
	[Modified_By] [int] NOT NULL,
	[Deleted] [bit] NOT NULL,
 CONSTRAINT [PK_Warehouse] PRIMARY KEY CLUSTERED 
(
	[Warehouse_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[usp_WarehouseUpdate]    Script Date: 03/13/2018 22:19:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_WarehouseUpdate] 
    @Warehouse_ID int,
    @Warehouse_Name nvarchar(MAX),
    @Onwer_Name char(20),
    @Onwer_Details nvarchar(MAX),
    @Landline_Number int,
    @Fax_Number int = NULL,
    @Email_Address nvarchar(50),
    @Contact_Number int,
    @Cell_Number int = NULL,
    @Location_ID int,
    @QR_Code nvarchar(50),
    @Rating int,
    @Created_DateTime datetime,
    @Created_By int,
    @Modified_DateTime datetime,
    @Modified_By int,
    @Deleted bit
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	UPDATE [dbo].[Warehouse]
	SET    [Warehouse_Name] = @Warehouse_Name, [Onwer_Name] = @Onwer_Name, [Onwer_Details] = @Onwer_Details, [Landline_Number] = @Landline_Number, [Fax_Number] = @Fax_Number, [Email_Address] = @Email_Address, [Contact_Number] = @Contact_Number, [Cell_Number] = @Cell_Number, [Location_ID] = @Location_ID, [QR_Code] = @QR_Code, [Rating] = @Rating, [Created_DateTime] = @Created_DateTime, [Created_By] = @Created_By, [Modified_DateTime] = @Modified_DateTime, [Modified_By] = @Modified_By, [Deleted] = @Deleted
	WHERE  [Warehouse_ID] = @Warehouse_ID
	
	-- Begin Return Select <- do not remove
	SELECT [Warehouse_ID], [Warehouse_Name], [Onwer_Name], [Onwer_Details], [Landline_Number], [Fax_Number], [Email_Address], [Contact_Number], [Cell_Number], [Location_ID], [QR_Code], [Rating], [Created_DateTime], [Created_By], [Modified_DateTime], [Modified_By], [Deleted]
	FROM   [dbo].[Warehouse]
	WHERE  [Warehouse_ID] = @Warehouse_ID	
	-- End Return Select <- do not remove

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_WarehouseSelect]    Script Date: 03/13/2018 22:19:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_WarehouseSelect] 
    @Warehouse_ID int
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN TRAN

	SELECT [Warehouse_ID], [Warehouse_Name], [Onwer_Name], [Onwer_Details], [Landline_Number], [Fax_Number], [Email_Address], [Contact_Number], [Cell_Number], [Location_ID], [QR_Code], [Rating], [Created_DateTime], [Created_By], [Modified_DateTime], [Modified_By], [Deleted] 
	FROM   [dbo].[Warehouse] 
	WHERE  ([Warehouse_ID] = @Warehouse_ID OR @Warehouse_ID IS NULL) 

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_WarehouseInsert]    Script Date: 03/13/2018 22:19:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_WarehouseInsert] 
    @Warehouse_Name nvarchar(MAX),
    @Onwer_Name char(20),
    @Onwer_Details nvarchar(MAX),
    @Landline_Number int,
    @Fax_Number int = NULL,
    @Email_Address nvarchar(50),
    @Contact_Number int,
    @Cell_Number int = NULL,
    @Location_ID int,
    @QR_Code nvarchar(50),
    @Rating int,
    @Created_DateTime datetime,
    @Created_By int,
    @Modified_DateTime datetime,
    @Modified_By int,
    @Deleted bit
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN
	
	INSERT INTO [dbo].[Warehouse] ([Warehouse_Name], [Onwer_Name], [Onwer_Details], [Landline_Number], [Fax_Number], [Email_Address], [Contact_Number], [Cell_Number], [Location_ID], [QR_Code], [Rating], [Created_DateTime], [Created_By], [Modified_DateTime], [Modified_By], [Deleted])
	SELECT @Warehouse_Name, @Onwer_Name, @Onwer_Details, @Landline_Number, @Fax_Number, @Email_Address, @Contact_Number, @Cell_Number, @Location_ID, @QR_Code, @Rating, @Created_DateTime, @Created_By, @Modified_DateTime, @Modified_By, @Deleted
	
	-- Begin Return Select <- do not remove
	SELECT [Warehouse_ID], [Warehouse_Name], [Onwer_Name], [Onwer_Details], [Landline_Number], [Fax_Number], [Email_Address], [Contact_Number], [Cell_Number], [Location_ID], [QR_Code], [Rating], [Created_DateTime], [Created_By], [Modified_DateTime], [Modified_By], [Deleted]
	FROM   [dbo].[Warehouse]
	WHERE  [Warehouse_ID] = SCOPE_IDENTITY()
	-- End Return Select <- do not remove
               
	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_WarehouseDelete]    Script Date: 03/13/2018 22:19:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_WarehouseDelete] 
    @Warehouse_ID int
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	DELETE
	FROM   [dbo].[Warehouse]
	WHERE  [Warehouse_ID] = @Warehouse_ID

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_TailorUpdate]    Script Date: 03/13/2018 22:19:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_TailorUpdate] 
    @Tailor_ID int,
    @Profile_Name nvarchar(50),
    @Password nvarchar(MAX),
    @First_Name char(10),
    @Middle_Name char(10) = NULL,
    @Last_Name char(10),
    @Email_Address nvarchar(50),
    @Contact_Number int,
    @Cell_Number int = NULL,
    @Location_ID int,
    @PickUp_Address nvarchar(MAX),
    @Drop_Address nvarchar(MAX),
    @QR_Code nvarchar(50),
    @Rating int,
    @Created_DateTime datetime,
    @Created_By int,
    @Modified_DateTime datetime,
    @Modified_By int,
    @Deleted bit
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	UPDATE [dbo].[Tailor]
	SET    [Profile_Name] = @Profile_Name, [Password] = @Password, [First_Name] = @First_Name, [Middle_Name] = @Middle_Name, [Last_Name] = @Last_Name, [Email_Address] = @Email_Address, [Contact_Number] = @Contact_Number, [Cell_Number] = @Cell_Number, [Location_ID] = @Location_ID, [PickUp_Address] = @PickUp_Address, [Drop_Address] = @Drop_Address, [QR_Code] = @QR_Code, [Rating] = @Rating, [Created_DateTime] = @Created_DateTime, [Created_By] = @Created_By, [Modified_DateTime] = @Modified_DateTime, [Modified_By] = @Modified_By, [Deleted] = @Deleted
	WHERE  [Tailor_ID] = @Tailor_ID
	
	-- Begin Return Select <- do not remove
	SELECT [Tailor_ID], [Profile_Name], [Password], [First_Name], [Middle_Name], [Last_Name], [Email_Address], [Contact_Number], [Cell_Number], [Location_ID], [PickUp_Address], [Drop_Address], [QR_Code], [Rating], [Created_DateTime], [Created_By], [Modified_DateTime], [Modified_By], [Deleted]
	FROM   [dbo].[Tailor]
	WHERE  [Tailor_ID] = @Tailor_ID	
	-- End Return Select <- do not remove

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_TailorSelect]    Script Date: 03/13/2018 22:19:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_TailorSelect] 
    @Tailor_ID int
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN TRAN

	SELECT [Tailor_ID], [Profile_Name], [Password], [First_Name], [Middle_Name], [Last_Name], [Email_Address], [Contact_Number], [Cell_Number], [Location_ID], [PickUp_Address], [Drop_Address], [QR_Code], [Rating], [Created_DateTime], [Created_By], [Modified_DateTime], [Modified_By], [Deleted] 
	FROM   [dbo].[Tailor] 
	WHERE  ([Tailor_ID] = @Tailor_ID OR @Tailor_ID IS NULL) 

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_TailorRiderUpdate]    Script Date: 03/13/2018 22:19:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_TailorRiderUpdate] 
    @T_RiderID int,
    @Profile_Name nvarchar(MAX),
    @Password nvarchar(20),
    @First_Name char(10),
    @Middle_Name char(10) = NULL,
    @Last_Name char(10),
    @Email_Address nvarchar(MAX),
    @Contact_Number int,
    @Cell_Number int = NULL,
    @QR_Code nvarchar(50),
    @Rating int,
    @Created_DateTime datetime,
    @Created_By int,
    @Modified_DateTime datetime,
    @Modified_By int,
    @Deleted bit
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	UPDATE [dbo].[TailorRider]
	SET    [Profile_Name] = @Profile_Name, [Password] = @Password, [First_Name] = @First_Name, [Middle_Name] = @Middle_Name, [Last_Name] = @Last_Name, [Email_Address] = @Email_Address, [Contact_Number] = @Contact_Number, [Cell_Number] = @Cell_Number, [QR_Code] = @QR_Code, [Rating] = @Rating, [Created_DateTime] = @Created_DateTime, [Created_By] = @Created_By, [Modified_DateTime] = @Modified_DateTime, [Modified_By] = @Modified_By, [Deleted] = @Deleted
	WHERE  [T_RiderID] = @T_RiderID
	
	-- Begin Return Select <- do not remove
	SELECT [T_RiderID], [Profile_Name], [Password], [First_Name], [Middle_Name], [Last_Name], [Email_Address], [Contact_Number], [Cell_Number], [QR_Code], [Rating], [Created_DateTime], [Created_By], [Modified_DateTime], [Modified_By], [Deleted]
	FROM   [dbo].[TailorRider]
	WHERE  [T_RiderID] = @T_RiderID	
	-- End Return Select <- do not remove

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_TailorRiderSelect]    Script Date: 03/13/2018 22:19:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_TailorRiderSelect] 
    @T_RiderID int
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN TRAN

	SELECT [T_RiderID], [Profile_Name], [Password], [First_Name], [Middle_Name], [Last_Name], [Email_Address], [Contact_Number], [Cell_Number], [QR_Code], [Rating], [Created_DateTime], [Created_By], [Modified_DateTime], [Modified_By], [Deleted] 
	FROM   [dbo].[TailorRider] 
	WHERE  ([T_RiderID] = @T_RiderID OR @T_RiderID IS NULL) 

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_TailorRiderInsert]    Script Date: 03/13/2018 22:19:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_TailorRiderInsert] 
    @Profile_Name nvarchar(MAX),
    @Password nvarchar(20),
    @First_Name char(10),
    @Middle_Name char(10) = NULL,
    @Last_Name char(10),
    @Email_Address nvarchar(MAX),
    @Contact_Number int,
    @Cell_Number int = NULL,
    @QR_Code nvarchar(50),
    @Rating int,
    @Created_DateTime datetime,
    @Created_By int,
    @Modified_DateTime datetime,
    @Modified_By int,
    @Deleted bit
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN
	
	INSERT INTO [dbo].[TailorRider] ([Profile_Name], [Password], [First_Name], [Middle_Name], [Last_Name], [Email_Address], [Contact_Number], [Cell_Number], [QR_Code], [Rating], [Created_DateTime], [Created_By], [Modified_DateTime], [Modified_By], [Deleted])
	SELECT @Profile_Name, @Password, @First_Name, @Middle_Name, @Last_Name, @Email_Address, @Contact_Number, @Cell_Number, @QR_Code, @Rating, @Created_DateTime, @Created_By, @Modified_DateTime, @Modified_By, @Deleted
	
	-- Begin Return Select <- do not remove
	SELECT [T_RiderID], [Profile_Name], [Password], [First_Name], [Middle_Name], [Last_Name], [Email_Address], [Contact_Number], [Cell_Number], [QR_Code], [Rating], [Created_DateTime], [Created_By], [Modified_DateTime], [Modified_By], [Deleted]
	FROM   [dbo].[TailorRider]
	WHERE  [T_RiderID] = SCOPE_IDENTITY()
	-- End Return Select <- do not remove
               
	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_TailorRiderDelete]    Script Date: 03/13/2018 22:19:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_TailorRiderDelete] 
    @T_RiderID int
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	DELETE
	FROM   [dbo].[TailorRider]
	WHERE  [T_RiderID] = @T_RiderID

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_TailorInsert]    Script Date: 03/13/2018 22:19:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_TailorInsert] 
    @Profile_Name nvarchar(50),
    @Password nvarchar(MAX),
    @First_Name char(10),
    @Middle_Name char(10) = NULL,
    @Last_Name char(10),
    @Email_Address nvarchar(50),
    @Contact_Number int,
    @Cell_Number int = NULL,
    @Location_ID int,
    @PickUp_Address nvarchar(MAX),
    @Drop_Address nvarchar(MAX),
    @QR_Code nvarchar(50),
    @Rating int,
    @Created_DateTime datetime,
    @Created_By int,
    @Modified_DateTime datetime,
    @Modified_By int,
    @Deleted bit
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN
	
	INSERT INTO [dbo].[Tailor] ([Profile_Name], [Password], [First_Name], [Middle_Name], [Last_Name], [Email_Address], [Contact_Number], [Cell_Number], [Location_ID], [PickUp_Address], [Drop_Address], [QR_Code], [Rating], [Created_DateTime], [Created_By], [Modified_DateTime], [Modified_By], [Deleted])
	SELECT @Profile_Name, @Password, @First_Name, @Middle_Name, @Last_Name, @Email_Address, @Contact_Number, @Cell_Number, @Location_ID, @PickUp_Address, @Drop_Address, @QR_Code, @Rating, @Created_DateTime, @Created_By, @Modified_DateTime, @Modified_By, @Deleted
	
	-- Begin Return Select <- do not remove
	SELECT [Tailor_ID], [Profile_Name], [Password], [First_Name], [Middle_Name], [Last_Name], [Email_Address], [Contact_Number], [Cell_Number], [Location_ID], [PickUp_Address], [Drop_Address], [QR_Code], [Rating], [Created_DateTime], [Created_By], [Modified_DateTime], [Modified_By], [Deleted]
	FROM   [dbo].[Tailor]
	WHERE  [Tailor_ID] = SCOPE_IDENTITY()
	-- End Return Select <- do not remove
               
	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_TailorDelete]    Script Date: 03/13/2018 22:19:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_TailorDelete] 
    @Tailor_ID int
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	DELETE
	FROM   [dbo].[Tailor]
	WHERE  [Tailor_ID] = @Tailor_ID

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_TailorCategoryUpdate]    Script Date: 03/13/2018 22:19:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_TailorCategoryUpdate] 
    @TailorCategory_ID int,
    @TailorCategory_Name nvarchar(50),
    @TailorCategory_Rating int,
    @TailorCategory_Days int,
    @DressCategory_ID int,
    @Tailor_ID int,
    @Created_DateTime datetime,
    @Created_By int,
    @Modified_DateTime datetime,
    @Modified_By int,
    @Deleted char(1)
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	UPDATE [dbo].[TailorCategory]
	SET    [TailorCategory_Name] = @TailorCategory_Name, [TailorCategory_Rating] = @TailorCategory_Rating, [TailorCategory_Days] = @TailorCategory_Days, [DressCategory_ID] = @DressCategory_ID, [Tailor_ID] = @Tailor_ID, [Created_DateTime] = @Created_DateTime, [Created_By] = @Created_By, [Modified_DateTime] = @Modified_DateTime, [Deleted] = @Deleted
	WHERE  [TailorCategory_ID] = @TailorCategory_ID
	
	-- Begin Return Select <- do not remove
	SELECT [TailorCategory_ID], [TailorCategory_Name], [TailorCategory_Rating], [TailorCategory_Days], [DressCategory_ID], [Tailor_ID], [Created_DateTime], [Created_By], [Modified_DateTime], [Modified_By], [Deleted]
	FROM   [dbo].[TailorCategory]
	WHERE  [TailorCategory_ID] = @TailorCategory_ID	
	-- End Return Select <- do not remove

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_TailorCategorySelect]    Script Date: 03/13/2018 22:19:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_TailorCategorySelect] 
    @TailorCategory_ID int
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN TRAN

	SELECT [TailorCategory_ID], [TailorCategory_Name], [TailorCategory_Rating], [TailorCategory_Days], [DressCategory_ID], [Tailor_ID], [Created_DateTime], [Created_By], [Modified_DateTime], [Modified_By], [Deleted] 
	FROM   [dbo].[TailorCategory] 
	WHERE  ([TailorCategory_ID] = @TailorCategory_ID OR @TailorCategory_ID IS NULL) 

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_TailorCategoryInsert]    Script Date: 03/13/2018 22:19:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_TailorCategoryInsert] 
    @TailorCategory_ID int,
    @TailorCategory_Name nvarchar(50),
    @TailorCategory_Rating int,
    @TailorCategory_Days int,
    @DressCategory_ID int,
    @Tailor_ID int,
    @Created_DateTime datetime,
    @Created_By int,
    @Modified_DateTime datetime,
    @Deleted char(1)
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN
	
	INSERT INTO [dbo].[TailorCategory] ([TailorCategory_ID], [TailorCategory_Name], [TailorCategory_Rating], [TailorCategory_Days], [DressCategory_ID], [Tailor_ID], [Created_DateTime], [Created_By], [Modified_DateTime], [Deleted])
	SELECT @TailorCategory_ID, @TailorCategory_Name, @TailorCategory_Rating, @TailorCategory_Days, @DressCategory_ID, @Tailor_ID, @Created_DateTime, @Created_By, @Modified_DateTime, @Deleted
	
	-- Begin Return Select <- do not remove
	SELECT [TailorCategory_ID], [TailorCategory_Name], [TailorCategory_Rating], [TailorCategory_Days], [DressCategory_ID], [Tailor_ID], [Created_DateTime], [Created_By], [Modified_DateTime], [Modified_By], [Deleted]
	FROM   [dbo].[TailorCategory]
	WHERE  [TailorCategory_ID] = @TailorCategory_ID
	-- End Return Select <- do not remove
               
	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_TailorCategoryDelete]    Script Date: 03/13/2018 22:19:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_TailorCategoryDelete] 
    @TailorCategory_ID int
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	DELETE
	FROM   [dbo].[TailorCategory]
	WHERE  [TailorCategory_ID] = @TailorCategory_ID

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_StatusUpdate]    Script Date: 03/13/2018 22:19:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_StatusUpdate] 
    @Status_ID int,
    @Status_Name nvarchar(50),
    @Created_DateTime datetime,
    @Created_By int,
    @Modified_DateTime datetime,
    @Modified_By int,
    @Deleted bit
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	UPDATE [dbo].[Status]
	SET    [Status_Name] = @Status_Name, [Created_DateTime] = @Created_DateTime, [Created_By] = @Created_By, [Modified_DateTime] = @Modified_DateTime, [Modified_By] = @Modified_By, [Deleted] = @Deleted
	WHERE  [Status_ID] = @Status_ID
	
	-- Begin Return Select <- do not remove
	SELECT [Status_ID], [Status_Name], [Created_DateTime], [Created_By], [Modified_DateTime], [Modified_By], [Deleted]
	FROM   [dbo].[Status]
	WHERE  [Status_ID] = @Status_ID	
	-- End Return Select <- do not remove

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_StatusSelect]    Script Date: 03/13/2018 22:19:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_StatusSelect] 
    @Status_ID int
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN TRAN

	SELECT [Status_ID], [Status_Name], [Created_DateTime], [Created_By], [Modified_DateTime], [Modified_By], [Deleted] 
	FROM   [dbo].[Status] 
	WHERE  ([Status_ID] = @Status_ID OR @Status_ID IS NULL) 

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_StatusInsert]    Script Date: 03/13/2018 22:19:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_StatusInsert] 
    @Status_Name nvarchar(50),
    @Created_DateTime datetime,
    @Created_By int,
    @Modified_DateTime datetime,
    @Modified_By int,
    @Deleted bit
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN
	
	INSERT INTO [dbo].[Status] ([Status_Name], [Created_DateTime], [Created_By], [Modified_DateTime], [Modified_By], [Deleted])
	SELECT @Status_Name, @Created_DateTime, @Created_By, @Modified_DateTime, @Modified_By, @Deleted
	
	-- Begin Return Select <- do not remove
	SELECT [Status_ID], [Status_Name], [Created_DateTime], [Created_By], [Modified_DateTime], [Modified_By], [Deleted]
	FROM   [dbo].[Status]
	WHERE  [Status_ID] = SCOPE_IDENTITY()
	-- End Return Select <- do not remove
               
	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_StatusDelete]    Script Date: 03/13/2018 22:19:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_StatusDelete] 
    @Status_ID int
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	DELETE
	FROM   [dbo].[Status]
	WHERE  [Status_ID] = @Status_ID

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_OrderUpdate]    Script Date: 03/13/2018 22:19:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_OrderUpdate] 
    @Order_ID int,
    @Client_ID int,
    @C_Rider_ID int,
    @Warehouse_ID int,
    @T_Rider_ID int,
    @Tailor_ID int,
    @DressDetails_ID int,
    @ClientSample_ID int = NULL,
    @Status_ID int,
    @QR_Code nvarchar(50),
    @Remarks nvarchar(50),
    @Offer_ID int,
    @Created_DateTime datetime,
    @Created_By int,
    @Modified_DateTime datetime,
    @Modified_By int,
    @Deleted bit
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	UPDATE [dbo].[Order]
	SET    [Client_ID] = @Client_ID, [C_Rider_ID] = @C_Rider_ID, [Warehouse_ID] = @Warehouse_ID, [T_Rider_ID] = @T_Rider_ID, [Tailor_ID] = @Tailor_ID, [DressDetails_ID] = @DressDetails_ID, [ClientSample_ID] = @ClientSample_ID, [Status_ID] = @Status_ID, [QR_Code] = @QR_Code, [Remarks] = @Remarks, [Offer_ID] = @Offer_ID, [Created_DateTime] = @Created_DateTime, [Modified_DateTime] = @Modified_DateTime, [Modified_By] = @Modified_By, [Deleted] = @Deleted
	WHERE  [Order_ID] = @Order_ID
	
	-- Begin Return Select <- do not remove
	SELECT [Order_ID], [Client_ID], [C_Rider_ID], [Warehouse_ID], [T_Rider_ID], [Tailor_ID], [DressDetails_ID], [ClientSample_ID], [Status_ID], [QR_Code], [Remarks], [Offer_ID], [Created_DateTime], [Created_By], [Modified_DateTime], [Modified_By], [Deleted]
	FROM   [dbo].[Order]
	WHERE  [Order_ID] = @Order_ID	
	-- End Return Select <- do not remove

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_OrderSelect]    Script Date: 03/13/2018 22:19:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_OrderSelect] 
    @Order_ID int
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN TRAN

	SELECT [Order_ID], [Client_ID], [C_Rider_ID], [Warehouse_ID], [T_Rider_ID], [Tailor_ID], [DressDetails_ID], [ClientSample_ID], [Status_ID], [QR_Code], [Remarks], [Offer_ID], [Created_DateTime], [Created_By], [Modified_DateTime], [Modified_By], [Deleted] 
	FROM   [dbo].[Order] 
	WHERE  ([Order_ID] = @Order_ID OR @Order_ID IS NULL) 

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_OrderInsert]    Script Date: 03/13/2018 22:19:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_OrderInsert] 
    @Order_ID int,
    @Client_ID int,
    @C_Rider_ID int,
    @Warehouse_ID int,
    @T_Rider_ID int,
    @Tailor_ID int,
    @DressDetails_ID int,
    @ClientSample_ID int = NULL,
    @Status_ID int,
    @QR_Code nvarchar(50),
    @Remarks nvarchar(50),
    @Offer_ID int,
    @Created_DateTime datetime,
    @Modified_DateTime datetime,
    @Modified_By int,
    @Deleted bit
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN
	
	INSERT INTO [dbo].[Order] ([Order_ID], [Client_ID], [C_Rider_ID], [Warehouse_ID], [T_Rider_ID], [Tailor_ID], [DressDetails_ID], [ClientSample_ID], [Status_ID], [QR_Code], [Remarks], [Offer_ID], [Created_DateTime], [Modified_DateTime], [Modified_By], [Deleted])
	SELECT @Order_ID, @Client_ID, @C_Rider_ID, @Warehouse_ID, @T_Rider_ID, @Tailor_ID, @DressDetails_ID, @ClientSample_ID, @Status_ID, @QR_Code, @Remarks, @Offer_ID, @Created_DateTime, @Modified_DateTime, @Modified_By, @Deleted
	
	-- Begin Return Select <- do not remove
	SELECT [Order_ID], [Client_ID], [C_Rider_ID], [Warehouse_ID], [T_Rider_ID], [Tailor_ID], [DressDetails_ID], [ClientSample_ID], [Status_ID], [QR_Code], [Remarks], [Offer_ID], [Created_DateTime], [Created_By], [Modified_DateTime], [Modified_By], [Deleted]
	FROM   [dbo].[Order]
	WHERE  [Order_ID] = @Order_ID
	-- End Return Select <- do not remove
               
	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_OrderDelete]    Script Date: 03/13/2018 22:19:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_OrderDelete] 
    @Order_ID int
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	DELETE
	FROM   [dbo].[Order]
	WHERE  [Order_ID] = @Order_ID

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_OffersUpdate]    Script Date: 03/13/2018 22:19:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_OffersUpdate] 
    @Offer_ID int,
    @Offer_Name nvarchar(50),
    @Offer_Event nvarchar(50),
    @Offer_Valid_From datetime,
    @Offer_Valid_Till datetime,
    @Created_DateTime datetime,
    @Created_By int,
    @Modified_DateTime datetime,
    @Modified_By int,
    @Deleted bit
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	UPDATE [dbo].[Offers]
	SET    [Offer_Name] = @Offer_Name, [Offer_Event] = @Offer_Event, [Offer_Valid_From] = @Offer_Valid_From, [Offer_Valid_Till] = @Offer_Valid_Till, [Created_DateTime] = @Created_DateTime, [Created_By] = @Created_By, [Modified_DateTime] = @Modified_DateTime, [Modified_By] = @Modified_By, [Deleted] = @Deleted
	WHERE  [Offer_ID] = @Offer_ID
	
	-- Begin Return Select <- do not remove
	SELECT [Offer_ID], [Offer_Name], [Offer_Event], [Offer_Valid_From], [Offer_Valid_Till], [Created_DateTime], [Created_By], [Modified_DateTime], [Modified_By], [Deleted]
	FROM   [dbo].[Offers]
	WHERE  [Offer_ID] = @Offer_ID	
	-- End Return Select <- do not remove

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_OffersSelect]    Script Date: 03/13/2018 22:19:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_OffersSelect] 
    @Offer_ID int
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN TRAN

	SELECT [Offer_ID], [Offer_Name], [Offer_Event], [Offer_Valid_From], [Offer_Valid_Till], [Created_DateTime], [Created_By], [Modified_DateTime], [Modified_By], [Deleted] 
	FROM   [dbo].[Offers] 
	WHERE  ([Offer_ID] = @Offer_ID OR @Offer_ID IS NULL) 

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_OffersInsert]    Script Date: 03/13/2018 22:19:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_OffersInsert] 
    @Offer_Name nvarchar(50),
    @Offer_Event nvarchar(50),
    @Offer_Valid_From datetime,
    @Offer_Valid_Till datetime,
    @Created_DateTime datetime,
    @Created_By int,
    @Modified_DateTime datetime,
    @Modified_By int,
    @Deleted bit
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN
	
	INSERT INTO [dbo].[Offers] ([Offer_Name], [Offer_Event], [Offer_Valid_From], [Offer_Valid_Till], [Created_DateTime], [Created_By], [Modified_DateTime], [Modified_By], [Deleted])
	SELECT @Offer_Name, @Offer_Event, @Offer_Valid_From, @Offer_Valid_Till, @Created_DateTime, @Created_By, @Modified_DateTime, @Modified_By, @Deleted
	
	-- Begin Return Select <- do not remove
	SELECT [Offer_ID], [Offer_Name], [Offer_Event], [Offer_Valid_From], [Offer_Valid_Till], [Created_DateTime], [Created_By], [Modified_DateTime], [Modified_By], [Deleted]
	FROM   [dbo].[Offers]
	WHERE  [Offer_ID] = SCOPE_IDENTITY()
	-- End Return Select <- do not remove
               
	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_OffersDelete]    Script Date: 03/13/2018 22:19:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_OffersDelete] 
    @Offer_ID int
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	DELETE
	FROM   [dbo].[Offers]
	WHERE  [Offer_ID] = @Offer_ID

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_LocationsUpdate]    Script Date: 03/13/2018 22:19:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_LocationsUpdate] 
    @Location_ID int,
    @Area_ID int,
    @Map_ID int,
    @City_ID int,
    @Country_ID int,
    @Created_DateTime datetime,
    @Created_By int,
    @Modified_DateTime datetime,
    @Modified_By int,
    @Deleted bit
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	UPDATE [dbo].[Locations]
	SET    [Area_ID] = @Area_ID, [Map_ID] = @Map_ID, [City_ID] = @City_ID, [Country_ID] = @Country_ID, [Created_DateTime] = @Created_DateTime, [Created_By] = @Created_By, [Modified_DateTime] = @Modified_DateTime, [Modified_By] = @Modified_By, [Deleted] = @Deleted
	WHERE  [Location_ID] = @Location_ID
	
	-- Begin Return Select <- do not remove
	SELECT [Location_ID], [Area_ID], [Map_ID], [City_ID], [Country_ID], [Created_DateTime], [Created_By], [Modified_DateTime], [Modified_By], [Deleted]
	FROM   [dbo].[Locations]
	WHERE  [Location_ID] = @Location_ID	
	-- End Return Select <- do not remove

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_LocationsSelect]    Script Date: 03/13/2018 22:19:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_LocationsSelect] 
    @Location_ID int
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN TRAN

	SELECT [Location_ID], [Area_ID], [Map_ID], [City_ID], [Country_ID], [Created_DateTime], [Created_By], [Modified_DateTime], [Modified_By], [Deleted] 
	FROM   [dbo].[Locations] 
	WHERE  ([Location_ID] = @Location_ID OR @Location_ID IS NULL) 

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_LocationsInsert]    Script Date: 03/13/2018 22:19:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_LocationsInsert] 
    @Location_ID int,
    @Area_ID int,
    @Map_ID int,
    @City_ID int,
    @Country_ID int,
    @Created_DateTime datetime,
    @Created_By int,
    @Modified_DateTime datetime,
    @Modified_By int,
    @Deleted bit
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN
	
	INSERT INTO [dbo].[Locations] ([Location_ID], [Area_ID], [Map_ID], [City_ID], [Country_ID], [Created_DateTime], [Created_By], [Modified_DateTime], [Modified_By], [Deleted])
	SELECT @Location_ID, @Area_ID, @Map_ID, @City_ID, @Country_ID, @Created_DateTime, @Created_By, @Modified_DateTime, @Modified_By, @Deleted
	
	-- Begin Return Select <- do not remove
	SELECT [Location_ID], [Area_ID], [Map_ID], [City_ID], [Country_ID], [Created_DateTime], [Created_By], [Modified_DateTime], [Modified_By], [Deleted]
	FROM   [dbo].[Locations]
	WHERE  [Location_ID] = @Location_ID
	-- End Return Select <- do not remove
               
	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_LocationsDelete]    Script Date: 03/13/2018 22:19:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_LocationsDelete] 
    @Location_ID int
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	DELETE
	FROM   [dbo].[Locations]
	WHERE  [Location_ID] = @Location_ID

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_EntityUpdate]    Script Date: 03/13/2018 22:19:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_EntityUpdate] 
    @Entity_ID int,
    @Entity_Name nvarchar(50),
    @Created_DateTime datetime,
    @Created_By int,
    @Modified_DateTime datetime,
    @Modified_By int,
    @Deleted bit
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	UPDATE [dbo].[Entity]
	SET    [Entity_Name] = @Entity_Name, [Created_DateTime] = @Created_DateTime, [Created_By] = @Created_By, [Modified_DateTime] = @Modified_DateTime, [Modified_By] = @Modified_By, [Deleted] = @Deleted
	WHERE  [Entity_ID] = @Entity_ID
	
	-- Begin Return Select <- do not remove
	SELECT [Entity_ID], [Entity_Name], [Created_DateTime], [Created_By], [Modified_DateTime], [Modified_By], [Deleted]
	FROM   [dbo].[Entity]
	WHERE  [Entity_ID] = @Entity_ID	
	-- End Return Select <- do not remove

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_EntitySelect]    Script Date: 03/13/2018 22:19:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_EntitySelect] 
    @Entity_ID int
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN TRAN

	SELECT [Entity_ID], [Entity_Name], [Created_DateTime], [Created_By], [Modified_DateTime], [Modified_By], [Deleted] 
	FROM   [dbo].[Entity] 
	WHERE  ([Entity_ID] = @Entity_ID OR @Entity_ID IS NULL) 

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_EntityInsert]    Script Date: 03/13/2018 22:19:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_EntityInsert] 
    @Entity_Name nvarchar(50),
    @Created_DateTime datetime,
    @Created_By int,
    @Modified_DateTime datetime,
    @Modified_By int,
    @Deleted bit
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN
	
	INSERT INTO [dbo].[Entity] ([Entity_Name], [Created_DateTime], [Created_By], [Modified_DateTime], [Modified_By], [Deleted])
	SELECT @Entity_Name, @Created_DateTime, @Created_By, @Modified_DateTime, @Modified_By, @Deleted
	
	-- Begin Return Select <- do not remove
	SELECT [Entity_ID], [Entity_Name], [Created_DateTime], [Created_By], [Modified_DateTime], [Modified_By], [Deleted]
	FROM   [dbo].[Entity]
	WHERE  [Entity_ID] = SCOPE_IDENTITY()
	-- End Return Select <- do not remove
               
	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_EntityDelete]    Script Date: 03/13/2018 22:19:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_EntityDelete] 
    @Entity_ID int
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	DELETE
	FROM   [dbo].[Entity]
	WHERE  [Entity_ID] = @Entity_ID

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_Entity_Order_TimeframeUpdate]    Script Date: 03/13/2018 22:19:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_Entity_Order_TimeframeUpdate] 
    @OrderTimeframe_ID int,
    @Order_ID int,
    @Entity_ID int,
    @Estimated_DateTime datetime,
    @Actual_DateTime datetime,
    @Pick datetime,
    @Drop datetime,
    @Created_DateTime datetime,
    @Created_By int,
    @Modified_DateTime datetime,
    @Modified_By int,
    @Deleted bit
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	UPDATE [dbo].[Entity_Order_Timeframe]
	SET    [Order_ID] = @Order_ID, [Entity_ID] = @Entity_ID, [Estimated_DateTime] = @Estimated_DateTime, [Actual_DateTime] = @Actual_DateTime, [Pick] = @Pick, [Drop] = @Drop, [Created_DateTime] = @Created_DateTime, [Created_By] = @Created_By, [Modified_DateTime] = @Modified_DateTime, [Modified_By] = @Modified_By, [Deleted] = @Deleted
	WHERE  [OrderTimeframe_ID] = @OrderTimeframe_ID
	
	-- Begin Return Select <- do not remove
	SELECT [OrderTimeframe_ID], [Order_ID], [Entity_ID], [Estimated_DateTime], [Actual_DateTime], [Pick], [Drop], [Created_DateTime], [Created_By], [Modified_DateTime], [Modified_By], [Deleted]
	FROM   [dbo].[Entity_Order_Timeframe]
	WHERE  [OrderTimeframe_ID] = @OrderTimeframe_ID	
	-- End Return Select <- do not remove

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_Entity_Order_TimeframeSelect]    Script Date: 03/13/2018 22:19:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_Entity_Order_TimeframeSelect] 
    @OrderTimeframe_ID int
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN TRAN

	SELECT [OrderTimeframe_ID], [Order_ID], [Entity_ID], [Estimated_DateTime], [Actual_DateTime], [Pick], [Drop], [Created_DateTime], [Created_By], [Modified_DateTime], [Modified_By], [Deleted] 
	FROM   [dbo].[Entity_Order_Timeframe] 
	WHERE  ([OrderTimeframe_ID] = @OrderTimeframe_ID OR @OrderTimeframe_ID IS NULL) 

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_Entity_Order_TimeframeInsert]    Script Date: 03/13/2018 22:19:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_Entity_Order_TimeframeInsert] 
    @Order_ID int,
    @Entity_ID int,
    @Estimated_DateTime datetime,
    @Actual_DateTime datetime,
    @Pick datetime,
    @Drop datetime,
    @Created_DateTime datetime,
    @Created_By int,
    @Modified_DateTime datetime,
    @Modified_By int,
    @Deleted bit
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN
	
	INSERT INTO [dbo].[Entity_Order_Timeframe] ([Order_ID], [Entity_ID], [Estimated_DateTime], [Actual_DateTime], [Pick], [Drop], [Created_DateTime], [Created_By], [Modified_DateTime], [Modified_By], [Deleted])
	SELECT @Order_ID, @Entity_ID, @Estimated_DateTime, @Actual_DateTime, @Pick, @Drop, @Created_DateTime, @Created_By, @Modified_DateTime, @Modified_By, @Deleted
	
	-- Begin Return Select <- do not remove
	SELECT [OrderTimeframe_ID], [Order_ID], [Entity_ID], [Estimated_DateTime], [Actual_DateTime], [Pick], [Drop], [Created_DateTime], [Created_By], [Modified_DateTime], [Modified_By], [Deleted]
	FROM   [dbo].[Entity_Order_Timeframe]
	WHERE  [OrderTimeframe_ID] = SCOPE_IDENTITY()
	-- End Return Select <- do not remove
               
	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_Entity_Order_TimeframeDelete]    Script Date: 03/13/2018 22:19:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_Entity_Order_TimeframeDelete] 
    @OrderTimeframe_ID int
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	DELETE
	FROM   [dbo].[Entity_Order_Timeframe]
	WHERE  [OrderTimeframe_ID] = @OrderTimeframe_ID

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_Entity_OfferUpdate]    Script Date: 03/13/2018 22:19:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_Entity_OfferUpdate] 
    @Entity_Offer_ID int,
    @Entity_ID int,
    @Offer_ID int,
    @DressDetails_ID int,
    @Rate int,
    @Percentage_Discount nvarchar(50),
    @Flat_Discount nvarchar(50),
    @Created_DateTime datetime,
    @Created_By int,
    @Modified_DateTime datetime,
    @Modified_By int,
    @Deleted bit
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	UPDATE [dbo].[Entity_Offer]
	SET    [Offer_ID] = @Offer_ID, [DressDetails_ID] = @DressDetails_ID, [Rate] = @Rate, [Percentage_Discount] = @Percentage_Discount, [Flat_Discount] = @Flat_Discount, [Created_DateTime] = @Created_DateTime, [Created_By] = @Created_By, [Modified_DateTime] = @Modified_DateTime, [Modified_By] = @Modified_By, [Deleted] = @Deleted
	WHERE  [Entity_Offer_ID] = @Entity_Offer_ID
	
	-- Begin Return Select <- do not remove
	SELECT [Entity_Offer_ID], [Entity_ID], [Offer_ID], [DressDetails_ID], [Rate], [Percentage_Discount], [Flat_Discount], [Created_DateTime], [Created_By], [Modified_DateTime], [Modified_By], [Deleted]
	FROM   [dbo].[Entity_Offer]
	WHERE  [Entity_Offer_ID] = @Entity_Offer_ID	
	-- End Return Select <- do not remove

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_Entity_OfferSelect]    Script Date: 03/13/2018 22:19:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_Entity_OfferSelect] 
    @Entity_Offer_ID int
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN TRAN

	SELECT [Entity_Offer_ID], [Entity_ID], [Offer_ID], [DressDetails_ID], [Rate], [Percentage_Discount], [Flat_Discount], [Created_DateTime], [Created_By], [Modified_DateTime], [Modified_By], [Deleted] 
	FROM   [dbo].[Entity_Offer] 
	WHERE  ([Entity_Offer_ID] = @Entity_Offer_ID OR @Entity_Offer_ID IS NULL) 

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_Entity_OfferInsert]    Script Date: 03/13/2018 22:19:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_Entity_OfferInsert] 
    @Entity_Offer_ID int,
    @Offer_ID int,
    @DressDetails_ID int,
    @Rate int,
    @Percentage_Discount nvarchar(50),
    @Flat_Discount nvarchar(50),
    @Created_DateTime datetime,
    @Created_By int,
    @Modified_DateTime datetime,
    @Modified_By int,
    @Deleted bit
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN
	
	INSERT INTO [dbo].[Entity_Offer] ([Entity_Offer_ID], [Offer_ID], [DressDetails_ID], [Rate], [Percentage_Discount], [Flat_Discount], [Created_DateTime], [Created_By], [Modified_DateTime], [Modified_By], [Deleted])
	SELECT @Entity_Offer_ID, @Offer_ID, @DressDetails_ID, @Rate, @Percentage_Discount, @Flat_Discount, @Created_DateTime, @Created_By, @Modified_DateTime, @Modified_By, @Deleted
	
	-- Begin Return Select <- do not remove
	SELECT [Entity_Offer_ID], [Entity_ID], [Offer_ID], [DressDetails_ID], [Rate], [Percentage_Discount], [Flat_Discount], [Created_DateTime], [Created_By], [Modified_DateTime], [Modified_By], [Deleted]
	FROM   [dbo].[Entity_Offer]
	WHERE  [Entity_Offer_ID] = @Entity_Offer_ID
	-- End Return Select <- do not remove
               
	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_Entity_OfferDelete]    Script Date: 03/13/2018 22:19:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_Entity_OfferDelete] 
    @Entity_Offer_ID int
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	DELETE
	FROM   [dbo].[Entity_Offer]
	WHERE  [Entity_Offer_ID] = @Entity_Offer_ID

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_DressTypeUpdate]    Script Date: 03/13/2018 22:19:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_DressTypeUpdate] 
    @DressType_ID int,
    @DressType_Name nvarchar(50),
    @Created_DateTime datetime,
    @Created_By int,
    @Modified_DateTime datetime,
    @Modified_By int,
    @Deleted bit
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	UPDATE [dbo].[DressType]
	SET    [DressType_Name] = @DressType_Name, [Created_DateTime] = @Created_DateTime, [Created_By] = @Created_By, [Modified_DateTime] = @Modified_DateTime, [Modified_By] = @Modified_By, [Deleted] = @Deleted
	WHERE  [DressType_ID] = @DressType_ID
	
	-- Begin Return Select <- do not remove
	SELECT [DressType_ID], [DressType_Name], [Created_DateTime], [Created_By], [Modified_DateTime], [Modified_By], [Deleted]
	FROM   [dbo].[DressType]
	WHERE  [DressType_ID] = @DressType_ID	
	-- End Return Select <- do not remove

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_DressTypeSelect]    Script Date: 03/13/2018 22:19:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_DressTypeSelect] 
    @DressType_ID int
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN TRAN

	SELECT [DressType_ID], [DressType_Name], [Created_DateTime], [Created_By], [Modified_DateTime], [Modified_By], [Deleted] 
	FROM   [dbo].[DressType] 
	WHERE  ([DressType_ID] = @DressType_ID OR @DressType_ID IS NULL) 

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_DressTypeInsert]    Script Date: 03/13/2018 22:19:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_DressTypeInsert] 
    @DressType_Name nvarchar(50),
    @Created_DateTime datetime,
    @Created_By int,
    @Modified_DateTime datetime,
    @Modified_By int,
    @Deleted bit
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN
	
	INSERT INTO [dbo].[DressType] ([DressType_Name], [Created_DateTime], [Created_By], [Modified_DateTime], [Modified_By], [Deleted])
	SELECT @DressType_Name, @Created_DateTime, @Created_By, @Modified_DateTime, @Modified_By, @Deleted
	
	-- Begin Return Select <- do not remove
	SELECT [DressType_ID], [DressType_Name], [Created_DateTime], [Created_By], [Modified_DateTime], [Modified_By], [Deleted]
	FROM   [dbo].[DressType]
	WHERE  [DressType_ID] = SCOPE_IDENTITY()
	-- End Return Select <- do not remove
               
	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_DressTypeDelete]    Script Date: 03/13/2018 22:19:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_DressTypeDelete] 
    @DressType_ID int
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	DELETE
	FROM   [dbo].[DressType]
	WHERE  [DressType_ID] = @DressType_ID

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_DressStyleUpdate]    Script Date: 03/13/2018 22:19:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_DressStyleUpdate] 
    @DressStyle_ID int,
    @DressStyle_Name nvarchar(50),
    @Created_DateTime datetime,
    @Created_By int,
    @Modified_DateTime datetime,
    @Modified_By int,
    @Deleted bit
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	UPDATE [dbo].[DressStyle]
	SET    [DressStyle_Name] = @DressStyle_Name, [Created_DateTime] = @Created_DateTime, [Created_By] = @Created_By, [Modified_DateTime] = @Modified_DateTime, [Modified_By] = @Modified_By, [Deleted] = @Deleted
	WHERE  [DressStyle_ID] = @DressStyle_ID
	
	-- Begin Return Select <- do not remove
	SELECT [DressStyle_ID], [DressStyle_Name], [Created_DateTime], [Created_By], [Modified_DateTime], [Modified_By], [Deleted]
	FROM   [dbo].[DressStyle]
	WHERE  [DressStyle_ID] = @DressStyle_ID	
	-- End Return Select <- do not remove

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_DressStyleSelect]    Script Date: 03/13/2018 22:19:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_DressStyleSelect] 
    @DressStyle_ID int
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN TRAN

	SELECT [DressStyle_ID], [DressStyle_Name], [Created_DateTime], [Created_By], [Modified_DateTime], [Modified_By], [Deleted] 
	FROM   [dbo].[DressStyle] 
	WHERE  ([DressStyle_ID] = @DressStyle_ID OR @DressStyle_ID IS NULL) 

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_DressStyleInsert]    Script Date: 03/13/2018 22:19:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_DressStyleInsert] 
    @DressStyle_Name nvarchar(50),
    @Created_DateTime datetime,
    @Created_By int,
    @Modified_DateTime datetime,
    @Modified_By int,
    @Deleted bit
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN
	
	INSERT INTO [dbo].[DressStyle] ([DressStyle_Name], [Created_DateTime], [Created_By], [Modified_DateTime], [Modified_By], [Deleted])
	SELECT @DressStyle_Name, @Created_DateTime, @Created_By, @Modified_DateTime, @Modified_By, @Deleted
	
	-- Begin Return Select <- do not remove
	SELECT [DressStyle_ID], [DressStyle_Name], [Created_DateTime], [Created_By], [Modified_DateTime], [Modified_By], [Deleted]
	FROM   [dbo].[DressStyle]
	WHERE  [DressStyle_ID] = SCOPE_IDENTITY()
	-- End Return Select <- do not remove
               
	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_DressStyleDelete]    Script Date: 03/13/2018 22:19:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_DressStyleDelete] 
    @DressStyle_ID int
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	DELETE
	FROM   [dbo].[DressStyle]
	WHERE  [DressStyle_ID] = @DressStyle_ID

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_DressDetailsUpdate]    Script Date: 03/13/2018 22:19:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_DressDetailsUpdate] 
    @DressDetails_ID int,
    @DressCategory_ID int,
    @DressType_ID int,
    @DressStyle_ID int,
    @Dimension_ID int,
    @Created_DateTime datetime,
    @Created_By int,
    @Modified_DateTime datetime,
    @Modified_By int,
    @Deleted bit
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	UPDATE [dbo].[DressDetails]
	SET    [DressCategory_ID] = @DressCategory_ID, [DressType_ID] = @DressType_ID, [DressStyle_ID] = @DressStyle_ID, [Dimension_ID] = @Dimension_ID, [Created_DateTime] = @Created_DateTime, [Created_By] = @Created_By, [Modified_DateTime] = @Modified_DateTime, [Modified_By] = @Modified_By, [Deleted] = @Deleted
	WHERE  [DressDetails_ID] = @DressDetails_ID
	
	-- Begin Return Select <- do not remove
	SELECT [DressDetails_ID], [DressCategory_ID], [DressType_ID], [DressStyle_ID], [Dimension_ID], [Created_DateTime], [Created_By], [Modified_DateTime], [Modified_By], [Deleted]
	FROM   [dbo].[DressDetails]
	WHERE  [DressDetails_ID] = @DressDetails_ID	
	-- End Return Select <- do not remove

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_DressDetailsSelect]    Script Date: 03/13/2018 22:19:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_DressDetailsSelect] 
    @DressDetails_ID int
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN TRAN

	SELECT [DressDetails_ID], [DressCategory_ID], [DressType_ID], [DressStyle_ID], [Dimension_ID], [Created_DateTime], [Created_By], [Modified_DateTime], [Modified_By], [Deleted] 
	FROM   [dbo].[DressDetails] 
	WHERE  ([DressDetails_ID] = @DressDetails_ID OR @DressDetails_ID IS NULL) 

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_DressDetailsInsert]    Script Date: 03/13/2018 22:19:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_DressDetailsInsert] 
    @DressCategory_ID int,
    @DressType_ID int,
    @DressStyle_ID int,
    @Dimension_ID int,
    @Created_DateTime datetime,
    @Created_By int,
    @Modified_DateTime datetime,
    @Modified_By int,
    @Deleted bit
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN
	
	INSERT INTO [dbo].[DressDetails] ([DressCategory_ID], [DressType_ID], [DressStyle_ID], [Dimension_ID], [Created_DateTime], [Created_By], [Modified_DateTime], [Modified_By], [Deleted])
	SELECT @DressCategory_ID, @DressType_ID, @DressStyle_ID, @Dimension_ID, @Created_DateTime, @Created_By, @Modified_DateTime, @Modified_By, @Deleted
	
	-- Begin Return Select <- do not remove
	SELECT [DressDetails_ID], [DressCategory_ID], [DressType_ID], [DressStyle_ID], [Dimension_ID], [Created_DateTime], [Created_By], [Modified_DateTime], [Modified_By], [Deleted]
	FROM   [dbo].[DressDetails]
	WHERE  [DressDetails_ID] = SCOPE_IDENTITY()
	-- End Return Select <- do not remove
               
	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_DressDetailsDelete]    Script Date: 03/13/2018 22:19:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_DressDetailsDelete] 
    @DressDetails_ID int
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	DELETE
	FROM   [dbo].[DressDetails]
	WHERE  [DressDetails_ID] = @DressDetails_ID

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_DressCategoryUpdate]    Script Date: 03/13/2018 22:19:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_DressCategoryUpdate] 
    @DressCategory_ID int,
    @DressCategory_Name nvarchar(50),
    @Created_DateTime datetime,
    @Created_By int,
    @Modified_DateTime datetime,
    @Modified_By int,
    @Deleted bit
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	UPDATE [dbo].[DressCategory]
	SET    [DressCategory_Name] = @DressCategory_Name, [Created_DateTime] = @Created_DateTime, [Created_By] = @Created_By, [Modified_DateTime] = @Modified_DateTime, [Modified_By] = @Modified_By, [Deleted] = @Deleted
	WHERE  [DressCategory_ID] = @DressCategory_ID
	
	-- Begin Return Select <- do not remove
	SELECT [DressCategory_ID], [DressCategory_Name], [Created_DateTime], [Created_By], [Modified_DateTime], [Modified_By], [Deleted]
	FROM   [dbo].[DressCategory]
	WHERE  [DressCategory_ID] = @DressCategory_ID	
	-- End Return Select <- do not remove

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_DressCategorySelect]    Script Date: 03/13/2018 22:19:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_DressCategorySelect] 
    @DressCategory_ID int
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN TRAN

	SELECT [DressCategory_ID], [DressCategory_Name], [Created_DateTime], [Created_By], [Modified_DateTime], [Modified_By], [Deleted] 
	FROM   [dbo].[DressCategory] 
	WHERE  ([DressCategory_ID] = @DressCategory_ID OR @DressCategory_ID IS NULL) 

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_DressCategoryInsert]    Script Date: 03/13/2018 22:19:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_DressCategoryInsert] 
    @DressCategory_Name nvarchar(50),
    @Created_DateTime datetime,
    @Created_By int,
    @Modified_DateTime datetime,
    @Modified_By int,
    @Deleted bit
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN
	
	INSERT INTO [dbo].[DressCategory] ([DressCategory_Name], [Created_DateTime], [Created_By], [Modified_DateTime], [Modified_By], [Deleted])
	SELECT @DressCategory_Name, @Created_DateTime, @Created_By, @Modified_DateTime, @Modified_By, @Deleted
	
	-- Begin Return Select <- do not remove
	SELECT [DressCategory_ID], [DressCategory_Name], [Created_DateTime], [Created_By], [Modified_DateTime], [Modified_By], [Deleted]
	FROM   [dbo].[DressCategory]
	WHERE  [DressCategory_ID] = SCOPE_IDENTITY()
	-- End Return Select <- do not remove
               
	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_DressCategoryDelete]    Script Date: 03/13/2018 22:19:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_DressCategoryDelete] 
    @DressCategory_ID int
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	DELETE
	FROM   [dbo].[DressCategory]
	WHERE  [DressCategory_ID] = @DressCategory_ID

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_DimensionUpdate]    Script Date: 03/13/2018 22:19:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_DimensionUpdate] 
    @Dimension_ID int,
    @Dimension_Name nvarchar(50),
    @Dimension_Value int,
    @Created_DateTime datetime,
    @Created_By int,
    @Modified_DateTime datetime,
    @Modified_By int,
    @Deleted bit
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	UPDATE [dbo].[Dimension]
	SET    [Dimension_Name] = @Dimension_Name, [Dimension_Value] = @Dimension_Value, [Created_DateTime] = @Created_DateTime, [Created_By] = @Created_By, [Modified_DateTime] = @Modified_DateTime, [Deleted] = @Deleted
	WHERE  [Dimension_ID] = @Dimension_ID
	
	-- Begin Return Select <- do not remove
	SELECT [Dimension_ID], [Dimension_Name], [Dimension_Value], [Created_DateTime], [Created_By], [Modified_DateTime], [Modified_By], [Deleted]
	FROM   [dbo].[Dimension]
	WHERE  [Dimension_ID] = @Dimension_ID	
	-- End Return Select <- do not remove

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_DimensionSelect]    Script Date: 03/13/2018 22:19:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_DimensionSelect] 
    @Dimension_ID int
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN TRAN

	SELECT [Dimension_ID], [Dimension_Name], [Dimension_Value], [Created_DateTime], [Created_By], [Modified_DateTime], [Modified_By], [Deleted] 
	FROM   [dbo].[Dimension] 
	WHERE  ([Dimension_ID] = @Dimension_ID OR @Dimension_ID IS NULL) 

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_DimensionInsert]    Script Date: 03/13/2018 22:19:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_DimensionInsert] 
    @Dimension_ID int,
    @Dimension_Name nvarchar(50),
    @Dimension_Value int,
    @Created_DateTime datetime,
    @Created_By int,
    @Modified_DateTime datetime,
    @Deleted bit
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN
	
	INSERT INTO [dbo].[Dimension] ([Dimension_ID], [Dimension_Name], [Dimension_Value], [Created_DateTime], [Created_By], [Modified_DateTime], [Deleted])
	SELECT @Dimension_ID, @Dimension_Name, @Dimension_Value, @Created_DateTime, @Created_By, @Modified_DateTime, @Deleted
	
	-- Begin Return Select <- do not remove
	SELECT [Dimension_ID], [Dimension_Name], [Dimension_Value], [Created_DateTime], [Created_By], [Modified_DateTime], [Modified_By], [Deleted]
	FROM   [dbo].[Dimension]
	WHERE  [Dimension_ID] = @Dimension_ID
	-- End Return Select <- do not remove
               
	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_DimensionDelete]    Script Date: 03/13/2018 22:19:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_DimensionDelete] 
    @Dimension_ID int
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	DELETE
	FROM   [dbo].[Dimension]
	WHERE  [Dimension_ID] = @Dimension_ID

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_ClientUpdate]    Script Date: 03/13/2018 22:19:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_ClientUpdate] 
    @Client_ID int,
    @Profile_Name nvarchar(100),
    @Password nvarchar(MAX),
    @First_Name nvarchar(20),
    @Middle_Name nvarchar(20) = NULL,
    @Last_Name nvarchar(20),
    @Email_Address nvarchar(MAX),
    @Contact_Number int = NULL,
    @Cell_Number int,
    @Location_ID int,
    @PickUp_Address nvarchar(MAX),
    @Drop_Address nvarchar(MAX),
    @QR_Code nvarchar(50),
    @Rating int,
    @Created_DateTime datetime2(7),
    @Created_By int,
    @Modified_DateTime datetime2(7),
    @Modified_By int,
    @Deleted bit
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	UPDATE [dbo].[Client]
	SET    [Profile_Name] = @Profile_Name, [Password] = @Password, [First_Name] = @First_Name, [Middle_Name] = @Middle_Name, [Last_Name] = @Last_Name, [Email_Address] = @Email_Address, [Contact_Number] = @Contact_Number, [Cell_Number] = @Cell_Number, [Location_ID] = @Location_ID, [PickUp_Address] = @PickUp_Address, [Drop_Address] = @Drop_Address, [QR_Code] = @QR_Code, [Rating] = @Rating, [Created_DateTime] = @Created_DateTime, [Created_By] = @Created_By, [Modified_DateTime] = @Modified_DateTime, [Modified_By] = @Modified_By, [Deleted] = @Deleted
	WHERE  [Client_ID] = @Client_ID
	
	-- Begin Return Select <- do not remove
	SELECT [Client_ID], [Profile_Name], [Password], [First_Name], [Middle_Name], [Last_Name], [Email_Address], [Contact_Number], [Cell_Number], [Location_ID], [PickUp_Address], [Drop_Address], [QR_Code], [Rating], [Created_DateTime], [Created_By], [Modified_DateTime], [Modified_By], [Deleted]
	FROM   [dbo].[Client]
	WHERE  [Client_ID] = @Client_ID	
	-- End Return Select <- do not remove

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_ClientSelect]    Script Date: 03/13/2018 22:19:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_ClientSelect] 
    @Client_ID int
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN TRAN

	SELECT [Client_ID], [Profile_Name], [Password], [First_Name], [Middle_Name], [Last_Name], [Email_Address], [Contact_Number], [Cell_Number], [Location_ID], [PickUp_Address], [Drop_Address], [QR_Code], [Rating], [Created_DateTime], [Created_By], [Modified_DateTime], [Modified_By], [Deleted] 
	FROM   [dbo].[Client] 
	WHERE  ([Client_ID] = @Client_ID OR @Client_ID IS NULL) 

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_ClientSampleUpdate]    Script Date: 03/13/2018 22:19:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_ClientSampleUpdate] 
    @ClientSample_ID int,
    @ClientSample_Name varchar(50),
    @ClientSample_QR_Code nvarchar(50),
    @Created_DateTime datetime,
    @Created_By int,
    @Modified_DateTime datetime,
    @Modified_By int,
    @Deleted bit
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	UPDATE [dbo].[ClientSample]
	SET    [ClientSample_Name] = @ClientSample_Name, [ClientSample_QR_Code] = @ClientSample_QR_Code, [Created_DateTime] = @Created_DateTime, [Created_By] = @Created_By, [Modified_DateTime] = @Modified_DateTime, [Deleted] = @Deleted
	WHERE  [ClientSample_ID] = @ClientSample_ID
	
	-- Begin Return Select <- do not remove
	SELECT [ClientSample_ID], [ClientSample_Name], [ClientSample_QR_Code], [Created_DateTime], [Created_By], [Modified_DateTime], [Modified_By], [Deleted]
	FROM   [dbo].[ClientSample]
	WHERE  [ClientSample_ID] = @ClientSample_ID	
	-- End Return Select <- do not remove

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_ClientSampleSelect]    Script Date: 03/13/2018 22:19:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_ClientSampleSelect] 
    @ClientSample_ID int
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN TRAN

	SELECT [ClientSample_ID], [ClientSample_Name], [ClientSample_QR_Code], [Created_DateTime], [Created_By], [Modified_DateTime], [Modified_By], [Deleted] 
	FROM   [dbo].[ClientSample] 
	WHERE  ([ClientSample_ID] = @ClientSample_ID OR @ClientSample_ID IS NULL) 

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_ClientSampleInsert]    Script Date: 03/13/2018 22:19:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_ClientSampleInsert] 
    @ClientSample_ID int,
    @ClientSample_Name varchar(50),
    @ClientSample_QR_Code nvarchar(50),
    @Created_DateTime datetime,
    @Created_By int,
    @Modified_DateTime datetime,
    @Deleted bit
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN
	
	INSERT INTO [dbo].[ClientSample] ([ClientSample_ID], [ClientSample_Name], [ClientSample_QR_Code], [Created_DateTime], [Created_By], [Modified_DateTime], [Deleted])
	SELECT @ClientSample_ID, @ClientSample_Name, @ClientSample_QR_Code, @Created_DateTime, @Created_By, @Modified_DateTime, @Deleted
	
	-- Begin Return Select <- do not remove
	SELECT [ClientSample_ID], [ClientSample_Name], [ClientSample_QR_Code], [Created_DateTime], [Created_By], [Modified_DateTime], [Modified_By], [Deleted]
	FROM   [dbo].[ClientSample]
	WHERE  [ClientSample_ID] = @ClientSample_ID
	-- End Return Select <- do not remove
               
	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_ClientSampleDelete]    Script Date: 03/13/2018 22:19:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_ClientSampleDelete] 
    @ClientSample_ID int
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	DELETE
	FROM   [dbo].[ClientSample]
	WHERE  [ClientSample_ID] = @ClientSample_ID

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_ClientRiderUpdate]    Script Date: 03/13/2018 22:19:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_ClientRiderUpdate] 
    @C_RiderID int,
    @Profile_Name nvarchar(MAX),
    @Password nvarchar(50),
    @First_Name char(10),
    @Middle_Name char(10) = NULL,
    @Last_Name char(10),
    @Email_Address nvarchar(50),
    @Contact_Number int,
    @Cell_Number int = NULL,
    @QR_Code nvarchar(MAX),
    @Rating int,
    @Created_DateTime datetime,
    @Created_By int,
    @Modified_DateTime datetime,
    @Modified_By int,
    @Deleted bit
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	UPDATE [dbo].[ClientRider]
	SET    [Profile_Name] = @Profile_Name, [Password] = @Password, [First_Name] = @First_Name, [Middle_Name] = @Middle_Name, [Last_Name] = @Last_Name, [Email_Address] = @Email_Address, [Contact_Number] = @Contact_Number, [Cell_Number] = @Cell_Number, [QR_Code] = @QR_Code, [Rating] = @Rating, [Created_DateTime] = @Created_DateTime, [Created_By] = @Created_By, [Modified_DateTime] = @Modified_DateTime, [Modified_By] = @Modified_By, [Deleted] = @Deleted
	WHERE  [C_RiderID] = @C_RiderID
	
	-- Begin Return Select <- do not remove
	SELECT [C_RiderID], [Profile_Name], [Password], [First_Name], [Middle_Name], [Last_Name], [Email_Address], [Contact_Number], [Cell_Number], [QR_Code], [Rating], [Created_DateTime], [Created_By], [Modified_DateTime], [Modified_By], [Deleted]
	FROM   [dbo].[ClientRider]
	WHERE  [C_RiderID] = @C_RiderID	
	-- End Return Select <- do not remove

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_ClientRiderSelect]    Script Date: 03/13/2018 22:19:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_ClientRiderSelect] 
    @C_RiderID int
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN TRAN

	SELECT [C_RiderID], [Profile_Name], [Password], [First_Name], [Middle_Name], [Last_Name], [Email_Address], [Contact_Number], [Cell_Number], [QR_Code], [Rating], [Created_DateTime], [Created_By], [Modified_DateTime], [Modified_By], [Deleted] 
	FROM   [dbo].[ClientRider] 
	WHERE  ([C_RiderID] = @C_RiderID OR @C_RiderID IS NULL) 

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_ClientRiderInsert]    Script Date: 03/13/2018 22:19:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_ClientRiderInsert] 
    @Profile_Name nvarchar(MAX),
    @Password nvarchar(50),
    @First_Name char(10),
    @Middle_Name char(10) = NULL,
    @Last_Name char(10),
    @Email_Address nvarchar(50),
    @Contact_Number int,
    @Cell_Number int = NULL,
    @QR_Code nvarchar(MAX),
    @Rating int,
    @Created_DateTime datetime,
    @Created_By int,
    @Modified_DateTime datetime,
    @Modified_By int,
    @Deleted bit
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN
	
	INSERT INTO [dbo].[ClientRider] ([Profile_Name], [Password], [First_Name], [Middle_Name], [Last_Name], [Email_Address], [Contact_Number], [Cell_Number], [QR_Code], [Rating], [Created_DateTime], [Created_By], [Modified_DateTime], [Modified_By], [Deleted])
	SELECT @Profile_Name, @Password, @First_Name, @Middle_Name, @Last_Name, @Email_Address, @Contact_Number, @Cell_Number, @QR_Code, @Rating, @Created_DateTime, @Created_By, @Modified_DateTime, @Modified_By, @Deleted
	
	-- Begin Return Select <- do not remove
	SELECT [C_RiderID], [Profile_Name], [Password], [First_Name], [Middle_Name], [Last_Name], [Email_Address], [Contact_Number], [Cell_Number], [QR_Code], [Rating], [Created_DateTime], [Created_By], [Modified_DateTime], [Modified_By], [Deleted]
	FROM   [dbo].[ClientRider]
	WHERE  [C_RiderID] = SCOPE_IDENTITY()
	-- End Return Select <- do not remove
               
	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_ClientRiderDelete]    Script Date: 03/13/2018 22:19:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_ClientRiderDelete] 
    @C_RiderID int
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	DELETE
	FROM   [dbo].[ClientRider]
	WHERE  [C_RiderID] = @C_RiderID

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_ClientInsert]    Script Date: 03/13/2018 22:19:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_ClientInsert] 
    @Profile_Name nvarchar(100),
    @Password nvarchar(MAX),
    @First_Name nvarchar(20),
    @Middle_Name nvarchar(20) = NULL,
    @Last_Name nvarchar(20),
    @Email_Address nvarchar(MAX),
    @Contact_Number int = NULL,
    @Cell_Number int,
    @Location_ID int,
    @PickUp_Address nvarchar(MAX),
    @Drop_Address nvarchar(MAX),
    @QR_Code nvarchar(50),
    @Rating int,
    @Created_DateTime datetime2(7),
    @Created_By int,
    @Modified_DateTime datetime2(7),
    @Modified_By int,
    @Deleted bit
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN
	
	INSERT INTO [dbo].[Client] ([Profile_Name], [Password], [First_Name], [Middle_Name], [Last_Name], [Email_Address], [Contact_Number], [Cell_Number], [Location_ID], [PickUp_Address], [Drop_Address], [QR_Code], [Rating], [Created_DateTime], [Created_By], [Modified_DateTime], [Modified_By], [Deleted])
	SELECT @Profile_Name, @Password, @First_Name, @Middle_Name, @Last_Name, @Email_Address, @Contact_Number, @Cell_Number, @Location_ID, @PickUp_Address, @Drop_Address, @QR_Code, @Rating, @Created_DateTime, @Created_By, @Modified_DateTime, @Modified_By, @Deleted
	
	-- Begin Return Select <- do not remove
	SELECT [Client_ID], [Profile_Name], [Password], [First_Name], [Middle_Name], [Last_Name], [Email_Address], [Contact_Number], [Cell_Number], [Location_ID], [PickUp_Address], [Drop_Address], [QR_Code], [Rating], [Created_DateTime], [Created_By], [Modified_DateTime], [Modified_By], [Deleted]
	FROM   [dbo].[Client]
	WHERE  [Client_ID] = SCOPE_IDENTITY()
	-- End Return Select <- do not remove
               
	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_ClientDelete]    Script Date: 03/13/2018 22:19:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_ClientDelete] 
    @Client_ID int
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	DELETE
	FROM   [dbo].[Client]
	WHERE  [Client_ID] = @Client_ID

	COMMIT
GO
