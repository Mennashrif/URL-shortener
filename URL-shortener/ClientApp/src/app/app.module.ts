import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule, Routes } from '@angular/router';

import { AppComponent } from './app.component';
import { ApiAuthorizationModule } from 'src/api-authorization/api-authorization.module';
import { AuthorizeGuard } from 'src/api-authorization/authorize.guard';
import { AuthorizeInterceptor } from 'src/api-authorization/authorize.interceptor';
import { HeaderComponent } from './header/header.component';
import { SectionComponent } from './section/section.component';
import { RedirComponent } from './redir/redir.component';


@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    SectionComponent,

  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    ApiAuthorizationModule,
    RouterModule.forRoot([

      {
        path: '',
        component: SectionComponent
      },

      {
        path: ':shortUrl',
        canActivate: [RedirComponent],
        component: RedirComponent,
        
      },

    ])
  ],
  providers: [
    { provide: HTTP_INTERCEPTORS, useClass: AuthorizeInterceptor, multi: true },
    RedirComponent
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
