namespace Basics
{
    public static class AlmondExtensions
    {
        public static bool isAlmond(Almond almond)
        {
            return almond.getWeight() > 10 && almond.getSize() < 10;
        }
    }
}