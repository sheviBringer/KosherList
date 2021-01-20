import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { LoginComponent } from './login/login.component';
import { RegisterComponent } from './register/register.component';
import { StoreComponent } from './store/store.component';
import { TimetableComponent } from './timetable/timetable.component';
import { UpdatesComponent } from './updates/updates.component';


const routes: Routes = [{
  path:"stores", component: StoreComponent},
{path:"register", component: RegisterComponent},
//  {path:"**", pathMatch:"full", redirectTo:"login"},
{path:"",component:LoginComponent},
{path:"login", component: LoginComponent},
{path:"timetable", component: TimetableComponent},
{path:"updates", component: UpdatesComponent},

// {path:"",  component: StoreComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
