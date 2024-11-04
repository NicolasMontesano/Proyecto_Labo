CREATE PROCEDURE SP_TOTAL_FACTURADO
  @Fecha int
AS
BEGIN

  SELECT SUM(Monto) AS TotalFacturado -- lo hice SUM porque me devuelve el Monto total
  FROM Facturas
  WHERE MONTH(FechaDePago) = @Fecha;
END;


