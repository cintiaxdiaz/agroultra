using System.Web;
using System.Web.Optimization;

namespace EVALUACION_2_TP {
    public class BundleConfig {
        // Para obtener más información sobre las uniones, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles) {
            Bundle bundle = new ScriptBundle("~/bundles/jquery");
            bundle.Include(
                       "~/Scripts/jquery-{version}.js");
          bundles.Add(bundle);

          bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                      "~/Scripts/jquery.validate*"));

            // Utilice la versión de desarrollo de Modernizr para desarrollar y obtener información. De este modo, estará
            // para la producción, use la herramienta de compilación disponible en https://modernizr.com para seleccionar solo las pruebas que necesite.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                    "~/url/https://cdnjs.cloudflare.com/ajax/libs/jquery/3.5.1/jquery.min.js",
                    "~/url/https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/js/bootstrap.bundle.min.js",
                    "~/url/https://cdnjs.cloudflare.com/ajax/libs/jquery-easing/1.4.1/jquery.easing.min.js",
                    "~/url/https://cdnjs.cloudflare.com/ajax/libs/magnific-popup.js/1.1.0/jquery.magnific-popup.min.js",
                    "~/url/https://use.fontawesome.com/releases/v5.13.0/js/all.js",
                    "~/Content/js/scripts.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                    "~/url/https://cdnjs.cloudflare.com/ajax/libs/magnific-popup.js/1.1.0/magnific-popup.min.css",
                    "~/Content/css/styles.css"));
        }
    }
}
