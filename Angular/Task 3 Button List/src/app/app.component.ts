import { Component } from '@angular/core';
import { MasterService } from 'src/app/Services/master.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
  providers:[MasterService]
})

export class AppComponent {
  title = 'Task-1-Employee';

}