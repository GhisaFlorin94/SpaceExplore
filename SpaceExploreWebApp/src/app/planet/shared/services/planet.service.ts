import { Injectable } from '@angular/core';
import { catchError, map } from 'rxjs/operators';
import { HttpClient, HttpResponse, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Planet } from '../models/planet.model';
import { AppPaths } from '../appPaths';

@Injectable()
export class PlanetService {

    headers: HttpHeaders;

    constructor(private httpClient: HttpClient) {
        this.headers = new HttpHeaders({
            'Content-Type': 'application/json'
        });
        this.headers.append('Content-Type', 'application/json');
    }

    getPlanets(): Observable<Planet[]> {
        return this.httpClient.get(AppPaths.GetPlanets,          
            {
                headers: this.headers
            }).pipe(catchError(this.handleError));
    }

    updatePlanet(planet: Planet): Observable<Planet[]>{
        return this.httpClient.patch(AppPaths.UpdatePlanets, planet,
            { 
                headers: this.headers
            }).pipe(catchError(this.handleError));
    }
    

    private handleError(error: any): Promise<any> {
        return Promise.reject(error.message || error);
    }
}