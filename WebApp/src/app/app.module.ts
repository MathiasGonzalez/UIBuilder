import { BrowserModule } from '@angular/platform-browser';

import { MatButtonModule, MatCheckboxModule, MatDividerModule, MatListModule, MatIconModule } from '@angular/material';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { NgModule, NO_ERRORS_SCHEMA } from '@angular/core';

import { AppComponent } from './app.component';
import { CatalogRow } from './catalog-row/catalog-row';
import { Catalog } from './catalog/catalog';

@NgModule({
  declarations: [
    AppComponent,
    CatalogRow,
    Catalog
  ],
  imports: [
    BrowserAnimationsModule,
    BrowserModule,
    MatButtonModule,
    MatCheckboxModule,
    MatDividerModule,
    MatListModule,
    MatIconModule
  ],
  providers: [],
  bootstrap: [
    AppComponent
  ],
  schemas: [
    NO_ERRORS_SCHEMA
  ]
})
export class AppModule { }
