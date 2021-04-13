<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewPatientData.aspx.cs" Inherits="MedicalMonitoring.ViewPatientData" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

            <div id="chart" style="width: 100%; height: 400px"></div>


    <asp:GridView runat="server" ID="gridviewData" AutoGenerateColumns="false" CssClass="table">
        <Columns>
            <asp:BoundField DataField="datetime" HeaderText="Date Time" />
            <asp:BoundField DataField="pulse" HeaderText="Pulse" />
            <asp:BoundField DataField="temp" HeaderText="Temperature" />
        </Columns>
    </asp:GridView>



    <script type="text/javascript" src="https://www.gstatic.com/charts/loader.js"></script>
    <script type="text/javascript">
        google.charts.load('current', { 'packages': ['corechart'] });
        google.charts.setOnLoadCallback(drawChart);

        function drawChart() {

            var data = new google.visualization.DataTable();
            data.addColumn('datetime', 'Date Time');
            data.addColumn('number', 'Pulse');
            data.addColumn('number', 'Temperature')
            //data.addColumn({ type: 'string', role: 'annotation' });

            //    data.addRows([
            //        [0, 0, null],
            //        [0.5, ${ avg500*60/ 1000}, ${ avg500 * 60 / 1000 }],
            //[1.0, ${ avg1000*60/ 1000}, ${ avg1000*60/ 1000}],
            //    [1.5, ${ avg1500*60/ 1000}, ${ avg1500*60/ 1000}]
            //                ]);
            data.addRows([

                <%foreach (System.Data.DataRow row in table.Rows)
        {%>
                [new Date(
                    <%=((System.DateTime)row["datetime"]).Year%>,
                    <%=((System.DateTime)row["datetime"]).Month%>,
                    <%=((System.DateTime)row["datetime"]).Day%>,
                    <%=((System.DateTime)row["datetime"]).Hour%>,
                    <%=((System.DateTime)row["datetime"]).Minute%>,
                    <%=((System.DateTime)row["datetime"]).Second%>
                ),<%=row["pulse"]%>,<%=row["temp"]%>],
        <%
        }%>
            ]);


            var options = {
                title: '',
                //                            curveType: 'function',
                curveType: 'none',
                legend: { position: 'none' },
                hAxis: { title: '' },
                vAxis: { title: '' },
                pointSize: 10,
            };

            var chart = new google.visualization.LineChart(document.getElementById('chart'));

            chart.draw(data, options);
        }
    </script>


</asp:Content>
