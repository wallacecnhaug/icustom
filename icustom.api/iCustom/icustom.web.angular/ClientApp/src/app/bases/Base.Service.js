"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.BaseService = void 0;
var http_1 = require("@angular/common/http");
var BaseService = /** @class */ (function () {
    function BaseService() {
        //public header: HttpHeaders;
        this.httpOptionsPlain = {
            headers: new http_1.HttpHeaders({
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            })
        };
    }
    BaseService.prototype.ngOnInit = function () {
        //this.header = new HttpHeaders().set('content-type', 'application/json');
    };
    return BaseService;
}());
exports.BaseService = BaseService;
//# sourceMappingURL=base.service.js.map