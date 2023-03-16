using System;
using System.Collections.Generic;

namespace ETModel
{
    public static partial class LandUIType
    {
        public const string LandLogin = "LandLogin";
        public const string LandLobby = "LandLobby";
        public const string SetUserInfo = "SetUserInfo";
        public const string LandRoom = "LandRoom";
    }

    public static partial class UIEventType
    {
        public const string LandInitSceneStart = "LandInitSceneStart";
        public const string LandLoginFinished = "LandLoginFinished";
        public const string LandInitLobby = "LandInitLobby";
        public const string LandInitSetUserInfo = "LandInitSetUserInfo";
        public const string LandSetUserInfoFinish = "LandSetUserInfoFinish";

    }

    [Event(UIEventType.LandInitSceneStart)]
    public class InitSceneStart_CreateLandLogin : AEvent
    {
        public override void Run()
        {
            Game.Scene.GetComponent<UIComponent>().Create(LandUIType.LandLogin);
            //Game.Scene.GetComponent<MyTestComponent>().MyTest();
        }
    }

    [Event(UIEventType.LandLoginFinished)]
    public class LandLoginFinished : AEvent
    {
        public override void Run()
        {
            Game.Scene.GetComponent<UIComponent>().Remove(LandUIType.LandLogin);
        }
    }

    [Event(UIEventType.LandInitLobby)]
    public class InitLobby_CreateLandLobby : AEvent
    {
        public override void Run()
        {
            Game.Scene.GetComponent<UIComponent>().Create(LandUIType.LandLobby);
        }
    }

    //初始设置用户信息事件方法
    [Event(UIEventType.LandInitSetUserInfo)]
    public class LandInitUserInfo_CreateSetUserInfo : AEvent
    {
        public override void Run()
        {
            Game.Scene.GetComponent<UIComponent>().Create(LandUIType.SetUserInfo);
        }
    }

    //登录完成移除登录界面事件方法
    [Event(UIEventType.LandSetUserInfoFinish)]
    public class LandSetUserInfoFinish : AEvent
    {
        public override void Run()
        {
            Game.Scene.GetComponent<UIComponent>().Remove(LandUIType.SetUserInfo);

        }
    }

}
