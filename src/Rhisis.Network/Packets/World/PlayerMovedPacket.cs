﻿using System;
using Ether.Network.Packets;
using Rhisis.Core.Data;
using Rhisis.Core.Structures;

namespace Rhisis.Network.Packets.World
{
    /// <summary>
    /// Defines the <see cref="PlayerMovedPacket"/> structure.
    /// </summary>
    public struct PlayerMovedPacket : IEquatable<PlayerMovedPacket>
    {
        /// <summary>
        /// Gets the BeginPosition.
        /// </summary>
        public Vector3 BeginPosition { get; }

        /// <summary>
        /// Gets the DestinationPosition.
        /// </summary>
        public Vector3 DestinationPosition { get; }

        /// <summary>
        /// Gets the Angle.
        /// </summary>
        public float Angle { get; }

        /// <summary>
        /// Gets the object state (MovingFlag).
        /// </summary>
        public uint State { get; }

        /// <summary>
        /// Gets the state flag. (Motion flag)
        /// </summary>
        public uint StateFlag { get; }

        /// <summary>
        /// Gets the motion.
        /// </summary>
        public uint Motion { get; }

        /// <summary>
        /// Gets the motion ex.
        /// </summary>
        public int MotionEx { get; }

        /// <summary>
        /// Gets the loop.
        /// </summary>
        public int Loop { get; }

        /// <summary>
        /// Gets the motion option.
        /// </summary>
        public uint MotionOption { get; }

        /// <summary>
        /// Gets the tick count.
        /// </summary>
        public long TickCount { get; }

        /// <summary>
        /// Creates a new <see cref="SetDestPositionPacket"/> instance.
        /// </summary>
        /// <param name="packet">Incoming packet</param>
        public PlayerMovedPacket(INetPacketStream packet)
        {
            this.BeginPosition = new Vector3(packet.Read<float>(), packet.Read<float>(), packet.Read<float>());
            this.DestinationPosition = new Vector3(packet.Read<float>(), packet.Read<float>(), packet.Read<float>());
            this.Angle = packet.Read<float>();
            this.State = packet.Read<uint>();
            this.StateFlag = packet.Read<uint>();
            this.Motion = packet.Read<uint>();
            this.MotionEx = packet.Read<int>();
            this.Loop = packet.Read<int>();
            this.MotionOption = packet.Read<uint>();
            this.TickCount = packet.Read<long>();
        }

        /// <summary>
        /// Compares two <see cref="PlayerMovedPacket"/> objects.
        /// </summary>
        /// <param name="other">Other <see cref="PlayerMovedPacket"/></param>
        /// <returns></returns>
        public bool Equals(PlayerMovedPacket other)
        {
            throw new NotImplementedException();
        }
    }
}