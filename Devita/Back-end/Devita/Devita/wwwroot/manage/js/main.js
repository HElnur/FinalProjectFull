$(function() {
    $(document).on("click", ".img-box-remove", function () {
        console.log("img remove")

        let Id = $(this).attr("data-id");
        let url = $(this).attr("href");

        fetch(url + Id)
            .then(response => response.text())
            .then(data => {
                console.log(data);
            })

        $(".img-box").remove();
    })
})