import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { BasketService } from 'src/app/basket/basket.service';

@Component({
  selector: 'app-checkout-review',
  templateUrl: './checkout-review.component.html',
  styleUrls: ['./checkout-review.component.scss'],
})
export class CheckoutReviewComponent implements OnInit {
  constructor(
    private basketService: BasketService,
    private toastr: ToastrService
  ) {}

  ngOnInit(): void {}

  createPaymentIntent() {
    return this.basketService.createPaymentIntent().subscribe(
      (response: any) => {
        this.toastr.success('payment intent created');
      },
      (error) => {
        console.log(error);
        this.toastr.error(error.message);
      }
    );
  }
}
