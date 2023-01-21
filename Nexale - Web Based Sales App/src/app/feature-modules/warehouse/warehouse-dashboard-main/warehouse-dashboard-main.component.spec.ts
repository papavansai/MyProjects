import { ComponentFixture, TestBed } from '@angular/core/testing';

import { WarehouseDashboardMainComponent } from './warehouse-dashboard-main.component';

describe('WarehouseDashboardMainComponent', () => {
  let component: WarehouseDashboardMainComponent;
  let fixture: ComponentFixture<WarehouseDashboardMainComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ WarehouseDashboardMainComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(WarehouseDashboardMainComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
