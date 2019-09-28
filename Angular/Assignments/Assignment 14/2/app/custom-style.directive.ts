import { Directive, ElementRef } from '@angular/core';

@Directive({
  selector: '[appCustomStyle]'
})
export class CustomStyleDirective 
{

  constructor(private _elementref:ElementRef) 
  { 
    this._elementref.nativeElement.style.background = 'yellow';
  }

  setcolor(color:String)
  {
    this._elementref.nativeElement.style.background = color;
  }
}
