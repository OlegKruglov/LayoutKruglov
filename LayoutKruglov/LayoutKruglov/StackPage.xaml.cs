using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LayoutKruglov
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StackPage : ContentPage
    {
        public StackPage()
        {
            InitializeComponent();
        }
        int clik = 0;

        private void btn_Clicked(object sender, EventArgs e)
        {
            //btn.Text = "Try Again";
            clik = clik+1;
            btn.Text = clik.ToString();
            if (clik % 5 == 0)
            {
                lbl.IsVisible = false;
            }
            else
            {
                lbl.IsVisible = true;
            }
        }

        private void butn_Clicked(object sender, EventArgs e)
        {
            clik = 0;
            btn.Text = clik.ToString();
        }
    }
}