﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Common.DataModels.DtoModels
{
    public class ClassEventDto
    {
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public override string ToString()
        {
            return $"{StartDate.ToShortDateString()} : {Description} \n Start: {StartDate.TimeOfDay} | End: {EndDate.TimeOfDay}";
        }
    }
}
