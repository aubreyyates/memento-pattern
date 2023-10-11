namespace MementoPattern
{
    /// <summary>
    /// The Editor class represents the element that will take in and store content. It is also known as the 
    /// originator.
    /// </summary>
    public class Editor
    {
        /// <summary>
        /// The content.
        /// </summary>
        private string Content;

        /// <summary>
        /// Creates an EditorState to hold a snapshot of the current content and returns it.
        /// </summary>
        /// <returns>The EditorState that contains the current content.</returns>
        public EditorState CreateState()
        {
            return new EditorState(Content);
        }

        /// <summary>
        /// Restores the content to that of a given EditorState's held content.
        /// </summary>
        /// <param name="editorState">The EditorState.</param>
        public void Restore(EditorState editorState)
        {
            Content = editorState.GetContent();
        }

        /// <summary>
        /// Returns the content.
        /// </summary>
        /// <returns>The content to return.</returns>
        public string GetContent() 
        { 
            return Content;
        }

        /// <summary>
        /// Sets the content.
        /// </summary>
        /// <param name="content">The content to be set.</param>
        public void SetContent(string content)
        {
            Content = content;
        }
    }
}
