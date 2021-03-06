﻿using Exrin.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeslaDefinition.Model;

namespace TeslaDefinition.Interfaces.Model
{
	public interface IServiceModel : IBaseModel
	{

		Task SaveBooking(Booking booking);

		Task<IList<Booking>> GetBookings();

		Task<IList<ServiceCentre>> GetServiceCentres();

	}
}
