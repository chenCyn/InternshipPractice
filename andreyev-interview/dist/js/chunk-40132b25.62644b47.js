(window["webpackJsonp"]=window["webpackJsonp"]||[]).push([["chunk-40132b25"],{"057f":function(t,e,n){var r=n("c6b6"),i=n("fc6a"),o=n("241c").f,c=n("4dae"),a="object"==typeof window&&window&&Object.getOwnPropertyNames?Object.getOwnPropertyNames(window):[],u=function(t){try{return o(t)}catch(e){return c(a)}};t.exports.f=function(t){return a&&"Window"==r(t)?u(t):o(i(t))}},"0b42":function(t,e,n){var r=n("da84"),i=n("e8b5"),o=n("68ee"),c=n("861d"),a=n("b622"),u=a("species"),f=r.Array;t.exports=function(t){var e;return i(t)&&(e=t.constructor,o(e)&&(e===f||i(e.prototype))?e=void 0:c(e)&&(e=e[u],null===e&&(e=void 0))),void 0===e?f:e}},"408a":function(t,e,n){var r=n("e330");t.exports=r(1..valueOf)},"428f":function(t,e,n){var r=n("da84");t.exports=r},"4dae":function(t,e,n){var r=n("da84"),i=n("23cb"),o=n("07fa"),c=n("8418"),a=r.Array,u=Math.max;t.exports=function(t,e,n){for(var r=o(t),f=i(e,r),l=i(void 0===n?r:n,r),s=a(u(l-f,0)),b=0;f<l;f++,b++)c(s,b,t[f]);return s.length=b,s}},5899:function(t,e){t.exports="\t\n\v\f\r                　\u2028\u2029\ufeff"},"58a8":function(t,e,n){var r=n("e330"),i=n("1d80"),o=n("577e"),c=n("5899"),a=r("".replace),u="["+c+"]",f=RegExp("^"+u+u+"*"),l=RegExp(u+u+"*$"),s=function(t){return function(e){var n=o(i(e));return 1&t&&(n=a(n,f,"")),2&t&&(n=a(n,l,"")),n}};t.exports={start:s(1),end:s(2),trim:s(3)}},"65f0":function(t,e,n){var r=n("0b42");t.exports=function(t,e){return new(r(t))(0===e?0:e)}},7156:function(t,e,n){var r=n("1626"),i=n("861d"),o=n("d2bb");t.exports=function(t,e,n){var c,a;return o&&r(c=e.constructor)&&c!==n&&i(a=c.prototype)&&a!==n.prototype&&o(t,a),t}},"746f":function(t,e,n){var r=n("428f"),i=n("1a2d"),o=n("e538"),c=n("9bf2").f;t.exports=function(t){var e=r.Symbol||(r.Symbol={});i(e,t)||c(e,t,{value:o.f(t)})}},8418:function(t,e,n){"use strict";var r=n("a04b"),i=n("9bf2"),o=n("5c6c");t.exports=function(t,e,n){var c=r(e);c in t?i.f(t,c,o(0,n)):t[c]=n}},a4d3:function(t,e,n){"use strict";var r=n("23e7"),i=n("da84"),o=n("d066"),c=n("2ba4"),a=n("c65b"),u=n("e330"),f=n("c430"),l=n("83ab"),s=n("4930"),b=n("d039"),d=n("1a2d"),p=n("e8b5"),v=n("1626"),h=n("861d"),O=n("3a9b"),y=n("d9b5"),m=n("825a"),j=n("7b0b"),g=n("fc6a"),I=n("a04b"),w=n("577e"),S=n("5c6c"),N=n("7c73"),x=n("df75"),E=n("241c"),T=n("057f"),C=n("7418"),k=n("06cf"),A=n("9bf2"),P=n("d1e7"),B=n("f36a"),V=n("6eeb"),F=n("5692"),_=n("f772"),q=n("d012"),L=n("90e3"),U=n("b622"),D=n("e538"),J=n("746f"),M=n("d44e"),R=n("69f3"),G=n("b727").forEach,$=_("hidden"),z="Symbol",Q="prototype",X=U("toPrimitive"),Y=R.set,W=R.getterFor(z),H=Object[Q],K=i.Symbol,Z=K&&K[Q],tt=i.TypeError,et=i.QObject,nt=o("JSON","stringify"),rt=k.f,it=A.f,ot=T.f,ct=P.f,at=u([].push),ut=F("symbols"),ft=F("op-symbols"),lt=F("string-to-symbol-registry"),st=F("symbol-to-string-registry"),bt=F("wks"),dt=!et||!et[Q]||!et[Q].findChild,pt=l&&b((function(){return 7!=N(it({},"a",{get:function(){return it(this,"a",{value:7}).a}})).a}))?function(t,e,n){var r=rt(H,e);r&&delete H[e],it(t,e,n),r&&t!==H&&it(H,e,r)}:it,vt=function(t,e){var n=ut[t]=N(Z);return Y(n,{type:z,tag:t,description:e}),l||(n.description=e),n},ht=function(t,e,n){t===H&&ht(ft,e,n),m(t);var r=I(e);return m(n),d(ut,r)?(n.enumerable?(d(t,$)&&t[$][r]&&(t[$][r]=!1),n=N(n,{enumerable:S(0,!1)})):(d(t,$)||it(t,$,S(1,{})),t[$][r]=!0),pt(t,r,n)):it(t,r,n)},Ot=function(t,e){m(t);var n=g(e),r=x(n).concat(It(n));return G(r,(function(e){l&&!a(mt,n,e)||ht(t,e,n[e])})),t},yt=function(t,e){return void 0===e?N(t):Ot(N(t),e)},mt=function(t){var e=I(t),n=a(ct,this,e);return!(this===H&&d(ut,e)&&!d(ft,e))&&(!(n||!d(this,e)||!d(ut,e)||d(this,$)&&this[$][e])||n)},jt=function(t,e){var n=g(t),r=I(e);if(n!==H||!d(ut,r)||d(ft,r)){var i=rt(n,r);return!i||!d(ut,r)||d(n,$)&&n[$][r]||(i.enumerable=!0),i}},gt=function(t){var e=ot(g(t)),n=[];return G(e,(function(t){d(ut,t)||d(q,t)||at(n,t)})),n},It=function(t){var e=t===H,n=ot(e?ft:g(t)),r=[];return G(n,(function(t){!d(ut,t)||e&&!d(H,t)||at(r,ut[t])})),r};if(s||(K=function(){if(O(Z,this))throw tt("Symbol is not a constructor");var t=arguments.length&&void 0!==arguments[0]?w(arguments[0]):void 0,e=L(t),n=function(t){this===H&&a(n,ft,t),d(this,$)&&d(this[$],e)&&(this[$][e]=!1),pt(this,e,S(1,t))};return l&&dt&&pt(H,e,{configurable:!0,set:n}),vt(e,t)},Z=K[Q],V(Z,"toString",(function(){return W(this).tag})),V(K,"withoutSetter",(function(t){return vt(L(t),t)})),P.f=mt,A.f=ht,k.f=jt,E.f=T.f=gt,C.f=It,D.f=function(t){return vt(U(t),t)},l&&(it(Z,"description",{configurable:!0,get:function(){return W(this).description}}),f||V(H,"propertyIsEnumerable",mt,{unsafe:!0}))),r({global:!0,wrap:!0,forced:!s,sham:!s},{Symbol:K}),G(x(bt),(function(t){J(t)})),r({target:z,stat:!0,forced:!s},{for:function(t){var e=w(t);if(d(lt,e))return lt[e];var n=K(e);return lt[e]=n,st[n]=e,n},keyFor:function(t){if(!y(t))throw tt(t+" is not a symbol");if(d(st,t))return st[t]},useSetter:function(){dt=!0},useSimple:function(){dt=!1}}),r({target:"Object",stat:!0,forced:!s,sham:!l},{create:yt,defineProperty:ht,defineProperties:Ot,getOwnPropertyDescriptor:jt}),r({target:"Object",stat:!0,forced:!s},{getOwnPropertyNames:gt,getOwnPropertySymbols:It}),r({target:"Object",stat:!0,forced:b((function(){C.f(1)}))},{getOwnPropertySymbols:function(t){return C.f(j(t))}}),nt){var wt=!s||b((function(){var t=K();return"[null]"!=nt([t])||"{}"!=nt({a:t})||"{}"!=nt(Object(t))}));r({target:"JSON",stat:!0,forced:wt},{stringify:function(t,e,n){var r=B(arguments),i=e;if((h(e)||void 0!==t)&&!y(t))return p(e)||(e=function(t,e){if(v(i)&&(e=a(i,this,t,e)),!y(e))return e}),r[1]=e,c(nt,null,r)}})}if(!Z[X]){var St=Z.valueOf;V(Z,X,(function(t){return a(St,this)}))}M(K,z),q[$]=!0},a9e3:function(t,e,n){"use strict";var r=n("83ab"),i=n("da84"),o=n("e330"),c=n("94ca"),a=n("6eeb"),u=n("1a2d"),f=n("7156"),l=n("3a9b"),s=n("d9b5"),b=n("c04e"),d=n("d039"),p=n("241c").f,v=n("06cf").f,h=n("9bf2").f,O=n("408a"),y=n("58a8").trim,m="Number",j=i[m],g=j.prototype,I=i.TypeError,w=o("".slice),S=o("".charCodeAt),N=function(t){var e=b(t,"number");return"bigint"==typeof e?e:x(e)},x=function(t){var e,n,r,i,o,c,a,u,f=b(t,"number");if(s(f))throw I("Cannot convert a Symbol value to a number");if("string"==typeof f&&f.length>2)if(f=y(f),e=S(f,0),43===e||45===e){if(n=S(f,2),88===n||120===n)return NaN}else if(48===e){switch(S(f,1)){case 66:case 98:r=2,i=49;break;case 79:case 111:r=8,i=55;break;default:return+f}for(o=w(f,2),c=o.length,a=0;a<c;a++)if(u=S(o,a),u<48||u>i)return NaN;return parseInt(o,r)}return+f};if(c(m,!j(" 0o1")||!j("0b1")||j("+0x1"))){for(var E,T=function(t){var e=arguments.length<1?0:j(N(t)),n=this;return l(g,n)&&d((function(){O(n)}))?f(Object(e),n,T):e},C=r?p(j):"MAX_VALUE,MIN_VALUE,NaN,NEGATIVE_INFINITY,POSITIVE_INFINITY,EPSILON,MAX_SAFE_INTEGER,MIN_SAFE_INTEGER,isFinite,isInteger,isNaN,isSafeInteger,parseFloat,parseInt,fromString,range".split(","),k=0;C.length>k;k++)u(j,E=C[k])&&!u(T,E)&&h(T,E,v(j,E));T.prototype=g,g.constructor=T,a(i,m,T)}},b0c0:function(t,e,n){var r=n("83ab"),i=n("5e77").EXISTS,o=n("e330"),c=n("9bf2").f,a=Function.prototype,u=o(a.toString),f=/function\b(?:\s|\/\*[\S\s]*?\*\/|\/\/[^\n\r]*[\n\r]+)*([^\s(/]*)/,l=o(f.exec),s="name";r&&!i&&c(a,s,{configurable:!0,get:function(){try{return l(f,u(this))[1]}catch(t){return""}}})},b727:function(t,e,n){var r=n("0366"),i=n("e330"),o=n("44ad"),c=n("7b0b"),a=n("07fa"),u=n("65f0"),f=i([].push),l=function(t){var e=1==t,n=2==t,i=3==t,l=4==t,s=6==t,b=7==t,d=5==t||s;return function(p,v,h,O){for(var y,m,j=c(p),g=o(j),I=r(v,h),w=a(g),S=0,N=O||u,x=e?N(p,w):n||b?N(p,0):void 0;w>S;S++)if((d||S in g)&&(y=g[S],m=I(y,S,j),t))if(e)x[S]=m;else if(m)switch(t){case 3:return!0;case 5:return y;case 6:return S;case 2:f(x,y)}else switch(t){case 4:return!1;case 7:f(x,y)}return s?-1:i||l?l:x}};t.exports={forEach:l(0),map:l(1),filter:l(2),some:l(3),every:l(4),find:l(5),findIndex:l(6),filterReject:l(7)}},c20d:function(t,e,n){var r=n("da84"),i=n("d039"),o=n("e330"),c=n("577e"),a=n("58a8").trim,u=n("5899"),f=r.parseInt,l=r.Symbol,s=l&&l.iterator,b=/^[+-]?0x/i,d=o(b.exec),p=8!==f(u+"08")||22!==f(u+"0x16")||s&&!i((function(){f(Object(s))}));t.exports=p?function(t,e){var n=a(c(t));return f(n,e>>>0||(d(b,n)?16:10))}:f},cbf3:function(t,e,n){"use strict";n.r(e);n("a4d3"),n("e01a");var r=n("7a23"),i={class:"about"},o=Object(r["e"])("Back"),c=Object(r["f"])("h2",null,"Invoice Details",-1),a=Object(r["f"])("h3",null,"Line Items",-1),u=Object(r["f"])("thead",null,[Object(r["f"])("th",null,"ID"),Object(r["f"])("th",null,"Description"),Object(r["f"])("th",null,"Quantity"),Object(r["f"])("th",null,"Cost"),Object(r["f"])("th",null,"Billable")],-1),f={class:"text-right"},l=Object(r["f"])("strong",null,"Total Value : ",-1),s={class:"text-right"},b=Object(r["f"])("strong",null,"Total Billable Value : ",-1),d=Object(r["f"])("h4",null,"Create Line Item",-1),p=Object(r["e"])(" Billable: "),v=Object(r["f"])("br",null,null,-1),h=Object(r["f"])("br",null,null,-1);function O(t,e,n,O,y,m){var j=Object(r["u"])("router-link");return Object(r["p"])(),Object(r["d"])("div",i,[Object(r["f"])(j,{to:{name:"Invoices"}},{default:Object(r["B"])((function(){return[o]})),_:1}),c,Object(r["f"])("span",null,"Invoice #"+Object(r["w"])(t.$route.params.id),1),a,Object(r["f"])("table",null,[u,Object(r["f"])("tbody",null,[(Object(r["p"])(!0),Object(r["d"])(r["a"],null,Object(r["t"])(t.state.lineItems.lineItem,(function(n){return Object(r["p"])(),Object(r["d"])("tr",{key:n.id},[Object(r["f"])("td",null,Object(r["w"])(n.id),1),Object(r["f"])("td",null,Object(r["w"])(n.description),1),Object(r["f"])("td",null,Object(r["w"])(n.quantity),1),Object(r["f"])("td",null,Object(r["w"])(n.cost),1),Object(r["f"])("td",null,[Object(r["f"])("input",{type:"checkbox",id:n.id,onChange:e[1]||(e[1]=function(e){return t.handleBillableStatus(e)}),name:n.invoiceId,value:n.isBillable,checked:!!n.isBillable},null,40,["id","name","value","checked"])])])})),128))])]),Object(r["f"])("div",f,[l,Object(r["e"])(" "+Object(r["w"])(t.state.lineItems.grandTotal),1)]),Object(r["f"])("div",s,[b,Object(r["e"])(" "+Object(r["w"])(t.state.lineItems.totalBillableValue),1)]),Object(r["f"])("form",{onSubmit:e[7]||(e[7]=Object(r["D"])((function(){}),["prevent"]))},[d,Object(r["C"])(Object(r["f"])("input",{type:"text",name:"description",placeholder:"Description","onUpdate:modelValue":e[2]||(e[2]=function(e){return t.state.description=e})},null,512),[[r["z"],t.state.description]]),Object(r["C"])(Object(r["f"])("input",{type:"number",name:"quantity",placeholder:"Quantity","onUpdate:modelValue":e[3]||(e[3]=function(e){return t.state.quantity=e})},null,512),[[r["z"],t.state.quantity]]),Object(r["C"])(Object(r["f"])("input",{type:"number",name:"cost",placeholder:"Cost","onUpdate:modelValue":e[4]||(e[4]=function(e){return t.state.cost=e})},null,512),[[r["z"],t.state.cost]]),p,Object(r["C"])(Object(r["f"])("input",{type:"checkbox",name:"isbillable","onUpdate:modelValue":e[5]||(e[5]=function(e){return t.state.isbillable=e})},null,512),[[r["y"],t.state.isbillable]]),v,h,Object(r["f"])("button",{onClick:e[6]||(e[6]=function(){return t.createLineItem&&t.createLineItem.apply(t,arguments)})},"Create Invoice")],32)])}n("a9e3"),n("b0c0"),n("d3b7"),n("e25e");var y=Object(r["g"])({name:"Invoice",props:{id:{type:[String,Number],required:!0}},methods:{handleBillableStatus:function(t){var e=t.target,n=e.value,r=e.id,i=e.name,o=!1;"true"==n?o=!1:"false"==n&&(o=!0),fetch("http://localhost:5000/invoices/Update/",{method:"PUT",headers:{"Content-Type":"application/json"},body:JSON.stringify({lineItemId:parseInt(r),isBillable:o,invoiceId:parseInt(i)})}).then((function(){window.location.reload()}))}},setup:function(t){var e=Object(r["r"])({lineItems:[],description:"",quantity:"0",cost:"0",isbillable:!0,invoiceId:t.id});function n(){fetch("http://localhost:5000/invoices/".concat(t.id),{method:"GET",headers:{"Content-Type":"application/json"}}).then((function(t){t.json().then((function(t){return e.lineItems=t}))}))}function i(){fetch("http://localhost:5000/invoices/".concat(t.id),{method:"POST",headers:{"Content-Type":"application/json"},body:JSON.stringify({description:e.description,quantity:Number(e.quantity),cost:Number(e.cost),isBillable:e.isbillable})}).then(n)}return Object(r["n"])(n),{state:e,createLineItem:i}}});y.render=O;e["default"]=y},e01a:function(t,e,n){"use strict";var r=n("23e7"),i=n("83ab"),o=n("da84"),c=n("e330"),a=n("1a2d"),u=n("1626"),f=n("3a9b"),l=n("577e"),s=n("9bf2").f,b=n("e893"),d=o.Symbol,p=d&&d.prototype;if(i&&u(d)&&(!("description"in p)||void 0!==d().description)){var v={},h=function(){var t=arguments.length<1||void 0===arguments[0]?void 0:l(arguments[0]),e=f(p,this)?new d(t):void 0===t?d():d(t);return""===t&&(v[e]=!0),e};b(h,d),h.prototype=p,p.constructor=h;var O="Symbol(test)"==String(d("test")),y=c(p.toString),m=c(p.valueOf),j=/^Symbol\((.*)\)[^)]+$/,g=c("".replace),I=c("".slice);s(p,"description",{configurable:!0,get:function(){var t=m(this),e=y(t);if(a(v,t))return"";var n=O?I(e,7,-1):g(e,j,"$1");return""===n?void 0:n}}),r({global:!0,forced:!0},{Symbol:h})}},e25e:function(t,e,n){var r=n("23e7"),i=n("c20d");r({global:!0,forced:parseInt!=i},{parseInt:i})},e538:function(t,e,n){var r=n("b622");e.f=r},e8b5:function(t,e,n){var r=n("c6b6");t.exports=Array.isArray||function(t){return"Array"==r(t)}}}]);
//# sourceMappingURL=chunk-40132b25.62644b47.js.map