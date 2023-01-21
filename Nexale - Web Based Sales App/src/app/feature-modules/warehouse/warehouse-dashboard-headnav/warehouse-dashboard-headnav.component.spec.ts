import { ComponentFixture, TestBed } from '@angular/core/testing';

import { WarehouseDashboardHeadnavComponent } from './warehouse-dashboard-headnav.component';

describe('WarehouseDashboardHeadnavComponent', () => {
  let component: WarehouseDashboardHeadnavComponent;
  let fixture: ComponentFixture<WarehouseDashboardHeadnavComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ WarehouseDashboardHeadnavComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(WarehouseDashboardHeadnavComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
