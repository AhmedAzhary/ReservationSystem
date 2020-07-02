using ReservationSystem.DTV;
using ReservationSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ReservationSystem.Logic
{
    public class RoomLogic
    {
        IDbSet<Room> _roomRepository;
        public RoomLogic()
        {
            _roomRepository = new RRSContext().Rooms;
        }
        public List<RoomDTV> GetRoomsByFilter(RoomFilter filter)
        {
            var query = _roomRepository.AsQueryable();
            query = ApplyFilters(filter, query);

            List<RoomDTV> rooms = new List<RoomDTV>();

            foreach (var room in query.ToList())
            {
                rooms.Add(new RoomDTV()
                {
                    Floor = room.Floor,
                    ID = room.ID,
                    Name = room.Name,
                    TypeID = room.TypeID
                });
            }
            return rooms;
        }

        private IQueryable<Room> ApplyFilters(RoomFilter filter, IQueryable<Room> query)
        {
            if(filter.AvilableFrom.HasValue)
                query = query.Where(r => r.FreeFrom <= filter.AvilableFrom);
            

            if (!String.IsNullOrEmpty(filter.Name))
                query = query.Where(r => r.Name == filter.Name);


            if (filter.Floor.HasValue)
                query = query.Where(r => r.Floor == filter.Floor);

            if (filter.Type.HasValue)
                query = query.Where(r => r.TypeID == filter.Type);

            return query;
        }
    }
}