import { HttpClient } from '@angular/common/http';
import { Component, inject } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { Router } from '@angular/router';
import { jwtDecode } from 'jwt-decode';
import { ApiService } from '../../../../services/api.service';

@Component({
  selector: 'app-login',
  standalone: true,
  imports: [FormsModule],
  templateUrl: './login.component.html',
  styleUrl: './login.component.css'
})
export class LoginComponent {

  loginModel: any = {
    email: "",
    password: "",
    isRemember: false
  }

  errorMessage = "";

  constructor(
    private _apiService: ApiService,
    private _router: Router
  ) { }


  onLogin() {
    this.errorMessage = "";
    this._apiService.postData(`accounts/signin`, this.loginModel)
      .subscribe(
        (result: any) => {
          if (result.succeeded) {
            localStorage.setItem("KPIMSWebApp", result.result);
            this._router.navigateByUrl("");
          } else {
            this.errorMessage = "Invalid credential!";
          }
        },
        (error) => {
          this.errorMessage = "Invalid credential!";
          console.error("HTTP Error:", error);
        }
      )
  }
}
