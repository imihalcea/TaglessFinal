# TaglessFinal
Exploration des interpreteurs TaglessFinal

Ce projet experimente les interpreteurs de type Tagless final en utilisant C# comme métalangage.

Les interpreteurs Tagless Final sont un moyen d'introduire et interpreter un langage au sein un langage de programmation 
appele le meta-langage (ex: C#, JS, Java, F# ...). Ils peuvet être utiles pour definir et executer des DSL (domain specific lanaguage) qui sont des langages de plus haut niveau destines à un domaine métier pariculier (calcul scientifique, configuration, calcul finnancier etc...).

Les api fluent (NFluent,Serilog etc..) sont des DSL internes qui s'appuyent sur un meta-langage à l'occurence C#. SQL et CSS par exemple sont également des DSL mais externes au programme. 
