am4core.ready(function() {

    // Themes begin

    var dataresponse;
    $.ajax({
        url: "https://webinar.azurewebsites.net/json/Wroc%C5%82aw",
        data: dataresponse,
        dataType: "json",
        success: function(dataresponse) {
            WriteGraph(dataresponse);
        }
    });

    function WriteGraph(dataresponse) {
        am4core.useTheme(am4themes_animated);
        // Themes end

        var chart = am4core.create("chartdiv", am4plugins_forceDirected.ForceDirectedTree);
        var networkSeries = chart.series.push(new am4plugins_forceDirected.ForceDirectedSeries());

        networkSeries.data = [
            {
                name: dataresponse.office.officeName,
                value: 2
            }
        ];
        for (var key in dataresponse.office.workers) {
            var obj = dataresponse.office.workers[key];
            var result = [{ name: obj.workerName + " " + obj.workerSurname }];
            
            for (var key2 in obj.hobbies) {
                var obj2 = obj.hobbies[key2];
                var result2 = { name: obj2.hobbyName, value: 1 };

                if (typeof result[0]["children"] == "undefined") {
                    result[0]["children"] = [];
                }

                result[0].children.push(result2);
            }

            if (typeof networkSeries.data[0]["children"] == "undefined") {
                networkSeries.data[0]["children"] = result;
            } else {
                var arrLenght = networkSeries.data[0]["children"].length;
                networkSeries.data[0].children.push(result[0]);
            }
            
        }

        networkSeries.dataFields.linkWith = "linkWith";
        networkSeries.dataFields.name = "name";
        networkSeries.dataFields.id = "name";
        networkSeries.dataFields.value = "value";
        networkSeries.dataFields.children = "children";
        networkSeries.links.template.distance = 1;
        networkSeries.nodes.template.tooltipText = "{name}";
        networkSeries.nodes.template.fillOpacity = 1;
        networkSeries.nodes.template.outerCircle.scale = 1;

        networkSeries.nodes.template.label.text = "{name}";
        networkSeries.fontSize = 8;
        networkSeries.nodes.template.label.hideOversized = true;
        networkSeries.nodes.template.label.truncate = true;
        networkSeries.minRadius = am4core.percent(2);
        networkSeries.manyBodyStrength = -5;
        networkSeries.links.template.strokeOpacity = 0;
    }
}); // end am4core.ready()