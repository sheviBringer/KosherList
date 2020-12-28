import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { RegisterComponent } from './register/register.component';
import { StoreComponent } from './store/store.component';


const routes: Routes = [{
  path:"stores", component: StoreComponent},
{path:"register", component: RegisterComponent},
// {path:"",  component: StoreComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
