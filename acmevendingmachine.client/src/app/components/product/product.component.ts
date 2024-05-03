import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrl: './product.component.css',
})
export class ProductComponent {
  @Input() imageUrl: string = '';
  @Input() name: string = '';
  @Input() price: string = '';
  @Input() quantity: string = '';
  @Input() id: string = '';
}
