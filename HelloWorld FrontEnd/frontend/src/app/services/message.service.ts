import { Injectable } from '@angular/core';
import { Message } from '../models/message';
import { Observable, of } from 'rxjs';
import { MESSAGE } from '../mock-message';

@Injectable({
  providedIn: 'root'
})
export class MessageService {
  message: Message = { bericht: 'helloWorld'} ;

  constructor() { }

  getMessageObservable(): Observable<Message> {
    return of(MESSAGE);
  }
}
