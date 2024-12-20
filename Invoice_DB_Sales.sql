USE [Invoice_DB_Sales]
GO
/****** Object:  Table [dbo].[CustAndVends]    Script Date: 16-01-2024 15:20:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CustAndVends](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Phone] [nvarchar](50) NULL,
	[Address] [nvarchar](50) NULL,
	[PartType] [int] NULL,
 CONSTRAINT [PK_CustAndVend] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Invoice_Det]    Script Date: 16-01-2024 15:20:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Invoice_Det](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Item_Code] [nvarchar](50) NULL,
	[Item_Qty] [int] NULL,
	[Item_Price] [decimal](18, 2) NULL,
	[total_Price] [decimal](18, 2) NULL,
	[InvoiceID] [int] NOT NULL,
	[IsIN] [bit] NULL,
 CONSTRAINT [PK_Invoice_Det] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Invoice_Header]    Script Date: 16-01-2024 15:20:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Invoice_Header](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Invoice_Nu] [nvarchar](50) NULL,
	[Invoice_Date] [date] NULL,
	[Customer_ID] [int] NULL,
	[Invoice_Total] [decimal](18, 2) NULL,
	[Invoice_Discount] [decimal](18, 2) NULL,
	[Invoice_Tax] [decimal](18, 2) NULL,
	[Invoice_Net] [decimal](18, 2) NULL,
	[Invoice_Paid] [decimal](18, 2) NULL,
	[Invoice_remain] [decimal](18, 2) NULL,
	[Invoice_Type] [int] NULL,
	[invoice_Note] [nvarchar](max) NULL,
 CONSTRAINT [PK_Invoice_Header] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[products]    Script Date: 16-01-2024 15:20:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[products](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[code] [nvarchar](50) NULL,
	[productName] [nvarchar](50) NULL,
	[BuyPrice] [decimal](18, 2) NULL,
	[SalePrice] [decimal](18, 2) NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_products] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
