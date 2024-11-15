using System;
using Adapter;

var nightClub = new Club();
var adult = new Adult("Jan", 33);
var fakeAdult = new FakeAdult("Michał", 15);

nightClub.Party(adult);
nightClub.Party(fakeAdult);
Console.ReadLine();