import { Component } from '@angular/core';
import { PaymentDetailService } from '../../shared/payment-details.service';

@Component({
  selector: 'app-payment-details-form',
  templateUrl: './payment-details-form.component.html',
  styleUrls: ['./payment-details-form.component.css'],
})
export class PaymentDetailsFormComponent {
  constructor(public service: PaymentDetailService) {}
}
