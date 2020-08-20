import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { IOrder } from 'src/app/shared/models/order';
import { BreadcrumbService } from 'xng-breadcrumb';
import { OrdersService } from '../orders.service';

@Component({
  selector: 'app-order-detail',
  templateUrl: './order-detail.component.html',
  styleUrls: ['./order-detail.component.scss'],
})
export class OrderDetailComponent implements OnInit {
  order: IOrder;

  constructor(
    private ordersService: OrdersService,
    private activatedRoute: ActivatedRoute,
    private bcService: BreadcrumbService
  ) {
    this.bcService.set('@orderDetails', '');
  }

  ngOnInit(): void {
    this.getOrder();
  }

  getOrder(): void {
    const id = +this.activatedRoute.snapshot.paramMap.get('id');
    this.ordersService.getOrder(id).subscribe(
      (order: IOrder) => {
        this.order = order;
        this.bcService.set('@orderDetails', `Order# ${id} - ${order.status}`);
      },
      (error) => {
        console.log(error);
      }
    );
  }
}
