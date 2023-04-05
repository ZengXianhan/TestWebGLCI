using UnityEditor;

public class BuildScript
{
    public static void BuildWebGL()
    {
        BuildPipeline.BuildPlayer(new string[] { "Assets/Scenes/SampleScene.unity" }, "Builds/WebGL", BuildTarget.WebGL, BuildOptions.None);
    }
}
