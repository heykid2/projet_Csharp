﻿using NavalWar.DTO;

namespace NavalWar.DAL.Interfaces
{
    public interface ISessionService
    {
        List<SessionDTO> GetSessions();
    }
}