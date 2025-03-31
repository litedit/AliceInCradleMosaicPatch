# AliceInCradleMosaicPatch
一个适用于游戏 _Alice In Cradle_ 的去马赛克补丁

__此补丁不受 Alice In Cradle 的官方支持__

# 安装和使用
1. 安装 [BepInEx5](https://github.com/BepInEx/BepInEx/tree/v5-lts)
2. clone 并编译此仓库
3. 将对应文件(AliceInCradleMosaicPatch.dll)复制到 BepInEx\plugins

# 注意
第一次使用时建议先在 DepInEx/config/DepInEx.cfg 中 Enable Logging.Console, 查看插件是否正常工作
<details>
<summary>例如在我的Windows环境上提示缺少 System.Runtime 库, 报错如下</summary>
[Error  : Unity Log] FileNotFoundException: Could not load file or assembly 'System.Runtime, Version=4.2.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a' or one of its dependencies.
Stack trace:
UnityEngine.GameObject:AddComponent(Type)
BepInEx.Bootstrap.Chainloader:Start()
UnityEngine.Application:.cctor()
Fusion.Static:.cctor()
Fusion.NetworkProjectConfig:ResetStatics()
Fusion.NetworkRunner:ResetAllSimulationStatics()
</details>

* 此时把 System.Runtime.dll 连同编译出的插件一起复制到 BepInEx\plugins 即可, 然后重新启动游戏

* 注意 System.Runtime.dll 的出处, 建议使用 dotnet/sdk 的子文件夹中的文件, 其他地方的会报其他错误
