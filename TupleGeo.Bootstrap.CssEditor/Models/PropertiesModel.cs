
#region Header
// Title Name       : PropertiesModel.
// Member of        : TupleGeo.Bootstrap.CssEditor.exe
// Description      : The model used by the properties viewmodel.
// Created by       : 02/11/2013 08:37, Vasilis Vlastaras.
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
using TupleGeo.Bootstrap.CssEditor.Engine;
using TupleGeo.Global.ComponentModel;
using TupleGeo.Mvvm;

#endregion

namespace TupleGeo.Bootstrap.CssEditor.Models {

  /// <summary>
  /// The model used by the properties viewmodel.
  /// </summary>
  public sealed class PropertiesModel : ObservableObject<PropertiesModel>, IModel {

    #region Constructors - Destuctors

    /// <summary>
    /// Initializes the PropertiesModel.
    /// </summary>
    public PropertiesModel() {

    }

    #endregion

    #region Public Properties

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

      public const string ModelName = "PropertiesModel";

      #endregion

    }

    #endregion

  }

}
