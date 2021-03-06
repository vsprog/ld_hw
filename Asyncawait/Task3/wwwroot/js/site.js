(function () {
    $(window).on('load', () => {
        $.ajax({
            url: '/cart/GetShortModel',
            method: 'GET',
            dataType: 'json',
            contentType: 'application/json; charset=utf-8',
            success: (data, textStatus, request) => {
                updateCartInfo(data);
            }
        });
    });

    $('.store').on('click', (e) => {
        var sender = $(e.target);
        if (sender.prop('tagName').toLowerCase() !== 'button') return;

        $.ajax({
            url: '/cart/AddToCart',
            method: 'POST',
            data: JSON.stringify(sender.data('productId')),
            dataType: 'json',
            contentType: 'application/json; charset=utf-8',
            success: (data, textStatus, request) => {
                updateCartInfo(data);
            }
        });
    });

    $('.cart').on('click', (e) => {
        var sender = $(e.target);
        if (sender.prop('tagName').toLowerCase() !== 'button') return;

        $.ajax({
            url: '/cart/RemoveFromCart',
            method: 'DELETE',
            data: JSON.stringify(sender.data('productId')),
            dataType: 'json',
            contentType: 'application/json; charset=utf-8',
            success: (data, textStatus, request) => {
                sender.parent().parent().remove();
                updateCartInfo(data);
                $('.cart__total-sum').html(data.totalSum);
            }
        });
    });

    function updateCartInfo(cartViewModel) {
        let headerCartElement = $('.session-cart');

        if (cartViewModel.totalItems == 0) headerCartElement.addClass('d-none');
        else headerCartElement.removeClass('d-none');

        $('.session-cart__count').html(cartViewModel.totalItems);
        $('.session-cart__total-price').html(cartViewModel.totalSum);
    }
})()