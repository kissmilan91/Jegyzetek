import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { PilotaModel } from '../models/pilota.model';

@Component({
  selector: 'app-pilota',
  templateUrl: './pilota.component.html',
  styleUrls: ['./pilota.component.css']
})
export class PilotaComponent implements OnInit {

  @Input() pilota: PilotaModel | undefined;
  @Output() törlésEsemény: EventEmitter<any> 
                            = new EventEmitter();

  constructor() { }

  ngOnInit(): void {
  }

  torlesKattintas(){
    this.törlésEsemény.emit(this.pilota);
  }

}
