USE [PlaceHolder]
GO

SET DATEFORMAT DMY

insert into NAMHOC values(1, '2012-2013')
insert into NAMHOC values(2, '2014-2015')

insert into HOCKY values(1, 1, N'HK I')
insert into HOCKY values(2, 1, N'HK II')
insert into HOCKY values(3, 1, N'HK Hè')
insert into HOCKY values(4, 2, N'HK I')
insert into HOCKY values(5, 2, N'HK II')
insert into HOCKY values(6, 2, N'HK Hè')

insert into KHOA values('SE', N'Kỹ Thuật Phần Mềm')
insert into KHOA values('CE', N'Kỹ Thuật Máy Tính')
insert into KHOA values('CS', N'Khoa Học Máy Tính')

insert into LOP values('KTPM2012.1', N'Kỹ thuật phần mềm 2012 - 1','SE',1)
insert into LOP values('KTPM2012.2', N'Kỹ thuật phần mềm 2012 - 2','SE',1)
