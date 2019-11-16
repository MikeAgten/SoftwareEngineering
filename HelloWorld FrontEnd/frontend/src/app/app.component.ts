import { Component, OnInit } from '@angular/core';
import { Message } from './models/message';
import { MessageService } from './services/message.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  message: Message;

  constructor(private service: MessageService) {  }

  ngOnInit() {
    this.service.getMessageObservable().subscribe(message => this.message = message);
  }
}
