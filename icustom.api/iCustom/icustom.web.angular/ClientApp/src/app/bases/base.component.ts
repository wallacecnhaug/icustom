import { OnInit } from "@angular/core";

export class BaseComponent {

  constructor() {

  }

  public msgSucesso: string;
  public msgErro: string;

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
