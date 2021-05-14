using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Google.Apis.Auth.OAuth2;
using Google.Apis.Classroom.v1;
using Google.Apis.Classroom.v1.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System.IO;
using System.Threading;

using Google.Apis.Drive.v3;
using Google.Apis.Drive.v3.Data;

namespace WindowsFormsApp1
{
    public partial class FrmTarea : System.Windows.Forms.Form
    {
        static string[] Scopes = { ClassroomService.Scope.ClassroomCoursesReadonly, ClassroomService.Scope.ClassroomCourseworkStudentsReadonly, ClassroomService.Scope.ClassroomStudentSubmissionsMeReadonly, ClassroomService.Scope.ClassroomRostersReadonly };
        static string ApplicationName = "Classroom API .NET Quickstart";

        static string[] Scopes2 = { DriveService.Scope.DriveReadonly };
        static string ApplicationName2 = "Drive API .NET Quickstart";

        private static FrmTarea frmTarea = null;
        private static string _idcurso = null; //La clase
        private static string _idtarea = null;
        private static string _titulo_tarea = null;

        private static Dictionary<String, StudentSubmission> _envíos = new Dictionary<string, StudentSubmission>();

        public FrmTarea()
        {
            InitializeComponent();
            frmTarea = this;
        }

        public FrmTarea(string idcurso, string idtarea, string titulo_tarea = null)
        {
            InitializeComponent();
            frmTarea = this;
            _idcurso = idcurso;
            _idtarea = idtarea;
            _titulo_tarea = titulo_tarea;
        }

        private void FrmTarea_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Cargando; IdTarea: " + _idtarea + "; IdCurso" + _idcurso);
            this.Text = "Tarea: " + _titulo_tarea;

            /*Task tarea = CargarDatosIniciales(sender, e);
            MessageBox.Show(tarea.CreationOptions.ToString());
            await tarea;*/

            CargarDatosIniciales(sender, e);

            /*Task.Factory.StartNew( () =>  CargarDatosIniciales(sender, e));*/
            /*Task allTasks = Task.WhenAll(tarea);

            try
            {
                await allTasks;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
                Console.WriteLine("Task IsFaulted: " + allTasks.IsFaulted);
                foreach (var inEx in allTasks.Exception.InnerExceptions)
                {
                    Console.WriteLine("Task Inner Exception: " + inEx.Message);
                }
            }*/

            //CargarDatosIniciales(sender, e);

            /*pegado*/

            /*fin pegado*/

        }

