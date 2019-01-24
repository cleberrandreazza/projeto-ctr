var gerenciador_url;
var map;
var marker;

$(document).ready(function () {

var controller = (window.location.host == 'localhost' || window.location.host == 'c.deen.com.br') ? window.location.pathname.split('/')[3] : window.location.pathname.split('/')[3];
var item_id = (window.location.host == 'localhost' || window.location.host == 'c.deen.com.br') ? window.location.pathname.split('/')[5] : window.location.pathname.split('/')[5];
if(!item_id) item_id = 0;
if($("#photoDropzone").size() > 0){
$("div#photoDropzone").dropzone();
    Dropzone.options.photoDropzone = {
        url: gerenciador_url + '/' + controller + '/upload/' + item_id,
        maxFileSize : 100,
        parallelUploads : 100,
         autoQueue: false,
         dictRemoveFile:'X',
         dictCancelUpload:'X',
        addRemoveLinks : true,
        dictDefaultMessage:'Arraste os arquivos aqui para enviar',
        init: function() {
            var submitButton = document.querySelector("#actions .start");
            myDropzone = this;
            submitButton.addEventListener("click", function() {
                console.log('aqui');
                myDropzone.processQueue(); 
            });
            myDropzone.on("addedfile", function(file) {
                $('#actions').fadeIn();
                if (!file.type.match(/image.*/)) {               
                    if(file.type.match(/application.zip/)){
                        myDropzone.emit("thumbnail", file, "path/to/img");
                    } else {
                        myDropzone.emit("thumbnail", file, "path/to/img");
                    }
                }
                 // file.previewElement.querySelector(".start").onclick = function() { myDropzone.enqueueFile(file); }
            });
            myDropzone.on("removedfile", function(file) {
                 document.querySelector("#total-progress .progress-bar").style.width = 0 + "%";
                if($('.dz-preview').length == 0){
                    $('#actions').fadeOut();
                }
            });
            myDropzone.on("totaluploadprogress", function(progress) {
              document.querySelector("#total-progress .progress-bar").style.width = progress + "%";
            });
            myDropzone.on("sending", function(file) {
              // Show the total progress bar when upload starts
              document.querySelector("#total-progress").style.opacity = "1";
              // And disable the start button
             submitButton.setAttribute("disabled", "disabled");
            });
            myDropzone.on("complete", function(file) {
                //myDropzone.removeFile(file);
            });
            myDropzone.on("queuecomplete", function(progress) {
                  //document.querySelector("#total-progress .progress-bar").style.width = 100 + "%";
                $('#actions').fadeOut();
                $("#actions .start").removeAttr("disabled");
                  myDropzone.removeAllFiles(true);

                 $.ajax({
                    type: "POST",
                    url: gerenciador_url + '/' + controller + '/getImages/' + item_id,
                    data: {
                        'item_id': item_id
                    },
                    beforeSend: function() {
                        $('.listagem .loader').fadeIn('fast');
                    },
                    success: function(data) {
                         $('.images .items-push').html('');
                        setTimeout(function() {
                            $('.listagem .loader').fadeOut('fast');
                        }, 800);
                     
                        setTimeout(function() {
                            $(data).appendTo('.images .items-push').hide().fadeIn(1500, function() {                })
                        }, 800);
                    }
                });
              document.querySelector("#total-progress").style.opacity = "0";
            });
        },
    };

document.querySelector("#actions .start").onclick = function() {

  myDropzone.enqueueFiles(myDropzone.getFilesWithStatus(Dropzone.ADDED));
};
document.querySelector("#actions .cancel").onclick = function() {
  myDropzone.removeAllFiles(true);
//   document.querySelector("#total-progress .progress-bar").style.width = 0 + "%";
  $('#actions').fadeOut();
};

}
App.initHelpers(['slick','summernote', 'ckeditor','datepicker']);

    $('.number').numeric();
    $('.phone').mask("(99) 9999-9999");
    $('.zip_code').mask("99999-999");
    $('.date').mask("99/99/9999");
    $('.time').mask("99:99");
    $('.uf').mask("aa");
    $('.price').priceFormat({
        prefix: '',
        centsSeparator: ',',
        thousandsSeparator: '.',
        clearPrefix: true
    });


    $('.filter-title').on('click', displayFormFilter);
    $('.checkbox-select-all').on('click', setCheckedList);
    $('.checkbox-list-item').on('click', setCheckedSelectAll);

    $('body').on('touchstart.dropdown', '.dropdown-menu', function (e) { e.stopPropagation(); });

    $(".fancybox").fancybox();

    $( "ul.sortable" ).sortable({ placeholder: "ui-state-highlight" }).on('sortupdate', function() {
        var items = [];

        $("ul.sortable .ui-state-default").each(function(i){
            var order = $("ul.sortable .ui-state-default").length - i;
            obj = {"item_id": $(this).data('id'), "order": order};
            items.push(obj);
        });

        reorder(items);
    });

     $('.ui-state-default').on('dblclick', function(e){
        var href = $('.btn-success', this).attr('href');
        if(href)
        window.location = href;
    });

    $(window).bind('keydown', function(event) {
        if (event.ctrlKey || event.metaKey) {
            switch (String.fromCharCode(event.which).toLowerCase()) {
            case 's':
                event.preventDefault();
                 $( ".form-horizontal" ).submit();
                break;
            }
        }
    });

    $('#selecctall').click(function(event) {  
        if(this.checked) {
            $('.checkbox1').each(function() {
                this.checked = true;                
            });
        }else{
            $('.checkbox1').each(function() { 
                this.checked = false;                       
            });         
        }

        checkSelected();
    });

     checkSelected();
    $('.checkbox1').on('click', checkSelected);
    $('.remove-all').on('click', removeSelected);


     $( ".table-sortable" ).sortable({ 
        cursor: "move", 
        placeholder: "ui-state-highlight", 
        helper: function(event, ui){ 
            ui.children().each(function() { 
               $(this).width($(this).width()); 
            }); 
            return ui; 
        }, 
        activate: function( event, ui ) { 
            console.log('aqui');
            $('.ui-state-highlight').css({ "height": $(ui.item).height()+"px","width": $(ui.item).width()+"px" }); 
        }

    }).on('sortupdate', function() {

        var items = [];

        $(".table-sortable .ui-state-default").each(function(i){
            var order = $(".table-sortable .ui-state-default").length - i;
            obj = {"item_id": $(this).data('id'), "order": order};
            items.push(obj);
        });

        reorder(items);
    });


    $( ".img-sortable" ).sortable({ 
        cursor: "move", 
        placeholder: "ui-state-highlight", 
        helper: function(event, ui){ 
            ui.children().each(function() { 
                //$(this).width($(this).width()); 
            }); 
            return ui; 
        }, 
        activate: function( event, ui ) { 
            console.log('aqui');
            //$('.ui-state-highlight').css({ "height": $(ui.item).height()+"px","width": $(ui.item).width()+"px","float":"left","padding":"15px" }); 
        }

    }).on('sortupdate', function() {

        var items = [];

        $(".img-sortable .ui-state-default").each(function(i){
            var order = $(".table-sortable .ui-state-default").length - i;
            obj = {"item_id": $(this).data('id'), "order": order};
            items.push(obj);
        });

        reorder(items);
    });

    $( ".sortable, .table-sortable, .img-sortable" ).disableSelection();

    // if( $('#map_div').length > 0 ){
    //     if($('#longitude').val() !== '' && $('#latitude').val() !== ''){
    //         show_map({lati: $('#latitude').val(), longi: $('#longitude').val()}, true);
    //     }
    // }

    $('.medias li').on('click', function(){
        var item_id = $(this).data('img-id');
        var value;
        if($(this).hasClass('added')){ value = 0; }
        else { value = 1; }

        save($(this), item_id, value);
    });

 //   getMedia = setInterval(onGetMedia, 10000);
});

