<%@ Page Title="Registrarse" Language="C#" MasterPageFile="~/Matricula.Master" AutoEventWireup="true" CodeBehind="Registrarse.aspx.cs" Inherits="School.UI.SistemaMatricula.Registrarse" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContenido" runat="server">
 <div class="col-xl-6 col-lg-6 col-md-12 col-sm-12 col-12">
    <div class="card">
        <h5 class="card-header">Ingresar datos del alumno: </h5>
        <div class="card-body">
            <form action="#" id="basicform" data-parsley-validate="" runat="server" method="post">
                <div class="form-group">
                    <label for="inputUserName">Nombres</label>
                    <input id="inputUserName" runat="server" type="text" name="name" data-parsley-trigger="change" required="" placeholder="Ingrese sus nombres" autocomplete="off" class="form-control"/>
                </div>
                <div class="form-group">
                    <label for="inputUserApellido">Apellidos</label>
                    <input id="inputUserApellido" runat="server" type="text" name="apellido" data-parsley-trigger="change" required="" placeholder="Ingrese su apellido" autocomplete="off" class="form-control"/>
                </div>
                <div class="form-group">
                    <label for="inputUserAddress">Dirección</label>
                    <input id="inputUserAddress" runat="server" type="text" name="address" data-parsley-trigger="change" required="" placeholder="Ingrese su dirección" autocomplete="off" class="form-control"/>
                </div>
               <div>
                    <h5>Sexo</h5>
                    <label class="custom-control custom-radio custom-control-inline">
                        <input id="inputSexo1" type="radio" runat="server" name="radio-inline" value="Masculino" class="custom-control-input" checked=""/><span class="custom-control-label">Masculino</span>
                    </label>
                    <label class="custom-control custom-radio custom-control-inline">
                        <input id="inputSexo2" type="radio" runat="server" name="radio-inline" value="Femenino" class="custom-control-input" /><span class="custom-control-label">Femenino</span>
                    </label>
                </div>

                <div class="form-group">
                    <label for="inputUserDateBirthday">Fecha de Nacimiento</label>
                    <input id="inputUserDateBirthday" runat="server" type="date" name="dateBirthday" class="form-control date-inputmask"  data-parsley-trigger="change" required=""/>
                </div>

                <div class="row" runat="server" >
                    <div class="col-sm-6 pl-0">
                        <p class="text-right">
                            <asp:Button ID="btnGuardar" runat="server" Text="Guardar" CssClass="btn btn-space btn-secondary" OnClick="btnGuardar_Click" />
                            <input type="reset" id="btnLimpiar" value="Limpiar" class="btn btn-space btn-secondary"/>
                        </p>
                    </div>
                </div>
            </form>
        </div>
    </div>
</div>
</asp:Content>
