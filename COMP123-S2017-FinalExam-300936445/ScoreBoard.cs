using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*Name: Sylvere Ekponon
 * Student ID: 300936445
 * Date: August 17, 2017
 * Description: Pick Highest Card
 * version: 0.2 - Added a constructor to the ScoreBoard class 
 */
namespace COMP123_S2017_FinalExam_300936445
{


    public class ScoreBoard
    {

        //PRIVATE VARIABLE INSTANCES
        private TextBox _finalScoreTextBox;
        private int _score;
        private TextBox _scoreTextBox;
        private int _time;
        private TextBox _timeTextBox;


        //public properties

        public TextBox FinalScoreTextBox
        {
            get
            {
                return this._finalScoreTextBox;
            }

            set
            {
                this._finalScoreTextBox.Text = this._score.ToString();
            }
            
        }
        public int Score
        {
            get
            {
                return this._score;
            }
            set
            {
                this._score = value;
            }
        }
        public TextBox ScoreTextBox
        {
            get
            {
                return this._scoreTextBox;
            }

            set
            {
                this._scoreTextBox.Text = Convert.ToString(this._score);
            }
        }

        public int Time
        {
            get
            {
                return this._time;
            }
            set
            {
                this._time = value;
            }
        }

        public TextBox TimeTexBox
        {
            get
            {
                return this._timeTextBox;
            }
            set
            {
                this._timeTextBox.Text = Convert.ToString(this._time);
            }
        }

        //CONSTRUCTORS
        public ScoreBoard(TextBox scoreTextBox, TextBox timeTexBox, TextBox finalScoreTextBox)
        {
            this.ScoreTextBox = scoreTextBox;
            this.TimeTexBox = timeTexBox;
            this.FinalScoreTextBox = finalScoreTextBox;
        }

        /// <summary>
        /// This method convert the current value of the TimeTextBox.Text property to an integer
        /// </summary>
        public void UpdateTime()
        {
            this.Time = Convert.ToInt32(TimeTexBox.Text) - 1;
            TimeTexBox.Text = Time.ToString();

        }
    }
}
