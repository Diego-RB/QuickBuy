import { Component } from "@angular/core";
import { Usuario } from "../../modelo/usuario";

@Component({
  selector: "app/login",
  templateUrl: "./login.component.html",
  styleUrls: ["./login.component.css"]
})

export class loginComponent {
  public enderecoImagem = "../../../assets/img/quick-login.jpg"

  public usuario;
    usuarioAutenticado: boolean;
  constructor() {
    this.usuario = new Usuario();
  }

  login() {
    if (this.usuario.email == "diego1279.dr@gmail.com" && this.usuario.senha == "123456") {
      this.usuarioAutenticado = true;
    } 
  }
}
