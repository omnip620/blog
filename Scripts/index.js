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

    var good = function () {
        var $good = $("#good");

        $good.mouseover(function () {
            $good.html('<i class="icon-thumbs-up" ></i>');
            $good.css('font-size','18px')
        });

        $good.mouseout(function () {
            $good.html('<span>1244</span>');
            $good.css({ 'font-size': '12px'});
        });

    }

    return {
        init: function () {
            header();
            good();
        }

    }

}()