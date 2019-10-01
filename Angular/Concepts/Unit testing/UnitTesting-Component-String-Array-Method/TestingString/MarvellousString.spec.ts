import { Display } from "./MarvellousString";

describe('Display',()=>{
    it('should return name of student',()=>{
        expect(Display('Mayur')).toContain('Mayur welcome to Marvellous Infosystems');
    });
})