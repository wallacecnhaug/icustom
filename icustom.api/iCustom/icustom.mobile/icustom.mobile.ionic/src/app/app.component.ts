import { Component } from '@angular/core';
@Component({
  selector: 'app-root',
  templateUrl: 'app.component.html',
  styleUrls: ['app.component.scss'],
})
export class AppComponent {
  public appPages = [
    { title: 'Home', url: '/home', icon: 'id-card' },
    { title: 'Login', url: '/login', icon: 'finger-print' },
    { title: 'Usuarios', url: '/usuarios', icon: 'people' },
  ];
  public labels = ['Sobre'];
  constructor() {}
}
