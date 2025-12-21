# VR Vision

##  项目结构
```text
VR Vision
├── _Project        # 主场景及核心配置
├── Scrpit          # 逻辑脚本
├── _Settings       # 项目环境设置
├── AssetRaw        # 原始资源 (模型、贴图原件)
├── Resources       # 动态加载资源
├── Samples         # 自带案例/插件示例
└── Scenes          # 场景目录
    ├── GameScene   # 游戏主场景
    ├── Scene       # 美术地图搭建
    └── UI Scene    # UI 界面搭建
```

## 项目须知
### 一、运行报错说明
项目在运行或编译时会提示 input system XX 相关报错。

原因：项目中包含一个仅支持 iOS 平台 的原生库。

注意点：在 Windows 平台上开发时该报错不影响逻辑编写，但测试与最终发布必须迁移至 macOS (Apple) 环境下进行。

### 二、Vision Pro 开发授权申请
由于使用 Vision Pro 开发需要 Unity Pro 权限，请按照以下步骤操作：

申请途径：

a. 前往 Unity 国际官网申请 30 天免费试用。

b. 国家/地区：请勿选择“中国”（避免强制跳转至国内版）。

c. 地址信息：需填写有效的海外邮编及地址。
