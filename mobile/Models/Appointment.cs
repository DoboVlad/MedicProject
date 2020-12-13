﻿using System;
using System.Collections.Generic;
using System.Text;
using mobile.ViewModels;

namespace mobile
{
    // for the moment, this is a dummy class used to load data for the list view in home page
    public class Appointment
    {
        private int id;
        private DateTime date;
        private string hour;
        private string status;
        private const string duration = "Duration: 30 min";
        private string details;
        private PatientModel patient;
        private string patientName;

        public PatientModel Patient 
        { 
            get 
            {
                return patient;
            }
            set { patient = value; }
        }
        public string PatientName
        {
            get
            {
                return patient.FullName;
            }
         
        }
        public string Details
        {
            get
            {
                return details;
            }
            set
            {
                details = value;

            }
        }
        public DateTime Date
        {

            get
            {

                return date;

            }
            set
            {
                date = value;
            }
        }
        public string DateString
        {

            get
            {

                return date.ToString();

            }
        }

        public string Hour
        {
            get
            {
                return hour;
            }

            set
            {

                hour = value.ToString();
            }
        }
        public int Id
        {
            get
            {
                return id;
            }

            set
            {

                id = value;
            }
        }
        public string Status
        {
            get
            {
                return status;
            }

            set
            {

                status = value.ToString();
            }
        }
        public string Duration
        {

            get { return duration; }
        }
        
    }

}
