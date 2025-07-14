using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

[AddComponentMenu("Custom/JoinLeaveSounds")]
public class JoinLeaveSounds : UdonSharpBehaviour
{
    [Header("Audio Source")]
    [SerializeField] private AudioSource audioSource;

    [Header("Audio Clips")]
    [Tooltip("Sound played when local player joins")]
    [SerializeField] private AudioClip selfJoinClip;
    [Tooltip("Sound played when another player joins")]
    [SerializeField] private AudioClip otherJoinClip;
    [Tooltip("Sound played when local player leaves")]
    [SerializeField] private AudioClip selfLeaveClip;
    [Tooltip("Sound played when another player leaves")]
    [SerializeField] private AudioClip otherLeaveClip;

    [Header("Playback Settings")]
    [Tooltip("Randomize pitch between min and max")]
    [SerializeField] private bool randomizePitch = false;
    [SerializeField] private Vector2 pitchRange = new Vector2(0.9f, 1.1f);

    [Header("Debug")]
    [SerializeField] private bool debugLog = false;

    public override void OnPlayerJoined(VRCPlayerApi player)
    {
        if (audioSource == null) return;
        PlayClip(player.isLocal ? selfJoinClip : otherJoinClip);
        if (debugLog)
            Debug.Log("[JoinLeaveSounds] " + (player.isLocal ? "Self join" : "Other join: " + player.displayName));
    }

    public override void OnPlayerLeft(VRCPlayerApi player)
    {
        if (audioSource == null) return;
        PlayClip(player.isLocal ? selfLeaveClip : otherLeaveClip);
        if (debugLog)
            Debug.Log("[JoinLeaveSounds] " + (player.isLocal ? "Self leave" : "Other leave: " + player.displayName));
    }

    private void PlayClip(AudioClip clip)
    {
        if (clip == null) return;
        if (randomizePitch)
            audioSource.pitch = Random.Range(pitchRange.x, pitchRange.y);
        audioSource.PlayOneShot(clip);
    }
}
