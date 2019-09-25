import { Injectable } from '@angular/core';
import { User } from './user.model';

@Injectable()
export class UserService 
{

  constructor() { }

  getUsers(): User[] {
    return [
      {
        id: 1,
        first: 'Mayur',
        last: 'Chandgude'
      },
      {
        id: 2,
        first: 'Ajit',
        last: 'Jadhav'
      },
      {
        id: 3,
        first: 'Vijay',
        last: 'Jawalkar'
      }
    ]
  }
}
