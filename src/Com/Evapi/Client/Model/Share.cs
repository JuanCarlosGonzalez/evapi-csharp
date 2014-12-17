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
  public class Share {
    public int id { get; set; }

    public string name { get; set; }

    public bool hasPassword { get; set; }

    public bool isPublic { get; set; }

    public string accessMode { get; set; }

    public string accessDescription { get; set; }

    public bool embed { get; set; }

    public string hash { get; set; }

    public string ownerHash { get; set; }

    public string expiration { get; set; }

    public string trackingStatus { get; set; }

    public string expired { get; set; }

    public bool resent { get; set; }

    public int owner { get; set; }

    public string ownerUsername { get; set; }

    public string type { get; set; }

    public bool requireEmail { get; set; }

    public bool fileDropCreateFolders { get; set; }

    public List<string> paths { get; set; }

    public List<Recipient> recipients { get; set; }

    public List<Recipient> recipientsWithOwner { get; set; }

    public List<Message> messages { get; set; }

    public bool inherited { get; set; }

    public int status { get; set; }

    public bool hasNotification { get; set; }

    public string notification { get; set; }

    public string created { get; set; }

    public string modified { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Share {\n");
      sb.Append("  id: ").Append(id).Append("\n");
      sb.Append("  name: ").Append(name).Append("\n");
      sb.Append("  hasPassword: ").Append(hasPassword).Append("\n");
      sb.Append("  isPublic: ").Append(isPublic).Append("\n");
      sb.Append("  accessMode: ").Append(accessMode).Append("\n");
      sb.Append("  accessDescription: ").Append(accessDescription).Append("\n");
      sb.Append("  embed: ").Append(embed).Append("\n");
      sb.Append("  hash: ").Append(hash).Append("\n");
      sb.Append("  ownerHash: ").Append(ownerHash).Append("\n");
      sb.Append("  expiration: ").Append(expiration).Append("\n");
      sb.Append("  trackingStatus: ").Append(trackingStatus).Append("\n");
      sb.Append("  expired: ").Append(expired).Append("\n");
      sb.Append("  resent: ").Append(resent).Append("\n");
      sb.Append("  owner: ").Append(owner).Append("\n");
      sb.Append("  ownerUsername: ").Append(ownerUsername).Append("\n");
      sb.Append("  type: ").Append(type).Append("\n");
      sb.Append("  requireEmail: ").Append(requireEmail).Append("\n");
      sb.Append("  fileDropCreateFolders: ").Append(fileDropCreateFolders).Append("\n");
      sb.Append("  paths: ").Append(paths).Append("\n");
      sb.Append("  recipients: ").Append(recipients).Append("\n");
      sb.Append("  recipientsWithOwner: ").Append(recipientsWithOwner).Append("\n");
      sb.Append("  messages: ").Append(messages).Append("\n");
      sb.Append("  inherited: ").Append(inherited).Append("\n");
      sb.Append("  status: ").Append(status).Append("\n");
      sb.Append("  hasNotification: ").Append(hasNotification).Append("\n");
      sb.Append("  notification: ").Append(notification).Append("\n");
      sb.Append("  created: ").Append(created).Append("\n");
      sb.Append("  modified: ").Append(modified).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }

