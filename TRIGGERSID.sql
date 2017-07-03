CREATE OR REPLACE TRIGGER tr_bodegaMedID
BEFORE INSERT ON BODEGA_MED 
FOR EACH ROW
BEGIN
  :new.ID_BODEGA_MED := seq_bod_med.nextval;
END;
/
CREATE OR REPLACE TRIGGER tr_bodegaProdID
BEFORE INSERT ON BODEGA_PROD 
FOR EACH ROW
BEGIN
  :new.ID_BODEGA_PROD := seq_bod_prod.nextval;
END;
/
CREATE OR REPLACE TRIGGER tr_compraID
BEFORE INSERT ON COMPRA 
FOR EACH ROW
BEGIN
  :new.ID_COMPRA := seq_compra.nextval;
END;
/
CREATE OR REPLACE TRIGGER tr_detCompraID
BEFORE INSERT ON DET_COMPRA 
FOR EACH ROW
BEGIN
  :new.ID_DET_COMPRA := seq_det_compra.nextval;
END;
/
CREATE OR REPLACE TRIGGER tr_inventarioID
BEFORE INSERT ON INVENTARIO 
FOR EACH ROW
BEGIN
  :new.ID_INVENTARIO := seq_inventario.nextval;
END;
/
CREATE OR REPLACE TRIGGER tr_medicinaID
BEFORE INSERT ON MEDICINA 
FOR EACH ROW
BEGIN
  :new.ID_MEDICINA := seq_medicina.nextval;
END;
/
CREATE OR REPLACE TRIGGER tr_productoID
BEFORE INSERT ON PRODUCTO 
FOR EACH ROW
BEGIN
  :new.ID_PRODUCTO := seq_producto.nextval;
END;
/
CREATE OR REPLACE TRIGGER tr_proveedorID
BEFORE INSERT ON PROVEEDOR 
FOR EACH ROW
BEGIN
  :new.ID_PROVEEDOR := seq_proveedor.nextval;
END;
/