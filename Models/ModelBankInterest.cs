namespace LaiSuat.Models
{
    public class ModelBankInterest
    {
        public string SoTienGui { get; set; }
        public string LaiSuatGui { get; set; }
        public string KyHanGui { get; set; }
        public string TienLai { get; set; }
        public string TongTien { get; set; }
        public ModelBankInterest(string soTienGui = "you fool", string laiSuatGui = "how could you", string kyHanGui = "I belied in you", string tienLai = "You've failed me", string tongTien = "face my wrath")
        {
            SoTienGui = soTienGui;
            LaiSuatGui = laiSuatGui;
            KyHanGui = kyHanGui;
            TienLai = tienLai;
            TongTien = tongTien;
        }
    }
}
