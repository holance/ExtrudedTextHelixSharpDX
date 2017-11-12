using HelixToolkit.Wpf.SharpDX;
using SharpDX;
using System.Windows;
using Point3D = global::SharpDX.Vector3;

namespace ExtrudedTextHelixSharpDX
{
    public class MainViewModel
    {
        public Color4 LightColor { set; get; } = Color.White;

        public MeshGeometry3D Model { set; get; }

        public Material Material { get; } = PhongMaterials.Bronze;

        public MainViewModel()
        {
            var builder = new MeshBuilder(true);
            builder.ExtrudeText(
                "Helix Toolkit",
                "Arial",
                FontStyles.Normal,
                FontWeights.Bold,
                20,
                new Vector3(1, 0, 0),
                new Point3D(0, 0, 0),
                new Point3D(0, 0, 1));
            Model = builder.ToMeshGeometry3D();
        }
    }
}
