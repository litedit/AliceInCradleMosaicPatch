# AliceInCradleMosaicPatch
һ����������Ϸ _Alice In Cradle_ ��ȥ�����˲���

__�˲������� Alice In Cradle �Ĺٷ�֧��__

# ��װ��ʹ��
1. ��װ [BepInEx5](https://github.com/BepInEx/BepInEx/tree/v5-lts)
2. clone ������˲ֿ�
3. ����Ӧ�ļ�(AliceInCradleMosaicPatch.dll)���Ƶ� BepInEx\plugins

# ע��
1. ֻ����`��ȫģʽ`����Ϊ __��__ ʱ�˲���Ż���Ч, ��ֻ��������ʱ�����Ϸ����, ��;�޸�������Ч

2. ��һ��ʹ��ʱ�������� DepInEx/config/DepInEx.cfg �� Enable Logging.Console, �鿴����Ƿ���������
<details>
<summary>�������ҵ�Windows��������ʾȱ�� System.Runtime ��, ��������</summary>
[Error  : Unity Log] FileNotFoundException: Could not load file or assembly 'System.Runtime, Version=4.2.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a' or one of its dependencies.
Stack trace:
UnityEngine.GameObject:AddComponent(Type)
BepInEx.Bootstrap.Chainloader:Start()
UnityEngine.Application:.cctor()
Fusion.Static:.cctor()
Fusion.NetworkProjectConfig:ResetStatics()
Fusion.NetworkRunner:ResetAllSimulationStatics()
</details>

* ��ʱ�� System.Runtime.dll ��ͬ������Ĳ��һ���Ƶ� BepInEx\plugins ����, Ȼ������������Ϸ

* ע�� System.Runtime.dll �ĳ���, ����ʹ�� dotnet/sdk �����ļ����е��ļ�, �����ط��Ļᱨ��������
# ����

�ǳ���л�Ҥʤ椢�͘�Ұ�ߤ�����λ��󿪷�����Ϸ  
**ŵ�������̫�ɰ���!**