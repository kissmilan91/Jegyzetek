import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { IndexComponent } from './index/index.component';
import { PlayersComponent } from './players/players.component';
import { RacesComponent } from './races/races.component';

const routes: Routes = [
  {path: "index", component: IndexComponent},
  {path: "versenyek", component: RacesComponent},
  {path: "versenyzok", component:PlayersComponent},
  {path: "csapatok", redirectTo: '/index'},
  {path: "hires", redirectTo: '/index'},
  { path: '**', component: IndexComponent},

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
