
namespace ETModel
{

    [ObjectSystem]
    public class MyTestComponetAwakeSystem : AwakeSystem<MyTestComponent>
    {
        public override void Awake(MyTestComponent self)
        {
            self.Awake();
        }
    }



    public class MyTestComponent : Component
    {
        public string MyTestString = "";

        public void Awake()
        {
            MyTestString = "Have Awake";
        }

        public void MyTest()
        {
            Log.Debug("Get Component from Through UIEventType");
        }
    }
}
