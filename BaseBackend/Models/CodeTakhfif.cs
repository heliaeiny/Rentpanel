using BaseBackend.Abstraction;
using BaseBackend.Enums;

namespace BaseBackend.Models;

public class CodeTakhfif : BaseEntity
{

    // inja base be in mana ast ke aval code haye classi ke azash ers bari shude ejra beshe
    // yani aval code haye baseentity ejra beshe baadesh code haye code takhfif 
    // va inke alan in codetakhfif ke base neveshte kenaresh yek constructor ast
    public CodeTakhfif() : base()
    { }
    public CodeTakhfif(string Code, TakhfifStatus Type)
    {
        //tyoe of no e dade ei ke dakhele paranteze jolosh hast ra barresi mikne
        //enum.isdefined ham yek method az classe enum hast ke barresi mikne meghdar moshakhas shde tooye enum hast ya na 
        if (string.IsNullOrEmpty(Code) || !Enum.IsDefined(typeof(TakhfifStatus), Type))
        {
            throw new Exception("لطفا کد تخفیف و نوع تخفیف را وارد کنید");
        }

    }
    //yedoone max bezaram
    public Product product { get; set; }
    public int ProductId { get; set; }
    public int Id { get; set; }
    public kodstatus? Type { get; set; }

    public int TypeId { get; set; }

    public int TakhfifId { get; set; }
    public double Meghdartakhfif { get; set; }
    public DateTime StartTakhfif { get; set; }
    public DateTime EndTakhfif { get; set; }
    //inja ke strinng code yni byd code tgakhfif ra vared kne 
    public string Code { get; set; }
    public bool IsActive { get; set; }
 }

