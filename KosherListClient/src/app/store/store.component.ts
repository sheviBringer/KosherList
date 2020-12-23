import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { Store } from '../classes/Store';
import { GetServerService } from '../get-server.service';

@Component({
  selector: 'app-store',
  templateUrl: './store.component.html',
  styleUrls: ['./store.component.css']
})
export class StoreComponent implements OnInit {
stores:Store[];
form = this.fb.group({
  nameStore: this.fb.control('', [Validators.required]),
  });
  constructor(  private fb: FormBuilder,private service:GetServerService) { }

  ngOnInit() {
    this.service.getStores().subscribe(x=>{
      this.stores=x;
    })
  }
create(){
  const store = <Store> this.form.value;
  this.service.createStore(store).subscribe(x=>{
   
  })
}
}
