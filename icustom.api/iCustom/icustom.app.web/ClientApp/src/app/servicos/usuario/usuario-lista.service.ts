import { HttpClient } from '@angular/common/http';
import { Injectable, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { BaseService } from '../../bases/base.service';
import { Constantes } from '../../helpers/Constantes';
import { UsuarioModel } from '../../models/usuario.model';
import { LoginService } from './login.service';

@Injectable()
export class UsuarioListaService extends BaseService implements OnInit {

  constructor(
    protected _http: HttpClient,
    protected _constantes: Constantes) {

    super(_http, _constantes);
  }

  ngOnInit(): void {
  }

  ObterTodos(): Observable<UsuarioModel[]> {

    return this.Get("Usuario/ListarTodos");

  }

}
