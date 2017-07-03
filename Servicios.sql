Insert into Servicio (ID_SERVICIO,NOMBRE_SERV,DESCRIPCION,COSTO_SERV)values(1,'Hospedaje Completo','Completo Servicio al Residente',1500000);
Insert into Servicio (ID_SERVICIO,NOMBRE_SERV,DESCRIPCION,COSTO_SERV)values(2,'Hospedaje Diario','Completo Servicio al Residente por el dia',500000);

INSERT INTO det_contrato (
    id_det_contrato,
    id_servicio,
    costo_total
) VALUES (1,1,1500000);

INSERT INTO det_contrato (
    id_det_contrato,
    id_servicio,
    costo_total
) VALUES (2,2,500000);

INSERT INTO contrato (
    id_contrato,
    id_det_contrato,
    condiciones_perm
) VALUES (1,1,'Cuidados Pernocturnos');

INSERT INTO contrato (
    id_contrato,
    id_det_contrato,
    condiciones_perm
) VALUES (2,2,'Toda la Alimentacion Necesaria');