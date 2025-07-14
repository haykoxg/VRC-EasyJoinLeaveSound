# JoinLeaveSounds

Simple UdonSharp script to play audio clips when players join or leave in VRChat.

## Installation

1. Copy `JoinLeaveSounds.cs` into your Unity project under `Assets/Scripts/`.
2. Attach the `JoinLeaveSounds` component to an active GameObject in the scene.
3. Assign an `AudioSource` and the four audio clips in the Inspector.

## Inspector Fields

| Field             | Type            | Description                                               |
|-------------------|-----------------|-----------------------------------------------------------|
| `Audio Source`    | AudioSource     | Component used for clip playback.                         |
| `selfJoinClip`    | AudioClip       | Sound when local player joins.                            |
| `otherJoinClip`   | AudioClip       | Sound when another player joins.                          |
| `selfLeaveClip`   | AudioClip       | Sound when local player leaves.                           |
| `otherLeaveClip`  | AudioClip       | Sound when another player leaves.                         |
| `Randomize Pitch` | bool            | Toggle pitch randomization.                               |
| `Pitch Range`     | Vector2         | Min/Max pitch when randomizing.                           |
| `Debug Log`       | bool            | Enable console debug messages for join/leave events.      |

## Usage

Once configured, the script automatically plays the appropriate audio clip on player join and leave events. No further setup is needed.

## License

This project is licensed under the MIT License. Feel free to use, modify, and distribute.

Courtesy of Icarus Armories 
