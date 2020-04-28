﻿using _4Gewinnt.Model;
using FluentAssertions;
using System;
using TechTalk.SpecFlow;

namespace _4Gewinnt.Features
{
    [Binding]
    public class SpielerSteps
    {
        Spieler _spieler;
        Spielfeld _spielfeld;
        Spielstein _spielstein;

        [When(@"I create a Spieler")]
        public void WhenICreateASpieler()
        {
            _spieler = new Spieler("blau");
            _spielfeld = new Spielfeld(7, 6);
            _spieler.player1 = true;
        }

        [Then(@"It's Spieler (.*) turn")]
        public void ThenItSSpielerTurn(int p0)
        {
            _spieler.player1.Should().BeTrue();
        }

        [Then(@"The color is on blau")]
        public void ThenTheColorIsOnBlau()
        {
            _spieler.farbe.Should().Be("blau");
        }

        [When(@"Spieler (.*) chooses the coloumn (.*) on Spielfeld")]
        public void WhenSpielerChoosesTheColoumnOnSpielfeld(int p0, int p1)
        {
            _spielfeld.FeldBesetzen(p1);
        }

        [Then(@"Spielstein should land on row (.*)")]
        public void ThenSpielsteinShouldLandOnRow(int p0)
        {
            _spielfeld.feld[4, p0].Should().Be(1);
        }


        [Given(@"It's Spieler (.*) turn")]
        public void GivenItSpielerTurn(int p0)
        {
            _spieler = new Spieler("blau");
            _spieler.player1 = true;
        }

        [When(@"I switch the player")]
        public void WhenISwitchThePlayer()
        {
            _spieler.SwitchPlayer();
        }

        [Then(@"It should be Player (.*) turn")]
        public void ThenItShouldBePlayerTurn(int p0)
        {
            _spieler.player2.Should().BeTrue();
        }

    }
}
