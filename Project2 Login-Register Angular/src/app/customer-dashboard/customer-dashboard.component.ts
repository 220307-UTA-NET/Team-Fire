import { Component, OnInit } from '@angular/core';
import {FormBuilder, FormGroup} from '@angular/forms'
import { createPublicKey } from 'crypto';
import {ApiService} from '../shared/api.service';
import {CustomerModel} from './customer-dashboard.model';
@Component({
  selector: 'app-customer-dashboard',
  templateUrl: './customer-dashboard.component.html',
  styleUrls: ['./customer-dashboard.component.css']
})
export class CustomerDashboardComponent implements OnInit {

  formValue !: FormGroup;
  customerModelObj: CustomerModel = new CustomerModel()
  customerData !: any;
  showAdd!: boolean;
  showUpdate !:boolean;
  api: any;
  constructor(private formbuilder: FormBuilder) { }

  ngOnInit(): void {
    this.formValue = this.formbuilder.group({
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
    this.getAllCustomer();
  }
  clickAddCustomer(){
    this.formValue.reset();
    this.showAdd = true;
    this.showUpdate = false;
  }
postCustomerDetails(){
  this.customerModelObj.customerFirstName = this.formValue.value.customerFirstName;
  this.customerModelObj.customerLastName = this.formValue.value.customerLastName;
  this.customerModelObj.customerPWord = this.formValue.value.customerPWord;
  this.customerModelObj.customerAddress1 = this.formValue.value.customerAddress1;
  this.customerModelObj.customerAddress2 = this.formValue.value.customerAddress2;
  this.customerModelObj.customerCity = this.formValue.value.customerCity;
  this.customerModelObj.customerStateAbb = this.formValue.value.customerStateAbb;
  this.customerModelObj.customerZip = this.formValue.value.customerZip;
  this.customerModelObj.customerPhone = this.formValue.value.customerPhone;
  this.customerModelObj.customerEmail = this.formValue.value.customerEmail;

  this.api.postCustomer(this.customerModelObj)
  .subscribe((res: any)=>{
    console.log(res);
    alert("Customer Added successfully")
    let ref = document.getElementById('cancel')
    ref?.click();
    this.formValue.reset();
    this.getAllCustomer();
  },
    (  err: any)=>{
    alert("Something went wrong")
  })
 }
 getAllCustomer(){
   this.api.getCustomer()
   .subscribe((res: any)=>{
     this.customerData = res;
   })
 }
 deleteCustomer(row : any){
   this.api.deleteEmployee(row.id)
   .subscribe((res: any)=>{
     alert("Customer Deleted");
     this.getAllCustomer();
   })
 }
 onEdit(row : any){
   
  this.showAdd = false;
  this.showUpdate = true;
   this.customerModelObj.customerId = row.customerId;
   this.formValue.controls['customerFirstName'].setValue(row.customerFirstName)
   this.formValue.controls['customerLastName'].setValue(row.customerLastName)
   this.formValue.controls['customerPWord'].setValue(row.customerPWord)
   this.formValue.controls['customerAddress1'].setValue(row.customerAddress1)
   this.formValue.controls['customerAddress2'].setValue(row.customerAddress2)
   this.formValue.controls['customerCity'].setValue(row.customerCity)
   this.formValue.controls['customerStateAbb'].setValue(row.customerStateAbb)
   this.formValue.controls['customerZip'].setValue(row.customerZip)
   this.formValue.controls['customerPhone'].setValue(row.customerPhone)
   this.formValue.controls['customerEmail '].setValue(row.customerEmail)
 }
 updateEmployeeDetails(){
  this.customerModelObj.customerFirstName = this.formValue.value.customerFirstName;
  this.customerModelObj.customerLastName = this.formValue.value.customerLastName;
  this.customerModelObj.customerPWord = this.formValue.value.customerPWord;
  this.customerModelObj.customerAddress1 = this.formValue.value.customerAddress1;
  this.customerModelObj.customerAddress2 = this.formValue.value.customerAddress2;
  this.customerModelObj.customerCity = this.formValue.value.customerCity;
  this.customerModelObj.customerStateAbb = this.formValue.value.customerStateAbb;
  this.customerModelObj.customerZip = this.formValue.value.customerZip;
  this.customerModelObj.customerPhone = this.formValue.value.customerPhone;
  this.customerModelObj.customerEmail = this.formValue.value.customerEmail;
  this.api.updateEmployee(this.customerModelObj)
  .subscribe((res: any)=>{
    alert("Updated Successfully");
    let ref = document.getElementById('cancel')
    ref?.click();
    this.formValue.reset();
    this.getAllCustomer();
  })
 }
}
