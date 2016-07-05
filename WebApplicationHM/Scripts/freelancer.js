// Freelancer Theme JavaScript

(function ($) {

    "use strict"; // Start of use strict

    
    $('a[href*=#]').on('click', function (event) {
        if (window.location.hash) {
            event.preventDefault();
            $('html,body').animate({ scrollTop: $(this.hash).offset().top }, 1000, 'easeInOutExpo');
        }
    });
    // *only* if we have anchor on the url
     if(window.location.hash) {

         // smooth scroll to the anchor id
         $('html, body').animate({
             scrollTop: $(window.location.hash).offset().top + 'px'
         }, 1000, 'easeInOutExpo');
     }
    


    // Highlight the top nav as scrolling occurs
    $('body').scrollspy({
        target: '.navbar-fixed-top',
        offset: 51
    });

    // Closes the Responsive Menu on Menu Item Click
    $('.navbar-collapse ul li a:not(.dropdown-toggle)').click(function() {
        $('.navbar-toggle:visible').click();
    });

    // Offset for Main Navigation
    $('#mainNav').affix({
        offset: {
            top: 100
        }
    })

    // Floating label headings for the contact form
    $(function() {
        $("body").on("input propertychange", ".floating-label-form-group", function(e) {
            $(this).toggleClass("floating-label-form-group-with-value", !!$(e.target).val());
        }).on("focus", ".floating-label-form-group", function() {
            $(this).addClass("floating-label-form-group-with-focus");
        }).on("blur", ".floating-label-form-group", function() {
            $(this).removeClass("floating-label-form-group-with-focus");
        });
    });

})(jQuery); // End of use strict
