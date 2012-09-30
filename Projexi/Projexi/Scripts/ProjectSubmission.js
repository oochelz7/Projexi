(function ($) {
    $(document).ready(function () {
        $('#overview-submit').click(OnContinueClick);
        $('#details-previous').click(OnPreviousClick);
        $('.date input').datepicker();
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
})(jQuery);