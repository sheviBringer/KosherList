import { Component, OnInit } from '@angular/core';
import { MatFormFieldModule } from '@angular/material/form-field';
import { Users } from '../classes/Users';
import { GetServerService } from '../get-server.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  constructor(private service:GetServerService) { }

  hide = true;

  ngOnInit() {
  }
  name:string;
  Password:string;
  myuser:Users;
  flag:boolean=false;


  searchuser(){
    this.service.getUsers()
    .subscribe(t=>{
      this.myuser=t.find(y=>y.userUserName==this.name&&y.userPassword==this.Password);
      if(this.myuser===undefined){
        this.flag=true;
      }
      else{
        // this.router.navigate(['/login']);
      }
      
    });
  }
  //   toRegister()
//   {
// this.router.navigate(['/register']);
//   }
}