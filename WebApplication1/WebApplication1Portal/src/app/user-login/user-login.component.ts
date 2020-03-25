import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import {User} from '../user.model';

@Component({
  selector: 'app-user-login',
  templateUrl: './user-login.component.html',
  styleUrls: ['./user-login.component.css']
})
export class UserLoginComponent implements OnInit {
  user:User =new User();
  userloginForm: FormGroup;
    submitted = false; 
    constructor(private formBuilder: FormBuilder) { }

  

  ngOnInit() {
    this.userloginForm = this.formBuilder.group({
    
      userName: ['', Validators.required],
     
      userPassword: ['', [Validators.required, Validators.minLength(6)]]

     
     
  });
  }

}
