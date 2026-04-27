# learn_git

使用 ASP.NET Core Minimal API 建立的範例專案，包含 Swagger UI 與 WeatherForecast API。

---

## 建立專案

```bash
dotnet new webapi -n learn_git
cd learn_git
```

---

## 執行專案

```bash
cd learn_git
dotnet run
```

啟動後開啟瀏覽器前往：

- Swagger UI：`http://localhost:5201/swagger`
- API：`http://localhost:5201/weatherforecast`

---

## 切換 Port

開啟 `Properties/launchSettings.json`，修改 `applicationUrl`：

```json
"applicationUrl": "http://0.0.0.0:8080"
```

或執行時直接指定：

```bash
dotnet run --urls "http://0.0.0.0:8080"
```

> 將 `0.0.0.0` 設為 host 可讓區域網路內其他裝置連入。

---

## 查詢本機 IP（ipconfig）

開啟命令提示字元（CMD）或 PowerShell，輸入：

```bash
ipconfig
```

找到 **乙太網路** 或 **Wi-Fi** 的 `IPv4 位址`，例如：

```
IPv4 位址 . . . . . . . . . . . . : 192.168.1.100
```

其他裝置即可透過 `http://192.168.1.100:5201/weatherforecast` 連入。

---

## 開啟防火牆供外部測試

### 方法一：Windows 防火牆（PowerShell，需系統管理員）

```powershell
New-NetFirewallRule -DisplayName "dotnet dev 5201" `
  -Direction Inbound `
  -Protocol TCP `
  -LocalPort 5201 `
  -Action Allow
```

### 方法二：Windows Defender 防火牆（UI）

1. 開啟「Windows Defender 防火牆」→「進階設定」
2. 點選「輸入規則」→「新增規則」
3. 選擇「連接埠」→ TCP → 輸入 port 號（如 `5201`）
4. 選擇「允許連線」→ 完成

### 測試完畢後移除規則

```powershell
Remove-NetFirewallRule -DisplayName "dotnet dev 5201"
```

> **安全提醒**：測試完畢請記得關閉防火牆規則，避免長期暴露開發伺服器。
