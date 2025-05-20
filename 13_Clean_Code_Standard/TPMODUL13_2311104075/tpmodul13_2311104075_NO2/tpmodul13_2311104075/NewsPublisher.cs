// File: NewsPublisher.cs  
using System;
using System.Collections.Generic;

namespace ObserverPattern
{
    public class NewsPublisher
    {
        private List<IObserver> _subscribers = new List<IObserver>();
        private string _latestNews;

        public void Attach(IObserver subscriber) => _subscribers.Add(subscriber);
        public void Detach(IObserver subscriber) => _subscribers.Remove(subscriber);

        public void PublishNews(string news)
        {
            _latestNews = news;
            Notify();
        }

        private void Notify()
        {
            foreach (var subscriber in _subscribers)
                subscriber.Update(_latestNews);
        }
    }
}