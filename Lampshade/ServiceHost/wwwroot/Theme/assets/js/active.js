(function ($) {
    "use strict";

    /*=============================================
    =            menu sticky and scroll to top            =
    =============================================*/
    
    	

	/*----------  Menu sticky ----------*/

	var windows = $(window);
	var screenSize = windows.width();
	var sticky = $('.header-sticky');
	var stickyAbsolute = $('.header-sticky--absolute');
	var $html = $('html');
	var $body = $('body');


	windows.on('scroll', function () {
		var scroll = windows.scrollTop();
		var headerHeight = sticky.height();
		var headerHeightAbsolute = stickyAbsolute.height();

		if (screenSize >= 992) {
			if (scroll < headerHeight) {
				sticky.removeClass('is-sticky');
			} else {
				sticky.addClass('is-sticky');
            }
            
			if (scroll < headerHeightAbsolute) {
				stickyAbsolute.removeClass('is-sticky--absolute');
			} else {
				stickyAbsolute.addClass('is-sticky--absolute');
			}
		}



		//code for scroll top

		if (scroll >= 400) {
			$('#scroll-top').fadeIn();
		} else {
			$('#scroll-top').fadeOut();
		}

	});




	/*----------  Scroll to top  ----------*/

	$('#scroll-top').on('click', function () {
		$('html,body').animate({
			scrollTop: 0
		}, 2000);
	});

    
    /*=====  End of menu sticky and scroll to top  ======*/

    
    /*=============================================
    =            minicart and settings active            =
    =============================================*/
    
    $('#minicart-trigger').on('click', function(e){
        e.preventDefault();
        $(this).siblings('.mini-cart').toggleClass('active');
        $('#settings-menu-wrapper').removeClass('active');
        $('body').addClass('active-overlay');
    });

    $('#header-settings-trigger').on('click', function(e){
        e.preventDefault();
        $(this).siblings('.settings-menu-wrapper').toggleClass('active');
        $('#mini-cart').removeClass('active');
        $('body').addClass('active-overlay');
    });

    $('#currency-trigger').on('click', function(e){
        e.preventDefault();
        $(this).siblings('#currency-menu').toggleClass('active');
        $('body').addClass('active-overlay');
    });

    $('#language-trigger').on('click', function(e){
        e.preventDefault();
        $(this).siblings('#language-menu').toggleClass('active');
        $('body').addClass('active-overlay');
    });

    /*Minicart Close When Click Outside Minicart*/

    $('body').on('click', function(e){
        var $target = e.target;
        if (!$($target).is('.header-cart-icon, .header-settings-icon, #currency-trigger, #language-trigger') && !$($target).parents().is('.header-cart-icon, .header-settings-icon, #currency-trigger') && $('body').hasClass('active-overlay')) {
           $('.mini-cart, .settings-menu-wrapper, #currency-menu, #language-menu').removeClass('active');
           $('body').removeClass('active-overlay');
        }
    });
     
    /*=====  End of minicart and settings active  ======*/
    
    
    /*=============================================
    =            perfect scrollbar active            =
    =============================================*/
    
    $('.ps-scroll').each(function() {
		if($('.ps-scroll').length) {
			const ps = new PerfectScrollbar($(this)[0]);
		}
	});
    
    /*=====  End of perfect scrollbar active  ======*/

    /*=============================================
    =            search overlay active            =
    =============================================*/
    
    $('#search-overlay-trigger').on('click', function(){
        $('#search-overlay').show();
    });
    
    
    $('#close-search-overlay').on('click', function(){
        $('#search-overlay').hide();
    });
    
    /*=====  End of search overlay active  ======*/
    

    /*=============================================
    =            offcanvas menu            =
    =============================================*/
    
    var $offCanvasNav = $('.offcanvas-navigation'),
        $offCanvasNavSubMenu = $offCanvasNav.find('.sub-menu');
    
    /*Add Toggle Button With Off Canvas Sub Menu*/
    $offCanvasNavSubMenu.parent().prepend('<span class="menu-expand"><i></i></span>');
    
    /*Close Off Canvas Sub Menu*/
    $offCanvasNavSubMenu.slideUp();
    
    /*Category Sub Menu Toggle*/
    $offCanvasNav.on('click', 'li a, li .menu-expand', function(e) {
        var $this = $(this);
        if ( ($this.parent().attr('class').match(/\b(menu-item-has-children|has-children|has-sub-menu)\b/)) && ($this.attr('href') === '#' || $this.hasClass('menu-expand')) ) {
            e.preventDefault();
            if ($this.siblings('ul:visible').length){
                $this.parent('li').removeClass('active');
                $this.siblings('ul').slideUp();
            } else {
                $this.parent('li').addClass('active');
                $this.closest('li').siblings('li').removeClass('active').find('li').removeClass('active');
                $this.closest('li').siblings('li').find('ul:visible').slideUp();
                $this.siblings('ul').slideDown();
            }
        }
    });
    
    /*=====  End of offcanvas menu  ======*/

        
    /*=============================================
    =            mobile menu activation            =
    =============================================*/
    
    $('#mobile-menu-trigger').on('click', function(){
        $('#offcanvas-mobile-menu').removeClass('inactive').addClass('active');
    });
    
    
    $('#offcanvas-menu-close-trigger').on('click', function(){
        $('#offcanvas-mobile-menu').removeClass('active').addClass('inactive');
    });
    
    /*=====  End of mobile menu activation  ======*/

    
    /*=============================================
    =            slick slider active            =
    =============================================*/
    
    var $htSlickSlider = $('.ht-slick-slider');
    
    /*For RTL*/
    if( $html.attr("dir") == "rtl" || $body.attr("dir") == "rtl" ){
        $htSlickSlider.attr("dir", "rtl");
    }
    
    $htSlickSlider.each(function(){
        
        /*Setting Variables*/
        var $this = $(this),
            $setting = $this.data('slick-setting'),
            $autoPlay = $setting.autoplay ? $setting.autoplay : false,
            $autoPlaySpeed = parseInt($setting.autoplaySpeed, 10) || 2000,
            $speed = parseInt($setting.speed, 10) || 2000,
            $asNavFor = $setting.asNavFor ? $setting.asNavFor : null,
            $appendArrows = $setting.appendArrows ? $setting.appendArrows : $this,
            $appendDots = $setting.appendDots ? $setting.appendDots : $this,
            $arrows = $setting.arrows ? $setting.arrows : false,
            $prevArrow = $setting.prevArrow ? '<button class="'+ $setting.prevArrow.buttonClass +'"><i class="'+ $setting.prevArrow.iconClass +'"></i></button>' : '<button class="slick-prev">previous</button>',
            $nextArrow = $setting.nextArrow ? '<button class="'+ $setting.nextArrow.buttonClass +'"><i class="'+ $setting.nextArrow.iconClass +'"></i></button>' : '<button class="slick-next">next</button>',
            $centerMode = $setting.centerMode ? $setting.centerMode : false,
            $centerPadding = $setting.centerPadding ? $setting.centerPadding : '50px',
            $dots = $setting.dots ? $setting.dots : false,
            $fade = $setting.fade ? $setting.fade : false,
            $focusOnSelect = $setting.focusOnSelect ? $setting.focusOnSelect : false,
            $infinite = $setting.infinite ? $setting.infinite : false,
            $pauseOnHover = $setting.pauseOnHover ? $setting.pauseOnHover : true,
            $rows = parseInt($setting.rows, 10) || 1,
            $slidesToShow = parseInt($setting.slidesToShow, 10) || 1,
            $slidesToScroll = parseInt($setting.slidesToScroll, 10) || 1,
            $swipe = $setting.swipe ? $setting.swipe : true,
            $swipeToSlide = $setting.swipeToSlide ? $setting.swipeToSlide : false,
            $variableWidth = $setting.variableWidth ? $setting.variableWidth : false,
            $vertical = $setting.vertical ? $setting.vertical : false,
            $verticalSwiping = $setting.verticalSwiping ? $setting.verticalSwiping : false,
            $rtl = $setting.rtl || $html.attr('dir="rtl"') || $body.attr('dir="rtl"') ? true : false;
        
        /*Responsive Variable, Array & Loops*/
        var $responsiveSetting = typeof $this.data('slick-responsive') !== 'undefined' ? $this.data('slick-responsive') : '',
            $responsiveSettingLength = $responsiveSetting.length,
            $responsiveArray = [];
            for (var i = 0; i < $responsiveSettingLength; i++) {
				$responsiveArray[i] = $responsiveSetting[i];
				
			}

        /*Slider Start*/
        $this.slick({
            autoplay: $autoPlay,
			autoplaySpeed: $autoPlaySpeed,
			speed: $speed,
            asNavFor: $asNavFor,
            appendArrows: $appendArrows,
            appendDots: $appendDots,
            arrows: $arrows,
            dots: $dots,
            centerMode: $centerMode,
            centerPadding: $centerPadding,
            fade: $fade,
            focusOnSelect: $focusOnSelect,
            infinite: $infinite,
            pauseOnHover: $pauseOnHover,
            rows: $rows,
            slidesToShow: $slidesToShow,
            slidesToScroll: $slidesToScroll,
            swipe: $swipe,
            swipeToSlide: $swipeToSlide,
            variableWidth: $variableWidth,
            vertical: $vertical,
            verticalSwiping: $verticalSwiping,
            rtl: $rtl,
            prevArrow: $prevArrow,
            nextArrow: $nextArrow,
			responsive: $responsiveArray
        });
        
	});
	
    
    /*=====  End of slick slider active  ======*/


    
    /*=============================================
    =            masonry activation            =
    =============================================*/
    
    windows.on("load", function(){
        $('.masonry-category-layout').masonry();
        $('.masonry-category-layout--style2').masonry();
    });
    
    
    /*=====  End of masonry activation  ======*/
    


        
    
    /*=============================================
    =            mailchimp active            =
    =============================================*/
    
    $('#mc-form').ajaxChimp({
		language: 'en',
		callback: mailChimpResponse,
		// ADD YOUR MAILCHIMP URL BELOW HERE!
		url: 'http://devitems.us11.list-manage.com/subscribe/post?u=6bbb9b6f5827bd842d9640c82&amp;id=05d85f18ef'

	});
    
    $('#mc-form2').ajaxChimp({
		language: 'en',
		callback: mailChimpResponse2,
		// ADD YOUR MAILCHIMP URL BELOW HERE!
		url: 'http://devitems.us11.list-manage.com/subscribe/post?u=6bbb9b6f5827bd842d9640c82&amp;id=05d85f18ef'

	});

	function mailChimpResponse(resp) {

		if (resp.result === 'success') {
			$('.mailchimp-success').html('' + resp.msg).fadeIn(900);
			$('.mailchimp-error').fadeOut(400);

		} else if (resp.result === 'error') {
			$('.mailchimp-error').html('' + resp.msg).fadeIn(900);
		}
	}

	function mailChimpResponse2(resp) {

		if (resp.result === 'success') {
			$('.mailchimp-success2').html('' + resp.msg).fadeIn(900);
			$('.mailchimp-error2').fadeOut(400);

		} else if (resp.result === 'error') {
			$('.mailchimp-error2').html('' + resp.msg).fadeIn(900);
		}
	}
    
    /*=====  End of mailchimp active  ======*/
    

     /*=============================================
    =            newsletter popup area            =
    =============================================*/
    
    $("#close-newsletter-popup").on("click", function(){
        $("#newsletter-popup-area").addClass("d-none");
    });
    
    /*=====  End of newsletter popup area  ======*/

    /*=============================================
    =            price range            =
    =============================================*/
    
    
	$('#price-range').slider({
		range: true,
		min: 0,
		max: 1000,
		values: [ 0, 900 ],
		slide: function( event, ui ) {
			$('#price-amount').val( '$' + ui.values[ 0 ] + ' - $' + ui.values[ 1 ] );
		}
	});
	$('#price-amount').val('$' + $('#price-range').slider( 'values', 0 ) +
		' - $' + $('#price-range').slider('values', 1 ) ); 
    
    /*=====  End of price range  ======*/

    /*=============================================
    =            product view mode            =
    =============================================*/

	$('.grid-icons button').on('click', function (e) {
		e.preventDefault();

		var shopProductWrap = $('.shop-product-wrap');
		var viewMode = $(this).data('target');

		$('.grid-icons button').removeClass('active');
		$(this).addClass('active');
        shopProductWrap.removeClass('grid three-column four-column five-column list').addClass(viewMode);
        
        if(viewMode == 'grid three-column'){
			shopProductWrap.children().addClass('col-lg-4').removeClass('col-lg-3 col-lg-is-5');
		}

		if(viewMode == 'grid four-column'){
			shopProductWrap.children().addClass('col-lg-3').removeClass('col-lg-4 col-lg-is-5');
		}

		if(viewMode == 'grid five-column'){
			shopProductWrap.children().addClass('col-lg-is-5').removeClass('col-lg-4 col-lg-3');
		}
	});
    /*=====  End of product view mode  ======*/

    
    /*=============================================
    =            countdown active            =
    =============================================*/
    
    $('[data-countdown]').each(function () {
		var $this = $(this),
		finalDate = $(this).data('countdown');
		$this.countdown(finalDate, function (event) {
			$this.html(event.strftime('<div class="single-countdown"><span class="single-countdown-time">%D</span><span class="single-countdown-text">Days</span></div><div class="single-countdown"><span class="single-countdown-time">%H</span><span class="single-countdown-text">Hours</span></div><div class="single-countdown"><span class="single-countdown-time">%M</span><span class="single-countdown-text">Mins</span></div><div class="single-countdown"><span class="single-countdown-time">%S</span><span class="single-countdown-text">Secs</span></div>'));
		});
	});
    
    /*=====  End of countdown active  ======*/
    

    
    /*=============================================
    =            zoom and light gallery active            =
    =============================================*/
    
    $('.product-details-big-image-slider-wrapper .single-image').zoom();

    $('.big-image-slider-wrapper .big-image-slider-single-item').zoom();

    
    /*=====  End of zoom active  ======*/

    /*=============================================
    =            sticky sidebar active          =
    =============================================*/
    
    $('.single-product-details-sticky').stickySidebar({
		topSpacing: 90,
		bottomSpacing: -80,
		minWidth: 768
	});
    
    /*=====  End of sticky sidebar active  ======*/

        
    /*=============================================
    =            payment  method select            =
    =============================================*/
    
    
    $('[name="paymentMethod"]').on('click', function () {

        var $value = $(this).attr('value');

        $('.single-method p').slideUp();
        $('[data-method="' + $value + '"]').slideDown();

    });
    
    
    /*=====  End of payment  method select  ======*/
    
    
    /*=============================================
    =            shipping form toggle            =
    =============================================*/
    
	$('[data-shipping]').on('click', function () {
		if ($('[data-shipping]:checked').length > 0) {
			$('#shipping-form').slideDown();
		} else {
			$('#shipping-form').slideUp();
		}
	});
    /*=====  End of shipping form toggle  ======*/
    
        
    
    /*=============================================
    =            blog post gallery active           =
    =============================================*/
    
    var blogPostSlider = $('.blog-image-gallery');
    blogPostSlider.slick({
        prevArrow: '<button type="button" class="slick-prev"><i class="fa fa-chevron-left"></i></button>',
        nextArrow: '<button type="button" class="slick-next"><i class="fa fa-chevron-right"></i></button>',
        arrows: true,
        autoplay: true,
        autoplaySpeed: 4000,
        dots: false,
        pauseOnFocus: false,
        pauseOnHover: false,
        infinite: true,
        slidesToShow: 1
    });
    /*=====  End of blog post gallery  ======*/

})(jQuery);