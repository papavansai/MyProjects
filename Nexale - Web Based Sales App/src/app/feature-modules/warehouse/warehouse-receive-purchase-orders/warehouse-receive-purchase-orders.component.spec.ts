import { ComponentFixture, TestBed } from '@angular/core/testing';

import { WarehouseReceivePurchaseOrdersComponent } from './warehouse-receive-purchase-orders.component';

describe('WarehouseReceivePurchaseOrdersComponent', () => {
  let component: WarehouseReceivePurchaseOrdersComponent;
  let fixture: ComponentFixture<WarehouseReceivePurchaseOrdersComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ WarehouseReceivePurchaseOrdersComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(WarehouseReceivePurchaseOrdersComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
