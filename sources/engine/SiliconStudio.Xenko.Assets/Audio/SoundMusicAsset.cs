﻿// Copyright (c) 2014 Silicon Studio Corp. (http://siliconstudio.co.jp)
// This file is distributed under GPL v3. See LICENSE.md for details.

using SiliconStudio.Assets;
using SiliconStudio.Assets.Compiler;
using SiliconStudio.Core;

namespace SiliconStudio.Xenko.Assets.Audio
{
    [DataContract("SoundMusic")]
    [AssetDescription(FileExtension)]
    [AssetCompiler(typeof(SoundAssetCompiler))]
    [Display(125, "Sound Music")]
    public class SoundMusicAsset : SoundAsset
    {
    }
}
