import { Routes } from '@angular/router';
import { customerRoutes } from './features/components/customer';
import { LoginComponent } from './features/components/login/login.component';

export const appRoutes: Routes = [
  ...customerRoutes,
    { path: 'login', component: LoginComponent },
    { path: 'customer', redirectTo: '/customer', pathMatch: 'full' },
  ];