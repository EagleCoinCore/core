var WalletController = function () {
    this.initialize = function () {
        loadWalletDeposits();
        registerEvents();
        registerControl();
    }
    function registerControl() {
        jQuery('#qrcodeTRXPublishKey').qrcode({
            text: $("#txtTRXPublishKey").val()
        });

        jQuery('#qrcodeUSDTTRC20PublishKey').qrcode({
            text: $("#txtUSDTTRC20PublishKey").val()
        });

        $(".numberFormat").each(function () {
            var numberValue = parseFloat($(this).html().replace(/,/g, ''));
            if (!numberValue) {
                $(this).html(be.formatCurrency(0));
            }
            else {
                $(this).html(be.formatCurrency(numberValue));
            }
        });

    }

    var registerEvents = function () {

        $('body').on('click', '#btnCopyTRXPublishKey', function (e) {
            copyTRXPublishKey();
        });
        $('body').on('click', '#btnCopyUSDTTRC20PublishKey', function (e) {
            copyUSDTTRC20PublishKey();
        });

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

        $('#btnWithdrawTRX').on('click', function (e) {
            e.preventDefault();
            withdrawTRX();
        });
        $('#btnWithdrawUSDTTRC20').on('click', function (e) {
            e.preventDefault();
            withdrawUSDTTRC20();
        });
    }

    function withdrawUSDTTRC20() {

        var data = {
            AddressReceiving: $('#txtAddressReceivingUSDTTRC20').val(),
            Amount: parseFloat($('#txtAmountUSDTTRC20').val().replace(/,/g, '')),
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
                url: "/Admin/Wallet/WithdrawUSDTTRC20",
                dataType: "json",
                data: { modelJson: JSON.stringify(data) },
                beforeSend: function () {
                    be.startLoading();
                },
                success: function (response) {
                    if (response.Success) {
                        be.success('Withdraw USDT TRC20', response.Message, function () {
                            window.location.reload();
                        });
                    }
                    else {
                        be.error('Withdraw USDT TRC20', response.Message);
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

    function withdrawTRX() {

        var data = {
            AddressReceiving: $('#txtAddressReceiving').val(),
            Amount: parseFloat($('#txtAmount').val().replace(/,/g, '')),
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
                url: "/Admin/Wallet/WithdrawTRX",
                dataType: "json",
                data: { modelJson: JSON.stringify(data) },
                beforeSend: function () {
                    be.startLoading();
                },
                success: function (response) {
                    if (response.Success) {
                        be.success('Withdraw TRX', response.Message, function () {
                            window.location.reload();
                        });
                    }
                    else {
                        be.error('Withdraw TRX', response.Message);
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
                $('.walletTrxDeposit').html(be.formatCurrency(response.WalletTRX));
                $('#trxBalance').val(be.formatCurrency(response.WalletTRX));

                $('.walletUsdtTrc20Deposit').html(be.formatCurrency(response.WalletUSDTTRC20));
                $('#usdttrc20Balance').val(be.formatCurrency(response.WalletUSDTTRC20));
            },
            error: function (message) {
                be.notify(`${message.responseText}`, `Status code: ${message.status}`, 'error');
            }
        });
    }
    function copyUSDTTRC20PublishKey() {
        var copyText = $("#txtUSDTTRC20PublishKey");
        copyText.select();
        document.execCommand("copy");
    }
    function copyTRXPublishKey() {
        var copyText = $("#txtTRXPublishKey");
        copyText.select();
        document.execCommand("copy");
    }
}