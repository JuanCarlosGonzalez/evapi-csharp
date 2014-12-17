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
  public class Url {
    public string url { get; set; }

    public int offset { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Url {\n");
      sb.Append("  url: ").Append(url).Append("\n");
      sb.Append("  offset: ").Append(offset).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }

