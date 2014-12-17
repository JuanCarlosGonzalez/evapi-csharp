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
  public class Account {
    public int id { get; set; }

    public string username { get; set; }

    public int maxUsers { get; set; }

    public int userCount { get; set; }

    public Account masterAccount { get; set; }

    public int status { get; set; }

    public bool branding { get; set; }

    public bool customDomain { get; set; }

    public string planCode { get; set; }

    public string diskQuotaLimit { get; set; }

    public string bandwidthQuotaLimit { get; set; }

    public string diskQuotaUsed { get; set; }

    public string bandwidthQuotaUsed { get; set; }

    public string quotaNoticeEnabled { get; set; }

    public string quotaNoticeThreshold { get; set; }

    public string redirect { get; set; }

    public bool secureOnly { get; set; }

    public bool complexPasswords { get; set; }

    public bool showReferralLinks { get; set; }

    public string externalDomains { get; set; }

    public bool freeTrial { get; set; }

    public string appliedPromotion { get; set; }

    public string clientId { get; set; }

    public string created { get; set; }

    public string modified { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Account {\n");
      sb.Append("  id: ").Append(id).Append("\n");
      sb.Append("  username: ").Append(username).Append("\n");
      sb.Append("  maxUsers: ").Append(maxUsers).Append("\n");
      sb.Append("  userCount: ").Append(userCount).Append("\n");
      sb.Append("  masterAccount: ").Append(masterAccount).Append("\n");
      sb.Append("  status: ").Append(status).Append("\n");
      sb.Append("  branding: ").Append(branding).Append("\n");
      sb.Append("  customDomain: ").Append(customDomain).Append("\n");
      sb.Append("  planCode: ").Append(planCode).Append("\n");
      sb.Append("  diskQuotaLimit: ").Append(diskQuotaLimit).Append("\n");
      sb.Append("  bandwidthQuotaLimit: ").Append(bandwidthQuotaLimit).Append("\n");
      sb.Append("  diskQuotaUsed: ").Append(diskQuotaUsed).Append("\n");
      sb.Append("  bandwidthQuotaUsed: ").Append(bandwidthQuotaUsed).Append("\n");
      sb.Append("  quotaNoticeEnabled: ").Append(quotaNoticeEnabled).Append("\n");
      sb.Append("  quotaNoticeThreshold: ").Append(quotaNoticeThreshold).Append("\n");
      sb.Append("  redirect: ").Append(redirect).Append("\n");
      sb.Append("  secureOnly: ").Append(secureOnly).Append("\n");
      sb.Append("  complexPasswords: ").Append(complexPasswords).Append("\n");
      sb.Append("  showReferralLinks: ").Append(showReferralLinks).Append("\n");
      sb.Append("  externalDomains: ").Append(externalDomains).Append("\n");
      sb.Append("  freeTrial: ").Append(freeTrial).Append("\n");
      sb.Append("  appliedPromotion: ").Append(appliedPromotion).Append("\n");
      sb.Append("  clientId: ").Append(clientId).Append("\n");
      sb.Append("  created: ").Append(created).Append("\n");
      sb.Append("  modified: ").Append(modified).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }

