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
        IDbSet<Reservation> _reservationRepository;
        RRSContext context;
        public RoomLogic()
        {
            context = new RRSContext();
            _roomRepository = context.Rooms;
            _reservationRepository = context.Reservations;
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

        public string AddReservation(ReservationWrapperDTV reservation)
        {
            var query = _reservationRepository
                .Where(r => (r.RoomID == reservation.RoomID) & ((r.ArrivalDate >= reservation.ArrivalDate & r.ArrivalDate <= reservation.DepartureDate)
                | (r.DepartureDate >= reservation.ArrivalDate & r.DepartureDate <= reservation.DepartureDate))).FirstOrDefault();
            if (query != null)
                return "هناك حجز يتعارض مع الوقت المطلوب، الرجاء مراجعة الحجوزات ثم المحاولة مرة اخرى";

            if (reservation.DepartureDate <= reservation.ArrivalDate)
                return "لا يجب ان يكون يوم المغادرة قبل يوم الوصول";

            var room = _roomRepository.Where(r => reservation.RoomID == r.ID).First();

            var totalDays = (reservation.DepartureDate - reservation.ArrivalDate).TotalDays;
            float cash = 0.0F;
            if (room.TypeID == (int)enums.RoomType.Single && room.Floor == 3)
                cash = (float)totalDays * 280;
            else if (room.TypeID == (int)enums.RoomType.Single && room.Floor == 4)
                cash = (float)totalDays * 380;
            else if (room.TypeID == (int)enums.RoomType.Double && room.Floor == 3)
                cash = (float)totalDays * 450;
            else if (room.TypeID == (int)enums.RoomType.Double && room.Floor == 4)
                cash = (float)totalDays * 650;
            else if (room.TypeID == (int)enums.RoomType.Suite && room.Floor == 3)
                cash = (float)totalDays * 580;
            else if (room.TypeID == (int)enums.RoomType.Suite && room.Floor == 4)
                cash = (float)totalDays * 1050;

            if (reservation.Nationality == (int)enums.Nationality.NonEgyptian)
                cash = cash * 2;
            _reservationRepository.Add(new Reservation()
            {
                ArrivalDate = reservation.ArrivalDate,
                ArrivingFrom = reservation.ArrivingFrom,
                RoomID = reservation.RoomID,
                DepartureDate = reservation.DepartureDate,
                Reason = reservation.Reason,
                Cash = cash,
                Client = new Client()
                {
                    BirthDate = reservation.BirthDate,
                    DoctorName = reservation.DoctorName,
                    EmployerName = reservation.EmployerName,
                    HomeAddress = reservation.EmployerName,
                    Name = reservation.Name,
                    NationalID_PassPortNumber = reservation.NationalID_PassPortNumber,
                    NationalityID = reservation.Nationality,
                    PhoneNumber = reservation.PhoneNumber,
                    PostalCode = reservation.PostalCode.Value,
                    PatientRoomNumber = reservation.PatientRoomNumber,
                    PatientName = reservation.PatientName,
                }
            });
            context.SaveChanges();
            return string.Empty;
        }

        public ReservationWrapperDTV GetReservations(int roomID)
        {
            var result = new ReservationWrapperDTV()
            {
                RoomID = roomID,
                Reservations = new List<ReservationDTV>()
            };
            var query = _reservationRepository.Where(res => res.RoomID == roomID).OrderByDescending(res => res.DepartureDate)
                .Select(res => new
                {
                    res.ID,
                    res.ArrivalDate,
                    res.DepartureDate,
                    res.Cash,
                    res.Client.Name,
                    IdOrPassPort = res.Client.NationalID_PassPortNumber
                });
            foreach (var reservation in query)
            {
                result.Reservations.Add(new ReservationDTV()
                {
                    ID = reservation.ID,
                    ArrivalDate = reservation.ArrivalDate,
                    DepartureDate = reservation.DepartureDate,
                    Cash = reservation.Cash,
                    Name = reservation.Name,
                    IdOrPassPort = reservation.IdOrPassPort
                });
            }
            return result;
        }

        private IQueryable<Room> ApplyFilters(RoomFilter filter, IQueryable<Room> query)
        {
            if (filter.AvilableFrom.HasValue)
                query = query.Where(r => r.FreeFrom <= filter.AvilableFrom);


            if (!String.IsNullOrEmpty(filter.Name))
                query = query.Where(r => r.Name.Contains(filter.Name));


            if (filter.Floor.HasValue)
                query = query.Where(r => r.Floor == filter.Floor);

            if (filter.Type.HasValue)
                query = query.Where(r => r.TypeID == filter.Type);

            return query;
        }
    }
}