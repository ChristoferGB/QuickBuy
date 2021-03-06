import { Component } from "@angular/core";
import { Usuario } from "../../model/usuario";
import { Router } from "@angular/router";

@Component({
  selector: "app-login",
  templateUrl: "./login.component.html",
  styleUrls: ["./login.component.css"]
})
export class LoginComponent {

  public usuario;
  
  constructor(private router: Router) {
    this.usuario = new Usuario();
  }

  entrar() {
    if (this.usuario.email == "christofer@teste.com" && this.usuario.senha == "abc123") {
      localStorage.setItem("usuario-autenticado", "1");
      this.router.navigate(['/']);
    }
  }

}
