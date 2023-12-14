using System.Windows.Input;

namespace ExamenApp.ViewModels;

public class CirculoViewModel : ContentView
{
            private double _radio;
            private double _area;

            public double Radio
            {
                get => _radio;
                set
                {
                    if (_radio != value)
                    {
                        _radio = value;
                        OnPropertyChanged(nameof(Radio));
                        CalculateArea();
                    }
                }
            }

            public double Area
            {
                get => _area;
                set
                {
                    if (_area != value)
                    {
                        _area = value;
                        OnPropertyChanged(nameof(Area));
                    }
                }
            }

            public ICommand CalculateCommand { get; }
            public ICommand ClearCommand { get; }
            public ICommand ClearAllCommand { get; }

            public CirculoViewModel()
            {
                CalculateCommand = new Command(CalculateArea);
                ClearCommand = new Command(Clear);
                ClearAllCommand = new Command(ClearAll);
            }

            private void CalculateArea()
            {
                if (IsValidInput())
                {
                    Area = Math.PI * Math.Pow(Radio, 2);
                }
                else
                {
                    Area = 0;
                }
            }

            private void Clear()
            {
                Radio = 0;
                Area = 0;
            }

            private void ClearAll()
            {
                Radio = 0;
                Area = 0;
            }

            private bool IsValidInput()
            {
                return Radio >= 0;
            }
}
