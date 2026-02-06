# CS417 VR Room Demo
CS 417 – MP0: The Room
Unity Version: Unity 6 (6000.3.5f2)
Platform Build Included: macOS

1) What’s included in this submission
- Video demo: MP0_Demo.mp4
- Standalone build (macOS): MP0_Build_macOS.app (inside the MP0_Build_macOS/ folder)
- README.txt (this file)

2) How to run
macOS build:
1. Open the folder: MP0_Build_macOS/
2. Double-click: MP0_Build_macOS.app

Note: If macOS blocks opening, right-click the app -> Open -> Open again.

3) Controls (Keyboard testing + XR bindings)
I implemented keyboard testing controls and XR controller bindings (via XRI input actions).

A) Quit / Exit
- Keyboard: ESC quits (stops Play Mode in Editor / quits in build)
- XR controller action: Bound to an XRI action (e.g., XRI Right Interaction/Select) via QuitManager + QuitAction script.

B) Light color change (center point light)
- Keyboard: T toggles the point light color
- XR controller action: Bound to an XRI action (controller button) to trigger the same color change behavior.

C) Inside <-> Outside viewpoint switch (Breakout)
- Keyboard (for testing): B toggles between inside and outside viewpoints
- XR controller action: Can be bound to an XRI action; script references InsidePoint and OutsidePoint and moves the XR Origin accordingly.

4) Features demonstrated in the video
1. The center point light and that it can change color
2. The planet and moon at the center
3. The text (HELLO)
4. The walls in the order specified in point 1.7
5. Switch to the outside point of view and show the skybox
6. Any additional work (if applicable)
7. Press the quit key/action to exit and end recording

5) Project link
GitHub repo: [PASTE YOUR GITHUB LINK HERE](https://github.com/KaiaZhang420/CS417_HW1_Room)
(If the repo is incomplete due to file-size limits, all required deliverables are included in this submission zip.)

6) Notes
- Tested using XR Device Simulator in Unity Editor on macOS.
- macOS standalone build is included.
