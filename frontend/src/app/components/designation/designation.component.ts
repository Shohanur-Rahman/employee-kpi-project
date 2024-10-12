import { HttpClient } from '@angular/common/http';
import { AfterViewInit, Component, inject, OnInit } from '@angular/core';
import { RouterModule } from '@angular/router';
import { ApiService } from '../../../services/api.service';
import { CommonModule } from '@angular/common';

declare var $: any;

@Component({
  selector: 'app-designation',
  standalone: true,
  imports: [RouterModule, CommonModule],
  templateUrl: './designation.component.html',
  styleUrl: './designation.component.css'
})
export class DesignationComponent implements AfterViewInit, OnInit {

  designations: any[] = [];

  constructor(private _apiService: ApiService) { }

  ngOnInit() {
    this.getDesignations();
  }

  ngAfterViewInit(): void {
    setTimeout(function () {
      $("#designationTable").DataTable();
    }, 1000);

  }

  _http = inject(HttpClient);

  getDesignations() {
    this._apiService.getData('designations')
      .subscribe((result: any) => {
        if (result.succeeded) {
          this.designations = result.result;
        }
      }, (error) => {
        console.error('Error fetching data', error);
      });
  }

}
