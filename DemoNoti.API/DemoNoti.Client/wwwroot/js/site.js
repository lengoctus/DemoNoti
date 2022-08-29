$(() => {
    LoadData();

    var conn = new signalR.HubConnectionBuilder().withUrl("/notify").build();
    conn.start();
    conn.on("/BroadcastMessage", function () {
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
                        <td>${v.sportTypeId}</td>
                        <td>${v.sportName}</td>                                                             
                        <td>${v.sportRefId}</td>
                        <td>${v.sportNameKo}</td>
                    </tr>`;
                })

                $('#table-body').html(tr)
            }
        })
    }
})