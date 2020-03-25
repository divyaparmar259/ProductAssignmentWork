import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import {CustomerComponent} from './customer/customer.component';
import {CustomerLoginComponent} from './customer-login/customer-login.component';
import {UserComponent} from './user/user.component';
import {UserLoginComponent} from './user-login/user-login.component';
import {ProductComponent} from './product/product.component';


const routes: Routes = [];

@NgModule({
  imports: [RouterModule.forRoot([
    {path:'customer',component:CustomerComponent},
    {path:'customer-login',component:CustomerLoginComponent},
    {path: 'user', component:UserComponent},
    {path: 'user-login',component:UserLoginComponent},
    {path: 'product', component:ProductComponent}
  ])],
  exports: [RouterModule]
})
export class AppRoutingModule { }
