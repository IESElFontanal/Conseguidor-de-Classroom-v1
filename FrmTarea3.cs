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
    public partial class FrmTarea3 : System.Windows.Forms.Form
    {
        static string[] Scopes = { ClassroomService.Scope.ClassroomCoursesReadonly, ClassroomService.Scope.ClassroomCourseworkStudentsReadonly, ClassroomService.Scope.ClassroomStudentSubmissionsMeReadonly, ClassroomService.Scope.ClassroomRostersReadonly };
        static string ApplicationName = "Classroom API .NET Quickstart";

        static string[] Scopes2 = { DriveService.Scope.DriveReadonly };
        static string ApplicationName2 = "Drive API .NET Quickstart";

        private static FrmTarea3 frmTarea2 = null;
        private static string _idcurso = null; //La clase
        private static string _idtarea = null;
        private static string _titulo_tarea = null;

        private static Dictionary<String, StudentSubmission> _envíos = new Dictionary<string, StudentSubmission>();

        public FrmTarea3()
        {
            InitializeComponent();
            frmTarea2 = this;
        }

        public FrmTarea3(string idcurso, string idtarea, string titulo_tarea = null)
        {
            InitializeComponent();
            frmTarea2 = this;
            _idcurso = idcurso;
            _idtarea = idtarea;
            _titulo_tarea = titulo_tarea;
            _envíos.Clear();
        }

        private void FrmTarea2_Load(object sender, EventArgs e)
        {
            this.Text = "Tarea: " + _titulo_tarea;

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

            CoursesResource.StudentsResource.ListRequest request = service.Courses.Students.List(_idcurso);
            CoursesResource.CourseWorkResource.StudentSubmissionsResource.ListRequest request2 = service.Courses.CourseWork.StudentSubmissions.List(_idcurso, _idtarea);

            ListStudentsResponse resp_lista_estudiantes = request.Execute();
            ListStudentSubmissionsResponse resp_lista_envíos = request2.Execute();

            var lista_estudiantes = resp_lista_estudiantes.Students;
            var lista_envíos = resp_lista_envíos.StudentSubmissions;

            if (lista_envíos != null && lista_envíos.Count > 0)
            {
                foreach (var envio in lista_envíos)
                {

                    Console.WriteLine("{0} / {1} / {2}", envio.Id, envio.UpdateTime, envio.UserId);
                    _envíos.Add(envio.UserId, envio);
                }
            }

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

                    frmTarea2.DtGVEnvíos.Rows.Add(estudiante_id, estudiante_nombre, estudiante_apellidos, envío_id, envío_fecha, envío_estado, envío_retrasado, envío_n_adjuntos, "-");

                }

            }

        }

        private async void btnDescargarLista_Click(object sender, EventArgs e)
        {
            btnDescargarLista.Enabled = false;
            await DescargarLista();
            //DescargarLista();
            btnDescargarLista.Enabled = true;
        }

        public async Task DescargarLista()
        {

            UserCredential credential;

            using (var stream =
                new FileStream("credentials-drive.json", FileMode.Open, FileAccess.Read))
            {
                // The file token.json stores the user's access and refresh tokens, and is created
                // automatically when the authorization flow completes for the first time.
                string credPath = "token2.json";
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes2,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
                Console.WriteLine("Credential file saved to: " + credPath);
            }

            // Create Drive API service.
            var service = new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName2,
            });

            //var todasTareas = new List<Task> { };
            foreach (DataGridViewRow fila in frmTarea2.DtGVEnvíos.Rows)
            {
                //if(fila.Cells["ClnNAdjuntosEnvío"].Value.)
                //MessageBox.Show(fila.Cells["ClnIdAdjunto"].Value.ToString());
                //1. Preparar carpeta

                string nombre_alumno = fila.Cells["ClnApellidosAlumno"].Value.ToString() + ", " + fila.Cells["ClnNombreAlumno"].Value.ToString();
                string fecha_entrega = fila.Cells["ClnFechaEnvío"].Value.ToString();
                string cadena_ruta_fecha = fecha_entrega.Substring(8, 2) + fecha_entrega.Substring(3, 2) + fecha_entrega.Substring(0, 2);

                //MessageBox.Show(ComponerRuta(nombre_alumno, cadena_ruta_fecha));

                string filepath = ComponerRuta(nombre_alumno, cadena_ruta_fecha);

                Directory.CreateDirectory(filepath);

                /*string filepath = @"D:\Temp\tomate";
                if (!Directory.Exists(filepath))
                    Directory.CreateDirectory(filepath);*/

                if (Int32.Parse(fila.Cells["ClnNAdjuntosEnvío"].Value.ToString()) > 0)
                {
                    fila.Cells["ClnDescarga"].Value = "Descargando...";
                    //todasTareas.Add(DownloadFile(service, fila.Cells["ClnIdAdjunto"].Value.ToString(), string.Format(filepath + @"\{0}", fila.Cells["ClnNombreFichero"].Value.ToString()), fila.Index, frmppal.DtGVAdjuntos));
                    StudentSubmission envío = _envíos[fila.Cells["ClnIdAlumno"].Value.ToString()];

                    if (envío.AssignmentSubmission != null)
                    {
                        if (envío.AssignmentSubmission.Attachments != null && envío.AssignmentSubmission.Attachments.Count > 0)
                        {
                            Console.WriteLine("- Adjuntos -");
                            foreach (var adjunto in envío.AssignmentSubmission.Attachments)
                            {
                                if (adjunto.DriveFile != null)
                                {
                                    Console.WriteLine(" - Enlace - {0}", adjunto.DriveFile.AlternateLink);
                                    Console.WriteLine(" - Fichero - {0}", adjunto.DriveFile.Title);
                                    Console.WriteLine(" - Id - {0}", adjunto.DriveFile.Id);
                                    //Console.WriteLine(" - Id - {0}", adjunto.);

                                    //this.DtGVAdjuntos.Rows.Add(adjunto.DriveFile.Id, adjunto.DriveFile.Title, adjunto.DriveFile.AlternateLink, "-");

                                    string nombre_fichero = adjunto.DriveFile.Title;
                                    foreach (var c in Path.GetInvalidFileNameChars()) { nombre_fichero = nombre_fichero.Replace(c, '-'); }

                                    var todasTareas = new List<Task> { };
                                    todasTareas.Add(DownloadFile(service, adjunto.DriveFile.Id, string.Format(filepath + @"\{0}", nombre_fichero), fila.Index, frmTarea2.DtGVEnvíos, frmTarea2.DtGDescargas));
                                    int total = 0;
                                    while (todasTareas.Any())
                                    {
                                        Task finishedTask = await Task.WhenAny(todasTareas);
                                        todasTareas.Remove(finishedTask);
                                        //total += finishedTask.;
                                    }
                                    MessageBox.Show("Total: " + total);
                                }
                                else
                                {
                                    fila.Cells["ClnDescarga"].Value = "Error";
                                }
                            }
                        }
                        else
                        {
                            fila.Cells["ClnDescarga"].Value = "No hay adjuntos";
                        }
                    }

                }
                else
                {
                    fila.Cells["ClnDescarga"].Value = "Ignorado";
                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public string ComponerRuta(string NombreAlumno = null, string Fecha = null) 
        {
            string ruta = "";

            ruta = TxtInicioRuta.Text;
            if(ChkNombreAlumno.CheckState == CheckState.Checked && NombreAlumno != null)
            {
                ruta += @"\" + NombreAlumno;
            }

            if (chkIntermedioRuta.CheckState == CheckState.Checked)
            {
                ruta += @"\" + txtIntermedioRuta.Text;
            }

            if (chkFechaEntrega.CheckState == CheckState.Checked && Fecha != null)
            {
                ruta += @"\" + Fecha;
            }

            return ruta;
        }

        private static async Task<int> DownloadFile(Google.Apis.Drive.v3.DriveService service, string identificador, string saveTo, int idrow, DataGridView DtgO, DataGridView DtgF)
        {

            var request = service.Files.Get(identificador);
            var stream = new System.IO.MemoryStream();
            var respuesta = 0;

            // Add a handler which will be notified on progress changes.
            // It will notify on each chunk download and when the
            // download is completed or failed.
            request.MediaDownloader.ProgressChanged += (Google.Apis.Download.IDownloadProgress progress) =>
            {
                switch (progress.Status)
                {
                    case Google.Apis.Download.DownloadStatus.Downloading:
                        {
                            Console.WriteLine(progress.BytesDownloaded);
                            DtgO.Rows[idrow].Cells["ClnDescarga"].Value = "Descargando...";
                            respuesta = -1;
                            break;
                        }
                    case Google.Apis.Download.DownloadStatus.Completed:
                        {
                            Console.WriteLine("Download complete.");
                            string nombre_alumno = DtgO.Rows[idrow].Cells["ClnApellidosAlumno"].Value.ToString() + ", " + DtgO.Rows[idrow].Cells["ClnNombreAlumno"].Value.ToString();
                            //frmTarea2.DtGDescargas.Rows.Add(nombre_alumno, saveTo, "OK");
                            SaveStream(stream, saveTo);
                            respuesta = 1;
                            break;
                        }
                    case Google.Apis.Download.DownloadStatus.Failed:
                        {
                            Console.WriteLine("Download failed.");
                            string nombre_alumno = DtgO.Rows[idrow].Cells["ClnApellidosAlumno"].Value.ToString() + ", " + DtgO.Rows[idrow].Cells["ClnNombreAlumno"].Value.ToString();
                            //frmTarea2.DtGDescargas.Rows.Add(nombre_alumno, saveTo, "Error");
                            respuesta = 0;
                            break;
                        }
                }
            };
            await request.DownloadAsync(stream);
            return respuesta;
        }

        private static void SaveStream(System.IO.MemoryStream stream, string saveTo)
        {
            using (System.IO.FileStream file = new System.IO.FileStream(saveTo, System.IO.FileMode.Create, System.IO.FileAccess.Write))
            {
                stream.WriteTo(file);
            }
        }

    }
}
