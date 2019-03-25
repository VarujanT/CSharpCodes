interface IDrawable
    {
        void DrawOnWindow();
    }
    interface IPrintable
    {
        void Print();
    }
    interface IDrawOnMemory : IDrawable, IPrintable
    {
        void DrawOnMemory();
    }