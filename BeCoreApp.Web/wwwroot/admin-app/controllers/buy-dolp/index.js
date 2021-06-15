var BuyDOLPController = function () {
    this.initialize = function () {
        loadWalletDeposits();
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

        $('.numberFormat').on("keypress", function (e) {
            var keyCode = e.which ? e.which : e.keyCode;
            var ret = ((keyCode >= 48 && keyCode <= 57) || keyCode == 46);
            if (ret)
                return true;
            else
                return false;
        });

        $(".numberFormat").focusout(function () {
            var numberValue = parseFloat($(this).val().replace(/,/g, ''));
            if (!numberValue) {
                $(this).val(be.formatCurrency(0));
            }
            else {
                $(this).val(be.formatCurrency(numberValue));
            }
        });

        $('#btnBuy').on('click', function (e) {
            e.preventDefault();
            buy();
        });
        $('.txtTRXAmount').on("keyup", function (e) {
            getTRXPaymentAmount($(this).val());
        });

        $('#btnUSDTTRC20Buy').on('click', function (e) {
            e.preventDefault();
            buyUSDTTRC20();
        });
        $('.txtUSDTTRC20Amount').on("keyup", function (e) {
            getUSDTTRC20PaymentAmount($(this).val());
        });
    }

    function getUSDTTRC20PaymentAmount(element) {
        debugger;

        var data = {
            Amount: parseFloat(element.replace(/,/g, '')),
        };

        if (data.Amount) {
            $.ajax({
                type: "POST",
                url: "/Admin/BuyDOLP/GetUSDTTRC20PaymentAmount",
                dataType: "json",
                data: { modelJson: JSON.stringify(data) },
                beforeSend: function () {
                    be.startLoading();
                },
                success: function (response) {
                    debugger;
                    if (response.Success) {
                        $("#txtUSDTTRC20DOLPReceiving").val(be.formatCurrency(response.Data));
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
    function buyUSDTTRC20() {

        var data = {
            Amount: parseFloat($('#txtUSDTTRC20Amount').val().replace(/,/g, '')),
            AddressReceiving: $('#txtUSDTTRC20AddressReceiving').val(),
        };

        var isValid = true;

        if (data.Amount <= 0) {
            isValid = be.notify('Amount is required.', '', 'error');
        }

        if (!data.AddressReceiving) {
            isValid = be.notify('Address receiving is required.', '', 'error');
        }

        if (isValid) {
            $.ajax({
                type: "POST",
                url: "/Admin/BuyDOLP/BuyUSDT",
                dataType: "json",
                data: { modelJson: JSON.stringify(data) },
                beforeSend: function () {
                    be.startLoading();
                },
                success: function (response) {
                    if (response.Success) {
                        be.success('Buy DOLP', response.Message, function () {
                            window.location.reload();
                        });
                    }
                    else {
                        be.error('Buy DOLP', response.Message);
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
            AddressReceiving: $('#txtAddressReceiving').val(),
        };

        var isValid = true;

        if (data.Amount <= 0) {
            isValid = be.notify('Amount is required.', '', 'error');
        }

        if (!data.AddressReceiving) {
            isValid = be.notify('Address receiving is required.', '', 'error');
        }

        if (isValid) {
            $.ajax({
                type: "POST",
                url: "/Admin/BuyDOLP/Buy",
                dataType: "json",
                data: { modelJson: JSON.stringify(data) },
                beforeSend: function () {
                    be.startLoading();
                },
                success: function (response) {
                    if (response.Success) {
                        be.success('Buy DOLP', response.Message, function () {
                            window.location.reload();
                        });
                    }
                    else {
                        be.error('Buy DOLP', response.Message);
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
    function getTRXPaymentAmount(element) {
        debugger;

        var data = {
            Amount: parseFloat(element.replace(/,/g, '')),
        };

        if (data.Amount) {
            $.ajax({
                type: "POST",
                url: "/Admin/BuyDOLP/GetTRXPaymentAmount",
                dataType: "json",
                data: { modelJson: JSON.stringify(data) },
                beforeSend: function () {
                    be.startLoading();
                },
                success: function (response) {
                    debugger;
                    if (response.Success) {
                        $("#txtDOLPReceiving").val(be.formatCurrency(response.Data));
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

    function loadWalletDeposits() {
        $.ajax({
            type: 'GET',
            url: '/admin/Wallet/GetWalletDeposits',
            dataType: 'json',
            beforeSend: function () {
            },
            success: function (response) {
                $('#trxBalance').val(be.formatCurrency(response.WalletTRX));
                $('#usdtTRC20Balance').val(be.formatCurrency(response.WalletUSDTTRC20));
            },
            error: function (message) {
                be.notify(`${message.responseText}`, `Status code: ${message.status}`, 'error');
            }
        });
    }
}