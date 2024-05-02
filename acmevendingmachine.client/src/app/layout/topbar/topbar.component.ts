import { Component, OnInit } from '@angular/core';
import { MenuItem } from 'primeng/api';
@Component({
  selector: 'app-topbar',
  templateUrl: './topbar.component.html',
})
export class TopbarComponent implements OnInit {
  items: MenuItem[] | undefined;

  ngOnInit() {
    this.items = [
      { label: 'Home', routerLink: ['/home'] },
      { label: 'Products', routerLink: ['/products'] },
      { label: 'About', routerLink: ['/about'] },
    ];
  }
}
