import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { MatFormFieldModule } from '@angular/material/form-field';
import { RouterModule,Router } from '@angular/router';
import { Users } from '../classes/Users';
import { Worker } from '../classes/Worker';
import { GetServerService } from '../get-server.service';
import { UserService } from '../user.service';
import { WorkerService } from '../worker.service';

@Component({
  selector: 'app-entrance',
  templateUrl: './entrance.component.html',
  styleUrls: ['./entrance.component.css']
})
export class EntranceComponent implements OnInit {


  constructor(private service:WorkerService,private fb: FormBuilder,private router:Router) { }
  form = this.fb.group({
    userUserName: this.fb.control('', [Validators.required]),
    userPassword: this.fb.control('', [Validators.required]),
    });
  hide = true;

  ngOnInit() {
  }
  myWorker:Worker;
  flag:boolean=false;
    searchuser(){
    const Worker = <Worker> this.form.value;
    this.service.getWorker()
    .subscribe(t=>{
      this.myWorker=t.find(y=>y.nameWorker==Worker.nameWorker
         &&y.codeWorker==Worker.codeWorker
        );
      if(this.myWorker===undefined){
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