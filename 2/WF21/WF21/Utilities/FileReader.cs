using geiko.WF21.Utilities;
using System;
using System.IO;

namespace geiko.WF21
{
    /// <summary>
    /// This is delegate for progress event.
    /// </summary>
    /// <param name="sender">Object that generates this event.</param>
    /// <param name="e">Arguments.</param>
    public delegate void ProgressBarHandler(object sender, ProgressBarEventArgs e);
    /// <summary>
    /// This is delegate for end of reading.
    /// </summary>
    /// <param name="sender">Object that generates this event.</param>
    /// <param name="e">Arguments.</param>
    public delegate void SuccessHandler(object sender, EventArgs e);


    /// <summary>
    /// It is file reader.
    /// </summary>
    class FileReader
    {
        /// <summary>
        /// It is event for reading progress.
        /// </summary>
        public event ProgressBarHandler ReportProgress;
        /// <summary>
        /// It is event for end of reading.
        /// </summary>
        public event SuccessHandler ReportSuccess;

        /// <summary>
        /// It reads file and throw exception if file is not found or can't be read.
        /// </summary>
        /// <param name="path">Path to the tested file.</param>
        public void Read(string path)
        {
            if (File.Exists(path))
            {
                using (FileStream cat = File.OpenRead(path))
                {
                    int stage = 1;
                    while (cat.ReadByte() >= 0)
                    {
                        if (cat.Position >= cat.Length / 100 * stage)
                        {
                            StageCompleted(stage);
                            stage++;
                        }
                    }
                }
                ReportSuccess(this, null);
            }
            else
                throw new FileNotFoundException("File is not found. Check your path or file.");
        }

        /// <summary>
        /// If progress is 1% it launches progress event.
        /// </summary>
        /// <param name="stage"></param>
        private void StageCompleted(int stage)
        {
            ProgressBarEventArgs args = new ProgressBarEventArgs();
            args.Stage = stage;
            ReportProgress(this, args);
        }
        
    }
}
