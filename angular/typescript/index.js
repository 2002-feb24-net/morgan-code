"use strict";
var LowercasestringHelper = /** @class */ (function () {
    function LowercasestringHelper() {
    }
    LowercasestringHelper.prototype.formatString = function (s) {
        return "" + s.toLowerCase;
    };
    return LowercasestringHelper;
}());
var helper = new LowercasestringHelper();
document.addEventListener('DOMContentLoaded', function () {
    var element = document.createElement('p');
    element.textContent = "Hello TS";
    document.body.appendChild(element);
});
