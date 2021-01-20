import { Time } from '@angular/common';
import { Component, OnDestroy, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { Update } from '../classes/Update';
import { Users } from '../classes/Users';
import { UpdatesService } from '../updates.service';
import { UserService } from '../user.service';

@Component({
  selector: 'app-updates',
  templateUrl: './updates.component.html',
  styleUrls: ['./updates.component.css']
})
export class UpdatesComponent implements OnInit {
  
  form = this.fb.group({
    codeStore: this.fb.control('', [Validators.required]),
    codeWorker:  this.fb.control('', [Validators.required]),
    dateVisit:this.fb.control('', [Validators.required]),
    begginingTime:this.fb.control('', [Validators.required]),
    exitingTime:this.fb.control('', [Validators.required]),
    remarks:this.fb.control('', [Validators.required]),
  });

  constructor(private fb: FormBuilder,private serviceU:UpdatesService,private serviceUser:UserService) { }
dateEntry:Date;
dateExit:Date;
  testResult: string;
  choiceTest: string[] = ['excelent', 'improvement Required', 'bad'];
  y:string=localStorage.getItem("userCurrent");
   user:Users[];
   userCurrent:Users

  ngOnInit() {
    // this.serviceUser.getUsers().subscribe(u=>{this.user=u;});
    // this.serviceUser.getUsers().subscribe(x=>{
    //   this.user=x;
    //  });
  this.serviceUser.getUsers().subscribe(u=>
  this.userCurrent=u.find(x=>x.userPassword===this.y));
  console.log("1="+this.y);
  console.log(this.userCurrent);
  }
  btnEntry()
  {
    this.dateEntry=new Date();
    this.form.value.begginingTime=this.dateEntry;
    this.form.value.dateEntry=new Date();
    
  }
  btnExit(){
    this.dateExit=new Date();
    this.form.value.exitingTime=this.dateExit;

console.log(this.form.value);
  
  }
  create(){
    const update = <Update> this.form.value;
    this.serviceU.createUpdate(update).subscribe(x=>{
     
    })
}
}
