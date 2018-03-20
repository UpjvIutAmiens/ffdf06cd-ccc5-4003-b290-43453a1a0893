using System.Collections.Generic;
using System.Linq;

namespace Commande
{
    public class Catalogue
    {
        private List<Article> _articles;

        public Catalogue()
        {
            this._articles = new List<Article>();
        }


        /// <summary>
        /// Les articles contenus dans le catalogue
        /// </summary>
        public List<Article> Articles => this._articles;


        /// <summary>
        /// Ajouter un article au catalogue
        /// </summary>
        /// <param name="article">L'article a ajouter</param>
        public void AddArticle(Article article)
        {
            this.Articles.Add(article);
        }

        /// <summary>
        /// Rechercher un article dans le cataglogue à partir de sa référence. En cas de doublon, le premier article est renvoyé.
        /// </summary>
        /// <param name="reference">Référence de l'article a rechercher</param>
        /// <returns>L'article trouvé ou null si la recherche a échouée.</returns>
        public Article GetArticleByRef(string reference)
        {
            // Utilisation du language LINQ pour rechercher un article.
            IEnumerable<Article> q = from article in this.Articles where article.Reference == reference select article;

            Article artFound = q.First();

            if (artFound == null)
            {
                return null;
            }

            return artFound;
        }
    }
}