// Print HTML content in a new window
window.printHtml = function (html) {
    var printWindow = window.open('', '_blank');
    if (printWindow) {
        printWindow.document.write(html);
        printWindow.document.close();
        printWindow.focus();
        printWindow.print();
    }
};
