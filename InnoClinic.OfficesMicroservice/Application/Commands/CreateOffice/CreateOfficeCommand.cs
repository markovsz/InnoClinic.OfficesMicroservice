﻿using Application.Abstractions.Messaging;

namespace Application.Commands.CreateOffice
{
    public class CreateOfficeCommand : CreateOfficeModel, ICommand<Guid>
    {
        public CreateOfficeCommand(string photoUrl, string city, string street, string houseNumber, string officeNumber, string registryPhoneNumber, string status)
            : base(photoUrl, city, street, houseNumber, officeNumber, registryPhoneNumber, status)
        {
        }
    }
}
