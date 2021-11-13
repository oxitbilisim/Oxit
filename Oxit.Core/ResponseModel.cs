namespace Oxit.Core
{
    public class ResponseModel
    {

        public ResponseModel()
        {
            Message = "Bir hata oluştu";
            Success = false;
        }
        public ResponseModel(string Message)
        {
            this.Message = Message;
            Success = false;
        }
        public ResponseModel(string Message, bool Success)
        {
            this.Message = Message;
            this.Success = Success;
        }
        public ResponseModel(bool Success)
        {
            this.Message = "İşlem Başarılı";
            this.Success = Success;
        }
        public ResponseModel(string Message, bool Success, object Data)
        {
            this.Message = Message;
            this.Success = Success;
            this.Data = Data;
        }
        public ResponseModel(object Data)
        {
            this.Data = Data;
            this.Message = "İşlem Başarılı";
            this.Success = true;
        }
        public bool Success { get; set; } = false;
        public string Message { get; set; }
        public object Data { get; set; }
    }
}
