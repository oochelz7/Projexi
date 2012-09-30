(function ($) {
    $(document).ready(function () {
        $('#overview-submit').click(OnContinueClick);
        $('#details-previous').click(OnPreviousClick);
        if (!isMobile.any())
            $('.date input').datepicker({ showButtonPanel: true });
    });

    function OnContinueClick(evt) {
        evt.preventDefault();
        $('#panel-overview').hide('slide', { direction: 'left' }, 1000);
        $('#subheader-overview').hide('slide', { direction: 'left' }, 1000);
        $('#panel-details').show('slide', { direction: 'right' }, 1000);
        $('#subheader-details').show('slide', { direction: 'right' }, 1000);
    }

    function OnPreviousClick(evt) {
        evt.preventDefault();
        $('#panel-details').hide('slide', { direction: 'right' }, 1000);
        $('#subheader-details').hide('slide', { direction: 'right' }, 1000);
        $('#panel-overview').show('slide', { direction: 'left' }, 1000);
        $('#subheader-overview').show('slide', { direction: 'left' }, 1000);
    }

    var isMobile = {
        Android: function () {
            return navigator.userAgent.match(/Android/i) ? true : false;
        },
        BlackBerry: function () {
            return navigator.userAgent.match(/BlackBerry/i) ? true : false;
        },
        iOS: function () {
            return navigator.userAgent.match(/iPhone|iPad|iPod/i) ? true : false;
        },
        Windows: function () {
            return navigator.userAgent.match(/IEMobile/i) ? true : false;
        },
        any: function () {
            return (isMobile.Android() || isMobile.BlackBerry() || isMobile.iOS() || isMobile.Windows());
        }
    };
})(jQuery);