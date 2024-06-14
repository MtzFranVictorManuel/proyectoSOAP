CREATE DATABASE FacturaDb;
USE FacturaDb;

CREATE USER pruebas@localhost IDENTIFIED BY 'Zx2Nv021O';
GRANT ALL ON FacturaDb.* to pruebas@localhost;

CREATE TABLE Factura (
    Id INT PRIMARY KEY AUTO_INCREMENT, -- Primary Key with auto-increment
    Version VARCHAR(10) NOT NULL,
    Serie VARCHAR(10) NOT NULL,
    Folio VARCHAR(20) NOT NULL,
    Fecha DATETIME NOT NULL,
    Sello TEXT NOT NULL,
    FormaPago VARCHAR(10) NOT NULL,
    NoCertificado VARCHAR(20) NOT NULL,
    Certificado TEXT NOT NULL,
    CondicionesDePago VARCHAR(50),
    SubTotal DECIMAL(18, 2) NOT NULL,
    Descuento DECIMAL(18, 2),
    Moneda VARCHAR(10) NOT NULL,
    Total DECIMAL(18, 2) NOT NULL,
    TipoDeComprobante VARCHAR(3) NOT NULL,
    Exportacion VARCHAR(3) NOT NULL,
    MetodoPago VARCHAR(10) NOT NULL,
    LugarExpedicion VARCHAR(10) NOT NULL,
    RfcEmisor VARCHAR(13) NOT NULL,
    NombreEmisor VARCHAR(100) NOT NULL,
    RegimenFiscalEmisor VARCHAR(10) NOT NULL,
    RfcReceptor VARCHAR(13) NOT NULL,
    NombreReceptor VARCHAR(100) NOT NULL,
    DomicilioFiscalReceptor VARCHAR(250) NOT NULL,
    RegimenFiscalReceptor VARCHAR(10) NOT NULL,
    UsoCFDI VARCHAR(3) NOT NULL,
    ObjetoImp VARCHAR(3) NOT NULL,
    ClaveProdServ VARCHAR(10) NOT NULL,
    Cantidad DECIMAL(18, 2) NOT NULL,
    ClaveUnidad VARCHAR(10) NOT NULL,
    Unidad VARCHAR(20) NOT NULL,
    Descripcion VARCHAR(255) NOT NULL,
    ValorUnitario DECIMAL(18, 2) NOT NULL,
    Importe DECIMAL(18, 2) NOT NULL,
    DescuentoConcepto DECIMAL(18, 2),
    BaseTraslado DECIMAL(18, 2) NOT NULL,
    Impuesto VARCHAR(3) NOT NULL,
    TipoFactor VARCHAR(10) NOT NULL,
    TasaOCuota DECIMAL(18, 6) NOT NULL,
    ImporteTraslado DECIMAL(18, 2) NOT NULL
);


INSERT INTO Factura (
    Version, Serie, Folio, Fecha, Sello, FormaPago, NoCertificado, Certificado, CondicionesDePago,
    SubTotal, Descuento, Moneda, Total, TipoDeComprobante, Exportacion, MetodoPago, LugarExpedicion,
    RfcEmisor, NombreEmisor, RegimenFiscalEmisor, RfcReceptor, NombreReceptor, DomicilioFiscalReceptor,
    RegimenFiscalReceptor, UsoCFDI, ObjetoImp, ClaveProdServ, Cantidad, ClaveUnidad, Unidad, Descripcion,
    ValorUnitario, Importe, DescuentoConcepto, BaseTraslado, Impuesto, TipoFactor, TasaOCuota, ImporteTraslado
) VALUES
('4.0', 'A', '001', '2023-05-01 10:00:00', 'SELLO1', '01', 'CERT001', 'CERTIFICADO1', 'Condiciones1',
 1000.00, 0.00, 'MXN', 1000.00, 'I', '02', 'PUE', '01000', 'AAA010101AAA', 'Empresa A', '601', 'BBB010101BBB', 'Cliente A', 'Calle 1',
 '601', 'G01', '02', '10101501', 2.00, 'H87', 'Pieza', 'Producto A', 500.00, 1000.00, 0.00, 1000.00, '002', 'Tasa', 0.160000, 160.00),
('4.0', 'B', '002', '2023-05-02 11:00:00', 'SELLO2', '02', 'CERT002', 'CERTIFICADO2', 'Condiciones2',
 2000.00, 100.00, 'USD', 1900.00, 'E', '01', 'TRF', '02000', 'AAA020202AAA', 'Empresa B', '602', 'BBB020202BBB', 'Cliente B', 'Calle 2',
 '602', 'G02', '03', '10101502', 4.00, 'H88', 'Caja', 'Producto B', 500.00, 2000.00, 100.00, 1900.00, '003', 'Exento', 0.000000, 0.00),
('4.0', 'C', '003', '2023-05-03 12:00:00', 'SELLO3', '03', 'CERT003', 'CERTIFICADO3', 'Condiciones3',
 3000.00, 200.00, 'EUR', 2800.00, 'N', '03', 'PUE', '03000', 'AAA030303AAA', 'Empresa C', '603', 'BBB030303BBB', 'Cliente C', 'Calle 3',
 '603', 'G03', '04', '10101503', 6.00, 'H89', 'Kilo', 'Producto C', 500.00, 3000.00, 200.00, 2800.00, '001', 'Tasa', 0.160000, 160.00),
('4.0', 'D', '004', '2023-05-04 13:00:00', 'SELLO4', '04', 'CERT004', 'CERTIFICADO4', 'Condiciones4',
 4000.00, 300.00, 'GBP', 3700.00, 'T', '02', 'TRF', '04000', 'AAA040404AAA', 'Empresa D', '604', 'BBB040404BBB', 'Cliente D', 'Calle 4',
 '604', 'G04', '05', '10101504', 8.00, 'H90', 'Litro', 'Producto D', 500.00, 4000.00, 300.00, 3700.00, '002', 'Tasa', 0.160000, 160.00),
('4.0', 'E', '005', '2023-05-05 14:00:00', 'SELLO5', '05', 'CERT005', 'CERTIFICADO5', 'Condiciones5',
 5000.00, 400.00, 'JPY', 4600.00, 'P', '01', 'PUE', '05000', 'AAA050505AAA', 'Empresa E', '605', 'BBB050505BBB', 'Cliente E', 'Calle 5',
 '605', 'G05', '06', '10101505', 10.00, 'H91', 'Metro', 'Producto E', 500.00, 5000.00, 400.00, 4600.00, '003', 'Exento', 0.000000, 0.00);

