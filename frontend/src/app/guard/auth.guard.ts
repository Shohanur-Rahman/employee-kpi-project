import { inject } from '@angular/core';
import { CanActivateFn, Router } from '@angular/router';

export const authGuard: CanActivateFn = (route, state) => {
  const router = inject(Router);
  const token = localStorage.getItem("KPIMSWebApp");
  if(token != null)
    return true;

  router.navigateByUrl("account/login");
  return false;
};
