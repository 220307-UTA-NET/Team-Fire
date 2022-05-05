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
    this.balance = '123456654321';
  }
  onSubmit(): void{
      this.balance = '654321123456';
      const configUrl = 'get/api/card/' + this.cardNum.value;
      const response = fetch(configUrl);
      this.balance= JSON.stringify(response); 
  }
  cardNum = new FormControl('');


}

export class cardSearch {
  cardNum = new FormControl('');
}
