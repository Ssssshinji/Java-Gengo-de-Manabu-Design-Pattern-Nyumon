using System.IO;
namespace Builder
{
    public class HTMLBuilder : Builder
    {
        private string filename;
        private StreamWriter writer;
        public void makeTitle(string title){
            filename = title + ".html";
            //不懂但是牛逼！
            using(FileStream F = new FileStream(filename, FileMode.Append,FileAccess.Write,FileShare.Write)){

            };
            try
            {
                writer = new StreamWriter(filename);
            }
            catch (System.Exception)
            {
                
                throw;
            }
            writer.Write("<html><head><title>" + title + "</title></head><body>");
            writer.Write("<h1>" + title + "</h1>");
            
        }
        public void makeString(string str){
            writer.Write("<p>" + str + "</p>");
        }
        public void makeItems(string[] items){
            writer.Write("<ul>");
            for(int i = 0; i < items.Length; i++){
                writer.Write("<li>" + items[i] + "</li>");
            }
            writer.Write("</ul>");
        }
        public void close(){
            writer.Write("</body></html>");
            writer.Close();
        }
        public string getResult(){
            return filename;
        }
    }
}