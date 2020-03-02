create table video(
idvideo int primary key,
titulo varchar (100),
repro int,
url varchar (100)
)
CREATE PROCEDURE sp_video_insertar
@idvideo int,
@titulo varchar (100),
@repro int,
@url varchar (100)
AS
BEGIN
insert into video VALUES(idvideo,@titulo,@repro,@url)
END