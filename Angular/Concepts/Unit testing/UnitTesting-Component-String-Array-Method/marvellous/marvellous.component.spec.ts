import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MarvellousComponent } from './marvellous.component';

describe('MarvellousComponent', () => {

  it('Should increment counter by 1 when we call incremennt method',()=>{
    let obj = new MarvellousComponent();
    obj.Increment();
    expect(obj.counter).toBe(1);
  });

  it('Should decrement counter by 1 when we call decrement method',()=>{
    let obj = new MarvellousComponent();
    obj.Decrement();
    expect(obj.counter).toBe(-1);
  });
});
