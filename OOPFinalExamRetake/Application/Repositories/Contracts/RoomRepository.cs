﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BookingApp.Models.Bookings.Contracts;
using BookingApp.Models.Rooms.Contracts;

namespace BookingApp.Repositories.Contracts
{
    public class RoomRepository :IRepository<IRoom>
    {
        private List<IRoom> bookings;

        public RoomRepository()
        {
            this.bookings = new List<IRoom>();
        }
        public void AddNew(IRoom model)
        {
            this.bookings.Add(model);
        }

        public IRoom Select(string criteria)
        {
            return this.bookings.FirstOrDefault(x => x.GetType().Name == criteria);
        }

        public IReadOnlyCollection<IRoom> All()
        {
            return this.bookings.AsReadOnly();
        }
    }
}
