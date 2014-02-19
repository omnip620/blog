var App = function () {

    var winWidth = window.innerWidth;
    var winHeight = window.innerHeight;
    var doc = $(document);
    var header = function () {
        var added;
        doc.scroll(function (e) {
            if (doc.scrollTop() > 5) {
                if (added) return;
                added = true;
                $('header').addClass('header');
            } else {
                $('header').removeClass('header');
                added = false;
            }
        })

    }

    return {
        init: function () {
            header();
        }

    }

}()