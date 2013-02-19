using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blog.Data
{
    public class BlogDAL
    {
        public static Post CreatePost(string title, string postContent)
        {
            Post newPost = new Post();
            newPost.PostTitle = title;
            newPost.PostContent = postContent;
            newPost.PostDate = DateTime.Now;

            CSCB766BlogDBEntities blogDB = new CSCB766BlogDBEntities();
            blogDB.Posts.AddObject(newPost);
            blogDB.SaveChanges();

            return newPost;
        }

        public static Post FindPostById(int postId)
        {
            CSCB766BlogDBEntities blogDB = new CSCB766BlogDBEntities();
            Post requestedPost = blogDB.Posts.SingleOrDefault(p => p.PostID == postId);

            return requestedPost;
        }

        public static Post EditPost(int postId, string title, string postContent)
        {
            CSCB766BlogDBEntities blogDB = new CSCB766BlogDBEntities();
            Post editedPost = blogDB.Posts.SingleOrDefault(p => p.PostID == postId);

            editedPost.PostTitle = title;
            editedPost.PostContent = postContent;
            blogDB.SaveChanges();

            return editedPost;
        }

        public static void DeletePost(int postId)
        {
            CSCB766BlogDBEntities blogDB = new CSCB766BlogDBEntities();
            Post deletedPost = blogDB.Posts.SingleOrDefault(p => p.PostID == postId);

            blogDB.DeleteObject(deletedPost);
            blogDB.SaveChanges();

        }

        public static int PostCount() 
        {
            CSCB766BlogDBEntities blogDB = new CSCB766BlogDBEntities();
            var count = blogDB.Posts.Count(p => p.PostID >= 1);
            

            if (count != 0)
            {
                return count;
            }

            else
            {
                return 0;
            }
            
        }

        public static int CommentCount()
        {
            CSCB766BlogDBEntities blogDB = new CSCB766BlogDBEntities();
            var count = blogDB.Comments.Count(p => p.CommentID >= 1);


            if (count != 0)
            {
                return count;
            }

            else
            {
                return 0;
            }

        }

        public static Comment AddComment(int postId, string author, string text)
        {
            CSCB766BlogDBEntities blogDB = new CSCB766BlogDBEntities();
            Comment comment = new Comment();

            comment.PostID = postId;
            comment.Author = author;
            comment.CommentText = text;

            blogDB.Comments.AddObject(comment);
            blogDB.SaveChanges();

            return comment;
        }
    }
}
