(function ($) {
    $(document).ready(function () {
        $('#overview-submit').click(OnContinueClick);
        $('#details-previous').click(OnPreviousClick);
    });

    function OnContinueClick(evt) {
        evt.preventDefault();
        $('.overview').hide('slide', { direction: 'left' }, 1000);
        $('.details').show('slide', { direction: 'right' }, 1000);
        $('#subheader').text('Details');
    }

    function OnPreviousClick(evt) {
        evt.preventDefault();
        $('.details').hide('slide', { direction: 'right' }, 1000);
        $('.overview').show('slide', { direction: 'left' }, 1000);
        $('#subheader').text('Overview');
    }
})(jQuery);