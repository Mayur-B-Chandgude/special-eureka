import { Directive, ElementRef, HostListener } from '@angular/core';

@Directive({
  selector: '[appCompSuccess]'
})
export class CompSuccessDirective 
{

  constructor(private _elementref:ElementRef) 
  { 

  }

  @HostListener('mouseenter') onmouseenter()
  {
    this.setcolor('green');
  }

  @HostListener('mouseleave') onmouseleave()
  {
    this.setcolor('black');
  }

  setcolor(color:string)
  {
    this._elementref.nativeElement.style.background = color;
  }

}
