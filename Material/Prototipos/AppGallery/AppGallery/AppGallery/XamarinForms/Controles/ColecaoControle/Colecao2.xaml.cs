﻿using AppGallery.XamarinForms.Controles.ListaControle;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Controles.ColecaoControle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Colecao2 : ContentPage
    {
        public Colecao2()
        {
            InitializeComponent(); 
            Lista01.ItemsSource = GetMarcasESeusModelos();
        }

        private ObservableCollection<Marca> GetMarcasESeusModelos()
        {
            Marca fiat = new Marca()
            {
                new Modelo { Nome = "Mobi", Motor = "1.0Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec ac rutrum nisi, ut venenatis purus. Nullam vitae malesuada lorem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec ac rutrum nisi, ut venenatis purus. Nullam vitae malesuada lorem. " },
                new Modelo { Nome = "Uno", Motor = "1.0" },
                new Modelo { Nome = "Argo", Motor = "1.4" },
                new Modelo { Nome = "Cronos", Motor = "1.4" },
                new Modelo { Nome = "Toro", Motor = "2.0" },
            };
            fiat.Nome = "FIAT";

            Marca chevrolet = new Marca()
            {
                new Modelo { Nome = "Onix", Motor = "1.0T" },
                new Modelo { Nome = "Onix Plus", Motor = "1.2T" },
                new Modelo { Nome = "Cruze", Motor= "2.0T" },
                new Modelo { Nome = "Cruze Sport6", Motor= "2.0T" },
                new Modelo { Nome = "Spin", Motor= "1.2T" },
                new Modelo { Nome = "Tracker", Motor= "1.2T" },
                new Modelo { Nome = "Equinox", Motor= "2.0T" },
                new Modelo { Nome = "TrailBlazer", Motor= "2.0T" },
            };
            chevrolet.Nome = "CHEVROLET";

            return new ObservableCollection<Marca>() { fiat, chevrolet };
        }

        private void Lista01_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var modelos = Lista01.SelectedItems;

            StringBuilder sb = new StringBuilder();
            foreach (Modelo modelo in modelos)
            {
                sb.Append($" - {modelo.Nome}({modelo.Motor})");
            }

            LblModelosSelecionados.Text = sb.ToString();
        }
    }
}