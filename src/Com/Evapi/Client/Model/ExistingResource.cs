/**
 * Copyright 2014 ExaVault, Inc.
 *
 * NOTE: This file was generated automatically. Do not modify by hand.
 */

using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Com.Evapi.Client.Model {
  public class ExistingResource {
    public bool exists { get; set; }

    public Resource resource { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ExistingResource {\n");
      sb.Append("  exists: ").Append(exists).Append("\n");
      sb.Append("  resource: ").Append(resource).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }

