# Unity-Moving-Circle-Simulate-Keypress
**How does it work?**

**InputCtrl.SimKeyPressBool()** is an alternative to Unity's **Input.GetKey()**.

GUIButton gets the correct *KeyCode** by parsing its text component. Then on the button press this *KeyCode* is added to the declared *HashSet* **ForcedKeys**. The **InputCtrl.SimKeyPressBool** checks if **ForcedKeys** contains the *KeyCode* and returns *bool* accordingly.

**Why HashSet?**

It provides O(1) search, insertion and deletion.
