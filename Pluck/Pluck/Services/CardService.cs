using Pluck.Enums;
using Pluck.Models;
using Xamarin.Forms;

namespace Pluck.Services
{
    class CardService : ICardService
    {
        public string GetCardName(Card card)
        {
            var cardName = "";
            switch (card.Suit.CardSuit)
            {
                #region Clubs
                case Suits.Club:
                    switch (card.Value)
                    {
                        case CardValues.Two:
                            cardName = "DuceOfClubs";
                            break;
                        case CardValues.Three:
                            cardName = "ThreeOfClubs";
                            break;
                        case CardValues.Four:
                            break;
                        case CardValues.Five:
                            break;
                        case CardValues.SIx:
                            break;
                        case CardValues.Seven:
                            break;
                        case CardValues.Eight:
                            break;
                        case CardValues.Nine:
                            break;
                        case CardValues.Ten:
                            break;
                        case CardValues.Jack:
                            break;
                        case CardValues.Queen:
                            break;
                        case CardValues.King:
                            break;
                        case CardValues.Ace:
                            break;
                        default:
                            break;
                    }
                    break;
                #endregion

                #region Diamonds
                case Suits.Diamond:
                    switch (card.Value)
                    {
                        case CardValues.Two:
                            break;
                        case CardValues.Three:
                            break;
                        case CardValues.Four:
                            break;
                        case CardValues.Five:
                            break;
                        case CardValues.SIx:
                            break;
                        case CardValues.Seven:
                            break;
                        case CardValues.Eight:
                            break;
                        case CardValues.Nine:
                            break;
                        case CardValues.Ten:
                            break;
                        case CardValues.Jack:
                            break;
                        case CardValues.Queen:
                            break;
                        case CardValues.King:
                            break;
                        case CardValues.Ace:
                            break;
                        default:
                            break;
                    }
                    break;
                #endregion

                #region Hearts
                case Suits.Heart:
                    switch (card.Value)
                    {
                        case CardValues.Two:
                            break;
                        case CardValues.Three:
                            break;
                        case CardValues.Four:
                            break;
                        case CardValues.Five:
                            break;
                        case CardValues.SIx:
                            break;
                        case CardValues.Seven:
                            break;
                        case CardValues.Eight:
                            break;
                        case CardValues.Nine:
                            break;
                        case CardValues.Ten:
                            break;
                        case CardValues.Jack:
                            break;
                        case CardValues.Queen:
                            break;
                        case CardValues.King:
                            break;
                        case CardValues.Ace:
                            break;
                        default:
                            break;
                    }
                    break;
                #endregion

                #region Spades
                case Suits.Spade:
                    switch (card.Value)
                    {
                        case CardValues.Two:
                            break;
                        case CardValues.Three:
                            break;
                        case CardValues.Four:
                            break;
                        case CardValues.Five:
                            break;
                        case CardValues.SIx:
                            break;
                        case CardValues.Seven:
                            break;
                        case CardValues.Eight:
                            break;
                        case CardValues.Nine:
                            break;
                        case CardValues.Ten:
                            break;
                        case CardValues.Jack:
                            break;
                        case CardValues.Queen:
                            break;
                        case CardValues.King:
                            break;
                        case CardValues.Ace:
                            break;
                        default:
                            break;
                    }
                    break;
                #endregion

                #region Jokkers
                case Suits.Joker:
                    switch (card.Value)
                    {
                        case CardValues.LittleJoker:
                            break;
                        case CardValues.BigJoker:
                            break;
                        default:
                            break;
                    }
                    break;
                #endregion
                
                default:
                    break;
            }
            return cardName;
        }
    }
}
