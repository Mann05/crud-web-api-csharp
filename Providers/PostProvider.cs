using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Project1.Models;
using System.Data.SqlClient;

namespace Project1.Providers
{
    public class PostProvider : BaseProvider
    {

        public ResultSet createPost(PostModels PM)
        {
            try
            {
                var postTitle = new SqlParameter("@postTitle",PM.PostTitle);
                var postDescription = new SqlParameter("@postDescription",PM.PostDescription);
                return Context.Database.SqlQuery<ResultSet>(@"EXEC sp_create_post postTitle=@postTitle,postDescription=@postDescription",postTitle,postDescription).FirstOrDefault();
            }
            catch (Exception ex)
            {
                return new ResultSet() { code = 0, message = ex.Message };
            }
        }

        public ResultSet deletePost(PostModels PM)
        {
            try
            {
                var postId = new SqlParameter("@postId", PM.PostId);
                return Context.Database.SqlQuery<ResultSet>(@"EXEC sp_delete_post postId=@postId",postId).FirstOrDefault();
            }
            catch (Exception ex)
            {
                return new ResultSet() { code = 0, message = ex.Message };
            }
        }

        public ResultSet updatePost(PostModels PM)
        {
            try
            {
                var postId = new SqlParameter("@postId", PM.PostId);
                var postTitle = new SqlParameter("@postTitle", PM.PostTitle);
                var postDescription = new SqlParameter("@postDescription", PM.PostDescription);
                return Context.Database.SqlQuery<ResultSet>(@"EXEC sp_delete_post postId=@postId,postTitle=@postTitle,postDescription=@postDescription", postId,postTitle,postDescription).FirstOrDefault();
            }
            catch (Exception ex)
            {
                return new ResultSet() { code = 0, message = ex.Message };
            }
        }

    }
}