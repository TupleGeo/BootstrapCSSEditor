
#region Header
// Title Name       : HtmlPageModel.
// Member of        : TupleGeo.Bootstrap.CssEditor.exe
// Description      : The model used by the html page viewmodel.
// Created by       : 02/11/2013 09:51, Vasilis Vlastaras.
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
  /// The model used by the html page viewmodel.
  /// </summary>
  public sealed class HtmlPageModel : ObservableObject<HtmlPageModel>, IModel {

    #region Constructors - Destuctors

    /// <summary>
    /// Initializes the HtmlPageModel.
    /// </summary>
    public HtmlPageModel() {
      _source = "http://www.google.com";
    }

    #endregion

    #region Public Properties

    private string _source;

    /// <summary>
    /// Gets / Sets the source of the html page.
    /// </summary>
    public string Source {
      get {
        return _source;
      }
      set {
        if (_source != value) {
          _source = value;
          this.OnPropertyChanged(m => m.Source);
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

      public const string ModelName = "HtmlPageModel";

      #endregion

    }

    #endregion

  }

}
