import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HomepageComponent } from './common-components/homepage/homepage.component';
import { LoginComponent } from './common-components/login/login.component';
import { RegisterComponent } from './common-components/register/register.component';
import { MaterialExampleModule } from '../feature-packages/angular-ui/material.module';
import { WorkingPageComponent } from './common-components/working-page/working-page.component';
import { HomeNavbarComponent } from './common-components/home-navbar/home-navbar.component';
import { HomeMasterComponent } from './common-components/home-master/home-master.component';

@NgModule({
  declarations: [
    AppComponent,
    HomepageComponent,
    LoginComponent,
    RegisterComponent,
    WorkingPageComponent,
    HomeNavbarComponent,
    HomeMasterComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MaterialExampleModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
