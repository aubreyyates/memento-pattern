namespace MementoPattern
{
    public class Editor
    {
        private string Content;

        public EditorState CreateState()
        {
            return new EditorState(Content);
        }

        public void Restore(EditorState editorState)
        {
            Content = editorState.GetContent();
        }

        public string GetContent() 
        { 
            return Content;
        }

        public void SetContent(string content)
        {
            Content = content;
        }
    }
}
