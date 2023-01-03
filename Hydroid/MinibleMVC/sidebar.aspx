<!--- Left Sidebar Start -->
<div class="vertical-menu">

    <!-- LOGO -->
    <div class="navbar-brand-box">
        <a href="@Url.Action("Index", "Dashboard")" class="logo logo-dark">
            <span class="logo-sm">
                <img src="~/assets/images/logo-sm.png" alt="" height="22">
            </span>
            <span class="logo-lg">
                <img src="~/assets/images/IMAGELOGO.png" alt="" height="20">
            </span>
        </a>
        
        <a href="@Url.Action("Index", "Dashboard")" class="logo logo-light">
            <span class="logo-sm">
                <img src="~/assets/images/logo-sm.png" alt="" height="22">
            </span>
            <span class="logo-lg">
                <img src="~/assets/images/logo-light.png" alt="" height="20">
            </span>
        </a>
    </div>

    <button type="button" class="btn btn-sm px-3 font-size-16 header-item waves-effect vertical-menu-btn">
        <i class="fa fa-fw fa-bars"></i>
    </button>

    <div data-simplebar class="sidebar-menu-scroll">

        <!--- Sidemenu -->
        <div id="sidebar-menu">
            <!-- Left Menu Start -->
            <ul class="metismenu list-unstyled" id="side-menu">

                @if (Session["AdminLogin"] != null)
                {

                    <li>
                        <a href="@Url.Action("Index", "Overview")">
                            <i class="uil-home-alt"></i>
                            <span>Overview</span>
                        </a>
                    </li>




                    @*<li>
                <a href="@Url.Action("datatable","Table")" class="waves-effect">
                    <i class="uil-file-alt"></i>
                    <span>Users List</span>
                </a>
            </li>*@

                }
                else if (Session["SuperAdmin"] != null)
                {
                  

                        <li>
                            <a href="@Url.Action("Index", "Dashboard")">
                                <i class="uil-home-alt"></i>
                                <span>Admin Dashboard</span>
                            </a>
                        </li>
                        <li>
                            <a href="@Url.Action("wizard", "Forms")">
                                <i class="uil-comments-alt"></i>
                                <span>Add Organisation</span>
                            </a>
                        </li>

                        <li>
                            <a href="@Url.Action("Index", "AddUser")">
                                <i class="uil-comments-alt"></i>
                                <span>Add User</span>
                            </a>
                        </li>

                        <li>
                            <a href="@Url.Action("Index", "AddDevice")">
                                <i class="uil-comments-alt"></i>
                                <span>Add Device</span>
                            </a>
                        </li>

                        <li>
                            <a href="@Url.Action("uploads", "Forms")">
                                <i class="uil-comments-alt"></i>
                                <span>AddBulk Devices</span>
                            </a>
                        </li>
                    
               
                }
                 else if (Session["SuperAdmin"] != null)
                 {



                                <li>
                                    <a href="@Url.Action("sparkline", "Chart")">
                                        <i class="uil-calender"></i>
                                        <span>Meter Reading</span>
                                    </a>
                                </li>


                                <li>
                                    <a href="@Url.Action("Index", "Notification")" class=" waves-effect">
                                        <i class="uil-comments-alt"></i>
                                        <span class="badge rounded-pill bg-warning float-end"></span>
                                        <span>Notifications</span>
                                    </a>
                                </li>

                                <li>
                                    <a href="@Url.Action("Index","Payment")" class="waves-effect">
                                        <i class="uil-invoice"></i>
                                        <span>Payment</span>
                                    </a>

                                </li>
                                <li>
                                    <a href="@Url.Action("repeater","Forms")" class="waves-effect">
                                        <i class="uil-file-alt"></i>
                                        <span>Ticket Status</span>
                                    </a>
                                </li>
                 }




            </ul>
        </div>
     <!-- Sidebar -->
    </div>
</div>
<!-- Left Sidebar End -->



