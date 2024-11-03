namespace VuHoaiNam.Controllers
{
    internal class ApplicationDbcontext
    {
        internal readonly object categories;

        public ApplicationDbcontext()
        {
        }

        public object Categories { get; internal set; }
    }
}