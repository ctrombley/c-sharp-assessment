(function($) {

	function ex1() {

		function foo(x) {
			var tmp = 3;

			return function(y) {
				alert(x + y + (++tmp));
			};
		}

		var bar = foo(2);
		bar(10);
		bar(10);
	}
	
}(jQuery));
