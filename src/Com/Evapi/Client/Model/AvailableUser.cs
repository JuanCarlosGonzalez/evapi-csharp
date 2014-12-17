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
  public class AvailableUser {
    public bool available { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AvailableUser {\n");
      sb.Append("  available: ").Append(available).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }

