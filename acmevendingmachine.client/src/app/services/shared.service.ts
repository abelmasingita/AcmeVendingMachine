import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class SharedService {
  private productDetails = new BehaviorSubject<any>(null);
  currentProductDetails = this.productDetails.asObservable();

  constructor() {}

  changeProductDetails(product: any) {
    this.productDetails.next(product);
  }
}
