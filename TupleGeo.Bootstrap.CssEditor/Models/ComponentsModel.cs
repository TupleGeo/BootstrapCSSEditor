
#region Header
// Title Name       : ComponentsModel.
// Member of        : TupleGeo.Bootstrap.CssEditor.exe
// Description      : The model used by the components viewmodel.
// Created by       : 02/11/2013 08:36, Vasilis Vlastaras.
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
  /// The model used by the components viewmodel.
  /// </summary>
  public sealed class ComponentsModel : ObservableObject<ComponentsModel>, IModel {

    #region Constructors - Destuctors

    /// <summary>
    /// Initializes the ComponentsModel.
    /// </summary>
    public ComponentsModel() {

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

      public const string ModelName = "ComponentsModel";

      #endregion

    }

    #endregion

  }

}
