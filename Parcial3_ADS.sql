--create database parcial3_kirio;
use parcial3_kirio;

create table departamento(
id_departamento int not null identity(1,1) primary key,
nombre_departamento varchar(60) not null);
insert into departamento(nombre_departamento) values ('Informática'),('Ventas');

create table subdepartamento(
id_subdepartamento int not null identity(1,1) primary key,
nombre_subdepartamento varchar(60) not null,
id_departamento int not null,
constraint fk_depa_subdepa foreign key (id_departamento) references departamento(id_departamento));
insert into subdepartamento(nombre_subdepartamento,id_departamento) values ('Desarrollo',1);

create table sexo(
id_sexo int identity(1,1) primary key not null,
sexo varchar(20) not null
);

insert into sexo(sexo) values('Femenino'),('Masculino');

create table empleados(
id_empleado int not null identity(1,1) primary key,
nombres varchar(100) not null,
apellidos varchar(100) not null,
fecha_nacimiento date not null,
correo_electronico varchar(60) not null,
dui varchar(12) not null unique,
nit varchar(20),
fecha_registro date default(getdate()),
telefono varchar(10) not null,
estado bit default 1,
direccion varchar(250),
id_departamento int not null,
id_sexo int not null,
constraint fk_sexo_empleado foreign key (id_sexo)references sexo(id_sexo),
constraint fk_empleado_depa foreign key (id_departamento) references subdepartamento(id_subdepartamento));
insert into empleados(nombres,apellidos,fecha_nacimiento,correo_electronico,dui,telefono,direccion,id_departamento,id_sexo)
values('Pedro', 'Molina', '1990-10-10','pedro@gmail.com','0615487-0','7845-7845','San Salvador',1,2);
insert into empleados(nombres,apellidos,fecha_nacimiento,correo_electronico,dui,telefono,direccion,id_departamento,id_sexo)
values('Carlos', 'Rodriguez', '1990-10-10','carlos@gmail.com','0784510-0','7845-7845','San Salvador',1,2);

create table plaza(
id_plaza int not null identity(1,1) primary key,
plaza varchar(60) not null);
insert into plaza(plaza) values('Programador'),('consultor'),('DBA');

create table turno_horario(
id_turno int not null identity(1,1) primary key,
turno varchar(60) not null);

insert into turno_horario(turno) values('Matutino'),('Vespertino');

create table contrato(
id_contrato int not null identity(1,1) primary key,
id_empleado int not null unique,
id_plaza int not null,
id_turno int not null,
horas_semana int not null,
salario_base real not null,
fecha_contrato date default(getdate()),
estado bit default (1),
constraint fk_plaza_contrato foreign key(id_plaza) references plaza(id_plaza),
constraint fk_empleado_contrato foreign key(id_empleado) references empleados (id_empleado),
constraint fk_turno_contrato foreign key (id_turno) references turno_horario(id_turno));
insert into contrato (id_empleado,id_plaza,id_turno,horas_semana,salario_base) values(1,1,1,40,500);
insert into contrato (id_empleado,id_plaza,id_turno,horas_semana,salario_base) values(2,1,2,35,500);

create table mes(
id_mes int not null identity(1,1) primary key,
mes varchar(30) not null);

insert into mes(mes) 
values('Enero'),('Febrero'),('Marzo'),('Abril'),('Mayo'),('Junio'),('Julio'),('Agosto'),('Septiembre'),('Octubre'),('Noviembre'),('Diciembre');

create table asistencia_mensual(
id_asistencia int not null identity(1,1) primary key,
id_empleado int not null,
id_mes int not null,
fecha_creacion date default(getdate()),
dias_asistidos int not null,
total_horas_realizadas decimal(3) not null,
constraint fk_empleado_asistencia foreign key(id_empleado) references empleados(id_empleado),
constraint fk_mes_asistencia foreign key(id_mes) references mes(id_mes));

