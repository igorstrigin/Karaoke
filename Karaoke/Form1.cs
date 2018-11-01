using System;
using System.Windows.Forms;
using NAudio.Wave;

namespace Karaoke
{
    public partial class Form1 : Form
    {
        private WaveIn SoundInput = null;
        private WaveOut SoundOutput = null;
        private BufferedWaveProvider waveProvider = null;


        public Form1()
        {
            InitializeComponent();
        }

        #region создание записи с микрофона и остановка записи
        private void btnStartRecord_Click(object sender, EventArgs e)
        {
            if (SoundInput != null)
                return;

            // create wave input from mic
            SoundInput = new WaveIn(this.Handle);
            SoundInput.BufferMilliseconds = 25;
            SoundInput.RecordingStopped += SoundInput_RecordingStopped;
            SoundInput.DataAvailable += SoundInput_DataAvailable;

            // create wave provider
            waveProvider = new BufferedWaveProvider(SoundInput.WaveFormat);

            // create wave output to speakers
            SoundOutput = new WaveOut();
            SoundOutput.DesiredLatency = 100;
            SoundOutput.Init(waveProvider);
            SoundOutput.PlaybackStopped += wavePlayer_PlaybackStopped;

            // start recording and playback
            SoundInput.StartRecording();
            SoundOutput.Play();
        }

        private void btnStopRecord_Click(object sender, EventArgs e)
        {
            if (SoundInput != null)
            {
                SoundInput.StopRecording();
            }
        }

        void SoundInput_DataAvailable(object sender, WaveInEventArgs e)
        {
            // add received data to waveProvider buffer
            if (waveProvider != null)
                waveProvider.AddSamples(e.Buffer, 0, e.BytesRecorded);
        }

        void SoundInput_RecordingStopped(object sender, StoppedEventArgs e)
        {
            // stop playback
            if (SoundOutput != null)
                SoundOutput.Stop();

            // dispose of wave input
            if (SoundInput != null)
            {
                SoundInput.Dispose();
                SoundInput = null;
            }

            // drop wave provider
            waveProvider = null;
        }

        void wavePlayer_PlaybackStopped(object sender, StoppedEventArgs e)
        {
            // stop recording
            if (SoundInput != null)
                SoundInput.StopRecording();

            // dispose of wave output
            if (SoundOutput != null)
            {
                SoundOutput.Dispose();
                SoundOutput = null;
            }
        }
        #endregion

        #region

        public void EnterYoutube(string ArtistAndSong)
        {
            webBrowser1.Navigate("Https://www.youtube.com/embed/" + tbArtistAndSong.Text);
           // webBrowser1.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(SearchString);

        }

        private void SearchString(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            foreach (HtmlElement i in webBrowser1.Document.GetElementsByTagName("input"))
            {
                if (i.GetAttribute("name") == "search_query")
                {
                    i.SetAttribute("value", tbArtistAndSong.Text);
                    foreach (HtmlElement y in webBrowser1.Document.GetElementsByTagName("button"))
                    {
                        if (y.GetAttribute("class") == "style-scope ytd-searchbox")
                        {
                            y.InvokeMember("click");
                            break;
                        }
                    }
                    break;
                }
            }
            webBrowser1.DocumentCompleted -= new WebBrowserDocumentCompletedEventHandler(SearchString);
        }


        #endregion

        private void btnFindSong_Click(object sender, EventArgs e)
        {
            EnterYoutube(tbArtistAndSong.Text);
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

            //webBrowser1.Document.GetElementById("search").SetAttribute("value", tbArtistAndSong.Text);
            //webBrowser1.Document.GetElementById("search-icon-legacy").InvokeMember("click");
            //foreach (HtmlElement i in webBrowser1.Document.GetElementsByTagName("form"))
            //{
            //    if(i.GetAttribute("id") == "search-form")
            //    {
            //        foreach (HtmlElement y in)
            //    }


            //}

            //webBrowser1.Document.GetElementById("search-icon-legacy").InvokeMember("click");
        }
    }
}
