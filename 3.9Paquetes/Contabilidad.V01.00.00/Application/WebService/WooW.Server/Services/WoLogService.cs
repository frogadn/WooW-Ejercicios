using System.Data;
using System.Net;
using System.Reflection;
using FastMember;
using GemBox.Document.Drawing;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using Org.BouncyCastle.Asn1.X509;
using ServiceStack;
using ServiceStack.Auth;
using ServiceStack.DataAnnotations;
using ServiceStack.OrmLite;
using WooW.Core;
using WooW.Core.Common;
using WooW.Core.Server;
using WooW.DTO;
using WooW.Model;
using WooW.WebService.WoSchemaAnalysis;
using static ServiceStack.HttpContextFactory;

namespace WooW.ServiceInterface
{
    public class WoLogService : Service
    {
        public WoLogChanges Get(WoLogRequest LogRequest)
        {
            var woTarget = new WoTargetConnection(Request, Db);

            WoLog woLog = new WoLog();

            return woLog.Get(woTarget.Db, woTarget.userAuthName, woTarget.Roles, LogRequest);
        }
    }
}
