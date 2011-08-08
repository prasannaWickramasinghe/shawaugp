using System;
using System.Collections;
using System.Collections.Generic;

namespace nothinbutdotnetprep.collections
{
    public class MovieLibrary
    {
        IList<Movie> movies;

        public MovieLibrary(IList<Movie> list_of_movies)
        {
            this.movies = list_of_movies;
        }

        public IEnumerable<Movie> all_movies()
        {
            //return this.movies;
            foreach (var movie in movies)
            {
                yield return movie;
            }
        }

        public void add(Movie movie)
        {
            //throw new NotImplementedException();
            if(movies.Contains(movie))
                return;
        }

        public IEnumerable<Movie> sort_all_movies_by_title_descending()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> all_movies_published_by_pixar()
        {
            var tmpList = new List<Movie>();

            foreach (Movie movie in movies)
            {
                if (movie.production_studio == ProductionStudio.Pixar)
                    tmpList.Add(movie);
            }
            return tmpList;
        }

        public IEnumerable<Movie> all_movies_published_by_pixar_or_disney()
        {
            var tmpList = new List<Movie>();

            foreach (Movie movie in movies)
            {
                if ((movie.production_studio == ProductionStudio.Pixar) ||(movie.production_studio == ProductionStudio.Disney))
                    tmpList.Add(movie);
            }
            return tmpList;
        }

        public IEnumerable<Movie> sort_all_movies_by_title_ascending()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> sort_all_movies_by_movie_studio_and_year_published()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> all_movies_not_published_by_pixar()
        {
            //throw new NotImplementedException();
            var tmpList = new List<Movie>();

            foreach (Movie movie in movies)
            {
                if (movie.production_studio != ProductionStudio.Pixar)
                    tmpList.Add(movie);
            }
            return tmpList;
        }

        public IEnumerable<Movie> all_movies_published_after(int year)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> all_movies_published_between_years(int startingYear, int endingYear)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> all_kid_movies()
        {
            var tmpList = new List<Movie>();

            foreach (Movie movie in movies)
            {
                if (movie.genre == Genre.kids)
                    tmpList.Add(movie);
            }
            return tmpList;
        }

        public IEnumerable<Movie> all_action_movies()
        {
            var tmpList = new List<Movie>();

            foreach (Movie movie in movies)
            {
                if (movie.genre == Genre.action)
                    tmpList.Add(movie);
            }
            return tmpList;
        }

        public IEnumerable<Movie> sort_all_movies_by_date_published_descending()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> sort_all_movies_by_date_published_ascending()
        {
            throw new NotImplementedException();
        }
    }
}