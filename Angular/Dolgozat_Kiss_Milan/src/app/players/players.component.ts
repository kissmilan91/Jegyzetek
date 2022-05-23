import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-players',
  templateUrl: './players.component.html',
  styleUrls: ['./players.component.css']
})
export class PlayersComponent implements OnInit {

  public players = [
    {
      name : "Michael Schumacher",
      url : "schumacher.jpg"
    },
    {
      name : "Alberto Ascari",
      url : "ascari.jpg"
    },
    {
      name : "Juan Manuel Fangio",
      url : "fangio.jpg"
    },
    {
      name : "Emerson Fittipaldi",
      url : "fittipaldi.jpg"
    },
    {
      name : "Mika Hakkinen",
      url : "hakkinen.jpg"
    },
    {
      name : "Alain Prost",
      url : "prost.jpg"
    },
    {
      name : "Keke Rosberg",
      url : "kekerosberg.jpg"
    },
    {
      name : "Jackie Stewart",
      url : "stewart.jpg"
    }
  ];

  constructor() { }

  ngOnInit(): void {
  }

}
