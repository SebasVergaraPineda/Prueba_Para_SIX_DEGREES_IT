import { Component } from '@angular/core';
import { UsuarioService, Usuario } from './services/usuario.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  usuarios: Usuario[] = [];

  constructor(private usuarioService: UsuarioService) {}

  buscar() {
    this.usuarioService.obtenerUsuarios().subscribe({
      next: data => this.usuarios = data,
      error: err => console.error('Error al obtener usuarios:', err)
    });
  }

  limpiar(){
    this.usuarios = [];
  }
}
