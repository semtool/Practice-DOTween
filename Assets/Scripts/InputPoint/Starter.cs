using UnityEngine;

public class Starter : MonoBehaviour
{
    [SerializeField] private MovingItem _mover;
    [SerializeField] private RotatingItem _rotator;
    [SerializeField] private ScalableItem _scaller;
    [SerializeField] private ColoringItem _colorer;
    [SerializeField] private MultiFunctionalItem _multiCube;

    private int _infiniteNumberCycles = -1;

    void Start()
    {
        _mover.StartActivity(_infiniteNumberCycles);

        _rotator.StartActivity(_infiniteNumberCycles);

        _scaller.StartActivity(_infiniteNumberCycles);

        _colorer.StartActivity(_infiniteNumberCycles);

        _multiCube.StartActivity(_infiniteNumberCycles);
    }
}