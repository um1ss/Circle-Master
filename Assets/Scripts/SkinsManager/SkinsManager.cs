using System;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using YG;

public class SkinsManager : MonoBehaviour
{
    [SerializeField] private SoundsManagerMainMenu _soundsManagerMainMenu;
    
    [SerializeField] private GameObject _prefabDonutARCADE;
    [SerializeField] private GameObject _prefabFirstPlayerDonut1VS1;
    [SerializeField] private GameObject _prefabSecondPlayerDonut1VS1;

    [SerializeField] private GameObject _buttonViewAdForSkinWATERMELON;
    [SerializeField] private GameObject _buttonViewAdForSkinSTARS;
    [SerializeField] private GameObject _buttonViewAdForSkinSHARK;
    [SerializeField] private GameObject _buttonViewAdForSkinSAVE_TRUST;
    [SerializeField] private GameObject _buttonViewAdForSkinRAINBOW;

    [SerializeField] private GameObject _buttonSelectWATERMELON;
    [SerializeField] private GameObject _buttonSelectSTARS;
    [SerializeField] private GameObject _buttonSelectSHARK;
    [SerializeField] private GameObject _buttonSelectSAVE_TRUST;
    [SerializeField] private GameObject _buttonSelectRAINBOW;

    [SerializeField] private GameObject _buttonSelectMINECRAFT;
    [SerializeField] private GameObject _buttonSelectMARIO;
    [SerializeField] private GameObject _buttonSelectKRENDEL;
    [SerializeField] private GameObject _buttonSelectINSIDE;
    [SerializeField] private GameObject _buttonSelectDONUT;
    [SerializeField] private GameObject _buttonSelectCANDY;
    [SerializeField] private GameObject _buttonSelectBEACH;
    [SerializeField] private GameObject _buttonSelectBANANA;
    [SerializeField] private GameObject _buttonSelectBADTRIP;
    [SerializeField] private GameObject _buttonSelectWHEEL;

    [SerializeField] private GameObject _pictureOfLockedWATERMELON;
    [SerializeField] private GameObject _pictureOfLockedSTARS;
    [SerializeField] private GameObject _pictureOfLockedSHARK;
    [SerializeField] private GameObject _pictureOfLockedSAVE_TRUST;
    [SerializeField] private GameObject _pictureOfLockedRAINBOW;

    [SerializeField] private TextMeshProUGUI _textViewedAdsWATERMELON;
    [SerializeField] private TextMeshProUGUI _textViewedAdsSTARS;
    [SerializeField] private TextMeshProUGUI _textViewedAdsSHARK;
    [SerializeField] private TextMeshProUGUI _textViewedAdsSAVE_TRUST;
    [SerializeField] private TextMeshProUGUI _textViewedAdsRAINBOW;

    [SerializeField] private GameObject _pictureOfLockedSkinMINECRAFT;
    [SerializeField] private GameObject _pictureOfLockedSkinMARIO;
    [SerializeField] private GameObject _pictureOfLockedSkinKRENDEL;
    [SerializeField] private GameObject _pictureOfLockedSkinINSIDE;
    [SerializeField] private GameObject _pictureOfLockedSkinDONUT;
    [SerializeField] private GameObject _pictureOfLockedSkinCANDY;
    [SerializeField] private GameObject _pictureOfLockedSkinBEACH;
    [SerializeField] private GameObject _pictureOfLockedSkinBANANA;
    [SerializeField] private GameObject _pictureOfLockedSkinBADTRIP;
    [SerializeField] private GameObject _pictureOfLockedSkinWHEEL;

    [SerializeField] private GameObject _pictureOfUnlockedSkinWATERMELON;
    [SerializeField] private GameObject _pictureOfUnlockedSkinSTARS;
    [SerializeField] private GameObject _pictureOfUnlockedSkinSHARK;
    [SerializeField] private GameObject _pictureOfUnlockedSkinSAVE_TRUST;
    [SerializeField] private GameObject _pictureOfUnlockedSkinRAINBOW;
    [SerializeField] private GameObject _pictureOfUnlockedSkinMINECRAFT;
    [SerializeField] private GameObject _pictureOfUnlockedSkinMARIO;
    [SerializeField] private GameObject _pictureOfUnlockedSkinKRENDEL;
    [SerializeField] private GameObject _pictureOfUnlockedSkinINSIDE;
    [SerializeField] private GameObject _pictureOfUnlockedSkinDONUT;
    [SerializeField] private GameObject _pictureOfUnlockedSkinCANDY;
    [SerializeField] private GameObject _pictureOfUnlockedSkinBEACH;
    [SerializeField] private GameObject _pictureOfUnlockedSkinBANANA;
    [SerializeField] private GameObject _pictureOfUnlockedSkinBADTRIP;
    [SerializeField] private GameObject _pictureOfUnlockedSkinWHEEL;

