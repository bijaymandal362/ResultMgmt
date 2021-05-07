export interface MvGridColumn {
  Name: string; // column name
  Type: string; // Action, Text, Number, Percent, Money, Date, DateTime, CheckBox, Template
  TemplateColumns?: string[]; // TemplateColumn is the list of columns which is to be shown as template in current column
  /*
        Formats are added by default, use this property if custom format needed
        Defaults: AppConst.Data.GridOptions.GridColumnOption.Format
    */
  Format?: string;
  CellColor?: string; // change the color of cell text
  CellInfoText?: string; // pass information sentence if needed to show info icon with information in tooltip on hover
  Data?: any[]; // action list for row Actions, other kind of additional data can be sent eg: Dropdownlist
  Sticky?: boolean; // sticky header - false by default (row Actions should always be sticky)
  DisableSort?: boolean; // disable column sort - false by default
  /*
        Cell prefix like $ or Rs 
        Defaults: AppConst.Data.GridOptions.GridColumnOption.Prefix
   */
  Prefix?: string;
  /*
        Cell suffix like % 
        Defaults: AppConst.Data.GridOptions.GridColumnOption.Suffix
   */
  Suffix?: string;
  Hidden?: boolean;
}

export interface MvStudent {
  StudentId: number;
  Name: string;
  ParentName: string;
  ParentEmail: string;
}

export interface MvClass {
  ClassId: number;
  Class: string;
  StudentId: number;
  Name: string;
}
export interface MvResult {
  StudentId: number;
  Name: string;
  ParentName: string;
  ParentEmail: string;
  ClassId: number;
  Class: string;
  SubjectId: string;
  Credit:number;
  Grade:string;
}
