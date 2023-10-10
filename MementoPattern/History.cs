using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    public class History
    {
        private List<EditorState> editorStates = new List<EditorState>();

        public void Push(EditorState editorState) 
        { 
            editorStates.Add(editorState);
        }

        public EditorState Pop()
        {
            editorStates.Remove(editorStates.Last());
            return editorStates.Last();
        }
    }
}
