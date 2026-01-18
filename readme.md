Rewrite of FSMViewAvalonia. Should work on any FSM game.

![FSMExpress](screenshot.png)

Usage for Silksong:

1. Config-&gt;Set game path to `Hollow Knight Silksong_Data` folder
2. If opening non-`scenes_scenes_scenes` files first, File-&gt;Open Bundle, select `Hollow Knight Silksong_Data/StreamingAssets/aa/Standalone<os>/<hash>_monoscripts.bundle`, then close the empty dialog box.
3. Open bundles in the `Standalone<os>` or `Standalone***/scenes_scenes_scenes` folders. Note that not all bundles have FSMs.

You should **not** use the File-&gt;Open scene list option at this time. It only works for games where scenes are not stored with Addressables.


Downloads:

- https://nightly.link/nesrak1/FSMExpress/workflows/build-ubuntu/skong/fsmexpress-ubuntu.zip
- https://nightly.link/nesrak1/FSMExpress/workflows/build-windows/skong/fsmexpress-windows.zip
