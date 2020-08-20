import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { OrdersComponent } from './orders.component';
import { OrderDetailComponent } from './order-detail/order-detail.component';
import { OrdersRoutingModule } from './orders-routing.module';

@NgModule({
  declarations: [OrdersComponent, OrderDetailComponent],
  imports: [CommonModule, OrdersRoutingModule],
})
export class OrdersModule {}
