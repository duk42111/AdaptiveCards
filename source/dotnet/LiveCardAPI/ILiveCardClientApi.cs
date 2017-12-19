﻿using AdaptiveCards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveCardAPI
{
    public enum InsertPosition
    {
        Before, After, FirstChild, LastChild
    }

    public interface ILiveCardClientAPI
    {
        /// <summary>
        /// Insert new element
        /// </summary>
        /// <param name="id"></param>
        /// <param name="element"></param>
        /// <returns></returns>
        Task InsertElement(string id, InsertPosition position, AdaptiveElement element);

        /// <summary>
        /// Replace element
        /// </summary>
        /// <param name="id"></param>
        /// <param name="element"></param>
        /// <returns></returns>
        Task ReplaceElement(AdaptiveElement element);

        /// <summary>
        /// Remove element
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task RemoveElement(string id);

        /// <summary>
        /// SetProperties on element
        /// </summary>
        /// <param name="id"></param>
        /// <param name="properties"></param>
        /// <returns></returns>
        Task SetProperties(string id, IEnumerable<SetProperty> properties);

        /// <summary>
        /// Save the card
        /// </summary>
        /// <returns></returns>
        Task SaveCard(AdaptiveCard card = null);

        /// <summary>
        /// Close the card
        /// </summary>
        /// <returns></returns>
        Task CloseCard();
    }
}