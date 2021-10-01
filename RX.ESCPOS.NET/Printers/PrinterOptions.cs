namespace RX.ESCPOS.NET.Printers
{
    public class PrinterOptions
    {
        int IdleTimeoutSeconds { get; set; } = 60;
        int StatusPollingIntervalMilliseconds { get; set; } = 500;
    }
}
