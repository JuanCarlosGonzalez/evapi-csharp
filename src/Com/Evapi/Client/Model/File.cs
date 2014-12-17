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
  public class File {
    public string file { get; set; }

    public string size { get; set; }

    public int success { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class File {\n");
      sb.Append("  file: ").Append(file).Append("\n");
      sb.Append("  size: ").Append(size).Append("\n");
      sb.Append("  success: ").Append(success).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }

