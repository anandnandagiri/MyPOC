import { Directive, ElementRef, Input } from '@angular/core';

export class Product {
    public ProductID: number;
    @Input('ProductName') public ProductName: string;
    UnitPrice: any;
    CategoryID: any;
    SupplierID: any;
}
