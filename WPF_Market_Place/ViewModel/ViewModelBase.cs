﻿using System.ComponentModel;

namespace WPF_Market_Place.ViewModel;

public class ViewModelBase : INotifyPropertyChanged
{
     public event PropertyChangedEventHandler? PropertyChanged;

     protected void OnPropertyChanged(string propertyName)
     {
          PropertyChanged?.Invoke (this, new PropertyChangedEventArgs(propertyName));
     }

     public virtual void Dispose() { }
}