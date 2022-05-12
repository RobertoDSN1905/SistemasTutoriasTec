<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="AsesoriasTEC2019.SignUp" %>


<!doctype html>
<html class="fixed">
	<head>

		<!-- Basic -->
		<meta charset="UTF-8">

		<meta name="keywords" content="HTML5 Admin Template" />
		<meta name="description" content="Porto Admin - Responsive HTML5 Template">
		<meta name="author" content="okler.net">

		<!-- Mobile Metas -->
		<meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=no" />

		<!-- Web Fonts  -->
		<link href="https://fonts.googleapis.com/css?family=Poppins:300,400,500,600,700,800|Shadows+Into+Light" rel="stylesheet" type="text/css">

		<!-- Vendor CSS -->
		<link rel="stylesheet" href="vendor/bootstrap/css/bootstrap.css" />
		<link rel="stylesheet" href="vendor/animate/animate.compat.css">
		<link rel="stylesheet" href="vendor/font-awesome/css/all.min.css" />
		<link rel="stylesheet" href="vendor/boxicons/css/boxicons.min.css" />
		<link rel="stylesheet" href="vendor/magnific-popup/magnific-popup.css" />
		<link rel="stylesheet" href="vendor/bootstrap-datepicker/css/bootstrap-datepicker3.css" />

		<!-- Theme CSS -->
		<link rel="stylesheet" href="css/theme.css" />

		<!-- Skin CSS -->
		<link rel="stylesheet" href="css/skins/default.css" />

		<!-- Theme Custom CSS -->
		<link rel="stylesheet" href="css/custom.css">

		<!-- Head Libs -->
		<script src="vendor/modernizr/modernizr.js"></script>

	</head>
	<style>
        body{
            background-image: url('Gato.jpg');
            background-size: 100% 100%;
        }
    </style>
		<!-- start: page -->
	<body>
	<form runat="server">
		
		<section class="body-sign">
			<div class="center-sign">

				<div class="panel card-sign">
					<div class="card-title-sign mt-3 text-end">
						<h2 class="title text-uppercase font-weight-bold m-0"><i class="bx bx-user-circle me-1 text-6 position-relative top-5"></i>Registro</h2>
					</div>
					<div class="card-body">
						<form>
							<div class="form-group mb-3">
								<label>Nombre</label>
								<input id="textName" runat="server" name="name" type="text" class="form-control form-control-lg" />
							</div>

                            <div class="form-group mb-3">
								<label>Apellido</label>
								<input id="textAp" runat="server" name="name" type="text" class="form-control form-control-lg" />
							</div>
                            
                            <div class="form-group mb-3">
								<label>Nombre de usuario</label>
								<input id="textUser" runat="server" name="name" type="text" class="form-control form-control-lg" />
							</div>

							<div class="form-group mb-3">
								<label>Correo Electronico o institucional</label>
								<input id="textEmail" runat="server" name="email" type="email" class="form-control form-control-lg" />
							</div>

							<div class="form-group mb-0">
								<div class="row">
									<div class="col-sm-6 mb-3">
										<label>Contrasena</label>
										<input id="textPas" runat="server" name="pwd" type="password" class="form-control form-control-lg" />
									</div>
									<div class="col-sm-6 mb-3">
										<label>Confirmar contrasena</label>
										<input id="textConfirm" runat="server" name="pwd_confirm" type="password" class="form-control form-control-lg" />
									</div>
								</div>
							</div>

							<div class="row">
								<div class="col-sm-8">
                                    <div class="form-group row pb-4">
                                        <label class="col-lg-3 control-label text-lg-end pt-2">Tipo de cuenta: </label>
                                        <div class="col-lg-6">
                                            <asp:DropDownList id="dropUser" runat="server" class="form-control mb-3">
                                                <asp:ListItem>Tutor</asp:ListItem>
                                                <asp:ListItem>Tutorado</asp:ListItem>
                                            </asp:DropDownList>

                                        </div>
                                    </div>
								</div>
							</div>
                            <div class="row align-items-center">
                                <div class="text-right">
									<asp:LinkButton ID="btnSignup" OnClick="btnSignup_Click" runat="server" type="submit" class="btn btn-primary mt-2">Registrarse</asp:LinkButton>
								</div>
                            </div>
						</form>
					</div>
				</div>

				<p class="text-center text-muted mt-3 mb-3">&copy; Copyright 2021. All Rights Reserved.</p>
			</div>
		</section>
		</form>
		<!-- end: page -->

		<!-- Vendor -->
		<script src="vendor/jquery/jquery.js"></script>
		<script src="vendor/jquery-browser-mobile/jquery.browser.mobile.js"></script>
		<script src="vendor/popper/umd/popper.min.js"></script>
		<script src="vendor/bootstrap/js/bootstrap.bundle.min.js"></script>
		<script src="vendor/bootstrap-datepicker/js/bootstrap-datepicker.js"></script>
		<script src="vendor/common/common.js"></script>
		<script src="vendor/nanoscroller/nanoscroller.js"></script>
		<script src="vendor/magnific-popup/jquery.magnific-popup.js"></script>
		<script src="vendor/jquery-placeholder/jquery.placeholder.js"></script>

		<!-- Specific Page Vendor -->

		<!-- Theme Base, Components and Settings -->
		<script src="js/theme.js"></script>

		<!-- Theme Custom -->
		<script src="js/custom.js"></script>

		<!-- Theme Initialization Files -->
		<script src="js/theme.init.js"></script>

	</body>
</html>