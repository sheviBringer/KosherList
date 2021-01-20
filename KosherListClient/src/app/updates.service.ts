import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Update } from './classes/Update';

@Injectable({
  providedIn: 'root'
})
export class UpdatesService {

  constructor(private Http:HttpClient) { }
  getUpdate():Observable<Update[]>{
    return this.Http.get<Update[]>("http://localhost:43048/api/update/getAllUpdate");
  }
  
   createUpdate(newUpdate: Update):Observable<boolean>{
    return this.Http.post<boolean>("http://localhost:43048/api/update/AddUpdate",newUpdate);
  }
}
