
export class CsapatModel {
    public ID : number = 0;
    public nev: string = "";
    public nemzet: string = "";

    public static csapatok:CsapatModel[] = [];
    
    constructor(szerverről_érkező_sor:any) {
        this.ID         = szerverről_érkező_sor.csapatID;
        this.nev        = szerverről_érkező_sor.csapatnev;
        this.nemzet     = szerverről_érkező_sor.csapatnemzet;

        CsapatModel.csapatok.push(this);
    }
}