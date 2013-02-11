﻿using System;
using System.Collections.Generic;

namespace DbLayer.Common
{
    public interface IEntity
    {
        int Id { get; set; }
        Guid Uid { get; set; }
        DateTime DateCreated { get; set; }
        string CreatedBy { get; set; }

        bool IsNew();
        //void AddModificationHistory(ModificationHistory modificationHistory);
    }
}