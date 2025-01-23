EXTERNAL SetDialogueVariable(key, value)
-> Zacatek

== Zacatek ==
    Dobré ráno! Zaspal jsi! Měl bys jít do školy!
    * [Cože? Zaspal jsem?] -> ReakceZaspal
    * [Co tě to zajímá?] -> ReakceZajima
== ReakceZaspal ==
Ano, běž rychle, odemknu ti dveře.
* [Díky!] ->
~ SetDialogueVariable("can_open_door", true)
->NPCFinal
* [Ještě tu chvilku zůstanu.] ->
~ SetDialogueVariable("can_open_door", false)
-> NPCFinal

== ReakceZajima ==
No, jen chci pomoct. Běž už do školy.
* [Díky za starost.] -> 
~ SetDialogueVariable("can_open_door", true)
                ->NPCFinal
* [Tohle není tvoje věc.] -> 
~ SetDialogueVariable("can_open_door", false)
                ->NPCFinal

== NPCFinal ==
-> END