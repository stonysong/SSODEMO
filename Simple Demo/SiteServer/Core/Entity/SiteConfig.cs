﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SiteServer.Core.Entity
{
    public class SiteConfig
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        /// <summary>
        /// client 请求 server 发送的校验 key
        /// </summary>
        public string AppKey { get; set; }
        /// <summary>
        /// server 请求 client 发送的校验 key
        /// </summary>
        public string SiteToken { get; set; }
        public string Host { get; set; }
        /// <summary>
        /// server 请求 client 的回调验证地址
        /// </summary>
        public string AuthCallBack { get; set; }
        /// <summary>
        /// server 请求向 client 端写入登录用户信息的地址
        /// </summary>
        public string AuthSession { get; set; }
        /// <summary>
        /// client 的默认首页地址
        /// </summary>
        public string DefaultIndex { get; set; }
    }
}
