<a name='assembly'></a>
# BibliothèqueDeGestionDePersonnage

## Contents

- [Personnage](#T-BibliothèqueDeGestionDePersonnage-Personnage 'BibliothèqueDeGestionDePersonnage.Personnage')
  - [#ctor(nom,pv,armure)](#M-BibliothèqueDeGestionDePersonnage-Personnage-#ctor-System-String,System-Int32,System-Int32- 'BibliothèqueDeGestionDePersonnage.Personnage.#ctor(System.String,System.Int32,System.Int32)')
  - [Armure](#P-BibliothèqueDeGestionDePersonnage-Personnage-Armure 'BibliothèqueDeGestionDePersonnage.Personnage.Armure')
  - [Nom](#P-BibliothèqueDeGestionDePersonnage-Personnage-Nom 'BibliothèqueDeGestionDePersonnage.Personnage.Nom')
  - [PV](#P-BibliothèqueDeGestionDePersonnage-Personnage-PV 'BibliothèqueDeGestionDePersonnage.Personnage.PV')
  - [SubbitDegat(degat)](#M-BibliothèqueDeGestionDePersonnage-Personnage-SubbitDegat-System-Int32- 'BibliothèqueDeGestionDePersonnage.Personnage.SubbitDegat(System.Int32)')

<a name='T-BibliothèqueDeGestionDePersonnage-Personnage'></a>
## Personnage `type`

##### Namespace

BibliothèqueDeGestionDePersonnage

##### Summary

Cette classe représente des personnages dans un jeu de combat.

```
    Personnage personnage = new Personnage("Patrick", 10, 2);
    personnage.SubbitDegat(5);
```

<a name='M-BibliothèqueDeGestionDePersonnage-Personnage-#ctor-System-String,System-Int32,System-Int32-'></a>
### #ctor(nom,pv,armure) `constructor`

##### Summary

Constructeur à paramètre pour instancier un personnage.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| nom | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Le nom du personnage |
| pv | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Le nombre de point de vie du personnage |
| armure | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | La force de l'armure du personnage |

<a name='P-BibliothèqueDeGestionDePersonnage-Personnage-Armure'></a>
### Armure `property`

##### Summary

Armure du personnage.

<a name='P-BibliothèqueDeGestionDePersonnage-Personnage-Nom'></a>
### Nom `property`

##### Summary

Nom du personnage.

<a name='P-BibliothèqueDeGestionDePersonnage-Personnage-PV'></a>
### PV `property`

##### Summary

Points de vie du personnage.

<a name='M-BibliothèqueDeGestionDePersonnage-Personnage-SubbitDegat-System-Int32-'></a>
### SubbitDegat(degat) `method`

##### Summary

Cette fonction permet au personnage de subir des dégats.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| degat | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Nombre de dégat que le personnage va subir. |
