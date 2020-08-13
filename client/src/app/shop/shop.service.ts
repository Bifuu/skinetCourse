import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

import { IPagination } from '../shared/models/pagination';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class ShopService {
  baseUrl = 'https://localhost:5001/api/';

  constructor(private http: HttpClient) {}

  getProducts(): Observable<IPagination> {
    return this.http.get<IPagination>(this.baseUrl + 'products?pageSize=50');
  }
}
