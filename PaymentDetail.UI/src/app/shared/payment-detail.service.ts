import { Injectable } from '@angular/core';
import { PaymentDetail } from './payment-details.model';
import {HttpClient} from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class PaymentDetailService {

  constructor(private httpRequest:HttpClient) { }

  formData: PaymentDetail = new PaymentDetail();
  readonly baseURL = 'https://localhost:44381/api/PaymentDetail';

  postPaymentDetail(){
    return this.httpRequest.post(this.baseURL, this.formData);
  }
  
}
