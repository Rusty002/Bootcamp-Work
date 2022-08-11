import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { Todo } from 'src/Models/Todo';

@Component({
  selector: 'app-todo-item',
  templateUrl: './todo-item.component.html',
  styleUrls: ['./todo-item.component.css']
})
export class TodoItemComponent implements OnInit {
  @Input() todo!: Todo;
  @Output() deleteTodo:EventEmitter<Todo> = new EventEmitter();
  constructor() { }

  ngOnInit(): void {
  }
 onClick(todo:Todo){
  this.deleteTodo.emit(todo);
 }
}
