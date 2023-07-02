import { Injectable } from '@angular/core';
import { PaymentDetail } from './payment-details.model';

@Injectable({
  providedIn: 'root',
})
export class PaymentDetailService {
  constructor() {}

  formData: PaymentDetail = new PaymentDetail();
}
