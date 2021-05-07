import { Component, Inject, Input, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { SharedService } from 'src/app/shared.service';
import {  MvResult } from 'src/core/base.model';

@Component({
  selector: 'app-result',
  templateUrl: './result.component.html',
  styleUrls: ['./result.component.scss']
})
export class ResultComponent implements OnInit {

  @Input() DATA:any;
  fmApplicant:FormGroup;
  selectedModel: MvResult = <MvResult>{};
  constructor(  public dialogRef: MatDialogRef<ResultComponent>,
  
    @Inject(MAT_DIALOG_DATA) public data: any,
    private fb: FormBuilder,
    private st: SharedService) { 
      // this.selectedModel  = <MvClass>data?.data;
    }

  ngOnInit() {
    this.initForm();
  }

  initForm() {

    this.fmApplicant = this.fb.group({
      StudentId: [this.selectedModel.StudentId],
      Name: [this.selectedModel.Name, Validators.required],
      ParentName: [this.selectedModel.ParentName, Validators.required],
      ParentEmail: [this.selectedModel.ParentEmail, Validators.required],
      ClassId: [this.selectedModel.ClassId, Validators.required],
      SubjectId: [this.selectedModel.SubjectId, Validators.required],
      Credit: [this.selectedModel.Credit, Validators.required],
      Grade: [this.selectedModel.Grade, Validators.required]
    

    });
  }


  mailClick(){
    this.st.sendEmail(this.fmApplicant.getRawValue()).subscribe(result => {
      console.log("Email sent!");
    });
    
  }

  cancelClick(){
    this.dialogRef.close();
  }
}
