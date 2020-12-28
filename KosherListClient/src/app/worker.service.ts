import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Worker } from './classes/Worker';

@Injectable({
  providedIn: 'root'
})
export class WorkerService {

  constructor(private Http:HttpClient) { }

  getWorker():Observable<Worker[]>{
    return this.Http.get<Worker[]>("http://localhost:43048/api/worker/getAllWorkers");
 
   };
   createWorker(newWorker: Worker):Observable<boolean>{
    return this.Http.post<boolean>("http://localhost:43048/api/worker/AddWorker",newWorker);
  }
}
