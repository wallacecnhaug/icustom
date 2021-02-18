import { HttpHeaders } from "@angular/common/http";
import { OnInit } from "@angular/core";

export class BaseService implements OnInit {

  constructor() {
  }

  ngOnInit(): void {
    //this.header = new HttpHeaders().set('content-type', 'application/json');
  }

  //public header: HttpHeaders;

  protected httpOptionsPlain = {
    headers: new HttpHeaders({
      'Accept': 'application/json',
      'Content-Type': 'application/json'
    })
  };

}
