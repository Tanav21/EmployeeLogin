USE [ems_db]
GO

/****** Object:  Table [dbo].[tasks]    Script Date: 2/11/2026 10:45:38 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tasks](
	[Description] [varchar](70) NULL,
	[refUser] [int] NULL,
	[IsCompleted] [bit] NULL,
	[TaskId] [int] IDENTITY(1,1) NOT NULL,
	[CreatedOn] [datetime] NOT NULL,
	[UpdatedOn] [datetime] NOT NULL,
 CONSTRAINT [PK_tasks_TaskId] PRIMARY KEY CLUSTERED 
(
	[TaskId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[tasks] ADD  DEFAULT ((0)) FOR [IsCompleted]
GO

ALTER TABLE [dbo].[tasks] ADD  DEFAULT (getdate()) FOR [CreatedOn]
GO

ALTER TABLE [dbo].[tasks] ADD  DEFAULT (getdate()) FOR [UpdatedOn]
GO

ALTER TABLE [dbo].[tasks]  WITH CHECK ADD  CONSTRAINT [FK_Tasks_Users] FOREIGN KEY([refUser])
REFERENCES [dbo].[users] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[tasks] CHECK CONSTRAINT [FK_Tasks_Users]
GO


