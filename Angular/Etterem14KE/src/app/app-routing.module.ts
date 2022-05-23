import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AdminComponent } from './admin/admin.component';
import { EtlapComponent } from './etlap/etlap.component';
import { HelyszinComponent } from './helyszin/helyszin.component';

const routes: Routes = [
  {
     path: 'helyszin', component: HelyszinComponent
  },
  {
    path: 'admin', component: AdminComponent
  },
  {
    path: '**', component: EtlapComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