    [SerializeField] private Mesh _default;
    [SerializeField] private Mesh _watermelon;
    [SerializeField] private Mesh _stars;
    [SerializeField] private Mesh _shark;
    [SerializeField] private Mesh _save_trust;
    [SerializeField] private Mesh _rainbow;
    [SerializeField] private Mesh _minecraft;
    [SerializeField] private Mesh _mario;
    [SerializeField] private Mesh _krendel;
    [SerializeField] private Mesh _inside;
    [SerializeField] private Mesh _donut;
    [SerializeField] private Mesh _candy;
    [SerializeField] private Mesh _beach;
    [SerializeField] private Mesh _banana;
    [SerializeField] private Mesh _badtrip;
    [SerializeField] private Mesh _wheel;

    [SerializeField] private Image _skinDEFAULT;
    [SerializeField] private Image _skinWATERMELON;
    [SerializeField] private Image _skinSTARS;
    [SerializeField] private Image _skinSHARK;
    [SerializeField] private Image _skinSAVE_TRUST;
    [SerializeField] private Image _skinRAINBOW;
    [SerializeField] private Image _skinMINECRAFT;
    [SerializeField] private Image _skinMARIO;
    [SerializeField] private Image _skinKRENDEL;
    [SerializeField] private Image _skinINSIDE;
    [SerializeField] private Image _skinDONUT;
    [SerializeField] private Image _skinCANDY;
    [SerializeField] private Image _skinBEACH;
    [SerializeField] private Image _skinBANANA;
    [SerializeField] private Image _skinBADTRIP;
    [SerializeField] private Image _skinWHEEL;

    [SerializeField] private Sprite _iconSelect;
    [SerializeField] private Sprite _iconUnSelect;

    [SerializeField] private MeshFilter meshPrefabARCADE;
    [SerializeField] private MeshFilter meshPrefabFirst1VS1;
    [SerializeField] private MeshFilter meshPrefabSecond1VS1;

    private void Awake()
    {
        YandexGame.RewardVideoEvent += CalculationViewedAdsForSkin1Rewarded;
        YandexGame.RewardVideoEvent += CalculationViewedAdsForSkin2Rewarded;
        YandexGame.RewardVideoEvent += CalculationViewedAdsForSkin3Rewarded;
        YandexGame.RewardVideoEvent += CalculationViewedAdsForSkin4Rewarded;
        YandexGame.RewardVideoEvent += CalculationViewedAdsForSkin5Rewarded;
        YandexGame.GetDataEvent += YGLoad;
    }

