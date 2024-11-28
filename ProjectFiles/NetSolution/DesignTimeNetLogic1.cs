#region Using directives
using System;
using UAManagedCore;
using OpcUa = UAManagedCore.OpcUa;
using FTOptix.UI;
using FTOptix.NativeUI;
using FTOptix.HMIProject;
using FTOptix.NetLogic;
using FTOptix.WebUI;
using FTOptix.Recipe;
using FTOptix.DataLogger;
using FTOptix.SQLiteStore;
using FTOptix.Store;
using FTOptix.OPCUAServer;
using FTOptix.Retentivity;
using FTOptix.CoreBase;
using FTOptix.Core;
using FTOptix.Alarm;
#endregion

public class DesignTimeNetLogic1 : BaseNetLogic
{
    [ExportMethod]
    public void ScriviNeiLog()
    {
        // Insert code to be executed by the method
        Log.Info("This is an info message");
    }

    [ExportMethod]
    public void CreaAllarmi()
    {
        // Insert code to be executed by the method
        var mioAllarme = InformationModel.Make<DigitalAlarm>("MioAllarme");
        mioAllarme.Message = "ciao";
        Project.Current.Get("Alarms").Add(mioAllarme);
    }
}
