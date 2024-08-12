
namespace YG
{
    [System.Serializable]
    public class SavesYG
    {
        // "Технические сохранения" для работы плагина (Не удалять)
        public int idSave;
        public bool isFirstSession = true;
        public string language = "ru";
        public bool promptDone;

        // Тестовые сохранения для демо сцены
        // Можно удалить этот код, но тогда удалите и демо (папка Example)
        public int money = 1;                       // Можно задать полям значения по умолчанию
        public string newPlayerName = "Hello!";
        public bool[] openLevels = new bool[3];

        // Ваши сохранения

        public bool VolumeIsActive = true;
        
        public int record = 0;
        
        public bool DEFAULTSkinSelected = true;
        public bool WATERMELONSkinSelected = false;
        public bool STARSSkinSelected = false;
        public bool SHARKSkinSelected = false;
        public bool SAVETRUSTSkinSelected = false;
        public bool RAINBOWSkinSelected = false;
        public bool MINECRAFTSkinSelected = false;
        public bool MARIOSkinSelected = false;
        public bool KRENDELSkinSelected = false;
        public bool INSIDESkinSelected = false;
        public bool DONUTSkinSelected = false;
        public bool CANDYSkinSelected = false;
        public bool BEACHSkinSelected = false;
        public bool BANANASkinSelected = false;
        public bool BADTRIPSkinSelected = false;
        public bool WHEELSkinSelected = false;
        
        public bool SkinIsOpenWATERMELON = false;
        public bool SkinIsOpenSTARS = false;
        public bool SkinIsOpenSHARK = false;
        public bool SkinIsOpenSAVE_TRUST = false;
        public bool SkinIsOpenRAINBOW = false;
        public bool SkinIsOpenMINECRAFT = false;
        public bool SkinIsOpenMARIO = false;
        public bool SkinIsOpenKRENDEL = false;
        public bool SkinIsOpenINSIDE = false;
        public bool SkinIsOpenBANANA = false;
        public bool SkinIsOpenCANDY = false;
        public bool SkinIsOpenBEACH = false;
        public bool SkinIsOpenDONUT = false;
        public bool SkinIsOpenBADTRIP = false;
        public bool SkinIsOpenWHEEL = false;
        
        public int NumberAdsViewedForWATERMELON = 1;
        public int NumberAdsViewedForSTARS = 2;
        public int NumberAdsViewedForSHARK = 3;
        public int NumberAdsViewedForSAVE_TRUST = 4;
        public int NumberAdsViewedForRAINBOW = 5;

        // Поля (сохранения) можно удалять и создавать новые. При обновлении игры сохранения ломаться не должны


        // Вы можете выполнить какие то действия при загрузке сохранений
        public SavesYG()
        {
            // Допустим, задать значения по умолчанию для отдельных элементов массива

            openLevels[1] = true;
        }
    }
}
