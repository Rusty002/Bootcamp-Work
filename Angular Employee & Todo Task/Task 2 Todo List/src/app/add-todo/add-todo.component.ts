import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { Todo } from 'src/Models/Todo';

@Component({
  selector: 'app-add-todo',
  templateUrl: './add-todo.component.html',
  styleUrls: ['./add-todo.component.css']
})
export class AddTodoComponent implements OnInit {
  title!:string;
  description!:string;
  @Output() addTodo:EventEmitter<Todo> = new EventEmitter();
  constructor() { }

  ngOnInit(): void {
  }
onSubmit(){
  const todo={
    title:this.title,
    description:this.description,
  }
  if(this.title == ""|| this.title == undefined)
  {
    alert("Enter title");
  }
  else if(this.description == "" || this.description == undefined)
  {
    alert("Enter description");
  }
  else
  {
    this.addTodo.emit(todo);
  }
}
}
