import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Worker } from '../classes/Worker';
import { GetServerService } from '../get-server.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {

  flagMail: boolean = false;
  constructor(private service: GetServerService, private http: HttpClient) { }

  ngOnInit() {
  }
  flag: any = false;
  worker: Worker = new Worker();
  

  flagUser: boolean;
  register() {
     if (this.worker.email.indexOf("@") > -1)

       this.flagMail = true;

    this.service.getWorker()
      .subscribe(t => {
       let workertmp:Worker = t.find(y => y.nameWorker == this.worker.nameWorker);
        if (workertmp === undefined && this.flagMail == true) {
          this.service.postWorker(this.worker)
          .subscribe(r => {
            if (r) { this.flag = true; }
            else { this.flag = false }
            alert(r);
            console.log(r);
          });
        }
        else {
          this.worker=workertmp;
          this.flagUser = true;
        }
      });

  }


}
