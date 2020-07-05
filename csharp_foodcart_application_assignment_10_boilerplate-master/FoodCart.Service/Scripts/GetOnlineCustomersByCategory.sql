USE [FoodPreReqDb]
GO

/****** Object:  StoredProcedure [dbo].[GetOnlineCustomersByCategory]    Script Date: 18/05/2020 12:46:25 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROCEDURE  [dbo].[GetOnlineCustomersByCategory]  
	-- Add the parameters for the stored procedure here
	@Category nvarchar(max)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Select Customers.CustomerId,Customers.CustomerName, Customers.Email, Customers.PhoneNo, 
		OnlineCustomers.Address,
		OnlineCustomers.Pincode,
		OnlineCustomers.Category,
		Customers.RowVersion
	from Customers inner join OnlineCustomers
	on
	Customers.CustomerId = OnlineCustomers.CustomerId
	where Category like @Category
END
GO


