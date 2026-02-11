using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001E4 RID: 484
	public sealed class XmlValueGetter : MulticastDelegate
	{
		// Token: 0x06002864 RID: 10340 RVA: 0x000BBC30 File Offset: 0x000B9E30
		// Note: this type is marked as 'beforefieldinit'.
		static XmlValueGetter()
		{
			Il2CppClassPointerStore<XmlValueGetter>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlValueGetter");
			XmlValueGetter.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueGetter>.NativeClassPtr, 100669136);
			XmlValueGetter.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueGetter>.NativeClassPtr, 100669137);
		}

		// Token: 0x06002865 RID: 10341 RVA: 0x000BBC80 File Offset: 0x000B9E80
		[CallerCount(210)]
		[CachedScanResults(RefRangeStart = 320759, RefRangeEnd = 320969, XrefRangeStart = 320759, XrefRangeEnd = 320969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlValueGetter(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlValueGetter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlValueGetter.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002866 RID: 10342 RVA: 0x000BBCDC File Offset: 0x000B9EDC
		[CallerCount(0)]
		public unsafe Object Invoke()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlValueGetter.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06002867 RID: 10343 RVA: 0x00011146 File Offset: 0x0000F346
		public XmlValueGetter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06002868 RID: 10344 RVA: 0x0001114F File Offset: 0x0000F34F
		public static implicit operator XmlValueGetter(Func<Object> A_0)
		{
			return DelegateSupport.ConvertDelegate<XmlValueGetter>(A_0);
		}

		// Token: 0x06002869 RID: 10345 RVA: 0x00011157 File Offset: 0x0000F357
		public static XmlValueGetter operator +(XmlValueGetter A_0, XmlValueGetter A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<XmlValueGetter>();
		}

		// Token: 0x0600286A RID: 10346 RVA: 0x00011165 File Offset: 0x0000F365
		public static XmlValueGetter operator -(XmlValueGetter A_0, XmlValueGetter A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<XmlValueGetter>();
			}
			return delegate2;
		}

		// Token: 0x04001E72 RID: 7794
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04001E73 RID: 7795
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Object_0;
	}
}
