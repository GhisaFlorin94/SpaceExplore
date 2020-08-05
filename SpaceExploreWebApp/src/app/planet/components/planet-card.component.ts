import { Component, OnInit, Input, NgModuleRef } from "@angular/core";
import { PlanetService } from "../shared/services/planet.service";
import { Planet } from "../shared/models/planet.model";
import { PlanetStatus } from "../shared/models/planet-status.enum";
import { PlanetEditModal } from "./planet-edit-modal.component";
import { NgbModal } from "@ng-bootstrap/ng-bootstrap";
import { Crew } from "../shared/models/crew.model";


@Component({
    moduleId: module.id,
    selector: 'planet-card',
    templateUrl: 'planet-card.component.html',
    styleUrls: ['planet-card.component.scss'],

    providers: [PlanetService]
})
export class PlanetCardComponent implements OnInit {

    @Input() planet:Planet;
    @Input() crewList: Crew[];
    exploringCrew:Crew;
    explorinRobots: string;
    constructor(private planetService: PlanetService, private modal: NgbModal) {
    
    }
    ngOnInit(): void {
       this.exploringCrew = this.getExploringCrewOfThePlanet();
       this.getRobotstDisplayText();
    }

    onClick() {
        const modalRef = this.modal.open(PlanetEditModal);
        modalRef.componentInstance.planet = this.planet;
        modalRef.componentInstance.crewList = this.crewList;

        modalRef.componentInstance.updatedPlanet.subscribe((updatePlanet) => {
            this.planet = updatePlanet;
            this.exploringCrew = this.crewList.find(c => c.crewId == this.planet.crewId)
            this.getRobotstDisplayText();

            })
      }

      getStatus(status: number){
        return PlanetStatus[status];
    }

    getRobotstDisplayText(){
        if(this.exploringCrew)
        this.explorinRobots = this.exploringCrew.robots.map(c => c.robotName).join(', ');
    }

    getExploringCrewOfThePlanet(){
        return this.crewList.find(c => c.crewId == this.planet.crewId)
    }
    
}