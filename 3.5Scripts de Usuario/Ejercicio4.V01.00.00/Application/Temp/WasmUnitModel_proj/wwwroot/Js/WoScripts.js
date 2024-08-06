
function SaveFile(fileName, bytesBase64) {
    var link = document.createElement('a');
    link.download = fileName;
    link.href = "data:application/octet-stream;base64," + bytesBase64;
    document.body.appendChild(link);
    link.click();
    document.body.removeChild(link);
}

function PrintFile(filename, contentType, content) {
    const file = new File([content], filename, { type: contentType });
    const exportUrl = URL.createObjectURL(file);
 
    window.open(exportUrl).print()
}