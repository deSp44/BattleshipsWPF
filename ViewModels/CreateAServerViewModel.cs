﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Battleships.Commands;
using Battleships.Stores;
using Battleships.Views.SwitchingViews;

namespace Battleships.ViewModels
{
    public class CreateAServerViewModel : ViewModelBase
    {
        private readonly NavigationStore _navigationStore;
        private SoundPlayer _buttonClickSound = new SoundPlayer(Path.Combine(Environment.CurrentDirectory + @"/media/button_sound.wav"));
        public CreateAServerViewModel(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;

            BackCommand = new RelayCommand(Back);
        }

        public ICommand BackCommand { get; }


        private void Back(object obj)
        {
            _buttonClickSound.Play();
            _navigationStore.CurrentViewModel = new HomeViewModel(_navigationStore);
        } 
    }
}
