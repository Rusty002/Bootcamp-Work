import { Component, OnInit } from '@angular/core';
import { Todo } from 'src/Models/Todo';

@Component({
  selector: 'app-todos',
  templateUrl: './todos.component.html',
  styleUrls: ['./todos.component.css']
})
export class TodosComponent implements OnInit {
  todoItems:Todo[];
  item:string | null;
  constructor() {
    this.item = localStorage.getItem("todoItems");
    if(this.item ==null){
      this.todoItems= [];
    }else{
      this.todoItems= JSON.parse(this.item);
    }

  }
  ngOnInit(): void {
  }
  todoDelete(todo:Todo){
  let index = this.todoItems.indexOf(todo);
  this.todoItems.splice(index, 1);
  localStorage.setItem("todoItems",JSON.stringify(this.todoItems));
  }
  todoAdd(todo:Todo){
    this.todoItems.push(todo);
   // console.log(todo);
    localStorage.setItem("todoItems",JSON.stringify(this.todoItems));
    }
}
