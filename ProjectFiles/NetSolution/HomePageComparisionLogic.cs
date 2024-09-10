#region Using directives
using System;
using UAManagedCore;
using FTOptix.NetLogic;
using Store = FTOptix.Store;
#endregion

public class HomePageComparisionLogic : BaseNetLogic
{
    private IUAVariable dateVariable;
    private IUAVariable date1Variable;
    private IUAVariable utilitypowerVariable;
    private IUAVariable jacestampingVariable;
    private IUAVariable targetstampingVariable;
    private IUAVariable yearloweststampingVariable;
    private IUAVariable monthloweststampingVariable;
    private IUAVariable averagestampingVariable;
    private IUAVariable consumptionstampingVariable;
    private IUAVariable jacetcfVariable;
    private IUAVariable targettcfVariable;
    private IUAVariable yearlowesttcfVariable;
    private IUAVariable monthlowesttcfVariable;
    private IUAVariable averagetcfVariable;
    private IUAVariable consumptiontcfVariable;
    private IUAVariable tcfpowerVariable;
    private IUAVariable jacebodyshopVariable;
    private IUAVariable targetbodyshopVariable;
    private IUAVariable yearlowestbodyshopVariable;
    private IUAVariable monthlowestbodyshopVariable;
    private IUAVariable averagebodyshopVariable;
    private IUAVariable consumptionbodyshopVariable;
    private IUAVariable consumptionpaintshopVariable;
    private IUAVariable paintshoppowerVariable;
    private IUAVariable jacesppVariable;
    private IUAVariable targetsppVariable;
    private IUAVariable yearlowestsppVariable;
    private IUAVariable monthlowestsppVariable;
    private IUAVariable averagesppVariable;
    private IUAVariable consumptionsppVariable;
    private IUAVariable spppowerVariable;
    private IUAVariable jacespareVariable;
    private IUAVariable targetspareVariable;
    private IUAVariable yearlowestspareVariable;
    private IUAVariable monthlowestspareVariable;
    private IUAVariable averagespareVariable;
    private IUAVariable consumptionspareVariable;
    private IUAVariable jace33kvVariable;
    private IUAVariable target33kvVariable;
    private IUAVariable yearlowest33kvVariable;
    private IUAVariable monthlowest33kvVariable;
    private IUAVariable average33kvVariable;
    private IUAVariable consumption33kvVariable;
    private IUAVariable kv33powerVariable;
    private IUAVariable bodyshoppercentageVariable;
    private IUAVariable engineshoppercentageVariable;
    private IUAVariable paintshoppercentageVariable;
    private IUAVariable sparepercentageVariable;
    private IUAVariable spppercentageVariable;
    private IUAVariable utilitypercentageVariable;
    private IUAVariable stampingpercentageVariable;
    private IUAVariable tcfpercentageVariable;
    private IUAVariable jaceengineshopVariable;
    private IUAVariable targetengineshopVariable;
    private IUAVariable yearlowestengineshopVariable;
    private IUAVariable monthlowestengineshopVariable;
    private IUAVariable averageengineshopVariable;
    private IUAVariable consumptionengineshopVariable;
    private IUAVariable jacepaintshopVariable;
    private IUAVariable targetpaintshopVariable;
    private IUAVariable yearlowestpaintshopVariable;
    private IUAVariable monthlowestpaintshopVariable;
    private IUAVariable averagepaintshopVariable;
    private IUAVariable jaceVariable;
    private IUAVariable meterVariable;
    private IUAVariable targetVariable;
    private IUAVariable yearlowestVariable;
    private IUAVariable monthlowestVariable;
    private IUAVariable averageVariable;
    private IUAVariable consumptionVariable;
    private IUAVariable gbuttonVariable;
    private PeriodicTask periodicTask;
    private IUAVariable monthyearVariable;
    private IUAVariable productioncountVariable;
    private IUAVariable yearVariable;
    private IUAVariable monthconsumptionVariable;
    private IUAVariable bodyshoppowerVariable;
    private IUAVariable adminpowerVariable;
    private IUAVariable stampingpowerVariable;






