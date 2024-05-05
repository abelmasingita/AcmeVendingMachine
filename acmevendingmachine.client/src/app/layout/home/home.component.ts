import { Component } from '@angular/core';
import { IProduct } from '../../utils/Interfaces/IProduct';
import { HttpClient } from '@angular/common/http';
import { baseUrl } from '../../utils/url';
import { SharedService } from '../../services/shared.service';
import { map } from 'rxjs';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {
  products: IProduct[] = [];
  baseUrl = baseUrl;

  constructor(private http: HttpClient, private sharedService: SharedService) {
    this.getProducts().subscribe((result) => {
      this.products = result;
    });

    this.sharedService.currentSearchTerm.subscribe((term) => {
      this.filterProducts(term);
    });
  }

  getProducts() {
    return this.http.get<IProduct[]>(`${baseUrl}/api/Product/Products`).pipe(
      map((result) => {
        return result;
      })
    );
  }

  //filter products based on search input
  filterProducts(searchTerm: string) {
    if (!searchTerm.trim()) {
      this.getProducts().subscribe((result) => {
        this.products = result;
      });
    } else {
      this.getProducts().subscribe((result) => {
        this.products = result.filter((product) =>
          product.name.toLowerCase().includes(searchTerm.toLowerCase())
        );
      });
    }
  }
}
