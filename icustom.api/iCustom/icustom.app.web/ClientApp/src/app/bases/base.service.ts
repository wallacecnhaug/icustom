import { HttpClient, HttpHeaders } from "@angular/common/http";
import { OnInit } from "@angular/core";
import { Constantes } from "../helpers/Constantes";

export class BaseService implements OnInit {

  constructor(
    protected _http: HttpClient,
    protected _constantes: Constantes) {
  }

  ngOnInit(): void {
  }

  public get storage(): Storage {

    let _storage = (this.manterConectado ? localStorage : sessionStorage);

    return _storage;
  }

  public get manterConectado(): boolean {
    return localStorage.getItem("manterConectado") == "1";
  }

  public set manterConectado(value: boolean) {
    localStorage.setItem("manterConectado", value ? "1" : "0");
  }

  public get token(): string {
    return (this.storage.getItem("tokenAutenticado") ? this.storage.getItem("tokenAutenticado") : "");
  }

  public set token(value: string) {
    this.storage.setItem("tokenAutenticado", value);
  }

  protected base_URL = this._constantes.URL_API;
  protected headers: HttpHeaders =
    new HttpHeaders({
      'Accept': 'application/json',
      'Content-Type': 'application/json',
      'Authorization': 'Bearer ' + this.token
    });

  protected ObterToken(): string {
    return sessionStorage.getItem("")
  }

  public Get(_url: string, _params?: any): any {

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
