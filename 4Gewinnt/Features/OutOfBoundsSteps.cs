﻿using _4Gewinnt.Model;
using FluentAssertions;
using System;
using TechTalk.SpecFlow;

namespace _4Gewinnt
{
    [Binding]
    public class OutOfBoundsSteps
    {
        Spiel _spiel;
        Spieler _spieler;
        Spielfeld _spielfeld;

        [Given(@"Column (.*) is all occupied")]
        public void GivenColumnIsAllOccupied(int p0)
        {
            _spiel = new Spiel(6, 7);
            _spieler = new Spieler();

            _spielfeld.feld[0, p0] = 2;
            _spielfeld.feld[1, p0] = 1;
            _spielfeld.feld[2, p0] = 2;
            _spielfeld.feld[3, p0] = 1;
            _spielfeld.feld[4, p0] = 2;
            _spielfeld.feld[5, p0] = 1;

        }
        [When(@"player (.*) chooses column (.*)")]
        public void WhenPlayerChoosesColumn(int p0, int p1)
        {
            _spieler.player2 = true;
            _spielfeld.FeldBesetzen(p1, _spieler);
        }

        [Then(@"out of bounds should be stopped")]
        public void ThenOutOfBoundsShouldBeStopped()
        {
            _spielfeld.outOfBounds.Should().BeTrue();
        }

        [Given(@"Spielsteine at the Corner")]
        public void GivenSpielsteineAtTheCorner()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"player (.*) set Spielstein on column (.*)")]
        public void WhenPlayerSetSpielsteinOnColumn(int p0, int p1)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"It should be player(.*) turn")]
        public void ThenItShouldBePlayerTurn(int p0)
        {
            ScenarioContext.Current.Pending();
        }


    }
}