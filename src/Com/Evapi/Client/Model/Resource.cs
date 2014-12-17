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
  public class Resource {
    public int totalFiles { get; set; }

    public List<ResourceProperty> resources { get; set; }

    public string inheritedShares { get; set; }

    public string inheritedNotifications { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Resource {\n");
      sb.Append("  totalFiles: ").Append(totalFiles).Append("\n");
      sb.Append("  resources: ").Append(resources).Append("\n");
      sb.Append("  inheritedShares: ").Append(inheritedShares).Append("\n");
      sb.Append("  inheritedNotifications: ").Append(inheritedNotifications).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }

