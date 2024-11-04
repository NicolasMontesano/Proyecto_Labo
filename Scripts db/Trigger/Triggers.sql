create trigger TR_Alta_Factura on Alumnos
after insert 
as
begin

	begin try
		begin transaction
		declare @id int
		select @id = IdAlumno from inserted

		insert into Facturas(IdAlumno, Monto, FechaDeEmision, FechaDePago, FechaDeVencimiento)
		values(@id, (select Precio from Disciplina where IdDisciplina=1), GETDATE(), GETDATE(), GETDATE());
	
		commit transaction
	end try

	begin catch
		rollback transaction
	end catch
end

create trigger TR_Descuento_Creditos on Facturas
after insert 
as
begin

	begin try
		begin transaction
		declare @id int
		select @id = IdAlumno from inserted

		update Creditos_Alumno set Creditos= Creditos - 1 where IdAlumno = @id and Creditos > 0

		commit transaction
	end try

	begin catch
		rollback transaction
	end catch
end
