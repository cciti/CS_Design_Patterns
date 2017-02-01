<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Sidebar.ascx.cs" Inherits="Aside" %>

<%if (false) { %>
    <link href="_css/main.css" rel="stylesheet" type="text/css" />
<% }%>

<aside>
    <section class="academic info">
        <h2>Academic Links</h2>
        <ul>
            <li><a href="undergraduate.htm" title="undergraduate degrees">Undergraduate Degrees</a></li>
            <li><a href="graduate.htm" title="Graduate Degrees">Graduate Degree Programs</a></li>
            <li><a href="continuing-education.htm" title="Continuing education">Continuing Education</a></li>
            <li><a href="faculty.htm" title="Faculty">Faculty Profiles</a></li>
            <li><a href="application-requirement.htm" title="Application requirements">Application Requirements</a></li>
            <li><a href="study-abroad.htm" title="Study abroad programs">Study Abroad Programs</a></li>
            <li><a href="internships.htm" title="Internship programs">Internship Programs</a></li>
            <li><a href="calendar.htm" title="Academic calendar">Academic Calendar</a></li>
        </ul>
    </section>
    <section class="connect info">
        <h2>Connect with us</h2>
        <ul>
            <li><a href="http://www.twitter.com/rouxacademy" title="Follow us!" target="_blank" class="twitter">Twitter</a></li>
            <li><a href="https://plus.google.com/" title="Google Plus" target="_blank" class="google">Google Plus</a></li>
            <li><a href="http://facebook.com" title="Be our friend" target="_blank" class="facebook">Facebook</a></li>
            <li><a href="http://www.linkedin.com" title="Let's connect" target="_blank" class="linked">LinkedIn</a></li>
        </ul>
    </section>
    <section class="find info">
        <h2>Find out more</h2>
        <ul>
            <li><a href="./tour.htm" title="Take a campus tour">Take a campus tour</a></li>
            <li><a href="./catalog.htm" title="course catalog">Download a course catalog</a></li>
            <li><a href="./admissions.htm" title="Apply now">Apply now</a></li>
        </ul>
    </section>
    <section class="show info">
        <h2>Current Show</h2>
        <img src="./_images/show1.jpg" width="285" height="230" alt="Current show">
        <p>Join us on May 11th for the opening reception of Ceramic Currency, an annual show presented by graduates from the Craft and Design program. Come see an exhibition of contemporary pottery and ceramic sculpture by over 30 artists. <a href="current_show.htm" title="current show" class="more">more info</a></p>
    </section>
</aside>
