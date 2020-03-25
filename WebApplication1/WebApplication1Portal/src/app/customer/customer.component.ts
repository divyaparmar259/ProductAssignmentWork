import { Component, OnInit } from '@angular/core';
import {First} from '../customer.model';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { HttpClient } from "@angular/common/http";

@Component({
  selector: 'app-customer',
  templateUrl: './customer.component.html',
  styleUrls: ['./customer.component.css']
})
export class CustomerComponent implements OnInit {

  first:First =new First();
    customerregisterForm: FormGroup;
    submitted = false; 
    readonly rootURL = "https://localhost:44388"
  constructor(private formBuilder: FormBuilder,private   http:HttpClient) { }


  ngOnInit() {
    this.customerregisterForm = this.formBuilder.group({
    
      customerName: ['', Validators.required],

      customerUserName:['',Validators.required],
     
      customerPassword: ['', [Validators.required, Validators.minLength(6)]],

    
      email: ['', [Validators.required, Validators.email]],
     
  });
  }
  onSubmit(formBuilder = this.customerregisterForm) {
    this.submitted = true;
    this.http.post(this.rootURL+ '/CustomerAdd',formBuilder)
    // stop the process here if form is invalid
    if (this.customerregisterForm.invalid) {
        return;
    }

    console.log(this.customerregisterForm.value);
}

}
