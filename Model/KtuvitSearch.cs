using System;
using System.Collections.Generic;

namespace Ktuvit.Plugin.Model
{
    public class KtuvitSearch
    {
        public string ID { get; set; }
        public string HebName { get; set; }
        public string EngName { get; set; }
        public string IMDB_Link { get; set; }
        public long ReleaseDate { get; set; }
        public Int32 FilmRunTimeMinutes { get; set; }
        public string Summary { get; set; }
        public string FolderID { get; set; }
        public string CreateDate { get; set; }
        public float rating { get; set; }
        public Int32 NumberOfVoters { get; set; }
        public Int32 NumOfSubs { get; set; }
        public string FilmImage { get; set; }
        public string UrlParam { get; set; }
        public string Actors { get; set; }
        public string Countries { get; set; }
        public string Directors { get; set; }
        public string Genres { get; set; }
        public string Lanuages { get; set; }
        public string Studios { get; set; }
        public bool IsSeries { get; set; }
        public string ImdbID { get; set; }
        public bool IsSuccess { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class KtuvitSeriesSearchRequest
    {
        public string SeriesName { get; set; }
        public int? SeasonIndex { get; set; }
        public int? EpisodeIndex { get; set; }
        public string ImdbId { get; set; }
        public int KtuvitSearchId { get; set; } = 1;
    }

    public class KtuvitMovieSearchRequest
    {
        public string MovieName { get; set; }
        public string ImdbId { get; set; }
        public int KtuvitSearchId { get; set; } = 0;
    }

    public class KtuvitSearchResponse
    {
        public string d { get; set; }
    }

    public class KtuvitSearchResult
    {
        public List<KtuvitSearch> Films { get; set; }

        public bool IsSuccess { get; set; }

        public string ErrorMessage { get; set; }
    }
}