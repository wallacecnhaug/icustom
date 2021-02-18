
import { Injectable, OnInit } from '@angular/core';
import { ErrorHandler } from '../../handlers/app.error.handler';
import { Constantes } from '../../helpers/Constantes';
import { Observable } from 'rxjs';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { UsuarioModel } from '../../models/usuario.model';
import { BaseService } from '../../bases/base.service';

@Injectable()
export class UsuarioService extends BaseService implements OnInit {

  constructor(
    private _http: HttpClient,
    private _constantes: Constantes) {

    super();
  }

    ngOnInit(): void {
  }

  adicionar(model: UsuarioModel): Observable<Response> {

    return this. _http
      .post<Response>(
        this._constantes.URL_API + 'Usuario/Adicionar', 
        model, this.httpOptionsPlain );
  }
}
