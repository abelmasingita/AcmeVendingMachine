import { Component, OnInit } from '@angular/core';
import { SharedService } from '../../services/shared.service';
@Component({
  selector: 'app-topbar',
  templateUrl: './topbar.component.html',
})
export class TopbarComponent implements OnInit {
  ngOnInit() {}

  constructor(private sharedService: SharedService) {}

  onSearch(event: any) {
    this.sharedService.changeSearchTerm(event.target.value);
  }
}
