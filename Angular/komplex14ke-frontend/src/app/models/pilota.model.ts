import { CsapatModel } from "./csapat.model";

export class PilotaModel {
    ID : number = 0;
    nev: string = "";
    nemzet:string = "";
    szuletes: Date;
    magassag: number = 0;
    csapat: CsapatModel;

    constructor(szerverről_érkező_sor:any) {
        this.ID         = szerverről_érkező_sor.ID;
        this.nev        = szerverről_érkező_sor.nev;
        this.nemzet     = szerverről_érkező_sor.nemzet;
        this.szuletes   = szerverről_érkező_sor.szuletes;
        this.magassag   = szerverről_érkező_sor.magassag;

        let csapat: CsapatModel | undefined;

        if (CsapatModel.csapatok.length > 0)
            CsapatModel.csapatok.forEach(tömbbeli_csapat => {
                if (tömbbeli_csapat.ID == szerverről_érkező_sor.csapatID) {
                    csapat = tömbbeli_csapat;
                } 
            });

        if (csapat === undefined) {
            this.csapat     = new CsapatModel(szerverről_érkező_sor);
        } else {
            this.csapat = csapat;
        }
        
    }
}
