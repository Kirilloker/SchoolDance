namespace SchoolDance.Util
{
    public static class ToolsForm
    {
        public static void ShowMessage(string errorMessage = "Что-то пошло не так", string caption = "Ошибка", MessageBoxIcon mes = MessageBoxIcon.Error)
        {
            MessageBox.Show(errorMessage, caption, MessageBoxButtons.OK, mes);
        }
    }
}
