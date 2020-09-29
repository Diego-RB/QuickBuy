import { Component, OnInit } from "@angular/core";
import { Usuario } from "../../modelo/usuario";
import { ActivatedRoute, Router } from "@angular/router";

@Component({
  selector: "app/login",
  templateUrl: "./login.component.html",
  styleUrls: ["./login.component.css"]
})

export class loginComponent implements OnInit {
  //Uma das maneiras de endereçar uma imagem no HTML
  public enderecoImagem = "../../../assets/img/quick-login.jpg"
  public returnUrl: string;

  public usuario;
  usuarioAutenticado: boolean;
  constructor(private router: Router, private activateRouter: ActivatedRoute) {

  }
    //Está fazendo a leitura do returnUrl do queryParams em guarda.rotas para quando efetuae login permanecer na página Produto
    ngOnInit(): void {
      this.returnUrl = this.activateRouter.snapshot.queryParams['returnUrl'];
      this.usuario = new Usuario();
    }
  //função verifica se os dados informados na página login estão corretos e retorna 1 se for verdadeiro
  login() {
    if (this.usuario.email == "diego1279.dr@gmail.com" && this.usuario.senha == "123456") {
      sessionStorage.setItem("usuario-autenticado", "1");
      //Após logado ele redirecina para a página que estava anteriormente.(Produto)
      this.router.navigate([this.returnUrl]);
    } 
  }
}
