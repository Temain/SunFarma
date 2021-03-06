﻿/**
 * [Chart.PieceLabel.js]{@link https://github.com/emn178/Chart.PieceLabel.js}
 *
 * @version 0.10.0
 * @author Chen, Yi-Cyuan [emn178@gmail.com]
 * @copyright Chen, Yi-Cyuan 2017-2018
 * @license MIT
 */
(function () {
    function d() { this.drawDataset = this.drawDataset.bind(this) } "undefined" === typeof Chart ? console.warn("Can not find Chart object.") : (d.prototype.beforeDatasetsUpdate = function (a) { if (this.parseOptions(a) && "outside" === this.position) { var b = 1.5 * this.fontSize + this.outsidePadding; a.chartArea.top += b; a.chartArea.bottom -= b } }, d.prototype.afterDatasetsDraw = function (a) { this.parseOptions(a) && (this.labelBounds = [], a.config.data.datasets.forEach(this.drawDataset)) }, d.prototype.drawDataset = function (a) {
        for (var b =
            this.ctx, f = this.chartInstance, q = a._meta[Object.keys(a._meta)[0]], k = 0, g = 0; g < q.data.length; g++) {
                var h = q.data[g], c = h._view; if (0 !== c.circumference || this.showZero) {
                    switch (this.render) {
                        case "value": var e = a.data[g]; this.format && (e = this.format(e)); e = e.toString(); break; case "label": e = f.config.data.labels[g]; break; case "image": e = this.images[g] ? this.loadImage(this.images[g]) : ""; break; default: var p = c.circumference / this.options.circumference * 100; p = parseFloat(p.toFixed(this.precision)); this.showActualPercentages ||
                            (k += p, 100 < k && (p -= k - 100, p = parseFloat(p.toFixed(this.precision)))); e = p + "%"
                    }"function" === typeof this.render && (e = this.render({ label: f.config.data.labels[g], value: a.data[g], percentage: p, dataset: a, index: g }), "object" === typeof e && (e = this.loadImage(e))); if (e) {
                        b.save(); b.beginPath(); b.font = Chart.helpers.fontString(this.fontSize, this.fontStyle, this.fontFamily); if ("outside" === this.position || "border" === this.position) {
                            var l = c.outerRadius / 2; var d, m = this.fontSize + 2; var n = c.startAngle + (c.endAngle - c.startAngle) / 2;
                            "border" === this.position ? d = (c.outerRadius - l) / 2 + l : "outside" === this.position && (d = c.outerRadius - l + l + m); n = { x: c.x + Math.cos(n) * d, y: c.y + Math.sin(n) * d }; if ("outside" === this.position) { n.x = n.x < c.x ? n.x - m : n.x + m; var r = c.outerRadius + m }
                        } else l = c.innerRadius, n = h.tooltipPosition(); m = this.fontColor; "function" === typeof m ? m = m({ label: f.config.data.labels[g], value: a.data[g], percentage: p, text: e, backgroundColor: a.backgroundColor[g], dataset: a, index: g }) : "string" !== typeof m && (m = m[g] || this.options.defaultFontColor); if (this.arc) r ||
                            (r = (l + c.outerRadius) / 2), b.fillStyle = m, b.textBaseline = "middle", this.drawArcText(e, r, c, this.overlap); else { l = this.measureText(e); c = n.x - l.width / 2; l = n.x + l.width / 2; var t = n.y - this.fontSize / 2, u = n.y + this.fontSize / 2; (this.overlap || ("outside" === this.position ? this.checkTextBound(c, l, t, u) : h.inRange(c, t) && h.inRange(c, u) && h.inRange(l, t) && h.inRange(l, u))) && this.fillText(e, n, m) } b.restore()
                    }
                }
        }
    }, d.prototype.parseOptions = function (a) {
        var b = a.options.pieceLabel; return b ? (this.chartInstance = a, this.ctx = a.chart.ctx, this.options =
            a.config.options, this.render = b.render || b.mode, this.position = b.position || "default", this.arc = b.arc, this.format = b.format, this.precision = b.precision || 0, this.fontSize = b.fontSize || this.options.defaultFontSize, this.fontColor = b.fontColor || this.options.defaultFontColor, this.fontStyle = b.fontStyle || this.options.defaultFontStyle, this.fontFamily = b.fontFamily || this.options.defaultFontFamily, this.hasTooltip = a.tooltip._active && a.tooltip._active.length, this.showZero = b.showZero, this.overlap = b.overlap, this.images = b.images ||
            [], this.outsidePadding = b.outsidePadding || 2, this.showActualPercentages = b.showActualPercentages || !1, !0) : !1
    }, d.prototype.checkTextBound = function (a, b, f, q) {
        for (var k = this.labelBounds, g = 0; g < k.length; ++g) { for (var h = k[g], c = [[a, f], [a, q], [b, f], [b, q]], e = 0; e < c.length; ++e) { var d = c[e][0], l = c[e][1]; if (d >= h.left && d <= h.right && l >= h.top && l <= h.bottom) return !1 } c = [[h.left, h.top], [h.left, h.bottom], [h.right, h.top], [h.right, h.bottom]]; for (e = 0; e < c.length; ++e)if (d = c[e][0], l = c[e][1], d >= a && d <= b && l >= f && l <= q) return !1 } k.push({
            left: a,
            right: b, top: f, bottom: q
        }); return !0
    }, d.prototype.measureText = function (a) { return "object" === typeof a ? { width: a.width, height: a.height } : this.ctx.measureText(a) }, d.prototype.fillText = function (a, b, d) { var f = this.ctx; "object" === typeof a ? f.drawImage(a, b.x - a.width / 2, b.y - a.height / 2, a.width, a.height) : (f.fillStyle = d, f.textBaseline = "top", f.textAlign = "center", f.fillText(a, b.x, b.y - this.fontSize / 2)) }, d.prototype.loadImage = function (a) { var b = new Image; b.src = a.src; b.width = a.width; b.height = a.height; return b }, d.prototype.drawArcText =
        function (a, b, f, d) { var k = this.ctx, g = f.x, h = f.y, c = f.startAngle; f = f.endAngle; k.save(); k.translate(g, h); h = f - c; c += Math.PI / 2; f += Math.PI / 2; var e = c; g = this.measureText(a); c += (f - (g.width / b + c)) / 2; if (d || !(f - c > h)) if ("string" === typeof a) for (k.rotate(c), d = 0; d < a.length; d++)c = a.charAt(d), g = k.measureText(c), k.save(), k.translate(0, -1 * b), k.fillText(c, 0, 0), k.restore(), k.rotate(g.width / b); else k.rotate((e + f) / 2), k.translate(0, -1 * b), this.fillText(a, { x: 0, y: 0 }); k.restore() }, Chart.pluginService.register({
            beforeInit: function (a) {
            a.pieceLabel =
                new d
            }, beforeDatasetsUpdate: function (a) { a.pieceLabel.beforeDatasetsUpdate(a) }, afterDatasetsDraw: function (a) { a.pieceLabel.afterDatasetsDraw(a) }
        }))
})();