import { Component } from '@angular/core';
import { BasketService } from '../../basket/basket.service';
import { BasketItem } from '../../models/basket';
import { AccountService } from '../../account/account.service';

@Component({
  selector: 'app-nav-bar',
  templateUrl: './nav-bar.component.html',
  styleUrl: './nav-bar.component.scss'
})
export class NavBarComponent {
logout() {
throw new Error('Method not implemented.');
}
  constructor(public basketService: BasketService,
    public accountService: AccountService
  ) {}

  getCount(items: BasketItem[]) {
    return items.reduce((sum,item) => sum + item.quantity, 0);
  }
}
