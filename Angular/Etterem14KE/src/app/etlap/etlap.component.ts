import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-etlap',
  templateUrl: './etlap.component.html',
  styleUrls: ['./etlap.component.css']
})
export class EtlapComponent implements OnInit {

  public Etelek = [
    {
      "Nev": "Újházi tyúkhúsleveles",
      "Leiras": "",
      "KepUrl": "/assets/leves.jpeg"
    },
    {
      "Nev": "Rántott sajt",
      "Leiras": "",
      "KepUrl": "/assets/rántottsajt.jpeg"
    },
    {
      "Nev": "Rántott karfiol",
      "Leiras": ""
    },
    {
      "Nev": "Rántott hús",
      "Leiras": "Nagy hús, akkor jó ha lelóg a tányérról",
      "KepUrl": "/assets/rántotthús.jpeg"
    },
    {
      "Nev": "Cigánypecsenye",
      "Leiras": ""
    },
    {
      "Nev": "Tökfőzelék",
      "Leiras": ""
    },
    {
      "Nev": "Brassói aprópecsenye",
      "Leiras": ""
    }
  ];


  constructor() { }

  ngOnInit(): void {
  }

}
