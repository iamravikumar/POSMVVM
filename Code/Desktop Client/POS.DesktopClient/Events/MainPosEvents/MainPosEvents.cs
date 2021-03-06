﻿using POSEntities;
using POSEntities.Entities;
using Prism.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.DesktopClient.Events.MainPosEvents
{
    public class AddItemEvent : PubSubEvent<ItemDisplayInfo> { }
    public class SelectItemComplete : PubSubEvent<IDisplayableModel> { }
    public class SelectItemCanceled : PubSubEvent<object> { }
    public class POSItemClick : PubSubEvent<ItemDisplayInfo> { }
    public class DisplayItemEditClick : PubSubEvent<ItemDisplayInfo> { }
    public class SelectDialogComplete : PubSubEvent<object> { }
    public class SelectDialogCancel : PubSubEvent<object> { }
    public class CopyOrderFromSearch : PubSubEvent<Order> { }
    public class PrintOrderFromSearch : PubSubEvent<Order> { }
    public class FullRefundFromSearch : PubSubEvent<Order> { }
    public class PartialRefundFromSearch : PubSubEvent<Order> { }

}
