namespace ITWebNet.Food.Core.DataContracts.Common
{
    public class ReportModel
    {
        public byte[] FileBody { get; set; }
        
        public string FileName { get; set; }
        
        public byte[] Hash { get; set; }
    }
}
