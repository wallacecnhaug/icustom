import { HttpClient, HttpHeaders } from "@angular/common/http";
import { OnInit } from "@angular/core";
import { Observable } from "rxjs";
import { Constantes } from "../helpers/Constantes";

export class BaseService implements OnInit {

  constructor(
    protected _http: HttpClient,
    protected _constantes: Constantes) {
  }

  ngOnInit(): void {
  }

  protected headers: HttpHeaders =
    new HttpHeaders({
      'Accept': 'application/json',
      'Content-Type': 'application/json'
    });

  public Post(_url: string, _body: any): Observable<Response> {
    return this._http
      .post<Response>(
        this._constantes.URL_API + _url, _body, { headers: this.headers });
  }

  public Get(_url: string, _params: any): Observable<Response> {
    return this._http
      .get<Response>(
        this._constantes.URL_API + _url, { headers: this.headers, params: _params });
  }

}
