
#region Header
// Title Name       : BootStrapper.
// Member of        : TupleGeo.Bootstrap.CssEditor.exe
// Description      : Provides the boot sequence for this application.
// Created by       : 02/11/2013 02:03, Vasilis Vlastaras.
// Updated by       : 
// Version          : 1.0.0
// Contact Details  : 
// License          : 
// Copyright        : TupleGeo, 2013
//
// Comments         : 
#endregion

#region Imported Namespaces

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

#endregion

namespace TupleGeo.Bootstrap.CssEditor {

  /// <summary>
  /// Provides the boot sequence for this application.
  /// </summary>
  public partial class BootStrapper : Application {

    #region Event Procedures

    /// <summary>
    /// Occurs upon application exit.
    /// </summary>
    /// <param name="e">The <see cref="ExitEventArgs"/>.</param>
    protected override void OnExit(ExitEventArgs e) {
      base.OnExit(e);

      //AppEngine.Instance.SaveConfiguration();
    }

    /// <summary>
    /// Occurs upon application startup.
    /// </summary>
    /// <param name="e">The <see cref="StartupEventArgs"/>.</param>
    protected override void OnStartup(StartupEventArgs e) {
      base.OnStartup(e);

      Initialize();
    }

    ///// <summary>
    ///// 
    ///// </summary>
    ///// <param name="sender"></param>
    ///// <param name="e"></param>
    //private void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e) {

    //  string directory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
    //  string logPath = directory + "\\Log_" + DateTime.Now.Year.ToString() + "_" + DateTime.Now.Month.ToString() + "_" + DateTime.Now.Day.ToString() + ".txt";

    //  StreamWriter streamWriter = new StreamWriter(logPath, true);

    //  try {
    //    Exception exception = (Exception)e.ExceptionObject;

    //    streamWriter.WriteLine("--------");
    //    streamWriter.WriteLine("Error Time: " + DateTime.Now.ToShortTimeString());
    //    streamWriter.WriteLine();
    //    streamWriter.WriteLine("Message: " + exception.Message);
    //    streamWriter.WriteLine();
    //    streamWriter.WriteLine("Source: " + exception.Source);
    //    streamWriter.WriteLine();
    //    streamWriter.WriteLine("StackTrace: " + exception.StackTrace);
    //    streamWriter.WriteLine("--------");

    //    MessageBox.Show(exception.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
    //  }
    //  catch {
    //    // Swallow the error.
    //  }
    //  finally {
    //    streamWriter.Close();
    //    streamWriter.Dispose();
    //  }

    //}

    ///// <summary>
    ///// 
    ///// </summary>
    ///// <param name="sender"></param>
    ///// <param name="e"></param>
    //private void Application_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e) {

    //  string directory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
    //  string logPath = directory + "\\Log_" + DateTime.Now.Year.ToString() + "_" + DateTime.Now.Month.ToString() + "_" + DateTime.Now.Day.ToString() + ".txt";

    //  StreamWriter streamWriter = new StreamWriter(logPath, true);

    //  try {
    //    Exception exception = e.Exception;

    //    streamWriter.WriteLine("--------");
    //    streamWriter.WriteLine("Error Time: " + DateTime.Now.ToShortTimeString());
    //    streamWriter.WriteLine();
    //    streamWriter.WriteLine("Message: " + exception.Message);
    //    streamWriter.WriteLine();
    //    streamWriter.WriteLine("Source: " + exception.Source);
    //    streamWriter.WriteLine();
    //    streamWriter.WriteLine("StackTrace: " + exception.StackTrace);
    //    streamWriter.WriteLine("--------");

    //    MessageBox.Show(exception.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
    //  }
    //  catch {
    //    // Swallow the error.
    //  }
    //  finally {
    //    e.Handled = true;
    //    streamWriter.Close();
    //    streamWriter.Dispose();
    //  }

    //}

    #endregion

    #region Private Procedures

    /// <summary>
    /// Initializes the application.
    /// </summary>
    private void Initialize() {

      // Catch unhandled exceptions.
      //AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException); // Let's hope Dichpatcher unhandled exception is sufficient enough.

      // Read the configuration file.
      //AppEngine.Instance.ReadConfiguration();

    }

    #endregion

  }

}
