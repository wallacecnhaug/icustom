import { Component, OnInit } from '@angular/core';
import { BaseComponent } from '../../bases/base.component';
import { UsuarioModel } from '../../models/usuario.model';
import { UsuarioListaService } from '../../servicos/usuario/usuario-lista.service';

@Component({
  selector: 'app-usuario-lista',
  templateUrl: './usuario-lista.component.html',
  styleUrls: ['./usuario-lista.component.css']
})
export class UsuarioListaComponent extends BaseComponent implements OnInit {

  public usuarios: UsuarioModel[];

  constructor(
    private _usuarioListaService: UsuarioListaService) {
    super();
  }

  ngOnInit(): void {
    this.ObterTodos();
  }

  ObterTodos() {

    this._usuarioListaService.ObterTodos()
      .subscribe(
        usuarios => {
          this.usuarios = usuarios;
        },
        err => {
          this.msgErro = err.message.toString();
        }
      );
  }

}
