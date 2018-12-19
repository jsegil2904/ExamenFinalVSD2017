<%@ Page Title="Consultar Alumno" Language="C#" MasterPageFile="~/Matricula.Master" AutoEventWireup="true" CodeBehind="Consultar.aspx.cs" Inherits="School.UI.SistemaMatricula.Consultar" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContenido" runat="server">
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePageMethods="true">

        </asp:ScriptManager>
        <div class="form-group">
            <div class="input-group mb-3">
                <input id="txtNombreAlumno" type="text" runat="server" placeholder="Ingresar el nombre de alumno" class="form-control"/>
                <div class="input-group-append">
                     <asp:Button ID="btnConsultar" runat="server" Text="Buscar" CssClass="btn btn-primary" OnClick="btnConsultar_Click" />
                </div>
                
            </div>
            <div>
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                               
                                    <div class="table-responsive">
                                        <asp:GridView ID="grdAlumnos" runat="server"  AutoGenerateColumns="false" 
                                            Cssclass="table table-striped table-bordered first" >
                                            <Columns>
                                                <asp:BoundField DataField="AlumnoID" HeaderText="ID de Alumno" />
                                                <asp:BoundField DataField="Nombres" HeaderText="Nombres" />
                                                <asp:BoundField DataField="Apellidos" HeaderText="Apellidos" />
                                                <asp:BoundField DataField="Direccion" HeaderText="Dirección" />
                                                <asp:BoundField DataField="Sexo" HeaderText="Sexo" />
                                                <asp:BoundField DataField="FechaNacimiento" HeaderText="Fecha de Nacimiento" />
                                                <asp:TemplateField HeaderText="Matricularse">
                                                    <ItemTemplate>
                                                         <a href="Matricular.aspx?id=<%#Eval("AlumnoID") %>"
                                                            >
                                                            <img id="imgMatricula" src="~/Matricula/images/matricula.png"
                                                                style="width:40px; height:40px; display:block;
                                                                    margin:auto;"
                                                                runat="server" />                        
                                                        </a>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                            </Columns>
                                        </asp:GridView>
                                    </div>

                                            
                    </ContentTemplate>
                     <Triggers>
                            <asp:AsyncPostBackTrigger ControlID="btnConsultar"
                              EventName="Click"
                            />
                        </Triggers>

                </asp:UpdatePanel>

            </div>
        </div>
    </form>
</asp:Content>