var reorder = function(items){
    var controller = (window.location.host == 'localhost' || window.location.host == 'c.deen.com.br') ? window.location.pathname.split('/')[3] : window.location.pathname.split('/')[3];
    if(items){
        $.ajax({
            url: gerenciador_url + controller + '/reorder' + ($('#rel_id') != null ? '/' + $('#rel_id').val() : ''),
            type: "POST",
            data: {data: items},
            success: function(data){
                if (data == 1) console.log("Sucesso!!");
                else  console.log(gerenciador_url);
            }
        });
    }
};

function displayFormFilter(){
    var element = $(this).parent().find('fieldset');
    if (element.hasClass("active")) {
        $(this).find('h3 i').removeClass('glyphicon-chevron-down');
        $(this).find('h3 i').addClass('glyphicon-chevron-right');
        element.removeClass('active');
        element.fadeOut(500);
    } else {
        $(this).find('h3 i').removeClass('glyphicon-chevron-right');
        $(this).find('h3 i').addClass('glyphicon-chevron-down');
        element.addClass('active');
        element.fadeIn(500);
    }
}

function setCheckedList(){
    $('.checkbox-list-item').attr('checked', $(this).is(":checked"));
}

function setCheckedSelectAll(){
    if(!$(this).is(":checked")) $('.checkbox-select-all').attr('checked', false);
    else
        if($('.checkbox-list-item:checked').length === $('.checkbox-list-item').length) $('.checkbox-select-all').attr('checked', true);
}

