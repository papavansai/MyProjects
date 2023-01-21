import { ComponentFixture, TestBed } from '@angular/core/testing';

import { WarehouseProfileComponent } from './warehouse-profile.component';

describe('WarehouseProfileComponent', () => {
  let component: WarehouseProfileComponent;
  let fixture: ComponentFixture<WarehouseProfileComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ WarehouseProfileComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(WarehouseProfileComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