    private void YGLoad()
    {
        if (YandexGame.savesData.DEFAULTSkinSelected)
        {
            meshPrefabARCADE.sharedMesh = _default;
            meshPrefabFirst1VS1.sharedMesh = _default;
            meshPrefabSecond1VS1.sharedMesh = _default;
        }
        if (YandexGame.savesData.WATERMELONSkinSelected)
        {
            meshPrefabARCADE.sharedMesh = _watermelon;
            meshPrefabFirst1VS1.sharedMesh = _watermelon;
            meshPrefabSecond1VS1.sharedMesh = _watermelon;
        }
        if (YandexGame.savesData.STARSSkinSelected)
        {
            meshPrefabARCADE.sharedMesh = _stars;
            meshPrefabFirst1VS1.sharedMesh = _stars;
            meshPrefabSecond1VS1.sharedMesh = _stars;
        }
        if (YandexGame.savesData.SHARKSkinSelected)
        {
            meshPrefabARCADE.sharedMesh = _shark;
            meshPrefabFirst1VS1.sharedMesh = _shark;
            meshPrefabSecond1VS1.sharedMesh = _shark;
        }
        if (YandexGame.savesData.SAVETRUSTSkinSelected)
        {
            meshPrefabARCADE.sharedMesh = _save_trust;
            meshPrefabFirst1VS1.sharedMesh = _save_trust;
            meshPrefabSecond1VS1.sharedMesh = _save_trust;
        }
        if (YandexGame.savesData.RAINBOWSkinSelected)
        {
            meshPrefabARCADE.sharedMesh = _rainbow;
            meshPrefabFirst1VS1.sharedMesh = _rainbow;
            meshPrefabSecond1VS1.sharedMesh = _rainbow;
        }
        if (YandexGame.savesData.MINECRAFTSkinSelected)
        {
            meshPrefabARCADE.sharedMesh = _minecraft;
            meshPrefabFirst1VS1.sharedMesh = _minecraft;
            meshPrefabSecond1VS1.sharedMesh = _minecraft;
        }
        if (YandexGame.savesData.MARIOSkinSelected)
        {
            meshPrefabARCADE.sharedMesh = _mario;
            meshPrefabFirst1VS1.sharedMesh = _mario;
            meshPrefabSecond1VS1.sharedMesh = _mario;
        }
        if (YandexGame.savesData.KRENDELSkinSelected)
        {
            meshPrefabARCADE.sharedMesh = _krendel;
            meshPrefabFirst1VS1.sharedMesh = _krendel;
            meshPrefabSecond1VS1.sharedMesh = _krendel;
        }
        if (YandexGame.savesData.INSIDESkinSelected)
        {
            meshPrefabARCADE.sharedMesh = _inside;
            meshPrefabFirst1VS1.sharedMesh = _inside;
            meshPrefabSecond1VS1.sharedMesh = _inside;
        }
        if (YandexGame.savesData.DONUTSkinSelected)
        {
            meshPrefabARCADE.sharedMesh = _donut;
            meshPrefabFirst1VS1.sharedMesh = _donut;
            meshPrefabSecond1VS1.sharedMesh = _donut;
        }
        if (YandexGame.savesData.CANDYSkinSelected)
        {
            meshPrefabARCADE.sharedMesh = _candy;
            meshPrefabFirst1VS1.sharedMesh = _candy;
            meshPrefabSecond1VS1.sharedMesh = _candy;
        }
        if (YandexGame.savesData.BEACHSkinSelected)
        {
            meshPrefabARCADE.sharedMesh = _beach;
            meshPrefabFirst1VS1.sharedMesh = _beach;
            meshPrefabSecond1VS1.sharedMesh = _beach;
        }
        if (YandexGame.savesData.BANANASkinSelected)
        {
            meshPrefabARCADE.sharedMesh = _banana;
            meshPrefabFirst1VS1.sharedMesh = _banana;
            meshPrefabSecond1VS1.sharedMesh = _banana;
        }
        if (YandexGame.savesData.BADTRIPSkinSelected)
        {
            meshPrefabARCADE.sharedMesh = _badtrip;
            meshPrefabFirst1VS1.sharedMesh = _badtrip;
            meshPrefabSecond1VS1.sharedMesh = _badtrip;
        }
        if (YandexGame.savesData.WHEELSkinSelected)
        {
            meshPrefabARCADE.sharedMesh = _wheel;
            meshPrefabFirst1VS1.sharedMesh = _wheel;
            meshPrefabSecond1VS1.sharedMesh = _wheel;
        }
    }

    public void CheckingWhichSkinIsSelected()
    {
        if (meshPrefabARCADE.sharedMesh == _default)
            _skinDEFAULT.sprite = _iconSelect;
        else
            _skinDEFAULT.sprite = _iconUnSelect;

        if (meshPrefabARCADE.sharedMesh == _watermelon)
            _skinWATERMELON.sprite = _iconSelect;
        else
            _skinWATERMELON.sprite = _iconUnSelect;

        if (meshPrefabARCADE.sharedMesh == _stars)
            _skinSTARS.sprite = _iconSelect;
        else
            _skinSTARS.sprite = _iconUnSelect;

        if (meshPrefabARCADE.sharedMesh == _shark)
            _skinSHARK.sprite = _iconSelect;
        else
            _skinSHARK.sprite = _iconUnSelect;

        if (meshPrefabARCADE.sharedMesh == _save_trust)
            _skinSAVE_TRUST.sprite = _iconSelect;
        else
            _skinSAVE_TRUST.sprite = _iconUnSelect;

        if (meshPrefabARCADE.sharedMesh == _rainbow)
            _skinRAINBOW.sprite = _iconSelect;
        else
            _skinRAINBOW.sprite = _iconUnSelect;

        if (meshPrefabARCADE.sharedMesh == _minecraft)
            _skinMINECRAFT.sprite = _iconSelect;
        else
            _skinMINECRAFT.sprite = _iconUnSelect;

        if (meshPrefabARCADE.sharedMesh == _mario)
            _skinMARIO.sprite = _iconSelect;
        else
            _skinMARIO.sprite = _iconUnSelect;

        if (meshPrefabARCADE.sharedMesh == _krendel)
            _skinKRENDEL.sprite = _iconSelect;
        else
            _skinKRENDEL.sprite = _iconUnSelect;

        if (meshPrefabARCADE.sharedMesh == _inside)
            _skinINSIDE.sprite = _iconSelect;
        else
            _skinINSIDE.sprite = _iconUnSelect;

        if (meshPrefabARCADE.sharedMesh == _donut)
            _skinDONUT.sprite = _iconSelect;
        else
            _skinDONUT.sprite = _iconUnSelect;

        if (meshPrefabARCADE.sharedMesh == _candy)
            _skinCANDY.sprite = _iconSelect;
        else
            _skinCANDY.sprite = _iconUnSelect;

        if (meshPrefabARCADE.sharedMesh == _beach)
            _skinBEACH.sprite = _iconSelect;
        else
            _skinBEACH.sprite = _iconUnSelect;

        if (meshPrefabARCADE.sharedMesh == _banana)
            _skinBANANA.sprite = _iconSelect;
        else
            _skinBANANA.sprite = _iconUnSelect;

        if (meshPrefabARCADE.sharedMesh == _badtrip)
            _skinBADTRIP.sprite = _iconSelect;
        else
            _skinBADTRIP.sprite = _iconUnSelect;

        if (meshPrefabARCADE.sharedMesh == _wheel)
            _skinWHEEL.sprite = _iconSelect;
        else
            _skinWHEEL.sprite = _iconUnSelect;
    }

