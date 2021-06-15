var WithdrawDOLPController = function () {
    this.initialize = function () {
        registerEvents();
        registerControl();
    }

    function registerControl() {

        $(".numberFormat").each(function () {
            var numberValue = parseFloat($(this).val().replace(/,/g, ''));
            if (!numberValue) {
                $(this).val(be.formatCurrency(0));
            }
            else {
                $(this).val(be.formatCurrency(numberValue));
            }
        });

    }

    function registerEvents() {

        $('#btnWithdraw').on('click', function (e) {
            e.preventDefault();
            withdraw();
        });
    }

    function withdraw() {

        var data = {
            AddressReceiving: $('#txtAddressReceiving').val(),
        };

        var isValid = true;


        if (!data.AddressReceiving) {
            isValid = be.notify('Address receiving is required.', '', 'error');
        }

        if (isValid) {
            $.ajax({
                type: "POST",
                url: "/Admin/withdrawDolp/Withdraw",
                dataType: "json",
                data: { modelJson: JSON.stringify(data) },
                beforeSend: function () {
                    be.startLoading();
                },
                success: function (response) {
                    if (response.Success) {
                        be.success('Withdraw DOLP', response.Message, function () {
                            window.location.reload();
                        });
                    }
                    else {
                        be.error('Withdraw DOLP', response.Message);
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
}