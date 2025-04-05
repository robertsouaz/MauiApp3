using System;
namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        // Assume que você tenha uma imagem chamada "cara.jpg" e "coroa.jpg" na pasta de recursos do seu projeto
        private Image MoedaImagem;

        private void FlipButton_Clicked(object sender, EventArgs e)
        {
            Random rnd = new Random(); //estaciar o objeto random
            int sorteio = rnd.Next(2); // sorteio 0 ou 1

            // Escolher a imagem com base no sorteio

            if (sorteio == 0)
            {
                MoedaImagem.Source = "cara.jpg"; // imagem cara
            }
            else
            {
                MoedaImagem.Source = "coroa.jpg"; // imagem coroa
            }

            // 0 = cara
            // 1 = coroa
            // selecaoPiker.SelectedIndex = 0 -> cara
            // selecaoPiker.SelectedIndex = 1 -> coroa
            // DisplayAlert -> exibe um alerta na tela
            // DisplayAlert("Título", "Mensagem", "Botão");
            // sorteio random 0 ou 1
            // rnd.Next(2) -> gera um número aleatório entre 0 e 1

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
