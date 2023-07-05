import { Component } from '@angular/core';
import { PaymentDetailService } from '../../shared/payment-details.service';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-payment-details-form',
  templateUrl: './payment-details-form.component.html',
  styleUrls: [],
})
export class PaymentDetailsFormComponent {
  constructor(public service: PaymentDetailService) {}

  onSubmit(form: NgForm) {
    this.service.postPaymentDetail().subscribe((res) => {
      console.log(res),
        (err: any) => {
          console.log(err);
        };
    });
  }
}
