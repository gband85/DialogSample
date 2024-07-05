/*
Alt Controller
--------------
Copyright 2013 Tim Brogden
http://altcontroller.net

Description
-----------
A free program for mapping computer inputs, such as pointer movements and button presses, 
to actions, such as key presses. The aim of this program is to help make third-party programs,
such as computer games, more accessible to users with physical difficulties.

License
-------
This file is part of Alt Controller. 
Alt Controller is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

Alt Controller is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with Alt Controller.  If not, see <http://www.gnu.org/licenses/>.
*/
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Windows;
using System.Windows.Interop;
using System.Windows.Controls;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm;
using CommunityToolkit.Mvvm.Input;
using System.Windows.Input;
using System.Windows.Threading;
using System.Threading;
using DialogSample.Event;
using DialogSample.Interfaces;
using DialogSample.Services;
using Microsoft.Win32;
using DialogSample.Views;
using Microsoft.Xaml.Behaviors.Core;
using Point = System.Windows.Point;

//using System.Diagnostics;

namespace DialogSample.ViewModels
{
    /// <summary>
    /// Main application window
    /// </summary>
    public partial class MainWindowViewModel : ViewModelBase
    {
        private readonly IDialogService dialogService;
        public MainWindowViewModel(IDialogService dialogService)
        {
            this.dialogService = dialogService;
            DisplayMessageCommand = new ActionCommand(p => DisplayMessage());
        }
            public ICommand DisplayMessageCommand { get; }

            private void DisplayMessage()
            {
                var viewModel = new DialogViewModel("Hello!");
                var view = new DialogWindow { DataContext = viewModel };

                bool? result = dialogService.ShowDialog(viewModel);

                if (result.HasValue)
                {
                    if (result.Value)
                    {
                        
                    }
                }
            }
    }
}
