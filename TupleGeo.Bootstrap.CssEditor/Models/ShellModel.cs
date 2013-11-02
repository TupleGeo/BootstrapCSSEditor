
#region Header
// Title Name       : ShellModel.
// Member of        : TupleGeo.Bootstrap.CssEditor.exe
// Description      : The model used by the shell.
// Created by       : 02/11/2013 02:25, Vasilis Vlastaras.
// Updated by       : 
// Version          : 1.0.0
// Contact Details  : 
// License          : 
// Copyright        : GeoValues, 2013
//
// Comments         : 
#endregion

#region Imported Namespaces

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TupleGeo.Bootstrap.CssEditor.Engine;
using TupleGeo.Global.ComponentModel;
using TupleGeo.Mvvm;

#endregion

namespace TupleGeo.Bootstrap.CssEditor.Models {

  /// <summary>
  /// The model used by the shell.
  /// </summary>
  public sealed class ShellModel : ObservableObject<ShellModel>, IModel {

    #region Constructors - Destuctors

    /// <summary>
    /// Initializes the ShellModel.
    /// </summary>
    public ShellModel() {

    }

    #endregion

    #region Public Properties

    /// <summary>
    /// Gets the caption of the shell.
    /// </summary>
    public string Caption {
      get {
        if (AppEngine.Instance.ApplicationModel != null) {
          return AppEngine.Instance.ApplicationModel.Caption;
        }
        else {
          return "";
        }
      }
    }

    #endregion

    #region Event Procedures

    #endregion

    #region IModel Members

    /// <summary>
    /// Gets the name of the model.
    /// </summary>
    public string ModelName {
      get {
        return StaticProvider.ModelName;
      }
    }

    #endregion

    #region Nested Classes

    /// <summary>
    /// The StaticProvider is used to provide static members to its parent class.
    /// </summary>
    private static class StaticProvider {

      #region Member Variables

      public const string ModelName = "ShellModel";

      #endregion

    }

    #endregion

  }  

}
