using Ktuvit.Plugin.Model;
using MediaBrowser.Controller.Providers;
using MediaBrowser.Controller.Subtitles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ktuvit.Plugin.Helpers
{
    public static class RequestParser
    {
        public static KtuvitSeriesSearchRequest GetSeriesSearchPhrase(SubtitleSearchRequest request)
        {
            return new KtuvitSeriesSearchRequest
            {
                SeriesName = request.SeriesName,
                SeasonIndex = request.ParentIndexNumber,
                EpisodeIndex = request.IndexNumber,
                ImdbId = request.ProviderIds["Imdb"]
            };
        }
        public static KtuvitMovieSearchRequest GetMovieSearchPhrase(SubtitleSearchRequest request)
        {
            return new KtuvitMovieSearchRequest
            {
                MovieName = request.Name,
                ImdbId = request.ProviderIds["Imdb"]
            };
        }
    }
}