    public override void Start()
    {
        // Insert code to be executed when the user-defined logic is started
        var owner = (HomePageComparisionPanel)LogicObject.Owner;
        productioncountVariable = owner.ProductionCountVariable;
        monthyearVariable = owner.MonthyearVariable;
        yearVariable = owner.YearVariable;
        monthconsumptionVariable = owner.MonthConsumptionVariable;
        //Utility
        jaceVariable = owner.JaceVariable;
        meterVariable = owner.MeterVariable;
        targetVariable = owner.TargetVariable;
        yearlowestVariable = owner.YearlowestVariable;
        monthlowestVariable = owner.MonthlowestVariable;
        averageVariable = owner.AverageVariable;
        consumptionVariable = owner.ConsumptionVariable;
        gbuttonVariable = owner.GBUTTONVariable;
        dateVariable = owner.DateVariable;
        date1Variable = owner.Date1Variable;
        utilitypowerVariable = owner.UtilityPowerVariable;

        // Stamping
        jacestampingVariable = owner.JaceStampingVariable;
        targetstampingVariable = owner.TargetStampingVariable;
        yearloweststampingVariable = owner.YearlowestStampingVariable;
        monthloweststampingVariable = owner.MonthlowestStampingVariable;
        averagestampingVariable = owner.AverageStampingVariable;
        consumptionstampingVariable = owner.ConsumptionStampingVariable;
        stampingpowerVariable = owner.StampingPowerVariable;
        // TCF
        jacetcfVariable = owner.JaceTcfVariable;
        targettcfVariable = owner.TargetTcfVariable;
        yearlowesttcfVariable = owner.YearlowestTcfVariable;
        monthlowesttcfVariable = owner.MonthlowestTcfVariable;
        averagetcfVariable = owner.AverageTcfVariable;
        consumptiontcfVariable = owner.ConsumptionTcfVariable;
        tcfpowerVariable = owner.TcfPowerVariable;

        // Bodyshop
        jacebodyshopVariable = owner.JaceBodyshopVariable;
        targetbodyshopVariable = owner.TargetBodyshopVariable;
        yearlowestbodyshopVariable = owner.YearlowestBodyshopVariable;
        monthlowestbodyshopVariable = owner.MonthlowestBodyshopVariable;
        averagebodyshopVariable = owner.AverageBodyshopVariable;
        consumptionbodyshopVariable = owner.ConsumptionBodyshopVariable;
        bodyshoppowerVariable = owner.BodyshopPowerVariable;

        // Engineshop
        jaceengineshopVariable = owner.JaceEngineshopVariable;
        targetengineshopVariable = owner.TargetEngineshopVariable;
        yearlowestengineshopVariable = owner.YearlowestEngineshopVariable;
        monthlowestengineshopVariable = owner.MonthlowestEngineshopVariable;
        averageengineshopVariable = owner.AverageEngineshopVariable;
        consumptionengineshopVariable = owner.ConsumptionEngineshopVariable;
        adminpowerVariable = owner.AdminPowerVariable;

        // Paintshop
        jacepaintshopVariable = owner.JacePaintshopVariable;
        targetpaintshopVariable = owner.TargetPaintshopVariable;
        yearlowestpaintshopVariable = owner.YearlowestPaintshopVariable;
        monthlowestpaintshopVariable = owner.MonthlowestPaintshopVariable;
        averagepaintshopVariable = owner.AveragePaintshopVariable;
        consumptionpaintshopVariable = owner.ConsumptionPaintshopVariable;
        paintshoppowerVariable = owner.PaintshopPowerVariable;

        // Spp
        jacesppVariable = owner.JaceSppVariable;
        targetsppVariable = owner.TargetSppVariable;
        yearlowestsppVariable = owner.YearlowestSppVariable;
        monthlowestsppVariable = owner.MonthlowestSppVariable;
        averagesppVariable = owner.AverageSppVariable;
        consumptionsppVariable = owner.ConsumptionSppVariable;
        spppowerVariable = owner.SppPowerVariable;

        // Spare
        jacespareVariable = owner.JaceSpareVariable;
        targetspareVariable = owner.TargetSpareVariable;
        yearlowestspareVariable = owner.YearlowestSpareVariable;
        monthlowestspareVariable = owner.MonthlowestSpareVariable;
        averagespareVariable = owner.AverageSpareVariable;
        consumptionspareVariable = owner.ConsumptionSpareVariable;


        // 33KV
        jace33kvVariable = owner.Jace33KVVariable;
        target33kvVariable = owner.Target33KVVariable;
        yearlowest33kvVariable = owner.Yearlowest33KVVariable;
        monthlowest33kvVariable = owner.Monthlowest33KVVariable;
        average33kvVariable = owner.Average33KVVariable;
        consumption33kvVariable = owner.Consumption33KVVariable;
        kv33powerVariable = owner.KV33PowerVariable;

        ////Calculation Related/////////
        utilitypercentageVariable = owner.UtilitypercentageVariable;
        stampingpercentageVariable = owner.StampingpercentageVariable;
        tcfpercentageVariable = owner.TcfpercentageVariable;
        bodyshoppercentageVariable = owner.BodyshoppercentageVariable;
        engineshoppercentageVariable = owner.EngineshoppercentageVariable;
        paintshoppercentageVariable = owner.PaintshoppercentageVariable;
        sparepercentageVariable = owner.SparepercentageVariable;
        spppercentageVariable = owner.SpppercentageVariable;


        periodicTask = new PeriodicTask(IncrementDecrementTask, 3000, LogicObject);
        periodicTask.Start();


    }
    ////////////////////////////////*********************************************///////////////////////////////////////////////////////////////////////////
    public override void Stop()
    {
        // Insert code to be executed when the user-defined logic is stopped
        periodicTask.Dispose();
        periodicTask = null;
    }

