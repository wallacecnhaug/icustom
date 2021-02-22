import { OnInit } from "@angular/core";

export class BaseComponent {

  constructor() {

  }

  public msgSucesso: string;
  public msgErro: string;
  public tokenAutenticado: string;

  public getToken(): string {
    this.tokenAutenticado = (sessionStorage.getItem("tokenAutenticado") ? sessionStorage.getItem("tokenAutenticado") : "");
    return this.tokenAutenticado;
  }
  public setToken(value: string) {
    sessionStorage.setItem("tokenAutenticado", value);
    this.tokenAutenticado = value;
  }

  public apagarMensagemSucesso() {
    this.msgSucesso = undefined;
  }

  public apagarMensagemErro() {
    this.msgErro = undefined;
  }

  public apagarMensagens() {
    this.apagarMensagemSucesso();
    this.apagarMensagemErro();
  }

}
