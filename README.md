# TaglessFinal
Exploration des interpréteurs TaglessFinal

Ce projet expérimente les interpréteurs de type Tagless final en utilisant C# comme métalangage.

Les interpréteurs Tagless Final sont un moyen d'introduire et interpréter un langage au sein un langage de programmation 
appelé le méta-langage (ex: C#, JS, Java, F# ...). Ils peuvent être utiles pour définir et exécuter des DSL (domain specific language) qui sont des langages de plus haut niveau destines à un domaine métier particulier (calcul scientifique, configuration, calcul financier etc...).

Les api fluent (NFluent,Serilog etc..) sont des DSL internes qui s’appuient sur un méta-langage à l’occurrence C#. 

SQL et CSS par exemple sont également des DSL externes au programme. 

Principale source d'inspiration se trouve ici: https://github.com/user-signal/tagless-final-lambda-lille
