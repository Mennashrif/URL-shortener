import { HttpClient, HttpHeaders } from '@angular/common/http';
import { error } from '@angular/compiler/src/util';
import { Component, Injectable, OnInit } from '@angular/core';
import { ActivatedRoute, ActivatedRouteSnapshot, CanActivate, RouterStateSnapshot, UrlTree } from '@angular/router';
import { SectionComponent } from '../section/section.component';
import { URL } from '../url'

@Injectable({
  providedIn: 'root',
})
export class RedirComponent implements CanActivate  {
  shortUrl = ""
  url = new URL;
  constructor(private route: ActivatedRoute, private http: HttpClient) { }
    canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): boolean {
      const httpOptions = {
        headers: new HttpHeaders({ 'Content-Type': 'application/json' })
      }
     
          this.url.shortUrl = window.location.href;
          this.http.post<any>('https://localhost:44392/api/Urls', JSON.stringify(this.url), httpOptions).subscribe(data => {
            window.location.href = data;
            return false;
          },
            error => {
              return false;
 
            })
        
      return false;
    }
    }

