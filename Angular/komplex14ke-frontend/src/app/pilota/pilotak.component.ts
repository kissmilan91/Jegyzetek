import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { SelectItem } from 'primeng/api';
import { PilotaModel } from '../models/pilota.model';
import { PilotaService } from '../services/pilota.service';


@Component({
  selector: 'app-pilotak',
  templateUrl: './pilotak.component.html',
  styleUrls: ['./pilotak.component.css']
})
export class PilotakComponent implements OnInit {

  public pilotak : PilotaModel[] = [];
  public query :string = "";
  public sortField = "magassag";
  public sortOrder:number = 1;
  public sortOptions: SelectItem[] = [
    {label: 'Csökkenő magasság szerint', value: '!magassag'},
    {label: 'Növekvő magasság szerint', value: 'magassag'},
    {label: 'Névsor szerint', value: 'nev'},
    {label: 'Születési dátum szerint', value: ''},
  ];

  constructor(private route:ActivatedRoute, private _router: Router, private pilotaszerviz:PilotaService) { 

    this.route.queryParams.subscribe(params => {
      this.query = params["query"];

      this.pilotaszerviz.getPilotak(this.query).subscribe(adatok => {
        this.pilotak = adatok;

        //this.pilotak[7].csapat.nemzet = "valami";
      });
    });
  }

  ngOnInit(): void {
    
  }

  onSortChange(event:any) {
    let value = event.value;

    if (value.indexOf('!') === 0) {
        this.sortOrder = -1;
        this.sortField = value.substring(1, value.length);
    }
    else {
        this.sortOrder = 1;
        this.sortField = value;
    }
}

  kereses() {
    this.frissitesEsemeny();
  }

  PilotaTorlese(model:PilotaModel) {
    this.pilotaszerviz.deletePilota(model).subscribe(() => {
      this.frissitesEsemeny();
    });
  }

  frissitesEsemeny() {
    this.pilotaszerviz.getPilotak(this.query).subscribe(adatok => {
      this.pilotak = adatok;
      this._router.navigate([], {
        queryParams: {
          query: this.query
        },
        queryParamsHandling: 'merge',
      });

    });
  }

}
