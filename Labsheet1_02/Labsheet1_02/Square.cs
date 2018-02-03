namespace Labsheet1_02
{
    class Square
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public double Area {  get { return Width * Height; } }


        public Square(double width = 0, double height = 0)
        {
            Width = width;
            Height = height;
        }
    }
}
