using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JSONLL
{
    public partial class JsonHandler
    {
        public void AddAfter(Chain link, Chain index)
        { 

        }
        public void Addbefore(Chain link, Chain index)
        {

        }
        public void AddLast(Chain link)
        {

        }
        public void AddFirst(Chain link)
        {

        }
        public void Remove(Chain link)
        {

        }
        public void RemoveById(string id)
        {

        }
        public Chain SearchById(string id)
        {
            if (id == "" || id == null)
            {
                return null;
            }
            Chain item = null;
            foreach (Chain link in Links)
            {
                if (link.Id == id)
                {
                    item = link;
                }
            }
            return item;
        }
        public Chain SearchByValue(Chain node, string value, bool isInstantiated = true)
        {
            Chain item = null;
            if (isInstantiated && IsSorted == true)
            {
                if (node.Blob.Data == value)
                {
                    item = node;
                }
                else
                {
                    if (node.Blob.Data[0] > value[0])
                    {
                        SearchByValue(node.Left, value, isInstantiated);
                    }
                    else
                    {
                        SearchByValue(node.Right, value, isInstantiated);
                    }
                }
            }
            else
            {
                foreach (Chain link in Links)
                {
                    if (link.Blob.Data == value)
                    {
                        item = link;
                    }
                }
            }
            return item;
        }
        public Chain SearchByValue(Chain node, int value, bool isInstantiated = true)
        {
            Chain item = null;
            if (isInstantiated && IsSorted == true)
            {
                if (Int32.Parse(node.Blob.Data) == value)
                {
                    item = node;
                }
                else
                {
                    if (Int32.Parse(node.Blob.Data) > value)
                    {
                        SearchByValue(node.Left, value, isInstantiated);
                    }
                    else
                    {
                        SearchByValue(node.Right, value, isInstantiated);
                    }
                }
            }
            else
            {
                foreach (Chain link in Links)
                {
                    if (Int32.Parse(link.Blob.Data) == value)
                    {
                        item = link;
                    }
                }
            }
            return item;
        }
        private void instantiate()
        {
            Root = null;
            int index = 0;
            foreach (Chain link in Links)
            {
                link.Index = index;
                if (IsSorted == true)
                {
                    link.SortedIndex = index;
                }
                else
                {
                    link.SortedIndex = null;
                }
                index++;
                link.Previous = SearchById(link.PrevId);
                link.Next = SearchById(link.NextId);
            }
        }
        public static JsonHandler FromJson(string json)
        {
            JsonHandler jsonll = JsonConvert.DeserializeObject<JsonHandler>(json);
            jsonll.instantiate();
            return jsonll;
        }
        public static string ToJSON(JsonHandler data) => JsonConvert.SerializeObject(data, Formatting.Indented);

        // remove
        // sort
    }
}
