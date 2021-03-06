﻿using Emprise.Domain.Core.Commands;
using Emprise.Domain.Core.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Emprise.Domain.Player.Commands
{
    public class JoinGameCommand : Command
    {
        public int UserId { get; set; }

        public int PlayerId { get; set; }


        public JoinGameCommand(int userId, int playerId)
        {
            UserId = userId;
            PlayerId = playerId;
        }

    }
}
