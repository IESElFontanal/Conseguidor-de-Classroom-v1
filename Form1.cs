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
    

    public partial class Form1 : System.Windows.Forms.Form
    {
        static string[] Scopes = { ClassroomService.Scope.ClassroomCoursesReadonly, ClassroomService.Scope.ClassroomCourseworkStudentsReadonly, ClassroomService.Scope.ClassroomStudentSubmissionsMeReadonly, ClassroomService.Scope.ClassroomRostersReadonly };
        static string ApplicationName = "Classroom API .NET Quickstart";

        static string[] Scopes2 = { DriveService.Scope.DriveReadonly };
        static string ApplicationName2 = "Drive API .NET Quickstart";

        private static Form1 frmppal = null;

        public Form1()
        {
            InitializeComponent();
            frmppal = this;
        }

        private void Form1_Load(object sender, EventArgs e)
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

            // Define request parameters.
            CoursesResource.ListRequest request = service.Courses.List();
            //request.PageSize = 10;

            // List courses.
            ListCoursesResponse response = request.Execute();
            Console.WriteLine("Courses:");
            if (response.Courses != null && response.Courses.Count > 0)
            {
                foreach (var course in response.Courses)
                {
                    Console.WriteLine("{0} ({1})", course.Name, course.Id);
                    this.DtGVClases.Rows.Add(course.Id, course.Name + " - " + course.Section);
                }
            }
            else
            {
                Console.WriteLine("No courses found.");
            }
            //Console.Read();

            //Fin Servicio
            
        }


        private async void BtnCagarAT_Click(object sender, EventArgs e)
        {
            if (this.DtGVClases.SelectedRows.Count == 1)
            {
                //await CargarTareasyAlumnos(sender, e);
                await CargarTareasyAlumnos(sender, e);
            }
            else
            {
                MessageBox.Show("No hay ninguna clase seleccionada");
            }
            
        }

        public static async Task CargarTareasyAlumnos(object sender, EventArgs e)
        {
            string idcourse = frmppal.DtGVClases.SelectedRows[0].Cells["ClnIdCourse"].Value.ToString();
            //MessageBox.Show(idcourse);

            frmppal.DtGVTareas.Rows.Clear();
            frmppal.DtGVAlumnos.Rows.Clear();

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

            frmppal.toolStripProgressBar2.ProgressBar.Style = ProgressBarStyle.Marquee;
            frmppal.toolStripProgressBar3.ProgressBar.Style = ProgressBarStyle.Marquee;

            CoursesResource.CourseWorkResource.ListRequest request2 = service.Courses.CourseWork.List(idcourse);
            CoursesResource.StudentsResource.ListRequest request = service.Courses.Students.List(idcourse);

            var TareaCursoApi = DescargarCursoAPI(request2);
            var TareaClsAPi = DescargarClsAPI(request);

            var todasTareas = new List<Task> { TareaCursoApi, TareaClsAPi };
            while (todasTareas.Count > 0)
            {
                Task finishedTask = await Task.WhenAny(todasTareas);
                if (finishedTask == TareaCursoApi)
                {
                    frmppal.toolStripProgressBar2.ProgressBar.Style = ProgressBarStyle.Continuous;
                    frmppal.toolStripProgressBar2.ProgressBar.Value = frmppal.toolStripProgressBar2.ProgressBar.Maximum;
                }
                else if (finishedTask == TareaClsAPi)
                {
                    frmppal.toolStripProgressBar3.ProgressBar.Style = ProgressBarStyle.Continuous;
                    frmppal.toolStripProgressBar3.ProgressBar.Value = frmppal.toolStripProgressBar2.ProgressBar.Maximum;
                }
                todasTareas.Remove(finishedTask);
            }
        }

        private static async Task<int> DescargarClsAPI(CoursesResource.StudentsResource.ListRequest solicitud)
        {
            //respuesta = await solicitud.Execute();
            //return 1;

            Console.WriteLine("Estudiantes:");
            //ListStudentsResponse r = new ListStudentsResponse();
            ListStudentsResponse r = await solicitud.ExecuteAsync();
            if (r.Students != null && r.Students.Count > 0)
            {

                foreach (var estudiante in r.Students)
                {
                    //Console.WriteLine("{0} / {1}", trabajo.Id, trabajo.Description);
                    Console.WriteLine("{0} / {1} / {2} / {3}", estudiante.UserId, estudiante.Profile.Name.FullName, estudiante.Profile.Name.FamilyName, estudiante.Profile.Name.GivenName);
                    frmppal.DtGVAlumnos.Rows.Add(estudiante.UserId, estudiante.Profile.Name.FamilyName, estudiante.Profile.Name.GivenName);
                }

            }

            return 1;
        }

        private static async Task<int> DescargarCursoAPI(CoursesResource.CourseWorkResource.ListRequest solicitud)
        {
            ListCourseWorkResponse r2 = await solicitud.ExecuteAsync();

            if (r2.CourseWork != null)
            {

                foreach (var trabajo in r2.CourseWork)
                {
                    Console.WriteLine("{0} / {1}", trabajo.Id, trabajo.Title);
                    frmppal.DtGVTareas.Rows.Add(trabajo.Id, trabajo.Title);
                }

            }

            return 1;
        }

        private void BtnCargarAdjuntos_Click(object sender, EventArgs e)
        {
            string idcourse = this.DtGVClases.SelectedRows[0].Cells["ClnIdCourse"].Value.ToString();
            string idwork = this.DtGVTareas.SelectedRows[0].Cells["ClnIdTarea"].Value.ToString();
            string idestudiante = this.DtGVAlumnos.SelectedRows[0].Cells["ClnIdStudent"].Value.ToString();

            DtGVAdjuntos.Rows.Clear();

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

            CoursesResource.CourseWorkResource.StudentSubmissionsResource.ListRequest request3 = service.Courses.CourseWork.StudentSubmissions.List(idcourse, idwork);
            //request3.PageSize = 40;
            request3.UserId = idestudiante;

            ListStudentSubmissionsResponse response3 = request3.Execute();
            Console.WriteLine("---");
            Console.WriteLine("Envíos:");

            if (response3.StudentSubmissions != null && response3.StudentSubmissions.Count > 0)
            {

                foreach (var envio in response3.StudentSubmissions)
                {
                    //Console.WriteLine("{0} / {1}", trabajo.Id, trabajo.Description);
                    Console.WriteLine("{0} / {1} / {2}", envio.Id, envio.UpdateTime, envio.UserId);
                    this.TxtBoxDatosEnvío.Text = "Id Envío: " + envio.Id + Environment.NewLine;
                    this.TxtBoxDatosEnvío.Text += "Fecha Envío: " + envio.UpdateTime + Environment.NewLine;
                    this.TxtBoxDatosEnvío.Text += "Estado: " + envio.State + Environment.NewLine;
                    this.TxtBoxDatosEnvío.Text += "Borrador: " + envio.DraftGrade + Environment.NewLine;
                    this.TxtBoxDatosEnvío.Text += "Id Usuario: " + envio.UserId;

                    if (envio.AssignmentSubmission != null)
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

                                this.DtGVAdjuntos.Rows.Add(adjunto.DriveFile.Id, adjunto.DriveFile.Title, adjunto.DriveFile.AlternateLink, "-");

                            }
                        }
                        else
                        {
                            this.TxtBoxDatosEnvío.Text += Environment.NewLine + "No hay adjuntos";
                        }
                    }
                    else
                    {
                        this.TxtBoxDatosEnvío.Text += Environment.NewLine + "No hay información";


                    }

                }

            }
        }

        private async void btnDescargarLista_Click(object sender, EventArgs e)
        {
            btnDescargarLista.Enabled = false;
            await DescargarListaFicheros();

            Console.Read();
            btnDescargarLista.Enabled = true;
        }

        public static async Task DescargarListaFicheros()
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

            var todasTareas = new List<Task> { };
            foreach (DataGridViewRow fila in frmppal.DtGVAdjuntos.Rows)
            {
                //MessageBox.Show(fila.Cells["ClnIdAdjunto"].Value.ToString());
                string filepath = @"D:\Temp\tomate";
                if (!Directory.Exists(filepath))
                    Directory.CreateDirectory(filepath);

                fila.Cells["ClnEstado"].Value = "Descargando...";
                todasTareas.Add(DownloadFile(service, fila.Cells["ClnIdAdjunto"].Value.ToString(), string.Format(filepath + @"\{0}", fila.Cells["ClnNombreFichero"].Value.ToString()), fila.Index, frmppal.DtGVAdjuntos));
            }
        }

        private static async Task<int> DownloadFile(Google.Apis.Drive.v3.DriveService service, string identificador, string saveTo, int idrow, DataGridView Dtg)
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
                            Dtg.Rows[idrow].Cells["ClnEstado"].Value = "Descargando...";
                            respuesta = -1;
                            break;
                        }
                    case Google.Apis.Download.DownloadStatus.Completed:
                        {
                            Console.WriteLine("Download complete.");
                            Dtg.Rows[idrow].Cells["ClnEstado"].Value = "Descarga Realizada";
                            SaveStream(stream, saveTo);
                            respuesta = 1;
                            break;
                        }
                    case Google.Apis.Download.DownloadStatus.Failed:
                        {
                            Console.WriteLine("Download failed.");
                            Dtg.Rows[idrow].Cells["ClnEstado"].Value = "Error";
                            respuesta = 0;
                            break;
                        }
                }
            };
            await request.DownloadAsync(stream);
            return respuesta;
        }

        private static async Task<int> DownloadFile(Google.Apis.Drive.v3.DriveService service, string identificador, string saveTo)
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
                            respuesta = -1;
                            break;
                        }
                    case Google.Apis.Download.DownloadStatus.Completed:
                        {
                            Console.WriteLine("Download complete.");
                            SaveStream(stream, saveTo);
                            respuesta = 1;
                            break;
                        }
                    case Google.Apis.Download.DownloadStatus.Failed:
                        {
                            Console.WriteLine("Download failed.");
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

        private void DtGVAdjuntos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DtGVAdjuntos.CurrentCell.ColumnIndex == DtGVAdjuntos.Columns["ClnDescarga"].Index)
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

                string filepath = @"D:\Temp\tomate";
                var fila = DtGVAdjuntos.Rows[DtGVAdjuntos.CurrentCell.RowIndex];
                fila.Cells["ClnEstado"].Value = "Descargando...";
                DownloadFile(service, fila.Cells["ClnIdAdjunto"].Value.ToString(), string.Format(filepath + @"\{0}", fila.Cells["ClnNombreFichero"].Value.ToString()), fila.Index, frmppal.DtGVAdjuntos);
            }
        }

        private void DtGVTareas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string idcourse = this.DtGVClases.SelectedRows[0].Cells["ClnIdCourse"].Value.ToString();
            string idwork = this.DtGVTareas.SelectedRows[0].Cells["ClnIdTarea"].Value.ToString();
            string titulo = this.DtGVTareas.SelectedRows[0].Cells["ClnTituloTarea"].Value.ToString();
            var ftarea2 = new FrmTarea2(idcourse, idwork, titulo);
            ftarea2.Show();
            //ftarea2.Dispose();
            /*var ftarea2 = new FrmTarea(idcourse, idwork, titulo);
            ftarea2.Show();*/
        }

        private void DtGVTareas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
