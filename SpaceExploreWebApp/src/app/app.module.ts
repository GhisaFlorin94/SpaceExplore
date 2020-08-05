import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { AppComponent } from './app.component';
import { PlanetListComponent } from './planet/components/planet-list.component';
import { FormsModule } from '@angular/forms';
import { HttpClientModule} from "@angular/common/http";
import { PlanetEditModal } from './planet/components/planet-edit-modal.component';
import { NgbModal, NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { PlanetCardComponent } from './planet/components/planet-card.component';
import { EnumToArrayPipe } from './planet/shared/pipe/enum-to-array.pipe';



@NgModule({
  declarations: [
    AppComponent,
    PlanetListComponent,
    PlanetCardComponent,
    PlanetEditModal,
    EnumToArrayPipe
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpClientModule,
    NgbModule.forRoot(),
    FormsModule
     ],
  providers: [],
  bootstrap: [AppComponent],
  entryComponents:[PlanetEditModal]
})
export class AppModule { }
