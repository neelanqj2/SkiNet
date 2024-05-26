import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HttpClientModule, provideHttpClient, withInterceptors } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavBarComponent } from './core/nav-bar/nav-bar.component';
import { CoreModule } from './core/core.module';
import { ShopModule } from './shop/shop.module';
import { ShopComponent } from './shop/shop.component';
import { HomeModule } from './home/home.module';
import { RouterModule } from '@angular/router';
import { errorInterceptor } from './core/interceptors/error.interceptor';
import { ToastrModule } from 'ngx-toastr';
import {BreadcrumbComponent, BreadcrumbItemDirective, BreadcrumbModule} from 'xng-breadcrumb';
import { loadingInterceptor } from './core/interceptors/loading.interceptor';


@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    HttpClientModule,
    CoreModule,
    HomeModule,
    BrowserAnimationsModule, // required animations module
    ToastrModule.forRoot({
      positionClass: 'toast-bottom-right'
    }) // ToastrModule added
  ],
  providers: [
    provideHttpClient(
      withInterceptors([errorInterceptor, loadingInterceptor])
    )],
  bootstrap: [AppComponent]
})
export class AppModule { }
