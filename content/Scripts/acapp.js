(function(_w, _d, $) {
    /* STORE REFERENCES TO PREVENT EXTERNAL INFLUENCES
       _w = window
       _d = document
       _s = this
    */
    var _s = this;

    /* DEFAULT SETTINGS */
    var settings = {        
        homepage: '/acapp/home/'
    };

    /* CONTAINERS */
    var $application = null;

    /* MAIN FUNCTION TO ADD BIND */
    $.fn.Acapp = function(method) {
        if (typeof(_s[method]) == "function") {
            return _s[method].apply(this, Array.prototype.slice.call(arguments, 1));
        } else if (typeof method === 'object' || !method) {
            return _s.init.apply(this, arguments);
        } else {
            $.error('Method ' + method + ' does not exist on jQuery');
            return false;
        }
    };

    /* STARTUP */

    /// <summary>
    /// This is the base method that is called. It will load the basic settings
    /// </summary>
    /// <remarks>
    /// 2014-05-16: Created
    /// </remarks>
    init = function(options) {
        //make sure the site loads on base url
        if (window.location.pathname != '/') {
            window.location.href = '/';
        }

        //store the container
        $application = $(this);
        
        //load user settings
        settings = $.extend(settings, options);
    }
    
})(window, document, jQuery);