Object.keyAt = function(obj, index) {
    var i = 0;
    for (var key in obj) {
        if ((index || 0) === i++) return key;
    }
};

/*
function google_map(address){    
    geocoder = new google.maps.Geocoder();

    geocoder.geocode( { 'address': address }, function(results, status) {
        if (status == google.maps.GeocoderStatus.OK) {
            // console.log(results[0].geometry.location);
            show_map({lati: results[0].geometry.location[Object.keyAt(results[0].geometry.location, 0)], longi: results[0].geometry.location[Object.keyAt(results[0].geometry.location, 1)]}, false);

        } else if (status == google.maps.GeocoderStatus.ZERO_RESULTS) {
            map = null;
            $('#map_div').html('O endereço preenchido não foi encontrado.');
        }
    });
}

function show_map(coords, useMarker){
    // console.log(coords);
    var latlng = new google.maps.LatLng(coords.lati, coords.longi);
    var options = {
        zoom: 12, 
        center: latlng,
        mapTypeId: google.maps.MapTypeId.ROADMAP, // This value can be set to define the map type ROADMAP/SATELLITE/HYBRID/TERRAIN
        navigationControl: true,
        mapTypeControl: true,
        scrollwheel: true,
        disableDoubleClickZoom: true
    };

    if (!map) map = new google.maps.Map(document.getElementById('map_div'), options);
    else map.setCenter(latlng);

    if(useMarker){
        marker = new google.maps.Marker({
            position: latlng, 
            map: map
        });
    }

    google.maps.event.addListener(map, 'click', function(event) {
        if(marker){
            marker.setPosition(event.latLng);
        } else {
            marker = new google.maps.Marker({
                position: event.latLng, 
                map: map
            });
        }
        // console.log(event.latLng);
        var lat = event.latLng[Object.keyAt(event.latLng, 0)];
        var lng = event.latLng[Object.keyAt(event.latLng, 1)];

        // console.log('esse', lat, lng);

        $('#map_lat').val(lat);
        $('#map_lng').val(lng);
    });

    $('#map_div').addClass("success");
}

// MAP
var myRouter = {
    map_: null,
    directionsHelper_: null,

    calcRoute: function(orig, dest) {
        var request = {
            //origin: new google.maps.LatLng(-29.17697,-51.181526),
            origin: orig,
            destination: dest,
            optimizeWaypoints: true,
            travelMode: google.maps.DirectionsTravelMode.DRIVING
        };

        var _SELF = this;
        this.directionsHelper_.route(request, function(response, status) {
            if (status == google.maps.DirectionsStatus.OK) {
                _SELF.directionsDisplay_.setDirections(response);
                return;
            }
            console.log('Directions Status: ' + status);
        });
    },

    init: function(mapid) {

        this.directionsHelper_ = new google.maps.DirectionsService();
        this.directionsDisplay_ = new google.maps.DirectionsRenderer();

        var center = new google.maps.LatLng(-29.1782672, -51.21349750000002);
        var myOptions = {
            zoom:16,
            mapTypeId: google.maps.MapTypeId.ROADMAP,
            center: center
        }
        this.map_ = new google.maps.Map(document.getElementById(mapid), myOptions);
        this.directionsDisplay_.setMap(this.map_);
    }
};*/