create table boleta_pago_mensual(
id_boleta int not null identity(1,1) primary key,
id_asistencia int not null,
id_mes int not null,
total_desc real not null,
salario_neto real not null,
fecha_generacion date default(getdate()),
constraint fk_mes_boleta foreign key(id_mes) references mes(id_mes),
constraint fk_asistencia_boleta foreign key(id_asistencia) references asistencia_mensual(id_asistencia));

create table tipo_movimiento(
id_movimiento int not null identity(1,1) primary key,
movimiento varchar(60) not null);

insert into tipo_movimiento(movimiento)values('Descuento'),('Abono'),('Descuento de ley');

create table detalle_boleta(
id_detalle int not null identity(1,1) primary key,
id_boleta int not null,
id_mov int not null,
concepto varchar(60) not null,
monto real not null,
fecha_detalle date default(getdate()),
constraint fk_movimiento_detalle foreign key(id_mov) references tipo_movimiento(id_movimiento),
constraint fk_detalle_boleta foreign key(id_boleta) references boleta_pago_mensual(id_boleta));

create table tipo_descuento_ley(
id_tipo_des int primary key identity(1,1) not null,
nombre_desc varchar(60) not null
);
insert into tipo_descuento_ley values ('ISSS'),('RENTA'),('AFP');

create table descuento_ley_detalle(
id_detalle_des int primary key identity(1,1) not null,
id_tipo_des int not null,
fecha_registro datetime default(getdate()),
porcentaje real not null,
categoria tinyint,
posee_rango bit not null,
vigencia bit not null,
constraint fk_tipo_descuento foreign key (id_tipo_des) references tipo_descuento_ley(id_tipo_des)
);

create table rango_descuento(
id_rango_descuento int not null primary key identity(1,1),
rango_inicial real not null,
rango_final real,
cuota real not null,
id_detalle_des int not null,
constraint fk_rango_descuento foreign key(id_detalle_des) references descuento_ley_detalle(id_detalle_des)
);

insert into descuento_ley_detalle (id_tipo_des,porcentaje,categoria,posee_rango,vigencia) values(2, 0.0, 1, 1, 1);
insert into descuento_ley_detalle (id_tipo_des,porcentaje,categoria,posee_rango,vigencia) values(2, 0.1, 2, 1, 1);
insert into descuento_ley_detalle (id_tipo_des,porcentaje,categoria,posee_rango,vigencia) values(2, 0.2, 3, 1, 1);
insert into descuento_ley_detalle (id_tipo_des,porcentaje,categoria,posee_rango,vigencia) values(2, 0.3, 4, 1, 1);
insert into descuento_ley_detalle (id_tipo_des,porcentaje,categoria,posee_rango,vigencia) values(1, 0.03, 1, 0, 1);
insert into descuento_ley_detalle (id_tipo_des,porcentaje,categoria,posee_rango,vigencia) values(3, 0.0725, 1, 0, 1);

insert into rango_descuento values(0.01,472.00, 0, 1);
insert into rango_descuento values(472.01,895.24, 17.67, 2);
insert into rango_descuento values(895.25,2038.10, 60, 3);
insert into rango_descuento values(2038.10,NULL, 288.57, 4);

go
create procedure pa_boleta_pago
@pa_dias int,
@pa_horas real,
@pa_empleado int,
@pa_mes int
as
begin
declare @horario int, @salario_base real, @tipo_empleado int, @calculo_salario real, @precio_hora real;

declare @total_horas real = 0.0, @descuento real = 0.0, @horas_fuera real=0.0, @horas_extras real=0.0, @asis int=0;
declare @afp real=0.0, @isss real=0.0, @renta real=0.0, @sueldo real=0.0;
declare @descuento_total real=0.0, @salario_neto real=0.0, @descuento_renta real=0.0, @descuentos_total real=0.0;
------------------------------------------------------------------------------------------------------------------------------------
insert into asistencia_mensual(dias_asistidos, total_horas_realizadas, id_empleado, id_mes)
values(@pa_dias, @pa_horas, @pa_empleado, @pa_mes);

