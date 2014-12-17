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
  public class User {
    public int gid { get; set; }

    public int status { get; set; }

    public string created { get; set; }

    public string modified { get; set; }

    public string accessTimestamp { get; set; }

    public int id { get; set; }

    public int owningAccountId { get; set; }

    public string username { get; set; }

    public string nickname { get; set; }

    public string email { get; set; }

    public string homeDir { get; set; }

    public bool download { get; set; }

    public bool upload { get; set; }

    public bool modify { get; set; }

    public bool delete { get; set; }

    public bool list { get; set; }

    public bool changePassword { get; set; }

    public bool share { get; set; }

    public bool notification { get; set; }

    public string role { get; set; }

    public string timeZone { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class User {\n");
      sb.Append("  gid: ").Append(gid).Append("\n");
      sb.Append("  status: ").Append(status).Append("\n");
      sb.Append("  created: ").Append(created).Append("\n");
      sb.Append("  modified: ").Append(modified).Append("\n");
      sb.Append("  accessTimestamp: ").Append(accessTimestamp).Append("\n");
      sb.Append("  id: ").Append(id).Append("\n");
      sb.Append("  owningAccountId: ").Append(owningAccountId).Append("\n");
      sb.Append("  username: ").Append(username).Append("\n");
      sb.Append("  nickname: ").Append(nickname).Append("\n");
      sb.Append("  email: ").Append(email).Append("\n");
      sb.Append("  homeDir: ").Append(homeDir).Append("\n");
      sb.Append("  download: ").Append(download).Append("\n");
      sb.Append("  upload: ").Append(upload).Append("\n");
      sb.Append("  modify: ").Append(modify).Append("\n");
      sb.Append("  delete: ").Append(delete).Append("\n");
      sb.Append("  list: ").Append(list).Append("\n");
      sb.Append("  changePassword: ").Append(changePassword).Append("\n");
      sb.Append("  share: ").Append(share).Append("\n");
      sb.Append("  notification: ").Append(notification).Append("\n");
      sb.Append("  role: ").Append(role).Append("\n");
      sb.Append("  timeZone: ").Append(timeZone).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }

