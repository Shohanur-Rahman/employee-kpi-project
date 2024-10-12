import { HttpInterceptorFn } from '@angular/common/http';

export const apiHelperInterceptor: HttpInterceptorFn = (req, next) => {
  const token = localStorage.getItem("KPIMSWebApp");
  const request = req.clone({
    setHeaders: {
      Authorization: `Bearer ${token}`
    }
  });
  return next(request);
};
