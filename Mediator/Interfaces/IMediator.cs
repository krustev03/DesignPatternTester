﻿namespace Mediator.Interfaces
{
    public interface IMediator
    {
        void Notify(object sender, string ev);
    }
}
