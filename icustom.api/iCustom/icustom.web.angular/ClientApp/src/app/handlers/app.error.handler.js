"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.ErrorHandler = void 0;
var http_1 = require("@angular/http");
var rxjs_1 = require("rxjs");
var ErrorHandler = /** @class */ (function () {
    function ErrorHandler() {
    }
    ErrorHandler.TratarError = function (error) {
        var msgErro;
        msgErro = error.toString();
        if (error instanceof http_1.Response) {
            msgErro = "Erro " + error.status + " na resposta da requisi\u00E7\u00E3o " + error.url + " - " + error.statusText;
        }
        console.log(msgErro);
        return rxjs_1.Observable.throw(msgErro);
    };
    return ErrorHandler;
}());
exports.ErrorHandler = ErrorHandler;
//# sourceMappingURL=app.error.handler.js.map