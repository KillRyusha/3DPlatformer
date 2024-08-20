using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Timeline;
using UnityEngine.UI;

public class SoundSettingsController : MonoBehaviour
{
    [SerializeField] private AudioMixer _masterMixer;
    [SerializeField] private SettingsView _settingsView;
    private SoundSettingsModel _model;

    private void Awake()
    {
        _model = new SoundSettingsModel();
        InitSlider(_settingsView.MasterVolumeSlider, GameStatsConsts.MASTER, _model.MasterVolume);
        InitSlider(_settingsView.MusicVolumeSlider, GameStatsConsts.MUSIC, _model.MusicVolume);
        InitSlider(_settingsView.EffectsVolumeSlider, GameStatsConsts.EFFECTS, _model.EffectsVolume);
    }
    private void Start()
    {
        SetMixers();
    }
    private void OnDisable()
    {
        GameEnd(GameStatsConsts.MASTER);
        GameEnd(GameStatsConsts.MUSIC);
        GameEnd(GameStatsConsts.EFFECTS);
    }
    private void SetMixers()
    {
        ChangeVolume(_model.MasterVolume, GameStatsConsts.MASTER);
        ChangeVolume(_model.MusicVolume, GameStatsConsts.MUSIC);
        ChangeVolume(_model.EffectsVolume, GameStatsConsts.EFFECTS);
    }

    private void GameEnd(string soundGroup)
    {
        float volume = 0;
        _masterMixer.GetFloat(soundGroup, out volume);
        PlayerPrefs.SetFloat(soundGroup, volume);
    }

    private void InitSlider(Slider slider, string soundGroup, float groupVolume)
    {
        slider.onValueChanged.AddListener(
            (volume) => ChangeVolume(volume, soundGroup));
        slider.value = groupVolume;
    }

    private void ChangeVolume(float volume, string soundGroup)
    {
        _masterMixer.SetFloat(soundGroup, volume);
    }

}