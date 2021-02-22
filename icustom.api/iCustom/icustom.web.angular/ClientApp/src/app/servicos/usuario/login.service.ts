import { HttpClient } from '@angular/common/http';
import { Injectable, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { BaseService } from '../../bases/base.service';
import { Constantes } from '../../helpers/Constantes';
import { LoginModel } from '../../models/login.model';

@Injectable()
export class LoginService extends BaseService implements OnInit {

  public get storage(): Storage {

    let _storage = (this.manterConectado ? localStorage : sessionStorage);

    return _storage;
  }

  constructor(
    protected _http: HttpClient,
    protected _constantes: Constantes) {

    super(_http, _constantes);
  }

  ngOnInit(): void {
  }

  public get token(): string {
    return (this.storage.getItem("tokenAutenticado") ? this.storage.getItem("tokenAutenticado") : "");
  }

  public set token(value: string) {
    this.storage.setItem("tokenAutenticado", value);
  }

  public autenticado(): boolean {
    return (this.loginAutenticado == "undefined" || this.loginAutenticado == null) ? false : true;
  }

  public get loginAutenticado(): string {
    return this.storage.getItem("loginAutenticado");
  }
  public set loginAutenticado(value: string) {
    this.storage.setItem("loginAutenticado", value);
  }

  public get manterConectado(): boolean {
    return localStorage.getItem("manterConectado") == "1";
  }

  public set manterConectado(value: boolean) {
    localStorage.setItem("manterConectado", value ? "1" : "0");
  }

  autenticar(loginModel: LoginModel): Observable<LoginModel> {
    //return this._http
    //  .post<LoginModel>(
    //    this.base_URL + "Usuario/Autenticar",
    //    loginModel,
    //    { headers: this.headers });

    return this.Post("Usuario/Autenticar", loginModel);

  }

}
