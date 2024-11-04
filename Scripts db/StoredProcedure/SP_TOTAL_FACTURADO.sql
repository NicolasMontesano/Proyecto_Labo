CREATE PROCEDURE SP_TOTAL_FACTURADO
  @Fecha DATE
AS
BEGIN
  DECLARE @MesDePago INT;
  SET @MesDePago = MONTH(@Fecha);

  SELECT SUM(Monto) AS TotalFacturado -- lo hice SUM porque me devuelve el Monto total
  FROM Facturas
  WHERE MONTH(FechaDePago) = @MesDePago;
END;