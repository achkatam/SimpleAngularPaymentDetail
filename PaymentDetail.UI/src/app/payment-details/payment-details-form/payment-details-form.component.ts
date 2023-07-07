import { Component } from '@angular/core';
import { NgForm } from '@angular/forms';
import { PaymentDetailService } from 'src/app/shared/payment-detail.service';

@Component({
  selector: 'app-payment-details-form',
  templateUrl: './payment-details-form.component.html',
  styleUrls: ['./payment-details-form.component.css']
})
export class PaymentDetailsFormComponent {
  
    constructor(public service: PaymentDetailService) {
    }
    
    onSubmit(form:NgForm){
      this.service.postPaymentDetail()
      .subscribe(
        res => {
          console.log(res);
        },
        err => {
          console.log(err);
        }
      )
    };
    
}
