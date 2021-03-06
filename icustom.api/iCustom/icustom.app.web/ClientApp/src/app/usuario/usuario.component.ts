import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { BaseComponent } from '../bases/base.component';
import { ErrorHandler } from '../handlers/app.error.handler';
import { UsuarioModel } from '../models/usuario.model';
import { UsuarioService } from '../servicos/usuario/usuario.service';

@Component({
  selector: 'app-usuario',
  templateUrl: './usuario.component.html',
  styleUrls: ['./usuario.component.css']
})
export class UsuarioComponent extends BaseComponent implements OnInit {

  public usuario: UsuarioModel;

  constructor(
    private _usuarioService: UsuarioService) {

    super();
    this.usuario = new UsuarioModel();
  }

  ngOnInit(): void {
  }

  adicionar() {

    this.apagarMensagens();

    this._usuarioService.adicionar(this.usuario)
      .subscribe(
        response => {
          this.msgSucesso = response;
        },
        err => {
          this.msgErro = err.message.toString();
        }
      )
  }

 

}
