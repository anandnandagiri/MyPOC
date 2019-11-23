import { Injectable } from '@angular/core';
import { Headers, Http, Response } from '@angular/http';
import 'rxjs/add/operator/toPromise';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/do';
import 'rxjs/add/operator/catch';

import { Observable } from 'rxjs/Observable';


import { Product } from './product.entities';

@Injectable()
export class ProductService {
    private productURL = 'http:///localhost:9000/api/Product/';  // URL to web api

    constructor(private http: Http) { }

    //With Observable Pattern
    GetProductList(): Observable<Product[]> {
        return this.http
            .get(this.productURL + 'GetProducts')
            .map((response: Response) => <Product[]>response.json().data)
            .do(data => console.log('All ' + JSON.stringify(data)));   
    }

    //With Promise
    GetOneProduct() {
        return this.http
            .get(this.productURL + 'GetOneProduct')
            .map((response: Response) => <Product>response.json().data)
            .toPromise();
            //.catch(this.handleError);            
    }

    private handleError(error: Response) {
        console.error(error);
        //let msg = `Error status code ${error.status} at ${error.url}`;
        //return Observable.throw(msg);
    }

}