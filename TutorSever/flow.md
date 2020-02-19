# 导师双向选择系统

## 登陆

### 前端部分

1. 要求输入 __用户名__， __密码__；
选择登陆身份 __学生__， __教师__ 或 __管理员__。

2. 验证密码：__Auth( UserName, PassWord )__；
如果验证通过，返回一个 __Token__，否则返回其他表示错误的结果。

3. 如果是学生：
持续要求输入 __新密码__，直到通过密码强度检查。
更新密码：__UpdatePassword( UserName, Token, NewPassWord )__。

4. 如果不是学生：
直接登陆。

### 后端部分

#### __身份验证 Auth__

```c++
string Auth( string UserName, string PassWord);
```

如果身份验证返回一个 __Token__，否则返回错误或其他。

#### __更新密码 UpdatePassword__

```c++
bool UpdatePassword( string UserName, string Token, string NewPassWord );
```

如果更新密码成功返回 __true__，否则返回 __false__。
