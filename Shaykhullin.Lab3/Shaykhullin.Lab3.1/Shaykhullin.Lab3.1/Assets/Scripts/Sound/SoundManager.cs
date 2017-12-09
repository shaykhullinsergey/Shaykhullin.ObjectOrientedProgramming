using UnityEngine;
using System.Linq;
using System.Collections.Generic;

public class SoundManager : Manager<SoundManager>
{
  public override bool DestroyOnLoad => false;

  [SerializeField] private AudioSource ambientChannel;

  [SerializeField] private AudioSource soundEffectsChannel1;
  [SerializeField] private AudioSource soundEffectsChannel2;
  [SerializeField] private AudioSource soundEffectsChannel3;

  [SerializeField] private List<AudioClip> menuAmbient;
  [SerializeField] private List<AudioClip> gameAmbient;

  [SerializeField] private List<AudioClip> hydrantAppear;
  [SerializeField] private List<AudioClip> hydrantEndTurn;
  [SerializeField] private List<AudioClip> notificationAppear;
  [SerializeField] private List<AudioClip> pipeItemAppear;
  [SerializeField] private List<AudioClip> pipeItemSelected;
  [SerializeField] private List<AudioClip> pipeRendererStart;
  [SerializeField] private List<AudioClip> pipeRendererEnd;
  [SerializeField] private List<AudioClip> buttonClicked;
  [SerializeField] private List<AudioClip> minigameAppear;
  [SerializeField] private List<AudioClip> gameOverAppear;
  [SerializeField] private List<AudioClip> pipeDecorationClick;
  [SerializeField] private List<AudioClip> hydrantDecorationClick;
  [SerializeField] private List<AudioClip> r2d2DecorationClicked;
  [SerializeField] private List<AudioClip> resetSelected;
  [SerializeField] private List<AudioClip> daladno;

  public void PlayMenuAmbient()
  {
    if(ambientChannel.clip != menuAmbient.First())
      Play(ambientChannel, menuAmbient);
  }
  public void PlayGameAmbient()
  {
    if (ambientChannel.clip != gameAmbient.First())
      Play(ambientChannel, gameAmbient);
  }
  public void PlayHydrantAppear() => Play(soundEffectsChannel1, hydrantAppear);
  public void PlayHydrantEndTurn() => Play(soundEffectsChannel2, hydrantEndTurn);
  public void PlayNotificationAppear() => Play(soundEffectsChannel1, notificationAppear);
  public void PlayMinigameAppear() => Play(soundEffectsChannel2, minigameAppear);
  public void PlayerGameOverAppear() => Play(soundEffectsChannel1, gameOverAppear);
  public void PlayButtonClicked() => Play(soundEffectsChannel1, buttonClicked);
  public void PlayPipeRendererStart() => Play(soundEffectsChannel2, pipeRendererStart);
  public void PlayPipeRendererEnd() => Play(soundEffectsChannel1, pipeRendererEnd);
  public void PlayPipeItemAppear() => Play(soundEffectsChannel1, pipeItemAppear);
  public void PlayPipeItemSelected() => Play(soundEffectsChannel1, pipeItemSelected);
  public void PlayPipeDecorationClicked() => Play(soundEffectsChannel1, pipeDecorationClick);
  public void PlayHydrantDecorationClicked() => Play(soundEffectsChannel1, hydrantDecorationClick);
  public void PlayR2D2DecorationClicked() => Play(soundEffectsChannel1, r2d2DecorationClicked);
  public void PlayResetSelected() => Play(soundEffectsChannel1, resetSelected);
  public void PlayDaladno() => Play(soundEffectsChannel3, daladno);

  private void Play(AudioSource channel, List<AudioClip> clip)
  {
    channel.clip = clip[Random.Range(0, clip.Count)];
    channel.pitch = Random.Range(0.9f, 1.1f);
    channel.Play();
  }

  public void UpdateVolumeSettings()
  {
    soundEffectsChannel1.volume 
      = soundEffectsChannel2.volume
      = ambientChannel.volume 
      = (float)Settings.SoundVolume / 100;
  }
}
