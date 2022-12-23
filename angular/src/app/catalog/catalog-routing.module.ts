import { PermissionGuard } from '@abp/ng.core';
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AttributeComponent } from './attribute/attribute.component';
import { ProductComponent } from './product/product.component';

const routes: Routes = [
  {
    path: 'product',
    component: ProductComponent,
    canActivate: [PermissionGuard],
    data: {
      requiredPolicy: 'remproAdminCatalog.Product',
    },
  },
  {
    path: 'attribute',
    component: AttributeComponent,
    canActivate: [PermissionGuard],
    data: {
      requiredPolicy: 'remproAdminCatalog.Attribute',
    },
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class CatalogRoutingModule {}
