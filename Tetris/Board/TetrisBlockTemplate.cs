﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

namespace Tetris.Board
{
    public class TetrisBlockTemplate
    {
        public static List<TetrisBlockTemplate> Templates { get; } = new List<TetrisBlockTemplate>()
        {
            new TetrisBlockTemplate()
            {
                Matrix = new int[][]
                {
                    new int[] {1, 1},
                    new int[] {1, 1}
                },
                BlockSkinID = "Block1"
            },
            new TetrisBlockTemplate()
            {
                Matrix = new int[][]
                {
                    new int[] {0, 1, 0},
                    new int[] {1, 1, 1},
                    new int[] {0, 0, 0},
                },
                BlockSkinID = "Block2"
            },
            new TetrisBlockTemplate()
            {
                Matrix = new int[][]
                {
                    new int[] {0, 1, 0},
                    new int[] {1, 1, 0},
                    new int[] {1, 0, 0},
                },
                BlockSkinID = "Block3"
            },
            new TetrisBlockTemplate()
            {
                Matrix = new int[][]
                {
                    new int[] {0, 1, 0},
                    new int[] {0, 1, 1},
                    new int[] {0, 0, 1},
                },
                BlockSkinID = "Block4"
            },
            new TetrisBlockTemplate()
            {
                Matrix = new int[][]
                {
                    new int[] {1, 1, 0},
                    new int[] {0, 1, 0},
                    new int[] {0, 1, 0},
                },
                BlockSkinID = "Block5"
            },
            new TetrisBlockTemplate()
            {
                Matrix = new int[][]
                {
                    new int[] {0, 1, 1},
                    new int[] {0, 1, 0},
                    new int[] {0, 1, 0},
                },
                BlockSkinID = "Block6"
            },
            new TetrisBlockTemplate()
            {
                Matrix = new int[][]
                {
                    new int[] {0, 0, 0, 0},
                    new int[] {1, 1, 1, 1},
                    new int[] {0, 0, 0, 0},
                    new int[] {0, 0, 0, 0}
                },
                BlockSkinID = "Block7"
            }
        };
        public static TetrisBlockTemplate GetRandomTemplate()
        {
            var index = Program.GetRandom(0, Templates.Count);
            return Templates[index];
        }

        public int[][] Matrix;
        public string BlockSkinID;
    }
}
