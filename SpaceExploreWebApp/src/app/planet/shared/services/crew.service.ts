import { Injectable } from '@angular/core';
import { catchError, map } from 'rxjs/operators';
import { HttpClient, HttpResponse, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Planet } from '../models/planet.model';
import { AppPaths } from '../appPaths';
import { Crew } from '../models/crew.model';

@Injectable()
export class CrewService {

    headers: HttpHeaders;

    constructor(private httpClient: HttpClient) {
        this.headers = new HttpHeaders({
            'Content-Type': 'application/json'
        });
        this.headers.append('Content-Type', 'application/json');
    }

    getCrews(): Observable<Crew[]> {
        return this.httpClient.get(AppPaths.GetCrews,          
            {
                headers: this.headers
            }).pipe(catchError(this.handleError));
    }
    

    private handleError(error: any): Promise<any> {
        return Promise.reject(error.message || error);
    }
}