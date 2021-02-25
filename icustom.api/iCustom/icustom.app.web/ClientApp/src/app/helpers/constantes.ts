import { Injectable, OnInit } from "@angular/core";
import { environment } from "../../environments/environment";

@Injectable()
export class Constantes implements OnInit {

  private _URL_API: string;

  constructor() {
    this._URL_API = environment.URL_API;
  }

  ngOnInit(): void {
  }


  public get URL_API(): string {
    return this._URL_API;
  }
  public set URL_API(value: string) {
    this._URL_API = value;
  }
}
