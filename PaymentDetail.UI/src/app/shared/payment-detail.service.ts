import { Injectable } from '@angular/core';
import { PaymentDetail } from './payment-details.model';
import {HttpClient} from '@angular/common/http'; 

@Injectable({
  providedIn: 'root'
})
export class PaymentDetailService {
  
 
  constructor(private httpRequest:HttpClient,
    ) { }

  formData: PaymentDetail = new PaymentDetail();
  readonly baseURL = 'https://localhost:44381/api/PaymentDetail';
  listOfPayments?: PaymentDetail[] ;

  postPaymentDetail(){
     return this.httpRequest.post(this.baseURL, this.formData);
  }
  
  refreshList(){
    this.httpRequest.get(this.baseURL)
    .toPromise()
    .then(res => this.listOfPayments = res as PaymentDetail[]);
  }
 
  deletePaymentDetail(id: string){
    return this.httpRequest.delete(`${this.baseURL}/${id}`);
  }
}
