import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { TopbarComponent } from './layout/topbar/topbar.component';
import { FooterComponent } from './layout/footer/footer.component';
import { HomeComponent } from './layout/home/home.component';
import { PurchaseComponent } from './components/purchase/purchase.component';
import { ProductComponent } from './components/product/product.component';
import { FormsModule } from '@angular/forms';
import { SharedService } from './services/shared.service';

@NgModule({
  declarations: [
    AppComponent,
    TopbarComponent,
    FooterComponent,
    HomeComponent,
    PurchaseComponent,
    ProductComponent,
  ],
  imports: [BrowserModule, HttpClientModule, AppRoutingModule, FormsModule],
  providers: [SharedService],
  bootstrap: [AppComponent],
})
export class AppModule {}
