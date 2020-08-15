import { Component, OnInit } from '@angular/core';
import { UserService } from '../user.service';

import { User } from '../user';

@Component({
  selector: 'app-user',
  templateUrl: './user.component.html',
  styleUrls: ['./user.component.css']
})
export class UserComponent implements OnInit {
  user;

  constructor(
    private userService: UserService
  ) { }

  ngOnInit(): void {
    this.userService.getUser()
      .subscribe(user => this.user = user);
  }

}
