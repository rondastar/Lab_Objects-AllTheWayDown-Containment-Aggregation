using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Objects_AllTheWayDown_Containment_Aggregation
{
    internal class Sunglasses
    {
        public enum InterchangeableLenses { yes, no }
        public enum BestUse { fashion, athletic }

        BestUse _bestUse;
        InterchangeableLenses _interchangeableLenses;
        Frames _frames;
        Lenses _lenses;
        decimal _price;

        internal BestUse BestUse1 { get => _bestUse; set => _bestUse = value; }
        internal InterchangeableLenses InterchangeableLenses1 { get => _interchangeableLenses; set => _interchangeableLenses = value; }
        internal Frames Frames { get => _frames; set => _frames = value; }
        internal Lenses Lenses { get => _lenses; set => _lenses = value; }
        public decimal Price { get => _price; }

        public Sunglasses(BestUse bestUse, InterchangeableLenses interchangeableLenses, decimal price, Frames frames, Lenses lenses)
        {
            _bestUse = bestUse;
            _interchangeableLenses = interchangeableLenses;
            _price = price;
            _frames = frames;
            _lenses = lenses;
        }

    } // class

    //// Sunglasses class from previous assignment
    //     internal class Sunglasses
    //  {
    //        public enum InterchangeableLenses { yes, no }
    //    public enum BestUse { fashion, athletic }

    //    int _numberOfLenses;
    //    int _UVProtection;
    //    string _brand;
    //    string _lensColor;
    //    string _frameColor;
    //    float _widthOfFramesInInches;
    //    InterchangeableLenses _interchangeableLenses;
    //    BestUse _bestUse;
    //    decimal _price;

    //    public int NumberOfLenses { get => _numberOfLenses; set => _numberOfLenses = value; }
    //    public int UVProtection { get => _UVProtection; set => _UVProtection = value; }
    //    public string Brand { get => _brand; set => _brand = value; }
    //    public string LensColor { get => _lensColor; set => _lensColor = value; }
    //    public string FrameColor { get => _frameColor; set => _frameColor = value; }
    //    public float WidthOfFramesInInches { get => _widthOfFramesInInches; set => _widthOfFramesInInches = value; }
    //    internal InterchangeableLenses InterchangeableLenses1 { get => _interchangeableLenses; set => _interchangeableLenses = value; }
    //    internal BestUse BestUse1 { get => _bestUse; set => _bestUse = value; }
    //    public decimal Price { get => _price; }

    //    public Sunglasses(int numberOfLenses, int uVProtection, string brand, string lensColor, string frameColor, float widthOfFramesInInches, InterchangeableLenses interchangeableLenses, BestUse bestUse, decimal price)
    //    {
    //        _numberOfLenses = numberOfLenses;
    //        _UVProtection = uVProtection;
    //        _brand = brand;
    //        _lensColor = lensColor;
    //        _frameColor = frameColor;
    //        _widthOfFramesInInches = widthOfFramesInInches;
    //        _interchangeableLenses = interchangeableLenses;
    //        _bestUse = bestUse;
    //        _price = price;
    //    }
    //  }
} // namespace
