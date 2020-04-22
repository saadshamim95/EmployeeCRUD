import axios from 'axios'

const feetToInchURL = 'https://localhost:44318/api/Conversion/FeetToInch';
const inchToFeetURL = 'https://localhost:44318/api/Conversion/InchToFeet';
const meterToCentimeterURL = 'https://localhost:44318/api/Conversion/MeterToCentimeter';
const centimeterToMeterURL = 'https://localhost:44318/api/Conversion/CentimeterToMeter';
const kgToGmURL = 'https://localhost:44318/api/Conversion/KgToGm';
const gmToKgURL = 'https://localhost:44318/api/Conversion/GmToKg';

export async function feetToInch(data){
   const response = await axios.post(feetToInchURL,data);
   return response;
}

export async function inchToFeet(data){
   const response = await axios.post(inchToFeetURL,data);
   return response;
}

export async function meterToCentimeter(data){
   const response = await axios.post(meterToCentimeterURL,data);
   return response;
}

export async function centimeterToMeter(data){
   const response = await axios.post(centimeterToMeterURL,data);
   return response;
}

export async function kgToGm(data){
    const response = await axios.post(kgToGmURL,data);
    return response;
}

 export async function gmToKg(data){
    const response = await axios.post(gmToKgURL,data);
    return response;
}