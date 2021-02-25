import { Injectable, OnInit } from '@angular/core';
import { ActivatedRouteSnapshot, CanActivate, Router, RouterStateSnapshot } from '@angular/router';
import { Observable } from 'rxjs';
import { LoginService } from './usuario/login.service';

@Injectable()
export class GuardaRotasService implements OnInit, CanActivate {

  constructor(
    private _router: Router,
    private _loginService: LoginService) {

  }

  public autenticado(): boolean {
    return this._loginService.autenticado();
  }

  canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): boolean {

    let autenticado = this.autenticado();

    if (autenticado) {
      return true;
    }
    else {
      this._router.navigate(['/login'], { queryParams: { returnUrl: state.url } });
    }
  }

  ngOnInit(): void {

  }
}
