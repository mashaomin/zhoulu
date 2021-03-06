﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Summer.Game
{

    public class ItemFactory : MonoBehaviour
    {
        public static ItemFactory Instance;


        public CandyItem candy_prf;
        public GridItem grid_pfb;

        private void Awake()
        {
            Instance = this;
        }

        public GridItem PopGridItem()
        {
            return Instantiate(grid_pfb);
        }

        public void PushGridItem(GridItem item)
        {

        }

        public CandyItem PopCandyItem()
        {
            return Instantiate(candy_prf);
        }

        public void PushCandyItem(GridItem item)
        {

        }
    }
}

