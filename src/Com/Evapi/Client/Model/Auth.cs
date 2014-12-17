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
  public class Auth {
    public string username { get; set; }

    public string accessToken { get; set; }

    public int mode { get; set; }

    public string clientIp { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Auth {\n");
      sb.Append("  username: ").Append(username).Append("\n");
      sb.Append("  accessToken: ").Append(accessToken).Append("\n");
      sb.Append("  mode: ").Append(mode).Append("\n");
      sb.Append("  clientIp: ").Append(clientIp).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }

