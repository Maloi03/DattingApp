import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit{
  title = 'The Datting app';
  user: any;

  constructor(private http: HttpClient) {}
  ngOnInit() {
    this.getUsers();
  }
  getUsers(){
    this.http.get('http://localhost:5046/api/user').subscribe(response =>{
      this.user = response;
    }, error =>{
      console.log(error);
    })
  }
}
