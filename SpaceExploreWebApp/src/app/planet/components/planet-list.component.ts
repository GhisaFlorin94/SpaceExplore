import { Component, OnInit } from "@angular/core";
import { PlanetService } from "../shared/services/planet.service";
import { Planet } from "../shared/models/planet.model";
import { PlanetStatus } from "../shared/models/planet-status.enum";
import { PlanetEditModal } from "./planet-edit-modal.component";
import { NgbModal } from "@ng-bootstrap/ng-bootstrap";
import { CrewService } from "../shared/services/crew.service";
import { Crew } from "../shared/models/crew.model";


@Component({
    moduleId: module.id,
    selector: 'planet-list-component',
    templateUrl: 'planet-list.component.html',
    styleUrls: ['planet-list.component.scss'],

    providers: [CrewService, PlanetService]
})
export class PlanetListComponent implements OnInit {

    planetList: Planet[] = [];
    crewList : Crew[]=[];

    constructor(private planetService: PlanetService, private crewService: CrewService, private modal: NgbModal) {
    
    }

    ngOnInit(){
        this.getPlanets();
        this.getCrews();
    }

    getPlanets(){
        this.planetService.getPlanets().subscribe(planetList=>{
            this.planetList = planetList;
        },
        error=>{
            alert("Something went wrong");
            console.error(error)
        }
        );
    }

    getCrews(){
        this.crewService.getCrews().subscribe(crewList=>{
            this.crewList = crewList;
        },
        error=>{
            alert("Something went wrong");
            console.error(error)
        }
        );
      }
    
}