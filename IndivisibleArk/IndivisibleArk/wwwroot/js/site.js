// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

//function ViewFunction(){
//    console.log("clicked using site.js!");
//
//}

function genFunction(script_text, user_name, con_name) {
    console.log("clicked generator button");
    console.log(script_text);
    console.log(user_name);
    console.log(con_name);
    let s_text = script_text.toString;
    s_text.replaceall("_c_", con_name);
    s_text.replaceall("_v_", user_name);

    console.log(s_text);
}


function copyTextToClipboard(text) {

    if (!navigator.clipboard) {
        fallbackCopyTextToClipboard(text);
        return;
    }

    navigator.clipboard.writeText(text).then(function () {
        console.log('Async: Copying to clipboard was successful!');
    }, function (err) {
        console.error('Async: Could not copy text: ', err);
    });

}
