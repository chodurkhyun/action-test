using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace CommonUtils
{
    [StructLayout(LayoutKind.Sequential)]
    public struct CamSettings
    {
        public int ScanMode;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)] public string Serial;
        public int OutputResolution;
        [MarshalAs(UnmanagedType.I1)] public bool SendNormalMap;
        public float IsolationDistance;
        public int IsolationMinNeighbors;
        public int TextureExposureMultiplier;
        public float TextureExposure1;
        public float TextureExposure2;
        public float TextureExposure3;
        public float TextureGain1;
        public float TextureGain2;
        public float TextureGain3;
        public int PatternExposureMultiplier;
        public float PatternExposure1;
        public float PatternExposure2;
        public float PatternExposure3;
        public float PatternGain1;
        public float PatternGain2;
        public float PatternGain3;
        public int DecodeThreshold1;
        public int DecodeThreshold2;
        public int DecodeThreshold3;
        public float NormalEstimationRadius; 
        public int SurfaceSmoothness;
        public int PatternStrategy;
        public int StructurePatternType;
        public float MaxNormalAngle;
        public float LedPower;
        public int TextureSource;
        public int PatternColor;

        public CamSettings(Dictionary<CameraAttribute, string> camConfig)
        {
            ScanMode = (int)camConfig[CameraAttribute.ScanMode].ToEnum<CameraScanMode>();
            Serial = camConfig[CameraAttribute.Serial];
            OutputResolution = (int)camConfig[CameraAttribute.OutputResolution].ToEnum<OutputResolution>();
            SendNormalMap = bool.Parse(camConfig[CameraAttribute.SendNormalMap]);
            IsolationDistance = float.Parse(camConfig[CameraAttribute.IsolationDistance]);
            IsolationMinNeighbors = int.Parse(camConfig[CameraAttribute.IsolationMinNeighbors]);
            TextureExposureMultiplier = int.Parse(camConfig[CameraAttribute.TextureExposureMultiplier]);
            TextureExposure1 = float.Parse(camConfig[CameraAttribute.TextureExposure1]);
            TextureExposure2 = float.Parse(camConfig[CameraAttribute.TextureExposure2]);
            TextureExposure3 = float.Parse(camConfig[CameraAttribute.TextureExposure3]);
            TextureGain1 = float.Parse(camConfig[CameraAttribute.TextureGain1]);
            TextureGain2 = float.Parse(camConfig[CameraAttribute.TextureGain2]);
            TextureGain3 = float.Parse(camConfig[CameraAttribute.TextureGain3]);
            PatternExposureMultiplier = int.Parse(camConfig[CameraAttribute.PatternExposureMultiplier]);
            PatternExposure1 = float.Parse(camConfig[CameraAttribute.PatternExposure1]);
            PatternExposure2 = float.Parse(camConfig[CameraAttribute.PatternExposure2]);
            PatternExposure3 = float.Parse(camConfig[CameraAttribute.PatternExposure3]);
            PatternGain1 = float.Parse(camConfig[CameraAttribute.PatternGain1]);
            PatternGain2 = float.Parse(camConfig[CameraAttribute.PatternGain2]);
            PatternGain3 = float.Parse(camConfig[CameraAttribute.PatternGain3]);
            DecodeThreshold1 = int.Parse(camConfig[CameraAttribute.DecodeThreshold1]);
            DecodeThreshold2 = int.Parse(camConfig[CameraAttribute.DecodeThreshold2]);
            DecodeThreshold3 = int.Parse(camConfig[CameraAttribute.DecodeThreshold3]);
            NormalEstimationRadius = float.Parse(camConfig[CameraAttribute.NormalEstimationRadius]);
            SurfaceSmoothness = (int)camConfig[CameraAttribute.SurfaceSmoothness].ToEnum<SurfaceSmoothness>();
            PatternStrategy = (int)camConfig[CameraAttribute.PatternStrategy].ToEnum<PatternStrategy>();
            StructurePatternType = (int)camConfig[CameraAttribute.StructurePatternType].ToEnum<StructurePatternType>();
            MaxNormalAngle = float.Parse(camConfig[CameraAttribute.MaxNomalAngle]);
            LedPower = float.Parse(camConfig[CameraAttribute.LedPower]);
            TextureSource = (int)camConfig[CameraAttribute.TextureSource].ToEnum<TextureSource>();
            PatternColor = (int)camConfig[CameraAttribute.PatternColor].ToEnum<PatternColor>();
        }
    }
}
