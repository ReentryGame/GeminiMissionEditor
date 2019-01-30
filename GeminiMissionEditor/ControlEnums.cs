using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeminiV2
{
    public enum PinID
    {
        NULL, FUSECoaxCntl,
        SquibBoostInsert, SquibRetroPWR, SquibRetroJett, SquibLanding, SquibRetro1, SquibRetro2, SquibRetro3, SquibRetro4,
        MainBattery1, MainBattery2, MainBattery3, MainBattery4, SquibBattery1, SquibBattery2, SquibBattery3,
        LightsBrightness, LightsTest,
        FuelCell1PurgeO2, FuelCell1PWR, FuelCell2PurgeO2, FuelCell2PWR, FuelCell1A, FuelCell1B, FuelCell1C, FuelCell2A, FuelCell2B, FuelCell2C,
        BusTie1, BusTie2,
        ControllerPWROAMS, ControllerPWRRCSA, ControllerPWRRCSB, ACPowerSource,
        MDIUPower, AuxTapePWR, ComputerPower, HorizonScannerSelect, HorizonScannerHeater,
        SuitFan, FUSESuitFan1, FUSESuitFan2, O2HighRate, CoolPriPumpA, CoolPriPumpB, CoolSecPumpA, CoolSecPumpB,
        RadiatorFlow, EvaporatorHeat, EvaporatprMaxFlow, EventTimerStart, EventTimerDirection, ElapsedTimeStarter,
        H2VacTank, CryoHeaterO2, CryoHeaterH2, OAMReg, PropMotoOAMS, PropMotRCSA, PropMotRCSB, FUSEDCDCConv,
        LightsCabin, LightsFDI, CTRLights,
        FUSEAudioAndUHFTR1, FUSEAudioAndUHFTR2, FUSEUHFRelay, FUSEToneVox, FUSETV, FUSEHFTR, FUSEAntCntl, FUSEWhipAntHF, FUSEWhipAntUHF, FUSEWhipAntDiplex,
        FUSEElectTimer, FUSEEventTimer, FUSEBoostCutoff1, FUSEBoostCutoff2, FUSERetroAuto, FUSERetroMan, FUSETr256, FUSEECSIndLts, FUSEIndLtTest, FUSESeqLightsPWR, FUSESeqLightsCntl, FUSEParaCntl,
        FUSEAttIncCntlRetro, FUSEAttIndCntlLdg, FUSEBoostInsertCntl1, FUSEBoostInsertCntl2, FUSERetroSeqCntl1, FUSERetroSeqCntl2, FUSELandingSecCntl1, FUSELandingSecCntl2, FDI1Controller, GuidanceSwitch,
        FUSEBeaconsC, FUSEBeaconsResc, FUSEBeaconsAcq, FUSEAUXRecp, FUSECryQty, FUSECoolPumpSecB, FUSECoolPumpSecA, FUSECoolPumpPriB, FUSECoolPumpPriA,
        FUSETMAC, FUSEXmtrsDT, FUSEXmtrsRT, FUSEXmtrsStbyPWR, FUSEXmtrsStbyCntl, FUSEPriO2Htrs, FUSEH2OHtrs, FUSEClkLt,
        FUSEOAMSHtrs, FUSEEvapThr, FUSECoolVlvsSec, FUSECoolVlvsPri, FUSEO2RateCntl,
        ACMEBiasPWR, RollJetsSelector, FUSEACMECntl1, FUSEACMECntl2, FUSEOAMSCntlProp, FUSEOAMSCntlReg1, FUSEOAMSCntlReg2, FUSERCSSquibs1, FUSERCSSquibs2,
        OAMSResvSwitch, FUSEManThru9, FUSEManThru10, FUSEManThru11, FUSEManThru12, FUSEManThru13, FUSEManThru14, FUSEManThru15, FUSEManThru16,
        AttitiudeDriversSwitch, FUSEAttThrust1, FUSEAttThrust2, FUSEAttThrust3, FUSEAttThrust4, FUSEAttThrust5, FUSEAttThrust6, FUSEAttThrust7, FUSEAttThrust8,
        ACMELogicYawSelector, ACMELogicPitchSelector, ACMELogicRollSelector, FUSERCSAPitch, FUSERCSAYawL, FUSERCSAYawR, FUSERCSBPitch, FUSERCSBYawL, FUSERCSBYawR,
        FUSEAUXTape, FUSESEOInst, FUSECalib, FUSEBioMedInst, FUSEDCSPWR, FUSEFCO2H2Reg, FUSEFCO2H2HTR, AGENAPWR, AGENASquib1, AGENASquib2, AGENACntl,
        FUSERadarPWR, FUSEACMEInv, FUSERCSHTRSA, FUSERCSHTRSB, FUSETapeRecorderPWR, FUSETapeRecorderCNTL, FUSEFuelCellCntl1, FUSEFuelCellCntl2, FUSEFCdP, AGENAEncoder, AGENAExtrLts,
        FDI2Switch, FUSEBioMedRcdr1, FUSEBioMedRcdr2, FUSERCSHtr, AGENAIndexEvaBars, AGENAEngineARM, AGENABusArm,
        RadarLockOn, TDAUndock, RateGyroPitch, RateGyroYaw, RateGyroRoll, UHFRadioSelect, HFAntennaSelect, RadioSilence, RadioKeying, RadioRecord,
        BeaconResc, BeaconSBand, BeaconCBand, TMCalib, TMSby, TMTM, RadioTapePlayback, RadioAntSel, HfAntControl, TDARigid
    };
    public enum PinPosition { NULL, Left, Middle, Right, Up, Down };

    public enum KnobID
    {
        NULL, VoltMeterSelector, dPMeterSelector, CryoSelector, ACMEMode, IGSPlatform, ComputerMode, FDI1Mode, FDI1Data, FDI2Mode, FDI2Data,
        TapeControl, Repressurize, CabinRecirc, Snorkel, CabinVent, WaterSeal, O2HighRateRecock, EventTimerTimeKnob, MissionElapsedTimeKnob,
        PropGaugeSelector, FDI1SetKnob, FDI2SetKnob, DCDCConvATM, SecondaryO2ShutoffL, SecondaryO2ShutoffR, EncoderBit1, EncoderBit2, EncoderBit3,
        RadioModeA, RadioModeB, DimLightControl
    };

    public enum TriggerButtonID
    {
        NULL, JettFairing, SepSpcft, IndRetroAtt, RCS, SepOAMSLine, SepElec, SepAdapt, ArmAutoRetro, JettRetro, ManFireRetro,
        Keyboard1, Keyboard2, Keyboard3, Keyboard4, Keyboard5, Keyboard6, Keyboard7, Keyboard8, Keyboard9, KeyboardZero,
        KeyboardReadOut, KeyboardClear, KeyboardEnter, ComputerReset, ComputerStart, PlatformReset, EmerRelease, DCSReceive, IMUReset,
        HiAltDrogue, Para, LdgAtt, ParaJett
    };
    public enum GaugeID
    {
        NULL, FC1AAmps, FC1BAmps, FC1CAmps, FC2AAmps, FC2BAmps, FC2CAmps, DCVoltmeter, FuelOxid1A, FuelOxid1B, FuelOxid2A, FuelOxid2B,
        dPMonitor, CryoQuantity, CryoPSIA, TempCabin, TempSuit, PressCabin, PressSuit, SecO2Pri, SecO2Sec, AltimeterShort, AltimeterLong,
        DecentRate, LongGForces, AccutronClockHour, AccutronClockMinutes, MechanicalClockHour, MechanicalClockMinutes,
        PropGaugeQty, PropGaugePSI, PropGaugeTemp, RadarRange, RadarRangeRate
    };

    public class GeminiOnBoardComputer
    {
        public enum ComputerMode { PreLaunch, Ascent, CatchUp, Rendesvouze, TDPre, ReEntry };
    }
}