var editor = ace.edit("editor");
editor.setTheme("ace/theme/dawn");
editor.session.setMode("ace/mode/plain");
 
editor.getSession().setUseWrapMode(true);
editor.setHighlightActiveLine(false);
//启用提示菜单
//自动换行,设置为off关闭
editor.setOption("wrap", "free")
ace.require("ace/ext/language_tools");
editor.setOptions({
    enableBasicAutocompletion: true,
    enableSnippets: true,
    enableLiveAutocompletion: true
});
//是否显示边距线
editor.setShowPrintMargin(false);
//var autoCompleteData = [{ "meta": "function", "caption": "addShape", "value": "addShape", "score": 1 }, { "meta": "function", "caption": "addShape.adc", "value": "addShape.adc", "score": 1 }, { "meta": "function", "caption": "addShape.ccc", "value": "addShape.ccc", "score": 1 }];
//var tangideCompleter = {
//    getCompletions: function (editor, session, pos, prefix, callback) {
//        if (prefix.length === 0) {
//            return callback(null, []);
//        } else {
//            return callback(null, autoCompleteData);
//        }
//    }
//}
//var langTools = ace.require("ace/ext/language_tools");
//langTools.addCompleter(tangideCompleter);
 