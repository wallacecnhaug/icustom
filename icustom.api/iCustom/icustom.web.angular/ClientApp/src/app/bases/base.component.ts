import { OnInit } from "@angular/core";

export class BaseComponent {

  constructor() {

  }

  private _msgSucesso: string;

  public get msgSucesso(): string {
    return this._msgSucesso;
  }

  public set msgSucesso(value: string) {
    this._msgErro = undefined;
    this._msgSucesso = value;
  }

  private _msgErro: string;

  public get msgErro(): string {
    return this._msgErro;
  }

  public set msgErro(value: string) {
    this._msgSucesso = undefined;
    this._msgErro = value;
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
