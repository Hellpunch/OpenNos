﻿////<auto-generated <- Codemaid exclusion for now (PacketIndex Order is important for maintenance)
using OpenNos.Core;
using OpenNos.Domain;

namespace OpenNos.GameObject
{
    [PacketHeader("$ChangeClass", PassNonParseablePacket = false)]
    public class ChangeClassPacket : PacketDefinition
    {
        #region Properties

        [PacketIndex(0)]
        public ClassType ClassType { get; set; }

        #endregion
    }
}