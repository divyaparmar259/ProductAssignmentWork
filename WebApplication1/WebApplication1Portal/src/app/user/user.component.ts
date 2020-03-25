import { Component, OnInit } from '@angular/core';
import {User} from '../user.model';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-user',
  templateUrl: './user.component.html',
  styleUrls: ['./user.component.css']
})
export class UserComponent implements OnInit {
  user:User=new User();
  userregisterForm: FormGroup;
    submitted = false; 

    constructor(private formBuilder: FormBuilder) { }
  ngOnInit() {
    this.userregisterForm = this.formBuilder.group({
    
      userFullName: ['', Validators.required],

      userName:['',Validators.required],
     
      userPassword: ['', [Validators.required, Validators.minLength(6)]],

    
      email: ['', [Validators.required, Validators.email]],
     
  });
  }
  onSubmit(formBuilder = this.userregisterForm) {
    this.submitted = true;
  //  this.http.post(this.rootURL+ '/CustomerAdd',formBuilder)
    // stop the process here if form is invalid
    if (this.userregisterForm.invalid) {
        return;
    }

    console.log(this.userregisterForm.value);
}

}
