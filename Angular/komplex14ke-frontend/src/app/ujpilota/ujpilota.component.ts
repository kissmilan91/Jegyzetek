import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { CsapatModel } from '../models/csapat.model';
import { PilotaModel } from '../models/pilota.model';
import { PilotaService } from '../services/pilota.service';

@Component({
  selector: 'app-ujpilota',
  templateUrl: './ujpilota.component.html',
  styleUrls: ['./ujpilota.component.css']
})
export class UjpilotaComponent implements OnInit {

  public pilota:PilotaModel = {
    ID: 0,
    nev: "Valaki János",
    szuletes: new Date("2022-02-01"),
    magassag: 180,
    nemzet : "",
    csapat : {
      ID : 1,
      nev : "",
      nemzet: ""
    }
  };

  @Output() frissitesEsemeny: EventEmitter<any> = new EventEmitter();

  public nemzetisegek : iNemzetiseg[] = [
    {name: "olasz", code: "olasz"},
    {name: "brit", code: "brit"},
    {name: "német", code: "nemet"},
  ]

  constructor(private pilotaservice:PilotaService) { }

  ngOnInit(): void {
  }

  ujpilota() {
    this.pilotaservice.insertPilota(this.pilota).subscribe( () => {
      this.frissitesEsemeny.emit();
    });
    
  }

}


interface iNemzetiseg {
  name: string,
  code: string
}