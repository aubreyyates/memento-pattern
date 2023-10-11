namespace MementoPattern
{
    /// <summary>
    /// The EditorState class holds a snapshot of content. It is also known as the Memento.
    /// </summary>
    public class EditorState
    {
        /// <summary>
        /// The content snapshot.
        /// </summary>
        private readonly string _content;

        /// <summary>
        /// The contstructor takes the content to store as a snapshot.
        /// </summary>
        /// <param name="content">The content to store as a snapshot.</param>
        public EditorState(string content) 
        {
            _content = content;
        }

        /// <summary>
        /// Returns the content snapshot.
        /// </summary>
        /// <returns>The content snapshot.</returns>
        public string GetContent()
        {
            return _content;
        }
    }
}
