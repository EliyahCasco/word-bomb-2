using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inputText : MonoBehaviour
{
    public Text currentText;
    public Text wordText;
    public GameObject levelSystem;
    levelSystem levelScript;
    public AudioSource theme1;
    public AudioSource theme2;
    public AudioSource theme3;



    public static string[] alphabet1 = {
        "a", "b", "c", "d", "e", "f", "g", "h", "i", "j",
        "k", "l", "m", "n", "o", "p", "r", "s", "t", "u",
        "v", "w", "y", "z"
    };
    public static string[] alphabet2 = {
        "ad", "ai", "al", "am", "an", "ar", "as", "at", "au", "av", "ax", "ay",
        "ba", "be", "bi", "bo", "br", "by",
        "ca", "ce", "ck", "cl", "co", "cu", "cy",
        "da", "db", "di", "do", "dr", "ds", "du", "dy",
        "ea", "ee", "eg", "el", "em", "ep", "er", "ev", "ew", "ex", "ey",
        "fa", "fe", "ff", "fl", "fr", "ft", "fo",
        "ga", "ge", "gh", "gi", "gl", "go", "gr", "gu", "gy",
        "ha", "he", "hi", "hm", "hu",
        "ib", "ic", "id", "ie", "im", "in", "io", "iq", "ix",
        "ja", "je", "ji", "jo", "ju",
        "ka", "ki", "kn", "ks",
        "la", "ld", "le", "li", "lk", "ll", "lm", "lo", "ls",
        "ma", "mb", "me", "mo", "mp", "mu", "my",
        "ne", "nt", "nu", "ny",
        "oa", "oc", "od", "oe", "of", "og", "oh", "oi", "ok", "om", "on", "oo", "op", "or", "os", "ou", "ow", "ox", "oy",
        "pa", "pe", "ph", "pi", "pl", "pp", "ps", "pu", "py",
        "re", "rf", "rk", "ro", "ru", "ry",
        "sc", "se", "sh", "si", "sk", "sl", "sm", "sp", "st", "su", "sw",
        "ta", "th", "ti", "to", "tt", "tw",
        "ue", "ug", "uh", "ui", "uk", "ul", "um", "un", "up", "us", "ut", "uz",
        "va",
        "wa", "we", "wh", "wo", "wr",
        "ya", "ye", "yi", "yo", "yu",
        "za"
    };
    public static string[] alphabet3 = {
    "aal", "abb", "abl", "abo", "abs", "acc", "ace", "ach", "ack", "aco", "adj", "adv", "aff", "aga", "age", "agi", "ago", "ags", "aha", "ail", "air", "ait", "aiv", "aka", "ake", "alm", "alo", "alr", "ama", "amb", "ams", "amu", "and", "ane", "ang", "ank", "ann", "ant", "any", "ape", "app", "aqu", "ara", "ard", "are", "arf", "arp", "ars", "ary", "ask", "asp", "ast", "ate", "atm", "ato", "ats", "att", "aug", "aun", "aur", "aut", "ave", "awe", "awk", "aws", "axe", "ayi", "aze", "azy",
    "bab", "bac", "bad", "bak", "bap", "bar", "bas", "bat", "bea", "bec", "beg", "bei", "ben", "ber", "bey", "bib", "big", "bik", "bin", "bir", "bit", "bla", "ble", "blo", "bod", "bog", "bok", "bom", "boo", "bop", "box", "boy", "bra", "bre", "bru", "buc", "bud", "bug", "bul", "bum", "bun", "bur", "bus", "but", "buy", "bys",
    "cab", "cad", "caf", "cag", "cam", "cas", "cat", "cau", "cav", "ced", "cel", "ceo", "che", "chi", "chu", "cid", "cig", "cir", "cis", "cit", "cks", "cky", "cla", "cle", "coa", "cob", "cof", "coi", "com", "coo", "cor", "cos", "cou", "cov", "cow", "coy", "coz", "cra", "cre", "cri", "cro", "cry", "cub", "cud", "cue", "cul", "cun", "cut", "cya",
    "dab", "dad", "dag", "dal", "dat", "daw", "day", "daz", "ddy", "dea", "deb", "dee", "def", "dei", "del", "dem", "dep", "dev", "dew", "dex", "dge", "dia", "dib", "did", "die", "dig", "dim", "dip", "dir", "dit", "div", "diz", "dna", "dob", "doc", "doe", "dol", "dom", "don", "doo", "dop", "dor", "dos", "dou", "dow", "dox", "dre", "dru", "dub", "duc", "due", "dul", "duo", "dup", "dus", "dye",
    "eaf", "eag", "eak", "eal", "ean", "eap", "ear", "eas", "eat", "eau", "eav", "ebb", "ech", "eck", "edg", "edi", "eef", "een", "eep", "eer", "ees", "eff", "eft", "ego", "eld", "elk", "ell", "elp", "emb", "eme", "emp", "ems", "end", "eng", "ens", "epi", "era", "erb", "erd", "ere", "erf", "erg", "erk", "err", "esc", "ess", "est", "eth", "ets", "eva", "evo", "ews", "exi", "exp", "eye",
    "fac", "fad", "fai", "fak", "fal", "fas", "fav", "fea", "fed", "fem", "fer", "feu", "ffs", "fia", "fib", "fid", "fie", "fig", "fil", "fin", "fir", "fis", "fix", "fla", "fle", "fli", "flu", "fly", "foe", "fog", "foi", "fol", "foo", "for", "fos", "fou", "fox", "fra", "fro", "fru", "fud", "fue", "ful", "fun", "fum", "fur", "fus", "fut",
    "gal", "gan", "gap", "gar", "gat", "gav", "gaw", "gaz", "gee", "gel", "gem", "gen", "ger", "ges", "ggl", "ggy", "gha", "gho", "ght", "gib", "gid", "gig", "gil", "gip", "gir", "gle", "gly", "gno", "goa", "gob", "god", "gog", "gol", "goo", "gor", "gos", "gua", "gue", "gui", "gul", "gut", "guy",
    "hab", "hac", "had", "hag", "hah", "hai", "hal", "ham", "han", "hap", "har", "hat", "hau", "hav", "hay", "haz", "hec", "hen", "hes", "hew", "hid", "hik", "hil", "hip", "hir", "hit", "hoa", "hog", "hol", "hon", "hoo", "hop", "hos", "hov", "hoy", "hub", "hug", "hun", "hup", "hur", "hus", "hut", "hyd", "hye",
    "iar", "ice", "ick", "icy", "ide", "idl", "ido", "ids", "ied", "ief", "ies", "iff", "ift", "ike", "iki", "ild", "ile", "ilk", "ill", "ilt", "imb", "imp", "ims", "inc", "ind", "ine", "inf", "ing", "int", "inv", "iny", "ion", "iot", "ips", "ire", "irm", "iro", "irt", "ish", "isk", "isl", "iso", "iss", "ist", "ita", "ite", "ith", "its", "ive", "iwi",
    "jac", "jag", "jai", "jam", "jan", "jaz", "jee", "jet", "jig", "jit", "job", "jog", "jor", "joy", "jug", "jui", "jum", "jun", "jut",
    "kab", "kai", "kak", "kat", "kaw", "kay", "ked", "kee", "kel", "ken", "kep", "ker", "ket", "kic", "kid", "kif", "kin", "kit", "kne", "kni", "koi",
    "lab", "lac", "lah", "lai", "lak", "lan", "lap", "lar", "las", "lat", "lav", "lax", "lds", "lea", "lec", "led", "lef", "leo", "les", "let", "lew", "lex", "ley", "lib", "lif", "lim", "lin", "lip", "lit", "lls", "lly", "loa", "lob", "loc", "lod", "log", "lol", "lop", "lor", "lot", "lou", "lox", "lts", "luc", "lue", "lug", "luk", "lum", "lun", "lus", "lut", "lux", "lyi", "lyr",
    "mad", "mae", "mag", "mai", "mak", "mal", "man", "mar", "mat", "maw", "mbs", "med", "mee", "meg", "mem", "men", "meo", "mer", "mes", "mew", "mia", "mid", "mig", "mim", "mir", "mit", "mmy", "moa", "moc", "mod", "mog", "moi", "mok", "mom", "mon", "moo", "mot", "mou", "mow", "moy", "mpt", "mud", "mun", "mur", "muz",
    "nab", "nah", "nai", "nak", "nal", "nan", "nap", "naw", "nay", "naz", "nch", "ncy", "nea", "neb", "neg", "neo", "nev", "new", "nex", "ngl", "nie", "nif", "nin", "nit", "nix", "nob", "nog", "noi", "nom", "non", "nop", "nor", "nos", "nov", "now", "nox", "noy", "nud", "nuk", "nun", "nur",
    "oal", "oan", "oap", "oar", "oas", "oba", "obe", "obj", "obo", "obs", "oce", "och", "ock", "odd", "ode", "ods", "oes", "oft", "ogs", "oid", "oil", "ois", "olf", "olk", "oll", "olo", "olt", "oly", "ome", "oms", "ond", "one", "onl", "ont", "ony", "oof", "ook", "ool", "oom", "oon", "oop", "oor", "opi", "opp", "ops", "opt", "ora", "orc", "ore", "org", "ori", "orm", "orn", "ors", "ort", "ory", "osh", "oss", "ost", "ote", "oth", "oto", "ots", "ouc", "oud", "oup", "ous", "ova", "ove", "owe", "owl", "oxo", "oxy", "oze", "ozo",
    "pac", "pad", "pag", "pai", "pal", "pam", "pap", "par", "pas", "pat", "peb", "pec", "peg", "pel", "peo", "pep", "per", "pes", "pew", "pha", "pia", "pin", "pir", "pix", "piz", "pla", "ple", "plo", "ply", "poc", "pod", "pok", "pom", "por", "pov", "pox", "pra", "pre", "pro", "pry", "psi", "psy", "pub", "puf", "pug", "puk", "pum", "pun", "pur", "put", "puz", "pyr",
    "qua", "que", "qui", "quo",
    "rab", "rag", "rai", "ral", "ram", "ran", "rar", "ras", "rav", "raw", "ray", "raz", "reb", "rec", "ree", "reg", "rei", "rej", "rem", "ren", "rep", "rev", "rex", "rch", "rib", "rif", "rig", "rim", "rip", "ris", "rit", "riv", "rms", "rob", "roi", "rol", "ron", "rop", "ros", "rov", "rro", "rse", "rue", "rug", "rul", "rum", "run", "rus", "rye",
    "sab", "sag", "sai", "sal", "sam", "san", "sap", "sar", "sat", "sau", "sav", "saw", "sch", "sci", "sco", "scr", "scu", "see", "seg", "sel", "sem", "sep", "ser", "ses", "sev", "sew", "sha", "sho", "shu", "sic", "sil", "sim", "sip", "sis", "ska", "ske", "ski", "sku", "sla", "slo", "sly", "smi", "smo", "sms", "smu", "sna", "sne", "sni", "sno", "snu", "soa", "sob", "soc", "sof", "sog", "soo", "sos", "sow", "spa", "spi", "spl", "spr", "squ", "ste", "sti", "str", "stu", "sty", "sud", "sue", "suf", "sur", "sus", "swa", "swi",
    "tab", "tac", "tad", "tal", "tam", "tan",  "tar", "tat", "tau", "tax", "tay", "tch", "tea", "tee", "teg", "tes", "tew", "tex", "tha", "the", "thi", "tho", "thr", "thu", "thy", "tid", "tie", "tig", "til", "tip", "tir", "tod", "tog", "tol", "too", "top", "tos", "tow", "tox", "tra", "tre", "tri", "tro", "tru", "tty", "tuc", "tue", "tuf", "tui", "tum", "tut", "twe", "twi", "two",
    "ube", "ubs", "uce", "uch", "uck", "udd", "ude", "uds", "uel", "uga", "uid", "uit", "uke", "ulb", "ulf", "ulk", "ull", "ulp", "umb", "umm", "una", "unc", "und", "ung", "uni", "unk", "unl", "unt", "upd", "upo", "upp", "ups", "urb", "urd", "ure", "urf", "uri", "urk", "urn", "ury", "use", "usk", "ust", "ute", "uts", "utt", "uzz",
    "vac", "vai", "vap", "var", "vas", "vat", "veg", "vei", "vel", "ven", "ver", "ves", "vex", "via", "vib", "vic", "vid", "vil", "vin", "vio", "vis", "vit", "viv", "vog", "voi", "vow", "vul",
    "wab", "wai", "wak", "wal", "wan", "was", "wax", "wea", "wed", "wee", "wer", "wes", "wet", "wha", "wic", "wid", "wil", "wis", "wiv", "wiz", "wol", "wom", "wor", "woo", "wou", "wra", "wri",
    "xam", "xed", "xtr",
    "yag", "yah", "yak", "yar", "yas", "yaw", "yel", "yen", "yin", "yog", "yor", "ype", "yup",
    "zeb", "zen", "zes", "zig", "zin", "zon", "zoo", "zzl"
    };
    int startIndex = 0;
    float holdKeyDownTimer = 0f;
    float holdKeyDownTime = 5f;

    private void Start()
    {
        levelScript = levelSystem.GetComponent<levelSystem>();
        startIndex = Random.Range(0, alphabet1.Length - 3);
        StartRound();
        holdKeyDownTimer = holdKeyDownTime;
    }
    void StartRound()
    {
        startLetters();
    }

    private void Update()
    {
        deleteText();

    }

    public void startLetters()
    {
        if (levelScript.currentLevel == 1)
        {
            theme1.Play();
        }
        if (levelScript.currentLevel == 10)
        {
            theme1.Stop();
            theme2.Play();
        }
        if (levelScript.currentLevel == 20)
        {
            theme2.Stop();
            theme3.Play();
        }
        if (levelScript.currentLevel<=10)
        {
            wordText.text = alphabet1[Random.Range(0, alphabet1.Length - 1)];
        }

        if(levelScript.currentLevel>=10)
        {
            wordText.text = alphabet2[Random.Range(0, alphabet2.Length - 1)];
        }
        if(levelScript.currentLevel>=20)
        {
            wordText.text = alphabet3[Random.Range(0, alphabet3.Length - 1)];
        }
    }
    public void deleteText()
    {
        currentText.text += Input.inputString.ToLower(); //all text blir små bokstäver
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            //holdKeyDownTimer -= Time.deltaTime; //test om man kan hålla in sen erasas allt

            string newText = "";
            if (!Input.GetKey(KeyCode.LeftControl) || holdKeyDownTimer < 0) //om mna håller der kontrol så försvinner all text
            {
                for (int i = 0; i < (currentText.text.Length - 2); i++) //går igenom texten (-2 för att man får error om man inte har)
                {
                    newText += currentText.text.ToCharArray()[i]; //
                }
            }
            currentText.text = newText;
        }
    }
}

    






