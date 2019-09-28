import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'marvellousChk'
})
export class MarvellousChkPipe implements PipeTransform 
{

  transform(value: any, Param: String): any 
  {
    if(Param == 'prime')
    {
      for(var i = 2 ; i <= value ; i++)
	    {
		    if((value % i) == 0)
		    {
			    return "Number is not Prime.."
		    }
		    else
		    {
			    return "Number is Prime..";
		    }
	    }
    }

    if(Param == 'perfect')
    {
      //register int i = 0;
	    var add = 0;
	    var temp = value;

	    for(var i = 1 ; i < value ; i++)
	    {
		    if((value % i) == 0)
		    {
			    add = add + i;
		    }
	    }

	    if(add == temp)
	    {
		    return "Number is Perfect..";
	    }
	    else
	    {
    		return "Number is not Perfect..";
	    }
    }

    if(Param == 'even')
    {
      if((value % 2) == 0)
      {
        return "Number is Even..";
      }
      else
      {
        return "Number is Odd..";
      }
    }
  }
}
