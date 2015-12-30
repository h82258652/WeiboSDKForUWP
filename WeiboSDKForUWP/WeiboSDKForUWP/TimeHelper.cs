﻿using System;

namespace WeiboSDKForUWP
{
    /// <summary>
    /// Unix时间戳转换类
    /// </summary>
    internal static class Unix2DateTime
    {
        /// <summary>
        /// 将Unix时间戳转换为DateTime类型时间
        /// </summary>
        /// <param name="timestamp">long型数字</param>
        /// <returns>DateTime</returns>
        internal static DateTime ConvertInt2DateTime(long timestamp)
        {
            var startTime = new DateTime(1970, 1, 1);
            var time = startTime.AddSeconds(timestamp);
            return time;
        }

        /// <summary>
        /// 将DateTime时间格式转换为Unix时间戳格式
        /// </summary>
        /// <param name="time">时间</param>
        /// <returns>long</returns>
        internal static long ConvertDateTime2Unix(DateTime time)
        {
            var startTime = new DateTime(1970, 1, 1);
            var intResult = (time - startTime).TotalSeconds;
            return (long)intResult;
        }

        /// <summary>
        /// 将DateTime时间格式转换为Unix时间戳格式
        /// </summary>
        /// <param name="time">时间</param>
        /// <returns>long</returns>
        internal static long ConvertDateTime2Long(DateTime time)
        {
            var timeStamp = new DateTime(1970, 1, 1);  //得到1970年的时间戳
            var a = (time.ToUniversalTime().Ticks - timeStamp.Ticks) / 10000000;  //注意这里有时区问题，用now就要减掉8个小时
            return a;
        }

        //获取当前时间的时间戳
        internal static long GetUnixTimestamp()
        {
            var timeStamp = new DateTime(1970, 1, 1);  //得到1970年的时间戳
            var a = (DateTime.UtcNow.Ticks - timeStamp.Ticks) / 10000000;  //注意这里有时区问题，用now就要减掉8个小时
            return a;
        }
    }
}