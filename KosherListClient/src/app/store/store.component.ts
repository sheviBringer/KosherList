import { Component, OnChanges, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { MatRadioChange } from '@angular/material';
import { Store } from '../classes/Store';
import { GetServerService } from '../get-server.service';
import { StoreService } from '../store.service';

@Component({
  selector: 'app-store',
  templateUrl: './store.component.html',
  styleUrls: ['./store.component.css']
})
export class StoreComponent implements OnInit {
stores:Store[];
// typeStore:number[]=[1,2];
typeStoreString = ["יצור חיצוני",  "יצור פנימי"];
typeStoreNumber=[1,2];

form = this.fb.group({
  nameStore: this.fb.control('', [Validators.required]),
  addressStore:  this.fb.control('', [Validators.required]),
  clasificationStore:this.fb.control('', [Validators.required]),
  activityTimeStart:this.fb.control('', [Validators.required]),
  activityTimeEnd:this.fb.control('', [Validators.required]),
});


  constructor(  private fb: FormBuilder,private service:StoreService) { }
  ngOnInit() {
   
    // this.service.getStores().subscribe(x=>{
    //   this.stores=x;
    // })
  }
create(){
  const store = <Store> this.form.value;
  this.service.createStore(store).subscribe(x=>{
   
  })
}
ss(e: MatRadioChange, data:number)
{
  // console.log(e);
  // console.log(data);
this.form.value.clasificationStore=data;
 console.log(this.form);
// console.log(this.form.value);

};
}
