import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CatalogRow } from './catalog-row';

describe('CatalogRow', () => {
  let component: CatalogRow;
  let fixture: ComponentFixture<CatalogRow>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CatalogRow ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CatalogRow);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
