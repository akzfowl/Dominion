using Dominion.Cards.Hybrid;
using Dominion.Cards.Victory;
using Dominion.Rules;
using Dominion.Cards.Actions;

namespace Dominion.GameHost
{
    public class SimpleStartingConfiguration : StartingConfiguration
    {
        public SimpleStartingConfiguration(int numberOfPlayers) : base(numberOfPlayers)
        {}

        public override void InitializeBank(Dominion.Rules.CardBank bank)
        {            
            bank.AddCardPile(new LimitedSupplyCardPile().WithNewCards<SecretChamber>(10));
            bank.AddCardPile(new LimitedSupplyCardPile().WithNewCards<Moat>(10));
            bank.AddCardPile(new LimitedSupplyCardPile().WithNewCards<Mine>(10));
            bank.AddCardPile(new LimitedSupplyCardPile().WithNewCards<Market>(10));
            bank.AddCardPile(new LimitedSupplyCardPile().WithNewCards<Chancellor>(10));
            bank.AddCardPile(new LimitedSupplyCardPile().WithNewCards<Nobles>(10));
            bank.AddCardPile(new LimitedSupplyCardPile().WithNewCards<Militia>(10));
            bank.AddCardPile(new LimitedSupplyCardPile().WithNewCards<Village>(10));
            bank.AddCardPile(new LimitedSupplyCardPile().WithNewCards<ThroneRoom>(10));
            bank.AddCardPile(new LimitedSupplyCardPile().WithNewCards<Remodel>(10));
            base.InitializeBank(bank);
        }

    }
}
