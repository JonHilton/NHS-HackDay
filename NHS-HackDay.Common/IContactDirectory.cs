﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHS_HackDay.Common
{
  public interface IContactDirectory
  {
    Contact FindContact(string id);
    void UpdateContact(Contact contact);
  }
}
