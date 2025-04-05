using System;
namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        
        private void FlipButton_Clicked(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int sorteio = rnd.Next(2);

            if (selecaoPiker.SelectedIndex == 0 && sorteio == 0)
            {
                DisplayAlert("Você ganhou!", "Você escolheu cara e saiu cara!", "OK");
            }
            else
            {
                if (selecaoPiker.SelectedIndex == 1 && sorteio == 1)
                {
                    DisplayAlert("Você ganhou!", "Você escolheu coroa e saiu coroa!", "OK");
                }
               
            }



        }


    }

}
