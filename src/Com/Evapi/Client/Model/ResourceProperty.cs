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
  public class ResourceProperty {
    public int fileCount { get; set; }

    public string file { get; set; }

    public string name { get; set; }

    public string createdBy { get; set; }

    public string uploadDate { get; set; }

    public string parent { get; set; }

    public string path { get; set; }

    public List<Share> shares { get; set; }

    public string notificationSettings { get; set; }

    public int size { get; set; }

    public bool previewable { get; set; }

    public string type { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ResourceProperty {\n");
      sb.Append("  fileCount: ").Append(fileCount).Append("\n");
      sb.Append("  file: ").Append(file).Append("\n");
      sb.Append("  name: ").Append(name).Append("\n");
      sb.Append("  createdBy: ").Append(createdBy).Append("\n");
      sb.Append("  uploadDate: ").Append(uploadDate).Append("\n");
      sb.Append("  parent: ").Append(parent).Append("\n");
      sb.Append("  path: ").Append(path).Append("\n");
      sb.Append("  shares: ").Append(shares).Append("\n");
      sb.Append("  notificationSettings: ").Append(notificationSettings).Append("\n");
      sb.Append("  size: ").Append(size).Append("\n");
      sb.Append("  previewable: ").Append(previewable).Append("\n");
      sb.Append("  type: ").Append(type).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }

