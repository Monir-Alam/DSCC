var dataTable;

$(document).ready(function () {
    loadDataTable();
})

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": {
            "url": "/Category/GetAll"
        },
        "columns": [
            { "data": "fileHeading" },
            { "data": "fileInDate" },
            { "data": "fileOutDate" },
        ]
    });
}