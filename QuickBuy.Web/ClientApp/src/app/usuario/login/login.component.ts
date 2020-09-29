import { Component } from "@angular/core";
import { Usuario } from "../../modelo/usuario";
import { Router } from "@angular/router";

@Component({
  selector: "app/login",
  templateUrl: "./login.component.html",
  styleUrls: ["./login.component.css"]
})

export class loginComponent {
  //Uma das maneiras de endereçar uma imagem no HTML
  public enderecoImagem = "../../../assets/img/quick-login.jpg"

  public usuario;
    usuarioAutenticado: boolean;
  constructor(private router: Router) {
    this.usuario = new Usuario();
  }
  //função verifica se os dados informados na página login estão corretos e retorna 1 se for verdadeiro
  login() {
    if (this.usuario.email == "diego1279.dr@gmail.com" && this.usuario.senha == "123456") {
      localStorage.setItem("usuario-autenticado", "1");
      //this.router.navigate(['/']);
    } 
  }
}
