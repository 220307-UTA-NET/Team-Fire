import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HeroesComponent } from './heroes/heroes.component';
import { HttpClientModule } from '@angular/common/http';
import { HistoryComponent } from './history/history.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { NgMaterialModule } from './ng-material/ng-material.module';
import { ButtonsComponent } from './buttons/buttons.component';
import { CardLookupComponent } from './card-lookup/card-lookup.component';
import { OrderComponent } from './order/order.component';
import { LogoutComponent } from './logout/logout.component';
import { RouterModule } from '@angular/router';
import { LogoComponent } from './logo/logo.component';
import { ReactiveFormsModule } from '@angular/forms';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { CommonModule, JsonPipe } from '@angular/common';

@NgModule({
  declarations: [
    AppComponent,
    HeroesComponent,
    HistoryComponent,
    ButtonsComponent,
    CardLookupComponent,
    OrderComponent,
    LogoutComponent,
    LogoComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    AppRoutingModule,
    NgMaterialModule,
    BrowserAnimationsModule,
    ReactiveFormsModule,
    CommonModule,
    RouterModule.forRoot([{path: 'order', component: OrderComponent},{path: 'logout', component: LogoutComponent},{path: 'cardLookup', component: CardLookupComponent}
  ])
  ],
  providers: [
    {provide: JsonPipe},
  ],
  bootstrap: [AppComponent],
  exports:[
    CommonModule, JsonPipe
  ],

})
export class AppModule { }
@Injectable()
export class ConfigService {
  constructor(private http: HttpClient) { }
}