    //ГОТОВ
    public void CheckingOpenSkinOrNot()
    {
        if (YandexGame.savesData.SkinIsOpenWATERMELON)
        {
            _buttonSelectWATERMELON.SetActive(true);
            _buttonViewAdForSkinWATERMELON.SetActive(false);

            _pictureOfUnlockedSkinWATERMELON.SetActive(true);
            _pictureOfLockedWATERMELON.SetActive(false);
        }
        else
        {
            _buttonSelectWATERMELON.SetActive(false);
            _buttonViewAdForSkinWATERMELON.SetActive(true);

            _pictureOfUnlockedSkinWATERMELON.SetActive(false);
            _pictureOfLockedWATERMELON.SetActive(true);
        }
        if (YandexGame.savesData.SkinIsOpenSTARS)
        {
            _buttonSelectSTARS.SetActive(true);
            _buttonViewAdForSkinSTARS.SetActive(false);

            _pictureOfUnlockedSkinSTARS.SetActive(true);
            _pictureOfLockedSTARS.SetActive(false);
        }
        else
        {
            _buttonSelectSTARS.SetActive(false);
            _buttonViewAdForSkinSTARS.SetActive(true);

            _pictureOfUnlockedSkinSTARS.SetActive(false);
            _pictureOfLockedSTARS.SetActive(true);
        }
        if (YandexGame.savesData.SkinIsOpenSHARK)
        {
            _buttonSelectSHARK.SetActive(true);
            _buttonViewAdForSkinSHARK.SetActive(false);

            _pictureOfUnlockedSkinSHARK.SetActive(true);
            _pictureOfLockedSHARK.SetActive(false);
        }
        else
        {
            _buttonSelectSHARK.SetActive(false);
            _buttonViewAdForSkinSHARK.SetActive(true);

            _pictureOfUnlockedSkinSHARK.SetActive(false);
            _pictureOfLockedSHARK.SetActive(true);
        }
        if (YandexGame.savesData.SkinIsOpenSAVE_TRUST)
        {
            _buttonSelectSAVE_TRUST.SetActive(true);
            _buttonViewAdForSkinSAVE_TRUST.SetActive(false);

            _pictureOfUnlockedSkinSAVE_TRUST.SetActive(true);
            _pictureOfLockedSAVE_TRUST.SetActive(false);
        }
        else
        {
            _buttonSelectSAVE_TRUST.SetActive(false);
            _buttonViewAdForSkinSAVE_TRUST.SetActive(true);

            _pictureOfUnlockedSkinSAVE_TRUST.SetActive(false);
            _pictureOfLockedSAVE_TRUST.SetActive(true);
        }
        if (YandexGame.savesData.SkinIsOpenRAINBOW)
        {
            _buttonSelectRAINBOW.SetActive(true);
            _buttonViewAdForSkinRAINBOW.SetActive(false);

            _pictureOfUnlockedSkinRAINBOW.SetActive(true);
            _pictureOfLockedRAINBOW.SetActive(false);
        }
        else
        {
            _buttonSelectRAINBOW.SetActive(false);
            _buttonViewAdForSkinRAINBOW.SetActive(true);

            _pictureOfUnlockedSkinRAINBOW.SetActive(false);
            _pictureOfLockedRAINBOW.SetActive(true);
        }
        if (YandexGame.savesData.SkinIsOpenMINECRAFT)
        {
            _buttonSelectMINECRAFT.SetActive(true);

            _pictureOfUnlockedSkinMINECRAFT.SetActive(true);
            _pictureOfLockedSkinMINECRAFT.SetActive(false);
        }
        else
        {
            _buttonSelectMINECRAFT.SetActive(false);

            _pictureOfUnlockedSkinMINECRAFT.SetActive(false);
            _pictureOfLockedSkinMINECRAFT.SetActive(true);
        }
        if (YandexGame.savesData.SkinIsOpenMARIO)
        {
            _buttonSelectMARIO.SetActive(true);

            _pictureOfUnlockedSkinMARIO.SetActive(true);
            _pictureOfLockedSkinMARIO.SetActive(false);
        }
        else
        {
            _buttonSelectMARIO.SetActive(false);

            _pictureOfUnlockedSkinMARIO.SetActive(false);
            _pictureOfLockedSkinMARIO.SetActive(true);
        }
        if (YandexGame.savesData.SkinIsOpenKRENDEL)
        {
            _buttonSelectKRENDEL.SetActive(true);

            _pictureOfUnlockedSkinKRENDEL.SetActive(true);
            _pictureOfLockedSkinKRENDEL.SetActive(false);
        }
        else
        {
            _buttonSelectKRENDEL.SetActive(false);

            _pictureOfUnlockedSkinKRENDEL.SetActive(false);
            _pictureOfLockedSkinKRENDEL.SetActive(true);
        }
        if (YandexGame.savesData.SkinIsOpenINSIDE)
        {
            _buttonSelectINSIDE.SetActive(true);

            _pictureOfUnlockedSkinINSIDE.SetActive(true);
            _pictureOfLockedSkinINSIDE.SetActive(false);
        }
        else
        {
            _buttonSelectINSIDE.SetActive(false);

            _pictureOfUnlockedSkinINSIDE.SetActive(false);
            _pictureOfLockedSkinINSIDE.SetActive(true);
        }
        if (YandexGame.savesData.SkinIsOpenDONUT)
        {
            _buttonSelectDONUT.SetActive(true);

            _pictureOfUnlockedSkinDONUT.SetActive(true);
            _pictureOfLockedSkinDONUT.SetActive(false);
        }
        else
        {
            _buttonSelectDONUT.SetActive(false);

            _pictureOfUnlockedSkinDONUT.SetActive(false);
            _pictureOfLockedSkinDONUT.SetActive(true);
        }
        if (YandexGame.savesData.SkinIsOpenCANDY)
        {
            _buttonSelectCANDY.SetActive(true);

            _pictureOfUnlockedSkinCANDY.SetActive(true);
            _pictureOfLockedSkinCANDY.SetActive(false);
        }
        else
        {
            _buttonSelectCANDY.SetActive(false);

            _pictureOfUnlockedSkinCANDY.SetActive(false);
            _pictureOfLockedSkinCANDY.SetActive(true);
        }
        if (YandexGame.savesData.SkinIsOpenBEACH)
        {
            _buttonSelectBEACH.SetActive(true);

            _pictureOfUnlockedSkinBEACH.SetActive(true);
            _pictureOfLockedSkinBEACH.SetActive(false);
        }
        else
        {
            _buttonSelectBEACH.SetActive(false);

            _pictureOfUnlockedSkinBEACH.SetActive(false);
            _pictureOfLockedSkinBEACH.SetActive(true);
        }
        if (YandexGame.savesData.SkinIsOpenBANANA)
        {
            _buttonSelectBANANA.SetActive(true);

            _pictureOfUnlockedSkinBANANA.SetActive(true);
            _pictureOfLockedSkinBANANA.SetActive(false);
        }
        else
        {
            _buttonSelectBANANA.SetActive(false);

            _pictureOfUnlockedSkinBANANA.SetActive(false);
            _pictureOfLockedSkinBANANA.SetActive(true);
        }
        if (YandexGame.savesData.SkinIsOpenBADTRIP)
        {
            _buttonSelectBADTRIP.SetActive(true);

            _pictureOfUnlockedSkinBADTRIP.SetActive(true);
            _pictureOfLockedSkinBADTRIP.SetActive(false);
        }
        else
        {
            _buttonSelectBADTRIP.SetActive(false);

            _pictureOfUnlockedSkinBADTRIP.SetActive(false);
            _pictureOfLockedSkinBADTRIP.SetActive(true);
        }
        if (YandexGame.savesData.SkinIsOpenWHEEL)
        {
            _buttonSelectWHEEL.SetActive(true);

            _pictureOfUnlockedSkinWHEEL.SetActive(true);
            _pictureOfLockedSkinWHEEL.SetActive(false);
        }
        else
        {
            _buttonSelectWHEEL.SetActive(false);

            _pictureOfUnlockedSkinWHEEL.SetActive(false);
            _pictureOfLockedSkinWHEEL.SetActive(true);
        }
    }

