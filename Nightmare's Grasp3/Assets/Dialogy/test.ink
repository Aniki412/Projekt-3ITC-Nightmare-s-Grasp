EXTERNAL SetDialogueVariable(key, value)
-> Zacatek
== Zacatek ==

Ahoj!

* ["Kdo jsi?"] -> OdpovedKdoJsi
* ["Co děláš v mém pokoji?"] -> OdpovedCoDelas

== OdpovedKdoJsi ==
Jsem tvůj odraz, koukáš do zrcadla...

* ["Proč můžeš mluvit?"] -> OdpovedProcMluvis
* ["Zbláznil jsem se?"] -> OdpovedZblaznil

== OdpovedCoDelas ==
Je to i můj pokoj.

* ["Proč můžeš mluvit?"] -> OdpovedProcMluvis
* ["Zbláznil jsem se?"] -> OdpovedZblaznil

== OdpovedProcMluvis ==
Protože byl někdo líný udělat modely.

* ["Už radši zmiz."]-> NPCFinal
* ["Radši otevři dveře!"]-> 
                ~ SetDialogueVariable("can_open_door", true)
                ->NPCFinal

== OdpovedZblaznil ==
Nezbláznil, ale brzo to přijde.

* ["Nech mě na pokoji!"] -> NPCFinal
* ["Radši otevři dveře!"]-> 
                ~ SetDialogueVariable("can_open_door", false)
                ->NPCFinal

== NPCFinal ==
Ty víš, že to nepůjde.

-> END
