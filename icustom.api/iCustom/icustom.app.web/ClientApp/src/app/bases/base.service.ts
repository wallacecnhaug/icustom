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

  protected base_URL = this._constantes.URL_API;
  protected headers: HttpHeaders =
    new HttpHeaders({
      'Accept': 'application/json',
      'Content-Type': 'application/json'
    });

  public get tokenAutenticado(): string {
    return (sessionStorage.getItem("tokenAutenticado") ? sessionStorage.getItem("tokenAutenticado") : "");
  }
  public set tokenAutenticado(value: string) {
    sessionStorage.setItem("tokenAutenticado", value);
  }

  public Get(_url: string, _params: any): any {
    return this._http
      .get<any>(
        this._constantes.URL_API + _url, { headers: this.headers, params: _params });
  }

  public Post(url: string, body: any): any {
    return this._http
      .post<any>(
        this.base_URL + url,
        body,
        { headers: this.headers });
  }

}
