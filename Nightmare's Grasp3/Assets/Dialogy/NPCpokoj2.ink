EXTERNAL SetDialogueVariable(key, value)
-> Pokoj

== Pokoj ==
Doufám, že jsi si užil prohlídku školy! Těším se, až tě příště uvidím.

* [Byla to zajímavá prohlídka.] -> ReakceZajimavo
* [Není to moje věc.] -> ReakceNemusim

== ReakceZajimavo ==
Jsem rád, že se ti líbilo! Příště to bude ještě lepší!
* [Určitě.] -> NPCFinal
* [Uvidíme.] -> NPCFinal

== ReakceNemusim ==
No, to je škoda. Ale příště to snad bude lepší.
* [To zjistíš.] -> NPCFinal
* [Už jdu pryč.] -> NPCFinal

== NPCFinal ==
-> END  
