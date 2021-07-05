using Microsoft.AspNet.Identity;
using Newtonsoft.Json;
using System;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Web.Mvc;
using System.Web.Security;
using Twitter.Models;
using System.Web.UI.WebControls;
using System.Threading.Tasks;
using System.Web.Helpers;

namespace Twitter.Controllers
{
    public class AccountController : Controller
    {
        TwitterContext db = new TwitterContext();
        private string keyForHmac = "281269751949953238506636101247451493";
        public ActionResult Index()
        {
            var posts = db.Posts.OrderByDescending(p => p.CreatedAt).Include(p => p.User);
            return View(posts.ToList());
        }
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            { 
                User user = null;
                user = db.Users.FirstOrDefault(u => u.Name == model.Name);
                if (user == null)
                {
                    db.Users.Add(new User { Name = model.Name, Password = GetHash(model.Password, keyForHmac)});
                    db.SaveChanges();
                    string passworhash = GetHash(model.Password, keyForHmac);
                    user = db.Users.Where(u => u.Name == model.Name && u.Password == passworhash).FirstOrDefault();
                    if (user != null)
                    {
                        FormsAuthentication.SetAuthCookie(model.Name, true);
                        return RedirectToAction("Index", "Account");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Пользователь с таким логином уже существует");
                }
            }

            return View(model);
        }
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                User user = null;
                string passworhash = GetHash(model.Password, keyForHmac);
                user = db.Users.FirstOrDefault(u => u.Name == model.Name && u.Password == passworhash);
                if (user != null)
                {
                    FormsAuthentication.SetAuthCookie(model.Name, true);
                    return RedirectToAction("Index", "Account");
                }
                else
                {
                    ModelState.AddModelError("", "Пользователя с таким логином и паролем нет");
                }
            }

            return View(model);
        }
        public ActionResult Logoff()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Account");
        }
        public static String GetHash(String text, String key)
        {
            ASCIIEncoding encoding = new ASCIIEncoding();
            Byte[] textBytes = encoding.GetBytes(text);
            Byte[] keyBytes = encoding.GetBytes(key);
            Byte[] hashBytes;
            using (HMACSHA256 hash = new HMACSHA256(keyBytes))
                hashBytes = hash.ComputeHash(textBytes);
            return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
        }

        public ActionResult EditPost(int Id)
        {
            return View(db.Posts.Find(Id));
        }

        [HttpPost]
        public ActionResult EditPost(EditPostModel model)
        {   
            Post post = db.Posts.Find(model.Id);
            post.PhotoLink = model.PhotoLink;
            post.Tags = model.Tags;
            post.Description = model.Description;
            db.Entry(post).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult AddPost()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddPost(AddPostModel model)
        {
            if (ModelState.IsValid)
            {
                string UserName = User.Identity.Name;
                User user = db.Users.FirstOrDefault(u => u.Name == UserName);
                int UserId_ = user.Id;
                db.Posts.Add(new Post { UserId = UserId_, Description = model.Description, CreatedAt = DateTime.Now, PhotoLink = model.PhotoLink, Tags = model.Tags});
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public ActionResult Delete(int Id)
        {
            db.Posts.Remove(db.Posts.Find(Id));
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Contact(Contact contact)
        {
            string useremail = "twitter.asp.net@gmail.com";
            string subject = contact.Subject;
            string body = "\"" + contact.Message + "\""+ "\n\n" + "User " + contact.Name + 
                " send you this message. Please, answer him\\her as soon as possible by e-mail: "
                + contact.Email+ "." + "\n\n" + "Thank you.";

            WebMail.Send(useremail, subject, body, null, null, null, true, null, null, null, null, null, null);
            ViewBag.msg = "Email sent successfully!";
            return View();
        }
      
    }
}