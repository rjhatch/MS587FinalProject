using MS587FinalProject.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MS587FinalProject.Helpers.Comments
{
    public class SortComments
    {
        private List<Comment> allComments;
        private List<Comment> sortedComments;

        public SortComments(List<Comment> comments)
        {
            allComments = comments;
        }

        public List<Comment> Sort()
        {
            sortedComments = new List<Comment>();

            foreach (var comment in allComments)
            {
                if (!sortedComments.Contains(comment) && comment.ParentCommentId == 0)
                {
                    sortedComments.Add(comment);
                    sortedComments.AddRange(FindCommentsWithParentId(comment));
                }
            }


            return sortedComments;
        }

        public List<Comment> FindCommentsWithParentIdIncludeParentComment(Comment parentComment)
        {
            Sort();
            List<Comment> addedComments = new List<Comment>();

            addedComments.Add(parentComment);
            addedComments.AddRange(FindCommentsWithParentId(parentComment));

            return addedComments;
        }

        private List<Comment> FindCommentsWithParentId(Comment parentComment)
        {
            List<Comment> addedComments = new List<Comment>();

            foreach (var comment in allComments)
            {
                if (!sortedComments.Contains(comment) && comment.ParentCommentId == parentComment.CommentId)
                {
                    sortedComments.Add(comment);
                    sortedComments.AddRange(FindCommentsWithParentId(comment));
                }
            }

            return addedComments;
        }
    }
}
