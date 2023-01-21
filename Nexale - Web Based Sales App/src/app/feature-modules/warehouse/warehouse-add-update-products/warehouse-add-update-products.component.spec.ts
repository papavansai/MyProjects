import { ComponentFixture, TestBed } from '@angular/core/testing';

import { WarehouseAddUpdateProductsComponent } from './warehouse-add-update-products.component';

describe('WarehouseAddUpdateProductsComponent', () => {
  let component: WarehouseAddUpdateProductsComponent;
  let fixture: ComponentFixture<WarehouseAddUpdateProductsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ WarehouseAddUpdateProductsComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(WarehouseAddUpdateProductsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
