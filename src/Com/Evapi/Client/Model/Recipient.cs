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
  public class Recipient {
    public string id { get; set; }

    public string shareId { get; set; }

    public string type { get; set; }

    public string hash { get; set; }

    public string email { get; set; }

    public bool sent { get; set; }

    public bool received { get; set; }

    public string created { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Recipient {\n");
      sb.Append("  id: ").Append(id).Append("\n");
      sb.Append("  shareId: ").Append(shareId).Append("\n");
      sb.Append("  type: ").Append(type).Append("\n");
      sb.Append("  hash: ").Append(hash).Append("\n");
      sb.Append("  email: ").Append(email).Append("\n");
      sb.Append("  sent: ").Append(sent).Append("\n");
      sb.Append("  received: ").Append(received).Append("\n");
      sb.Append("  created: ").Append(created).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }

