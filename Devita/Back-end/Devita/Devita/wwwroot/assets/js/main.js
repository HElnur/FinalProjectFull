$('.owl-carousel').owlCarousel({
    loop:true,
    margin:10,
    dots:false,
    nav:true,
    responsive:{
        0:{
            items:2
        },
        600:{
            items:3
        },
        1000:{
            items:5
        }
    }
})

$(function () {
    $(document).on("click", ".addBasket", function (e) {
        e.preventDefault();
        let url = $(this).attr("href")
        fetch(url)
            .then(response => response.json())
            .then(data => {
                $(".order-text .count").text(data.basketItems.length + "item(s)")
                $(".shopping-cart-total  .salePrice").text("£" + data.totalAmount)

                $('#shopping-cart-items').html("");
                for (var i = 0; i < data.basketItems.length; i++) {
                    let element = `
                                            <li class="clearfix d-flex">
                            <img width="20%" height="20%" src="~/assets/image/`+ data.basketItems[i].productImage +`"
                                 alt="item1" />
                            <div class="price-prdname p-3">
                                <span class="item-name">@item.Name</span>
                                <span class="item-price">`+ data.basketItems[i].price +`</span>
                                <span class="item-quantity">Quantity: @item.Count</span>
                            </div>
                        </li>`
                    $('#shopping-cart-items').append($(element));
                    window.location.reload(true)
                }
            })
    })
    $(document).on("click", ".deleteBtn", function (e) {
        e.preventDefault();
        let url = $(this).attr("href")
        fetch(url)
            .then(response => response.text())
            .then(data => {
                window.location.reload(true)
                console.log(url)
            })
    })
})


$(".exploder").click(function () {

    $(this).toggleClass("btn-success btn-danger");

    $(this).children("span").toggleClass("glyphicon-search glyphicon-zoom-out");

    $(this).closest("tr").next("tr").toggleClass("hide");

    if ($(this).closest("tr").next("tr").hasClass("hide")) {
        $(this).closest("tr").next("tr").children("td").slideUp();
    }
    else {
        $(this).closest("tr").next("tr").children("td").slideDown(350);
    }
});

let stars = document.querySelectorAll(".star");
document.querySelector(".star-container").addEventListener("click", starRating);
let rating = document.querySelector(".rating");

function starRating(e) {
    stars.forEach((star) => star.classList.remove("star__checked"));
    const i = [...stars].indexOf(e.target);
    if (i > -1) {
        stars[i].classList.add("star__checked");
        rating.textContent = `${stars.length - i}/5`;
    } else {
        rating.textContent = `${0}/5`;
    }
}