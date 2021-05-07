import { BrowserModule } from "@angular/platform-browser";
import { NgModule } from "@angular/core";
import { FormsModule, ReactiveFormsModule } from "@angular/forms";
import { HttpClientModule } from "@angular/common/http";
import { RouterModule } from "@angular/router";
import { MatPaginator, MatPaginatorModule } from "@angular/material/paginator";
import { AppComponent } from "./app.component";
import { NavMenuComponent } from "./nav-menu/nav-menu.component";
import { ClassFormComponent } from './students/class-form/class-form.component';
import { BrowserAnimationsModule } from "@angular/platform-browser/animations";
import { approutes } from "./app-routing.module";
import { StudentsComponent } from "./students/students.component";
import { MatTableModule } from "@angular/material/table";
import { SharedService } from "./shared.service";
import {
  MatButtonModule,
  MatDialogModule,
  MatFormFieldModule,
  MatIconModule,
  MatSnackBarModule,
  MatTooltipModule,
} from "@angular/material";
import { ResultComponent } from "./students/result/result.component";
import { MatInputModule } from "@angular/material/input";
import { MatSelectModule } from "@angular/material/select";
import { NgxPrintModule } from "ngx-print";

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    StudentsComponent,
    ResultComponent,
    ClassFormComponent
  ],
  imports: [
  
  BrowserModule.withServerTransition({ appId: "ng-cli-universal" }),
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    RouterModule.forRoot([
      { path: "", component: StudentsComponent, pathMatch: "full" },
      { path: "addresult", component: ResultComponent },
      { path: "addclass", component: ClassFormComponent },
       
    ]),
    RouterModule.forRoot(approutes, { onSameUrlNavigation: "reload" }),
    BrowserAnimationsModule,
    MatPaginatorModule,
    MatFormFieldModule,
    MatTableModule,
    MatButtonModule,
    MatIconModule,
    MatDialogModule,
    MatSnackBarModule,
    MatTooltipModule,
    MatSelectModule,
    MatInputModule,
    NgxPrintModule
    
  ],
  providers: [SharedService],
  bootstrap: [AppComponent],
})
export class AppModule {}
