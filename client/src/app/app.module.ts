import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {HttpClientModule} from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { NavComponent } from './nav/nav.component';
import { FormsModule } from '@angular/forms';
import { ButtonsModule } from 'ngx-bootstrap/buttons';

import { BsDropdownModule } from 'ngx-bootstrap/dropdown';
import { HomeComponent } from './home/home.component';
import { UploadComponent } from './upload/upload.component';
import { GamesComponent } from './games/games.component';
import { ProfileComponent } from './profile/profile.component';
import { GameComponent } from './game/game.component';

@NgModule({
  declarations: [
    AppComponent,
    NavComponent,
    HomeComponent,
    UploadComponent,
    GamesComponent,
    ProfileComponent,
    GameComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    BrowserAnimationsModule,
    FormsModule,
    BsDropdownModule.forRoot(),
    ButtonsModule.forRoot()
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
