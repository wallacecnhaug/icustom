
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
    protected _http: HttpClient,
    protected _constantes: Constantes) {

    super(_http, _constantes);
  }

    ngOnInit(): void {
  }

  adicionar(model: UsuarioModel): Observable<Response> {

    return this.Post('Usuario/Adicionar', model);
  }
}
