using FunnyMonkey_Xamarin.forms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FunnyMonkey_Xamarin.forms.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Pictures : ContentPage
    {
        public Pictures()
        {
            InitializeComponent();

            var list = new List<Monkey>();
            var monkey1 = new Monkey();
            var monkey2 = new Monkey();
            var monkey3 = new Monkey();

            monkey1.Name = "Buzzu";
            monkey1.Image = "https://upload.wikimedia.org/wikipedia/commons/8/85/Tamarin_portrait_2_edit3.jpg";
            monkey2.Name = "Alfredo";
            monkey2.Image = "https://yt3.ggpht.com/-_IXzYFNWU8U/AAAAAAAAAAI/AAAAAAAAAAA/6tXWVmD0E64/s900-c-k-no-mo-rj-c0xffffff/photo.jpg";
            monkey3.Name = "Crush";
            monkey3.Image = "https://i.ytimg.com/vi/PObLY87wyIU/maxresdefault.jpg";

            list.Add(monkey1);
            list.Add(monkey2);
            list.Add(monkey3);

            Carousel.ItemsSource = list;
        }

    }
}