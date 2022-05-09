import { Component, OnInit } from '@angular/core';
import {TextFieldModule} from '@angular/cdk/text-field';
import  {MatInputModule} from '@angular/material/input';
import { FormBuilder, FormGroup, FormControl, Validators, ReactiveFormsModule} from '@angular/forms';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { HttpClientModule } from '@angular/common/http';
import { Observable } from 'rxjs/internal/Observable';
import { map } from 'rxjs/operators';
import { CommonModule, JsonPipe } from '@angular/common';
import { Renderer2, Inject } from '@angular/core';

declare function checkBalance(cardNum: any): string;

@Component({
  selector: 'app-card-lookup',
  templateUrl: './card-lookup.component.html',
  styleUrls: ['./card-lookup.component.css']
})
export class CardLookupComponent implements OnInit {

  constructor(
    private formBuilder: FormBuilder,
    private readonly http: HttpClient
  ) { }
  balance = '';
  ngOnInit(): void {
    this.balance = '';
  }
  async onSubmit(): Promise<void>{
      const configUrl = 'https://localhost:49181/api/Card/' + this.cardNum.value;
      try{
      const response = await fetch(configUrl);
      const data = await response.json();
      if (typeof data == 'string')
      {
        this.balance = 'Card not Found';
      }
      else
      {
        this.balance = JSON.stringify(data);
      }

    }catch (error){
      this.balance = 'Card not Found';
    }

  }
  cardNum = new FormControl('');


}

export class cardSearch {
  cardNum = new FormControl('');
}
