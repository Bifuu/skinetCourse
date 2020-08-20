import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from '../../environments/environment';
import { IOrder } from '../shared/models/order';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class OrdersService {
  baseUrl = environment.apiUrl;

  constructor(private http: HttpClient) {}

  getOrders(): Observable<IOrder[]> {
    return this.http.get<IOrder[]>(this.baseUrl + 'orders');
  }

  getOrder(id: number): Observable<IOrder> {
    return this.http.get<IOrder>(this.baseUrl + 'orders/' + id);
  }
}
