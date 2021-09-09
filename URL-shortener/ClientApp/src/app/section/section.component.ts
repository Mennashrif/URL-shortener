import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-section',
  templateUrl: './section.component.html',
  styleUrls: ['./section.component.css']
})
export class SectionComponent {
  URl = ""
  totalAngularPackages = []

  constructor(private http: HttpClient) { }
  onKeyUp() {
 
  }

}
