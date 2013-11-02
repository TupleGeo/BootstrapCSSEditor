
#region Header
// Title Name       : ApplicationModel.
// Member of        : TupleGeo.Bootstrap.CssEditor.exe
// Description      : The model of the application.
// Created by       : 02/11/2012 02:54, Vasilis Vlastaras.
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
using System.Xml.Serialization;
using TupleGeo.Global.ComponentModel;
using TupleGeo.Mvvm;

#endregion

namespace TupleGeo.Bootstrap.CssEditor.Models.Application {

  /// <summary>
  /// The model of the application.
  /// </summary>
  [SerializableAttribute()]
  [XmlRootAttribute(Namespace = "urn:TupleGeo.Bootstrap.CssEditor.Models.Application", ElementName = "applicationConfiguration")]
  public sealed class ApplicationModel : ObservableObject<ApplicationModel>, IModel {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="ApplicationModel"/>.
    /// </summary>
    public ApplicationModel() {
      this.Caption = "Bootstrap CSS Editor";
    }

    #endregion

    #region Public Properties

    private string _caption;

    /// <summary>
    /// Gets / Sets the caption text of the main application window.
    /// </summary>
    [XmlIgnoreAttribute()]
    public string Caption {
      get {
        return _caption;
      }
      set {
        if (_caption != value) {
          _caption = value;
          this.OnPropertyChanged(m => m.Caption);
        }
      }
    }

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

      public const string ModelName = "ApplicationModel";

      #endregion

    }

    #endregion

  }

}
