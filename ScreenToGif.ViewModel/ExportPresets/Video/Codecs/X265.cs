using ScreenToGif.Domain.Enums;

namespace ScreenToGif.ViewModel.ExportPresets.Video.Codecs;

public class X265 : VideoCodec
{
    public X265()
    {
        Type = VideoCodecs.X265;
        Name = "x265";
        Command = "libx265";

        CanSetCrf = true;
        MinimumCrf = 0;
        MaximumCrf = 51;
        CodecPresets = new List<EnumItem<VideoCodecPresets>>
        {
            new(VideoCodecPresets.None, "S.SaveAs.VideoOptions.CodecPreset.None", ""),
            new(VideoCodecPresets.Slow, "S.SaveAs.VideoOptions.CodecPreset.Placebo", "placebo"),
            new(VideoCodecPresets.Slow, "S.SaveAs.VideoOptions.CodecPreset.VerySlow", "veryslow"),
            new(VideoCodecPresets.Slow, "S.SaveAs.VideoOptions.CodecPreset.Slower", "slower"),
            new(VideoCodecPresets.Slow, "S.SaveAs.VideoOptions.CodecPreset.Slow", "slow"),
            new(VideoCodecPresets.Medium, "S.SaveAs.VideoOptions.CodecPreset.Medium", "medium"),
            new(VideoCodecPresets.Fast, "S.SaveAs.VideoOptions.CodecPreset.Fast", "fast"),
            new(VideoCodecPresets.Fast, "S.SaveAs.VideoOptions.CodecPreset.Faster", "faster"),
            new(VideoCodecPresets.Fast, "S.SaveAs.VideoOptions.CodecPreset.VeryFast", "veryfast"),
            new(VideoCodecPresets.Fast, "S.SaveAs.VideoOptions.CodecPreset.SuperFast", "superfast"),
            new(VideoCodecPresets.Fast, "S.SaveAs.VideoOptions.CodecPreset.UltraFast", "ultrafast"),
        };
        PixelFormats = new List<EnumItem<VideoPixelFormats>>
        {
            new(VideoPixelFormats.Auto, "S.SaveAs.VideoOptions.PixelFormat.Auto", ""),
            new(VideoPixelFormats.Gbrp, "", "Gbrp", "gbrp"),
            new(VideoPixelFormats.Gbrp10Le, "", "Gbrp10Le", "gbrp10le"),
            new(VideoPixelFormats.Gray, "", "Gray", "gray"),
            new(VideoPixelFormats.Gray10Le, "", "Gray10Le", "gray10le"),
            new(VideoPixelFormats.Yuv420p, "", "Yuv420p", "yuv420p"),
            new(VideoPixelFormats.Yuv422p, "", "Yuv422p", "yuv422p"),
            new(VideoPixelFormats.Yuv444p, "", "Yuv444p", "yuv444p"),
            new(VideoPixelFormats.Yuvj420p, "", "Yuvj420p", "yuvj420p"),
            new(VideoPixelFormats.Yuvj422p, "", "Yuvj422p", "yuvj422p"),
            new(VideoPixelFormats.Yuvj444p, "", "Yuvj444p", "yuvj444p"),
            new(VideoPixelFormats.Yuv420p10Le, "", "Yuv420p10Le", "yuv420p10le"),
            new(VideoPixelFormats.Yuv422p10Le, "", "Yuv422p10Le", "yuv422p10le"),
            new(VideoPixelFormats.Yuv444p10Le, "", "Yuv444p10Le", "yuv444p10le")
        };
    }
}