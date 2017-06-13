using FunnyMonkey_Xamarin.forms.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FunnyMonkey_Xamarin.forms.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Pictures : ContentPage, INotifyPropertyChanged
    {
        public Pictures()
        {
            InitializeComponent();

            

            Lista = new List<Monkey>() {new Monkey() {Name = "Buzzu", Image = "https://upload.wikimedia.org/wikipedia/commons/8/85/Tamarin_portrait_2_edit3.jpg"},
                                       new Monkey() {Name = "Alfredo", Image = "https://yt3.ggpht.com/-_IXzYFNWU8U/AAAAAAAAAAI/AAAAAAAAAAA/6tXWVmD0E64/s900-c-k-no-mo-rj-c0xffffff/photo.jpg"},
                                       new Monkey() {Name = "Crush", Image = "https://i.ytimg.com/vi/PObLY87wyIU/maxresdefault.jpg"}};
            BindingContext = this;
        }
        public List<Monkey> Lista { get; set; }
        private int _position;
        public int Position { get { return _position; } set { _position = value; OnPropertyChanged(); } }

    }
}