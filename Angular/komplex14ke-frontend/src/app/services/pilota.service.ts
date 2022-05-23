import { HttpClient, HttpErrorResponse, HttpHeaders, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { firstValueFrom, lastValueFrom, Observable, throwError } from 'rxjs';
import { catchError, map, tap } from 'rxjs/operators';
import { PilotaModel } from '../models/pilota.model';

@Injectable({
  providedIn: 'root'
})
export class PilotaService {

  private token :string = "";

  constructor(private http: HttpClient) { 
      
    this.getToken().then( szerverről_érkezett_token=> {
      this.token = szerverről_érkezett_token;
      console.log("'"+this.token+"'");
    });

  }

  async getToken():Promise<string> {
    return firstValueFrom(await this.http.get("http://127.0.0.1:8000/api/csrf", {responseType: 'text'}));
  }

  insertPilota(p:PilotaModel):Observable<any> {
    let seged = {
      nev : p.nev,
      nemzet : p.nemzet, 
      szuletes: p.szuletes.getFullYear()+"-"+p.szuletes.getMonth()+"-"+p.szuletes.getDate(),
      magassag: p.magassag,
      csapat: p.csapat.ID
    }
    return this.http.post("http://127.0.0.1:8000/api/pilota", {params: {ujpilota:seged}});
  }

  getPilotak(query:string = ""):Observable<PilotaModel[]> {

    return this.http
        .get<any[]>("http://127.0.0.1:8000/api/pilotak", {params: {q:query}})
        .pipe(map(adatok_szerverről => {
                let válasz :PilotaModel[] = [];
                    
                adatok_szerverről.forEach(adat => {
                  válasz.push(new PilotaModel(adat))
                });
                return válasz;
              }));
  }

  deletePilota(model:PilotaModel):Observable<any> {
    
        let headers = new HttpHeaders(
          {
            "X-CSRF-TOKEN": this.token
          }
        );

        return this.http.delete('http://127.0.0.1:8000/api/pilota/'+model.ID, {headers})
                          .pipe(
                            catchError((error: HttpErrorResponse) => {
                              throw(new Error(error.message));
                            })
                          );
  }
  

}