    //ГОТОВ
    public void CheckingAdvertisementWasViewed()
    {
        if (YandexGame.savesData.NumberAdsViewedForWATERMELON <= 0)
        {
            YandexGame.savesData.SkinIsOpenWATERMELON = true;
        }
        else
        {
            YandexGame.savesData.SkinIsOpenWATERMELON = false;
        }

        if (YandexGame.savesData.NumberAdsViewedForSTARS <= 0)
        {
            YandexGame.savesData.SkinIsOpenSTARS = true;
        }
        else
        {
            YandexGame.savesData.SkinIsOpenSTARS = false;
        }

        if (YandexGame.savesData.NumberAdsViewedForSHARK <= 0)
        {
            YandexGame.savesData.SkinIsOpenSHARK = true;
        }
        else
        {
            YandexGame.savesData.SkinIsOpenSHARK = false;
        }

        if (YandexGame.savesData.NumberAdsViewedForSAVE_TRUST <= 0)
        {
            YandexGame.savesData.SkinIsOpenSAVE_TRUST = true;
        }
        else
        {
            YandexGame.savesData.SkinIsOpenSAVE_TRUST = false;
        }

        if (YandexGame.savesData.NumberAdsViewedForRAINBOW <= 0)
        {
            YandexGame.savesData.SkinIsOpenRAINBOW = true;
        }
        else
        {
            YandexGame.savesData.SkinIsOpenRAINBOW = false;
        }
    }

