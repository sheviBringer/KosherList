USE [KosherList]
GO
DROP TABLE  [dbo].[WorkerScheduler_tbl]
GO
/****** Object:  Table [dbo].[WorkerScheduler_tbl]    Script Date: 04/01/2021 22:42:28 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[WorkerScheduler_tbl](
	[workerSchedulerID] [int] IDENTITY(1,1) NOT NULL,
	[workerId] [int] NOT NULL,
	[hour] [int] NOT NULL,
	[day1] [int] NULL,
	[day2] [int] NULL,
	[day3] [int] NULL,
	[day4] [int] NULL,
	[day5] [int] NULL,
	[day6] [int] NULL,
	[day7] [int] NULL,
 CONSTRAINT [PK_Table_1] PRIMARY KEY CLUSTERED 
(
	[workerSchedulerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[WorkerScheduler_tbl]  WITH CHECK ADD  CONSTRAINT [FK_WorkerId_Workers] FOREIGN KEY([workerId])
REFERENCES [dbo].[Worker_tbl] ([codeWorker])
GO

ALTER TABLE [dbo].[WorkerScheduler_tbl]  WITH CHECK ADD  CONSTRAINT [FK_day1_Stores] FOREIGN KEY([day1])
REFERENCES [dbo].[Store_tbl] ([codeStore])
GO
ALTER TABLE [dbo].[WorkerScheduler_tbl]  WITH CHECK ADD  CONSTRAINT [FK_day2_Stores] FOREIGN KEY([day2])
REFERENCES [dbo].[Store_tbl] ([codeStore])
GO
ALTER TABLE [dbo].[WorkerScheduler_tbl]  WITH CHECK ADD  CONSTRAINT [FK_day3_Stores] FOREIGN KEY([day3])
REFERENCES [dbo].[Store_tbl] ([codeStore])
GO
ALTER TABLE [dbo].[WorkerScheduler_tbl]  WITH CHECK ADD  CONSTRAINT [FK_day4_Stores] FOREIGN KEY([day4])
REFERENCES [dbo].[Store_tbl] ([codeStore])
GO
ALTER TABLE [dbo].[WorkerScheduler_tbl]  WITH CHECK ADD  CONSTRAINT [FK_day5_Stores] FOREIGN KEY([day5])
REFERENCES [dbo].[Store_tbl] ([codeStore])
GO
ALTER TABLE [dbo].[WorkerScheduler_tbl]  WITH CHECK ADD  CONSTRAINT [FK_day6_Stores] FOREIGN KEY([day6])
REFERENCES [dbo].[Store_tbl] ([codeStore])
GO
ALTER TABLE [dbo].[WorkerScheduler_tbl]  WITH CHECK ADD  CONSTRAINT [FK_day7_Stores] FOREIGN KEY([day7])
REFERENCES [dbo].[Store_tbl] ([codeStore])
GO
ALTER TABLE [dbo].[WorkerScheduler_tbl] CHECK CONSTRAINT [FK_WorkerId_Workers]
GO


