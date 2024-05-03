import { Component } from '@angular/core';
import { IProduct } from '../../utils/Interfaces/IProduct';
import { products } from '../../../assets/data/products';
import { SharedService } from '../../services/shared.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {
  products: IProduct[] = products;

  constructor(private sharedService: SharedService) {}

  onProductSelected() {
    //access the product details from the shared service
    this.sharedService.currentProductDetails.subscribe((product) => {
      //console.log(product);
    });
  }
}
