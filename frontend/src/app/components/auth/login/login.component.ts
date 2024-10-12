import { HttpClient } from '@angular/common/http';
import { Component, inject } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { jwtDecode } from 'jwt-decode';

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

  http = inject(HttpClient);

  onLogin() {
    this.http.post(`http://gamivov425-001-site1.gtempurl.com/api/accounts/signin`, this.loginModel)
      .subscribe((result: any) => {
        console.log("Result => ", result)
        if (result.succeeded) {
          let loginInfo = jwtDecode(result.result);
          console.log("Info => ", loginInfo)
        }
      })
  }
}
