
#region Header
// Title Name       : PropertiesView.
// Member of        : TupleGeo.Bootstrap.CssEditor.exe
// Description      : The component properties view.
// Created by       : 02/11/2013 08:20, Vasilis Vlastaras.
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
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TupleGeo.Bootstrap.CssEditor.Engine;
using TupleGeo.Bootstrap.CssEditor.ViewModels;
using TupleGeo.Mvvm;

#endregion

namespace TupleGeo.Bootstrap.CssEditor.Views {

  /// <summary>
  /// The Bootstrap components view.
  /// </summary>
  public sealed partial class PropertiesView : UserControl, IView {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="PropertiesView"/>.
    /// </summary>
    public PropertiesView() {
      InitializeComponent();
      InitializeView();
    }

    #endregion

    #region Event Procedures

    #endregion

    #region Private Procedures

    /// <summary>
    /// Initializes the view.
    /// </summary>
    private void InitializeView() {

      try {
        // Make sure this executes in runtime.
        if (!DesignerProperties.GetIsInDesignMode(this)) {
          // The viewmodel of this view acts as a datacontext. Bind the viewmodel here.
          PropertiesViewModel propertiesViewModel = (PropertiesViewModel)((IViewModel)(Catalog.GetViewModel(this.GetType())));
          this.DataContext = propertiesViewModel;
          
          // The event procedures reside in to the viewmodel. Bind the view model event procedures here.

          // The dictionary of the controls needed to be observed by the viewmodel.
          //Dictionary<string, object> observedControlsDictionary = new Dictionary<string, object>();
          // Add the controls.
          //observedControlsDictionary.Add(this.layoutGrid.Name, this.layoutGrid);

          // Call the SubscribeToEvents method of the viewmodel.
          //shellViewModel.SubscribeToEvents(observedControlsDictionary);

          // Get any CollectionViewSources defined in the view as resources.
          //Dictionary<string, CollectionViewSource> collectionViewSourcesDictionary = new Dictionary<string, CollectionViewSource>();
          //CollectionViewSource completenessResultsViewSource = (CollectionViewSource)(this.Resources["completenessResultsViewSource"]);
          //collectionViewSourcesDictionary.Add("completenessResultsViewSource", completenessResultsViewSource);

          // Set the collection view sources in the viewmodel.
          //testFilesStructureViewModel.SetCollectionViewSources(collectionViewSourcesDictionary);
        }
      }
      catch (Exception ex) {
        //AppEngine.Instance.LogError(ex, "ShellView - InitializeView()");
        string error = "A data binding error has occured in 'PropertiesView'\r\n\r\n" +
                         "Error message: " + ex.Message + "\r\n\r\n";
        if (ex.InnerException != null) {
          error += string.Format("Internal exception: {0}", ex.InnerException.Message);
        }
        MessageBox.Show(error, "Databinding view error", MessageBoxButton.OK, MessageBoxImage.Error);
      }

    }

    #endregion

    #region IView Members

    /// <summary>
    /// Gets the view name.
    /// </summary>
    public string ViewName {
      get {
        return "PropertiesView";
      }
    }

    #endregion

  }

}
