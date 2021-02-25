import { Component, OnInit } from '@angular/core';
import { LoginService } from '../../services/login.service';
import { BasePage } from '../base.page';

@Component({
  selector: 'app-login',
  templateUrl: './login.page.html',
  styleUrls: ['./login.page.css'],
})
export class LoginPage extends BasePage implements OnInit {

  constructor(private loginService : LoginService) { 
    super();
  }

  ngOnInit() {

  }

}
