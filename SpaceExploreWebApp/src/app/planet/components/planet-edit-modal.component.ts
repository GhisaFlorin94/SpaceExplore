import { Component, OnInit, Input, EventEmitter, Output } from '@angular/core';
import {NgbActiveModal} from '@ng-bootstrap/ng-bootstrap';
import { CrewService } from '../shared/services/crew.service';
import { Crew } from '../shared/models/crew.model';
import { PlanetStatus } from '../shared/models/planet-status.enum';
import { Planet } from '../shared/models/planet.model';
import { PlanetService } from '../shared/services/planet.service';

@Component({
  selector: 'planet-edit-modal',
  templateUrl: './planet-edit-modal.component.html',
  styleUrls: ['./planet-edit-modal.component.scss'],
  providers: [CrewService, PlanetService]

})
export class PlanetEditModal implements OnInit {

  planetStatuses = PlanetStatus;
  @Input()crewList : Crew[];
  @Input() planet:Planet;
  updatingPlanet: Planet;
  @Output() updatedPlanet: EventEmitter<Planet> = new EventEmitter();


  constructor(public activeModal: NgbActiveModal, private crewService: CrewService, private planetService: PlanetService ) { }

  ngOnInit(){

    this.updatingPlanet = {crewId: this.planet.crewId
                        ,description: this.planet.description
                        ,planetStatus: this.planet.planetStatus
                        ,imageUrl: this.planet.imageUrl
                        ,planetId: this.planet.planetId
                        ,name: this.planet.name};

    }
  


/*
  private getStatusName(statusId: number) {
    for (const enumMember in this.planetStatuses) {
      if (statusId === this.planetStatuses[enumMember]) {
        return enumMember;
      }
    }
  }
*/

  submitHandler(planetform){
    this.planet.description = planetform.form.value.description;
    this.planet.planetStatus = planetform.form.value.status;
    this.planet.crewId = planetform.form.value.crew;

    this.planetService.updatePlanet(this.planet).subscribe(response=>{
      this.updatedPlanet.emit(this.planet);
      this.activeModal.close();
    },
    error=>{
        alert("Something went wrong");
        console.error(error)
        this.activeModal.close();
      }
     );
      console.log(planetform);
  }
}