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

public class RuntimeNetLogic2 : BaseNetLogic
{
    public override void Start()
    {
        // Insert code to be executed when the user-defined logic is started
        var umidita = Project.Current.GetVariable("Model/Umidita");
        umidita.VariableChange += Umidita_VariableChange;
    }

    private void Umidita_VariableChange(object sender, VariableChangeEventArgs e)
    {
        var umiditaCalcolata = Project.Current.GetVariable("Model/UmiditaCalcolata");
        umiditaCalcolata.Value = umiditaCalcolata.Value + 1;
    }

    public override void Stop()
    {
        // Insert code to be executed when the user-defined logic is stopped
    }
}
