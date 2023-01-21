import { ComponentFixture, TestBed } from '@angular/core/testing';

import { WarehouseDashboardSidenavComponent } from './warehouse-dashboard-sidenav.component';

describe('WarehouseDashboardSidenavComponent', () => {
  let component: WarehouseDashboardSidenavComponent;
  let fixture: ComponentFixture<WarehouseDashboardSidenavComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ WarehouseDashboardSidenavComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(WarehouseDashboardSidenavComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
