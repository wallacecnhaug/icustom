import { HttpClient } from '@angular/common/http';
import { Injectable, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { BaseService } from '../../bases/base.service';
import { Constantes } from '../../helpers/Constantes';
import { LoginModel } from '../../models/login.model';

@Injectable()
export class LoginService extends BaseService implements OnInit {

  constructor(
    protected _http: HttpClient,
    protected _constantes: Constantes) {

    super(_http, _constantes);
  }

    ngOnInit(): void {
  }

  public autenticado(): boolean {
    return (this.loginAutenticado == "undefined" || this.loginAutenticado == null) ? false : true;
  }

  private _loginAutenticado: string;

  public get loginAutenticado(): string {
    this._loginAutenticado = sessionStorage.getItem("loginAutenticado");
    return this._loginAutenticado;
  }
  public set loginAutenticado(value: string) {
    sessionStorage.setItem("loginAutenticado", value);
    this._loginAutenticado = value;
  }

  autenticar(loginModel: LoginModel): Observable<any> {

    return this.Post("Usuario/Autenticar", loginModel);
  }

}
