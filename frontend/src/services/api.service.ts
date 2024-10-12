import { Injectable } from '@angular/core';
import { environment } from '../environments/environment';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class ApiService {

  private baseUrl = environment.apiBaseUrl;

  constructor(
    private _http: HttpClient

  ) {

  }

  getData(endpoint: string) {
    return this._http.get(`${this.baseUrl}/${endpoint}`);
  }

  postData(endpoint: string, data: any) {
    return this._http.post(`${this.baseUrl}/${endpoint}`, data);
  }

  putData(endpoint: string, data: any) {
    return this._http.put(`${this.baseUrl}/${endpoint}`, data);
  }

  deleteData(endpoint: string) {
    return this._http.delete(`${this.baseUrl}/${endpoint}`);
  }

}
