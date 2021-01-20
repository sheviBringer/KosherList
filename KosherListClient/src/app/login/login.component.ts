import { Variable } from '@angular/compiler/src/render3/r3_ast';
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
  testObject:Variable;
  hide = true;

  ngOnInit() {
  }
  myuser:Users;
  flag:boolean;
  // ss:boolean=false;
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
        // this.testObject ={key:"this.form.value.userPassword", value:"Date 2017-02-03T08:38:04.449Z"};

        localStorage.setItem("userCurrent",this.form.value.userPassword );
        console.log(localStorage.getItem("userCurrent"))
        console.log(localStorage.getItem(this.form.value.userPassword));
          
        this.router.navigate(['/updates']);
      }
    
    });
    
  }
    register()
  {
console.log(this.router);
    this.router.navigate(['/register']);

  }
}