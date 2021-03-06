﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Org.Greenrobot.Greendao.Internal
{
    partial class FastCursor
    {
        static IntPtr id_getExtras;
        public unsafe global::Android.OS.Bundle Extras
        {
            // Metadata.xml XPath method reference: path="/api/package[@name='org.greenrobot.greendao.internal']/class[@name='FastCursor']/method[@name='getExtras' and count(parameter)=0]"
            [Register("getExtras", "()Landroid/os/Bundle;", "GetGetExtrasHandler")]
            get
            {
                if (id_getExtras == IntPtr.Zero)
                    id_getExtras = JNIEnv.GetMethodID(class_ref, "getExtras", "()Landroid/os/Bundle;");
                try
                {
                    return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_getExtras), JniHandleOwnership.TransferLocalRef);
                }
                finally
                {
                }
            }
            set
            {
                throw new NotSupportedException();
            }
        }
    }
}
namespace Org.Greenrobot.Greendao.Identityscope
{
    partial class IdentityScopeLong
    {
        public bool Detach(Java.Lang.Object p1, Java.Lang.Object p2)
        {
            return Detach((long)p1, p2);
        }

        public void Put(Java.Lang.Object p1, Java.Lang.Object p2)
        {
            Put((long)p1, p2);
        }

        public void PutNoLock(Java.Lang.Object p1, Java.Lang.Object p2)
        {
            PutNoLock((long)p1, p2);
        }

        public Java.Lang.Object Get(Java.Lang.Object p1)
        {
            return Get((long)p1);
        }

        public Java.Lang.Object GetNoLock(Java.Lang.Object p1)
        {
            return GetNoLock((long)p1);
        }
 
        public void Remove(Java.Lang.Object p1)
        {
            Remove((long)p1);
        }
    }
}