import { Component } from '@angular/core';
import { IProduct } from '../../utils/Interfaces/IProduct';
import { products } from '../../../assets/data/products';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {
  products: IProduct[] = products;
}
