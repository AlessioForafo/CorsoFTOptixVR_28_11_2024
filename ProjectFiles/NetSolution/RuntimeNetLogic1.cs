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

public class RuntimeNetLogic1 : BaseNetLogic
{
    public override void Start()
    {
        // Insert code to be executed when the user-defined logic is started
        Log.Info("Avvio progetto");
    }

    public override void Stop()
    {
        // Insert code to be executed when the user-defined logic is stopped
        Log.Info("Chiusura progetto");
    }

    [ExportMethod]
    public void MioLogCustom(string miotesto)
    {
        Log.Info(miotesto);
    }

    [ExportMethod]
    public void CalcolaUmidita()
    {
        var umidita = Project.Current.GetVariable("Model/Umidita");
        var umiditaCalcolata = Project.Current.GetVariable("Model/UmiditaCalcolata");
        umiditaCalcolata.Value = umidita.Value + 100;
    }
}