    //ГОТОВ
    public void CheckingScoresPlayer()
    {
        if (YandexGame.savesData.record >= 5)
        {
            YandexGame.savesData.SkinIsOpenMINECRAFT = true;
        }
        else
        {
            YandexGame.savesData.SkinIsOpenMINECRAFT = false;
        }

        if (YandexGame.savesData.record >= 10)
        {
            YandexGame.savesData.SkinIsOpenMARIO = true;
        }
        else
        {
            YandexGame.savesData.SkinIsOpenMARIO = false;
        }

        if (YandexGame.savesData.record >= 15)
        {
            YandexGame.savesData.SkinIsOpenKRENDEL = true;
        }
        else
        {
            YandexGame.savesData.SkinIsOpenKRENDEL = false;
        }

        if (YandexGame.savesData.record >= 20)
        {
            YandexGame.savesData.SkinIsOpenINSIDE = true;
        }
        else
        {
            YandexGame.savesData.SkinIsOpenINSIDE = false;
        }

        if (YandexGame.savesData.record >= 25)
        {
            YandexGame.savesData.SkinIsOpenDONUT = true;
        }
        else
        {
            YandexGame.savesData.SkinIsOpenDONUT = false;
        }

        if (YandexGame.savesData.record >= 30)
        {
            YandexGame.savesData.SkinIsOpenCANDY = true;
        }
        else
        {
            YandexGame.savesData.SkinIsOpenCANDY = false;
        }

        if (YandexGame.savesData.record >= 35)
        {
            YandexGame.savesData.SkinIsOpenBEACH = true;
        }
        else
        {
            YandexGame.savesData.SkinIsOpenBEACH = false;
        }

        if (YandexGame.savesData.record >= 40)
        {
            YandexGame.savesData.SkinIsOpenBANANA = true;
        }
        else
        {
            YandexGame.savesData.SkinIsOpenBANANA = false;
        }

        if (YandexGame.savesData.record >= 45)
        {
            YandexGame.savesData.SkinIsOpenBADTRIP = true;
        }
        else
        {
            YandexGame.savesData.SkinIsOpenBADTRIP = false;
        }

        if (YandexGame.savesData.record >= 50)
        {
            YandexGame.savesData.SkinIsOpenWHEEL = true;
        }
        else
        {
            YandexGame.savesData.SkinIsOpenWHEEL = false;
        }
        YandexGame.SaveProgress();
    }
    
