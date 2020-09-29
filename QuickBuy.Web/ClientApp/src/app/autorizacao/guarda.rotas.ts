import { Injectable } from "@angular/core";
import { Router, CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot } from "@angular/router";

@Injectable({
  providedIn:'root'
})
export class GuardaRotar implements CanActivate {
  constructor(private router: Router) {

  }

  canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): boolean {
    var autenticado = localStorage.getItem("usuario-autenticado");
    if (autenticado == "1") {
      return true;
    }
    //rota para redirecionar o usuario para a página de login.Ccaso o login estiver correto redireciona para a página solicitada
    this.router.navigate(['/login'], { queryParams: { returnUrl: state.url }});
    //se o usuário for autenticado
    return false;
  }
}
