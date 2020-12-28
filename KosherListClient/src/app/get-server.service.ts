import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Store } from './classes/Store';
import { Users } from './classes/Users';
import { Worker } from './classes/Worker';

@Injectable({
  providedIn: 'root'
})
export class GetServerService {

  constructor(private Http:HttpClient) { }

  getStores():Observable<Store[]>{
    return this.Http.get<Store[]>("http://localhost:43048/api/store/getAllStores");
  }
  
  
   createStore(newStore: Store):Observable<boolean>{
    return this.Http.post<boolean>("http://localhost:43048/api/store/AddStore",newStore);
  }
   postWorker(w:Worker)
  {
   return this.Http.post("http://localhost:43048/api/Worker",w)
  }

}
