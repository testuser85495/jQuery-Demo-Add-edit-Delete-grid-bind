////$(document).ready(function () {
////    ShowStudentData();
////});
////function ShowStudentData() {
////    debugger;
////    $.ajax({
////        url: "/Home/studata",
////        type: "Get",
////        dataType: "json",
////        contentType: "application/json;charset=utf-8;",
////        success: function (result,status,xhr) {
////            var res = '';
////            $.each(result, function (index, item) {
////                res += '<tr>';
////                res += "<td>" + item.studentId + "</td>";
////                res += "<td>" + item.name + "</td>";
////                res += "<td>" + item.age + "</td>";
////                res += "<td>" + item.gender + "</td>";
////                res += "<td>" + item.address + "</td>";
////                res += '<td> <a href="#" class="btn btn-primary" onclick="Edit(' + item.studentId + ')"> Edit </a> || <a href="#" class="btn btn-danger" onclick="Delete(' + item.studentId + ')"> Delete </a></td>';
////                res += '</tr>';
////            });
////            $("#table_data").html(res);
////        },
////        error: function () {
////            alert('data not get');
////        }
////    });
////};

////$('#BtnAddStudent').click(function () {
////    $('#studentModal').modal('show');
////})
