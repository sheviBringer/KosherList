import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Users } from './classes/Users';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class UserService {
  CurrentUser:Users;
  constructor(private Http:HttpClient) { }
// getCurrentUser(){
//   if(this.CurrentUser===null)
//   {return null}
//   else
//   return this.CurrentUser;
// };

saveCurrentUser(u:Users){
  this.CurrentUser=u;
};
  getUsers():Observable<Users[]>{
    return this.Http.get<Users[]>("http://localhost:43048/api/users/getAllUsers");
   };
}
// api/users/getAllUsers