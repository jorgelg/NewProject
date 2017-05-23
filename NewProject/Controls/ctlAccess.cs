using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Claims;
using NewProject.CustomLibraries;
using NewProject.Models;
using System.Web;
using System.Web.Mvc;
using NewProject.DBServices;

namespace NewProject.Controls
{
    public class ctlAccess
    {
        Usuarios clsUsuario;
        public ctlAccess()
        {
            clsUsuario = new Usuarios();
        }

        public ClaimsIdentity IniciarSesion(string user,string password)
        {
            using(var db=new AccessDBContext())
            {
                var usuarioID = db.Usuarios.FirstOrDefault(u => u.UserId == user);
                if (usuarioID != null)
                {
                   
                    var userPassword = usuarioID.Password;
                    var decryptedPassword = CustomDecrypt.Decrypt(userPassword);
                    if (password == decryptedPassword)
                    {
                        var getName2 = usuarioID.Personas_con_Accesos.Personas_Naturales.Nombres + ' ' + usuarioID.Personas_con_Accesos.Personas_Naturales.Apellido_Paterno + ' ' + usuarioID.Personas_con_Accesos.Personas_Naturales.Apellido_Materno;
                        var permiso = usuarioID.Permisos.Descripcion;

                        //cookie
                        var identity = new ClaimsIdentity(new[]
                        {
                            new Claim(ClaimTypes.Name,getName2),
                            new Claim(ClaimTypes.NameIdentifier,user),
                            new Claim(ClaimTypes.Role,permiso)
                        },
                        "ApplicationCookie");
                        //var ctx = Request.GetOwinContext();
                        //var authManager = ctx.Authentication;
                        //authManager.SignIn(identity);
                        return identity;
                     
                    }
                    else
                    {
                        throw new Exception("Password incorrecta...");
                    }
                }
                else
                {
                    throw new Exception("Usuario inexistente...");
                }
            }
            
        }

        public bool CrearUsuario(string nombre, string ap, string am, string email, string ci,string userid, string password)
        {
            ctlPersonas persona = new ctlPersonas();
            try
            {
                var personaid = persona.RegistrarPersona(nombre, ap, am, email, ci);
                using (var db = new DBServices.AccessDBContext())
                {
                    var persona_con_acceso = db.Personas_con_Accesos.Create();
                    persona_con_acceso.PersonaId = personaid;
                    db.Personas_con_Accesos.Add(persona_con_acceso);
                    db.SaveChanges();
                    if (persona_con_acceso.Id == 0)
                    {
                        throw new Exception("Error en asignacion de acceso...");
                    }
                    var encryptedpassword = CustomEncrypt.Encrypt(password);
                    var usuario = db.Usuarios.Create();
                    usuario.UserId = userid;
                    usuario.Password = encryptedpassword;
                    usuario.PersonaId = persona_con_acceso.Id;
                    usuario.PermisoId = 1;
                    db.Usuarios.Add(usuario);
                    db.SaveChanges();
                    if (usuario.Id != 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch(Exception e)
            {
                throw e;
            }

            finally
            {
                
            }
                
            
        }
    }

}
