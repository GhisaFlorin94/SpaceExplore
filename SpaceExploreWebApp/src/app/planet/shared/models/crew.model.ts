import { Robot } from "./robot.model";
import { Captain } from "./captain.model";
import { Shuttle } from "./shuttle.model";

export class Crew {

    crewId: number;
    captainId: number;
    shuttleId: number;
    captain: Captain;
    shuttle: Shuttle;
    robots: Robot[]=[];
   
}
