import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { baseUrl } from '../../utils/url';
import { SharedService } from '../../services/shared.service';
import { IProduct } from '../../utils/Interfaces/IProduct';

@Component({
  selector: 'app-purchase',
  templateUrl: './purchase.component.html',
})
export class PurchaseComponent implements OnInit {
  selectedCurrency: string = 'USD'; //default to USD
  tenderedAmount: number = 0;
  purchaseAmount: number = 0;
  product: IProduct | undefined;
  baseUrl = baseUrl;
  change: any = [];
  showAlert: boolean = false;

  ngOnInit(): void {
    this.sharedService.currentProductDetails.subscribe(
      (product) => {
        this.product = product;
        this.purchaseAmount = product?.price;

        this.showAlert = true;
        // Hide the alert after 2 seconds
        setTimeout(() => {
          this.showAlert = false;
        }, 5000);
      },
      (error) => {
        console.error('Error receiving product details:', error);
      }
    );
  }
  constructor(private http: HttpClient, private sharedService: SharedService) {}

  getChange() {
    this.http
      .get(
        `${baseUrl}/api/VendingMachine/calculateChange?currency=${this.selectedCurrency}&purchaseAmount=${this.purchaseAmount}&tenderAmount=${this.tenderedAmount}`
      )
      .subscribe(
        (result) => {
          this.change = result;
        },
        (error) => {
          console.error(error);
        }
      );
  }
  onPurchase() {
    this.getChange();
  }

  parseFloat(num: string) {
    return parseFloat(num);
  }
}
