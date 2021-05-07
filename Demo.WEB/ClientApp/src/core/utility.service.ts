import { Injectable } from "@angular/core";

import { MatSnackBar } from "@angular/material/snack-bar";

@Injectable({
  providedIn: "root",
})
export class UtilityService {
  constructor(private snackBar: MatSnackBar) {}

  openSnackBar(message: string, type: string, duration?: number) {
    
    this.snackBar.open(message, "x", {
      duration: duration || 5000, // in milli-seconds
      panelClass: [type],
      horizontalPosition: "end",
      verticalPosition: "top",
    });
  }
}
