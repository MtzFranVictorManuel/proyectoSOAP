using System;

public class Factura
{
    public int Id { get; set; }
    public string Version { get; set; }
    public string Serie { get; set; }
    public string Folio { get; set; }
    public DateTime Fecha { get; set; }
    public string Sello { get; set; }
    public string FormaPago { get; set; }
    public string NoCertificado { get; set; }
    public string Certificado { get; set; }
    public string CondicionesDePago { get; set; }
    public decimal SubTotal { get; set; }
    public decimal? Descuento { get; set; }
    public string Moneda { get; set; }
    public decimal Total { get; set; }
    public string TipoDeComprobante { get; set; }
    public string Exportacion { get; set; }
    public string MetodoPago { get; set; }
    public string LugarExpedicion { get; set; }
    public string RfcEmisor { get; set; }
    public string NombreEmisor { get; set; }
    public string RegimenFiscalEmisor { get; set; }
    public string RfcReceptor { get; set; }
    public string NombreReceptor { get; set; }
    public string DomicilioFiscalReceptor { get; set; }
    public string RegimenFiscalReceptor { get; set; }
    public string UsoCFDI { get; set; }
    public string ObjetoImp { get; set; }
    public string ClaveProdServ { get; set; }
    public decimal Cantidad { get; set; }
    public string ClaveUnidad { get; set; }
    public string Unidad { get; set; }
    public string Descripcion { get; set; }
    public decimal ValorUnitario { get; set; }
    public decimal Importe { get; set; }
    public decimal? DescuentoConcepto { get; set; }
    public decimal BaseTraslado { get; set; }
    public string Impuesto { get; set; }
    public string TipoFactor { get; set; }
    public decimal TasaOCuota { get; set; }
    public decimal ImporteTraslado { get; set; }
}