import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';

import { AppComponent } from './app.component';

import { AppRoutingModule, routedComponents } from './app.router';

@NgModule({
    imports: [BrowserModule, HttpModule, AppRoutingModule],
    declarations: [AppComponent, routedComponents ],
    bootstrap: [AppComponent]
})

export class AppModule { }
