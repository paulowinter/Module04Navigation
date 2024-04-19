using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Module04Navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CarouselPage1 : CarouselPage
    {

        ObservableCollection<Hyungwon> hyungwons = new ObservableCollection<Hyungwon>();

        public ObservableCollection<Hyungwon> Hyungwons { get { return hyungwons; } }
        public CarouselPage1()
        {
            InitializeComponent();

            HyungwonView.ItemsSource = hyungwons;

            hyungwons.Add(new Hyungwon { DisplayName = "Hyungwon Selca 1", Image = "https://i.pinimg.com/736x/45/ff/3a/45ff3ac7147493c6c35ee1fed51c3d31.jpg" });
            hyungwons.Add(new Hyungwon { DisplayName = "Hyungwon Selca 2", Image = "https://i.pinimg.com/originals/15/db/9d/15db9d03af73c4d1b69dff982d7691a0.jpg" });
            hyungwons.Add(new Hyungwon { DisplayName = "Hyungwon Selca 3", Image = "https://i.pinimg.com/736x/d6/0c/64/d60c648f289a0f2df9fee4467b51a870.jpg" });
            hyungwons.Add(new Hyungwon { DisplayName = "Hyungwon Selca 4", Image = "https://i.pinimg.com/736x/e8/f7/c4/e8f7c47382c409da0018ce4162f75f4b.jpg" });
            hyungwons.Add(new Hyungwon { DisplayName = "Hyungwon Selca 5", Image = "https://i.pinimg.com/736x/57/82/8f/57828f0a04409d6614ad69ee94275719.jpg" });
        }
    }
}