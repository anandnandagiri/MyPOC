import { Component, OnInit, OnDestroy  } from '@angular/core';
import { ProductService } from './product.service';
import { Product } from './product.entities';

@Component({
    selector: 'mp-product',
    templateUrl: 'app/product/product.html',
    styleUrls: ['app/app.bootstrap.min.css'],
    providers: [ProductService]

})


export class ProductComponent implements OnInit, OnDestroy {
    pageTitle: string = "Product Page";
    products: Product[];
    oproduct: Promise<Product>;
    errorMessage: string;

    constructor(private _productService: ProductService)
    {
        //this.oproduct = { ProductID: 1, ProductName: 'pavan', UnitPrice: 0.00, CategoryID: 1, SupplierID: 1};
        //console.log('Constructor ' + this.oproduct.ProductName);
        //debugger;
    }

    ngOnInit() {
        this.oproduct = this._productService.GetOneProduct();
        this._productService.GetProductList().subscribe(po => this.products = po,err => this.errorMessage = <any>err);
        //this._productService.GetOneProduct().subscribe(pro => this.oproduct = pro, err => this.errorMessage = <any>err);
    }

    ngOnDestroy() {
        console.log('Error Message: ' + this.errorMessage);
    }

}