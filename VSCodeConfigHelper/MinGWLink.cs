﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSCodeConfigHelper
{
    class Spec
    {
        public Spec(string official, string disk)
        {
            this.official = official;
            this.disk = disk;
        }
        readonly string official;
        readonly string disk;
        public string getLink(bool isDisk)
        {
            if (isDisk) return disk;
            else return official;
        }
    }

    public class MinGWLink
    {
        readonly Spec win32;
        readonly Spec win64;
        public readonly string standard;
        MinGWLink(string win32official, string win32disk, string win64official, string win64disk, string standard = "c++17")
        {
            win32 = new Spec(win32official, win32disk);
            win64 = new Spec(win64official, win64disk);
            this.standard = standard;
        }
        public string getLink(bool is64, bool isDisk)
        {
            if (is64) return win64.getLink(isDisk);
            else return win32.getLink(isDisk);
        }

        public static readonly MinGWLink official = new MinGWLink(
            @"https://sourceforge.net/projects/mingw-w64/files/Toolchains%20targetting%20Win32/Personal%20Builds/mingw-builds/8.1.0/threads-posix/dwarf/i686-8.1.0-release-posix-dwarf-rt_v6-rev0.7z",
            @"https://wws.lanzous.com/iVdwNge4cde",
            @"https://sourceforge.net/projects/mingw-w64/files/Toolchains%20targetting%20Win64/Personal%20Builds/mingw-builds/8.1.0/threads-posix/seh/x86_64-8.1.0-release-posix-seh-rt_v6-rev0.7z",
            @"https://wws.lanzous.com/iuRLbge4bni"
        );

        public static readonly MinGWLink tdm = new MinGWLink(
            @"https://github.com/jmeubank/tdm-gcc/releases/download/v9.2.0-tdm-1/tdm-gcc-9.2.0.exe",
            @"https://wws.lanzous.com/iRpRjge4r4f",
            @"https://github.com/jmeubank/tdm-gcc/releases/download/v9.2.0-tdm64-1/tdm64-gcc-9.2.0.exe",
            @"https://wws.lanzous.com/iMhd6ge4qkf"
        );

        public static readonly MinGWLink gytx = new MinGWLink(
            @"https://github.com/Guyutongxue/mingw-release/releases/download/v10.2.0/gytx_i686-10.2.0-posix-dwarf.7z",
            @"https://wws.lanzous.com/iubxqge4ffe",
            @"https://github.com/Guyutongxue/mingw-release/releases/download/v10.2.0/gytx_x86_64-10.2.0-posix-seh.7z",
            @"https://wws.lanzous.com/iAj1Zge4fyd",
            "c++20"
        );

    }
}
