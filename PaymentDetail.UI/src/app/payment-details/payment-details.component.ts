import { Component, OnInit } from '@angular/core';
import { PaymentDetailService } from '../shared/payment-detail.service';
import { PaymentDetail } from '../shared/payment-details.model';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-payment-details',
  templateUrl: './payment-details.component.html',
  styleUrls: ['./payment-details.component.css'],
})
export class PaymentDetailsComponent implements OnInit {
  constructor(
    public service: PaymentDetailService,
    private toasrt: ToastrService
  ) {}
 
  
  ngOnInit(): void {
    this.service.refreshList();
  }

  populateForm(selectedRecordedData: PaymentDetail) {
    this.service.formData = Object.assign({}, selectedRecordedData);
  }

  onDelete(Id: string) {
    if (confirm('Are you sure to delete this record?')) {
      this.service.deletePaymentDetail(Id)
      .subscribe(
        (res) => {
          this.service.refreshList();
          this.toasrt.error('Deleted successfully', 'Payment Detail Register');
        });
    }
  }
}
