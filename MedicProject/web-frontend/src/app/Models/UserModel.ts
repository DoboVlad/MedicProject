import {Doctor} from './DoctorModel';

export class User{
  id? : number;
  firstName?: string;
  lastName?: String;
  email?: String;
  password?: String;
  repeatPassword?: String;
  description?: string;
  dateOfBirth?: Date;
  gender?: string;
  cnp?: string;
  photo?: string;
  age?: number;
  phoneNumber?: String;
  isApproved?: number;
  token?: string;
  doctorId?: number;
  doctor?: Doctor;
  isMedic?: number;
  status?: any;
  validated?: number;
  active?: boolean;
  City?: String;
  Street?: String;
  County?: String;
  HomeNumber?: number;
  Appartment?: number;
  Entrance?: number;
}
