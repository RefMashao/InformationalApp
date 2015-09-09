using System;
using System.Collections.Generic;
using System.Text;

namespace InformationalApp.Classes
{
    class MainWindowViewModel
    {
        public MainWindowViewModel()
        {
            Pirates = new List<Pirate>
             {
                      new Pirate("Tshwane University of Technology"),
                      new Pirate("University of Johannesburg"),
                      new Pirate("Jeppe College"),
                      new Pirate("University of Limpopo"),
                      new Pirate("Tshwane North College"),
                      
                  };
        }

        public List<Pirate> Pirates { get; set; }

        public Pirate SelectedPirate { get; set; }
    }
}
