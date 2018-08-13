import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { Catalog } from './catalog';

describe('CatalogComponent', () => {
  let component: Catalog;
  let fixture: ComponentFixture<Catalog>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ Catalog ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(Catalog);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
