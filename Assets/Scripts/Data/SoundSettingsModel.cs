using UnityEngine;

public class SoundSettingsModel
{
    private float _masterVolume;
    private float _musicVolume;
    private float _effectsVolume;

    public SoundSettingsModel()
    {
        _masterVolume = PlayerPrefs.GetFloat(GameStatsConsts.MASTER, -20);
        _musicVolume = PlayerPrefs.GetFloat(GameStatsConsts.MUSIC, -20);
        _effectsVolume = PlayerPrefs.GetFloat(GameStatsConsts.EFFECTS, -20);
    }

    public float MasterVolume { get => _masterVolume; set => _masterVolume = value; }
    public float MusicVolume { get => _musicVolume; set => _musicVolume = value; }
    public float EffectsVolume { get => _effectsVolume; set => _effectsVolume = value; }
}