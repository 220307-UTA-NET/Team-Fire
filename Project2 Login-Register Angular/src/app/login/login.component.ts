import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import {FormBuilder, FormGroup} from "@angular/forms"
import { Router } from '@angular/router';
@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  public loginForm!: FormGroup
  constructor(private formBuilder : FormBuilder, private http : HttpClient, private router: Router) { }

  ngOnInit(): void {
    this.loginForm = this.formBuilder.group({
      customerFirstName:[''],
      customerLastName:[''],
      customerPWord:['']
    })
  }
  login(){
    this.http.get<any>("http://localhost:3000/singupCustomers")
    .subscribe(res=>{
      const customer = res.find((a:any) => {
        return a.customerFirstName === this.loginForm.value.customerFirstName &&
         a.customerLastName === this.loginForm.value.customerLastName &&
        a.customerPWord === this.loginForm.value.customerPWord       
    });
    if(customer){
      alert("Login Success!!");
      this.loginForm.reset();
      this.router.navigate(['dashboard'])
    }else{
      alert("Customer not found!")
    }
   },err=>{
    alert("Something went wrong!!")
  })
 }
}
