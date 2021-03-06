USE [[THUCTAP5]]_QuanLyKhoHang]
GO
/****** Object:  Table [dbo].[chitietphieunhap]    Script Date: 22/04/2017 4:48:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[chitietphieunhap](
	[ma] [int] IDENTITY(1,1) NOT NULL,
	[phieunhapma] [int] NOT NULL,
	[hanghoama] [int] NOT NULL,
	[soluong] [int] NOT NULL,
	[dongia] [int] NOT NULL,
 CONSTRAINT [PK_chitietphieunhap] PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[chitietphieuxuat]    Script Date: 22/04/2017 4:48:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[chitietphieuxuat](
	[ma] [int] IDENTITY(1,1) NOT NULL,
	[phieuxuatma] [int] NOT NULL,
	[hanghoama] [int] NOT NULL,
	[soluong] [int] NOT NULL,
	[dongia] [int] NOT NULL,
 CONSTRAINT [PK_chitietphieuxuat] PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[hanghoa]    Script Date: 22/04/2017 4:48:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hanghoa](
	[ma] [int] IDENTITY(1,1) NOT NULL,
	[ten] [nvarchar](50) NOT NULL,
	[donvitinh] [nvarchar](50) NOT NULL,
	[soluong] [int] NOT NULL,
	[xuatxu] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_hanghoa] PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[nhacungcap]    Script Date: 22/04/2017 4:48:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nhacungcap](
	[ma] [int] IDENTITY(1,1) NOT NULL,
	[ten] [nvarchar](50) NOT NULL,
	[diachi] [nvarchar](50) NOT NULL,
	[sdt] [nvarchar](50) NOT NULL,
	[masothue] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_nhacungcap] PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[nhanhanhang]    Script Date: 22/04/2017 4:48:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nhanhanhang](
	[ma] [int] IDENTITY(1,1) NOT NULL,
	[ten] [nvarchar](50) NOT NULL,
	[diachi] [nvarchar](50) NOT NULL,
	[sdt] [nvarchar](50) NOT NULL,
	[masothue] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_nhanhanhang] PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[phieunhap]    Script Date: 22/04/2017 4:48:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[phieunhap](
	[ma] [int] IDENTITY(1,1) NOT NULL,
	[ten] [nvarchar](50) NOT NULL,
	[ngaynhap] [datetime] NOT NULL,
	[nhacungcapma] [int] NOT NULL,
	[thukhoma] [int] NOT NULL,
	[ghichu] [ntext] NULL,
 CONSTRAINT [PK_phieunhap] PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[phieuxuat]    Script Date: 22/04/2017 4:48:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[phieuxuat](
	[ma] [int] IDENTITY(1,1) NOT NULL,
	[ten] [nvarchar](50) NOT NULL,
	[ngayxuat] [datetime] NOT NULL,
	[lydoxuat] [nvarchar](50) NOT NULL,
	[nhanhanhangma] [int] NOT NULL,
	[thukhoma] [int] NOT NULL,
	[ghichu] [ntext] NULL,
 CONSTRAINT [PK_phieuxuat] PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[thukho]    Script Date: 22/04/2017 4:48:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[thukho](
	[ma] [int] IDENTITY(1,1) NOT NULL,
	[username] [nchar](50) NOT NULL,
	[password] [nchar](50) NOT NULL,
	[ten] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_thukho] PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
