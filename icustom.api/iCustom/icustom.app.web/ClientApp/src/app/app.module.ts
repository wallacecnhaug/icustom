import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { UsuarioComponent } from './usuario/usuario.component';
import { UsuarioService } from './servicos/usuario/usuario.service';
import { Constantes } from './helpers/Constantes';
import { LoginService } from './servicos/usuario/login.service';
import { GuardaRotasService } from './servicos/guarda-rotas.service';
import { UsuarioListaComponent } from './usuario/usuario-lista/usuario-lista.component';
import { UsuarioListaService } from './servicos/usuario/usuario-lista.service';
import LoginComponent from './usuario/login/login.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    UsuarioComponent,
    UsuarioListaComponent,
    LoginComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'usuario', component: UsuarioComponent },
      { path: 'usuarios', component: UsuarioListaComponent, canActivate: [GuardaRotasService] },
      { path: 'login', component: LoginComponent },
    ])
  ],
  providers: [
    UsuarioService,
    LoginService,
    GuardaRotasService,
    UsuarioListaService,
    Constantes
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
