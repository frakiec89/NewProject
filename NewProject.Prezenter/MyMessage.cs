using NewProject.Core;


namespace NewProject.Prezenter
{
    public class MyMessage
    {
        IBLContent iBLContent;
        IViewMessage viewMessage;

        public MyMessage(IBLContent iBLContent, IViewMessage viewMessage)
        {
            this.iBLContent = iBLContent;
            this.viewMessage = viewMessage;
            viewMessage.StartEvent += ViewMessage_StartEvent;
        }

        private void ViewMessage_StartEvent(object sender, System.EventArgs e)
        {
            viewMessage.Print(iBLContent.GetContent());
        }
    }
}
