import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-admin',
  templateUrl: './admin.component.html',
  styleUrls: ['./admin.component.css']
})
export class AdminComponent implements OnInit {

  public HibaUzenet:string = "Kérlek, lépj be!";
  public hiba_On:Boolean = false;
  public username: string = "admin";
  public password: string = "12345";
  public szin: string = "blue";

  constructor() { }

  ngOnInit(): void {
  }

  kattintas() {
    this.hiba_On = false;
    if (this.username == "admin" && this.password == "12345") {
      alert("OK");
      this.szin = "lime";
    } else {
      this.HibaUzenet = "Nem megfelelő felhasználónév vagy jelszó!";
      this.hiba_On = true;
      this.szin = "red";
    }
  }

}


