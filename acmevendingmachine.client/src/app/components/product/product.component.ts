import { Component, OnInit, Output, Input, EventEmitter } from '@angular/core';
import { SharedService } from '../../services/shared.service';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
})
export class ProductComponent implements OnInit {
  @Input() imageUrl: string = '';
  @Input() name: string = '';
  @Input() price: string = '';
  @Input() quantity: string = '';
  @Input() id: string = '';
  currency: any;

  @Output() selected = new EventEmitter<void>();
  constructor(private sharedService: SharedService) {}

  ngOnInit(): void {
    this.sharedService.selectedCurrency.subscribe((currency) => {
      console.log('Currency ::', currency);
      this.currency = currency;
    });
  }

  selectProduct() {
    const productDetails = {
      imageUrl: this.imageUrl,
      name: this.name,
      price: this.price,
      quantity: this.quantity,
    };
    this.sharedService.changeProductDetails(productDetails);
    this.selected.emit();
  }
}
