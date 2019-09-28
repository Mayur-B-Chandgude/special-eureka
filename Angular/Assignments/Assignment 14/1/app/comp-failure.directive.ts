import { Directive, ElementRef, HostListener } from '@angular/core';

@Directive({
  selector: '[appCompFailure]'
})
export class CompFailureDirective 
{

  constructor(private _elementref:ElementRef) 
  { 

  }

  @HostListener('mouseenter') onmouseenter()
  {
    this.setcolor('red');
  }

  @HostListener('mouseleave') onmouseleave()
  {
    this.setcolor('black');
  }
  
  setcolor(color:String)
  {
    this._elementref.nativeElement.style.background = color;
  }
}
