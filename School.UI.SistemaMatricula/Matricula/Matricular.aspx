<%@ Page Title="Matricula Alumno" Language="C#" MasterPageFile="~/Matricula.Master" AutoEventWireup="true" CodeBehind="Matricular.aspx.cs" Inherits="School.UI.SistemaMatricula.Matricular" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContenido" runat="server">
  <div class="col-xl-6 col-lg-6 col-md-12 col-sm-12 col-12">
    <div class="card">
        <h5 class="card-header">Registrar Matrícula: </h5>
        <div class="card-body">
            <form action="#" id="basicform" data-parsley-validate="" runat="server">
                <asp:HiddenField ID="alID" runat="server"/>
                <div class="form-group">
                    <label for="inputUserName">Nombre de alumno</label>
                    <input id="inputUserName" runat="server" type="text" name="name" data-parsley-trigger="change"  autocomplete="off" class="form-control" readonly="readonly"/>
                </div>
                <div class="form-group">
                    <label for="inputUserApellido">Apellidos del alumno</label>
                    <input id="inputUserApellido" runat="server" type="text" name="apellido" data-parsley-trigger="change"   autocomplete="off" class="form-control" readonly="readonly"/>
                </div>
                <div class="form-group" runat="server">
                    <label for="inputGrados">Elegir Grado: </label>
                    <asp:DropDownList ID="ddlGrados" CssClass="form-control" runat="server"  AutoPostBack="true" OnSelectedIndexChanged="ddlGrados_SelectedIndexChanged">
                        <asp:ListItem></asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div class="form-group" runat="server">
                    <label for="inputSecciones">Elegir Sección: </label>
                    <asp:DropDownList ID="ddlSecciones" CssClass="form-control" runat="server" >
                        <asp:ListItem></asp:ListItem>
                    </asp:DropDownList>
                </div>

                   <div class="row">
                    <div class="col-sm-6 pl-0">
                        <p class="text-right">
                            <asp:Button ID="btnGuardar" runat="server" Text="Registrar" CssClass="btn btn-space btn-secondary" OnClick="btnGuardar_Click" />
                        </p>
                    </div>
                </div>
            </form>
        </div>
    </div>
</div>
</asp:Content>