set @asis = (select (id_asistencia) from asistencia_mensual where id_empleado = @pa_empleado and id_asistencia = @@IDENTITY);

set @horario = (select id_turno from contrato where id_empleado = @pa_empleado);
print 'horario: '+cast(@horario as varchar);

set @salario_base = (select salario_base from contrato where id_empleado = @pa_empleado);
print 'salario base: '+cast(@salario_base as varchar);

set @total_horas = (select (horas_semana) from contrato where id_empleado = @pa_empleado);
print 'total horas: '+cast(@total_horas as varchar);

set @total_horas = @total_horas * 4;
print 'total horas: '+cast(@total_horas as varchar);

set @precio_hora = @salario_base/@total_horas;
print 'precio hora: '+cast(@precio_hora as varchar);

if @horario = 1 
	begin
		if @pa_horas >= @total_horas
			begin
				set @calculo_salario = @precio_hora * @pa_horas;
				print 'calculo salario: '+cast(@calculo_salario as varchar);
				set @descuento = 0.0;
				set @horas_extras = ((@pa_horas - @total_horas) * @precio_hora) * 2;
				print 'horas extras: '+cast(@horas_extras as varchar);
			end
		else	
			begin
				set @horas_extras = 0.0;
				set @horas_fuera = @total_horas - @pa_horas;
				set @descuento = @horas_fuera * @precio_hora;
				set @calculo_salario = (@precio_hora * @pa_horas) - @descuento;
				print 'horas fuera'+cast(@horas_fuera as varchar);
				print 'descuento'+cast(@descuento as varchar);
				print 'calculo salario: '+cast(@calculo_salario as varchar);
			end
	end
else if @horario = 2
begin
	set @precio_hora = @precio_hora * 1.25;

		if @pa_horas >= @total_horas
			begin
				set @calculo_salario = @precio_hora * @pa_horas;
				set @descuento = 0.0;
				set @horas_extras = ((@pa_horas - @total_horas) * @precio_hora) * 2;
				print 'calculo salario: '+cast(@calculo_salario as varchar);
				print 'horas extras: '+cast(@horas_extras as varchar);
			end
		else if @pa_horas < @total_horas
			begin
				set @horas_extras = 0.0;
				set @horas_fuera = @total_horas - @pa_horas;
				set @descuento = @horas_fuera * @precio_hora;
				set @calculo_salario = (@precio_hora * @pa_horas) - @descuento;
				print 'horas fuera: '+cast(@horas_fuera as varchar);
				print 'descuento: '+cast(@descuento as varchar);
				print 'calculo salario: '+cast(@calculo_salario as varchar);
			end
end

set @afp = (select top(1) (porcentaje) from descuento_ley_detalle where id_tipo_des=3 order by fecha_registro desc) * @calculo_salario;
set @isss = (select top(1) (porcentaje) from descuento_ley_detalle where id_tipo_des=1 order by fecha_registro desc) * @calculo_salario;

print 'afp: '+cast(@afp as varchar);
print ' isss: '+cast(@isss as varchar); 

set @sueldo = @calculo_salario - (@afp + @isss) + @horas_extras;

print 'sueldo: '+cast(@sueldo as varchar);

declare @ranin1 real = (select rango_inicial from rango_descuento where id_detalle_des=1)
declare @ranfin1 real = (select rango_final from rango_descuento where id_detalle_des=1) 

if @sueldo > @ranin1 and @sueldo < @ranfin1
	begin
		declare @exceso real = 0
		declare @cuota real = 0
		set @descuento_renta = @sueldo;
	end

