//$(tabs());
//$(window).resize(tabs());
var tabsWidth = {};
var tabsLeft = {};

var hash = window.location.hash;
if (!hash && typeof anchorTag != 'undefined') {
    hash = anchorTag;
}

window.onresize = tabs;

var handler = window.onresize;
handler.apply(window, [' On']);

//$(window).on('resize', tabs());

function tabs() {
    var tabs = $('.nav.nav-tabs');

    for (var n = 0; n < tabs.length; n++) {
        var id = n + 1;

        var tabsElements = $(tabs[n]).children();
        var numTabs = $(tabs[n]).children().length;

        if (!$(tabsElements[tabsElements.length-1]).hasClass('ms-tabs-indicator')) {
            $(tabs[n]).data('id', id);
            $(tabs[n]).append('<span id="i' + id +'" class="ms-tabs-indicator"></span>');
        }
        var indicator = $('#i' + id);

        tabsWidth['tabW' + id] = [];
        tabsLeft['tabL' + id] = [];
        var currentWidth = tabsWidth['tabW' + id];
        var currentLeft = tabsLeft['tabL' + id];

        var tabLeft = 0;
        for(m = 0; m < numTabs; m++) {
            currentLeft[m] = tabLeft;
            currentWidth[m] = $(tabsElements[m]).width();

            if($(tabsElements[m]).children().hasClass('active')) {
                indicator.css({
                    left: currentLeft[m] + 'px',
                    width: currentWidth[m] + 'px'
                });
            }

            tabLeft += currentWidth[m];
        }

        var preselectedTab = $(tabs[n]).find('li > a[href="' + hash + '"]');
        if (preselectedTab.length > 0)
        {
            showTab(preselectedTab.parent());
            preselectedTab.tab('show');
        }
    }

    $('.nav.nav-tabs > li').click(function (event) {
        showTab(this);
    });
}

function showTab(el)
{
    tabsElements = $(el).parent();
    var id = tabsElements.data('id');
    tabsElements.children().removeClass('current');
    $(el).addClass('current');
    var tabs = tabsElements.children();
    for (var i = 0; i < tabs.length - 1; i++) {
        if ($(tabs[i]).hasClass('current')) {
            $('#i' + id).css({
                left: tabsLeft['tabL' + id][i] + 'px',
                width: tabsWidth['tabW' + id][i] + 'px'
            });
        }
    }

    var tabId = $(el).find('a').attr("href").substr(1);
    var yScroll = document.body.scrollTop;
    window.location.hash = tabId;
    document.body.scrollTop = yScroll;
}

$('#ms-account-modal').on('shown.bs.modal', function (e) {
    setTimeout(tabs, 700);
});
