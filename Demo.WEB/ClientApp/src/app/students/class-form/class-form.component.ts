import { Component, Inject, Input, OnDestroy, OnInit } from "@angular/core";
import { FormGroup, FormBuilder, Validators } from "@angular/forms";
import { MatDialogRef, MAT_DIALOG_DATA } from "@angular/material/dialog";
import { Subject } from "rxjs";
import { SharedService } from "src/app/shared.service";
import { MvClass, MvStudent } from "./../../../core/base.model";

@Component({
  selector: "app-class-form",
  templateUrl: "./class-form.component.html",
  styleUrls: ["./class-form.component.scss"],
})
export class ClassFormComponent implements OnInit, OnDestroy {


  private _unsubscribeAll: Subject<any>;
  fmClass: FormGroup;
  selectedModel: MvClass = <MvClass>{};
  studentList: number[];
  constructor(
    public dialogRef: MatDialogRef<ClassFormComponent>,
    @Inject(MAT_DIALOG_DATA) public data: any,
    private fb: FormBuilder,
    private st: SharedService
  ) {
    this._unsubscribeAll = new Subject();
  }

  ngOnInit() {}

  cancelClick() {
    this.dialogRef.close();
  }

  submitForm() {}

  getStudentList() {
    // let val = this.st.getStudent();
    // val.subscribe((report) => (this.dataSource.data = report as MvStudent[]));
  }

  ngOnDestroy() {
    this._unsubscribeAll.next();
    this._unsubscribeAll.complete();
  }
}
function takeUntil(_unsubscribeAll: Subject<any>): any {
  throw new Error("Function not implemented.");
}
