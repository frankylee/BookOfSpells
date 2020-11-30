
// Prevent page reload from jumping to top when visitor
// submits email address in the newsletter signup block.
// Credit: http://www.codestore.net/store.nsf/unid/BLOG-20110427-0501
//
function jumpTo() {
    $(document).ready(function () {
        var anchor = 'newsletterSignup';
        $(this).scrollTop($('#' + anchor).position().top)
    });
}