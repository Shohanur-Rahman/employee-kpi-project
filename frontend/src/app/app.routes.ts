import { Routes } from '@angular/router';
import { DesignationListComponent } from './components/designation/designation-list/designation-list.component';
import { LoginComponent } from './components/auth/login/login.component';
import { AuthLayoutComponent } from './components/auth/auth-layout/auth-layout.component';
import { MainLayoutComponent } from './components/main-layout/main-layout.component';
import { AppComponent } from './app.component';
import { DashboardComponent } from './components/dashboard/dashboard.component';

export const routes: Routes = [
    {
        path: 'account',
        component: AuthLayoutComponent,
        children: [
            {
                path: 'login',
                component: LoginComponent
            }
        ]
    },
    {
        path: '',
        component: MainLayoutComponent,
        children: [
            {
                path: "",
                component: DashboardComponent
            },
            {
                path: 'designations',
                component: DesignationListComponent
            }
        ]
    }
];