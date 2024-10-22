# Tidle defense

Tidle defense is een tower defense game waarbij je kleine bootjes moet gaan kapot maken voordat de bootjes voorbij de rivier gaan. Het doel van het spel is om zo lang mogelijk leven in het spel. De bootjes worden steeds meer en meer sterker, des te langer je zit te spelen. Je torens die je kan plaatsen hebben allemaal verschillende stats van bijvoorbeeld damage of cooldown. 

![image](https://github.com/user-attachments/assets/f8671366-11a0-415d-905e-731fa4825c61)

## SRP en DRY

Bij mijn Enemy script heb ik een list gemaakt waarvan ik verschillende rotaties heb toegevoegd waardoor ik het niet steeds opnieuw hoef opschrijven in mijn code. Alle code dat op Enemy staat hoort gebruik ik voor de wordt gebruikt om mijn enemy prefab te laten bewegen.
[link naar script](https://github.com/notsosaltyasiankid/towerdefense-game/blob/main/first%20tower%20defense%20game/Assets/Script/Enemy.cs)

## Project Root

Dit is de [ROOT](https://github.com/notsosaltyasiankid/towerdefense-game/tree/main/first%20tower%20defense%20game/Assets) folder van mijn unity project.

## Sprites

![Textures Sprites](https://github.com/user-attachments/assets/50451345-b863-4357-984b-f0c10bf5ecd3)

## Issues

[Hier de link naar mijn issues](https://github.com/notsosaltyasiankid/towerdefense-game/issues) Ik had al wel meerdere bugs gehad en had het uiteindelijk hier in de issues gezet.

## Builds
Mijn Builds bestaan uit:

Sprint 1: Ik had alleen de eerste map en de main menu gemaakt.

Sprint 2: Ik maakte een path waarbij enemies het volgt. Ook maakt ik een begin aan de sprites van de torens.

sprint 3: Ik maakte de buttons om de torens te gaan spawnen maar konnen nog niet schieten. Dan ging ik ook nog werken aan de sprites van de enemy.

Tidle defense final build: Als laast ging ik een wave systeem maakte dat oneindig door gaat en maakte nog dat de torens gingen schieten.

## Game design

*  **Je game bevat torens die kunnen mikken en schieten op een bewegend doel.**

Ik heb torens gemaakt waarbij ze verschillende bullets schieten. Die bullets hebben ook een verschil van snelheid en damage. Zelf hebben de torens een verschil van hoeveel het kost om dat dan te bouwen.

*  **Je game bevat vernietigbare vijanden die 1 of meerderen paden kunnen volgen.**

Mijn game bevat alleen 1 enemy dat een klein schip is die 5 hp heeft. Dit wordt dan de heletijd gespawned voor elke wave.

*  **Je game bevat een “wave” systeem waarmee er onder bepaalde voorwaarden (tijd/vijanden op) nieuwe waves met vijanden het veld in komen.**

De wave systeem van mij is endless. Hiermee bedoel ik dat er dan elke keer 10 enemies spawnen en ze worden steeds sterker na elke wave. Het gaat door totdat de player dood gaat.

*  **Een “health” systeem waarmee je levens kunt verliezen als vijanden hun doel bereiken en zodoende het spel kunt verliezen.**

De player kan 10 schepen door laten totdat je uiteindelijk dood gaat. Als dat is dan ga je naar de game over screen waarbij je kan kijken hoelang je het hebt overleeft.

*  **Een “resource” systeem waarmee je resources kunt verdienen waarmee je torens kunt kopen en .evt upgraden.**

De game heeft een scrap systeem waarbij ze elke keer een schip doden dan 10 scrap krijgen om dan uiteindelijk nieuwe torens te gaan kopen.

## Product 9: SCRUM planning inschatting 

Ik gebruikte hier voor een trello om alles in te gaan plannen met sprints
[Link naar trello](https://trello.com/b/b5ySsHrh/tower-defense-trello)
