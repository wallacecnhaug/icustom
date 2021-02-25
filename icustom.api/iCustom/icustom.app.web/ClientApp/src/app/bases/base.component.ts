import { OnInit } from "@angular/core";

export class BaseComponent {

  constructor() {

  }

  private static _msgSucesso: string;

  getMsgSucesso(): string {
    return BaseComponent._msgSucesso;
  }

  public set msgSucesso(value: string) {
    BaseComponent._msgErro = undefined;
    BaseComponent._msgSucesso = value;
  }

  private static _msgErro: string;

  getMsgErro(): string {
    return BaseComponent._msgErro;
  }

  public set msgErro(value: string) {
    BaseComponent._msgSucesso = undefined;
    BaseComponent._msgErro = value;
  }

  public apagarMensagemSucesso() {
    BaseComponent._msgSucesso = undefined;
  }

  public apagarMensagemErro() {
    BaseComponent._msgErro = undefined;
  }

  public apagarMensagens() {
    this.apagarMensagemSucesso();
    this.apagarMensagemErro();
  }

}
