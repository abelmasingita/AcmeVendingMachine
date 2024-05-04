import { Component } from '@angular/core';
import { IProduct } from '../../utils/Interfaces/IProduct';
import { HttpClient } from '@angular/common/http';
import { baseUrl } from '../../utils/url';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {
  products: IProduct[] = [];
  baseUrl = baseUrl;
  constructor(private http: HttpClient) {
    this.getProducts();
  }

  getProducts() {
    this.http.get<IProduct[]>(`${baseUrl}/api/Product/Product`).subscribe(
      (result) => {
        this.products = result;
      },
      (error) => {
        console.error(error);
      }
    );
  }
}
