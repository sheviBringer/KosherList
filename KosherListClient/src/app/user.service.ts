import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Users } from './classes/Users';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  constructor(private Http:HttpClient) { }

  getUsers():Observable<Users[]>{
    return this.Http.get<Users[]>("http://localhost:43048/api/users/getAllUsers");
   };
}
// api/users/getAllUsers