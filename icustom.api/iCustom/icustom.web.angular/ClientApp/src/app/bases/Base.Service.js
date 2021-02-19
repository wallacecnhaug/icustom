"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.BaseService = void 0;
var http_1 = require("@angular/common/http");
var BaseService = /** @class */ (function () {
    function BaseService(_http, _constantes) {
        this._http = _http;
        this._constantes = _constantes;
        this.headers = new http_1.HttpHeaders({
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        });
    }
    BaseService.prototype.ngOnInit = function () {
    };
    BaseService.prototype.Post = function (_url, _body) {
        return this._http
            .post(this._constantes.URL_API + _url, _body, { headers: this.headers });
    };
    BaseService.prototype.Get = function (_url, _params) {
        return this._http
            .get(this._constantes.URL_API + _url, { headers: this.headers, params: _params });
    };
    return BaseService;
}());
exports.BaseService = BaseService;
//# sourceMappingURL=base.service.js.map