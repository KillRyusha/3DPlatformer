using UnityEngine;
using UnityEngine.UI;

public class SettingsView : MonoBehaviour
{
    [SerializeField] private Slider _masterVolumeSlider;
    [SerializeField] private Slider _musicVolumeSlider;
    [SerializeField] private Slider _effectsVolumeSlider;

    public Slider MasterVolumeSlider => _masterVolumeSlider;
    public Slider MusicVolumeSlider => _musicVolumeSlider;
    public Slider EffectsVolumeSlider => _effectsVolumeSlider;
}