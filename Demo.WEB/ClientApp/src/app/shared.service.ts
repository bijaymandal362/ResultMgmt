import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';


@Injectable({
  providedIn: 'root'
})

export class SharedService {
close(arg0: any) {
  throw new Error('Method not implemented.');
}
readonly APIUrl = "https://localhost:44308/api";

constructor(private http: HttpClient) {}
headers = new HttpHeaders().set('Content-Type', 'application/json; charset=utf-8');

getStudent(): Observable<any[]> {
  return this.http.get<any>(this.APIUrl + "/students");
}

sendEmail(mailMessage: any) {
  return this.http.post<any>(this.APIUrl + "/Email", JSON.stringify(mailMessage), { headers: this.headers })
}

}
