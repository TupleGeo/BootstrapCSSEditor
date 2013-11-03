
#region Header
// Title Name       : HtmlPageViewModel.
// Member of        : TupleGeo.Bootstrap.CssEditor.exe
// Description      : The html page view model.
// Created by       : 02/11/2012 09:50, Vasilis Vlastaras.
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
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;
using TupleGeo.Bootstrap.CssEditor.Models;
using TupleGeo.Mvvm;
using TupleGeo.Mvvm.Commands;
using TupleGeo.Bootstrap.CssEditor.Engine;

#endregion

namespace TupleGeo.Bootstrap.CssEditor.ViewModels {

  /// <summary>
  /// The components view model.
  /// </summary>
  public sealed class HtmlPageViewModel : BaseViewModel<HtmlPageModel>, IViewModel {

    #region Member Variables

    #endregion

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="HtmlPageViewModel"/>.
    /// </summary>
    /// <param name="htmlPageModel">The <see cref="HtmlPageModel"/> used against this view model.</param>
    public HtmlPageViewModel(HtmlPageModel htmlPageModel)
      : base(htmlPageModel) {

      InitializeCommands();
    }

    #endregion

    #region Public Properties

    /// <summary>
    /// Gets / Sets the load html page command.
    /// </summary>
    public ICommand LoadHtmlPageCommand {
      get;
      private set;
    }

    #endregion

    #region Public Methods

    #endregion

    #region Event Procedures

    #endregion

    #region Private Procedures

    /// <summary>
    /// Initializes the commands.
    /// </summary>
    private void InitializeCommands() {

      // LoadHtmlPageCommand.
      LoadHtmlPageCommand = new MvvmCommand(
        (parameter) => {
          LoadHtmlPageCommandAction(parameter);
        },
        (parameter) => {
          return LoadHtmlPageCommandCanExecute(parameter);
        }
      );
      // Add listeners here.
      ((MvvmCommand)this.LoadHtmlPageCommand).AddListener<HtmlPageModel>(this.Model, m => m.Source);
      //((MvvmCommand)this.Command1Command).AddObservableCollectionListener<MvvmModel>(this.Model.ObservableCollection1);
      //((MvvmCommand)this.Command1Command).AddListener<MvvmModel>(this.Model, m => m.Property2);
      
    }

    #endregion

    #region Private Actions

    /// <summary>
    /// 
    /// </summary>
    /// <param name="parameter"></param>
    private void LoadHtmlPageCommandAction(object parameter) {

      TupleGeo.Bootstrap.CssEditor.Views.HtmlPageView view = 
        (TupleGeo.Bootstrap.CssEditor.Views.HtmlPageView)Catalog.GetSingletonView(typeof(TupleGeo.Bootstrap.CssEditor.Views.HtmlPageView));
      
      view.webBrowser.Source = new Uri(this.Model.Source, UriKind.RelativeOrAbsolute);
      //view.webBrowser.Navigate(this.Model.Source);
      
    }

    /// <summary>
    /// Determines whether the <see cref="LoadHtmlPageCommand"/> can execute.
    /// </summary>
    /// <param name="parameter">The parameter associated with the command.</param>
    /// <returns>A <see cref="bool"/> with the result of the evaluation.</returns>
    private bool LoadHtmlPageCommandCanExecute(object parameter) {
      return this.Model.Source != null &&
             this.Model.Source != string.Empty;
    }

    #endregion

    #region BaseViewModel Members

    /// <summary>
    /// Gets the title for this view model.
    /// </summary>
    public override string Title {
      get {
        return this.Model.ModelName;
      }
    }

    #endregion

    #region IViewModel Members

    /// <summary>
    /// Gets the name of the view model.
    /// </summary>
    public string Name {
      get {
        return "HtmlPageViewModel";
      }
    }

    /// <summary>
    /// Binds this view model to events raised by its corresponding view.
    /// </summary>
    /// <param name="triggeringObjectsDictionary">The object whose events will be observed.</param>
    public void SubscribeToEvents(Dictionary<string, object> triggeringObjectsDictionary) {

    }

    /// <summary>
    /// Removes event subscriptions of this view model.
    /// </summary>
    /// <param name="triggeringObjectsDictionary">The objects whose events will be stoped being observed.</param>
    public void UnsubscribeFromEvents(Dictionary<string, object> triggeringObjectsDictionary) {

    }

    /// <summary>
    /// Sets the <see cref="CollectionViewSource">CollectionViewSources</see> for this model.
    /// </summary>
    /// <param name="collectionViewSources">
    /// The dictionary of <see cref="CollectionViewSource">CollectionViewSources</see>
    /// that will be used to display data.
    /// </param>
    public void SetCollectionViewSources(Dictionary<string, CollectionViewSource> collectionViewSources) {

    }

    #endregion

  }

}