var marker = null;
function clearMarker(){
    if (marker != null) {
        marker.setMap(null);
        marker = null;
    }
}
function codeAddress(address, candrag, lat, lng) {
    var myLatlng = null;
    if (lat != null && lng != null)
        myLatlng = new google.maps.LatLng(lat,lng);
        
    address = address.replace(/[\\"']/g, '\\$&').replace(/\u0000/g, '\\0');

    var mapProp = {
      zoom:12,
      mapTypeId:google.maps.MapTypeId.HYBRID,
      zoom:16,
      };

    map = new google.maps.Map(document.getElementById("map_div"),mapProp);
    clearMarker();
    $('#map_error').html('');
    if (myLatlng == null) {
         console.log('aqui2');
        geocoder = new google.maps.Geocoder();
        geocoder.geocode( { 'address': address }, function(results, status) {
            if (status == google.maps.GeocoderStatus.OK) {
                map.setCenter(results[0].geometry.location);

                // set
                $('#map_lat').val(results[0].geometry.location.lat());
                $('#map_lng').val(results[0].geometry.location.lng());
                $('#latitude').val(results[0].geometry.location.lat());
                $('#longitude').val(results[0].geometry.location.lng());
                
                // marker
                marker = new google.maps.Marker({
                    draggable: candrag, 
                    zIndexProcess:function() {return 50;},
                    map: map, 
                    position:{lat: results[0].geometry.location.lat(), lng: results[0].geometry.location.lng()},
                    title:address
                });
                addMarkerListener();
            } else if (status == google.maps.GeocoderStatus.ZERO_RESULTS) {
                $('#map_error').html('O endereço preenchido não foi encontrado.');
                return;
            }
        });
    } else {
        console.log('aqui');
        map.setCenter(myLatlng);
        marker = new google.maps.Marker({
            draggable: candrag, 
            zIndexProcess:function() {return 50;},
            map: map, 
            position: myLatlng,
            title:""
        });
       
        marker.setMap(map);
        addMarkerListener();
    }
    /*setTimeout(function() {
        if (marker != null) {
            google.maps.event.addListener(marker, 'dragend', function() {
                var lat = marker.position.Ja;
                var lng = marker.position.Ka;
                
                $('#map_lat').val(lat);
                $('#map_lng').val(lng);
            });
        }
    }, 2000);*/
    
}

function addMarkerListener() {
    google.maps.event.addListener(marker, 'dragend', function() {
        var lat = marker.position.lat();
        var lng = marker.position.lng();
        
        $('#map_lat').val(lat);
        $('#map_lng').val(lng);
        $('#latitude').val(lat);
        $('#longitude').val(lng);
    });
}

var checkSelected = function () {
    var selected = false;
    $('.ui-state-default').each(function(){

        if($('.checkbox1', this).is(':checked')){
            selected = true;
            return;
        }

    });

    (selected) ? $('.remove-all').stop().fadeIn(200) :  $('.remove-all').stop().fadeOut(200);
};

var removeSelected = function (e) {
    e.preventDefault();

    $('.preloader').fadeIn(200);

    var selecteds = [];
    $('.ui-state-default').each(function(){
        
        if($('.checkbox1', this).is(':checked')){
            var id = $(this).data('id');
            deleteRequest(id);
            // selecteds.push(id);
        }

    });    
};

var deleteRequest = function(id){
    var controller = (window.location.host == 'localhost' || window.location.host == 'c.deen.com.br') ? window.location.pathname.split('/')[3] : window.location.pathname.split('/')[2];

    $.ajax({
        url: gerenciador_url + controller + '/delete/' + id,
        type: "POST",
        success: function(response){
            console.log(response);
            $('.ui-state-default').each(function(){
                if($('.checkbox1', this).is(':checked')){
                    location.reload();
                }
            });
        },

        error: function (err) {
            
        }
    });
}

var save = function(item, item_id, value){
    console.log(window.location.href + '/onBlackList/' + item_id + '/' + value)
    $.ajax({
        url: window.location.href + '/onBlackList/' + item_id + '/' + value,
        success: function(data){

            if(value === 1 ) item.addClass('added');
            else item.removeClass('added');

            console.log("success");
        } 
    });
};

var medias = {
    getIds: function (){
        var array = [];
        $('li', '.medias').each(function(i){
            array.push($(this).data('id'));
        });

        return array.sort().reverse();
    },

    getHighestId: function (){
        var array = [];
        $('li', '.medias').each(function(i){
            array.push($(this).data('id'));
        });

        return array.sort().reverse()[0];
    },

    getLowerId: function (){
        var array = [];
        $('li', '.medias').each(function(i){
            array.push($(this).data('id'));
        });

        return array.sort()[0];
    },

    getElement: function(id){
        if(id){
           return $('li', '.medias').filter(function(){ return $(this).data('id') == id});
        }
    }
};


// var onGetMedia = function(){
//     var instagram_id = medias.getHighestId();
//     var min_id = medias.getElement(medias.getHighestId()).data('img-id');

//     $.ajax({
//         url: window.location.href + '/getMedias/' + min_id + '/' + instagram_id,
//         success: function(data){
//             if(data){
//                 try{
//                     var json = JSON.parse(data);
//                 }
//                 catch(e){}

//                 if(json) parseAndPrepend(json);
//             }
//         },
//         error: function(e){
//             console.log(e.message);
//         }
//     });
// };

var parseAndPrepend = function(json){

    for( var i = 0; i < json.length; i++){
        $('.medias').prepend('<li data-img-id="' + json[i].image_id + '" class="image" data-id="' + json[i].instagram_id + '" ><img src="' + json[i].img + '"></li>');
        $('.medias li').on('click', function(){
            var item_id = $(this).data('img-id');
            var value;
            if($(this).hasClass('added')){ value = 0; }
            else { value = 1; }

            save($(this), item_id, value);
        });
    }
}

