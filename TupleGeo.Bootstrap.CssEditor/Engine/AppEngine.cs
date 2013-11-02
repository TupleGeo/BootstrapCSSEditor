
#region Header
// Title Name       : AppEngine.
// Member of        : TupleGeo.Bootstrap.CssEditor.exe
// Description      : The application engine.
// Created by       : 02/11/2013 02:28, Vasilis Vlastaras.
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
using System.Linq;
using System.Text;
using TupleGeo.Bootstrap.CssEditor.Models.Application;
using TupleGeo.Global.ComponentModel;

#endregion

namespace TupleGeo.Bootstrap.CssEditor.Engine {

  /// <summary>
  /// The application engine.
  /// </summary>
  public sealed class AppEngine : ObservableObject<AppEngine> {

    #region Member Variables

    #endregion

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the AppEngine.
    /// </summary>
    private AppEngine() {
      _applicationModel = new ApplicationModel();
    }

    #endregion

    #region Public Properties

    private static readonly AppEngine _instance = new AppEngine();

    /// <summary>
    /// Gets the instance of the <see cref="AppEngine"/>.
    /// </summary>
    public static AppEngine Instance {
      get {
        return _instance;
      }
    }

    //private MvvmEventManager _eventManager;

    ///// <summary>
    ///// Gets the event manager of the application.
    ///// </summary>
    //public MvvmEventManager EventManager {
    //  get {
    //    return _eventManager;
    //  }
    //}

    private ApplicationModel _applicationModel;

    /// <summary>
    /// Gets / Sets the <see cref="ApplicationModel"/>.
    /// </summary>
    public ApplicationModel ApplicationModel {
      get {
        return _applicationModel;
      }
      set {
        if (_applicationModel != value) {
          _applicationModel = value;
          this.OnPropertyChanged(m => m.ApplicationModel);
        }
      }
    }

    #endregion

    #region Public Methods

    ///// <summary>
    ///// Gets a property name.
    ///// </summary>
    ///// <typeparam name="TEntity">The entity.</typeparam>
    ///// <param name="expression">The expression.</param>
    ///// <returns>A string holding the property name.</returns>
    //public string GetPropertyName<TEntity>(Expression<Func<TEntity, object>> expression) {
    //  var lambda = expression as LambdaExpression;
    //  MemberExpression memberExpression;

    //  if (lambda.Body is UnaryExpression) {
    //    var unaryExpression = lambda.Body as UnaryExpression;
    //    memberExpression = unaryExpression.Operand as MemberExpression;
    //  }
    //  else {
    //    memberExpression = lambda.Body as MemberExpression;
    //  }

    //  var constantExpression = memberExpression.Expression as ConstantExpression;
    //  var propertyInfo = memberExpression.Member as PropertyInfo;
          
    //  return propertyInfo.Name;
    //}

    ///// <summary>
    ///// Reads the configuration of the application from the configuration file.
    ///// </summary>
    //public void ReadConfiguration() {
    //  string configFile = string.Format(
    //    "{0}{1}", // TODO: RES
    //    PathsUtility.AddBackSlashToPath(AppDomain.CurrentDomain.BaseDirectory), Settings.Default.ApplicationConfigFile
    //  );

    //  // TODO: Serialization Code to be removed.
    //  #region Serialization Code

    //  //_applicationModel.ShapeFileBasePath = @"\\geofiles\G_I_S\1_GIS\01_Digital_Data\";

    //  //TupleGeo.Global.Serialization.XmlSerializer.Serialize(_applicationModel, configFile);

    //  #endregion

    //  // Get the application level information.
    //  AppEngine.Instance.ApplicationModel = (ApplicationModel)TupleGeo.Global.Serialization.XmlSerializer.Deserialize(
    //    typeof(ApplicationModel),
    //    configFile
    //  );
    //}

    ///// <summary>
    ///// Saves the configuration of the application in to the configuration file.
    ///// </summary>
    //public void SaveConfiguration() {
    //  string configFile = string.Format(
    //    "{0}{1}",
    //    PathsUtility.AddBackSlashToPath(AppDomain.CurrentDomain.BaseDirectory), Settings.Default.ApplicationConfigFile
    //  );

    //  TupleGeo.Global.Serialization.XmlSerializer.Serialize(_applicationModel, configFile);
    //}

    ///// <summary>
    ///// Logs an error in to the application error log file.
    ///// </summary>
    ///// <param name="exception">The <see cref="Exception"/> that has been occured.</param>
    //public void LogError(Exception exception) {

    //  string directory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
    //  string logPath = directory + "\\Logs\\Log_" + DateTime.Now.Year.ToString() + "_" + DateTime.Now.Month.ToString() + "_" + DateTime.Now.Day.ToString() + ".txt";

    //  StreamWriter streamWriter = new StreamWriter(logPath, true);

    //  try {
    //    streamWriter.WriteLine("--------");
    //    streamWriter.WriteLine("Error Time: " + DateTime.Now.ToShortTimeString());
    //    streamWriter.WriteLine();
    //    streamWriter.WriteLine("Message: " + exception.Message);
    //    streamWriter.WriteLine();
    //    streamWriter.WriteLine("Source: " + exception.Source);
    //    streamWriter.WriteLine();
    //    streamWriter.WriteLine("StackTrace: " + exception.StackTrace);
    //    streamWriter.WriteLine("--------");

    //    MessageBox.Show(exception.Message, "Σφάλμα", MessageBoxButton.OK, MessageBoxImage.Error);
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
    ///// Logs an error in to the application error log file.
    ///// </summary>
    ///// <param name="exception">The <see cref="Exception"/> that has been occured.</param>
    ///// <param name="friendlySource">A friendly source name.</param>
    //public void LogError(Exception exception, string friendlySource) {

    //  string directory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
    //  string logPath = directory + "\\Logs\\Log_" + DateTime.Now.Year.ToString() + "_" + DateTime.Now.Month.ToString() + "_" + DateTime.Now.Day.ToString() + ".txt";

    //  StreamWriter streamWriter = new StreamWriter(logPath, true);

    //  try {
    //    streamWriter.WriteLine("--------");
    //    streamWriter.WriteLine("Error Time: " + DateTime.Now.ToShortTimeString());
    //    streamWriter.WriteLine();
    //    streamWriter.WriteLine("Message: " + exception.Message);
    //    streamWriter.WriteLine();
    //    streamWriter.WriteLine("Friendly Source: " + friendlySource);
    //    streamWriter.WriteLine();
    //    streamWriter.WriteLine("Source: " + exception.Source);
    //    streamWriter.WriteLine();
    //    streamWriter.WriteLine("StackTrace: " + exception.StackTrace);
    //    streamWriter.WriteLine("--------");
    //  }
    //  catch {
    //    // Swallow the error.
    //  }
    //  finally {
    //    streamWriter.Close();
    //    streamWriter.Dispose();
    //  }

    //}

    #endregion

  }

}
