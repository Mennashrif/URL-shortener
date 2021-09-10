import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { URL } from '../url'

@Component({
  selector: 'app-redir',
  templateUrl: './redir.component.html',
  styleUrls: ['./redir.component.css']
})
export class RedirComponent implements OnInit {
  shortUrl = ""
  url = new URL;
  constructor(private route: ActivatedRoute, private http: HttpClient) { }

  ngOnInit() {
    

    const httpOptions = {
      headers: new HttpHeaders({ 'Content-Type': 'application/json' })
    }
    this.route.paramMap
      .subscribe(params => {
        this.shortUrl = params.get("shortUrl");
        this.url.shortUrl = this.shortUrl;
        this.http.post<any>('https://localhost:44392/api/Urls', JSON.stringify(this.url), httpOptions).subscribe(data => {
          window.location.href = data;
          
        })
      })
    
  }

}
