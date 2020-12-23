import { Time } from '@angular/common';
import { Component, OnDestroy, OnInit } from '@angular/core';

@Component({
  selector: 'app-updates',
  templateUrl: './updates.component.html',
  styleUrls: ['./updates.component.css']
})
export class UpdatesComponent implements OnInit {

  constructor() { }
dateEntry:Date;
dateExit:Date;
  testResult: string;
  choiceTest: string[] = ['excelent', 'improvementRequired', 'bad'];

  ngOnInit() {
  }
  
  btnEntry()
  {
    this.dateEntry=new Date();
  }
  btnExit(){
    this.dateExit=new Date();
  
  }

}
