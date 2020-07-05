USE [FoodPreReqDb]
GO

/****** Object:  StoredProcedure [dbo].[GetOnlineCustomersByCategoryAndPincode]    Script Date: 18/05/2020 12:44:48 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROCEDURE  [dbo].[GetOnlineCustomersByCategoryAndPincode]  
	-- Add the parameters for the stored procedure here
	@Category nvarchar(max),
	@Pincode nvarchar(max)
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
	where Category like @Category and Pincode = @Pincode
END 
GO


