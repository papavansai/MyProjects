import { ComponentFixture, TestBed } from '@angular/core/testing';

import { WarehouseProductCatalogComponent } from './warehouse-product-catalog.component';

describe('WarehouseProductCatalogComponent', () => {
  let component: WarehouseProductCatalogComponent;
  let fixture: ComponentFixture<WarehouseProductCatalogComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ WarehouseProductCatalogComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(WarehouseProductCatalogComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
