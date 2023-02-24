// File:    PhysitianFollowUpSchedulingStrategy.cs
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class PhysitianFollowUpSchedulingStrategy

using Backend.Dto;
using System;

namespace Backend.Service.SchedulingService.SchedulingStrategies
{ 
    public class PhysitianFollowUpSchedulingStrategy : SchedulingStrategy
    {
        private const int DISALLOW_SCHEDULING_HOURS = 24;
        public AppointmentDTO PrepareAppointment(AppointmentDTO appointment)
        {
            appointment.RestrictedHours = DISALLOW_SCHEDULING_HOURS;
            return appointment;
        }
    }
}