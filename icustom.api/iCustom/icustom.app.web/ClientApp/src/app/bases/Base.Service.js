"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.BaseService = void 0;
var http_1 = require("@angular/common/http");
var BaseService = /** @class */ (function () {
    function BaseService(_http, _constantes) {
        this._http = _http;
        this._constantes = _constantes;
        this.base_URL = this._constantes.URL_API;
        this.headers = new http_1.HttpHeaders({
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        });
    }
    BaseService.prototype.ngOnInit = function () {
    };
    Object.defineProperty(BaseService.prototype, "tokenAutenticado", {
        get: function () {
            return (sessionStorage.getItem("tokenAutenticado") ? sessionStorage.getItem("tokenAutenticado") : "");
        },
        set: function (value) {
            sessionStorage.setItem("tokenAutenticado", value);
        },
        enumerable: false,
        configurable: true
    });
    BaseService.prototype.Get = function (_url, _params) {
        return this._http
            .get(this._constantes.URL_API + _url, { headers: this.headers, params: _params });
    };
    BaseService.prototype.Post = function (url, body) {
        return this._http
            .post(this.base_URL + url, body, { headers: this.headers });
    };
    return BaseService;
}());
exports.BaseService = BaseService;
//# sourceMappingURL=base.service.js.map