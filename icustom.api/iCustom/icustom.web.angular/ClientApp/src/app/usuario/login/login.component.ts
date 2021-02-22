import { Component, OnInit } from '@angular/core';
import { BaseComponent } from '../../bases/base.component';
import { LoginModel } from '../../models/login.model';
import { LoginService } from '../../servicos/usuario/login.service';

@Component({
    selector: 'app-login',
    templateUrl: './login.component.html',
    styleUrls: ['./login.component.css']
})

export default class LoginComponent extends BaseComponent implements OnInit {

  public login: LoginModel;



  constructor(
    private _loginService: LoginService) {

    super();

    this.login = new LoginModel();

    let auth = this._loginService.autenticado;
  }

  ngOnInit(): void {
  }

  public autenticado(): boolean {
    return this._loginService.autenticado();
  }

  public get loginAutenticado(): string {
    return this._loginService.loginAutenticado;
  }

  autenticar() {

    this._loginService.autenticar(this.login)
      .subscribe(
        response => {
          this.msgSucesso = "Login realizado com sucesso.";

          this.setToken(response.token);

          this._loginService.loginAutenticado = response.email;
        },
        err => {
          this.msgErro = err.message.toString();
        }
      );
  }

  sair() {
    this._loginService.loginAutenticado = undefined;
  }
}
