import { Component, OnInit } from '@angular/core';
import {First} from '../customer.model';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { HttpClient } from "@angular/common/http";

@Component({
  selector: 'app-customer-login',
  templateUrl: './customer-login.component.html',
  styleUrls: ['./customer-login.component.css']
})
export class CustomerLoginComponent implements OnInit {
  first:First =new First();
  customerloginForm: FormGroup;
    submitted = false; 
    constructor(private formBuilder: FormBuilder,private   http:HttpClient) { }

  

  ngOnInit() {
    this.customerloginForm = this.formBuilder.group({
    
      customerUserName: ['', Validators.required],
     
      customerPassword: ['', [Validators.required, Validators.minLength(6)]]

     
     
  });
  }
  

}
