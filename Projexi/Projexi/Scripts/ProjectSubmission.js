(function ($) {
    $(document).ready(function () {
        $('#overview-submit').click(OnContinueClick);
    });

    function OnContinueClick(evt) {
        evt.preventDefault();
        $('.overview').hide('slide', { direction: 'left' }, 1000);
        $('.details').show('slide', { direction: 'right' }, 1000);
        $('#subheader').text('Details');
    }
})(jQuery);