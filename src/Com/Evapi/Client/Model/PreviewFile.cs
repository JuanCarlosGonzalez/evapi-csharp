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
  public class PreviewFile {
    public string image { get; set; }

    public int size { get; set; }

    public string imageId { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PreviewFile {\n");
      sb.Append("  image: ").Append(image).Append("\n");
      sb.Append("  size: ").Append(size).Append("\n");
      sb.Append("  imageId: ").Append(imageId).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }

