import { Component } from '@angular/core';
import{ Constants } from './config/constants';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent{ 
  title = Constants.TitleOfSite; 
  constructor() { 
      console.log(Constants.API_ENDPOINT); 
  } 
  ngOnInit() { 
      console.log(this.title); 
  } 
} 