        public static async Task CargarDatosIniciales(object sender, EventArgs e)
        {
            UserCredential credential;

            using (var stream =
                new FileStream("credentials-p4.json", FileMode.Open, FileAccess.Read))
            {
                // The file token.json stores the user's access and refresh tokens, and is created
                // automatically when the authorization flow completes for the first time.
                string credPath = "token.json";
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
                Console.WriteLine("Credential file saved to: " + credPath);
            }

            //Servicio

            // Create Classroom API service.
            var service = new ClassroomService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });

            //1. Obtenemos los alumnos y los envíos de manera asíncrona

            CoursesResource.StudentsResource.ListRequest request = service.Courses.Students.List(_idcurso);
            CoursesResource.CourseWorkResource.StudentSubmissionsResource.ListRequest request2 = service.Courses.CourseWork.StudentSubmissions.List(_idcurso, _idtarea);

            var TareaClsAPi = DescargarClsAPI(request);
            var TareaEnvíosAPI = DescargarClsEnvíosAPI(request2);

            var todasTareas = new List<Task> { TareaEnvíosAPI, TareaClsAPi };
            while (todasTareas.Count > 0)
            {
                Task finishedTask = await Task.WhenAny(todasTareas);
                if (finishedTask == TareaEnvíosAPI)
                {
                    /*frmppal.toolStripProgressBar2.ProgressBar.Style = ProgressBarStyle.Continuous;
                    frmppal.toolStripProgressBar2.ProgressBar.Value = frmppal.toolStripProgressBar2.ProgressBar.Maximum;*/
                }
                else if (finishedTask == TareaClsAPi)
                {
                    /*frmppal.toolStripProgressBar3.ProgressBar.Style = ProgressBarStyle.Continuous;
                    frmppal.toolStripProgressBar3.ProgressBar.Value = frmppal.toolStripProgressBar2.ProgressBar.Maximum;*/
                }
                todasTareas.Remove(finishedTask);
            }

            ListStudentsResponse resp_lista_estudiantes = TareaClsAPi.Result;
            var lista_estudiantes = resp_lista_estudiantes.Students;
            ListStudentSubmissionsResponse resp_lista_envíos = TareaEnvíosAPI.Result;
            var lista_envíos = resp_lista_envíos.StudentSubmissions;
            //MessageBox.Show(r.ToString());

            //2. Por cada envío, sus adjuntos, y almacenamos esa información en un diccionario de envíos
            if (lista_envíos != null && lista_envíos.Count > 0)
            {
                foreach (var envio in lista_envíos)
                {
                    //Console.WriteLine("{0} / {1}", trabajo.Id, trabajo.Description);
                    Console.WriteLine("{0} / {1} / {2}", envio.Id, envio.UpdateTime, envio.UserId);
                    /*this.TxtBoxDatosEnvío.Text = "Id Envío: " + envio.Id + Environment.NewLine;
                    this.TxtBoxDatosEnvío.Text += "Fecha Envío: " + envio.UpdateTime + Environment.NewLine;
                    this.TxtBoxDatosEnvío.Text += "Estado: " + envio.State + Environment.NewLine;
                    this.TxtBoxDatosEnvío.Text += "Borrador: " + envio.DraftGrade + Environment.NewLine;
                    this.TxtBoxDatosEnvío.Text += "Id Usuario: " + envio.UserId;*/

                    _envíos.Add(envio.UserId, envio);

                    /*if (envio.AssignmentSubmission != null)
                    {
                        if (envio.AssignmentSubmission.Attachments != null && envio.AssignmentSubmission.Attachments.Count > 0)
                        {
                            Console.WriteLine("- Adjuntos -");
                            foreach (var adjunto in envio.AssignmentSubmission.Attachments)
                            {
                                Console.WriteLine(" - Enlace - {0}", adjunto.DriveFile.AlternateLink);
                                Console.WriteLine(" - Fichero - {0}", adjunto.DriveFile.Title);
                                Console.WriteLine(" - Id - {0}", adjunto.DriveFile.Id);
                                //Console.WriteLine(" - Id - {0}", adjunto.);

                                //this.DtGVAdjuntos.Rows.Add(adjunto.DriveFile.Id, adjunto.DriveFile.Title, adjunto.DriveFile.AlternateLink, "-");

                            }
                        }
                        else
                        {
                            //this.TxtBoxDatosEnvío.Text += Environment.NewLine + "No hay adjuntos";
                        }
                    }
                    else
                    {
                        //this.TxtBoxDatosEnvío.Text += Environment.NewLine + "No hay información";


                    }*/
                }
            }

            //3. Presentamos la información por pantalla
            if (lista_estudiantes != null && lista_estudiantes.Count > 0)
            {

                foreach (var estudiante in lista_estudiantes)
                {
                    string estudiante_id = estudiante.UserId;
                    string estudiante_nombre = estudiante.Profile.Name.GivenName;
                    string estudiante_apellidos = estudiante.Profile.Name.FamilyName;
                    string estudiante_email = estudiante.Profile.EmailAddress;

                    Console.WriteLine("Correo electrónico: {0}", estudiante_email);
                    Console.WriteLine("{0} / {1} / {2} / {3}", estudiante.UserId, estudiante.Profile.Name.FullName, estudiante.Profile.Name.FamilyName, estudiante.Profile.Name.GivenName);
                    //2. Por cada alumno, obtenemos sus envíos
                    StudentSubmission envío = _envíos[estudiante_id];

                    string envío_id = envío.Id;
                    string envío_fecha = envío.UpdateTime.ToString();
                    string envío_estado = envío.State;
                    string envío_retrasado = envío.Late.ToString();
                    int envío_n_adjuntos = 0;
                    if (envío.AssignmentSubmission != null)
                    {
                        if (envío.AssignmentSubmission.Attachments != null)
                        {
                            envío_n_adjuntos = envío.AssignmentSubmission.Attachments.Count();
                        }
                    }

                    frmTarea.DtGVEnvíos.Rows.Add(estudiante_id, estudiante_nombre, estudiante_apellidos, envío_id, envío_fecha, envío_estado, envío_retrasado, envío_n_adjuntos, "-");

                }

            }
        }

        private static async Task<ListStudentsResponse> DescargarClsAPI(CoursesResource.StudentsResource.ListRequest solicitud)
        {
            //respuesta = await solicitud.Execute();
            //return 1;

            Console.WriteLine("Subproceso asíncrono para obtener listado de Estudiantes");
            //ListStudentsResponse r = new ListStudentsResponse();
            ListStudentsResponse r = await solicitud.ExecuteAsync();

            //FrmTarea._lista_respuesta_estudiantes = r;
            //respuesta = r.Students.Count;

            return r;
        }

        private static async Task<ListStudentSubmissionsResponse> DescargarClsEnvíosAPI(CoursesResource.CourseWorkResource.StudentSubmissionsResource.ListRequest solicitud)
        {
            //respuesta = await solicitud.Execute();
            //return 1;

            Console.WriteLine("Subproceso asíncrono para obtener listado de envíos");
            //ListStudentsResponse r = new ListStudentsResponse();
            ListStudentSubmissionsResponse r = await solicitud.ExecuteAsync();

            return r;
        }
    }
}
