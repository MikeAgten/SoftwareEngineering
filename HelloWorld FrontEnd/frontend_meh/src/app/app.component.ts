import { Component } from '@angular/core';
import { HelloService } from './services/hello.service';
import { Message } from './models/message';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  message: Message;

  constructor(private helloService: HelloService) {
    this.fetchMessage();
  }

  fetchMessage()  {
    this.message =  this.helloService.fetchTitle();
    console.log(this.message + '....');
  }
}
