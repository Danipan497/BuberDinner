using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BuberDinner.Domain.Host.ValueObjects;
using BuberDinner.Domain.Menu;
using BuberDinner.Domain.Menu.Entities;

using ErrorOr;

using MediatR;

namespace BuberDinner.Application.Menus.Commands.CreateMenu
{
    public class CreateMenuCommandHandler : IRequestHandler<CreateMenuCommand, ErrorOr<Menu>>
    {
        public Task<ErrorOr<Menu>> Handle(CreateMenuCommand request, CancellationToken cancellationToken)
        {
            var menu = Menu.Create(
                HostId.Create(request.HostId),
                request.Name,
                request.Description,
                request.Sections.ConvertAll(section =>  MenuSection.Create(
                    section.Name,
                    section.Description,
                    section.Items.ConvertAll(item =>  MenuItem.Create(
                        item.Name,
                        item.Description)))));


            return default!;
        }
    }
}
