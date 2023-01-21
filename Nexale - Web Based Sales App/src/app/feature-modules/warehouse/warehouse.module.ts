import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { WarehouseRoutingModule } from './warehouse-routing.module';
import { WarehouseDashboardComponent } from './warehouse-dashboard/warehouse-dashboard.component';
import { WarehouseDashboardHeadnavComponent } from './warehouse-dashboard-headnav/warehouse-dashboard-headnav.component';
import { WarehouseDashboardSidenavComponent } from './warehouse-dashboard-sidenav/warehouse-dashboard-sidenav.component';
import { WarehouseProfileComponent } from './warehouse-profile/warehouse-profile.component';
import { WarehouseAddUpdateProductsComponent } from './warehouse-add-update-products/warehouse-add-update-products.component';
import { WarehouseReceivePurchaseOrdersComponent } from './warehouse-receive-purchase-orders/warehouse-receive-purchase-orders.component';
import { WarehouseProductCatalogComponent } from './warehouse-product-catalog/warehouse-product-catalog.component';
import { WarehouseDashboardMainComponent } from './warehouse-dashboard-main/warehouse-dashboard-main.component';


@NgModule({
  declarations: [
    WarehouseDashboardComponent,
    WarehouseDashboardHeadnavComponent,
    WarehouseDashboardSidenavComponent,
    WarehouseProfileComponent,
    WarehouseAddUpdateProductsComponent,
    WarehouseReceivePurchaseOrdersComponent,
    WarehouseProductCatalogComponent,
    WarehouseDashboardMainComponent
  ],
  imports: [
    CommonModule,
    WarehouseRoutingModule
  ]
})
export class WarehouseModule { }