    public void IncrementDecrementTask()
    {
        DateTime date = dateVariable.Value;
        String date1 = date1Variable.Value;
        String monthyear = monthyearVariable.Value;
        String year = yearVariable.Value;

        //For Utility
        int jace = jaceVariable.Value;
        int meter = meterVariable.Value;
        int target = targetVariable.Value;
        int yearlowest = yearlowestVariable.Value;
        int monthlowest = monthlowestVariable.Value;
        int average = averageVariable.Value;
        int consumption = consumptionVariable.Value;
        bool gbutton = gbuttonVariable.Value;
        float utilitypower = utilitypowerVariable.Value;

        //For Stamping
        int jacestamping = jacestampingVariable.Value;
        int targetstamping = targetstampingVariable.Value;
        int yearloweststamping = yearloweststampingVariable.Value;
        int monthloweststamping = monthloweststampingVariable.Value;
        int averagestamping = averagestampingVariable.Value;
        float consumptionstamping = consumptionstampingVariable.Value;
        float stampingpower = stampingpowerVariable.Value;

        // For TCF
        int jacetcf = jacetcfVariable.Value;
        int targettcf = targettcfVariable.Value;
        int yearlowesttcf = yearlowesttcfVariable.Value;
        int monthlowesttcf = monthlowesttcfVariable.Value;
        int averagetcf = averagetcfVariable.Value;
        float consumptiontcf = consumptiontcfVariable.Value;
        float tcfpower = tcfpowerVariable.Value;

        // For BodyShop
        int jacebodyshop = jacebodyshopVariable.Value;
        int targetbodyshop = targetbodyshopVariable.Value;
        int yearlowestbodyshop = yearlowestbodyshopVariable.Value;
        int monthlowestbodyshop = monthlowestbodyshopVariable.Value;
        int averagebodyshop = averagebodyshopVariable.Value;
        float consumptionbodyshop = consumptionbodyshopVariable.Value;
        float bodyshoppower = bodyshoppowerVariable.Value;

        // For EngineShop
        int jaceengineshop = jaceengineshopVariable.Value;
        int targetengineshop = targetengineshopVariable.Value;
        int yearlowestengineshop = yearlowestengineshopVariable.Value;
        int monthlowestengineshop = monthlowestengineshopVariable.Value;
        int averageengineshop = averageengineshopVariable.Value;
        float consumptionengineshop = consumptionengineshopVariable.Value;
        float adminpower = adminpowerVariable.Value;

        // For Paintshop
        int jacepaintshop = jacepaintshopVariable.Value;
        int targetpaintshop = targetpaintshopVariable.Value;
        int yearlowestpaintshop = monthlowestpaintshopVariable.Value;
        int monthlowestpaintshop = monthlowestpaintshopVariable.Value;
        int averagepaintshop = averagepaintshopVariable.Value;
        float consumptionpaintshop = consumptionpaintshopVariable.Value;
        float paintshoppower = paintshoppowerVariable.Value;


        // For Spp
        int jacespp = jacesppVariable.Value;
        int targetspp = targetsppVariable.Value;
        int yearlowestspp = yearlowestsppVariable.Value;
        int monthlowestspp = monthlowestsppVariable.Value;
        int averagespp = averagesppVariable.Value;
        float consumptionspp = consumptionsppVariable.Value;
        float spppower = spppowerVariable.Value;


        // For Spare
        int jacespare = jacespareVariable.Value;
        int targetspare = targetspareVariable.Value;
        int yearlowestspare = yearlowestspareVariable.Value;
        int monthlowestspare = monthlowestspareVariable.Value;
        int averagespare = averagespareVariable.Value;
        float consumptionspare = consumptionspareVariable.Value;

        // For 33Kv
        int jace33kv = jace33kvVariable.Value;
        int target33kv = target33kvVariable.Value;
        int yearlowest33kv = yearlowest33kvVariable.Value;
        int monthlowest33kv = monthlowest33kvVariable.Value;
        int average33kv = average33kvVariable.Value;
        float consumption33kv = consumption33kvVariable.Value;
        float monthconsumption = monthconsumptionVariable.Value;
        float kv33power  = kv33powerVariable.Value;

        //////////////Production Count/////////////////
        int productioncount = productioncountVariable.Value;

        // For Calculation
        float utilitypercentage = utilitypercentageVariable.Value;
        float stampingpercentage = stampingpercentageVariable.Value;
        float tcfpercentage = tcfpercentageVariable.Value;
        float bodyshoppercentage = bodyshoppercentageVariable.Value;
        float engineshoppercentage = engineshoppercentageVariable.Value;
        float paintshoppercentage = paintshoppercentageVariable.Value;
        float sparepercentage = sparepercentageVariable.Value;
        float spppercentage = spppercentageVariable.Value;

        ////////////////////////////////*********************************************///////////////////////////////////////////////////////////////////////////

        var project = FTOptix.HMIProject.Project.Current;
        // For Utility
        var myStore = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");//Target
       


        ////////////////////////////////*********************************************///////////////////////////////////////////////////////////////////////////
        // For Utility
        object[,] resultSet1;
        string[] header1;
        object[,] resultSet2;
        string[] header2;
        object[,] resultSet3;
        string[] header3;
        object[,] resultSet4;
        string[] header4;
        object[,] resultSet5;
        string[] header5;

        // For Stamping
        object[,] resultSet6;
        string[] header6;
        object[,] resultSet7;
        string[] header7;
        object[,] resultSet8;
        string[] header8;
        object[,] resultSet9;
        string[] header9;
        object[,] resultSet10;
        string[] header10;

        // For TCF
        object[,] resultSet11;
        string[] header11;
        object[,] resultSet12;
        string[] header12;
        object[,] resultSet13;
        string[] header13;
        object[,] resultSet14;
        string[] header14;
        object[,] resultSet15;
        string[] header15;


        // For Bodyshop
        object[,] resultSet16;
        string[] header16;
        object[,] resultSet17;
        string[] header17;
        object[,] resultSet18;
        string[] header18;
        object[,] resultSet19;
        string[] header19;
        object[,] resultSet20;
        string[] header20;

        // For Engineshop
        object[,] resultSet21;
        string[] header21;
        object[,] resultSet22;
        string[] header22;
        object[,] resultSet23;
        string[] header23;
        object[,] resultSet24;
        string[] header24;
        object[,] resultSet25;
        string[] header25;

        // For Paintshop
        object[,] resultSet26;
        string[] header26;
        object[,] resultSet27;
        string[] header27;
        object[,] resultSet28;
        string[] header28;
        object[,] resultSet29;
        string[] header29;
        object[,] resultSet30;
        string[] header30;

        // For Spp
        object[,] resultSet31;
        string[] header31;
        object[,] resultSet32;
        string[] header32;
        object[,] resultSet33;
        string[] header33;
        object[,] resultSet34;
        string[] header34;
        object[,] resultSet35;
        string[] header35;

        // For Spare
        object[,] resultSet36;
        string[] header36;
        object[,] resultSet37;
        string[] header37;
        object[,] resultSet38;
        string[] header38;
        object[,] resultSet39;
        string[] header39;
        object[,] resultSet40;
        string[] header40;


        // For 33KV
        object[,] resultSet41;
        string[] header41;
        object[,] resultSet42;
        string[] header42;
        object[,] resultSet43;
        string[] header43;
        object[,] resultSet44;
        string[] header44;
        object[,] resultSet45;
        string[] header45;

        /////////////For Production Count//////////////
        object[,] resultSet46;
        string[] header46;
        object[,] resultSet47;
        string[] header47;


        ////////////////////////////////*********************************************///////////////////////////////////////////////////////////////////////////
       // if (gbutton == true)
       // {

            DateTime currentTime = DateTime.Now;
            string currentDate = DateTime.Now.ToString("yyyy-MM-dd");

            // Calculate start and end times for the current day
            DateTime startTime = new DateTime(currentTime.Year, currentTime.Month, currentTime.Day, 0, 0, 0);
            DateTime endTime = new DateTime(currentTime.Year, currentTime.Month, currentTime.Day, 0, 0, 0).AddDays(-1);
            string new321 = endTime.ToString("yyyy-MM-dd");

            string new123 = startTime.ToString("yyyy-MM-dd");
            string month123 = startTime.ToString("yyyy-MM");
            string year123 = startTime.ToString("yyyy");
            float target33KV = target33kvVariable.Value;
            float targetstamping1 = targetstampingVariable.Value;
            float targettcf1 = targettcfVariable.Value;
            float targetbodyshop1 = targetbodyshopVariable.Value;
            float targetengineshop1 = targetengineshopVariable.Value;
            float targetpaintshop1 = targetpaintshopVariable.Value;
            float targetspp1 = targetsppVariable.Value;
            float targetutility1 = targetVariable.Value;
            float productioncount1 = productioncountVariable.Value;

            string old123 = endTime.ToString("yyyy-MM-dd"); 
           
            //throw new Exception(query46);

            ////////////////////////////////*********************************************/////////////////////////////////////////////////////////////////////////// 
            // For Utility
            myStore.Query(" UPDATE HomePage SET Target = '" + targetutility1 + "' WHERE LocalTimestamp BETWEEN '" + new123 + " 0:00:00' AND '" + new123 + " 23:59:59' AND Jace = 'UTILITY' ", out header1, out resultSet1);
            // myStore1.Query(query1, out string[] header1, out object[,] resultSet1);
            myStore.Query("SELECT Active_Power_Total FROM DailyJaceDataLogger WHERE Timestamp = '" + new123 + " 00:00:00.000' AND Jace = 'UTILITY' ", out header2, out resultSet2);
            myStore.Query("SELECT MIN(Consumption) FROM DailyJaceDataLogger WHERE MonthYear = '" + month123 + "' AND Jace = 'UTILITY' ", out header3, out resultSet3);
            myStore.Query("SELECT AVG(Consumption) FROM DailyJaceDataLogger WHERE MonthYear  = '" + month123 + "' AND Jace = 'UTILITY' ", out header4, out resultSet4);
            myStore.Query("SELECT Consumption FROM DailyJaceDataLogger WHERE Timestamp = '" + new123 + " 00:00:00.000' AND Jace = 'UTILITY' ", out header5, out resultSet5);
            // For Stamping
            myStore.Query(" UPDATE HomePage SET Target = '" + targetstamping1 + "' WHERE LocalTimestamp BETWEEN '" + new123 + " 0:00:00' AND '" + new123 + " 23:59:59' AND Jace = 'Stamping' ", out header6, out resultSet6);
            myStore.Query("SELECT Active_Power_Total FROM DailyJaceDataLogger WHERE Timestamp = '" + new123 + " 00:00:00.000' AND Jace = 'Stamping' ", out header7, out resultSet7);
            myStore.Query("SELECT MIN(Consumption) FROM DailyJaceDataLogger WHERE MonthYear = '" + month123 + "' AND Jace = 'STAMPING' ", out header8, out resultSet8);
            myStore.Query("SELECT AVG(Consumption) FROM DailyJaceDataLogger WHERE MonthYear  = '" + month123 + "' AND Jace = 'STAMPING' ", out header9, out resultSet9);
            myStore.Query("SELECT Consumption FROM DailyJaceDataLogger WHERE Timestamp = '" + new123 + " 00:00:00.000' AND Jace = 'STAMPING' ", out header10, out resultSet10);

            // For Tcf
            myStore.Query(" UPDATE HomePage SET Target = '" + targettcf1 + "' WHERE LocalTimestamp BETWEEN '" + new123 + " 0:00:00' AND '" + new123 + " 23:59:59' AND Jace = 'TCF' ", out header11, out resultSet11);
            myStore.Query("SELECT Active_Power_Total FROM DailyJaceDataLogger WHERE Timestamp = '" + new123 + " 00:00:00.000' AND Jace = 'TCF' ", out header12, out resultSet12);
            myStore.Query("SELECT MIN(Consumption) FROM DailyJaceDataLogger WHERE MonthYear = '" + month123 + "' AND Jace = 'TCF' ", out header13, out resultSet13);
            myStore.Query("SELECT AVG(Consumption) FROM DailyJaceDataLogger WHERE MonthYear  = '" + month123 + "' AND Jace = 'TCF' ", out header14, out resultSet14);
            myStore.Query("SELECT Consumption FROM DailyJaceDataLogger WHERE Timestamp = '" + new123 + " 00:00:00.000' AND Jace = 'TCF' ", out header15, out resultSet15);


            // For Bodyshop
            myStore.Query(" UPDATE HomePage SET Target = '" + targetbodyshop1 + "' WHERE LocalTimestamp BETWEEN '" + new123 + " 0:00:00' AND '" + new123 + " 23:59:59' AND Jace = 'BODYSHOP' ", out header16, out resultSet16);
            myStore.Query("SELECT Active_Power_Total FROM DailyJaceDataLogger WHERE Timestamp = '" + new123 + " 00:00:00.000' AND Jace = 'BODYSHOP' ", out header17, out resultSet17);
            myStore.Query("SELECT MIN(Consumption) FROM DailyJaceDataLogger WHERE MonthYear = '" + month123 + "' AND Jace = 'BODYSHOP' ", out header18, out resultSet18);
            myStore.Query("SELECT AVG(Consumption) FROM DailyJaceDataLogger WHERE MonthYear  = '" + month123 + "' AND Jace = 'BODYSHOP' ", out header19, out resultSet19);
            myStore.Query("SELECT Consumption FROM DailyJaceDataLogger WHERE Timestamp = '" + new123 + " 00:00:00.000' AND Jace = 'BODYSHOP' ", out header20, out resultSet20);



            // For Admin Shop
            myStore.Query(" UPDATE HomePage SET Target = '" + targetengineshop1 + "' WHERE LocalTimestamp BETWEEN '" + new123 + " 0:00:00' AND '" + new123 + " 23:59:59' AND Jace = 'ADMIN' ", out header21, out resultSet21);
            myStore.Query("SELECT Active_Power_Total FROM DailyJaceDataLogger WHERE Timestamp = '" + new123 + " 00:00:00.000' AND Jace = 'ADMIN' ", out header22, out resultSet22);
            myStore.Query("SELECT MIN(Consumption) FROM DailyJaceDataLogger WHERE MonthYear = '" + month123 + "' AND Jace = 'ADMIN' ", out header23, out resultSet23);
            myStore.Query("SELECT AVG(Consumption) FROM DailyJaceDataLogger WHERE MonthYear = '" + month123 + "' AND Jace = 'ADMIN' ", out header24, out resultSet24);
            myStore.Query("SELECT Consumption FROM DailyJaceDataLogger WHERE Timestamp = '" + new123 + " 00:00:00.000' AND Jace = 'ADMIN' ", out header25, out resultSet25);

            // For Paintshop
            myStore.Query(" UPDATE HomePage SET Target = '" + targetpaintshop1 + "' WHERE LocalTimestamp BETWEEN '" + new123 + " 0:00:00' AND '" + new123 + " 23:59:59' AND Jace = 'PAINTSHOP' ", out header26, out resultSet26);
            myStore.Query("SELECT Active_Power_Total FROM DailyJaceDataLogger WHERE Timestamp = '" + new123 + " 00:00:00.000' AND Jace = 'PAINTSHOP' ", out header27, out resultSet27);
            myStore.Query("SELECT MIN(Consumption) FROM DailyJaceDataLogger WHERE MonthYear = '" + month123 + "' AND Jace = 'PAINTSHOP' ", out header28, out resultSet28);
            myStore.Query("SELECT AVG(Consumption) FROM DailyJaceDataLogger WHERE MonthYear  = '" + month123 + "' AND Jace = 'PAINTSHOP' ", out header29, out resultSet29);
            myStore.Query("SELECT Consumption FROM DailyJaceDataLogger WHERE Timestamp = '" + new123 + " 00:00:00.000' AND Jace = 'PAINTSHOP' ", out header30, out resultSet30);


            // For Spp
            myStore.Query(" UPDATE HomePage SET Target = '" + targetspp1 + "' WHERE LocalTimestamp BETWEEN '" + new123 + " 0:00:00' AND '" + new123 + " 23:59:59' AND Jace = 'SPP' ", out header31, out resultSet31);
            myStore.Query("SELECT Active_Power_Total FROM DailyJaceDataLogger WHERE Timestamp = '" + new123 + " 00:00:00.000' AND Jace = 'SPP' ", out header32, out resultSet32);
            myStore.Query("SELECT MIN(Consumption) FROM DailyJaceDataLogger WHERE MonthYear = '" + month123 + "' AND Jace = 'SPP' ", out header33, out resultSet33);
            myStore.Query("SELECT AVG(Consumption) FROM DailyJaceDataLogger WHERE MonthYear  = '" + month123 + "' AND Jace = 'SPP' ", out header34, out resultSet34);
            myStore.Query("SELECT Consumption FROM DailyJaceDataLogger WHERE Timestamp = '" + new123 + " 00:00:00.000' AND Jace = 'SPP' ", out header35, out resultSet35);


            // For Spare
            myStore.Query("SELECT Target FROM ConsumptionDistribution WHERE LocalTimestamp BETWEEN '" + new123 + " 08:00:00' AND '" + new123 + " 07:59:59' AND Jace = 'Utility' ", out header36, out resultSet36);
            myStore.Query("SELECT Active_Power_Total FROM DailyJaceDataLogger WHERE Timestamp = '" + new123 + " 00:00:00.000' AND Jace = 'Utility' ", out header37, out resultSet37);
            myStore.Query("SELECT MIN(Consumption) FROM ConsumptionDistribution WHERE MonthYear = '" + month123 + "' AND Jace = 'Utility' ", out header38, out resultSet38);
            myStore.Query("SELECT AVG(Consumption) FROM ConsumptionDistribution WHERE MonthYear = '" + month123 + "' AND Jace = 'Utility' ", out header39, out resultSet39);
            myStore.Query("SELECT Consumption FROM ConsumptionDistribution WHERE Timestamp = '" + new123 + " 00:00:00.000' AND Jace = 'Utility' ", out header40, out resultSet40);



            // For 33KV
            myStore.Query(" UPDATE HomePage SET Target = '" + target33KV + "' WHERE LocalTimestamp BETWEEN '" + new123 + " 0:00:00' AND '" + new123 + " 23:59:59' AND Jace = '33KV' ", out header41, out resultSet41);
            myStore.Query("SELECT Active_Power_Total FROM DailyJaceDataLogger WHERE Timestamp = '" + new123 + " 00:00:00.000' AND Jace = '33KV' ", out header42, out resultSet42);
            myStore.Query("SELECT MIN(Consumption) FROM DailyJaceDataLogger WHERE MonthYear = '" + month123 + "' AND Jace = '33KV' ", out header43, out resultSet43);
            myStore.Query("SELECT AVG(Consumption) FROM DailyJaceDataLogger WHERE MonthYear  = '" + month123 + "' AND Jace = '33KV' ", out header44, out resultSet44);
            myStore.Query("SELECT Consumption FROM DailyJaceDataLogger WHERE Timestamp = '" + new123 + " 00:00:00.000' AND Jace = '33KV' ", out header45, out resultSet45);

            myStore.Query(" UPDATE HomePage SET Production = '" + productioncount1 + "' WHERE LocalTimestamp BETWEEN '" + old123 + " 0:00:00' AND '" + old123 + " 23:59:59' ", out header46, out resultSet46);
            myStore.Query("SELECT SUM(Consumption) FROM DailyJaceDataLogger WHERE MonthYear = '" + month123 + "' AND Jace = '33KV' ", out header47, out resultSet47);/////////////////For Production Count/////////////////////

            ////////////////////////////////*********************************************///////////////////////////////////////////////////////////////////////////

            //For Utility
            /*
            var rowCount1 = resultSet1 != null ? resultSet1.GetLength(0) : 0;
            var columnCount1 = header1 != null ? header1.Length : 0;
            if (rowCount1 > 0 && columnCount1 > 0)
            {
                var column1 = Convert.ToInt32(resultSet1[0, 0]);
                var Target = column1;
                target = Target;
            }
            */



            var rowCount2 = resultSet2 != null ? resultSet2.GetLength(0) : 0;
            var columnCount2 = header2 != null ? header2.Length : 0;
            if (rowCount2 > 0 && columnCount2 > 0)
            {
                var column1 = Convert.ToInt32(resultSet2[0, 0]);
                var UtilityPower = column1;
                utilitypower = UtilityPower;
            }


            var rowCount3 = resultSet3 != null ? resultSet3.GetLength(0) : 0;
            var columnCount3 = header3 != null ? header3.Length : 0;
            if (rowCount3 > 0 && columnCount3 > 0)
            {
                var column1 = Convert.ToInt32(resultSet3[0, 0]);
                var Monthlowest = column1;
                monthlowest = Monthlowest;
            }


            var rowCount4 = resultSet4 != null ? resultSet4.GetLength(0) : 0;
            var columnCount4 = header4 != null ? header4.Length : 0;
            if (rowCount4 > 0 && columnCount4 > 0)
            {
                var column1 = Convert.ToInt32(resultSet4[0, 0]);
                var Average = column1;
                average = Average;
            }

            var rowCount5 = resultSet5 != null ? resultSet5.GetLength(0) : 0;
            var columnCount5 = header5 != null ? header5.Length : 0;
            if (rowCount5 > 0 && columnCount5 > 0)
            {
                var column1 = Convert.ToInt32(resultSet5[0, 0]);
                var Consumption = column1;
                consumption = Consumption;
            }


            // For Stamping
            /*
            var rowCount6 = resultSet6 != null ? resultSet6.GetLength(0) : 0;
            var columnCount6 = header6 != null ? header6.Length : 0;
            if (rowCount6 > 0 && columnCount6 > 0)
            {
                var column1 = Convert.ToInt32(resultSet6[0, 0]);
                var TargetStamping = column1;
                targetstamping = TargetStamping;
            }

            */

            var rowCount7 = resultSet7 != null ? resultSet7.GetLength(0) : 0;
            var columnCount7 = header7 != null ? header7.Length : 0;
            if (rowCount7 > 0 && columnCount7 > 0)
            {
                var column1 = Convert.ToInt32(resultSet7[0, 0]);
                var StampingPower = column1;
                stampingpower = StampingPower;
            }


            var rowCount8 = resultSet8 != null ? resultSet8.GetLength(0) : 0;
            var columnCount8 = header8 != null ? header8.Length : 0;
            if (rowCount8 > 0 && columnCount8 > 0)
            {
                var column1 = Convert.ToInt32(resultSet8[0, 0]);
                var MonthlowestStamping = column1;
                monthloweststamping = MonthlowestStamping;
            }


            var rowCount9 = resultSet9 != null ? resultSet9.GetLength(0) : 0;
            var columnCount9 = header9 != null ? header9.Length : 0;
            if (rowCount9 > 0 && columnCount9 > 0)
            {
                var column1 = Convert.ToInt32(resultSet9[0, 0]);
                var AverageStamping = column1;
                averagestamping = AverageStamping;
            }

            var rowCount10 = resultSet10 != null ? resultSet10.GetLength(0) : 0;
            var columnCount10 = header10 != null ? header10.Length : 0;
            if (rowCount10 > 0 && columnCount10 > 0)
            {
                var column1 = Convert.ToInt32(resultSet10[0, 0]);
                var ConsumptionStamping = column1;
                consumptionstamping = ConsumptionStamping;
            }


            // For Tcf
            /*
            var rowCount11 = resultSet11 != null ? resultSet11.GetLength(0) : 0;
            var columnCount11 = header11 != null ? header11.Length : 0;
            if (rowCount11 > 0 && columnCount11 > 0)
            {
                var column1 = Convert.ToInt32(resultSet11[0, 0]);
                var TargetTcf = column1;
                targetstamping = TargetTcf;
            }
            */


            var rowCount12 = resultSet12 != null ? resultSet12.GetLength(0) : 0;
            var columnCount12 = header12 != null ? header12.Length : 0;
            if (rowCount12 > 0 && columnCount12 > 0)
            {
                var column1 = Convert.ToInt32(resultSet12[0, 0]);
                var TcfPower = column1;
                tcfpower = TcfPower;
            }


            var rowCount13 = resultSet13 != null ? resultSet13.GetLength(0) : 0;
            var columnCount13 = header13 != null ? header13.Length : 0;
            if (rowCount13 > 0 && columnCount13 > 0)
            {
                var column1 = Convert.ToInt32(resultSet13[0, 0]);
                var MonthlowestTcf = column1;
                monthlowesttcf = MonthlowestTcf;
            }


            var rowCount14 = resultSet14 != null ? resultSet14.GetLength(0) : 0;
            var columnCount14 = header14 != null ? header14.Length : 0;
            if (rowCount14 > 0 && columnCount14 > 0)
            {
                var column1 = Convert.ToInt32(resultSet14[0, 0]);
                var AverageTcf = column1;
                averagetcf = AverageTcf;
            }

            var rowCount15 = resultSet15 != null ? resultSet15.GetLength(0) : 0;
            var columnCount15 = header15 != null ? header15.Length : 0;
            if (rowCount15 > 0 && columnCount15 > 0)
            {
                var column1 = Convert.ToInt32(resultSet15[0, 0]);
                var ConsumptionTcf = column1;
                consumptiontcf = ConsumptionTcf;
            }

            // For Bodyshop
            /*
            var rowCount16 = resultSet16 != null ? resultSet16.GetLength(0) : 0;
            var columnCount16 = header16 != null ? header16.Length : 0;
            if (rowCount16 > 0 && columnCount16 > 0)
            {
                var column1 = Convert.ToInt32(resultSet16[0, 0]);
                var TargetBodyshop = column1;
                targetbodyshop = TargetBodyshop;
            }
            */


            var rowCount17 = resultSet17 != null ? resultSet17.GetLength(0) : 0;
            var columnCount17 = header17 != null ? header17.Length : 0;
            if (rowCount17 > 0 && columnCount17 > 0)
            {
                var column1 = Convert.ToInt32(resultSet17[0, 0]);
                var BodyshopPower = column1;
                bodyshoppower = BodyshopPower;
            }


            var rowCount18 = resultSet18 != null ? resultSet18.GetLength(0) : 0;
            var columnCount18 = header18 != null ? header18.Length : 0;
            if (rowCount18 > 0 && columnCount18 > 0)
            {
                var column1 = Convert.ToInt32(resultSet18[0, 0]);
                var MonthlowestBodyshop = column1;
                monthlowestbodyshop = MonthlowestBodyshop;
            }


            var rowCount19 = resultSet19 != null ? resultSet19.GetLength(0) : 0;
            var columnCount19 = header19 != null ? header19.Length : 0;
            if (rowCount19 > 0 && columnCount19 > 0)
            {
                var column1 = Convert.ToInt32(resultSet19[0, 0]);
                var AverageBodyshop = column1;
                averagebodyshop = AverageBodyshop;
            }

            var rowCount20 = resultSet20 != null ? resultSet20.GetLength(0) : 0;
            var columnCount20 = header20 != null ? header20.Length : 0;
            if (rowCount20 > 0 && columnCount20 > 0)
            {
                var column1 = Convert.ToInt32(resultSet20[0, 0]);
                var ConsumptionBodyshop = column1;
                consumptionbodyshop = ConsumptionBodyshop;
            }


            // For Engineshop
            /*
            var rowCount21 = resultSet21 != null ? resultSet21.GetLength(0) : 0;
            var columnCount21 = header21 != null ? header21.Length : 0;
            if (rowCount21 > 0 && columnCount21 > 0)
            {
                var column1 = Convert.ToInt32(resultSet21[0, 0]);
                var TargetEngineshop = column1;
                targetengineshop = TargetEngineshop;
            }
            */


            var rowCount22 = resultSet22 != null ? resultSet22.GetLength(0) : 0;
            var columnCount22 = header22 != null ? header22.Length : 0;
            if (rowCount22 > 0 && columnCount22 > 0)
            {
                var column1 = Convert.ToInt32(resultSet22[0, 0]);
                var AdminPower = column1;
                adminpower = AdminPower;
            }


            var rowCount23 = resultSet23 != null ? resultSet23.GetLength(0) : 0;
            var columnCount23 = header23 != null ? header23.Length : 0;
            if (rowCount23 > 0 && columnCount23 > 0)
            {
                var column1 = Convert.ToInt32(resultSet23[0, 0]);
                var MonthlowestEngineshop = column1;
                monthlowestengineshop = MonthlowestEngineshop;
            }


            var rowCount24 = resultSet24 != null ? resultSet24.GetLength(0) : 0;
            var columnCount24 = header24 != null ? header24.Length : 0;
            if (rowCount24 > 0 && columnCount24 > 0)
            {
                var column1 = Convert.ToInt32(resultSet24[0, 0]);
                var AverageEngineshop = column1;
                averageengineshop = AverageEngineshop;
            }

            var rowCount25 = resultSet25 != null ? resultSet25.GetLength(0) : 0;
            var columnCount25 = header25 != null ? header25.Length : 0;
            if (rowCount25 > 0 && columnCount25 > 0)
            {
                var column1 = Convert.ToInt32(resultSet25[0, 0]);
                var ConsumptionEngineshop = column1;
                consumptionengineshop = ConsumptionEngineshop;
            }



            // For Paintshop
            /*
            var rowCount26 = resultSet26 != null ? resultSet26.GetLength(0) : 0;
            var columnCount26 = header26 != null ? header26.Length : 0;
            if (rowCount26 > 0 && columnCount26 > 0)
            {
                var column1 = Convert.ToInt32(resultSet26[0, 0]);
                var TargetPaintshop = column1;
                targetpaintshop = TargetPaintshop;
            }
            */


            var rowCount27 = resultSet27 != null ? resultSet27.GetLength(0) : 0;
            var columnCount27 = header27 != null ? header27.Length : 0;
            if (rowCount27 > 0 && columnCount27 > 0)
            {
                var column1 = Convert.ToInt32(resultSet27[0, 0]);
                var PaintshopPower = column1;
               paintshoppower = PaintshopPower;
            }


            var rowCount28 = resultSet28 != null ? resultSet28.GetLength(0) : 0;
            var columnCount28 = header28 != null ? header28.Length : 0;
            if (rowCount28 > 0 && columnCount28 > 0)
            {
                var column1 = Convert.ToInt32(resultSet28[0, 0]);
                var MonthlowestPaintshop = column1;
                monthlowestpaintshop = MonthlowestPaintshop;
            }


            var rowCount29 = resultSet29 != null ? resultSet29.GetLength(0) : 0;
            var columnCount29 = header29 != null ? header29.Length : 0;
            if (rowCount29 > 0 && columnCount29 > 0)
            {
                var column1 = Convert.ToInt32(resultSet29[0, 0]);
                var AveragePaintshop = column1;
                averagepaintshop = AveragePaintshop;
            }

            var rowCount30 = resultSet30 != null ? resultSet30.GetLength(0) : 0;
            var columnCount30 = header30 != null ? header30.Length : 0;
            if (rowCount30 > 0 && columnCount30 > 0)
            {
                var column1 = Convert.ToInt32(resultSet30[0, 0]);
                var ConsumptionPaintshop = column1;
                consumptionpaintshop = ConsumptionPaintshop;
            }



            // For Spp
            /*
            var rowCount31 = resultSet31 != null ? resultSet31.GetLength(0) : 0;
            var columnCount31 = header31 != null ? header31.Length : 0;
            if (rowCount31 > 0 && columnCount31 > 0)
            {
                var column1 = Convert.ToInt32(resultSet31[0, 0]);
                var TargetSpp = column1;
                targetspp = TargetSpp;
            }
            */


            var rowCount32 = resultSet32 != null ? resultSet32.GetLength(0) : 0;
            var columnCount32 = header32 != null ? header32.Length : 0;
            if (rowCount32 > 0 && columnCount32 > 0)
            {
                var column1 = Convert.ToInt32(resultSet32[0, 0]);
                var SppPower = column1;
                spppower = SppPower;
            }


            var rowCount33 = resultSet33 != null ? resultSet33.GetLength(0) : 0;
            var columnCount33 = header33 != null ? header33.Length : 0;
            if (rowCount33 > 0 && columnCount33 > 0)
            {
                var column1 = Convert.ToInt32(resultSet33[0, 0]);
                var MonthlowestSpp = column1;
                monthlowestspp = MonthlowestSpp;
            }


            var rowCount34 = resultSet34 != null ? resultSet34.GetLength(0) : 0;
            var columnCount34 = header34 != null ? header34.Length : 0;
            if (rowCount34 > 0 && columnCount34 > 0)
            {
                var column1 = Convert.ToInt32(resultSet34[0, 0]);
                var AverageSpp = column1;
                averagespp = AverageSpp;
            }

            var rowCount35 = resultSet35 != null ? resultSet35.GetLength(0) : 0;
            var columnCount35 = header35 != null ? header35.Length : 0;
            if (rowCount35 > 0 && columnCount35 > 0)
            {
                var column1 = Convert.ToInt32(resultSet35[0, 0]);
                var ConsumptionSpp = column1;
                consumptionspp = ConsumptionSpp;
            }



            // For Spare
            /*
            var rowCount36 = resultSet36 != null ? resultSet36.GetLength(0) : 0;
            var columnCount36 = header36 != null ? header36.Length : 0;
            if (rowCount36 > 0 && columnCount36 > 0)
            {
                var column1 = Convert.ToInt32(resultSet36[0, 0]);
                var TargetSpare = column1;
                targetspare = TargetSpare;
            }
            */


            var rowCount37 = resultSet37 != null ? resultSet37.GetLength(0) : 0;
            var columnCount37 = header37 != null ? header37.Length : 0;
            if (rowCount37 > 0 && columnCount37 > 0)
            {
                var column1 = Convert.ToInt32(resultSet37[0, 0]);
                var YearlowestSpare = column1;
                yearlowestspare = YearlowestSpare;
            }


            var rowCount38 = resultSet38 != null ? resultSet38.GetLength(0) : 0;
            var columnCount38 = header38 != null ? header38.Length : 0;
            if (rowCount38 > 0 && columnCount38 > 0)
            {
                var column1 = Convert.ToInt32(resultSet38[0, 0]);
                var MonthlowestSpare = column1;
                monthlowestspare = MonthlowestSpare;
            }


            var rowCount39 = resultSet39 != null ? resultSet39.GetLength(0) : 0;
            var columnCount39 = header39 != null ? header39.Length : 0;
            if (rowCount39 > 0 && columnCount39 > 0)
            {
                var column1 = Convert.ToInt32(resultSet39[0, 0]);
                var AverageSpare = column1;
                averagespare = AverageSpare;
            }

            var rowCount40 = resultSet40 != null ? resultSet40.GetLength(0) : 0;
            var columnCount40 = header40 != null ? header40.Length : 0;
            if (rowCount40 > 0 && columnCount40 > 0)
            {
                var column1 = Convert.ToInt32(resultSet40[0, 0]);
                var ConsumptionSpare = column1;
                consumptionspare = ConsumptionSpare;
            }

            // For 33KV
            /*
            var rowCount41 = resultSet41 != null ? resultSet41.GetLength(0) : 0;
            var columnCount41 = header41 != null ? header41.Length : 0;
            if (rowCount41 > 0 && columnCount41 > 0)
            {
                var column1 = Convert.ToInt32(resultSet41[0, 0]);
                var Target33KV = column1;
                target33kv = Target33KV;
            }
            */


            var rowCount42 = resultSet42 != null ? resultSet42.GetLength(0) : 0;
            var columnCount42 = header42 != null ? header42.Length : 0;
            if (rowCount42 > 0 && columnCount42 > 0)
            {
                var column1 = Convert.ToInt32(resultSet42[0, 0]);
                var KV33Power = column1;
                kv33power = KV33Power;
            }


            var rowCount43 = resultSet43 != null ? resultSet43.GetLength(0) : 0;
            var columnCount43 = header43 != null ? header43.Length : 0;
            if (rowCount43 > 0 && columnCount43 > 0)
            {
                var column1 = Convert.ToInt32(resultSet43[0, 0]);
                var Monthlowest33KV = column1;
                monthlowest33kv = Monthlowest33KV;
            }


            var rowCount44 = resultSet44 != null ? resultSet44.GetLength(0) : 0;
            var columnCount44 = header44 != null ? header44.Length : 0;
            if (rowCount44 > 0 && columnCount44 > 0)
            {
                var column1 = Convert.ToInt32(resultSet44[0, 0]);
                var Average33KV = column1;
                average33kv = Average33KV;
            }

            var rowCount45 = resultSet45 != null ? resultSet45.GetLength(0) : 0;
            var columnCount45 = header45 != null ? header45.Length : 0;
            if (rowCount45 > 0 && columnCount45 > 0)
            {
                var column1 = Convert.ToInt32(resultSet45[0, 0]);
                var Consumption33KV = column1;
                consumption33kv = Consumption33KV;
            }

            var rowCount47 = resultSet47 != null ? resultSet47.GetLength(0) : 0;
            var columnCount47 = header47 != null ? header47.Length : 0;
            if (rowCount47 > 0 && columnCount47 > 0)
            {
                var column1 = Convert.ToInt32(resultSet47[0, 0]);
                var MonthConsumption = column1;
                monthconsumption = MonthConsumption;
            }


            ////////////////Calculation for Percentage/////////////////////////////
            float utilityP = (consumption * 100) / consumption33kv;
            float stampingP = (consumptionstamping * 100) / consumption33kv;
            float bodyshopP = (consumptionbodyshop * 100) / consumption33kv;
            float paintshopP = (consumptionpaintshop * 100) / consumption33kv;
            float sppP = (consumptionspp * 100) / consumption33kv;
            float spareP = (consumptionspare * 100) / consumption33kv;
            float tcfP = (consumptiontcf * 100) / consumption33kv;
            float engineP = (consumptionengineshop * 100) / consumption33kv;


            utilitypercentage = utilityP;
            stampingpercentage = stampingP;
            tcfpercentage = tcfP;
            bodyshoppercentage = bodyshopP;
            engineshoppercentage = engineP;
            paintshoppercentage = paintshopP;
            sparepercentage = spareP;
            spppercentage = sppP;

       // }

        /////////////////////////////////////////////////////*********************************************///////////////////////////////////////////////////////////////////////////
        monthyearVariable.Value = monthyear;
        yearVariable.Value = year;
        date1Variable.Value = date1;
        // For Utility
        //targetVariable.Value = target;
        utilitypowerVariable.Value = utilitypower;
        monthlowestVariable.Value = monthlowest;
        averageVariable.Value = average;
        consumptionVariable.Value = consumption;

        // For Stamping
        //targetstampingVariable.Value = targetstamping;
        stampingpowerVariable.Value = stampingpower;
        monthloweststampingVariable.Value = monthloweststamping;
        averagestampingVariable.Value = averagestamping;
        consumptionstampingVariable.Value = consumptionstamping;

        // For TCF
        //targettcfVariable.Value = targettcf;
        tcfpowerVariable.Value = tcfpower;
        monthlowesttcfVariable.Value = monthlowesttcf;
        averagetcfVariable.Value = averagetcf;
        consumptiontcfVariable.Value = consumptiontcf;

        // For Bodyshop
        //targetbodyshopVariable.Value = targetbodyshop;
        bodyshoppowerVariable.Value = bodyshoppower;
        monthlowestbodyshopVariable.Value = monthlowestbodyshop;
        averagebodyshopVariable.Value = averagebodyshop;
        consumptionbodyshopVariable.Value = consumptionbodyshop;


        // For Engineshop
        //targetengineshopVariable.Value = targetengineshop;
        adminpowerVariable.Value = adminpower;
        monthlowestengineshopVariable.Value = monthlowestengineshop;
        averageengineshopVariable.Value = averageengineshop;
        consumptionengineshopVariable.Value = consumptionengineshop;


        // For Paintshop
        //targetpaintshopVariable.Value = targetpaintshop;
        paintshoppowerVariable.Value = paintshoppower;
        monthlowestpaintshopVariable.Value = monthlowestpaintshop;
        averagepaintshopVariable.Value = averagepaintshop;
        consumptionpaintshopVariable.Value = consumptionpaintshop;

        // For Spp
        //targetsppVariable.Value = targetspp;
        spppowerVariable.Value = spppower;
        monthlowestsppVariable.Value = monthlowestspp;
        averagesppVariable.Value = averagespp;
        consumptionsppVariable.Value = consumptionspp;

        // For Spare
        //targetspareVariable.Value = targetspare;
        yearlowestspareVariable.Value = yearlowestspare;
        monthlowestspareVariable.Value = monthlowestspare;
        averagespareVariable.Value = averagespare;
        consumptionspareVariable.Value = consumptionspare;


        // For 33KV
        //
        //target33kvVariable.Value = target33kv;
        kv33powerVariable.Value = kv33power;
        monthlowest33kvVariable.Value = monthlowest33kv;
        average33kvVariable.Value = average33kv;
        consumption33kvVariable.Value = consumption33kv;


        // For Calculation
        utilitypercentageVariable.Value = utilitypercentage;
        stampingpercentageVariable.Value = stampingpercentage;
        tcfpercentageVariable.Value = tcfpercentage;
        bodyshoppercentageVariable.Value = bodyshoppercentage;
        engineshoppercentageVariable.Value = engineshoppercentage;
        paintshoppercentageVariable.Value = paintshoppercentage;
        sparepercentageVariable.Value = sparepercentage;
        spppercentageVariable.Value = spppercentage;

        monthconsumptionVariable.Value = monthconsumption;



    }


}
