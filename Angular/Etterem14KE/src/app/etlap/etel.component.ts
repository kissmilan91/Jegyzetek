import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-etel',
  templateUrl: './etel.component.html',
  styleUrls: ['./etel.component.css']
})
export class EtelComponent implements OnInit {

  @Input() public EtelNeve:string;
  @Input() public EtelLeirasa:string;
  @Input() public Kep:any;

  constructor() { 
    this.EtelNeve = "lorem ipsum";
    this.EtelLeirasa = "lorem ipsum dolor sit amet";
  }

  ngOnInit(): void {
  }

}
