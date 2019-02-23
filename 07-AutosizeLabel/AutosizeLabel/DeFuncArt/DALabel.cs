﻿using System;
using Xamarin.Forms;

namespace DeFuncArt
{
    /// <summary>
    /// An extension of Xamarin.Forms.Label which adds the ability to autosize the font (between option min and max values).
    /// </summary>
    public class DALabel : Label
    {
        /// <summary>The minimum font size allowed.</summary>
        private const double MIN_FONT_SIZE = 6;

        /// <summary>
        /// The minimum font size property.
        /// </summary>
        public static readonly BindableProperty MinFontSizeProperty = BindableProperty.CreateAttached("MinFontSize", typeof(double), typeof(DALabel), MIN_FONT_SIZE, validateValue: (bindable, value) => (double)value >= MIN_FONT_SIZE);

        /// <summary>
        /// Gets the specified minimum font size.
        /// </summary>
        public static double GetMinFontSize(BindableObject bindable)
        {
            return (double)bindable.GetValue(MinFontSizeProperty);
        }

        /// <summary>The maximum font size allowed.</summary>
        private const double MAX_FONT_SIZE = 500;

        /// <summary>
        /// The maximum font size property.
        /// </summary>
        public static readonly BindableProperty MaxFontSizeProperty = BindableProperty.CreateAttached("MaxFontSize", typeof(double), typeof(DALabel), MAX_FONT_SIZE, validateValue: (bindable, value) => (double)value <= MAX_FONT_SIZE);

        /// <summary>
        /// Gets the specified maximum font size.
        /// </summary>
        public static double GetMaxFontSize(BindableObject bindable)
        {
            return (double)bindable.GetValue(MaxFontSizeProperty);
        }

        //TODO MaxFontSizeProperty, MinFontSizeProperty don't assure against MinFontSize > MaxFontSize

        /// <summary>
        /// The label's text.
        /// </summary>
        new public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); AutoFontSize(); }
        }

        /// <summary>
        /// Callback when the size of the element is set during a layout cycle.
        /// </summary>
        protected override void OnSizeAllocated(double width, double height)
        {
            //call base implementation
            base.OnSizeAllocated(width, height);

            //update font size
            AutoFontSize();
        }

        /// <summary>
        /// Autosizes the label's font size with regards to it's container size.
        /// </summary>
        private void AutoFontSize()
        {
            //determine the text height for the min font size
            double lowerFontSize = (double)GetValue(MinFontSizeProperty);
            double lowerTextHeight = TextHeightForFontSize(lowerFontSize);

            //determine the text height for the max font size
            double upperFontSize = (double)GetValue(MaxFontSizeProperty);
            double upperTextHeight = TextHeightForFontSize(upperFontSize);

            //start a loop which'll find the optimal font size
            while(upperFontSize - lowerFontSize > 1)
            {
                //determine current average font size and calculate corresponding text height
                double fontSize = (lowerFontSize + upperFontSize) / 2;
                double textHeight = TextHeightForFontSize(upperFontSize);

                //if the calculated height is out of bounds, update max values, else update min values
                if(textHeight > Height)
                {
                    upperFontSize = fontSize; upperTextHeight = textHeight;
                }
                else
                {
                    lowerFontSize = fontSize; lowerTextHeight = textHeight;
                }
            }

            //finally set the correct font size
            FontSize = lowerFontSize;
        }

        /// <summary>
        /// Determines the text height for the label with a given font size.
        /// </summary>
        private double TextHeightForFontSize(double fontSize)
        {
            FontSize = fontSize;
            return OnMeasure(Width, Double.PositiveInfinity).Request.Height;
        }
    }
}