    //ГОТОВ
    public void UpdateBestPlayerScores()
    {
        if (YandexGame.savesData.record < ScoresManagerARCADE.BestScoresPlayer)
        {
            YandexGame.savesData.record = ScoresManagerARCADE.BestScoresPlayer;
        }
        YandexGame.SaveProgress();
    }
    
    //ГОТОВ
    public void SetSkinToPrefabForAdvertising(Mesh mesh)
    {
        meshPrefabARCADE.sharedMesh = mesh;
        meshPrefabFirst1VS1.sharedMesh = mesh;
        meshPrefabSecond1VS1.sharedMesh = mesh;

        if (meshPrefabARCADE.sharedMesh == _default)
        {
            YandexGame.savesData.DEFAULTSkinSelected = true;
            Debug.Log(YandexGame.savesData.DEFAULTSkinSelected);
        }
        else
            YandexGame.savesData.DEFAULTSkinSelected = false;

        if (meshPrefabARCADE.sharedMesh == _watermelon)
            YandexGame.savesData.WATERMELONSkinSelected = true;
        else
            YandexGame.savesData.WATERMELONSkinSelected = false;

        if (meshPrefabARCADE.sharedMesh == _stars)
            YandexGame.savesData.STARSSkinSelected = true;
        else
            YandexGame.savesData.STARSSkinSelected = false;

        if (meshPrefabARCADE.sharedMesh == _shark)
            YandexGame.savesData.SHARKSkinSelected = true;
        else
            YandexGame.savesData.SHARKSkinSelected = false;

        if (meshPrefabARCADE.sharedMesh == _save_trust)
            YandexGame.savesData.SAVETRUSTSkinSelected = true;
        else
            YandexGame.savesData.SAVETRUSTSkinSelected = false;

        if (meshPrefabARCADE.sharedMesh == _rainbow)
            YandexGame.savesData.RAINBOWSkinSelected = true;
        else
            YandexGame.savesData.RAINBOWSkinSelected = false;

        if (meshPrefabARCADE.sharedMesh == _minecraft)
            YandexGame.savesData.MINECRAFTSkinSelected = true;
        else
            YandexGame.savesData.MINECRAFTSkinSelected = false;

        if (meshPrefabARCADE.sharedMesh == _mario)
            YandexGame.savesData.MARIOSkinSelected = true;
        else
            YandexGame.savesData.MARIOSkinSelected = false;

        if (meshPrefabARCADE.sharedMesh == _krendel)
            YandexGame.savesData.KRENDELSkinSelected = true;
        else
            YandexGame.savesData.KRENDELSkinSelected = false;

        if (meshPrefabARCADE.sharedMesh == _inside)
            YandexGame.savesData.INSIDESkinSelected = true;
        else
            YandexGame.savesData.INSIDESkinSelected = false;

        if (meshPrefabARCADE.sharedMesh == _donut)
            YandexGame.savesData.DONUTSkinSelected = true;
        else
            YandexGame.savesData.DONUTSkinSelected = false;

        if (meshPrefabARCADE.sharedMesh == _candy)
            YandexGame.savesData.CANDYSkinSelected = true;
        else
            YandexGame.savesData.CANDYSkinSelected = false;

        if (meshPrefabARCADE.sharedMesh == _beach)
            YandexGame.savesData.BEACHSkinSelected = true;
        else
            YandexGame.savesData.BEACHSkinSelected = false;

        if (meshPrefabARCADE.sharedMesh == _banana)
            YandexGame.savesData.BANANASkinSelected = true;
        else
            YandexGame.savesData.BANANASkinSelected = false;

        if (meshPrefabARCADE.sharedMesh == _badtrip)
            YandexGame.savesData.BADTRIPSkinSelected = true;
        else
            YandexGame.savesData.BADTRIPSkinSelected = false;

        if (meshPrefabARCADE.sharedMesh == _wheel)
            YandexGame.savesData.WHEELSkinSelected = true;
        else
            YandexGame.savesData.WHEELSkinSelected = false;
        
        CheckingScoresPlayer();
        UpdateBestPlayerScores();
        CheckingWhichSkinIsSelected();
        CheckingOpenSkinOrNot();
        CheckingAdvertisementWasViewed();
        UpdateText();
        
        YandexGame.SaveProgress();
    }
    
