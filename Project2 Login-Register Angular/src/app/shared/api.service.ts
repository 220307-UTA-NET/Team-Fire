import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http'
import{map} from 'rxjs/operators'

@Injectable({
  providedIn: 'root'
})
export class ApiService {
    
  public loginAPIUrl : string = "https://localhost:44371/api/Login"  
  constructor(private http: HttpClient) { }

  PostCustomer(data : any) {
    return this.http.post<any>(`${this.loginAPIUrl}registerCustomer`,data)
    .pipe(map((res:any)=>{
        return res;
    }))
}

UpdateCustomer(data : any) {
    return this.http.put<any>(`${this.loginAPIUrl}updateCustomer`,data)
    .pipe(map((res:any)=>{
        return res;
    }))
}

DeleteCustomer(customerId : number) {
    return this.http.delete<any>(`${this.loginAPIUrl}deleteCustomer`+customerId)
    .pipe(map((res:any)=>{
        return res;
    }))
}

GetCustomers(){
    return this.http.get<any>(`${this.loginAPIUrl}getAllCustomers`)
    .pipe(map((res:any)=>{
        return res;
    }))
}

signUp(customerObj : any){
    return this.http.post<any>(`${this.loginAPIUrl}signup`,customerObj)

}
}
