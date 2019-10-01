import { batches } from "./MarvellousArray";

describe('batches',()=>{

    it('should return all names of Marvellous Batches', ()=>{
        const ret = batches();
        expect(ret).toContain('PPA');
        expect(ret).toContain('Angular');
        expect(ret).toContain('LB');
        expect(ret).toContain('Python');
    })
})