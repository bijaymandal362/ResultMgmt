import { Component, Input, OnDestroy, OnInit, ViewChild } from "@angular/core";
import { MatSort } from "@angular/material/sort";
import { MatPaginator } from "@angular/material/paginator";
import { Subject } from "rxjs";
import { MvStudent } from "src/core/base.model";
import { MatTableDataSource } from "@angular/material/table";
import { SharedService } from "../shared.service";
import { SelectionModel } from "@angular/cdk/collections";
import { MatDialog } from "@angular/material/dialog";
import { ResultComponent } from "./result/result.component";
import { UtilityService } from "src/core/utility.service";
import { ClassFormComponent } from './class-form/class-form.component';
import { report } from "process";

@Component({
  selector: "app-students",
  templateUrl: "./students.component.html",
  styleUrls: ["./students.component.scss"],
})
export class StudentsComponent implements OnInit, OnDestroy {

  private _unsubscribeAll: Subject<any>;

  hasActions = false;
  gridData: MvStudent[] = [];
  @ViewChild(MatSort, { static: true }) sort: MatSort;
  @ViewChild(MatPaginator, { static: true }) paginator: MatPaginator;
  ELEMENT_DATA: MvStudent[] = [];
  displayedColumns: string[] = [
    "StudentId",
    "Name",
    "ParentName",
    "ParentEmail",
  ];
  name = "Angular";
  enableEdit = false;
  enableEditIndex = null;
  selectedRow: MvStudent = <MvStudent>{};
  dataSource = new MatTableDataSource<MvStudent>(this.ELEMENT_DATA);
  selection = new SelectionModel<MvStudent>(false, []);

  constructor(private st: SharedService, public dialog: MatDialog,private us: UtilityService) {
    this._unsubscribeAll = new Subject();
  }

  ngOnInit() {
    this.dataSource.paginator = this.paginator;
    this.getStudent();
  }

  rowClick(row: MvStudent) {
  
    this.selectedRow = { ...row };
    this.selection.toggle(row);
  }

  getStudent() {
    let val = this.st.getStudent();
    val.subscribe((report) => (this.dataSource.data = report as MvStudent[]));

    console.log(val)
  }

  enableEditMethod(e, i) {
    this.enableEdit = true;
    this.enableEditIndex = i;
    console.log(i, e);
  }

  OpenResult() {
    this.openDialog();
  }

  setTableDataSource() {

    if (this.hasActions) { // add row data for actions
      this.gridData.forEach((data: any) => {
        if (!data['Actions']) {
          data['Actions'] = null;
        }
      });
    }

    this.dataSource = new MatTableDataSource<MvStudent>(this.gridData);
    this.dataSource._updateChangeSubscription();
    this.dataSource.paginator = this.paginator;
    this.dataSource.sort = this.sort;
    
  }

  openDialog() {
    if (!this.selectedRow || Object.keys(this.selectedRow).length === 0) {
      this.us.openSnackBar('Select A Row', 'info');
      return;
    }
    const dialogRef = this.dialog.open(ResultComponent, {
      disableClose: true,

      data: {
        data: { ...this.selectedRow },
      },
    });
  }

  openAddClassDialog(){
    const dialogRef = this.dialog.open(ClassFormComponent, {
      disableClose: true,

      data: {
        data: { ...this.selectedRow },
      },
    });
  }

  AddClass(){
    this.openAddClassDialog();
  }

  ngOnDestroy() {
    this._unsubscribeAll.next();
    this._unsubscribeAll.complete();
  }
}
