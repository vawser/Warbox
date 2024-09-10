﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudioCore.Utilities;

public static class FontUtils
{
    /// <summary>
    /// Characters to load that FromSoft use, but aren't included in the ImGui Japanese glyph range.
    /// </summary>
    public static char[] SpecialCharsJP =
    {
        '⇒','⑮','⑭','⑲','⑳','⑥','⑤','㎏','⑯','②','①','⑨','⑦','⑰','―','㌃','’','㌦','㌧','㌻','㍉','㍊','㍍','㍑','㍗','㍻','㍼','㍽','㍾','⑫','㌶','Ⅱ','※','⑱','⑧','⑩','⑪','㊤','㊦','㊧','㊨','●','㌍','⑬','㌣','“','”','•','㎎','←','↑','→','↓','蜘','蛛','牢','墟','壷','熔','吊','塵','屍','♀','彷','徨','徘','徊','吠','祀','…','騙','眷','嘘','穢','擲','罠','邂','逅','涜','扁','罹','脆','蠢','繍','蝕','袂','鍮','鴉','嘴','檻','娼','腑','賤','鍔','囁','祓','縋','歪','躯','仇','啜','繋','痺','搦','壺','覗','咆','哮','夥','隕','蹂','躙','詛','哭','捩','嘯','蕩','舐','嗜','僻','裔','贄','抉','鉈','叩','膂','迸','厭','鉾','誂','呆','跪','攫','滲','唸','躊','躇','∞','靭','棘','篝','㌔','㌘','㌢','㌫','③','④','瑕','疵','■','頬','髭','痣','埃','窩','枷','戮','僥','濘','侘','噛','呻','怯','碌','懺','吼','縷','爺','餞','誑','邁','儂','儚','憑','糞','眩','瞞','讐','澹','軛','鶯','瀉','鋤','蝋','⇔','磔','Ω','Ⅰ','賽','渠','瞑','蛆','澱','揶','揄','篭','贖','帷','冑','熾','斃','屠','謳','烙','痒','爛','褪','鑽','矮','傅','虔','瘴','躱','泄','瘤','蟲','燻','滓','蝙','蝠','楔','剥','膿','簒','矜','拗','欒','炸','烽','譚','謐','咬','佇','蜥','蜴','噺','嵌','掴','僭','貶','朧','峙','棍','鋲','鬨','薔','薇','滾','洩','髯','剃','Ⅲ','™','竄','–','誅','掻','愴','鼠','涎','蛭','蛾','贔','屓','鎚','鉤','芒','傀','儡','α','β','γ','礫','♂','○','鍾','囮','踵','誹','囃','碍','鄙','賎','掟','娑','弩','蜀','靄','蛙','轢','嗟','贅','Ⅳ','齧','咎','奢','頚','燐','填','鏃','△','□','謬','諌','憺','媚','垢','宸','憫','蝿','蟇','嚢','─','悶','櫃','咳','狗','艱','倅','箪','淤','飴','梟','曰','仄','呟','吽','刎','鬘','睨','鈷','屏','汞','翡','籃','蝉','箒','猩','埒','閂','癪','皺','憚','杞','甕','弑','祟','狐','貉','撓','褄','★','祠','廠','燼','衒','狸','酩','酊','殲','鹵','閾','謗','—','한','국','어','體','简','Р','у','с','к','и','й','언','변','경','최','종','사','용','자','라','이','선','스','계','약','개','인','정','보','처','리','방','침','데','터','에','관','동','의','페','지','넘','기','택','실','행','닫','하','다','거','절','變','權','隱','擇','關','语','变','终','户','许','协','议','隐','游','戏','换','页','选','择','执','关','闭','ę','Ż','Ń','Ś','ż','ź','ń','П','а','р','м','е','т','ы','я','з','Л','И','Ц','Е','Н','З','О','С','Г','А','Ш','К','Ч','Ы','М','Ь','В','Т','Ф','Д','о','г','л','ш','н','б','п','ь','в','д','х','Я','ю','猜','諜','聘','站','腿','恫','賁','戈','絨','毯','攪','倶','洒','掩','頸','懣','愾','啼','狽','捌','頷','轍','輜','儘','淘','餐','廓','撹','飄','坩','堝','屹','鬣','孕','痾','衾','聳','嘶','疼','蠅','茹','朦','鹸','閨','闢','竦','焉','斂','蛹','蜃','孵','蟻','癌','瘡','蠍','鋏','讒','姦','仗','拵','跋','扈','鮫','笏','錨','銛','撻','⟪','⟫','ภ','า','ษ','​','ไ','ท','ย','禿','驟','咥','慟','糺','麾','藉','蠱','奸','躾','吝','嗇','孺','濾','滸','訝','煽','蛸','‐','恍','隧','臍','蟷','螂','蜷','œ','„','업','트','년','월','일','본','을','신','중','게','읽','으','십','시','오','귀','가','당','임','또','는','서','비','접','근','나','를','것','은','술','된','모','든','조','건','그','고','참','급','통','해','부','루','구','속','되','로','함','미','합','니','러','두','않','우','마','재','항','제','과','집','단','소','송','포','있','며','외','역','주','들','적','습','독','특','됩','세','내','및','확','유','럽','연','호','북','남','칭','와','멀','티','플','레','온','면','전','문','콘','텐','츠','운','드','능','련','위','액','입','판','매','아','여','대','명','권','른','품','존','떤','식','도','키','추','혹','삭','공','요','금','청','차','프','션','규','칙','음','징','될','수','달','룹','상','충','체','결','립','따','치','같','취','뒤','안','완','히','준','할','법','성','령','만','후','견','야','코','등','록','넷','디','털','못','작','반','영','컬','컴','퓨','웨','랫','폼','크','웃','됨','했','간','점','직','배','타','양','불','널','버','별','예','범','느','허','락','복','목','분','석','설','파','셈','블','발','생','물','저','알','렵','벗','회','폐','래','텍','픽','진','화','템','열','산','더','장','없','족','효','각','써','무','런','책','즉','료','환','받','량','새','메','승','필','획','득','럼','철','교','줄','혀','향','칠','격','증','익','원','현','려','져','색','출','활','걸','쳐','누','평','찬','킬','표','검','토','감','때','론','퇴','훼','손','욕','쾌','란','노','골','괴','롭','협','박','퍼','학','킹','편','밀','광','력','뜨','팸','류','봇','뮬','움','순','올','네','워','끊','밖','었','바','담','닙','황','팩','질','형','태','천','애','묵','롯','므','강','축','쟁','패','큼','까','백','민','초','험','망','멸','휴','벌','총','높','테','심','탈','병','엄','앞','울','엇','닌','탕','겠','뿐','냄','납','긴','날','찍','름','번','케','팅','념','엔','캘','섭','랑','클','카','갖','쿄','옹','탁','머','잔','너','캔','르','객','갱','컨','롤','짜','릴','홈','살','펴','벨','델','브','뉴','밍','센','랭','글','균','맞','춥','랍','돕','응','답','벤','링','좋','탐','률','채','턴','웹','믿','옵','난','람','떠','곳','낼','閱','讀','們','您','處','豁','歐','澳','稱','雙','說','內','屬','售','會','產','刪','絕','銷','另','發','點','參','當','效','區','齡','對','號','續','數','腦','經','據','獨','譯','圖','找','碼','衍','檔','沒','滿','隨','仍','繼','兌','值','賺','賬','戶','圍','佔','稅','做','聲','譽','歸','擔','查','佈','雖','猥','褻','擾','勵','攬','假','僱','聯','亂','喊','寫','垃','圾','缺','礙','斷','幫','贏','證','贊','輕','濟','潛','兩','址','份','釋','簽','遞','餘','啟','你','窗','瀏','舉','營','估','獎','趨','聊','辨','隸','竊','请','细','阅','读','访','问','们','务','处','约','这','节','为','则','适','于','详','见','亚','订','进','并','网','络','发','线','载','书','电','该','权','产','删','确','绝','张','贴','费','结','销','规','说','间','冲','类','缔','签','实','决','过','显','获','时','经','达','辖','龄','监','护','须','对','册','续','连','联','损','运','设','备','统','帐','拥','话','转','让','补','带','况','复','个','业','编','译','汇','试','图','寻','码','创','标','计','范','围','它','尝','饰','义','软','币','拟','档','财','识','现','满','毁','负','责','暂','还','购','买','无','继','视','邮','应','紧','货','专','门','兑','价','际','认','响','赚','赎','额','赠','赁','员','账','开','弃','频','项','广','传','赔','偿','资','归','错','误','论','违','审','储','报','虽','辑','从','给','诽','谤','伤','秽','亵','骚','扰','胁','滥','动','诈','种','揽','输','坛','领','导','陈','坏','优','势','骗','仿','维','难','击','败','帮','赢','赛','卖','师','东','证','质','赞','荐','颁','样','减','强','竞','仅','测','诺','长','严','伙','惩','罚','润','轻','坚','众','调','构','济','诉','讼','团','纠','纷','讯','别','组','较','两','亲','阶','级','针','释','预','递','题','记','录','营','赋','圣','县','杂','夺','启','扫','忆','侦','浏','览','阐','顶','沟','态','评','术','奖','兴','闻','趋','检','顾','绍','单','织','丢','链','齐','异','ć','Ę','Ć','Ą','Ł','ą','ł','ś','Ź','Й','Э','У','Ж','Б','Ю','Щ','Х','ж','ф','ц','ч','щ','э','ъ','Ъ','เ','ล','ื','','อ','น','ก','ด','ํ','ิ','ร','ป','ี','ม','ั','บ','่','','ข','้','ต','ง','ใ','ห','ส','ธ','','แ','ผ','ู','ช','จ','ุ','ค','','ณ','ถ','ึ','ะ','พ','ว','ญ','โ','ซ','ศ','ฐ','','ฏ','์','ๆ','็','ฉ','ฑ','ฎ','ฟ','','','ฮ','','ฝ','','','ฆ','ฌ','ฤ','ฯ','ฒ','','鎗','≪','≫','隘','髑','髏'
    };
}
