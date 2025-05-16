using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace KnowledgeManagement
{
    public partial class KnowledgeDataSet
    {
        public partial class TagRow
        {
            public override string ToString()
            {
                return Text;
            }
        }

        public partial class ArticleRow
        {
            public override string ToString()
            {
                return Title;
            }
        }

        public partial class PictureRow
        {
            public override string ToString()
            {
                return Title;
            }
        }

        public partial class VideoRow
        {
            public override string ToString()
            {
                return Title;
            }
        }

        public partial class LinkRow
        {
            public override string ToString()
            {
                return Title;
            }
        }
    }
}
