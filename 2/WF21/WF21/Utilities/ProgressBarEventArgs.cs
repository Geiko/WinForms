namespace geiko.WF21.Utilities
{
    /// <summary>
    /// It determines arguments for event of reading progress.
    /// </summary>
    public class ProgressBarEventArgs : System.EventArgs
    {
        // It is percent of progress.
        public int Stage { get; set; }
    }

}
