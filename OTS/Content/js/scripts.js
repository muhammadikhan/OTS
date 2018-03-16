$(document).ready(function () {
    if (window.location.href.indexOf("Announcements") > -1) { $("li#id_course_announcements").addClass(' selected'); }
    else if (window.location.href.indexOf("LessonsResources") > -1) { $("li#id_learning_resources").addClass(' selected'); }
    else if (window.location.href.indexOf("Assignments") > -1) { $("li#id_assigments").addClass(' selected'); }
    else if (window.location.href.indexOf("MDB") > -1) { $("li#id_mdb").addClass(' selected'); }
    else if (window.location.href.indexOf("GDB") > -1) { $("li#id_gdb").addClass(' selected'); }
    else if (window.location.href.indexOf("Quizzes") > -1) { $("li#id_quizzes").addClass(' selected'); }
    else if (window.location.href.indexOf("VideoLessons") > -1) { $("li#id_live_sessions").addClass(' selected'); }
    else if (window.location.href.indexOf("CourseInformation") > -1) { $("li#id_course_information").addClass(' selected'); }
    else { $("li#id_course_announcements").addClass(' selected'); }
});


SelectSubMenu(item)
{
    try {
        debugger;
        $("#id_create").attr("href", item + "/Index");
    } catch (e) {

    }
}
