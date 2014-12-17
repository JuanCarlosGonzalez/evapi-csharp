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
  public class LogEntry {
    public string fileName { get; set; }

    public string fileSource { get; set; }

    public string operation { get; set; }

    public string duration { get; set; }

    public string bytesTransferred { get; set; }

    public string id { get; set; }

    public string created { get; set; }

    public string username { get; set; }

    public string sessionId { get; set; }

    public string ipAddress { get; set; }

    public string protocol { get; set; }

    public string status { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class LogEntry {\n");
      sb.Append("  fileName: ").Append(fileName).Append("\n");
      sb.Append("  fileSource: ").Append(fileSource).Append("\n");
      sb.Append("  operation: ").Append(operation).Append("\n");
      sb.Append("  duration: ").Append(duration).Append("\n");
      sb.Append("  bytesTransferred: ").Append(bytesTransferred).Append("\n");
      sb.Append("  id: ").Append(id).Append("\n");
      sb.Append("  created: ").Append(created).Append("\n");
      sb.Append("  username: ").Append(username).Append("\n");
      sb.Append("  sessionId: ").Append(sessionId).Append("\n");
      sb.Append("  ipAddress: ").Append(ipAddress).Append("\n");
      sb.Append("  protocol: ").Append(protocol).Append("\n");
      sb.Append("  status: ").Append(status).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }

