#region Using directives
using System;
using UAManagedCore;
using OpcUa = UAManagedCore.OpcUa;
using FTOptix.DataLogger;
using FTOptix.HMIProject;
using FTOptix.NetLogic;
using FTOptix.NativeUI;
using FTOptix.UI;
using FTOptix.CoreBase;
using FTOptix.Store;
using FTOptix.ODBCStore;
using FTOptix.Report;
using FTOptix.RAEtherNetIP;
using FTOptix.Retentivity;
using FTOptix.CommunicationDriver;
using FTOptix.Core;
using Store = FTOptix.Store;
using System.Text.RegularExpressions;
using FTOptix.SQLiteStore;
using System.Data;
using System.Linq;
using System.Data.SqlClient;
using System.Reflection.Emit;
using FTOptix.MicroController;
using FTOptix.AuditSigning;
using FTOptix.Alarm;
#endregion

public class RuntimeNetLogic9 : BaseNetLogic
{
    
    private PeriodicTask periodicTask;
    private IUAVariable productioncountVariable;

    public IUAVariable ButtonVariable;

    public override void Start()
    {
        // Insert code to be executed when the user-defined logic is started
        var owner = (ProductionCount1)LogicObject.Owner;

        productioncountVariable = owner.ProductionCountVariable;
        ButtonVariable = owner.ButtonVariable;

       


        periodicTask = new PeriodicTask(IncrementDecrementTask, 2000, LogicObject);
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
        int production = productioncountVariable.Value;
        bool button = ButtonVariable.Value;
       

        ////////////////////////////////*********************************************///////////////////////////////////////////////////////////////////////////

        var project = FTOptix.HMIProject.Project.Current;
        // For Utility
        var myStore1 = project.GetObject("DataStores").Get<Store.Store>("ODBCDatabase");//Target
       



        ////////////////////////////////*********************************************///////////////////////////////////////////////////////////////////////////
        // For Utility
        object[,] resultSet1;
        string[] header1;
       


        ////////////////////////////////*********************************************///////////////////////////////////////////////////////////////////////////
        if (button == true)
        {

            DateTime currentTime = DateTime.Now;
            string currentDate = DateTime.Now.ToString("yyyy-MM-dd");


            // Calculate start and end times for the current day
            DateTime startTime = new DateTime(currentTime.Year, currentTime.Month, currentTime.Day, 0, 0, 0);
            DateTime endTime = new DateTime(currentTime.Year, currentTime.Month, currentTime.Day, 0, 0, 0).AddDays(-1);
            string new321 = endTime.ToString("yyyy-MM-dd");

            string new123 = endTime.ToString("yyyy-MM-dd");
            string month123 = startTime.ToString("yyyy-MM");
            string year123 = startTime.ToString("yyyy");
           


            // For Utility
            string query1 = $" UPDATE HomePage SET Production = '" + production + "' WHERE LocalTimestamp BETWEEN '" + new123 + " 0:00:00' AND '" + new123 + " 23:59:59' ";
            
            // For Utility
            myStore1.Query(query1, out header1, out resultSet1);
           


           

        }

       


    }


}
