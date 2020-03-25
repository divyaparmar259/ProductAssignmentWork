import { Component, OnInit } from '@angular/core';
import { Product}  from '../product.model';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})
export class ProductComponent implements OnInit {
  product :Product = new Product();
  productform :FormGroup;
  submitted = false; 
  constructor(private formBuilder: FormBuilder) { }

 ngOnInit() {
      this.productform = this.formBuilder.group({

        productName:['', Validators.required],
        productPrice:['', Validators.required],
        productQuantity:['', Validators.required]
      });
  }

  productAdd()
  {
    alert("Your Product is successfully added")
  }

}
