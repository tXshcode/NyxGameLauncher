using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using NyxGameLauncher.Model;
using Rechnungsverwaltung.ViewModel;

namespace NyxGameLauncher.ViewModel
{
    internal class GameViewModel : INotifyPropertyChanged
    {
        #region Declarations

        private GameList list;
        public GameList List
        {
            get => list;
            set
            {
                list = value;
                RaisePropertyChanged();
            }
        }
        #region ICommand Declarations
        public ICommand AddGameCommand { get; set; }
        #endregion
        
        #endregion


        public GameViewModel()
        {


            #region ICommands Definitions

            AddGameCommand = new RelayCommand(e =>
            {
                Console.WriteLine("test");
            });

            #endregion
        }


        #region PropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
