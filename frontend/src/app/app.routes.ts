import { Routes } from '@angular/router';
import { LoginComponent } from './components/auth/login/login.component';
import { AuthLayoutComponent } from './components/auth/auth-layout/auth-layout.component';
import { MainLayoutComponent } from './components/main-layout/main-layout.component';
import { AppComponent } from './app.component';
import { DashboardComponent } from './components/dashboard/dashboard.component';
import { authGuard } from './guard/auth.guard';
import { DesignationComponent } from './components/designation/designation.component';

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
        canActivate: [authGuard],
        children: [
            {
                path: "",
                component: DashboardComponent
            },
            {
                path: 'designations',
                component: DesignationComponent
            }
        ]
    }
];