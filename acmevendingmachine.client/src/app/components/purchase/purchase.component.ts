import { Component } from '@angular/core';

@Component({
  selector: 'app-purchase',
  templateUrl: './purchase.component.html',
  styleUrl: './purchase.component.css',
})
export class PurchaseComponent {
  selectedCurrency: string = '';
  tenderedAmount: number = 0;

  onPurchase() {
    console.log(
      `Tender Amount: ${this.tenderedAmount}, Selected Currency: ${this.selectedCurrency}`
    );
  }
}
