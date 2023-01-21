import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeMasterComponent } from './common-components/home-master/home-master.component';
import { HomepageComponent } from './common-components/homepage/homepage.component';
import { LoginComponent } from './common-components/login/login.component';
import { RegisterComponent } from './common-components/register/register.component';
import { WorkingPageComponent } from './common-components/working-page/working-page.component';

const routes: Routes = [
  { path: '', component: HomepageComponent },
  {path:'home', component: HomepageComponent},
  { path: 'login', component: LoginComponent},
  {path: 'register', component: RegisterComponent},
  {path:'stwn', component: WorkingPageComponent},
  { path:'admin', loadChildren : () => import('./feature-modules/admin/admin.module').then(a=>a.AdminModule) },
  { path: 'authorizer', loadChildren : () => import('./feature-modules/authorizer/authorizer.module').then( a => a.AuthorizerModule) },
  { path: 'distributer', loadChildren : () => import('./feature-modules/distributor/distributor.module').then(a => a.DistributorModule), canActivate : [] },
  { path: 'warehouse',  loadChildren : () => import('./feature-modules/warehouse/warehouse.module').then(a => a.WarehouseModule) },
];


@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
