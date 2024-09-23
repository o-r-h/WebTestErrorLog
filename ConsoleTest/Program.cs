using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleTest
{
    class Program
    {
        static async Task Main(string[] args)
        {
            TestTimeOutBackent();


            Console.ReadLine();

        }

        static async void JsonErrorExample() {
            string json = @"{
           'Btinreq':{
              'Device':'',
              'Usuario':'',
              'Requerimiento':'',
              'Canal':'',
              'Token':''
           },
           'alertasTempranas':{
              'JAQMBBTALERTATEMPRANA':[
                 
              ]
           },
           'Erroresnegocio':{
              'BTErrorNegocio':[
            {   'Severidad': 'E',
                'Descripcion': 'AJAQM04Milegal',
                'Codigo': 10001
            },
            {
                'Severidad': 'E',
                'Descripcion': 'AJAQM04Mcom.dlya.bantotal.ajaqm04m.execute_int(ajaqm04m.java:1082)',
                'Codigo': 10002
            },
            {
                'Severidad': 'E',
                'Descripcion': 'AJAQM04Mcom.dlya.bantotal.ajaqm04m.execute(ajaqm04m.java:63)',
                'Codigo': 10003
            },
            {
                'Severidad': 'E',
                'Descripcion': 'AJAQM04Mcom.dlya.bantotal.pjaqm04m.execute_int(pjaqm04m.java:73)',
                'Codigo': 10004
            },
            {
                'Severidad': 'E',
                'Descripcion': 'AJAQM04Mcom.dlya.bantotal.pjaqm04m.execute(pjaqm04m.java:61)',
                'Codigo': 10005
            },
            {
                'Severidad': 'E',
                'Descripcion': 'AJAQM04Msun.reflect.NativeMethodAccessorImpl.invoke0(Native Method)',
                'Codigo': 10006
            },
            {
                'Severidad': 'E',
                'Descripcion': 'AJAQM04Msun.reflect.NativeMethodAccessorImpl.invoke(NativeMethodAccessorImpl.java:39)',
                'Codigo': 10007
            },
            {
                'Severidad': 'E',
                'Descripcion': 'AJAQM04Msun.reflect.DelegatingMethodAccessorImpl.invoke(DelegatingMethodAccessorImpl.java:25)',
                'Codigo': 10008
            },
            {
                'Severidad': 'E',
                'Descripcion': 'AJAQM04Mjava.lang.reflect.Method.invoke(Method.java:597)',
                'Codigo': 10009
            },
            {
                'Severidad': 'E',
                'Descripcion': 'AJAQM04Mcom.dlya.bantotal.btarq.BTServiceExecution.execute_int(Unknown Source)',
                'Codigo': 10010
            },
            {
                'Severidad': 'E',
                'Descripcion': 'AJAQM04Mcom.dlya.bantotal.btarq.BTServiceExecution.executeService(Unknown Source)',
                'Codigo': 10011
            },
            {
                'Severidad': 'E',
                'Descripcion': 'AJAQM04Mcom.dlya.bantotal.btarq.BTSOA.executeService(Unknown Source)',
                'Codigo': 10012
            },
            {
                'Severidad': 'E',
                'Descripcion': 'AJAQM04Mcom.dlya.bantotal.odwsbt_impl.webExecute(odwsbt_impl.java:642)',
                'Codigo': 10013
            },
            {
                'Severidad': 'E',
                'Descripcion': 'AJAQM04Mcom.genexus.webpanels.GXWebObjectBase.doExecute(GXWebObjectBase.java:94)',
                'Codigo': 10014
            },
            {
                'Severidad': 'E',
                'Descripcion': 'AJAQM04Mcom.dlya.bantotal.odwsbt.doExecute(odwsbt.java:20)',
                'Codigo': 10015
            },
            {
                'Severidad': 'E',
                'Descripcion': 'AJAQM04Mcom.genexus.webpanels.GXWebObjectStub.callExecute(GXWebObjectStub.java:111)',
                'Codigo': 10016
            },
            {
                'Severidad': 'E',
                'Descripcion': 'AJAQM04Mcom.genexus.webpanels.GXWebObjectStub.doPost(GXWebObjectStub.java:44)',
                'Codigo': 10017
            },
            {
                'Severidad': 'E',
                'Descripcion': 'AJAQM04Mjavax.servlet.http.HttpServlet.service(HttpServlet.java:637)',
                'Codigo': 10018
            },
            {
                'Severidad': 'E',
                'Descripcion': 'AJAQM04Mjavax.servlet.http.HttpServlet.service(HttpServlet.java:717)',
                'Codigo': 10019
            },
            {
                'Severidad': 'E',
                'Descripcion': 'AJAQM04Mcom.dlya.serverextensions.invoker.ServletInvoker.service(ServletInvoker.java:38)',
                'Codigo': 10020
            },
            {
                'Severidad': 'E',
                'Descripcion': 'AJAQM04Mjavax.servlet.http.HttpServlet.service(HttpServlet.java:717)',
                'Codigo': 10021
            },
            {
                'Severidad': 'E',
                'Descripcion': 'AJAQM04Morg.apache.catalina.core.ApplicationFilterChain.internalDoFilter(ApplicationFilterChain.java:290)',
                'Codigo': 10022
            },
            {
                'Severidad': 'E',
                'Descripcion': 'AJAQM04Morg.apache.catalina.core.ApplicationFilterChain.doFilter(ApplicationFilterChain.java:206)',
                'Codigo': 10023
            },
            {
                'Severidad': 'E',
                'Descripcion': 'AJAQM04Morg.apache.catalina.core.ApplicationDispatcher.invoke(ApplicationDispatcher.java:630)',
                'Codigo': 10024
            },
            {
                'Severidad': 'E',
                'Descripcion': 'AJAQM04Morg.apache.catalina.core.ApplicationDispatcher.processRequest(ApplicationDispatcher.java:436)',
                'Codigo': 10025
            },
            {
                'Severidad': 'E',
                'Descripcion': 'AJAQM04Morg.apache.catalina.core.ApplicationDispatcher.doForward(ApplicationDispatcher.java:374)',
                'Codigo': 10026
            },
            {
                'Severidad': 'E',
                'Descripcion': 'AJAQM04Morg.apache.catalina.core.ApplicationDispatcher.forward(ApplicationDispatcher.java:302)',
                'Codigo': 10027
            },
            {
                'Severidad': 'E',
                'Descripcion': 'AJAQM04Mcom.dlya.bantotal.BTSOAFilter.doFilter(Unknown Source)',
                'Codigo': 10028
            },
            {
                'Severidad': 'E',
                'Descripcion': 'AJAQM04Morg.apache.catalina.core.ApplicationFilterChain.internalDoFilter(ApplicationFilterChain.java:235)',
                'Codigo': 10029
            },
            {
                'Severidad': 'E',
                'Descripcion': 'AJAQM04Morg.apache.catalina.core.ApplicationFilterChain.doFilter(ApplicationFilterChain.java:206)',
                'Codigo': 10030
            },
            {
                'Severidad': 'E',
                'Descripcion': 'AJAQM04Morg.apache.catalina.core.StandardWrapperValve.invoke(StandardWrapperValve.java:233)',
                'Codigo': 10031
            },
            {
                'Severidad': 'E',
                'Descripcion': 'AJAQM04Morg.apache.catalina.core.StandardContextValve.invoke(StandardContextValve.java:191)',
                'Codigo': 10032
            },
            {
                'Severidad': 'E',
                'Descripcion': 'AJAQM04Morg.apache.catalina.core.StandardHostValve.invoke(StandardHostValve.java:128)',
                'Codigo': 10033
                }
              ]
           },
           'Btoutreq':{
              'Numero':0,
              'Estado':'BTS_CONF_ERROR',
              'Servicio':'CMACAlertasTempranas.ObtenerATparaGA',
              'Requerimiento':'',
              'Fecha':'2024-08-07',
              'Hora':'15:27:39',
              'Canal':''
           }
        }";

            //var descripciones = new List<string>();
            StringBuilder sb = new StringBuilder();
            var jsonObject = JObject.Parse(json);
            var erroresNegocio = jsonObject["Erroresnegocio"]["BTErrorNegocio"];

            foreach (var error in erroresNegocio)
            {
                sb.AppendLine(error["Descripcion"].ToString() ?? "");
            }

            Console.WriteLine("Errores:");
            Console.WriteLine(sb);
        }



        static async void TestTimeOutBackent(){
            Console.WriteLine("Indique tiempo en segundos para el timeOut");
            string tiempoStr = Console.ReadLine();
            if (int.TryParse(tiempoStr, out int tiempo))
            {
                Console.WriteLine("Inicio");
                Console.WriteLine(DateTime.Now.ToString());
                Console.WriteLine("-");
                Stopwatch sw = new Stopwatch();
                using (var cts = new CancellationTokenSource(TimeSpan.FromSeconds(tiempo)))
                {
                    sw.Restart();
                    try
                    {
                        using (var client = new HttpClient())
                        {
                            //var result = await client.GetAsync("http://blog.cincura.net/", cts.Token);
                            var result = await client.GetAsync("http://google.com/", cts.Token);
                            Console.WriteLine(result);
                            Console.WriteLine($"Tarea ejecutada: {sw.Elapsed}");
                            Console.ReadLine();
                        }
                    }
                    catch (OperationCanceledException opex)
                    {

                        Console.WriteLine($"Tiempo limite excedido: {opex.Message} {sw.Elapsed}");
                        Console.ReadLine();
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine($"Error: {ex.Message} tiempo {sw.Elapsed}");
                        Console.ReadLine();
                    }
                }
                Console.WriteLine("Servicio terminado");
                Console.WriteLine(DateTime.Now.ToString());
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Por favor, ingrese un número válido.");

            }
        }


        static void TestVelocity()
        {
            Stopwatch sw = new Stopwatch();

            sw.Stop();

            Console.WriteLine("Reflection Result:");

            sw.Start();
            for (int i = 0; i < 1000000; i++)
            {
                //Using reflection to get the current method name.
                PassedName(MethodBase.GetCurrentMethod().Name);
            }
            Console.WriteLine(sw.Elapsed);

            Console.WriteLine("StackFrame Result");

            sw.Restart();

            for (int i = 0; i < 1000000; i++)
            {
                UsingStackFrame();
            }

            Console.WriteLine(sw.Elapsed);

            Console.WriteLine("CallerMemberName attribute Result:");

            sw.Restart();
            for (int i = 0; i < 1000000; i++)
            {
                UsingCallerAttribute();
            }

            Console.WriteLine(sw.Elapsed);

            sw.Stop();



            Console.WriteLine("Done");
            Console.Read();
        }


        static void PassedName(string name)
        {

        }

        static void UsingStackFrame()
        {
            string name = new StackFrame(1).GetMethod().Name;
        }

        static void UsingCallerAttribute([CallerMemberName] string memberName = "")
        {

        }
    }
}
