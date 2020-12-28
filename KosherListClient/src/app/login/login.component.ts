import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { MatFormFieldModule } from '@angular/material/form-field';
import { RouterModule,Router } from '@angular/router';
import { Users } from '../classes/Users';
import { GetServerService } from '../get-server.service';
import { UserService } from '../user.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  constructor(private service:UserService,private fb: FormBuilder,private router:Router) { }
  form = this.fb.group({
    userUserName: this.fb.control('', [Validators.required]),
    userPassword: this.fb.control('', [Validators.required]),
    });
  hide = true;

  ngOnInit() {
  }
  myuser:Users;
  flag:boolean=false;
  ss:boolean=false;
    searchuser(){
    const User = <Users> this.form.value;
    this.service.getUsers()
    .subscribe(t=>{
      this.myuser=t.find(y=>y.userUserName==User.userUserName
         &&y.userPassword==User.userPassword
        );
      if(this.myuser===undefined){
        this.flag=true;
this.form.reset();
        // console.log(t);
        // console.log(User);
      }
      else{
        // console.log(t);
        // console.log(User);
        this.router.navigate(['/stores']);
      }
      
    });
    
  }
    register()
  {
console.log(this.router);
    this.router.navigate(['/register']);

  }
}