import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HttpClient } from '@angular/common/http';
import { response } from 'express';

@Component({
  selector: 'app-eventos',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './eventos.component.html',
  styleUrl: './eventos.component.scss'
})
export class EventosComponent {
  constructor(private http: HttpClient) { }

  ngOnInit(): void {
    this.getEventos();
  }

  public eventos: any;

  public getEventos(): void {
    this.http.get("https://localhost:5001/api/Eventos").subscribe(
      response => this.eventos = response
    );
  }
}
