﻿
#region Header
// Title Name       : ComponentsViewModel.
// Member of        : TupleGeo.Bootstrap.CssEditor.exe
// Description      : The components view model.
// Created by       : 02/11/2012 08:27, Vasilis Vlastaras.
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

#endregion

namespace TupleGeo.Bootstrap.CssEditor.ViewModels {

  /// <summary>
  /// The components view model.
  /// </summary>
  public sealed class ComponentsViewModel : BaseViewModel<ComponentsModel>, IViewModel {

    #region Member Variables

    #endregion

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="ComponentsViewModel"/>.
    /// </summary>
    /// <param name="componentsModel">The <see cref="ComponentsModel"/> used against this view model.</param>
    public ComponentsViewModel(ComponentsModel componentsModel)
      : base(componentsModel) {

    }

    #endregion

    #region Public Properties

    #endregion

    #region Public Methods

    #endregion

    #region Event Procedures

    #endregion

    #region Private Procedures

    #endregion

    #region Private Actions

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
        return "ComponentsViewModel";
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
