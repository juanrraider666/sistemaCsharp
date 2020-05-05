update Producto set Precio = 33000 where Producto = 'tipo 1'
select *from Producto 
select Documento,Nombre,Apellido,Usuario,Contraseña from Persona
select Documento,Nombre,Apellido,Usuario,contraseña,Rol from Persona inner join Rol on Persona.IdRol = Rol.IdRol
select Producto ,Color ,valorTotalProducto from Producto inner join DetalleVenta on Producto.IdProducto = DetalleVenta.IdProducto 
select Referencia,Presentacion,Tipo,color,DetalleVenta.Cantidad,ValorTotalProducto from Producto inner join Presentacion on Presentacion.IdPresentacion = Producto.IdPresentacion inner join Tipo on Tipo.IdTipo = Producto.IdTipo inner join DetalleVenta on DetalleVenta.IdProducto = Producto.IdProducto where DetalleVenta.IdProducto =1
select * from DetalleVenta