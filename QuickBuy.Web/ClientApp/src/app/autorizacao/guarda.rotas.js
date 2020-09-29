"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.GuardaRotar = void 0;
var GuardaRotar = /** @class */ (function () {
    function GuardaRotar(router) {
        this.router = router;
    }
    GuardaRotar.prototype.canActivate = function (route, state) {
        //this.router.navigate(['/login'])
        //se o usuário for autenticado
        return true;
    };
    return GuardaRotar;
}());
exports.GuardaRotar = GuardaRotar;
//# sourceMappingURL=guarda.rotas.js.map