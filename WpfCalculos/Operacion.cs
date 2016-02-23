using System.Web.Script.Serialization;

namespace WpfCalculos
{
    public class Operacion
    {
       
            public int Op1 { get; set; }
            public int Op2 { get; set; }

        public string ToJson()
        {
            var ser=new JavaScriptSerializer();

            return ser.Serialize(this);

        }
         
    }
}