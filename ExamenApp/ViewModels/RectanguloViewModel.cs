using System;
using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace ExamenApp
{
    public class RectanguloViewModel : ContentView
    {
        private double _length;
        private double _width;
        private double _area;

        public double Length
        {
            get => _length;
            set
            {
                if (_length != value)
                {
                    _length = value;
                    OnPropertyChanged(nameof(Length));
                    CalculateArea();
                }
            }
        }

        public new double Width
        {
            get => _width;
            set
            {
                if (_width != value)
                {
                    _width = value;
                    OnPropertyChanged(nameof(Width));
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

        public RectanguloViewModel()
        {
            CalculateCommand = new Command(CalculateArea);
            ClearCommand = new Command(Clear);
            ClearAllCommand = new Command(ClearAll);
        }

        private void CalculateArea()
        {
            if (IsValidInput())
            {
                Area = Length * Width;
            }
            else
            {
                Area = 0;
            }
        }

        private void Clear()
        {
            Length = 0;
            Width = 0;
            Area = 0;
        }

        private void ClearAll()
        {
            Length = 0;
            Width = 0;
            Area = 0;
        }

        private bool IsValidInput()
        {
            return Length >= 0 && Width >= 0;
        }
    }
}

