EXTERNAL SetDialogueVariable(key, value)
-> Skola

== Skola ==
Ahoj! Dělal jsem si srandu, dnes není výuka! Chtěl jsem tě jen, abys prozkoumal novou školu, do které budeš chodit!"
* ["Aha to je zajímavý."] -> ReakceZmateni
* ["Takže není výuka?"] -> ReakceNeniVyuka

== ReakceZmateni ==
No, to byla jen legrace. Tohle je opravdu nová škola."
* ["Tak to je fajn."] ->
~ SetDialogueVariable("visited_school", true)
-> NPCFinal
* ["Nevím, co si o tom myslet."] ->
~ SetDialogueVariable("visited_school", true)
-> NPCFinal

== ReakceNeniVyuka ==
NPC: "Ne, škola začíná až zítra! Dneska si tu můžeš prohlédnout všechno nové."
* ["Nechci nic vědět."] -> 
~ SetDialogueVariable("visited_school", true)
-> NPCFinal
* ["Dobře jdu se vyspat."] -> 
~ SetDialogueVariable("visited_school", true)
-> NPCFinal

== NPCFinal ==
-> END