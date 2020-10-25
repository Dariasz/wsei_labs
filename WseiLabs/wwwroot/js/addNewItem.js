(function () {
    const alertElement = document.getElementById("success-alert");
    const formElement = document.forms[0];
    const addNewItem = async () => {
        let formData = {Name: "Bike", Description: "The fastest bike", IsVisible: true};
        
        const response = await fetch("/api/Item", {
            method: 'POST',
            headers: {"Content-type": "application/json"},
            body: JSON.stringify(formData)
        })
        
        // const responseJson = await response.json();
        
        if (response.ok) {
            alertElement.style.display = "block";
        }
    };
    window.addEventListener("load", () => {
        formElement.addEventListener("submit", event => {
            event.preventDefault();
            addNewItem().then(() => console.log("added successfully"));
        });
    });
})();