using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLearning.Core.Entities.json
{

    public class Match
    {
        public int optionLeft_id { get; set; }
        public int optionRight_id { get; set; }
    }

    public class QuestionAnswer
    {
        public List<Match > match { get; set; }
        public List<int> multipleOptions_id { get; set; }
        public int singleOption_id { get; set; }
        public string textAnswer { get; set; }
    }
    public class QuestionAnswerWrapper
    {
        public QuestionAnswer answer { get; set; }
        public int question_id { get; set; }
    }
}
