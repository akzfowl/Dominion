// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.3.5.2
//      Runtime Version:4.0.30319.1
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
namespace Dominion.Specs.Cards
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.3.5.2")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("GhostShip")]
    public partial class GhostShipFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "GhostShip.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "GhostShip", "", ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Players are expected to put cards on their deck when Ghost Ship is played")]
        public virtual void PlayersAreExpectedToPutCardsOnTheirDeckWhenGhostShipIsPlayed()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Players are expected to put cards on their deck when Ghost Ship is played", ((string[])(null)));
#line 3
this.ScenarioSetup(scenarioInfo);
#line 4
testRunner.Given("A new game with 2 players");
#line 5
testRunner.And("Player1 has a GhostShip in hand instead of a Copper");
#line 6
testRunner.When("Player1 plays a GhostShip");
#line 7
testRunner.Then("Player1 should have 6 cards in hand");
#line 8
testRunner.And("Player2 must select 1 card to put on top of the deck");
#line 9
testRunner.When("Player2 selects a Copper to go on top");
#line 10
testRunner.Then("Player2 must select 1 card to put on top of the deck (again)");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Players put cards on top of their deck")]
        public virtual void PlayersPutCardsOnTopOfTheirDeck()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Players put cards on top of their deck", ((string[])(null)));
#line 12
this.ScenarioSetup(scenarioInfo);
#line 13
testRunner.Given("A new game with 2 players");
#line 14
testRunner.And("Player1 has a GhostShip in hand instead of a Copper");
#line 15
testRunner.And("Player2 has a hand of Copper, Copper, Copper, Copper, Copper");
#line 16
testRunner.And("Player2 has a deck of Estate, Estate, Estate, Estate, Estate");
#line 17
testRunner.When("Player1 plays a GhostShip");
#line 18
testRunner.And("Player2 selects a Copper to go on top");
#line 19
testRunner.And("Player2 selects a Copper to go on top (again)");
#line 20
testRunner.Then("All actions should be resolved");
#line 21
testRunner.And("Player2 should have a deck of: Copper, Copper, Estate, Estate, Estate, Estate, Es" +
                    "tate");
#line 22
testRunner.And("Player2 should have 3 cards in hand");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Ghost ship played twice via Throne Room")]
        public virtual void GhostShipPlayedTwiceViaThroneRoom()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Ghost ship played twice via Throne Room", ((string[])(null)));
#line 24
this.ScenarioSetup(scenarioInfo);
#line 25
testRunner.Given("A new game with 2 players");
#line 26
testRunner.And("Player1 has a GhostShip in hand instead of a Copper");
#line 27
testRunner.And("Player1 has a ThroneRoom in hand instead of a Copper");
#line 28
testRunner.When("Player1 plays a ThroneRoom");
#line 29
testRunner.And("Player1 selects a GhostShip to throne room");
#line 30
testRunner.And("Player2 selects a Copper to go on top");
#line 31
testRunner.And("Player2 selects a Copper to go on top (again)");
#line 32
testRunner.Then("All actions should be resolved");
#line 33
testRunner.And("Player1 should have 7 cards in hand");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Information on Ghost Ship effect")]
        [NUnit.Framework.CategoryAttribute("Hosted")]
        public virtual void InformationOnGhostShipEffect()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Information on Ghost Ship effect", new string[] {
                        "Hosted"});
#line 36
this.ScenarioSetup(scenarioInfo);
#line 37
testRunner.Given("A new hosted game with 2 players");
#line 38
testRunner.And("Player1 has a GhostShip in hand instead of a Copper");
#line 39
testRunner.When("The game begins");
#line 40
testRunner.And("Player1 tells the host to play GhostShip");
#line 41
testRunner.Then("Player2\'s current activity should have a type of SelectFixedNumberOfCards");
#line 42
testRunner.Then("Player2\'s current activity should have a hint of RedrawCards");
#line 43
testRunner.Then("Player2\'s current activity should have a source of GhostShip");
#line hidden
            testRunner.CollectScenarioErrors();
        }
    }
}
#endregion
