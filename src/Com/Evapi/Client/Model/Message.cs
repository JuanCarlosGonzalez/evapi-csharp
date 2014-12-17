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
  public class Message {
    public string id { get; set; }

    public string userId { get; set; }

    public string shareId { get; set; }

    public string subject { get; set; }

    public string body { get; set; }

    public string created { get; set; }

    public string modified { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Message {\n");
      sb.Append("  id: ").Append(id).Append("\n");
      sb.Append("  userId: ").Append(userId).Append("\n");
      sb.Append("  shareId: ").Append(shareId).Append("\n");
      sb.Append("  subject: ").Append(subject).Append("\n");
      sb.Append("  body: ").Append(body).Append("\n");
      sb.Append("  created: ").Append(created).Append("\n");
      sb.Append("  modified: ").Append(modified).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }

