﻿using System;
using System.Security.Permissions;
using System.Web;

namespace AspNet.HtmlControls
{
    [Serializable]
    [AspNetHostingPermission(SecurityAction.LinkDemand, Level = AspNetHostingPermissionLevel.Minimal)]
    public class Quintuple
    {
        /// <summary>
        /// 获取或设置五元数组的第一个 object。
        /// </summary>
        public object First;
        /// <summary>
        /// 获取或设置五元数组的第二个 object。
        /// </summary>
        public object Second;
        /// <summary>
        /// 获取或设置五元数组的第三个 object。
        /// </summary>
        public object Third;
        /// <summary>
        /// 获取或设置五元数组的第四个 object。
        /// </summary>
        public object Fourth;
        /// <summary>
        /// 获取或设置五元数组的第五个 object。
        /// </summary>
        public object Fifth;
        /// <summary>
        /// 初始化 <see cref="T:AspNet.HtmlControls.Quintuple"/> 类的新实例。
        /// </summary>
        public Quintuple()
        {
        }

        /// <summary>
        /// 初始化 <see cref="T:AspNet.HtmlControls.Quintuple"/> 类的新实例，并设置前两个对象。
        /// </summary>
        /// <param name="x">分配给 <see cref="F:AspNet.HtmlControls.Quintuple.First"/> 的对象。</param>
        /// <param name="y">分配给 <see cref="F:AspNet.HtmlControls.Quintuple.Second"/> 的对象。</param>
        public Quintuple(object x, object y)
        {
            First = x;
            Second = y;
        }

        /// <summary>
        /// 使用提供的三个对象初始化 <see cref="T:AspNet.HtmlControls.Quintuple"/> 类的新实例。
        /// </summary>
        /// <param name="x">分配给 <see cref="F:AspNet.HtmlControls.Quintuple.First"/> 的对象。</param>
        /// <param name="y">分配给 <see cref="F:AspNet.HtmlControls.Quintuple.Second"/> 的对象。</param>
        /// <param name="z">分配给 <see cref="F:AspNet.HtmlControls.Quintuple.Third"/> 的对象。</param>
        public Quintuple(object x, object y, object z)
        {
            First = x;
            Second = y;
            Third = z;
        }

        /// <summary>
        /// 使用提供的四个对象初始化 <see cref="T:AspNet.HtmlControls.Quintuple"/> 类的新实例。
        /// </summary>
        /// <param name="a">分配给 <see cref="F:AspNet.HtmlControls.Quintuple.First"/> 的对象。</param>
        /// <param name="b">分配给 <see cref="F:AspNet.HtmlControls.Quintuple.Second"/> 的对象。</param>
        /// <param name="c">分配给 <see cref="F:AspNet.HtmlControls.Quintuple.Third"/> 的对象。</param>
        /// <param name="d">分配给 <see cref="F:AspNet.HtmlControls.Quintuple.Fourth"/> 的对象。</param>
        public Quintuple(object a, object b, object c, object d)
        {
            First = a;
            Second = b;
            Third = c;
            Fourth = d;
        }

        /// <summary>
        /// 使用提供的五个对象初始化 <see cref="T:AspNet.HtmlControls.Quintuple"/> 类的新实例。
        /// </summary>
        /// <param name="a">分配给 <see cref="F:AspNet.HtmlControls.Quintuple.First"/> 的对象。</param>
        /// <param name="b">分配给 <see cref="F:AspNet.HtmlControls.Quintuple.Second"/> 的对象。</param>
        /// <param name="c">分配给 <see cref="F:AspNet.HtmlControls.Quintuple.Third"/> 的对象。</param>
        /// <param name="d">分配给 <see cref="F:AspNet.HtmlControls.Quintuple.Fourth"/> 的对象。</param>
        /// <param name="e">分配给 <see cref="F:AspNet.HtmlControls.Quintuple.Fifth"/> 的对象。</param>
        public Quintuple(object a, object b, object c, object d, object e)
        {
            First = a;
            Second = b;
            Third = c;
            Fourth = d;
            Fifth = e;
        }
    }
}
