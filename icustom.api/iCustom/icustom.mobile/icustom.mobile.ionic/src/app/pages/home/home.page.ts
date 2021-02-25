import { Component, OnInit } from '@angular/core';
import { BasePage } from '../base.page';

@Component({
  selector: 'app-home',
  templateUrl: './home.page.html',
  styleUrls: ['./home.page.css'],
})
export class HomePage extends BasePage implements OnInit {

  constructor() {
    super();
   }

  ngOnInit() {
  }

}
