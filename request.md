# Git Worktree 需求

## 目標 1：WeatherForecast 加上查詢筆數參數
**分支名稱：** `feature/weather-count-param`

讓 `GET /weatherforecast` 支援 query string，預設回傳 5 筆，`count` 可由呼叫者指定。

**使用範例：**
```
GET /weatherforecast?count=3
```
---

## 目標 2：新增 `/api/version` 端點
**分支名稱：** `feature/version-api`

在 `SystemController.cs` 新增端點，回傳專案版本與當前環境。

**回傳格式：**
```json
{
  "version": "1.0.0",
  "environment": "Development"
}
```
