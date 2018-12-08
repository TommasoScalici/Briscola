using Briscola.DataModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Briscola
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GamePage : ContentPage
    {
        Game game;
        Image[] userImageCards;

        public GamePage()
        {
            InitializeComponent();

            game = new Game();
            userImageCards = new Image[] { yourCard1, yourCard2, yourCard3 };
            UpdateGame();
        }


        void UpdateGame()
        {
            opponentCard1.BindingContext = game.Player2.Hand[0];
            opponentCard2.BindingContext = game.Player2.Hand[1];
            opponentCard3.BindingContext = game.Player2.Hand[2];

            yourCard1.BindingContext = game.Player1.Hand[0];
            yourCard2.BindingContext = game.Player1.Hand[1];
            yourCard3.BindingContext = game.Player1.Hand[2];

            trumpCard.BindingContext = game.TrumpCard;

            deck.Source = opponentCard1.Source = opponentCard2.Source = opponentCard3.Source = ImageSource.FromFile("retro.png");
            trumpCard.Source = ImageSource.FromFile($"Siciliane_{game.TrumpCard.Suit.GetSuitItalianName()}{game.TrumpCard.Number}.png");

            foreach (var image in userImageCards)
                if (image.BindingContext is Card card)
                    image.Source = ImageSource.FromFile($"Siciliane_{card.Suit.GetSuitItalianName()}{card.Number}");
        }
    }
}
