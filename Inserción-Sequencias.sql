CREATE TABLE ROL
  (
    ID_ROL          INTEGER NOT NULL PRIMARY KEY,
    NOMBRE_ROL      VARCHAR2 (20) NOT NULL,
    DESCRIPCION_ROL VARCHAR2 (50)
  ) ;
 
 
CREATE TABLE USUARIO
  (
    ID_USUARIO INTEGER NOT NULL PRIMARY KEY,
    RUT_USUARIO VARCHAR(10) NOT NULL,
    CONTRASENA VARCHAR2 (20) NOT NULL,
    ID_ROL INTEGER NOT NULL
  );
  
  alter table FUNDACION.USUARIO
   add constraint FK_ROL_USUARIO foreign key (ID_ROL)
      references FUNDACION.ROL (ID_ROL)
      on delete cascade;
      
DROP SEQUENCE seq_rol;

CREATE SEQUENCE seq_rol START WITH 1 INCREMENT BY 1;

CREATE OR REPLACE TRIGGER seq_rol 
BEFORE INSERT ON ROL 
FOR EACH ROW
BEGIN
  :new.ID_ROL := seq_rol.nextval;
END;

DROP SEQUENCE seq_usuario;

CREATE SEQUENCE seq_usuario START WITH 1 INCREMENT BY 1;

CREATE OR REPLACE TRIGGER seq_usuario 
BEFORE INSERT ON USUARIO
FOR EACH ROW
BEGIN
  :new.ID_USUARIO := seq_usuario.nextval;
END;


/*Insert into table USUARIO*/
insert into USUARIO
values (1, 18998347-2, 'admin', 1);
insert into USUARIO
values (2, 8732123-1, 'supervisor', 2);
insert into USUARIO
values (3, 13988232-4, 'enfermera', 3);
 insert into USUARIO
values (4, 15678981-6, 'paramedico', 4);
insert into USUARIO
values (5, 13668200-2, 'encargadofarmacia', 5);

/*Insert into table ROL*/
insert into ROL
values (1, 'Administrador', 'Persona con todos los privilegios.');
insert into ROL
values (2, 'Supervisor', 'Persona encargada de la gestión de la fundación.');
insert into ROL
values (3, 'Enfermera', 'Persona encargada del cuidado de los pacientes.');
 insert into ROL
values (4, 'Paramédico', 'Persona encargada de trasladar pacientes.');
insert into ROL
values (5, 'Encargado Farmacia', 'Administra inventario medicamentos.');

SELECT * FROM USUARIO;
SELECT * FROM ROL;
   