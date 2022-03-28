<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminDashboard.aspx.cs" Inherits="KitapWeb.AdminDashboard" %>

<asp:Content ID="Content2" ContentPlaceHolderID="Ana" runat="server">
                   <div class="row">
                    <div class="col-md-3 col-sm-12 col-xs-12">
                        <div class="panel panel-primary text-center no-boder bg-color-green green">
                            <div class="panel-left pull-left green">
                                <i class="fa fa-bar-chart-o fa-5x"></i>
                                
                            </div>
                            <div class="panel-right pull-right">
								<h3>
                                    <asp:Label ID="lbl_Books" runat="server" Text=""></asp:Label>
								</h3>
                               <strong> Books</strong>
                            </div>
                        </div>
                    </div>
                    <div class="col-md-3 col-sm-12 col-xs-12">
                        <div class="panel panel-primary text-center no-boder bg-color-blue blue">
                              <div class="panel-left pull-left blue">
                                <i class="fa fa-shopping-cart fa-5x"></i>
								</div>
                                
                            <div class="panel-right pull-right">
							<h3>
                                <asp:Label ID="lbl_BookOrders" runat="server" Text=""></asp:Label></h3>
                               <strong> BookOrders</strong>

                            </div>
                        </div>
                    </div>
                    <div class="col-md-3 col-sm-12 col-xs-12">
                        <div class="panel panel-primary text-center no-boder bg-color-red red">
                            <div class="panel-left pull-left red">
                                <i class="fa fa fa-comments fa-5x"></i>
                               
                            </div>
                            <div class="panel-right pull-right">
							 <h3>
                                 <asp:Label ID="lbl_Customers" runat="server" Text=""></asp:Label></h3>
                               <strong> Customers </strong>

                            </div>
                        </div>
                    </div>
                    <div class="col-md-3 col-sm-12 col-xs-12">
                        <div class="panel panel-primary text-center no-boder bg-color-brown brown">
                            <div class="panel-left pull-left brown">
                                <i class="fa fa-users fa-5x"></i>
                                
                            </div>
                            <div class="panel-right pull-right">
							<h3>
                                <asp:Label ID="lbl_BookCategories" runat="server" Text=""></asp:Label> </h3>
                             <strong>BookCategories</strong>

                            </div>
                        </div>
                    </div>
                </div>
				
		
		<div class="row">
			<div class="col-xs-6 col-md-3">
				<div class="panel panel-default">
					<div class="panel-body easypiechart-panel">
						<h4>Books</h4>
						<div class="easypiechart" id="easypiechart-blue" data-percent="<%=BooksPersent()%>" ><span class="percent"><%=BooksPersent()%>%</span>
						</div>
					</div>
				</div>
			</div>
			<div class="col-xs-6 col-md-3">
				<div class="panel panel-default">
					<div class="panel-body easypiechart-panel">
						<h4>BookOrders</h4>
						<div class="easypiechart" id="easypiechart-orange" data-percent="<%=BookOrdersPersent()%>" ><span class="percent"><%=BookOrdersPersent()%>%</span>
						</div>
					</div>
				</div>
			</div>
			<div class="col-xs-6 col-md-3">
				<div class="panel panel-default">
					<div class="panel-body easypiechart-panel">
						<h4>Customers</h4>
						<div class="easypiechart" id="easypiechart-teal" data-percent="<%=CustomersPersent()%>" ><span class="percent"><%=CustomersPersent()%>%</span>
						</div>
					</div>
				</div>
			</div>
			<div class="col-xs-6 col-md-3">
				<div class="panel panel-default">
					<div class="panel-body easypiechart-panel">
						<h4>BookCategories</h4>
						<div class="easypiechart" id="easypiechart-red" data-percent="<%= BookCategoriesPersent() %>" ><span class="percent"><%= BookCategoriesPersent() %>%</span>
						</div>
					</div>
				</div>
			</div>
		</div><!--/.row-->
    
                <div class="row">
                   
                    <div class="col-md-8 col-sm-12 col-xs-12">

                        <div class="panel panel-default">
                            <div class="panel-heading">
                                Responsive Table Example
                            </div> 
                            <div class="panel-body">
                                <div class="table-responsive">
                                    <table class="table table-striped table-bordered table-hover">
                                        <thead>
                                            <tr>
                                                <th>Id</th>
                                                <th>BookCategoryId</th>
                                                <th>Name</th>
                                                <th>UnitPrice</th>
                                                <th>UnitsInStock</th>
                                                <th>WriterName</th>
                                                <th>BooksPage</th>
                                                
                                            </tr>
                                        </thead>
                                        <tbody>
                                            <%foreach (var book in BooksGetAll()){ %>
                                            <tr>
                                                <td><%= book.Id %></td>
                                                <td><%= book.BookCategoryId %></td>                                               
                                                <td><%= book.Name %></td>                                                
                                                <td><%= book.UnitPrice %></td>                                                
                                                <td><%= book.UnitsInStock %></td>
                                                <td><%= book.WriterName %></td>
                                                <td><%= book.BooksPage %></td>
                                            </tr>
                                            <% } %>
                                        </tbody>
                                     </table>
                                </div>
                            </div>
                        </div>
        </div>
     </div>
</asp:Content>
