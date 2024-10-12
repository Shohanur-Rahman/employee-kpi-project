import { Routes } from '@angular/router';
import { DesignationListComponent } from './components/designation/designation-list/designation-list.component';
import { LoginComponent } from './components/auth/login/login.component';

export const routes: Routes = [
    {
        path: "designations",
        component: DesignationListComponent
    },
    {
        path: "login",
        component: LoginComponent
    }
];
