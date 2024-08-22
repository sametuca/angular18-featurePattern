import { Routes } from "@angular/router";
import { CustomerComponent } from "./customer.component";
import { AuthGuard } from "../../../../core/guard/auth.guard";

export const customerRoutes: Routes = [
  { path: 'customer', component: CustomerComponent, canActivate: [AuthGuard] },
];