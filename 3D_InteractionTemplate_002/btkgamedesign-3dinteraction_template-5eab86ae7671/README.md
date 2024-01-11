# 3D Interaction Template - Game Design // UE

## Unity Version
This Project uses **Unity version 2021.3.10**.

## How To (English)

<u>Test the template:</u>

*  open the "Example" scene and press play
*  controls: Q/E for camera turning and clicking objects to interact with them

<u>Create content with the template:</u>

* if it is a new scene delete the main camera
* add the 'InteractionTemplate' prefab (from the prefab folder) to the scene
* place interactable prefabs in the scene for every desired interactable object
* it can make sense to make prefab variants or separate prefabs for these objects
* replace the child called 'cube' with whatever visuals you desire, also adjust the collider on the Interactable base object to fit the visuals
* define the text that should be displayed when clicking the object in the Text component on the 'PopupText' GameObject, which is the child of the 'TextCanvas'
* define the AnimationClip that should be played when the object is clicked on the 'Interactable' component
* adjust the Cinemachine Virtual Camera's body settings and the CameraTarget's rotation speed if necessary


## How To (Deutsch)

<u>Das Template testen:</u>

*  Öffnen Sie die Szene "Example" und drücken Sie Play.
*  Steuerung: Q/E zum Drehen der Kamera und Anklicken von Objekten, um mit ihnen zu interagieren.

<u>Inhalte mit dem Template erstellen:</u>

* Wenn Sie eine neue Szene erstellt haben, löschen Sie die MainCamera.
* Fügen Sie das Prefab 'InteractionTemplate' (aus dem Prefab-Ordner) zur Szene hinzu.
* Platzieren Sie ein 'Interactable' Prefab in der Szene für jedes Objekt das eine Interaktion haben soll.
* Dieser ist editierbar in der Komponente 'Text' auf dem GameObject "PopupText" klickt, das ein child des 'TextCanvas' ist (dieser ist Standardmäßig inaktiv, schalten Sie dieses kurz an, editieren sie und schalten sie es wieder inaktiv)
* Definieren Sie den AnimationClip, der abgespielt werden soll, wenn das Objekt auf der 'Interactable'-Komponente angeklickt wird
* Es kann sinnvoll sein Prefab Varianten oder separate Prefabs für diese Objekte zu erstellen.
* Passen Sie die 'Body'-Settings der Virtuellen Cinemachine Kamera und den 'Rotationspeed' des CameraTargets an, falls erforderlich.
* Fertig!
* Drücke Sie Play in geniessen Sie die interaktive Szene
* Ersetzen Sie das child Objekt names 'Cube' mit den gewünschten Modellen, passen sie auch den Collider auf dem 'Interactable' Basisobjekt an.
* Definieren Sie den Text, der angezeigt werden soll, wenn man auf das Objektklickt

## Credits

* **Sebastian Stamm** - <http://www.the-stamm.com/wordpress/>
* **Benjamin Rose** - benjamin.rose141@gmail.com


## License

Free to use for any students and lecturers of the GameDesign program at UE Germany.