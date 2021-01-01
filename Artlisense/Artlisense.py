import urllib3
import re

# 实例化产生请求对象
http = urllib3.PoolManager()

# get请求指定网址
url = "https://www.asdf.com"
#url="http://www.sohu.com"
res = http.request("GET",url)

# 获取HTTP状态码
print("status:%d" % res.status)

# 获取响应内容
data = res.data#.decode("utf-8")

# 正则解析并输出
print(data)

fo = open("foo.txt", "w")
fo.write("asdfasfsdffsfas")
 
# 关闭打开的文件
fo.close()