    //ГОТОВ
    private void CalculationViewedAdsForSkin1Rewarded(int id)
    {
        CheckingScoresPlayer();
        UpdateBestPlayerScores();
        CheckingWhichSkinIsSelected();
        CheckingOpenSkinOrNot();
        CheckingAdvertisementWasViewed();
        UpdateText();
        if (id == 2)
        {
            if (YandexGame.savesData.NumberAdsViewedForWATERMELON > 0)
            {
                YandexGame.savesData.NumberAdsViewedForWATERMELON -= 1;
            }
            YandexGame.SaveProgress();
        }
    }
    public void CalculationViewedAdsForSkin1()
    {
        YandexGame.RewVideoShow(2);
    }

    private void CalculationViewedAdsForSkin2Rewarded(int id)
    {
        CheckingScoresPlayer();
        UpdateBestPlayerScores();
        CheckingWhichSkinIsSelected();
        CheckingOpenSkinOrNot();
        CheckingAdvertisementWasViewed();
        UpdateText();
        if (id == 3)
        {
            if (YandexGame.savesData.NumberAdsViewedForSTARS > 0)
            {
                YandexGame.savesData.NumberAdsViewedForSTARS -= 1;
            }
            YandexGame.SaveProgress();
        }
    }
    
    public void CalculationViewedAdsForSkin2()
    {
        YandexGame.RewVideoShow(3);
    }

    private void CalculationViewedAdsForSkin3Rewarded(int id)
    {
        CheckingScoresPlayer();
        UpdateBestPlayerScores();
        CheckingWhichSkinIsSelected();
        CheckingOpenSkinOrNot();
        CheckingAdvertisementWasViewed();
        UpdateText();
        if (id == 4)
        {
            if (YandexGame.savesData.NumberAdsViewedForSHARK > 0)
            {
                YandexGame.savesData.NumberAdsViewedForSHARK -= 1;
            }
            YandexGame.SaveProgress();
        }
    }
    
    public void CalculationViewedAdsForSkin3()
    {
        YandexGame.RewVideoShow(4);
    }

    private void CalculationViewedAdsForSkin4Rewarded(int id)
    {
        CheckingScoresPlayer();
        UpdateBestPlayerScores();
        CheckingWhichSkinIsSelected();
        CheckingOpenSkinOrNot();
        CheckingAdvertisementWasViewed();
        UpdateText();
        if (id == 5)
        {
            if (YandexGame.savesData.NumberAdsViewedForSAVE_TRUST > 0)
            {
                YandexGame.savesData.NumberAdsViewedForSAVE_TRUST -= 1;
            }
            YandexGame.SaveProgress();
        }
    }
    
    public void CalculationViewedAdsForSkin4()
    {
        YandexGame.RewVideoShow(5);
    }

    private void CalculationViewedAdsForSkin5Rewarded(int id)
    {
        CheckingScoresPlayer();
        UpdateBestPlayerScores();
        CheckingWhichSkinIsSelected();
        CheckingOpenSkinOrNot();
        CheckingAdvertisementWasViewed();
        UpdateText();
        if (id == 6)
        {
            if (YandexGame.savesData.NumberAdsViewedForRAINBOW > 0)
            {
                YandexGame.savesData.NumberAdsViewedForRAINBOW -= 1;
            }
            YandexGame.SaveProgress();
        }
    }
    
    public void CalculationViewedAdsForSkin5()
    {
        YandexGame.RewVideoShow(6);
    }

    //ГОТОВ
    public void UpdateText()
    {
        _textViewedAdsWATERMELON.text = $"{YandexGame.savesData.NumberAdsViewedForWATERMELON.ToString()}/1";
        _textViewedAdsSTARS.text = $"{YandexGame.savesData.NumberAdsViewedForSTARS.ToString()}/2";
        _textViewedAdsSHARK.text = $"{YandexGame.savesData.NumberAdsViewedForSHARK.ToString()}/3";
        _textViewedAdsSAVE_TRUST.text = $"{YandexGame.savesData.NumberAdsViewedForSAVE_TRUST.ToString()}/4";
        _textViewedAdsRAINBOW.text = $"{YandexGame.savesData.NumberAdsViewedForRAINBOW.ToString()}/5";
    }

    private void OnDestroy()
    {
        YandexGame.RewardVideoEvent -= CalculationViewedAdsForSkin1Rewarded;
        YandexGame.RewardVideoEvent -= CalculationViewedAdsForSkin2Rewarded;
        YandexGame.RewardVideoEvent -= CalculationViewedAdsForSkin3Rewarded;
        YandexGame.RewardVideoEvent -= CalculationViewedAdsForSkin4Rewarded;
        YandexGame.RewardVideoEvent -= CalculationViewedAdsForSkin5Rewarded;
        YandexGame.GetDataEvent -= YGLoad;
    }
}
