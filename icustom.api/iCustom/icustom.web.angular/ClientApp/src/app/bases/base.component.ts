import { OnInit } from "@angular/core";

export class BaseComponent implements OnInit {

  public msgSucesso: string;
  public msgErro: string;

  constructor() {
  }

  ngOnInit(): void {
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
