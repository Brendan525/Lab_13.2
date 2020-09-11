
function displayPickUpTimeOrDeliveryAddress() {
    if (document.getElementById('pickup').checked) {
        document.getElementById('pickUpTime').style.display = 'block';
        document.getElementById('deliveryTime').style.display = 'none';
    }
    else if (document.getElementById('delivery').checked) {
        document.getElementById('deliveryTime').style.display = 'block';
        document.getElementById('pickUpTime').style.display = 'none';
    }
}
