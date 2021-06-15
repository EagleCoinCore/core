var HomeController = function () {
    this.initialize = function () {
        registerEvents();
    }

    var countDownDate = new Date("May 2, 2021 21:00:00").getTime();

    function registerEvents() {
        loadBuyCountDownDate(countDownDate);

        $('#btnBuy').on('click', function (e) {
            e.preventDefault();
            buy();
        });

        $('.txtTRXAmount').on("keyup", function (e) {
            getTRXPaymentAmount($(this).val());
        });
    };

    function getTRXPaymentAmount(element) {
        debugger;

        var data = {
            Amount: parseFloat(element.replace(/,/g, '')),
        };

        if (data.Amount) {
            $.ajax({
                type: "POST",
                url: "/Admin/Home/GetTRXPaymentAmount",
                dataType: "json",
                data: { modelJson: JSON.stringify(data) },
                beforeSend: function () {
                    be.startLoading();
                },
                success: function (response) {
                    debugger;
                    if (response.Success) {
                        $("#txtTTReceiving").val(be.formatCurrency(response.Data));
                    }
                    else {
                        be.notify(response.Message, "", 'error');
                    }
                    be.stopLoading();
                },
                error: function (message) {
                    be.notify(`${message.responseText}`, `Status code: ${message.status}`, 'error');
                    be.stopLoading();
                }
            });
        }
    }

    function buy() {

        var data = {
            Amount: parseFloat($('#txtAmount').val().replace(/,/g, '')),
        };

        var isValid = true;

        if (data.Amount <= 0) {
            isValid = be.notify('Amount is required.', '', 'error');
        }

        if (isValid) {
            $.ajax({
                type: "POST",
                url: "/Admin/Home/Buy",
                dataType: "json",
                data: { modelJson: JSON.stringify(data) },
                beforeSend: function () {
                    be.startLoading();
                },
                success: function (response) {
                    if (response.Success) {
                        be.success('Buy TickTok (TT)', response.Message, function () {
                            window.location.reload();
                        });
                    }
                    else {
                        be.error('Buy TickTok (TT)', response.Message);
                    }

                    be.stopLoading();
                },
                error: function (message) {
                    be.notify(`${message.responseText}`, `Status code: ${message.status}`, 'error');
                    be.stopLoading();
                }
            });
        }
    }

    // Set the date we're counting down to
    function loadBuyCountDownDate(countDownDate) {

        // Update the count down every 1 second
        var x = setInterval(function () {

            // Get today's date and time
            var nowDate = new Date();

            var now = nowDate.getTime();

            // Find the distance between now and the count down date
            var distance = countDownDate - now;

            // Time calculations for days, hours, minutes and seconds
            var days = Math.floor(distance / (1000 * 60 * 60 * 24));
            var hours = Math.floor((distance % (1000 * 60 * 60 * 24)) / (1000 * 60 * 60));
            var minutes = Math.floor((distance % (1000 * 60 * 60)) / (1000 * 60));
            var seconds = Math.floor((distance % (1000 * 60)) / 1000);

            // If the count down is over, write some text 
            if (distance < 0) {

                clearInterval(x);

                $('#header-buy-private-sale').hide();
                $('#form-buy-private-sale').show();

                var y = setInterval(function () {
                    clearInterval(y);
                    $('#header-buy-private-sale').show();
                    $('#form-buy-private-sale').hide();
                }, 60 * 1000)
            }
            else {
                $('#form-buy-private-sale').hide();
                document.getElementById("boxDay").innerHTML = days;
                document.getElementById("boxHours").innerHTML = hours;
                document.getElementById("boxMin").innerHTML = minutes;
                document.getElementById("boxSeconds").innerHTML = seconds;
            }
        }, 1000);

    }
}
