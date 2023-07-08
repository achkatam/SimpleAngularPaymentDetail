import { Component } from '@angular/core';
import { NgForm } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { PaymentDetailService } from 'src/app/shared/payment-detail.service';
import { PaymentDetail } from 'src/app/shared/payment-details.model';

@Component({
  selector: 'app-payment-details-form',
  templateUrl: './payment-details-form.component.html',
  styleUrls: ['./payment-details-form.component.css'],
})
export class PaymentDetailsFormComponent {
  constructor(public service: PaymentDetailService,
    private toastr : ToastrService) {}

  onSubmit(form: NgForm) {
    this.insertData(form);
  }

  insertData(form: NgForm) {
    this.service.postPaymentDetail().subscribe(
      (res) => {
        this.resetForm(form);
        this.service.refreshList();
        this.toastr.success('Submitted successfully', 'Payment Detail Register');
      },
      (err) => {
        console.log(err);
        this.toastr.error('Error', 'Payment Detail Register');
      }
    );
  }
 

  resetForm(form: NgForm) {
    form.form.reset();
    this.service.formData = new PaymentDetail();
  }
  
}