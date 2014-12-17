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
  public class Error {
    public string message { get; set; }

    public int code { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Error {\n");
      sb.Append("  message: ").Append(message).Append("\n");
      sb.Append("  code: ").Append(code).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }

