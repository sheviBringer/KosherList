import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { Worker } from '../classes/Worker';
import { GetServerService } from '../get-server.service';
import { WorkerService } from '../worker.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {
  workers:Worker[];
  form = this.fb.group({
    nameWorker: this.fb.control('', [Validators.required]),
    addressWorker: this.fb.control('', [Validators.required]),
    telWorker: this.fb.control('', [Validators.required]),
    dateStart: this.fb.control('', [Validators.required]),
    email: this.fb.control('', [Validators.required]),
    mobility: this.fb.control('', [Validators.required]),
    
  });
  flagMail: boolean = false;
  constructor(private service: WorkerService, private http: HttpClient,private fb:FormBuilder) { }

  ngOnInit() {
  }
  flag: any = false;
  // worker: Worker = new Worker();
  
// if (this.worker.email.indexOf("@") > -1)
      //  this.flagMail = true;

  flagUser: boolean;
  register() {
    const worker = <Worker> this.form.value;
    this.service.createWorker(worker).subscribe(x=>{
     
    })};
     

    // this.service.getWorker()
    //   .subscribe(t => {
    //    let workertmp:Worker = t.find(y => y.nameWorker == this.worker.nameWorker);
    //     if (workertmp === undefined && this.flagMail == true) {
    //       this.service.postWorker(this.worker)
    //       .subscribe(r => {
    //         if (r) { this.flag = true; }
    //         else { this.flag = false }
    //         alert(r);
    //         console.log(r);
    //       });
        // }
        // else {
        //   this.worker=workertmp;
        //   this.flagUser = true;
        // }
      // });

  }
