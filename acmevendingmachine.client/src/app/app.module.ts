import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { MenubarModule } from 'primeng/menubar';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { TopbarComponent } from './layout/topbar/topbar.component';
import { FooterComponent } from './layout/footer/footer.component';

@NgModule({
  declarations: [AppComponent, TopbarComponent, FooterComponent],
  imports: [BrowserModule, HttpClientModule, AppRoutingModule, MenubarModule],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}
