CREATE OR ALTER PROCEDURE XoaCaLam @id int
AS
BEGIN
DELETE FROM PhanCongCaLam
WHERE PhanCongCaLam.id = @id;
END
GO

CREATE OR ALTER PROCEDURE [dbo].[BaoCaoThang] @month datetime, @year datetime
AS
BEGIN
	SELECT NguyenLieu.id, [name], category, NguyenLieu.quantity, product_date
	FROM NguyenLieu
	WHERE @month =  MONTH(import_date) AND @year = YEAR(import_date)
END
GO

CREATE OR ALTER PROCEDURE [dbo].[LayNguyenVatLieu] @LayNVL int, @product_id int
AS
BEGIN
UPDATE NguyenLieu
SET quantity = quantity - @LayNVL
WHERE id = @product_id
END
GO


CREATE OR ALTER PROCEDURE [dbo].[PhanCong] @user_id int, @calam_id nvarchar(5), @ngayLam Datetime
AS
BEGIN
    INSERT INTO PhanCongCaLam ([user_id], calam_id, ngayLam)
    VALUES (@user_id, @calam_id, @ngayLam)
END
GO

CREATE OR ALTER PROCEDURE [dbo].[UpdateTable] @table_id int
AS
UPDATE [Table]
SET [status] = 1
WHERE id = @table_id
GO
