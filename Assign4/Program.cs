/************************************************************
 *                                                          *
 *  CSCI 473/504           Assignment 4         Fall 2018   *                                             
 *                                                          *
 *  Programmers: Tyler Saballus/Josh Ruge                   *
 *                                                          *
 *  Date Due:   Nov-1                                       *                          
 *                                                          *
 *  Purpose:    Clone of paint program, has pencil line     *
 *              draw, brush and eraser as well as undo and  *
 *              redo tools as well as a file system         *
 ***********************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assign4
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PaintApp());
        }

    }
}
