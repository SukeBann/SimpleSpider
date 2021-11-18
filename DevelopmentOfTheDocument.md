 ---------

## SimpleSpider    
A crawler that allows anyone to simply crawl data from a web page

 ---------

#### 立项时间：2021/11/17 23：17：05
#### 作者 : sukeban 
##### 1052700448@qq.com

 ---------

### module
    
1. spider_config_core
2. database
3. spider_url_core
4. spider_content_core
5. gui
    
整个程序的设计思路为 

spider_config_core 来提供爬虫的爬取规则，规则存放在数据库中存储

1. 提供 url获取规则
2. 提供要内容获取规则
3. 提供存储规则
4. 