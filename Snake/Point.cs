﻿//-----------------------------------------------------------------------
// <copyright file="Point.cs" company="Anton Klyushin">
// Copyright (c) Anton Klyushin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Snake
{
    using System;
    
    /// <summary>
    /// Point class
    /// </summary>
    internal class Point
    {
        /// <summary>
        /// Координата х
        /// </summary>
        private int x;
        
        /// <summary>
        /// Координата y
        /// </summary>
        private int y;

        /// <summary>
        /// Символ точки
        /// </summary>
        private char symbol;

        /// <summary>
        /// Initializes a new instance of the <see cref="Point"/> class.
        /// </summary>
        internal Point()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Point"/> class.
        /// </summary>
        /// <param name="x">Координата точки по оси x</param>
        /// <param name="y">Координата точки по оси y</param>
        /// <param name="symbol">Символ точки</param>
        internal Point(int x, int y, char symbol)
        {
            this.x = x;
            this.y = y;
            this.symbol = symbol;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Point"/> class.
        /// </summary>
        /// <param name="p">Экземпляр класса Point</param>
        internal Point(Point p)
        {
            this.x = p.GetX;
            this.y = p.GetY;
            this.symbol = p.GetSymbol;
        }

        /// <summary>
        /// Gets координаты х
        /// </summary>
        internal int GetX => this.x;

        /// <summary>
        /// Sets координаты х
        /// </summary>
        internal int SetX
        {
            set => this.x = value;
        }

        /// <summary>
        /// Gets координаты y
        /// </summary>
        internal int GetY => this.y;

        /// <summary>
        /// Sets координаты y
        /// </summary>
        internal int SetY
        {
            set => this.y = value;
        }

        /// <summary>
        /// Gets символа точки
        /// </summary>
        internal char GetSymbol => this.symbol;

        /// <summary>
        /// Sets символа точки
        /// </summary>
        internal char SetSymbol
        {
            set => this.symbol = value;
        }

        /// <summary>
        /// Override method ToString() for Point class
        /// </summary>
        /// <returns>The coordinates of the point and point symbol</returns>
        public override string ToString()
        {
            return this.x + ", " + this.y + ", " + this.symbol;
        }

        /// <summary>
        /// Check point match method
        /// </summary>
        /// <param name="p">Other point</param>
        /// <returns>True or False</returns>
        internal bool IsHit(Point p)
        {
            return p.x == this.x && p.y == this.y;
        }

        /// <summary>
        /// Clear point method
        /// </summary>
        internal void Clear()
        {
            this.symbol = ' ';
            this.Draw();
        }

        /// <summary>
        /// Draw point method
        /// </summary>
        internal void Draw()
        {
            Console.SetCursorPosition(this.x, this.y);
            Console.Write(this.symbol);
        }

        /// <summary>
        /// Move method for Point class
        /// </summary>
        /// <param name="offset">Offset of point</param>
        /// <param name="direction">Direction of the offset point </param>
        internal void Move(int offset, Direction direction)
        {
            switch (Convert.ToInt32(direction))
            {
                case 0:
                    this.x = this.x - offset;
                    break;
                case 1:
                    this.x = this.x + offset;
                    break;
                case 2:
                    this.y = this.y - offset;
                    break;
                case 3:
                    this.y = this.y + offset;
                    break;
                default:
                    break;
            }
        }
    }
}
