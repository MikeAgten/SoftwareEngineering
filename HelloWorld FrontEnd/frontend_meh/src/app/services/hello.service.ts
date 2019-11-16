import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Message } from '../models/message';

@Injectable({
  providedIn: 'root'
})
export class HelloService {

  helloText: Message;

  constructor(private http: HttpClient) {
  }

  // fetchTitle(): Observable<Message> {
  //   return this.http.get<Message>('src\assets\title.json').map((res:any) => res.json())
  // }

  fetchTitle(): Message {
    this.helloText.message = 'hello';
    return this.helloText;
  }


}
