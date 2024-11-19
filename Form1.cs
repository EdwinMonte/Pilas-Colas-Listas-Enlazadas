namespace Pilas_Colas_Listas_Enlazadas
{
    public partial class Form1 : Form
    {
        private Stack<int> stack = new Stack<int>();
        private Queue<int> queue = new Queue<int>();
        private LinkedList<int> linkedList = new LinkedList<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtInput.Text, out int value))
            {
                stack.Push(value);
                UpdateDisplay("Stack");
            }
            else
            {
                MessageBox.Show("Enter a valid integer.");
            }
        }

        private void btnPop_Click(object sender, EventArgs e)
        {
            if (stack.Count > 0)
            {
                stack.Pop();
                UpdateDisplay("Stack");
            }
            else
            {
                MessageBox.Show("Stack is empty.");
            }
        }

        private void btnEnqueue_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtInput.Text, out int value))
            {
                queue.Enqueue(value);
                UpdateDisplay("Queue");
            }
            else
            {
                MessageBox.Show("Enter a valid integer.");
            }
        }

        private void btnDequeue_Click(object sender, EventArgs e)
        {
            if (queue.Count > 0)
            {
                queue.Dequeue();
                UpdateDisplay("Queue");
            }
            else
            {
                MessageBox.Show("Queue is empty.");
            }
        }

        private void btnAddFirst_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtInput.Text, out int value))
            {
                linkedList.AddFirst(value);
                UpdateDisplay("LinkedList");
            }
            else
            {
                MessageBox.Show("Enter a valid integer.");
            }
        }

        private void btnAddLast_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtInput.Text, out int value))
            {
                linkedList.AddLast(value);
                UpdateDisplay("LinkedList");
            }
            else
            {
                MessageBox.Show("Enter a valid integer.");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtInput.Text, out int value))
            {
                if (linkedList.Remove(value))
                {
                    UpdateDisplay("LinkedList");
                }
                else
                {
                    MessageBox.Show("Value not found in the list.");
                }
            }
            else
            {
                MessageBox.Show("Enter a valid integer.");
            }
        }

        private void UpdateDisplay(string structure)
        {
            lstDisplay.Items.Clear();
            if (structure == "Stack")
            {
                foreach (var item in stack)
                {
                    lstDisplay.Items.Add(item);
                }
            }
            else if (structure == "Queue")
            {
                foreach (var item in queue)
                {
                    lstDisplay.Items.Add(item);
                }
            }
            else if (structure == "LinkedList")
            {
                foreach (var item in linkedList)
                {
                    lstDisplay.Items.Add(item);
                }
            }
        }
    }
}
    

