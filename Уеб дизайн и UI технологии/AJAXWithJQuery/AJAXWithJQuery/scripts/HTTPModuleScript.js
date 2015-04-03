//$('<button>').text('Test').on('click', test).appendTo('body');
//function test () {
//    $('#add-new')
//    .on('click', function () {
//        var newStudent;
//        newStudent = {
//            name: $('#name').val(),
//            grade: $('#grade').val()
//        };
//        addStudents();
//    });
//    function addStudents() {
//        return $.ajax({
//            url: 'http://localhost:3000/students',
//            type: 'POST',
//            data: JSON.stringify(newStudent),
//            contentType: 'application/json',
//            success: function (data) {
//                $message
//                    .html('' + data.name + ' successfully added')
//                    .show()
//                refreshStudents();
//            },
//            error: function (err) {
//                console.error(err);
//            }
//        });

//    };

//    function refreshStudents() {
//        $.getJSON({
//            url: 'http://localhost:3000/students',
//            type: 'GET',
//            contentType: 'application/json',
//            success: function (data) {
//                var $list = $('<ul />');
//                $('#container').html($list)
//                $(data.student)
//                .each(function (index, student) {
//                    $('<li />')
//                    .addClass('student-item')
//                        .html(student.name)
//                    .appendTo($list);
//                    //.append($('<span />')
//                    //.html(student.grade))
//                    //.appendTo($studentsList);
//                });
//                $('#students-container').html($list);
//            },
//            error: function (err) {
//                console.error(err)
//            }
//        });
//    }
//    $(function () {
//        refreshStudents();
//    });
//};
var url = 'http://localhost:3000/students';
$.getJSON(url, function (data) {
    var i, student, len, $studentsList;
    $studentsList = $('<ul />');
    for (i = 0, len = data.students.length; i < len; i += 1) {
        student = data.students[i];
        $('<li />')
            .html(student.name)
            .appendTo($studentsList);
    }
    $("#http-response").html($studentsList);
});