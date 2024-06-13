# Drawing Your First Spline

Follow these steps to draw your first spline using Spline Plus:

1. **Add Spline Plus FollowerGameObject to Scene**:
   - Navigate to `Tools` > `Spline Plus`.
   - Select `Spline Plus` FollowerGameObject.
   - Go to its inspector.

2. **Editor Mode Initialization**:
   - Since there are no nodes or branches yet, Spline Plus will automatically enable the editor mode to facilitate spline creation.

<div >
    <img alt="Spline Plus" src="../Images/Null_branch.png" style="display: inline-block;" width="450px">
</div>
   - Click anywhere in the Scene View to add your first node.
<div >
    <img alt="Add Node" src="../Images/SplinePlus_AddNodes.gif" style="display: inline-block;" width="480px">
</div>

3. **Add Another Branch**:
   - In the toolbar of the `Spline Plus` FollowerGameObject, navigate to `Branch` > `Add`.
<div >
    <img alt="Add Node" src="../Images/SplinePlus_AddNewBranch.gif" style="display: inline-block;" width="350px">
</div>

4. **Adding Nodes to the New Branch**:
   - Click in the Scene View to add nodes for the newly created branch.
<div >
    <img alt="Add Node" src="../Images/SplinePlus_AddSecondBranch.gif" style="display: inline-block;" width="480px">
</div>

   - Press `Esc` on your keyboard to exit edit mode and switch back to selection mode once you're done adding nodes.

5. **Fusing Nodes**:
   - To connect the selected node to another one in a different branch.
   - Navigate to the `Spline Plus` toolbar, then `Node` > `Fuse`.
   <div >
    <img alt="Add Node" src="../Images/Node_FuseMode.gif" style="display: inline-block;" width="350px">
</div>

   - Click the node you want to fuse with the selected node.
   - A shared node will be created.
<div >
    <img alt="Add Node" src="../Images/Node_Fuse.gif" style="display: inline-block;" width="480px">
</div>

   - You can check the debug area while selecting the shared node to view the shared node index in the selected branch, the connected branches key of the shared node, and the branch key of the currently selected branch.
<div >
    <img alt="Add Node" src="../Images/DebugArea.png" style="display: inline-block;" width="450px">
</div>

6. **Switching Selection Between Connected Branches**:
   - A shortcut to switch selection between the branches connected to the shared node:
     - Make sure you're selecting the shared node.
     - Press `Return` on your keyboard.
<div >
    <img alt="Add Node" src="../Images/Branch_ReturnSelection.gif" style="display: inline-block;" width="450px">
</div>

---

Follow these steps to create your first spline in Spline Plus. Experiment with different nodes and branches to achieve your desired spline shape and complexity.
