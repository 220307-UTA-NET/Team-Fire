import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import {FormGroup, FormBuilder} from "@angular/forms"
import { Router } from '@angular/router';
import { ApiService} from '../shared/api.service'
@Component({
  selector: 'app-signup',
  templateUrl: './signup.component.html',
  styleUrls: ['./signup.component.css']
})
export class SignupComponent implements OnInit {

  public signupForm !:FormGroup;
  signupObj: any;

  constructor(private formBuilder: FormBuilder, private http : HttpClient, private router:Router, private api: ApiService) { }

  ngOnInit(): void {
    this.signupForm=this.formBuilder.group({
      customerFirstName:[''],
      customerLastName:[''],
      customerPWord:[''],
      customerAddress1:[''],
      customerAddress2:[''],
      customerCity:[''],
      customerStateAbb:[''],
      customerZip:[''],
      customerPhone:[''],
      customerEmail:['']
    })
  }

  signUp(){
  //   this.http.post<any>("http:/localhost:3000/sigupCustomers",this.signupForm.value)
  //   .subscribe(res=>{
  //     alert("Signup Successfull");
  //     this.signupForm.reset();
  //     this.router.navigate(['login']);
  //   },err=>{
  //     alert("Something went wrong")
  //   })
  this.signupObj.custtomerFirstName = this.signupForm.value.customerFirstName;
  this.signupObj.customerLastName = this.signupForm.value.customerLastName;
  this.signupObj.customerPWord = this.signupForm.value.customerPWord;
  this.signupObj.customerAddress1 = this.signupForm.value.customerAddress1;
  this.signupObj.customerAddress2 = this.signupForm.value.customerAddress2;
  this.signupObj.customerCity = this.signupForm.value.customerCity;
  this.signupObj.customerStateAbb = this.signupForm.value.customerStateAbb;
  this.signupObj.customerZip = this.signupForm.value.customerZip;
  this.signupObj.customerPhone = this.signupForm.value.customerPhone;
  this.signupObj.customerEmail = this.signupForm.value.customerEmail;
  this.api.signUp(this.signupForm.value)
  .subscribe(res=>{
    alert(res.message)
  })
 }
}
