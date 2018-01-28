using System;
using System.Collections.Generic;
using System.Text;

namespace NvnNavigator.Common {
    public enum NavigateDirection {
        Forward,
        Backward,
        Left,
        Right
    }

    public enum StartOrEnd {
        Start,
        End
    }

    public enum MapLocationImageType {
        Search,
        CurrentLocation,
        YouAreHere
    }

    public enum FadeType {
        SplitRightToLeft,
        LeftToRight,
        RightToLeft,
        TopToBottom,
        BottomToTop,
        DarkenImage,
        BrightenImage
    }

    public enum GroupType {
        None,
        Floor,
        Category
    }

    public enum DirectionType {
        UpGreen,
        DownGreen,
        LeftGreen,
        RightGreen,
        UpWhite,
        DownWhite,
        LeftWhite,
        RightWhite,
    }

    [Serializable]
    public enum ViewMapLayout {
        ViewOnly,
        MapOnly,
        ViewLeftMapRight,
        ViewRightMapLeft,
        ViewTopMapBottom,
        ViewBottomMapTop
    }

    [Serializable]
    public enum AdLayout {
        Top, Right, Bottom, Left
    }

    public enum ExtendedWindowStyles {
        WS_EX_LAYERED = 0x00080000,
        WS_EX_NOACTIVATE = 0x08000000,
        WS_EX_TOOLWINDOW = 0x00000080,
        WS_EX_TRANSPARENT = 0x00000020,
    }
}