﻿using Application.Abstractions.Messaging;
using Application.Shared;
using AutoMapper;
using Domain.Abstractions.CommandRepositories;
using Domain.Entities;

namespace Application.Commands.UpdateOffice
{
    public class UpdateOfficeCommandHandler : ICommandHandler<UpdateOfficeCommand, Result>
    {
        private IReadWriteOfficesRepository _officesRepository;
        private IMapper _mapper;
        public UpdateOfficeCommandHandler(IReadWriteOfficesRepository officesRepository, IMapper mapper)
        {
            _officesRepository = officesRepository;
            _mapper = mapper;
        }

        public async Task<Result> Handle(UpdateOfficeCommand request, CancellationToken cancellationToken)
        {
            var office = _mapper.Map<Office>(request);
            await _officesRepository.UpdateAsync(office);
            return new Result();
        }
    }
}
