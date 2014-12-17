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
  public class FilesResponse {
    public int success { get; set; }

    public Error error { get; set; }

    public List<File> results { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class FilesResponse {\n");
      sb.Append("  success: ").Append(success).Append("\n");
      sb.Append("  error: ").Append(error).Append("\n");
      sb.Append("  results: ").Append(results).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }

