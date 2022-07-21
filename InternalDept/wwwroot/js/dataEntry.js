var dataTable;

$(document).ready(function () {
    loadDataTable();
})

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": {
            "url": "/Category/Index"
        },
        "columns": [
            { "data": "FileHeading" },
            { "data": "FileInDate" },
            { "data": "FileOutDate" }
        ]
    });
}