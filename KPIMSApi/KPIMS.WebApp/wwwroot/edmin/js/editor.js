var editor;
window.initializeEditor = (selector) => {
    editor = $(selector).kendoEditor({
        stylesheets: [
            "../content/shared/styles/editor.css",
        ],
        tools: [
            "undo",
            "redo",
            { name: "separator1", type: "separator" },
            {
                name: "fontName",
                items: [
                    { text: "Andale Mono", value: "\"Andale Mono\"" }, // Font-family names composed of several words should be wrapped in \" \"
                    { text: "Arial", value: "Arial" },
                    { text: "Arial Black", value: "\"Arial Black\"" },
                    { text: "Book Antiqua", value: "\"Book Antiqua\"" },
                    { text: "Comic Sans MS", value: "\"Comic Sans MS\"" },
                    { text: "Courier New", value: "\"Courier New\"" },
                    { text: "Georgia", value: "Georgia" },
                    { text: "Helvetica", value: "Helvetica" },
                    { text: "Impact", value: "Impact" },
                    { text: "Symbol", value: "Symbol" },
                    { text: "Tahoma", value: "Tahoma" },
                    { text: "Terminal", value: "Terminal" },
                    { text: "Times New Roman", value: "\"Times New Roman\"" },
                    { text: "Trebuchet MS", value: "\"Trebuchet MS\"" },
                    { text: "Verdana", value: "Verdana" },
                ]
            },
            "fontSize",
            "bold",
            "italic",
            "underline",
            "backColor",
            "foreColor",
            { name: "separator2", type: "separator" },
            "insertUnorderedList",
            "justifyLeft",
            "justifyCenter",
            "justifyRight",
            { name: "separator3", type: "separator" },
            "formatting",
            { name: "separator4", type: "separator" },
            "createLink",
            "unlink",
            "insertImage",
            { name: "separator5", type: "separator" },
            "tableWizard",
            "tableProperties",
            "tableCellProperties",
            "createTable",
            "addRowAbove",
            "addRowBelow",
            "addColumnLeft",
            "addColumnRight",
            "deleteRow",
            "deleteColumn",
            "mergeCellsHorizontally",
            "mergeCellsVertically",
            "splitCellHorizontally",
            "splitCellVertically",
            "tableAlignLeft",
            "tableAlignCenter",
            "tableAlignRight"
        ]
    });
};

window.destroyEditor = () => {
    if (editor) {
        editor.destroy();
        editor = null;
    }
};