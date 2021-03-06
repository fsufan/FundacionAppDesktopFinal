DROP SEQUENCE seq_HistoMedico;
DROP SEQUENCE seq_seq_servicio;
DROP SEQUENCE seq_ficharesidente;
DROP SEQUENCE seq_Familiar;
DROP SEQUENCE seq_InforPersonal;
DROP SEQUENCE seq_Residente;
DROP SEQUENCE seq_Contrato;
DROP SEQUENCE seq_Det_Contrato;
DROP SEQUENCE seq_Direccion;
DROP SEQUENCE seq_Servicio;

CREATE SEQUENCE seq_servicio START WITH 1 INCREMENT BY 1;
CREATE SEQUENCE seq_Direccion START WITH 1 INCREMENT BY 1;
CREATE SEQUENCE seq_HistoMedico START WITH 1 INCREMENT BY 1;
CREATE SEQUENCE seq_ficharesidente START WITH 1 INCREMENT BY 1;
CREATE SEQUENCE seq_Familiar START WITH 1 INCREMENT BY 1;
CREATE SEQUENCE seq_InforPersonal START WITH 1 INCREMENT BY 1;
CREATE SEQUENCE seq_Residente START WITH 1 INCREMENT BY 1;
CREATE SEQUENCE seq_Contrato START WITH 1 INCREMENT BY 1;
CREATE SEQUENCE seq_Det_Contrato START WITH 1 INCREMENT BY 1;


CREATE OR REPLACE TRIGGER DIRECCION_id 
BEFORE INSERT ON DIRECCION
FOR EACH ROW
BEGIN
  :new.ID_DIRECCION := seq_Direccion.nextval;
END;


CREATE OR REPLACE TRIGGER HistorialMedico_id 
BEFORE INSERT ON HISTO_MEDICO
FOR EACH ROW
BEGIN
  :new.ID_HISTORIALMED := seq_HistoMedico.nextval;
END;


CREATE OR REPLACE TRIGGER FichaResidente_id 
BEFORE INSERT ON FIC_RESIDENTE
FOR EACH ROW
BEGIN
  :new.ID_FIC_RESIDENTE := SEQ_FICHARESIDENTE.nextval;
END;


CREATE OR REPLACE TRIGGER Familiar_id 
BEFORE INSERT ON FAMILIAR
FOR EACH ROW
BEGIN
  :new.ID_FAMILIAR := seq_Familiar.nextval;
END;


CREATE OR REPLACE TRIGGER InfoPersonal_id 
BEFORE INSERT ON INFO_PERSONAL
FOR EACH ROW
BEGIN
  :new.ID_INFOPERSONAL := seq_InforPersonal.nextval;
END;


CREATE OR REPLACE TRIGGER Residente_id 
BEFORE INSERT ON RESIDENTE
FOR EACH ROW
BEGIN
  :new.ID_RESIDENTE := seq_Residente.nextval;
END;


CREATE OR REPLACE TRIGGER Contrato_id 
BEFORE INSERT ON CONTRATO
FOR EACH ROW
BEGIN
  :new.ID_CONTRATO := seq_Contrato.nextval;
END;


CREATE OR REPLACE TRIGGER Detcontrato_id 
BEFORE INSERT ON DET_CONTRATO
FOR EACH ROW
BEGIN
  :new.ID_DET_CONTRATO := seq_Det_Contrato.nextval;
END;



CREATE OR REPLACE TRIGGER servicio_id 
BEFORE INSERT ON SERVICIO
FOR EACH ROW
BEGIN
  :new.ID_SERVICIO := seq_servicio.nextval;
END;
