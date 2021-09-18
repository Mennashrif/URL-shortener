import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { URL } from '../url'
@Component({
  selector: 'app-section',
  templateUrl: './section.component.html',
  styleUrls: ['./section.component.css']
})
export class SectionComponent {
  URl = "";
  UrlShortener = "";
  url = new URL;

  constructor(private http: HttpClient) {
  }
  onKeyUp() {
    this.url.longUrl = this.URl;

    const httpOptions = {
      headers: new HttpHeaders({ 'Content-Type': 'application/json' })
    }
    console.log(JSON.stringify( this.url));
    
    this.http.post<any>('https://localhost:44392/api/Urls', JSON.stringify(this.url) ,httpOptions).subscribe(data => {
      this.UrlShortener = data;
    })
    
  }
  

}
