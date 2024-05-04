import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class SharedService {
  //product details
  private productDetails = new BehaviorSubject<any>(null);
  currentProductDetails = this.productDetails.asObservable();

  //currency
  private currency = new BehaviorSubject<any>(null);
  currencyDetails = this.currency.asObservable();

  //search input
  private searchTerm = new BehaviorSubject<any>(null);
  currentSearchTerm = this.searchTerm.asObservable();

  constructor() {}

  changeProductDetails(product: any) {
    this.productDetails.next(product);
  }

  changeCurrency(curr: any) {
    this.currency.next(curr);
  }

  changeSearchTerm(term: string) {
    this.searchTerm.next(term);
  }
}