else if @sueldo > (select rango_inicial from rango_descuento where id_detalle_des=2) and @sueldo < (select rango_final from rango_descuento where id_detalle_des=2)
	begin
		declare @detalle int = (select top(1) id_detalle_des from descuento_ley_detalle where id_tipo_des = 2 and categoria = 2 order by fecha_registro desc)
		set @exceso = ((select rango_inicial-0.01 from rango_descuento where id_detalle_des=2))
		set @renta = (select top(1) porcentaje from descuento_ley_detalle where id_tipo_des = 2 and categoria = 2 order by fecha_registro desc)
		set @cuota = (select cuota from rango_descuento where id_detalle_des = @detalle)
	end

else if @sueldo > (select rango_inicial from rango_descuento where id_detalle_des=3) and @sueldo < (select rango_final from rango_descuento where id_detalle_des=3)
	begin
		set @exceso = (select rango_inicial-0.01 from rango_descuento where id_detalle_des=3)
		set @renta = (select top(1) porcentaje from descuento_ley_detalle where id_tipo_des = 2 and categoria = 3 order by fecha_registro desc)
		set @detalle = (select top(1) id_detalle_des from descuento_ley_detalle where id_tipo_des = 2 and categoria = 3 order by fecha_registro desc)
		set @cuota  = (select cuota from rango_descuento where id_detalle_des = @detalle)
	end

else if @sueldo > (select rango_inicial from rango_descuento where id_detalle_des=4)
	begin
		set @exceso = (select rango_inicial-0.01 from rango_descuento where id_detalle_des=4)
		set @renta = (select top(1) porcentaje from descuento_ley_detalle where id_tipo_des = 2 and categoria = 4 order by fecha_registro desc)
		set @detalle = (select top(1) id_detalle_des from descuento_ley_detalle where id_tipo_des = 2 and categoria = 4 order by fecha_registro desc)
		set @cuota  = (select cuota from rango_descuento where id_detalle_des = @detalle)
	end

set @descuento_renta = ((@sueldo -  @exceso) * @renta) + @cuota; 
print 'total desc: '+cast(@descuento_renta as varchar);

set @descuentos_total = @afp + @isss + @descuento_renta;
print 'total desc: '+cast(@descuentos_total as varchar);

set @salario_neto = @calculo_salario - @descuentos_total;
print 'salario neto: '+cast(@salario_neto as varchar);

insert into boleta_pago_mensual(id_asistencia,id_mes,total_desc,salario_neto)
values(@asis,@pa_mes,round(@descuentos_total,2),round(@salario_neto,2));

declare @boleta int = (select id_boleta from boleta_pago_mensual where id_boleta = @@IDENTITY);
print 'Boleta id: '+cast(@boleta as varchar);

insert into 
detalle_boleta (id_boleta,id_mov,concepto,monto)
values
(@boleta,2,'Salario devengado',round(@calculo_salario,2)), 
(@boleta,3,'Descuento de AFP',round(@afp,2)),
(@boleta,3,'Descuento de ISSS',round(@isss,2)),
(@boleta,3,'Impuesto sobre la renta',round(@descuento_renta,2)),
(@boleta,1,'Horas/días no laborados',round(@descuento,2)),
(@boleta,2,'Horas extras',round(@horas_extras,2)); 
	
	select b.id_asistencia as bol_asis_num, m.mes as mes, CONCAT(e.nombres,' ',e.apellidos) as empleado, a.total_horas_realizadas as total_horas,
	a.dias_asistidos as dias_asistidos, b.total_desc as descontado, b.salario_neto as salario_neto, b.fecha_generacion as fecha_creacion 
	from boleta_pago_mensual B	
	inner join mes m on m.id_mes = b.id_mes
	inner join asistencia_mensual a on a.id_asistencia = b.id_asistencia
	inner join empleados e on e.id_empleado = a.id_empleado
	where b.id_asistencia = @asis;


	select d.id_boleta as bol_asis_num, m.movimiento as tipo_movimiento, d.concepto as concepto, d.monto as monto, d.fecha_detalle as fecha_creacion 
	from detalle_boleta d
	inner join tipo_movimiento m on m.id_movimiento = d.id_mov
	where id_boleta = @boleta;
end
