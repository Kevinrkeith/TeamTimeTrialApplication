﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTrialsWPFApplication.Commands;

namespace TimeTrialsWPFApplication.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        NavigateCommand<BaseViewModel> navigateCommand;
        public BaseViewModel()
        {

        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
