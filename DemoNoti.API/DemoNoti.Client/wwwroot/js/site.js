$(() => {
    LoadData();

    var conn = new signalR.HubConnectionBuilder().withUrl("/notify").build();
    conn.start();
    conn.on("BroadcastMessage", function () {
        LoadData()
    })

    LoadData();

    function LoadData() {
        var tr = '';
        $.ajax({
            url: '/LiveScores/GetLiveScores',
            method: 'GET',
            success: (result) => {
                $.each(result, (k, v) => {
                    tr += `<tr>
                        <td>${v.SportTypeId}</td>
                        <td>${v.SportName}</td>                                             
                        <td>${v.SportRefId}</td>
                        <td>${v.SportNameKo}</td>
                    </tr>`;
                })

                $('#table-body').html(tr)
            }
        })
    }
})