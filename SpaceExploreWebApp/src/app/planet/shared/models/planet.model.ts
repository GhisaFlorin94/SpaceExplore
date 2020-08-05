import { Description } from "./description.model";
import { Robot } from "./robot.model";
import { PlanetStatus } from "./planet-status.enum";

export class Planet {

    planetId: number;
    name: string;
    imageUrl: string;
    description: string;
    crewId:number;
    planetStatus: PlanetStatus;
   
}