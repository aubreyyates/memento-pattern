namespace MementoPattern
{
    /// <summary>
    /// The History class holds all of the snapshots of content. It is also known as the Caretaker.
    /// </summary>
    public class History
    {
        /// <summary>
        /// The list of EditorStates that hold the content snapshots.
        /// </summary>
        private List<EditorState> editorStates = new List<EditorState>();

        /// <summary>
        /// Adds a new EditorState to the list of EditorStates.
        /// </summary>
        /// <param name="editorState">The EditorState to add.</param>
        public void Push(EditorState editorState) 
        { 
            editorStates.Add(editorState);
        }

        /// <summary>
        /// Removes the last EditorState, then returns the new last EditorState.
        /// </summary>
        /// <returns>The new last EditorState.</returns>
        public EditorState Pop()
        {
            editorStates.Remove(editorStates.Last());
            return editorStates.Last();
        }
    }
}
